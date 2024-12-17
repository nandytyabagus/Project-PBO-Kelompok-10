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
    public class M_Akun
    {
        [Key] public int id_akun { get; set; }
        [Required] public string username { get; set; }
        [Required] public string password { get; set; }
        [Required] public string nama { get; set; }
        [Required] public string email { get; set; }
        [Required] public string nomor_hp { get; set; }
        [Required] public byte[] gambar {  get; set; }
    }
}
