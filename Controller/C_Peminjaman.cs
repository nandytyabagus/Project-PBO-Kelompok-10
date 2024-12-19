using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Buku;
using Projek_SimBuku.Views.Peminjaman;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Projek_SimBuku.Views.Massage_Box;

namespace Projek_SimBuku.Controller
{
    public class C_Peminjaman : Connector
    {
        C_Homepage Homepage;
        Peminjaman vpeminjaman;
        C_MassageBox C_MassageBox = new C_MassageBox();
        public C_Peminjaman(C_Homepage homepage, Peminjaman peminjaman)
        {
            Homepage = homepage;
            vpeminjaman = peminjaman;
        }
        public List<M_Peminjaman> GetDataPeminjaman()
        {
            List<M_Peminjaman> Peminjaman = new List<M_Peminjaman>();
            DataTable data = Execute_With_Return("SELECT  t.id_transaksi, t.status, t.harga_sewa, t.tanggal_pengambilan, a.nama, a.id_akun, b.judul_buku, b.pengarang, g.genre FROM transaksi t JOIN data_akun a ON t.id_akun = a.id_akun JOIN buku b ON t.id_buku = b.id_buku JOIN genre g ON b.id_genre = g.id_genre WHERE t.status IN ('Belum Dibayar', 'Lunas'); ");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Peminjaman m_Peminjaman = new M_Peminjaman
                {
                    Id_Transaksi = Convert.ToInt32(data.Rows[i]["id_transaksi"]),
                    status = data.Rows[i]["status"].ToString(),
                    harga_sewa = Convert.ToDecimal(data.Rows[i]["harga_sewa"]),
                    tanggal_pengambilan = data.Rows[i]["tanggal_pengambilan"].ToString(),
                    Nama = data.Rows[i]["nama"].ToString(),
                    Judul_buku = data.Rows[i]["judul_buku"].ToString(),
                    id_akun = Convert.ToInt32(data.Rows[i]["id_akun"])
                };
                Peminjaman.Add(m_Peminjaman);
            }
            return Peminjaman;
        }
        public void Update(int id)
        {
            if (C_MassageBox.showConfirm("Apakah Anda Yakin Mengubah Status Peminjaman ?"))
            {
                Execute_No_Return($"UPDATE transaksi SET status = 'Dipinjam' WHERE id_transaksi = {id}");
            }
        }
        public void LoadData()
        {
            vpeminjaman.dataPeminjaman.DataSource = null;
            vpeminjaman.dataPeminjaman.Columns.Clear();

            DataGridViewButtonColumn UbahStatus = new DataGridViewButtonColumn
            {
                Name = "Ubah Status",
                UseColumnTextForButtonValue = true,
                Text = "Ubah Status",
                HeaderText = ""
            };

            vpeminjaman.dataPeminjaman.DataSource = GetDataPeminjaman();

            vpeminjaman.dataPeminjaman.Columns["Id_Transaksi"].Visible = false;
            vpeminjaman.dataPeminjaman.Columns["id_akun"].Visible = false;
            vpeminjaman.dataPeminjaman.Columns["nama"].HeaderText = "Nama Pelanggan";
            vpeminjaman.dataPeminjaman.Columns["Judul_buku"].HeaderText = "Buku";
            vpeminjaman.dataPeminjaman.Columns["harga_sewa"].HeaderText = "Harga Sewa";
            vpeminjaman.dataPeminjaman.Columns["tanggal_pengambilan"].HeaderText = "Pengambilan";
            vpeminjaman.dataPeminjaman.Columns["status"].HeaderText = "Status";

            vpeminjaman.dataPeminjaman.Columns.Add(UbahStatus);
            vpeminjaman.dataPeminjaman.Refresh();
        }
        public void CariPeminjaman(string keyword)
        {
            var filteredData = GetDataPeminjaman().Where(b =>
            b.Nama.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            b.status.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            b.Judul_buku.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

            vpeminjaman.dataPeminjaman.DataSource = null;
            vpeminjaman.dataPeminjaman.Columns.Clear();

            DataGridViewButtonColumn UbahStatus = new DataGridViewButtonColumn
            {
                Name = "Ubah Status",
                UseColumnTextForButtonValue = true,
                Text = "Ubah Status",
                HeaderText = ""
            };

            vpeminjaman.dataPeminjaman.DataSource = filteredData;

            vpeminjaman.dataPeminjaman.Columns["Id_Transaksi"].Visible = false;
            vpeminjaman.dataPeminjaman.Columns["id_akun"].Visible = false;
            vpeminjaman.dataPeminjaman.Columns["nama"].HeaderText = "Nama Pelanggan";
            vpeminjaman.dataPeminjaman.Columns["Judul_buku"].HeaderText = "Buku";
            vpeminjaman.dataPeminjaman.Columns["harga_sewa"].HeaderText = "Harga Sewa";
            vpeminjaman.dataPeminjaman.Columns["tanggal_pengambilan"].HeaderText = "Pengambilan";
            vpeminjaman.dataPeminjaman.Columns["status"].HeaderText = "Status";

            vpeminjaman.dataPeminjaman.Columns.Add(UbahStatus);
            vpeminjaman.dataPeminjaman.Refresh();
        }
    }
}
