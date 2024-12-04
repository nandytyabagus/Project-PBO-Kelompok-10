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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Home Vhome;
        public RiwayatPelanggan VriwayatPelanggan;
        public Keranjang VPeminjamanPelanggan;
        public Setting Vsetting;
        public C_Homepage(Homepage_pelanggan homepage_Pelanggan)
        {
            this.Vhomepage_Pelanggan = homepage_Pelanggan;
            Vhome = new Home(this);
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
    }
}
