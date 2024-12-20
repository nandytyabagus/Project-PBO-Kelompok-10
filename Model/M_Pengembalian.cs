using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Pengembalian
    {
        [Key]
        public int Id_Transaksi { get; set; }
        [Required]
        public string tanggal_pengembalian { get; set; }
        [Required]
        public decimal harga_denda { get; set; }
        [Required]
        public string status { get; set; }
        public int id_akun { get; set; }
        public int id_buku { get; set; }
        
        public string Nama { get; set; }
        public string Judul_buku { get; set; }
        public string pengarang { get; set; }
    }
}
