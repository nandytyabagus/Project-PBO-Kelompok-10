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
        [Key] public static int id_akun { get; set; }
        [Required] public static string username { get; set; }
        [Required] public static string password { get; set; }
        [Required] public static string nama { get; set; }
        [Required] public static string email { get; set; }
        [Required] public static string nomor_hp { get; set; }
    }
}
