using Microsoft.VisualBasic.Devices;
using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Admin.Buku;
using Projek_SimBuku.Views.Admin.Transaksi;
using Projek_SimBuku.Views.Buku;
using Projek_SimBuku.Views.Pelanggan;
using Projek_SimBuku.Views.Pelanggan.Riwayat;
using Projek_SimBuku.Views.Pelanggan.Transaksi;
using Projek_SimBuku.Views.Peminjaman;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projek_SimBuku.Controller.C_Transaksi;
using static System.Runtime.InteropServices.JavaScript.JSType;
using QRCoder;

namespace Projek_SimBuku.Controller
{
    public class C_Transaksi : Connector
    {
        C_Homepage chomepage;
        C_Keranjang cKeranjang;
        Transaksi vtransaksi;
        RiwayatPelanggan vriwayatPelanggan;
        BuatTransaksi vbuatTransaksi;
        FormTransaksi vForm;
        DetailTransaksiPelanggan vdetailTransaksiPelanggan;
        public DetailTransaksi ? vdetail;
        M_Transaksi m_transaksi = new M_Transaksi();
        public C_Transaksi(C_Homepage homepage, Transaksi transaksi)
        {
            chomepage = homepage;
            vtransaksi = transaksi;
        }
        public C_Transaksi(C_Homepage homepage, RiwayatPelanggan view)
        {
            chomepage = homepage;
            vriwayatPelanggan = view;
        }
        public C_Transaksi(FormTransaksi formTransaksi)
        {
            vForm = formTransaksi;
        }
        public List<M_Transaksi> GetDataTransaksi()
        {
            List<M_Transaksi> transaksi = new List<M_Transaksi>();
            DataTable data = Execute_With_Return("SELECT t.id_transaksi ,t.id_akun ,t.id_buku ,t.tanggal_transaksi, t.status, t.harga_sewa, t.harga_denda, t.tanggal_pengambilan, t.tanggal_pengembalian, a.nama, b.judul_buku, mp.metode " +
           "FROM transaksi t " +
           "JOIN data_akun a ON t.id_akun = a.id_akun " +
           "JOIN buku b ON t.id_buku = b.id_buku " +
           "JOIN metode_pembayaran mp ON t.id_metode_pembayaran = mp.id_metode_pembayaran WHERE t.status = 'Kembali';");


            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Transaksi m_transaksi = new M_Transaksi
                {
                    id_transaksi = Convert.ToInt32(data.Rows[i]["id_transaksi"]),
                    id_akun = Convert.ToInt32(data.Rows[i]["id_akun"]),
                    Id_Buku = Convert.ToInt32(data.Rows[i]["id_buku"]),
                    nama = data.Rows[i]["nama"].ToString(),
                    tanggal_transaksi = data.Rows[i]["tanggal_transaksi"].ToString(),
                    judul_buku = data.Rows[i]["judul_buku"].ToString(),
                    harga_sewa = Convert.ToDecimal(data.Rows[i]["harga_sewa"]),
                    metode = data.Rows[i]["metode"].ToString(),
                    harga_denda = data.Rows[i]["harga_denda"] == DBNull.Value ? 0 : Convert.ToDecimal(data.Rows[i]["harga_denda"]),
                    status = data.Rows[i]["status"].ToString(),
                    tanggal_pengambilan = data.Rows[i]["tanggal_pengambilan"] == DBNull.Value ? null : data.Rows[i]["tanggal_pengambilan"].ToString(),
                    tanggal_pengembalian = data.Rows[i]["tanggal_pengembalian"] == DBNull.Value ? null : data.Rows[i]["tanggal_pengembalian"].ToString()
                };
                transaksi.Add(m_transaksi);
            }
            return transaksi;
        }
        public void LoadData()
        {
            vtransaksi.dataTransaksi.DataSource = null;
            vtransaksi.dataTransaksi.Columns.Clear();

            DataGridViewButtonColumn Detail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                UseColumnTextForButtonValue = true,
                Text = "Detail",
                HeaderText = ""
            };

            vtransaksi.dataTransaksi.DataSource = GetDataTransaksi(); 

            vtransaksi.dataTransaksi.Columns["id_transaksi"].Visible = false;
            vtransaksi.dataTransaksi.Columns["id_akun"].Visible = false;  
            vtransaksi.dataTransaksi.Columns["Id_Buku"].Visible = false;  
            vtransaksi.dataTransaksi.Columns["metode"].Visible = false;
            vtransaksi.dataTransaksi.Columns["harga_denda"].Visible = false;
            vtransaksi.dataTransaksi.Columns["status"].Visible = false;
            vtransaksi.dataTransaksi.Columns["tanggal_pengambilan"].Visible = false;
            vtransaksi.dataTransaksi.Columns["tanggal_pengembalian"].Visible = false;
            vtransaksi.dataTransaksi.Columns["nama"].HeaderText = "Nama Pelanggan";
            vtransaksi.dataTransaksi.Columns["tanggal_transaksi"].HeaderText = "Tanggal Transaksi"; 
            vtransaksi.dataTransaksi.Columns["judul_buku"].HeaderText = "Buku";
            vtransaksi.dataTransaksi.Columns["harga_sewa"].HeaderText = "Harga Sewa";

            vtransaksi.dataTransaksi.Columns.Add(Detail);
            vtransaksi.dataTransaksi.Refresh();
        }
        public void SearchTransaksi(string keyword)
        {
            var filteredData = GetDataTransaksi().Where(b =>
            b.judul_buku.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            b.nama.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            vtransaksi.dataTransaksi.DataSource = null;
            vtransaksi.dataTransaksi.Columns.Clear();

            vtransaksi.dataTransaksi.DataSource = filteredData;

            vtransaksi.dataTransaksi.Columns["id_transaksi"].Visible = false;
            vtransaksi.dataTransaksi.Columns["id_akun"].Visible = false;
            vtransaksi.dataTransaksi.Columns["Id_Buku"].Visible = false;
            vtransaksi.dataTransaksi.Columns["metode"].Visible = false;
            vtransaksi.dataTransaksi.Columns["harga_denda"].Visible = false;
            vtransaksi.dataTransaksi.Columns["status"].Visible = false;
            vtransaksi.dataTransaksi.Columns["tanggal_pengambilan"].Visible = false;
            vtransaksi.dataTransaksi.Columns["tanggal_pengembalian"].Visible = false;
            vtransaksi.dataTransaksi.Columns["nama"].HeaderText = "Nama Pelanggan";
            vtransaksi.dataTransaksi.Columns["tanggal_transaksi"].HeaderText = "Tanggal Transaksi";
            vtransaksi.dataTransaksi.Columns["judul_buku"].HeaderText = "Buku";
            vtransaksi.dataTransaksi.Columns["harga_sewa"].HeaderText = "Harga Sewa";
        }

        public void Durasi(BuatTransaksi view)
        {
            var data = new List<dynamic>
            {
                new { value = 1, hari = "1 Hari" },
                new { value = 2, hari = "2 Hari" },
                new { value = 3, hari = "3 Hari" }
            };
            view.comboBox1.DataSource = data;
            view.comboBox1.DisplayMember = "hari";
            view.comboBox1.ValueMember = "value";
            view.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Validasi_Transaksi(BuatTransaksi view)
        {
            if (view.E_wallet.Checked)
            {
                FormTransaksi View = new FormTransaksi(this, new Ewallet(this));
                View.ShowDialog();
            }
            else if (view.Transfer.Checked)
            {
                FormTransaksi View = new FormTransaksi(this, new Transfer(this));
                View.ShowDialog();
            }
            else if (view.Tunai.Checked)
            {
                FormTransaksi View = new FormTransaksi(this, new Bukti_Pembayaran(this));
                View.ShowDialog();
            }
        }
        private int GetTotalBukuBelumDikembalikan(int idAkun)
        {
            string query = $"SELECT COUNT(*) FROM transaksi WHERE id_akun = {idAkun} AND status != 'Dikembalikan';";
            DataTable result = Execute_With_Return(query);
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0][0]) : 0;
        }
        public void UpdateStok(int id)
        {
            Execute_No_Return($"UPDATE buku SET stok = stok - 1 WHERE id_buku = {id}");
        }
        public void Buat_transaks(BuatTransaksi view)
        {
            if (!M_Keranjang.StaticCartItems.Any())
            {
                MessageBox.Show("Pilih buku yang akan disewa");
                return;
            }
            int totalBukuDipinjam = GetTotalBukuBelumDikembalikan(M_Sementara.id);
            if (totalBukuDipinjam >= 3)
            {
                MessageBox.Show("Anda masih memiliki 3 buku yang belum dikembalikan. Silakan kembalikan buku terlebih dahulu.");
                return;
            }
            if (totalBukuDipinjam + M_Keranjang.StaticCartItems.Count > 3)
            {
                MessageBox.Show("Maksimal 3 buku per akun. Kurangi jumlah buku yang ingin dipinjam.");
                return;
            }

            foreach (var item in M_Keranjang.StaticCartItems)
            {
                transaksi transaksi = new transaksi();

                RadioButton selectedRadioButton = view.metode_pembayaran.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
                if (selectedRadioButton != null)
                {
                    transaksi.id_metode = Convert.ToInt32(selectedRadioButton.Tag);
                }
                else
                {
                    MessageBox.Show("Pilih metode pembayaran");
                    return;
                }

                transaksi.id_buku = item.Id_Buku;

                if (view.comboBox1.SelectedItem != null)
                {
                    dynamic selectedItem = view.comboBox1.SelectedValue;
                    transaksi.durasi = Convert.ToInt32(selectedItem);
                }
                else
                {
                    MessageBox.Show("Pilih durasi peminjaman");
                    return;
                }

                if (view.dateTimePicker1.Value == null)
                {
                    MessageBox.Show("Pilih tanggal pengambilan");
                    return;
                }
                else
                {
                    transaksi.Pengambilan = view.dateTimePicker1.Value;
                }

                transaksi.Pengembalian = transaksi.Pengambilan.AddDays(transaksi.durasi);

                decimal hargaSewaPerBuku = 10000;
                transaksi.harga_sewa = (int)(hargaSewaPerBuku * transaksi.durasi);

                if (transaksi.harga_sewa <= 0)
                {
                    MessageBox.Show("Harga sewa tidak valid.");
                    return;
                }
                Insert(transaksi, M_Sementara.id);
            }
        }
        public void UbahStatusTransaksi()
        {
            string query = $"UPDATE transaksi SET status = 'Lunas' Where id_akun = {M_Sementara.id};";
            Execute_No_Return(query);
            foreach (var item in M_Keranjang.StaticCartItems)
            {
                int id_buku = item.Id_Buku;
                UpdateStok(id_buku);
            }
            M_Keranjang.StaticCartItems.Clear();
        }

        public void Insert(object obj, int id)
        {
            transaksi transaksi = obj as transaksi;
            if (transaksi == null || transaksi.durasi <= 0 || transaksi.id_metode <= 0)
            {
                MessageBox.Show("Data transaksi tidak valid.");
                return;
            }
            string query = $"INSERT INTO transaksi (id_akun, id_buku, id_metode_pembayaran, tanggal_pengambilan, tanggal_pengembalian, harga_sewa, status, harga_denda) " +
                           $"VALUES ({id}, {transaksi.id_buku}, {transaksi.id_metode}, '{transaksi.Pengambilan:yyyy-MM-dd}', '{transaksi.Pengembalian:yyyy-MM-dd}', {transaksi.harga_sewa}, 'Belum Dibayar', null);";
            try
            {
                Execute_No_Return(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public class transaksi
        {
            public int id_buku { get; set; }
            public int id_metode { get; set; }
            public int durasi { get; set; }
            public DateTime Pengambilan { get; set; }
            public DateTime Pengembalian { get; set; }
            public int harga_sewa {  get; set; }
        }

        public List<M_Transaksi> GetRiwayatTransaksi(int id)
        {
            List<M_Transaksi> transaksi = new List<M_Transaksi>();
            DataTable data = Execute_With_Return(
                $"SELECT t.id_transaksi, t.tanggal_transaksi, t.status, t.harga_sewa," +
                $"t.tanggal_pengambilan, t.tanggal_pengembalian, b.judul_buku, " +
                $"mp.metode AS metode_pembayaran " +
                $"FROM transaksi t " +
                $"JOIN buku b ON t.id_buku = b.id_buku " +
                $"JOIN metode_pembayaran mp ON t.id_metode_pembayaran = mp.id_metode_pembayaran WHERE id_akun = {M_Sementara.id};");
            foreach (DataRow row in data.Rows)
            {
                M_Transaksi m_transaksi = new M_Transaksi
                {
                    id_transaksi = Convert.ToInt32(row["id_transaksi"]),
                    metode = row["metode_pembayaran"].ToString(),
                    tanggal_transaksi = row["tanggal_transaksi"].ToString(),
                    status = row["status"].ToString(),
                    harga_sewa = Convert.ToDecimal(row["harga_sewa"]),
                    tanggal_pengambilan = row["tanggal_pengambilan"] == DBNull.Value ? null : row["tanggal_pengambilan"].ToString(),
                    tanggal_pengembalian = row["tanggal_pengembalian"] == DBNull.Value ? null : row["tanggal_pengembalian"].ToString(),
                    judul_buku = row["judul_buku"].ToString()
                };
                transaksi.Add(m_transaksi);
            }
            return transaksi;
        }
        public void LoadDatariwayat()
        {
            vriwayatPelanggan.dataGridView1.DataSource = null;
            vriwayatPelanggan.dataGridView1.Columns.Clear();

            DataGridViewButtonColumn Detail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                UseColumnTextForButtonValue = true,
                Text = "Detail"
            };

            vriwayatPelanggan.dataGridView1.DataSource = GetRiwayatTransaksi(M_Sementara.id);

            vriwayatPelanggan.dataGridView1.Columns["id_transaksi"].Visible = false;
            vriwayatPelanggan.dataGridView1.Columns["id_akun"].Visible = false;
            vriwayatPelanggan.dataGridView1.Columns["Id_Buku"].Visible = false;
            vriwayatPelanggan.dataGridView1.Columns["harga_denda"].Visible = false;
            vriwayatPelanggan.dataGridView1.Columns["nama"].Visible = false;
            vriwayatPelanggan.dataGridView1.Columns["tanggal_transaksi"].HeaderText = "Tanggal Transaksi";
            vriwayatPelanggan.dataGridView1.Columns["judul_buku"].HeaderText = "Judul Buku";
            vriwayatPelanggan.dataGridView1.Columns["harga_sewa"].HeaderText = "Harga Sewa";
            vriwayatPelanggan.dataGridView1.Columns["metode"].HeaderText = "Pembayaran";
            vriwayatPelanggan.dataGridView1.Columns["tanggal_pengambilan"].HeaderText = "Tanggal Pengambilan";
            vriwayatPelanggan.dataGridView1.Columns["status"].HeaderText = "Status";
            vriwayatPelanggan.dataGridView1.Columns["tanggal_pengembalian"].HeaderText = "Tanggal Kembali";

            vriwayatPelanggan.dataGridView1.Columns.Add(Detail);

            vriwayatPelanggan.dataGridView1.Columns["Detail"].HeaderText = "";
            vriwayatPelanggan.dataGridView1.Refresh();
        }
        public M_Transaksi getDetailTransaksiPelanggan(int id)
        {
            DataTable data = Execute_With_Return(
                "SELECT t.id_transaksi, t.tanggal_transaksi, t.status, t.harga_sewa, " +
                "t.tanggal_pengambilan, t.tanggal_pengembalian, mp.metode AS metode_pembayaran, " +
                "b.judul_buku, b.pengarang, b.tahun_terbit, b.penerbit, b.gambar, g.genre " +
                "FROM transaksi t " +
                "JOIN metode_pembayaran mp ON t.id_metode_pembayaran = mp.id_metode_pembayaran " +
                "JOIN buku b ON t.id_buku = b.id_buku " +
                "JOIN genre g ON b.id_genre = g.id_genre " +
                $"WHERE t.id_transaksi = {id};");
            M_Transaksi detail = new M_Transaksi();
            detail.Detail = new List<dynamic[]>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                detail.id_transaksi = (int)data.Rows[i]["id_transaksi"];
                detail.tanggal_transaksi = data.Rows[i]["tanggal_transaksi"].ToString();
                detail.status = data.Rows[i]["status"].ToString();
                detail.harga_sewa = (decimal)data.Rows[i]["harga_sewa"];
                detail.tanggal_pengambilan = data.Rows[i]["tanggal_pengambilan"] == DBNull.Value ? null : data.Rows[i]["tanggal_pengambilan"].ToString();
                detail.tanggal_pengembalian = data.Rows[i]["tanggal_pengembalian"] == DBNull.Value ? null : data.Rows[i]["tanggal_pengembalian"].ToString();
                detail.metode = data.Rows[i]["metode_pembayaran"].ToString();
                detail.Detail.Add(new dynamic[]
                {
                    data.Rows[i]["judul_buku"].ToString(),
                    data.Rows[i]["pengarang"].ToString(),
                    data.Rows[i]["penerbit"].ToString(),
                    data.Rows[i]["tahun_terbit"].ToString(),
                    data.Rows[i]["genre"].ToString(),
                    data.Rows[i]["Gambar"] != DBNull.Value ? (byte[])data.Rows[i]["Gambar"] : new byte[0],

                });
            }
            return detail;
        }
        public void LoadDetailTransaksi(int id)
        {
            M_Transaksi data = getDetailTransaksiPelanggan(id);
            vdetailTransaksiPelanggan = new DetailTransaksiPelanggan(this, data);
            vdetailTransaksiPelanggan.ShowDialog();
        }
        public M_Transaksi getDetailTransaksi(int id)
        {
            DataTable data = Execute_With_Return(
                "SELECT t.id_transaksi, t.tanggal_transaksi, t.status, t.harga_sewa, " +
                "t.tanggal_pengambilan, t.tanggal_pengembalian, mp.metode AS metode_pembayaran, " +
                "b.judul_buku, b.pengarang, b.penerbit, b.tahun_terbit, b.gambar, g.genre, " +
                "a.nama, a.email " +
                "FROM transaksi t " +
                "JOIN metode_pembayaran mp ON t.id_metode_pembayaran = mp.id_metode_pembayaran " +
                "JOIN buku b ON t.id_buku = b.id_buku " +
                "JOIN genre g ON b.id_genre = g.id_genre " +
                "JOIN data_akun a ON t.id_akun = a.id_akun " +
                $"WHERE t.id_transaksi = {id};");

            M_Transaksi detail = new M_Transaksi();

            detail.Detail = new List<dynamic[]>();
            detail.DetailAkun = new List<dynamic[]>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                detail.id_transaksi = (int)data.Rows[i]["id_transaksi"];
                detail.tanggal_transaksi = data.Rows[i]["tanggal_transaksi"].ToString();
                detail.status = data.Rows[i]["status"].ToString();
                detail.harga_sewa = (decimal)data.Rows[i]["harga_sewa"];
                detail.tanggal_pengambilan = data.Rows[i]["tanggal_pengambilan"] == DBNull.Value ? null : data.Rows[i]["tanggal_pengambilan"].ToString();
                detail.tanggal_pengembalian = data.Rows[i]["tanggal_pengembalian"] == DBNull.Value ? null : data.Rows[i]["tanggal_pengembalian"].ToString();
                detail.metode = data.Rows[i]["metode_pembayaran"].ToString();
                detail.Detail.Add(new dynamic[]
                {
                    data.Rows[i]["judul_buku"].ToString(),
                    data.Rows[i]["pengarang"].ToString(),
                    data.Rows[i]["penerbit"].ToString(),
                    data.Rows[i]["tahun_terbit"].ToString(),
                    data.Rows[i]["genre"].ToString(),
                    data.Rows[i]["Gambar"] != DBNull.Value ? (byte[])data.Rows[i]["Gambar"] : new byte[0],
                });
                detail.DetailAkun.Add(new dynamic[]
                {
                    data.Rows[i]["nama"].ToString(),
                    data.Rows[i]["email"].ToString()
                });
            }
            return detail;
        }
        public void LoadDetail(int id)
        {
            M_Transaksi data = getDetailTransaksi(id);
            vdetail = new DetailTransaksi(this, data);
            vdetail.ShowDialog();
        }
    }
}

