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
        public C_Pengembalian(C_Homepage homepage, Pengembalian pengembalian)
        {
            c_Homepage = homepage;
            vpengembalian = pengembalian;
        }
        public List<M_Pengembalian> GetDataPeminjaman()
        {
            List<M_Pengembalian> M_pengembalian = new List<M_Pengembalian>();
            DataTable data = Execute_With_Return("SELECT t.id_transaksi, t.status, t.harga_denda, t.tanggal_pengembalian, a.nama, b.judul_buku, b.pengarang, g.genre FROM transaksi t JOIN data_akun a ON t.id_akun = a.id_akun JOIN buku b ON t.id_buku = b.id_buku JOIN genre g ON b.id_genre = g.id_genre WHERE t.status IN ('Belum Dibayar', 'Sudah Dibayar');");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Pengembalian m_Pengembalian = new M_Pengembalian
                {
                    Id_Transaksi = Convert.ToInt32(data.Rows[i]["id_transaksi"]),
                    status = data.Rows[i]["status"].ToString(),
                    denda = Convert.ToDecimal(data.Rows[i]["harga_denda"]),
                    tanggal_pengambilan = data.Rows[i]["tanggal_pengembalian"].ToString(),
                    Nama = data.Rows[i]["nama"].ToString(),
                    Judul_buku = data.Rows[i]["judul_buku"].ToString()
                };
                M_pengembalian.Add(m_Pengembalian);
            }
            return M_pengembalian;
        }
        public void Update(int id)
        {

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

            vpengembalian.dataPengembalian.DataSource = GetDataPeminjaman();

            vpengembalian.dataPengembalian.Columns["Id_Transaksi"].Visible = false;
            vpengembalian.dataPengembalian.Columns["nama"].HeaderText = "Nama Pelanggan";
            vpengembalian.dataPengembalian.Columns["Judul_buku"].HeaderText = "Buku";
            vpengembalian.dataPengembalian.Columns["harga_sewa"].HeaderText = "Harga Sewa";
            vpengembalian.dataPengembalian.Columns["tanggal_pengambilan"].HeaderText = "Pengambilan";
            vpengembalian.dataPengembalian.Columns["status"].HeaderText = "Status";

            vpengembalian.dataPengembalian.Columns.Add(UbahStatus);
            vpengembalian.dataPengembalian.Refresh();
        }
    }
}

