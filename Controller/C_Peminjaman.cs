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
        M_Transaksi m_transaksi = new M_Transaksi();
        public C_Peminjaman(C_Homepage homepage, Peminjaman peminjaman)
        {
            Homepage = homepage;
            vpeminjaman = peminjaman;
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

            vpeminjaman.dataPeminjaman.DataSource = Homepage.GetDataTransaksi();

            vpeminjaman.dataPeminjaman.Columns["id_transaksi"].Visible = false;

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
