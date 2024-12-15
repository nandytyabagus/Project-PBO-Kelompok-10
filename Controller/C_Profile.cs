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
using static Projek_SimBuku.Controller.C_LoginRegister;

namespace Projek_SimBuku.Controller
{
    public class C_Profile : Connector
    {
        C_Homepage vhomepage;
        Setting vsetting;
        M_Akun m_akun = new M_Akun();
        public C_Profile(C_Homepage homepage, Setting setting) 
        { 
            vhomepage = homepage;
            vsetting = setting;
        }
        public void Get(int id)
        {
            DataTable data = Execute_With_Return($"SELECT * FROM Data_Akun WHERE id_buku = {id}");

            if (data.Rows.Count > 0)
            {
                m_akun.id_akun = int.Parse(data.Rows[0]["id_Akun"].ToString());
                m_akun.username = data.Rows[0]["username"].ToString();
                m_akun.password = data.Rows[0]["password"].ToString();
                m_akun.nama = data.Rows[0]["nama"].ToString();
                m_akun.email = data.Rows[0]["email"].ToString();
                m_akun.nomor_hp = data.Rows[0]["nomor_hp"].ToString();
            }
        }
        public void loadDataAkun()
        {
            
        }
        public void Update(object obj, int id)
        {
            //M_Akun data = obj as M_Akun;
            //string querry = $"UPDATE Data_Akun SET password = '{data.password}', nama = '{data.nama}', email = '{data.email}', nomor_hp = '{data.nomor_hp}' WHERE akun_id = {akun.id_akun}";
            //Execute_No_Return(querry);
        }
    }
}
