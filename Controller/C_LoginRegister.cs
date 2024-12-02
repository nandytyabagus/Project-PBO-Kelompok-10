using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using Projek_SimBuku.Model;
using Projek_SimBuku.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_LoginRegister : C_MassageBox
    {
        public LoginRegister VloginRegister;
        C_LoginRegister controller_loginRegister;
        public Login Vlogin;
        public Register Vregister;
        M_Akun m_akun = new M_Akun();

        public C_LoginRegister(LoginRegister loginRegister)
        {
            this.VloginRegister = loginRegister;
            Vlogin = new Login(this);
            Vregister = new Register(this);
            switchView(Vlogin);
        }
        public void switchView(UserControl form)
        {
            VloginRegister.panel1.Controls.Clear();
            VloginRegister.panel1.Controls.Add(form);
        }
        public void Login()
        {
            m_akun.Get(Vlogin.textBoxUsername.Text, Vlogin.textBoxPassword.Text);
            if (AkunLogin.username == Vlogin.textBoxUsername.Text && AkunLogin.password == Vlogin.textBoxPassword.Text)
            {
                showMassageBox("Berhasil Login");
                Homepage_pelanggan homepage_Pelanggan = new Homepage_pelanggan();
                VloginRegister.Hide();
                homepage_Pelanggan.ShowDialog();
                VloginRegister.Close();
            }
            else if (Vlogin.textBoxUsername.Text == "SimBuku" && Vlogin.textBoxPassword.Text == "Simbuku")
            {
                showMassageBox("Berhasil Login Sebagai Admin");
                HomePage homePage = new HomePage();
                VloginRegister.Hide();
                homePage.ShowDialog();
                VloginRegister.Close();
            }
            else if (AkunLogin.username == Vlogin.textBoxUsername.Text || AkunLogin.password != Vlogin.textBoxPassword.Text)
            {
                Vlogin.textBoxPassword.Clear();
                Vlogin.label3.Visible = true;
                Vlogin.label3.Text = "Password Salah";
            }
            else if (AkunLogin.username != Vlogin.textBoxUsername.Text)
            {
                Vlogin.textBoxUsername.Clear();
                Vlogin.label2.Visible = true;
                Vlogin.label2.Text = "Username Salah";
            }
            else if (string.IsNullOrEmpty(Vlogin.textBoxUsername.Text) && string.IsNullOrEmpty(Vlogin.textBoxPassword.Text))
            {
                Vlogin.label2.Visible = true;
                Vlogin.label2.Text = "Masukan Username Anda";
                Vlogin.label3.Visible = true;
                Vlogin.label3.Text = "Masukan Password Anda";
                return;
            }
            else if (string.IsNullOrEmpty(Vlogin.textBoxUsername.Text))
            {
                Vlogin.label2.Visible = true;
                Vlogin.label2.Text = "Masukan Username Anda";
                return;
            }
            else if (Vlogin.textBoxPassword.Text == "Password")
            {
                Vlogin.label3.Visible = true;
                Vlogin.label3.Text = "Masukan Password Anda";
                return;
            }
        }
        public void Registrasi()
        {
            Akun dataAkun = new Akun()
            {
                Username = Vregister.textBoxUsername.Text,
                Password = Vregister.textBoxPassword.Text,
                Nama = Vregister.textBoxNama.Text,
                Email = Vregister.textBoxEmail.Text,
                Nomor_Hp = Vregister.textBoxNomorHp.Text,
            };
            if (Vregister.textBoxConfirmPass.Text != Vregister.textBoxPassword.Text)
            {
                showMassageBox("Password Tidak Sama");
                return;
            }
            else
            {
                try
                {
                    m_akun.Insert(dataAkun);
                    showMassageBox("Akun Berhasil Ditambahkan");
                    switchView(Vlogin);
                }
                catch
                {
                    showMassageBox("Username Sudah Ada");
                }
            }
        }
    }
}
