using Npgsql;
using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Massage_Box;
using Projek_SimBuku.Views.Pelanggan;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projek_SimBuku.Controller.C_Buku;
using static Projek_SimBuku.Controller.C_LoginRegister;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projek_SimBuku.Controller
{
    public class C_Profile : Connector
    {
        C_Homepage vhomepage;
        Setting vsetting;
        M_Akun m_akun = new M_Akun();
        C_MassageBox C_MassageBox = new C_MassageBox();
        bool edit;
        public C_Profile(C_Homepage homepage, Setting setting) 
        { 
            vhomepage = homepage;
            vsetting = setting;
        }
        public M_Akun GetDataAkun(int id)
        {
            DataTable data = Execute_With_Return($"SELECT * FROM Data_Akun WHERE id_akun = {id}");
            M_Akun akun = new M_Akun();

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                akun.id_akun = Convert.ToInt32(row["id_akun"]);
                akun.username = row["username"].ToString();
                akun.password = row["password"].ToString();
                akun.nama = row["nama"].ToString();
                akun.email = row["email"].ToString();
                akun.nomor_hp = row["nomor_hp"].ToString();
                akun.gambar = row["gambar"] != DBNull.Value ? (byte[])row["gambar"] : null;
            }
            return akun;
        }

        public void LoadDataAkun()
        {
            M_Akun akun = GetDataAkun(M_Sementara.id);
            vsetting.textBox1.Text = akun.nama;
            vsetting.textBox2.Text = akun.username;
            vsetting.textBox3.Text = akun.password;
            vsetting.textBox4.Text = akun.email;
            vsetting.textBox5.Text = akun.nomor_hp;

            if (akun.gambar != null && akun.gambar.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(akun.gambar))
                {
                    vsetting.pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                vsetting.pictureBox1.Image = null;
            }
        }

        public void UbahData()
        {
            if (C_MassageBox.showConfirm("Apakah Anda Suda Yakin Mengubah Data ?"))
            {
                Akun akun = new Akun
                {
                    Nama = vsetting.textBox1.Text,
                    Username = vsetting.textBox2.Text,
                    Password = vsetting.textBox3.Text,
                    Email = vsetting.textBox4.Text,
                    Nomor_Hp = vsetting.textBox5.Text,
                    gambar = (byte[])new ImageConverter().ConvertTo(vsetting.pictureBox1.Image, typeof(byte[]))
                };
                try
                {
                    Update(akun,M_Sementara.id);
                    LoadDataAkun();
                    C_MassageBox.showMassageBox("Data Berhasil Dirubah");
                }
                catch { }

            }
        }
        public void Update(object obj,int id)
        {
            Akun dataBaru = obj as Akun;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = @"UPDATE Data_Akun 
                                    SET password = @password, 
                                        nama = @nama, 
                                        email = @email, 
                                        nomor_hp = @nomor, 
                                        gambar = @foto 
                                    WHERE id_Akun = @id";

                cmd.Parameters.AddWithValue("@password", dataBaru.Password);
                cmd.Parameters.AddWithValue("@nama", dataBaru.Nama);
                cmd.Parameters.AddWithValue("@email", dataBaru.Email);
                cmd.Parameters.AddWithValue("@nomor", dataBaru.Nomor_Hp);
                cmd.Parameters.AddWithValue("@foto", NpgsqlTypes.NpgsqlDbType.Bytea, dataBaru.gambar);
                cmd.Parameters.AddWithValue("@id", id);

                Execute_No_Return(cmd);
            }
        }
        public class Akun
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Nama { get; set; }
            public string Email { get; set; }
            public string Nomor_Hp { get; set; }
            public byte[] gambar {  get; set; }
        }
    }
}
