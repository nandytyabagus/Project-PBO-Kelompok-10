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
        [Key]
        public int Id_Keranjang { get; set; }
        [ForeignKey("M_Akun")]
        public int id_akun {  get; set; }
        [ForeignKey("M_Buku")]
        public int Id_Buku {  get; set; }
        [Required]
        public int jumlah { get; set; }
    }
}
