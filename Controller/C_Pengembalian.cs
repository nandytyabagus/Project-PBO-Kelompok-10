using Projek_SimBuku.Model;
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
        public List<M_Pengembalian> GetDataPengembalian()
        {
            List<M_Pengembalian> Pengembalian = new List<M_Pengembalian>();
            DataTable data = Execute_With_Return("SELECT t.id_transaksi, t.status, t.harga_denda AS denda, t.tanggal_pengembalian, a.nama, b.judul_buku FROM transaksi t JOIN keranjang k ON t.id_keranjang = k.id_keranjang JOIN data_akun a ON k.id_akun = a.id_akun JOIN buku b ON k.id_buku = b.id_buku;");
            
            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Pengembalian m_Pengembalian = new M_Pengembalian
                {
                    Id_Transaksi = Convert.ToInt32(data.Rows[i]["id_transaksi"]),
                    status = data.Rows[i]["Status"].ToString(),
                    denda = Convert.ToDecimal(data.Rows[i]["Harga Sewa"]),
                    tanggal_pengembalian = data.Rows[i]["Tanggal Pengembalian"].ToString(),
                    Keranjang = new M_Keranjang
                    {
                        Akun = new M_Akun
                        {
                            nama = data.Rows[i]["Nama Akun"].ToString()
                        },
                        Buku = new M_Buku
                        {
                            Judul_buku = data.Rows[i]["Judul Buku"].ToString()
                        }
                    }
                };
                Pengembalian.Add(m_Pengembalian);
            }
            return Pengembalian;
        }
        public void Insert()
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

            vpengembalian.dataPengembalian.DataSource = GetDataPengembalian();

            vpengembalian.dataPengembalian.Columns["Id_Transaksi"].Visible = false;

            vpengembalian.dataPengembalian.Columns["nama"].HeaderText = "Nama Pelanggan";
            vpengembalian.dataPengembalian.Columns["Judul_buku"].HeaderText = "Buku";
            vpengembalian.dataPengembalian.Columns["denda"].HeaderText = "Denda";
            vpengembalian.dataPengembalian.Columns["tanggal_pengembalian"].HeaderText = "Pengembalian";
            vpengembalian.dataPengembalian.Columns["status"].HeaderText = "Status";

            vpengembalian.dataPengembalian.Columns.Add(UbahStatus);

        }
        public void Update()
        {

        }
    }
}
