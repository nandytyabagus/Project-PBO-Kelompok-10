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
    public class C_LoginRegister : C_MassageBox
    {
        C_LoginRegister controller_loginRegister;
        public LoginRegister VloginRegister;
        public Login Vlogin;
        public Register Vregister;
        Connector connector = new Connector();
        M_Akun m_akun = new M_Akun();

        public C_LoginRegister(LoginRegister loginRegister)
        {
            this.VloginRegister = loginRegister;
            Vlogin = new Login(this);
            Vregister = new Register(this);
            connector.Setup();
            switchView(Vlogin);
        }
        public void switchView(UserControl form)
        {
            VloginRegister.panel1.Controls.Clear();
            VloginRegister.panel1.Controls.Add(form);
        }
        public List<object> Get()
        {
            return new List<object>();
        }
        public void Get(string username, string password)
        {
            DataTable data = connector.Execute_With_Return($"SELECT * FROM Data_Akun WHERE username = '{username}' and password = '{password}'");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Akun.id_akun = int.Parse(data.Rows[i]["id_Akun"].ToString());
                M_Akun.username = data.Rows[i]["username"].ToString();
                M_Akun.password = data.Rows[i]["password"].ToString();
                M_Akun.nama = data.Rows[i]["nama"].ToString();
                M_Akun.email = data.Rows[i]["email"].ToString();
                M_Akun.nomor_hp = data.Rows[i]["nomor_hp"].ToString();
            }
        }
        public void Insert(object item)
        {
            Akun akun = item as Akun;
            connector.Execute_No_Return($"INSERT INTO Data_Akun(username,password,nama,email,nomor_hp) VALUES ('{akun.Username}','{akun.Password}','{akun.Nama}','{akun.Email}','{akun.Nomor_Hp}')");
        }
        public void Update(object data, int id)
        {

        }
        public class Akun
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Nama { get; set; }
            public string Email { get; set; }
            public string Nomor_Hp { get; set; }
        }

        public void Login()
        {
            Get(Vlogin.textBoxUsername.Text, Vlogin.textBoxPassword.Text);
            if (M_Akun.username == Vlogin.textBoxUsername.Text && M_Akun.password == Vlogin.textBoxPassword.Text)
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
            else if (M_Akun.username == Vlogin.textBoxUsername.Text || M_Akun.password != Vlogin.textBoxPassword.Text)
            {
                Vlogin.textBoxPassword.Clear();
                Vlogin.label3.Visible = true;
                Vlogin.label3.Text = "Password Salah";
            }
            else if (M_Akun.username != Vlogin.textBoxUsername.Text)
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
                    Insert(dataAkun);
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
