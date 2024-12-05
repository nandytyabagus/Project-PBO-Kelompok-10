using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Pelanggan;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_Profile : Connector
    {
        C_Homepage vhomepage;
        Setting vsetting;
        M_Akun akun = new M_Akun();
        public C_Profile(C_Homepage homepage, Setting setting) 
        { 
            vhomepage = homepage;
            vsetting = setting;
        }
        public void Update(object obj, int id)
        {
            //akun.password = ;
            //akun.nama = ;
            //akun.email = ;
            //akun.nomor_hp = ;
            M_Akun data = obj as M_Akun;
            string querry = $"UPDATE Data_Akun SET password = '{data.password}', nama = '{data.nama}', email = '{data.email}', nomor_hp = '{data.nomor_hp}' WHERE akun_id = {akun.id_akun}";
            Execute_Single_Return(querry);
        }
    }
}
