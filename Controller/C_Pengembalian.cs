using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Peminjaman;
using Projek_SimBuku.Views.Pengembalian;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_Pengembalian : Connector
    {
        C_Homepage c_Homepage;
        Pengembalian vpengembalian;
        C_MassageBox C_MassageBox = new C_MassageBox();
        public C_Pengembalian(C_Homepage homepage, Pengembalian pengembalian)
        {
            c_Homepage = homepage;
            vpengembalian = pengembalian;
        }
        public List<M_Pengembalian> GetDataPengembalian()
        {
            List<M_Pengembalian> M_pengembalian = new List<M_Pengembalian>();
            DataTable data = Execute_With_Return("SELECT t.id_transaksi, t.status, t.harga_denda, t.tanggal_pengembalian, a.nama, a.id_akun, b.id_buku, b.judul_buku, b.pengarang, g.genre FROM transaksi t JOIN data_akun a ON t.id_akun = a.id_akun JOIN buku b ON t.id_buku = b.id_buku JOIN genre g ON b.id_genre = g.id_genre WHERE t.status IN ('Dipinjam','Denda') ;");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Pengembalian m_Pengembalian = new M_Pengembalian
                {
                    Id_Transaksi = Convert.ToInt32(data.Rows[i]["id_transaksi"]),
                    status = data.Rows[i]["status"].ToString(),
                    harga_denda = data.Rows[i]["harga_denda"] == DBNull.Value ? 0 : Convert.ToDecimal(data.Rows[i]["harga_denda"]),
                    tanggal_pengembalian = data.Rows[i]["tanggal_pengembalian"].ToString(),
                    Nama = data.Rows[i]["nama"].ToString(),
                    Judul_buku = data.Rows[i]["judul_buku"].ToString(),
                    id_akun = Convert.ToInt32(data.Rows[i]["id_akun"]),
                    id_buku = Convert.ToInt32(data.Rows[i]["id_buku"])
                };
                M_pengembalian.Add(m_Pengembalian);
            }
            return M_pengembalian;
        }
        public void Update(int id, decimal denda)
        {
            Execute_No_Return($"UPDATE transaksi SET harga_denda = {denda}, status = 'Denda' WHERE id_transaksi = {id};");
        }
        public void UpdateStatus(int id,int idBuku)
        {
            if(C_MassageBox.showConfirm("Apakah Anda Sudah Yakin"))
            {
                Execute_No_Return($"UPDATE transaksi SET status = 'Kembali' WHERE id_transaksi = {id};");
                Execute_No_Return($"UPDATE buku SET stok = stok + 1 WHERE id_buku = {idBuku};");
            }
        }
        public void HitungDenda()
        {
            List<M_Pengembalian> dataPengembalian = GetDataPengembalian();

            DateTime tanggalSekarang = DateTime.Now;
            decimal dendaPerHari = 10000;
            foreach (var pengembalian in dataPengembalian)
            {
                DateTime tanggalPengembalian = Convert.ToDateTime(pengembalian.tanggal_pengembalian);
                if (tanggalPengembalian < tanggalSekarang)
                {
                    int hariKeterlambatan = (tanggalSekarang - tanggalPengembalian).Days;
                    if (hariKeterlambatan > 0)
                    {
                        decimal dendaTerlambat = hariKeterlambatan * dendaPerHari;
                        Update(pengembalian.Id_Transaksi, dendaTerlambat);
                    }
                }
            }
            LoadData();
        }

        public void LoadData()
        {
            vpengembalian.dataPengembalian.DataSource = null;
            vpengembalian.dataPengembalian.Columns.Clear();

            DataGridViewButtonColumn UbahStatus = new DataGridViewButtonColumn
            {
                Name = "Ubah Status",
                UseColumnTextForButtonValue = true,
                Text = "Ubah Status",
                HeaderText = ""
            };

            vpengembalian.dataPengembalian.DataSource = GetDataPengembalian();

            vpengembalian.dataPengembalian.Columns["Id_Transaksi"].Visible = false;
            vpengembalian.dataPengembalian.Columns["id_akun"].Visible = false;
            vpengembalian.dataPengembalian.Columns["id_buku"].Visible = false;
            vpengembalian.dataPengembalian.Columns["nama"].HeaderText = "Nama Pelanggan";
            vpengembalian.dataPengembalian.Columns["Judul_buku"].HeaderText = "Buku";
            vpengembalian.dataPengembalian.Columns["tanggal_pengembalian"].HeaderText = "Pengembalian";
            vpengembalian.dataPengembalian.Columns["status"].HeaderText = "Status";
            vpengembalian.dataPengembalian.Columns["harga_denda"].HeaderText = "Total Denda";

            vpengembalian.dataPengembalian.Columns.Add(UbahStatus);
            vpengembalian.dataPengembalian.Refresh();
        }
        public void CariPengembalian(string keyword)
        {
            var filteredData = GetDataPengembalian().Where(b =>
            b.Nama.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            b.status.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            b.Judul_buku.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

            vpengembalian.dataPengembalian.DataSource = null;
            vpengembalian.dataPengembalian.Columns.Clear();

            DataGridViewButtonColumn UbahStatus = new DataGridViewButtonColumn
            {
                Name = "Ubah Status",
                UseColumnTextForButtonValue = true,
                Text = "Ubah Status",
                HeaderText = ""
            };

            vpengembalian.dataPengembalian.DataSource = filteredData;

            vpengembalian.dataPengembalian.Columns["Id_Transaksi"].Visible = false;
            vpengembalian.dataPengembalian.Columns["id_akun"].Visible = false;
            vpengembalian.dataPengembalian.Columns["nama"].HeaderText = "Nama Pelanggan";
            vpengembalian.dataPengembalian.Columns["Judul_buku"].HeaderText = "Buku";
            vpengembalian.dataPengembalian.Columns["tanggal_pengembalian"].HeaderText = "Pengembalian";
            vpengembalian.dataPengembalian.Columns["status"].HeaderText = "Status";
            vpengembalian.dataPengembalian.Columns["harga_denda"].HeaderText = "Total Denda";

            vpengembalian.dataPengembalian.Columns.Add(UbahStatus);
            vpengembalian.dataPengembalian.Refresh();
        }
    }
}

