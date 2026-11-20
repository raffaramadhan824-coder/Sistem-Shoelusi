Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports System.Globalization

Namespace Shoelusi
    Public Module ModuleUtama

        Private ReadOnly Property DatabasePath As String
            Get
                Const databaseName As String = "Database ShoeLusi.mdb"
                Dim executableDir As New DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
                Dim binDir = executableDir.Parent
                If binDir IsNot Nothing AndAlso binDir.Name.Equals("bin", StringComparison.OrdinalIgnoreCase) AndAlso
                   binDir.Parent IsNot Nothing AndAlso File.Exists(Path.Combine(binDir.Parent.FullName, "Shoelusi.vbproj")) Then
                    Return Path.Combine(binDir.Parent.FullName, databaseName)
                End If
                Return Path.Combine(executableDir.FullName, databaseName)
            End Get
        End Property

        Public Function GetConnection() As OleDbConnection
            If Not File.Exists(DatabasePath) Then
                Throw New FileNotFoundException("Database tidak ditemukan: " & DatabasePath, DatabasePath)
            End If

            If (File.GetAttributes(DatabasePath) And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
                Throw New IOException("Database hanya-baca. Buka proyek dari folder yang dapat ditulis: " & DatabasePath)
            End If

            ' Jet membuka MDB Access 2003 pada aplikasi Windows 32-bit.
            ' Coba ACE jika Jet tidak terdaftar pada komputer ini.
            Dim lastProviderError As Exception = Nothing
            For Each provider As String In {"Microsoft.Jet.OLEDB.4.0", "Microsoft.ACE.OLEDB.16.0", "Microsoft.ACE.OLEDB.12.0"}
                Dim settings As New OleDbConnectionStringBuilder()
                settings.Provider = provider
                settings.DataSource = DatabasePath
                Dim cn As New OleDbConnection(settings.ConnectionString)
                Try
                    cn.Open()
                    Return cn
                Catch ex As InvalidOperationException
                    cn.Dispose()
                    lastProviderError = ex
                Catch
                    cn.Dispose()
                    Throw
                End Try
            Next
            Throw New InvalidOperationException("Provider Access tidak tersedia. Gunakan Windows dengan Jet 4.0 atau Microsoft Access Database Engine yang sesuai dengan arsitektur aplikasi.", lastProviderError)
        End Function

        Public Function ReadRows(sql As String, ParamArray values As Object()) As DataTable
            Dim rows As New DataTable()
            Using cn As OleDbConnection = GetConnection()
                Using cmd As New OleDbCommand(sql, cn)
                    AddParameters(cmd, values)
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(rows)
                    End Using
                End Using
            End Using
            Return rows
        End Function

        Public Function ExecuteChange(sql As String, ParamArray values As Object()) As Integer
            Using cn As OleDbConnection = GetConnection()
                Using cmd As New OleDbCommand(sql, cn)
                    AddParameters(cmd, values)
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using
        End Function

        Private Sub AddParameters(cmd As OleDbCommand, values As Object())
            For Each value As Object In values
                Dim name As String = "@p" & cmd.Parameters.Count
                If TypeOf value Is Integer Then
                    cmd.Parameters.Add(name, OleDbType.Integer).Value = value
                ElseIf TypeOf value Is DateTime OrElse Convert.IsDBNull(value) Then
                    cmd.Parameters.Add(name, OleDbType.Date).Value = value
                ElseIf TypeOf value Is Decimal Then
                    cmd.Parameters.Add(name, OleDbType.Currency).Value = value
                Else
                    cmd.Parameters.Add(name, OleDbType.VarWChar, Math.Max(1, CStr(value).Length)).Value = value
                End If
            Next
        End Sub

        Public Function GetAccount(noId As String) As DataRow
            Dim rows = ReadRows("SELECT [No_ID], [Nama], [Divisi], [Kata Sandi] FROM [Data Akun] WHERE [No_ID] = ?", noId)
            If rows.Rows.Count = 0 Then Return Nothing
            Return rows.Rows(0)
        End Function

        Public Function AccountDivision(value As String) As String
            Select Case value.Trim().ToLowerInvariant()
                Case "kasir" : Return "Kasir"
                Case "teknisi" : Return "Teknisi"
                Case "staf gudang" : Return "Staf Gudang"
                Case "pemilik" : Return "Pemilik"
                Case Else : Return String.Empty
            End Select
        End Function

        Public Function TryReadPin(value As String, ByRef pin As Integer) As Boolean
            Return Integer.TryParse(value, NumberStyles.None, CultureInfo.InvariantCulture, pin) AndAlso
                   pin >= 0 AndAlso value = pin.ToString(CultureInfo.InvariantCulture)
        End Function

        Public Function ChangePassword(noId As String, oldPassword As Integer, newPassword As Integer) As Integer
            Return ExecuteChange("UPDATE [Data Akun] SET [Kata Sandi] = ? WHERE [No_ID] = ? AND [Kata Sandi] = ?", newPassword, noId, oldPassword)
        End Function

        Friend Function ExecuteInTransaction(transaction As OleDbTransaction, sql As String, ParamArray values As Object()) As Integer
            Using cmd As New OleDbCommand(sql, transaction.Connection, transaction)
                AddParameters(cmd, values)
                Return cmd.ExecuteNonQuery()
            End Using
        End Function

        Public Sub LoadGrid(grid As DataGridView, sql As String, Optional columnPositions As Integer() = Nothing, Optional keyColumn As Integer = 0)
            Dim table As DataTable = ReadRows(sql)
            grid.Rows.Clear()
            For Each row As DataRow In table.Rows
                Dim values(grid.Columns.Count - 1) As Object
                Dim sourceCount = If(columnPositions Is Nothing, Math.Min(values.Length, table.Columns.Count), columnPositions.Length)
                For index As Integer = 0 To sourceCount - 1
                    Dim value = row(index)
                    If TypeOf value Is DateTime Then
                        value = CDate(value).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                    ElseIf TypeOf value Is Decimal Then
                        value = CDec(value).ToString("0.####", CultureInfo.InvariantCulture)
                    ElseIf Convert.IsDBNull(value) Then
                        value = Nothing
                    End If
                    Dim destination = If(columnPositions Is Nothing, index, columnPositions(index))
                    values(destination) = value
                Next
                Dim displayedRow As DataGridViewRow = grid.Rows(grid.Rows.Add(values))
                displayedRow.Tag = Convert.ToString(row(keyColumn))
            Next
            grid.CurrentCell = Nothing
            grid.ClearSelection()
            ApplySearch(grid)
        End Sub

        Public Sub BindCrud(grid As DataGridView, inputs As Control(), btnAdd As Button, btnUpdate As Button,
                            btnDelete As Button, btnClear As Button, entityName As String, reload As Action,
                            save As Action(Of String, String()), delete As Action(Of String), Optional refreshEditor As Action = Nothing)
            Dim clear As Action = Sub()
                                      grid.CurrentCell = Nothing
                                      grid.ClearSelection()
                                      ClearEditor(inputs)
                                      If refreshEditor IsNot Nothing Then refreshEditor()
                                  End Sub
            Dim saveAction As Action(Of Boolean) =
                Sub(adding)
                    Dim row = ActualSelection(grid)
                    If Not adding AndAlso row Is Nothing Then
                        MessageBox.Show("Pilih data yang ingin diubah.", entityName)
                        Return
                    End If
                    Try
                        save(If(adding, Nothing, CStr(row.Tag)), inputs.Select(AddressOf ReadEditorValue).ToArray())
                    Catch ex As Exception
                        MessageBox.Show("Gagal menyimpan data. " & ex.Message, entityName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End Try
                    RefreshAfterWrite(reload, clear)
                End Sub
            AddHandler btnAdd.Click, Sub(sender, e) saveAction(True)
            AddHandler btnUpdate.Click, Sub(sender, e) saveAction(False)
            AddHandler btnClear.Click, Sub(sender, e) clear()
            AddHandler btnDelete.Click,
                Sub(sender, e)
                    Dim row = ActualSelection(grid)
                    If row Is Nothing Then Return
                    If MessageBox.Show("Hapus " & entityName & " yang dipilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                    Try
                        delete(CStr(row.Tag))
                    Catch ex As Exception
                        MessageBox.Show("Gagal menghapus data. " & ex.Message, entityName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End Try
                    RefreshAfterWrite(reload, clear)
                End Sub
            AddHandler grid.CurrentCellChanged,
                Sub(sender, e)
                    Dim row = grid.CurrentRow
                    If row Is Nothing Then
                        Return
                    End If
                    For index As Integer = 0 To inputs.Length - 1
                        SetEditorValue(inputs(index), Convert.ToString(row.Cells(index).Value))
                    Next
                    If refreshEditor IsNot Nothing Then refreshEditor()
                End Sub
            ClearEditor(inputs)
        End Sub

        Friend Sub RefreshAfterWrite(reload As Action, Optional clear As Action = Nothing)
            Try
                reload()
                If clear IsNot Nothing Then clear()
            Catch ex As Exception
                MessageBox.Show("Perubahan tersimpan di database, tetapi tabel gagal dimuat ulang. " & ex.Message, "Muat Ulang Data")
            End Try
        End Sub

        Friend Function ActualSelection(grid As DataGridView) As DataGridViewRow
            Dim row = grid.CurrentRow
            If row Is Nothing OrElse Not row.Selected Then Return Nothing
            Return row
        End Function

        Private Function ReadEditorValue(input As Control) As String
            Dim picker = TryCast(input, DateTimePicker)
            If picker Is Nothing Then Return input.Text.Trim()
            If picker.ShowCheckBox AndAlso Not picker.Checked Then Return ""
            Return DateText(picker.Value)
        End Function

        Private Sub SetEditorValue(input As Control, value As String)
            Dim picker = TryCast(input, DateTimePicker)
            If picker Is Nothing Then
                input.Text = value
                Return
            End If
            Dim parsed As DateTime
            Dim hasDate = TryReadDate(value, parsed)
            picker.Value = If(hasDate, parsed, DateTime.Today)
            If picker.ShowCheckBox Then picker.Checked = hasDate
        End Sub

        Private Sub ClearEditor(inputs As Control())
            For Each input In inputs
                SetEditorValue(input, "")
            Next
        End Sub

        Public Sub ClearInputs(inputs As TextBox())
            For Each t In inputs
                t.Clear()
            Next
        End Sub

        Public Sub BindSearch(grid As DataGridView, Optional txt As TextBox = Nothing)
            If txt Is Nothing Then
                Dim label As New Label With {.Text = "Cari", .AutoSize = True, .Font = grid.Font}
                txt = New TextBox With {.AccessibleName = "Cari " & grid.Name, .Font = grid.Font, .Width = Math.Min(300, grid.Width - 70)}
                Dim top = grid.Top
                label.Location = New Drawing.Point(grid.Left, top + 3)
                txt.Location = New Drawing.Point(grid.Left + label.GetPreferredSize(Drawing.Size.Empty).Width + 10, top)
                grid.Parent.Controls.Add(label)
                grid.Parent.Controls.Add(txt)
                Dim offset = txt.Height + 7
                grid.SetBounds(grid.Left, top + offset, grid.Width, grid.Height - offset)
            End If
            grid.Tag = txt
            AddHandler txt.TextChanged, Sub(sender, e) ApplySearch(grid)
        End Sub

        Friend Sub ApplySearch(grid As DataGridView)
            Dim txt = TryCast(grid.Tag, TextBox)
            If txt Is Nothing Then Return
            Dim key = txt.Text.Trim()
            Dim current = grid.CurrentRow
            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Continue For
                Dim matches = key.Length = 0 OrElse row.Cells.Cast(Of DataGridViewCell)().
                    Any(Function(cell) cell.OwningColumn.Visible AndAlso Convert.ToString(cell.Value).IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                If Not matches AndAlso row Is current Then
                    grid.CurrentCell = Nothing
                    grid.ClearSelection()
                End If
                row.Visible = matches
            Next
        End Sub

    End Module
End Namespace
