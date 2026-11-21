DATABASE SHOELUSI

Database ShoeLusi.mdb adalah file Microsoft Access 2003.
Saat dijalankan melalui proyek Visual Studio, Debug dan Release membuka file
Database ShoeLusi.mdb di folder yang sama dengan Shoelusi.vbproj. File ini
bisa dibuka dengan Microsoft Access untuk melihat perubahan para aktor.
Jalankan dari folder hasil ekstrak yang dapat ditulis. Build tidak menyalin
atau mengganti MDB. Jika menyalin EXE untuk dipakai tanpa folder proyek,
letakkan MDB revisi di folder yang sama dengan EXE.

Isi database
- Data Akun, 4 akun awal
- Data_Layanan, 14 layanan
- Data_Bahan_Baku, 7 bahan dan alat
- Data_Pemesanan, 8 pesanan dengan referensi akun kasir
- Data_Penjualan, 8 transaksi dengan total berdasarkan tarif dan jumlah sepatu
- Data_Pengadaan_Bahan_Baku, 8 pengadaan, termasuk satu pengadaan menunggu
- Data_Penggunaan_Bahan_Baku, 8 pemakaian terkait transaksi penjualan
- Data_Persediaan, 7 saldo stok awal dari pengadaan diterima dikurangi pemakaian
- Data_Pengerjaan, 8 catatan demonstrasi berdasarkan pesanan dan pemakaian
  yang sudah tersedia

Biaya, jumlah, kondisi, tanggal tambahan, pengadaan, dan saldo stok di atas
menggunakan asumsi untuk demonstrasi. Status dan tanggal pengerjaan awal juga
menggunakan asumsi.

Sumber tampilan
- Gudang: Persediaan dan parameter EOQ/ROP menggunakan Data_Persediaan.
  Riwayat pengadaan menggunakan Data_Pengadaan_Bahan_Baku.
  Cek Penggunaan dan Cek Penjualan memakai tabel transaksi masing-masing.
- Kasir: Pemesanan, Penjualan, Layanan, dan Pengerjaan bersumber dari Access.
- Teknisi: Cek Pesanan, Pengerjaan, dan Penggunaan Bahan Baku memakai Access.
- Pemilik: Data Akun, Pengadaan, Layanan, dan Penjualan memakai Access.

Kode kunci: SL (akun), BB (bahan), ST (persediaan), LY (layanan), PM (pesanan),
PJ (penjualan), PB (pengadaan), PG (pengerjaan), dan PU (penggunaan).
Kode BB dan PU lama diubah dari angka menjadi teks berawalan. Access
menolak kode utama ganda dan referensi yang tidak ditemukan. Kode persediaan
dan kode penggunaan terisi otomatis saat dibuat melalui aplikasi.

Tombol Tambah, Ubah, Hapus, dan persetujuan pengadaan menyimpan ke Access.
Pilih baris untuk mengubah atau menghapus data. Isian tanggal memakai kalender.
Ketik di kotak Cari untuk menyaring tabel. Hapus teks untuk menampilkan semua.

Harga dan perhitungan
- Pengadaan: isi kode bahan dan jumlah. Harga acuan di tab Persediaan dan
  subtotal terisi otomatis. Harga pada transaksi lama dipertahankan.
- Penjualan: isi kode pesanan dan jumlah sepatu (pasang). Total mengikuti
  tarif layanan per pasang. Tarif transaksi lama dipertahankan.
- EOQ dan ROP: pilih bahan baku pada daftar perhitungan. Parameter dan hasil
  disimpan pada satu baris Data_Persediaan untuk setiap Kode_Bahan_Baku.
  EOQ memakai permintaan tahunan, biaya pemesanan, dan biaya penyimpanan.
  ROP memakai pemakaian harian, lead time, dan safety stock.
- Pengadaan baru berstatus Menunggu dan harus disetujui Pemilik. Saat Gudang
  mengubah status Disetujui menjadi Diterima, jumlah pembelian otomatis
  ditambahkan ke saldo Data_Persediaan. Penerimaan tidak dilakukan dua kali.
- Saat Teknisi menambah pemakaian bahan, stok otomatis berkurang. Saat catatan
  pemakaian diubah atau dihapus, saldo stok disesuaikan dalam transaksi database.

Harga bahan baku di bawah ini adalah estimasi acuan dalam rupiah per satuan
database, dibulatkan dari contoh penawaran publik dan dapat diedit di Persediaan.
- BB001 Sabun Pembersih Sepatu, Rp95.000/liter. Acuan pembersih 1 liter
  Rp98.950 di Shopee.
  https://shopee.co.id/search?category=11042985&keyword=sabun+cuci&subcategory=11043002
- BB002 Sikat Sepatu, Rp7.000/buah. Acuan sikat semir kayu Rp4.999–Rp6.999.
  https://shopee.co.id/SIKAT-SEMIR-SEPATU-SIKAT-KAYU-HARGA-1-PIECES-TERSEDIA-UKURAN-KECIL-DAN-BESAR-i.18746984.20852624341
- BB003 Cat Sepatu, Rp45.000/kaleng atau kemasan setara 100 ml.
  Acuan cat kanvas/kulit 100 ml Rp43.512.
  https://shopee.co.id/list/Spotless/Shoe%20Cleaner
- BB004 Lem Sepatu, Rp9.000/tube. Acuan Fox Plus 20 g Rp8.255.
  https://www.blibli.com/p/lem-fox-plus-tube-original-20g-lem-kuning-karet-kulit-sepatu-tube-merah-20g/ps--OHM-60022-01604
- BB005 Benang Jahit, Rp5.000/gulung. Acuan benang nilon sol satu gulung.
  https://www.blibli.com/p/baru-benang-jahit-sol-sepatu-benang-nylon-coklat-terbatas/ps--SUJ-60037-00573
- BB006 Sol Sepatu, Rp37.000/pasang sebagai asumsi anggaran.
  Acuan listing outsole karet Rp37.000, isi kemasan tidak dinyatakan.
  https://shopee.co.id/sol-sepatu-safety-karet-outsole-i.15633908.2917780260
- BB007 Amplas Halus, Rp3.500/lembar. Acuan amplas grit 400 Rp3.150.
  https://www.blibli.com/jual/amplas-halus-per-lembar

Katalog layanan: Linktree ShoeLusi memuat kontak dan lokasi cabang.
Nama, jenis, dan harga layanan yang sudah ada tetap digunakan sebagai
data proyek yang belum terverifikasi dari daftar tarif resmi.
https://linktr.ee/shoelusi
