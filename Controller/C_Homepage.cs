using Projek_SimBuku.Model;
using Projek_SimBuku.Views;
using Projek_SimBuku.Views.Admin.Transaksi;
using Projek_SimBuku.Views.Buku;
using Projek_SimBuku.Views.Dashboard;
using Projek_SimBuku.Views.Pelanggan;
using Projek_SimBuku.Views.Peminjaman;
using Projek_SimBuku.Views.Pengembalian;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace Projek_SimBuku.Controller
{
    public class C_Homepage : C_MassageBox
    {
        HomePage Vhomepage;
        M_Akun m_akun = new M_Akun();
        public C_Homepage Controller_Homepage;
        public Dashboard Vdashboard;
        public Buku Vbuku;
        public Peminjaman Vpeminjaman;
        public Pengembalian VPengembalian;
        public Transaksi Vtransaksi;
        public Connector connector;
        public C_Homepage(HomePage homePage)
        {
            this.Vhomepage = homePage;
            this.connector = new Connector();
            Vdashboard = new Dashboard(this);
            Vbuku = new Buku(this);
            Vpeminjaman = new Peminjaman(this);
            VPengembalian = new Pengembalian(this);
            Vtransaksi = new Transaksi(this);
            switchView(Vdashboard);
            GetDataTransaksi();
        }

        Homepage_pelanggan Vhomepage_Pelanggan;
        public Home Vhome;
        public RiwayatPelanggan VriwayatPelanggan;
        public Keranjang VPeminjamanPelanggan;
        public Setting Vsetting;
        public C_Homepage(Homepage_pelanggan homepage_Pelanggan)
        {
            this.Vhomepage_Pelanggan = homepage_Pelanggan;
            this.connector = new Connector();
            Vhome = new Home(this);
            VriwayatPelanggan = new RiwayatPelanggan(this);
            VPeminjamanPelanggan = new Keranjang(this);
            Vsetting = new Setting(this);
            switchViewPelanggan(Vhome);
            GetDataTransaksi();
        }

        public void switchView(UserControl form)
        {
            Vhomepage.panel1.Controls.Clear();
            Vhomepage.panel1.Controls.Add(form);
        }
        public void switchViewPelanggan(UserControl view)
        {
            Vhomepage_Pelanggan.panel3.Controls.Clear();
            Vhomepage_Pelanggan.panel3.Controls.Add(view);
        }
        public void logOut_Admin()
        {
            if (showConfirm("Apakah Anda Yakin ?"))
            {
                LoginRegister loginRegister = new LoginRegister();
                Vhomepage.Hide();
                loginRegister.ShowDialog();
                Vhomepage.Close();
            }
        }
        public void logOut_Pelanggan()
        {
            if (showConfirm("Apakah Anda Yakin ?"))
            {
                LoginRegister loginRegister = new LoginRegister();
                Vhomepage_Pelanggan.Hide();
                loginRegister.ShowDialog();
                Vhomepage_Pelanggan.Close();
                m_akun.id_akun = 0;
                m_akun.username = null;
                m_akun.password = null;
                m_akun.email = null;
                m_akun.nama = null;
                m_akun.nomor_hp = null;
            }
        }
        public List<M_Transaksi> GetDataTransaksi()
        {
            List<M_Transaksi> transaksi = new List<M_Transaksi>();
            DataTable data = connector.Execute_With_Return("SELECT t.id_transaksi, t.tanggal_transaksi, t.status, t.harga_sewa, t.harga_denda, t.tanggal_pengambilan, t.tanggal_pengembalian, a.nama, b.judul_buku, mp.metode FROM transaksi t JOIN keranjang k ON t.id_keranjang = k.id_keranjang JOIN data_akun a ON k.id_akun = a.id_akun JOIN buku b ON k.id_buku = b.id_buku JOIN metode_pembayaran mp ON t.id_metode_pembayaran = mp.id_metode_pembayaran;");

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
                    },
                    MetodePembayaran = new M_Metode_Pembayaran
                    {
                        Metode = data.Rows[i]["metode"].ToString()
                    }
                };
                transaksi.Add(m_transaksi);
            }
            return transaksi;
        }

    }
}
