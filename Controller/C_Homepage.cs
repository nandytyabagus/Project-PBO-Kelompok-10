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
using Projek_SimBuku.Views.Pelanggan.Home;

namespace Projek_SimBuku.Controller
{
    public class C_Homepage : C_MassageBox
    {
        HomePage Vhomepage;
        public C_Homepage Controller_Homepage;
        public Dashboard Vdashboard;
        public Buku Vbuku;
        public Peminjaman Vpeminjaman;
        public Pengembalian VPengembalian;
        public Transaksi Vtransaksi;
        M_Akun m_akun = new M_Akun();
        M_Buku m_Buku = new M_Buku();
        M_Keranjang m_Keranjang = new M_Keranjang();
        M_Peminjaman m_Peminjaman = new M_Peminjaman();
        M_Pengembalian m_Pengembalian = new M_Pengembalian();
        M_Transaksi m_Transaksi = new M_Transaksi();
        public C_Homepage(HomePage homePage)
        {
            this.Vhomepage = homePage;
            Vdashboard = new Dashboard(this);
            Vbuku = new Buku(this);
            Vpeminjaman = new Peminjaman(this);
            VPengembalian = new Pengembalian(this);
            Vtransaksi = new Transaksi(this);
            switchView(Vdashboard);
        }

        Homepage_pelanggan Vhomepage_Pelanggan;
        public HomeKatalog Vhome;
        public RiwayatPelanggan VriwayatPelanggan;
        public Keranjang VPeminjamanPelanggan;
        public Setting Vsetting;
        public C_Homepage(Homepage_pelanggan homepage_Pelanggan)
        {
            this.Vhomepage_Pelanggan = homepage_Pelanggan;
            Vhome = new HomeKatalog(this);
            VriwayatPelanggan = new RiwayatPelanggan(this);
            VPeminjamanPelanggan = new Keranjang(this);
            Vsetting = new Setting(this);
            switchViewPelanggan(Vhome);
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
                m_akun = null;
                m_Buku = null;
                m_Peminjaman = null;
                m_Pengembalian = null;
                m_Transaksi = null;
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
                m_akun = null;
                m_Buku = null;
                m_Keranjang = null;
                m_Transaksi = null;
            }
        }
    }
}
