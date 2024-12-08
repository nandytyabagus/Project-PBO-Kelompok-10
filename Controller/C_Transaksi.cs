using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Admin.Transaksi;
using Projek_SimBuku.Views.Peminjaman;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_Transaksi : Connector
    {
        C_Homepage chomepage;
        Transaksi vtransaksi;

        public C_Transaksi(C_Homepage homepage, Transaksi transaksi)
        {
            chomepage = homepage;
            vtransaksi = transaksi;
        }

        public List<M_Transaksi> GetDataTransaksi()
        {
            List<M_Transaksi> transaksi = new List<M_Transaksi>();
            DataTable data = Execute_With_Return("SELECT t.id_transaksi, t.tanggal_transaksi AS tanggal_tansaksi, t.status, t.harga_sewa, t.harga_denda, t.tanggal_pengambilan, t.tanggal_pengembalian, a.nama, b.judul_buku, mp.metode FROM transaksi t JOIN keranjang k ON t.id_keranjang = k.id_keranjang JOIN data_akun a ON k.id_akun = a.id_akun JOIN buku b ON k.id_buku = b.id_buku JOIN metode_pembayaran mp ON t.id_metode_pembayaran = mp.id_metode_pembayaran;");

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
                    Keranjang = new M_Keranjang
                    {
                        Buku = new M_Buku
                        {
                            Judul_buku = data.Rows[i]["judul_buku"].ToString()
                        },
                        Akun = new M_Akun
                        {
                            nama = data.Rows[i]["nama"].ToString()
                        }
                    }
                };
                transaksi.Add(m_transaksi);
            }
            return transaksi;
        }

        public void LoadData()
        {
            vtransaksi.dataTransaksi.DataSource = null;
            vtransaksi.dataTransaksi.Columns.Clear();

            var transaksiList = GetDataTransaksi();
            vtransaksi.dataTransaksi.DataSource = transaksiList.Select(t => new
            {
                t.id_transaksi,
                t.tanggal_tansaksi,
                Nama = t.nama,
                Judul_Buku = t.judul_buku,
                Harga_Sewa = t.harga_sewa,
                Harga_Denda = t.harga_denda,
                Pengambilan = t.tanggal_pengambilan,
                Pengembalian = t.tanggal_pengembalian,
                Status = t.status,
                Metode = t.metode
            }).ToList();

            vtransaksi.dataTransaksi.Columns["id_transaksi"].Visible = false;
            vtransaksi.dataTransaksi.Columns["tanggal_tansaksi"].HeaderText = "Tanggal Transaksi";
            vtransaksi.dataTransaksi.Columns["Nama"].HeaderText = "Nama Pelanggan";
            vtransaksi.dataTransaksi.Columns["Judul_Buku"].HeaderText = "Buku";
            vtransaksi.dataTransaksi.Columns["Harga_Sewa"].HeaderText = "Harga Sewa";
            vtransaksi.dataTransaksi.Columns["Harga_Denda"].HeaderText = "Harga Denda";
            vtransaksi.dataTransaksi.Columns["Pengambilan"].HeaderText = "Pengambilan";
            vtransaksi.dataTransaksi.Columns["Pengembalian"].HeaderText = "Pengembalian";
            vtransaksi.dataTransaksi.Columns["Status"].HeaderText = "Status";
            vtransaksi.dataTransaksi.Columns["Metode"].HeaderText = "Metode Pembayaran";
        }
    }
}
