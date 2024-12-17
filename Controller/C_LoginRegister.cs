using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using Projek_SimBuku.Model;
using Projek_SimBuku.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_LoginRegister : Connector
    {
        public LoginRegister VloginRegister;
        public Login Vlogin;
        public Register Vregister;
        C_MassageBox C_MassageBox = new C_MassageBox();
        M_Akun m_akun = new M_Akun();

        public C_LoginRegister(LoginRegister loginRegister)
        {
            this.VloginRegister = loginRegister;
            Vlogin = new Login(this);
            Vregister = new Register(this);
            Setup();
            switchView(Vlogin);
        }
        public void switchView(UserControl form)
        {
            VloginRegister.panel1.Controls.Clear();
            VloginRegister.panel1.Controls.Add(form);
        }
        public void Get(string username, string password)
        {
            DataTable data = Execute_With_Return($"SELECT * FROM Data_Akun WHERE username = '{username}' and password = '{password}'");

            if (data.Rows.Count > 0)
            {
                M_Session.Id = int.Parse(data.Rows[0]["id_Akun"].ToString());
                m_akun.id_akun = int.Parse(data.Rows[0]["id_Akun"].ToString());
                m_akun.username = data.Rows[0]["username"].ToString();
                m_akun.password = data.Rows[0]["password"].ToString();
                m_akun.nama = data.Rows[0]["nama"].ToString();
                m_akun.email = data.Rows[0]["email"].ToString();
                m_akun.nomor_hp = data.Rows[0]["nomor_hp"].ToString();
            }
        }

        public void Insert(object item)
        {
            Akun akun = item as Akun;
            Execute_No_Return($"INSERT INTO Data_Akun(username,password,nama,email,nomor_hp,gambar) VALUES ('{akun.Username}','{akun.Password}','{akun.Nama}','{akun.Email}','{akun.Nomor_Hp}',null)");
        }
        public void Update(object data, int id)
        {

        }

        public void Login()
        {
            Get(Vlogin.textBoxUsername.Text, Vlogin.textBoxPassword.Text);
            if (m_akun.username == Vlogin.textBoxUsername.Text || m_akun.password == Vlogin.textBoxPassword.Text)
            {
                C_MassageBox.showMassageBox("Berhasil Login");
                Homepage_pelanggan homepage_Pelanggan = new Homepage_pelanggan();
                VloginRegister.Hide();
                homepage_Pelanggan.ShowDialog();
                VloginRegister.Close();
            }
            else if (Vlogin.textBoxUsername.Text == "SimBuku" && Vlogin.textBoxPassword.Text == "Simbuku")
            {
                C_MassageBox.showMassageBox("Berhasil Login Sebagai Admin");
                HomePage homePage = new HomePage();
                VloginRegister.Hide();
                homePage.ShowDialog();
                VloginRegister.Close();
            }
            else if (m_akun.username == Vlogin.textBoxUsername.Text || m_akun.password != Vlogin.textBoxPassword.Text)
            {
                Vlogin.textBoxPassword.Clear();
                Vlogin.label3.Visible = true;
                Vlogin.label3.Text = "Password Salah";
            }
            else if (m_akun.username != Vlogin.textBoxUsername.Text)
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
                C_MassageBox.showMassageBox("Password Tidak Sama");
                return;
            }
            else
            {
                try
                {
                    Insert(dataAkun);
                    C_MassageBox.showMassageBox("Akun Berhasil Ditambahkan");
                    switchView(Vlogin);
                }
                catch
                {
                    C_MassageBox.showMassageBox("Username Sudah Ada");
                }
            }
        }
        public class Akun
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Nama { get; set; }
            public string Email { get; set; }
            public string Nomor_Hp { get; set; }
        }
    }
}
