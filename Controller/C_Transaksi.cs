using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Admin.Buku;
using Projek_SimBuku.Views.Admin.Transaksi;
using Projek_SimBuku.Views.Pelanggan;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            DataTable data = Execute_With_Return("SELECT t.id_transaksi, t.tanggal_transaksi, t.status, t.harga_sewa, t.harga_denda, t.tanggal_pengambilan, t.tanggal_pengembalian, a.nama, b.judul_buku, mp.metode FROM transaksi t JOIN keranjang k ON t.id_keranjang = k.id_keranjang JOIN data_akun a ON k.id_akun = a.id_akun JOIN buku b ON k.id_buku = b.id_buku JOIN metode_pembayaran mp ON t.id_metode_pembayaran = mp.id_metode_pembayaran;");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Transaksi m_transaksi = new M_Transaksi
                {
                    id_transaksi = Convert.ToInt32(data.Rows[i]["id_transaksi"]),
                    tanggal_tansaksi = data.Rows[i]["tanggal_tansaksi"].ToString(),
                    status = data.Rows[i]["status"].ToString(),
                    harga_sewa = Convert.ToDecimal(data.Rows[i]["harga_sewa"]),
                    harga_denda = Convert.ToDecimal(data.Rows[i]["harga_denda"]),
                    tanggal_pengambilan = data.Rows[i]["tanggal_pengambilan"].ToString(),
                    tanggal_pengembalian = data.Rows[i]["tanggal_pengembalian"].ToString(),
                    metode = Convert.ToInt32(data.Rows[i]["i"])
                };
                transaksi.Add(m_transaksi);
            }
            return transaksi;
        }
        public void LoadData()
        {
            vtransaksi.dataTransaksi.DataSource = null;
            vtransaksi.dataTransaksi.Columns.Clear();

            vtransaksi.dataTransaksi.DataSource = GetDataTransaksi();

            vtransaksi.dataTransaksi.Columns["id_transaksi"].Visible = false;
            vtransaksi.dataTransaksi.Columns["tanggal_tansaksi"].HeaderText = "Tanggal Transaksi";
            vtransaksi.dataTransaksi.Columns["nama"].HeaderText = "Nama Pelanggan";
            vtransaksi.dataTransaksi.Columns["judul_buku"].HeaderText = "Buku";
            vtransaksi.dataTransaksi.Columns["Harga_Sewa"].HeaderText = "Harga Sewa";
            vtransaksi.dataTransaksi.Columns["Harga_Denda"].HeaderText = "Harga Denda";
            vtransaksi.dataTransaksi.Columns["tanggal_pengambilan"].HeaderText = "Pengambilan";
            vtransaksi.dataTransaksi.Columns["tanggal_pengembalian"].HeaderText = "Pengembalian";
            vtransaksi.dataTransaksi.Columns["status"].HeaderText = "Status";
            vtransaksi.dataTransaksi.Columns["metode"].HeaderText = "Metode Pembayaran";
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
            RadioButton selectedRadioButton = view.metode_pembayaran.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (selectedRadioButton == null || view.comboBox1.SelectedValue == null || view.dateTimePicker1.Value == null)
            {
                MessageBox.Show("Lengkapi Data");
            }
            else
            {
                MessageBox.Show("apakah anda yakin?");
                if (view.E_wallet.Checked)
                {
                    FormTransaksi View = new FormTransaksi(this, new Bukti_Pembayaran(this));
                    View.ShowDialog();
                }
                else if (view.Transfer.Checked)
                {
                    FormTransaksi View = new FormTransaksi(this, new Bukti_Pembayaran(this));
                    View.ShowDialog();
                }
                else if (!view.Tunai.Checked)
                {
                    FormTransaksi View = new FormTransaksi(this, new Bukti_Pembayaran(this));
                    View.ShowDialog();
                }
            }
        }
        public void Buat_transaks(BuatTransaksi view)
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

            if (M_Keranjang.StaticCartItems.Any())
            {
                transaksi.id_buku = M_Keranjang.StaticCartItems[0].Id_Buku;
            }
            else
            {
                MessageBox.Show("Pilih buku yang akan disewa");
                return;
            }

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
            transaksi.harga_sewa = (int)hargaSewaPerBuku * transaksi.durasi;

            if (transaksi.harga_sewa <= 0)
            {
                MessageBox.Show("Harga sewa tidak valid.");
                return;
            }
            Insert(transaksi, M_Sementara.id);
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
                           $"VALUES ({id}, {transaksi.id_buku}, {transaksi.id_metode}, '{transaksi.Pengambilan:yyyy-MM-dd}', '{transaksi.Pengembalian:yyyy-MM-dd}', {transaksi.harga_sewa}, 'Lunas', null);";
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

        //public List<M_Transaksi> GetRiwayatTransaksi()
        //{
        //    List<M_Transaksi> transaksi = new List<M_Transaksi>();
        //    DataTable data = Execute_With_Return($"SELECT t.id_transaksi, t.tanggal_transaksi, t.status, t.harga_sewa, t.harga_denda, t.tanggal_pengambilan, t.tanggal_pengembalian, a.nama, b.judul_buku, mp.metode FROM transaksi t JOIN keranjang k ON t.id_keranjang = k.id_keranjang JOIN data_akun a ON k.id_akun = a.id_akun JOIN buku b ON k.id_buku = b.id_buku JOIN metode_pembayaran mp ON t.id_metode_pembayaran = mp.id_metode_pembayaran WHERE a.id_akun = {akun.id_akun};");

        //    for (int i = 0; i < data.Rows.Count; i++)
        //    {
        //        M_Transaksi m_transaksi = new M_Transaksi
        //        {
        //            id_transaksi = Convert.ToInt32(data.Rows[i]["id_transaksi"]),
        //            tanggal_tansaksi = data.Rows[i]["tanggal_tansaksi"].ToString(),
        //            status = data.Rows[i]["status"].ToString(),
        //            harga_sewa = Convert.ToDecimal(data.Rows[i]["harga_sewa"]),
        //            harga_denda = Convert.ToDecimal(data.Rows[i]["harga_denda"]),
        //            tanggal_pengambilan = data.Rows[i]["tanggal_pengambilan"].ToString(),
        //            tanggal_pengembalian = data.Rows[i]["tanggal_pengembalian"].ToString(),
        //            metode = data.Rows[i]["metode"].ToString(),
        //            Keranjang = new M_Keranjang
        //            {
        //                Buku = new M_Buku
        //                {
        //                    Judul_buku = data.Rows[i]["judul_buku"].ToString()
        //                },
        //            }
        //        };
        //        transaksi.Add(m_transaksi);
        //    }
        //    return transaksi;
        //}
        //public void LoadDatariwayat()
        //{
        //    vriwayatPelanggan.dataGridView1.DataSource = null;
        //    vriwayatPelanggan.dataGridView1.Columns.Clear();

        //    vriwayatPelanggan.dataGridView1.DataSource = GetRiwayatTransaksi();

        //    vriwayatPelanggan.dataGridView1.Columns["id_transaksi"].Visible = false;
        //    vriwayatPelanggan.dataGridView1.Columns["tanggal_tansaksi"].HeaderText = "Tanggal Transaksi";
        //    vriwayatPelanggan.dataGridView1.Columns["judul_buku"].HeaderText = "Buku";
        //    vriwayatPelanggan.dataGridView1.Columns["Harga_Sewa"].HeaderText = "Harga Sewa";
        //    vriwayatPelanggan.dataGridView1.Columns["Harga_Denda"].Visible = false;
        //    vriwayatPelanggan.dataGridView1.Columns["tanggal_pengambilan"].Visible = false;
        //    vriwayatPelanggan.dataGridView1.Columns["tanggal_pengembalian"].Visible = false;
        //    vriwayatPelanggan.dataGridView1.Columns["metode"].Visible = false;
        //}
    }
}

