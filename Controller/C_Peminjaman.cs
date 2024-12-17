using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Buku;
using Projek_SimBuku.Views.Peminjaman;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_Peminjaman : Connector
    {
        C_Homepage Homepage;
        Peminjaman vpeminjaman;
        M_Peminjaman m_peminjaman = new M_Peminjaman();
        public C_Peminjaman(C_Homepage homepage, Peminjaman peminjaman)
        {
            Homepage = homepage;
            vpeminjaman = peminjaman;
        }
        public List<M_Peminjaman> GetDataPeminjaman()
        {
            List<M_Peminjaman> Peminjaman = new List<M_Peminjaman>();
            DataTable data = Execute_With_Return("SELECT t.id_transaksi, t.status, t.harga_sewa, t.tanggal_pengambilan, a.nama, b.judul_buku FROM transaksi t JOIN keranjang k ON t.id_keranjang = k.id_keranjang JOIN data_akun a ON k.id_akun = a.id_akun JOIN buku b ON k.id_buku = b.id_buku;");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Peminjaman m_Peminjaman = new M_Peminjaman
                {
                    Id_Transaksi = Convert.ToInt32(data.Rows[i]["id_transaksi"]),
                    status = data.Rows[i]["status"].ToString(),
                    harga_sewa = Convert.ToDecimal(data.Rows[i]["harga_sewa"]),
                    tanggal_pengambilan = data.Rows[i]["tanggal_pengambilan"].ToString(),
                };
                Peminjaman.Add(m_Peminjaman);
            }
            return Peminjaman;
        }
        public void Insert()
        {

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

            vpeminjaman.dataPeminjaman.Columns["nama"].HeaderText = "Nama Pelanggan";
            vpeminjaman.dataPeminjaman.Columns["Judul_buku"].HeaderText = "Buku";
            vpeminjaman.dataPeminjaman.Columns["harga_sewa"].HeaderText = "Harga Sewa";
            vpeminjaman.dataPeminjaman.Columns["tanggal_pengambilan"].HeaderText = "Pengambilan";
            vpeminjaman.dataPeminjaman.Columns["status"].HeaderText = "Status";

            vpeminjaman.dataPeminjaman.Columns.Add(UbahStatus);

        }
        public void Update()
        { 

        }
    }
}
