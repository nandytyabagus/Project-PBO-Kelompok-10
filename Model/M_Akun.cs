using Projek_SimBuku.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Akun : Connector
    {
        public M_Akun() 
        {
            Setup();
        }

        public List<object> Get()
        {
            return new List<object>();
        }
        public void Get(string username , string password)
        {
            DataTable data = Execute_With_Return($"SELECT * FROM Data_Akun WHERE username = '{username}' and password = '{password}'");
            for (int i = 0; i < data.Rows.Count; i++)
            { 
                AkunLogin.id_akun = int.Parse(data.Rows[i]["id_Akun"].ToString());
                AkunLogin.username = data.Rows[i]["username"].ToString();
                AkunLogin.password = data.Rows[i]["password"].ToString();
                AkunLogin.nama = data.Rows[i]["nama"].ToString();
                AkunLogin.email = data.Rows[i]["email"].ToString();
                AkunLogin.nomor_hp = data.Rows[i]["nomor_hp"].ToString();
            }
        }
        public void Insert(object item)
        {
            Akun akun = item as Akun;
            Execute_No_Return($"INSERT INTO Data_Akun(username,password,nama,email,nomor_hp) VALUES ('{akun.Username}','{akun.Password}','{akun.Nama}','{akun.Email}','{akun.Nomor_Hp}')");
        }
        public void Update(object data,int id)
        {

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
    public class AkunLogin
    {
        [Key]public static int id_akun { get; set; } 
        [Required]public static string username { get; set; }
        [Required]public static string password { get; set; }
        [Required]public static string nama { get; set; }
        [Required]public static string email { get; set; }
        [Required]public static string nomor_hp {  get; set; }
    }
}
