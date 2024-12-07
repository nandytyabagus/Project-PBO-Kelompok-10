using Projek_SimBuku.Views.Pelanggan;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Peminjaman
    {
        [Key]
        public int Id_Transaksi { get; set; }
        [Required]
        public string tanggal_pengambilan { get; set; }
        [Required]
        public decimal harga_sewa { get; set; }
        [Required]
        public string status { get; set; }
        public virtual M_Keranjang Keranjang { get; set; }
        [NotMapped]
        public string judul_buku => Keranjang?.Buku?.Judul_buku;
        [NotMapped]
        public string nama => Keranjang?.Akun?.nama;

    }
}
