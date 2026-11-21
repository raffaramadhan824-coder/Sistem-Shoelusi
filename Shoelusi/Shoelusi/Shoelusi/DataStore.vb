Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Shoelusi
    Friend Module DataStore
        Friend Const Materials As String = "Data_Bahan_Baku"
        Friend Const Stock As String = "Data_Persediaan"
        Friend Const Purchases As String = "Data_Pengadaan_Bahan_Baku"
        Friend Const MaterialUse As String = "Data_Penggunaan_Bahan_Baku"
        Friend Const Services As String = "Data_Layanan"
        Friend Const Orders As String = "Data_Pemesanan"
        Friend Const Sales As String = "Data_Penjualan"
        Friend Const Jobs As String = "Data_Pengerjaan"

        Friend Const SelectMaterials As String =
            "SELECT b.Kode_Bahan_Baku, b.Nama_Bahan_Baku, s.Jumlah_Stok_Bahan_Baku, b.Satuan, b.Stok_Minimum, b.Jenis_Bahan_Baku, b.Harga_Acuan " &
            "FROM Data_Bahan_Baku AS b LEFT JOIN Data_Persediaan AS s ON b.Kode_Bahan_Baku = s.Kode_Bahan_Baku ORDER BY b.Kode_Bahan_Baku"

        Friend Const SelectPurchases As String =
            "SELECT p.Kode_Pengadaan, p.Tanggal_Pengadaan, p.Kode_Bahan_Baku, p.Jumlah_Pembelian, p.Status_Pengadaan, p.Harga_Satuan, b.Nama_Bahan_Baku, p.Subtotal_Pembelian " &
            "FROM Data_Pengadaan_Bahan_Baku AS p INNER JOIN Data_Bahan_Baku AS b ON p.Kode_Bahan_Baku = b.Kode_Bahan_Baku ORDER BY p.Kode_Pengadaan"

        Friend Const SelectApprovals As String =
            "SELECT p.Kode_Pengadaan, p.Tanggal_Pengadaan, b.Nama_Bahan_Baku, p.Subtotal_Pembelian, p.Status_Pengadaan " &
            "FROM Data_Pengadaan_Bahan_Baku AS p INNER JOIN Data_Bahan_Baku AS b ON p.Kode_Bahan_Baku = b.Kode_Bahan_Baku ORDER BY p.Kode_Pengadaan"

        Friend Const SelectUsage As String =
            "SELECT u.Tanggal_Penggunaan, u.Kode_Pengerjaan, u.Kode_Bahan_Baku, b.Nama_Bahan_Baku, u.Jumlah_Penggunaan, b.Satuan, u.Kondisi_Bahan_Baku, u.Kode_Penggunaan " &
            "FROM Data_Penggunaan_Bahan_Baku AS u INNER JOIN Data_Bahan_Baku AS b ON u.Kode_Bahan_Baku = b.Kode_Bahan_Baku ORDER BY u.Kode_Penggunaan"

        Friend Const SelectWarehouseUsage As String =
            "SELECT u.Tanggal_Penggunaan, u.Kode_Pengerjaan, b.Nama_Bahan_Baku, u.Jumlah_Penggunaan, b.Satuan, u.Kondisi_Bahan_Baku, u.Kode_Penggunaan " &
            "FROM Data_Penggunaan_Bahan_Baku AS u INNER JOIN Data_Bahan_Baku AS b ON u.Kode_Bahan_Baku = b.Kode_Bahan_Baku ORDER BY u.Kode_Penggunaan"

        Friend Const SelectSales As String =
            "SELECT Kode_Penjualan, Kode_Pemesanan, Tanggal_Pengambilan, Total_Biaya, Status_Pembayaran, Jumlah_Sepatu, Harga_Layanan_Transaksi FROM Data_Penjualan ORDER BY Kode_Penjualan"

        Friend Const SelectSalesSummary As String =
            "SELECT Kode_Penjualan, Tanggal_Pengambilan, Kode_Pemesanan, Total_Biaya, Status_Pembayaran FROM Data_Penjualan ORDER BY Kode_Penjualan"

        Friend Const SelectOrders As String =
            "SELECT o.Kode_Pesanan, o.Nama_Konsumen, o.Kode_Layanan, o.Tanggal_Pemesanan, o.Status_Pesanan, l.Nama_Layanan " &
            "FROM Data_Pemesanan AS o INNER JOIN Data_Layanan AS l ON o.Kode_Layanan = l.Kode_Layanan ORDER BY o.Kode_Pesanan"

        Friend Const SelectOrderSummary As String =
            "SELECT o.Kode_Pesanan, o.Nama_Konsumen, l.Nama_Layanan, o.Keluhan, o.Tanggal_Pemesanan, o.Status_Pesanan " &
            "FROM Data_Pemesanan AS o INNER JOIN Data_Layanan AS l ON o.Kode_Layanan = l.Kode_Layanan ORDER BY o.Kode_Pesanan"

        Friend Const SelectServices As String =
            "SELECT Kode_Layanan, Nama_Layanan, Jenis_Layanan, Harga_Layanan, Estimasi_Pengerjaan FROM Data_Layanan ORDER BY Kode_Layanan"

        Friend Const SelectJobs As String =
            "SELECT Kode_Pengerjaan, Kode_Pesanan, Tanggal_Mulai, Tanggal_Selesai, Status_Pengerjaan FROM Data_Pengerjaan ORDER BY Kode_Pengerjaan"

        Friend Const SelectJobSummary As String =
            "SELECT j.Kode_Pengerjaan, j.Kode_Pesanan, a.Nama, j.Tanggal_Mulai, j.Tanggal_Selesai, j.Status_Pengerjaan " &
            "FROM Data_Pengerjaan AS j LEFT JOIN [Data Akun] AS a ON j.No_ID = a.No_ID ORDER BY j.Kode_Pengerjaan"

        Friend Const SelectEoq As String =
            "SELECT b.Nama_Bahan_Baku, s.Permintaan_Tahunan, s.Biaya_Pemesanan, s.Biaya_Penyimpanan, s.Nilai_EOQ, s.Kode_Bahan_Baku " &
            "FROM Data_Persediaan AS s INNER JOIN Data_Bahan_Baku AS b ON s.Kode_Bahan_Baku = b.Kode_Bahan_Baku " &
            "ORDER BY s.Kode_Bahan_Baku"

        Friend Const SelectRop As String =
            "SELECT b.Nama_Bahan_Baku, s.Permintaan_Harian, s.Permintaan_Harian_Maksimum, s.Lead_Time, s.Lead_Time_Maksimum, s.Safety_Stock, s.Nilai_ROP, s.Kode_Bahan_Baku " &
            "FROM Data_Persediaan AS s INNER JOIN Data_Bahan_Baku AS b ON s.Kode_Bahan_Baku = b.Kode_Bahan_Baku " &
            "ORDER BY s.Kode_Bahan_Baku"

        Friend Function RequireCode(value As String, prefix As String) As String
            Dim normalized = value.Trim().ToUpperInvariant()
            If Not Regex.IsMatch(normalized, "\A" & prefix & "[0-9]{3,12}\z") Then
                Throw New ArgumentException("Gunakan kode dengan awalan " & prefix & " dan minimal tiga angka, misalnya " & prefix & "001.")
            End If
            Return normalized
        End Function

        Friend Function RequireText(value As String, label As String) As String
            If String.IsNullOrWhiteSpace(value) Then Throw New ArgumentException("Isi " & label & ".")
            Return value.Trim()
        End Function

        Friend Function TryReadDate(value As String, ByRef parsed As DateTime) As Boolean
            Return DateTime.TryParseExact(value, {"d/M/yyyy", "yyyy-MM-dd"}, CultureInfo.InvariantCulture, DateTimeStyles.None, parsed)
        End Function

        Friend Function RequireDate(value As String) As DateTime
            Dim parsed As DateTime
            If Not TryReadDate(value, parsed) Then Throw New ArgumentException("Pilih tanggal yang valid.")
            Return parsed
        End Function

        Friend Function TryReadAmount(value As String, ByRef parsed As Decimal) As Boolean
            Return Decimal.TryParse(value.Replace(","c, "."c), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, parsed) AndAlso parsed >= 0D
        End Function

        Friend Function RequireAmount(value As String, label As String, Optional allowZero As Boolean = False) As Decimal
            Dim parsed As Decimal
            If Not TryReadAmount(value, parsed) OrElse (parsed = 0D AndAlso Not allowZero) Then
                Throw New ArgumentException("Isi " & label & " dengan angka yang sesuai.")
            End If
            Return parsed
        End Function

        Friend Function PreviewTotal(quantity As Decimal, price As Decimal) As String
            If price > 1D AndAlso quantity > Decimal.MaxValue / price Then Return ""
            Return DecimalText(quantity * price)
        End Function

        Friend Function DecimalText(value As Decimal) As String
            Return value.ToString(CultureInfo.InvariantCulture)
        End Function

        Friend Function DateText(value As DateTime) As String
            Return value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        End Function

        Friend Sub SaveRecord(table As String, key As String, previousCode As String, code As String,
                              columns As String(), values As Object(), Optional transaction As OleDbTransaction = Nothing)
            If previousCode IsNot Nothing AndAlso Not String.Equals(code, previousCode, StringComparison.OrdinalIgnoreCase) Then
                Throw New ArgumentException("Kode utama tidak dapat diubah. Gunakan Bersihkan untuk menambah kode baru.")
            End If
            Dim sql As String
            Dim parameters As Object()
            If previousCode Is Nothing Then
                sql = "INSERT INTO [" & table & "] ([" & key & "], [" & String.Join("], [", columns) & "]) VALUES (" &
                      String.Join(", ", Enumerable.Repeat("?", columns.Length + 1)) & ")"
                parameters = {code}
                parameters = parameters.Concat(values).ToArray()
            Else
                sql = "UPDATE [" & table & "] SET " & String.Join(", ", columns.Select(Function(column) "[" & column & "] = ?")) &
                      " WHERE [" & key & "] = ?"
                parameters = values.Concat(New Object() {previousCode}).ToArray()
            End If
            Dim changed = If(transaction Is Nothing, ExecuteChange(sql, parameters), ExecuteInTransaction(transaction, sql, parameters))
            If changed <> 1 Then Throw New InvalidOperationException("Data yang dipilih sudah tidak tersedia.")
        End Sub

        Friend Sub DeleteRecord(table As String, key As String, code As String)
            If ExecuteChange("DELETE FROM [" & table & "] WHERE [" & key & "] = ?", code) <> 1 Then
                Throw New InvalidOperationException("Data yang dipilih sudah tidak tersedia.")
            End If
        End Sub
    End Module
End Namespace
