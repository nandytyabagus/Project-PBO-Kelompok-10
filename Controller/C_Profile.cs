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

namespace Projek_SimBuku.Controller
{
    public class C_Profile : Connector
    {
        C_Homepage vhomepage;
        Setting vsetting;
        M_Akun m_akun = new M_Akun();
        bool edit;
        public C_Profile(C_Homepage homepage, Setting setting) 
        { 
            vhomepage = homepage;
            vsetting = setting;
        }
        public void Get()
        {
            DataTable data = Execute_With_Return($"SELECT * FROM Data_Akun WHERE id_akun = {M_Session.Id}");
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                m_akun.id_akun = Convert.ToInt32(row["id_Akun"]);
                m_akun.username = row["username"].ToString();
                m_akun.password = row["password"].ToString();
                m_akun.nama = row["nama"].ToString();
                m_akun.email = row["email"].ToString();
                m_akun.nomor_hp = row["nomor_hp"].ToString();
                m_akun.gambar = row["Gambar"] != DBNull.Value ? (byte[])row["Gambar"] : null;
            }
        }

        public void loadDataAkun()
        {
            if (m_akun.gambar != null && m_akun.gambar.Length > 0)
                vsetting.pictureBox1.Image = Image.FromStream(new MemoryStream(m_akun.gambar));

            //vsetting.nama.Text = m_akun.nama;
            //vsetting.username.Text = m_akun.username;
            //vsetting.password.Text = m_akun.password;
            //vsetting.email.Text = m_akun.email;
            //vsetting.nomor.Text = m_akun.nomor_hp;
        }
        public void UbahData()
        {
            Akun data = new Akun()
            {
                //Password = vsetting.password.Text,
                //Nama = vsetting.nama.Text,
                //Email = vsetting.email.Text,
                gambar = (byte[])new ImageConverter().ConvertTo(vsetting.pictureBox1.Image, typeof(byte[]))
            };
            try
            {
                Update(data,M_Sementara.id);
                vhomepage.switchViewPelanggan(vsetting);
            }
            catch 
            {
                MessageBox.Show($"Terjadi kesalahan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
