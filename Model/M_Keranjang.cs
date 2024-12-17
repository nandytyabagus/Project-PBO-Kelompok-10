using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Keranjang
    {
        public static List<M_Keranjang> StaticCartItems = new List<M_Keranjang>();
        public int Id_Buku { get; set; }
        public string Judul_buku { get; set; }
        public byte[] Gambar { get; set; }
        public string Genre { get; set; }
    }

}
