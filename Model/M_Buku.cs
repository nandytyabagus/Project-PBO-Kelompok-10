using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Buku
    {
        
        [Key]
        public int Id_Buku { get; set; }
        [Required]
        public string Judul_buku { get; set; }
        [Required]
        public string Tahun_Terbit { get; set; }
        [Required]
        public byte[] Gambar {  get; set; }
        [Required]
        public int Stok {  get; set; }
        [Required]
        public string keterangan { get; set; }
        [ForeignKey("M_Pengarang")]
        public string Pengarang {  get; set; }
        [ForeignKey("M_Genre")]
        public string Genre {  get; set; }
        [ForeignKey("M_Penerbit")]
        public string Penerbit { get; set; }
        public virtual M_Pengarang pengarang { get; set; }
        public virtual M_Genre genre { get; set; }
        public virtual M_Penerbit penerbit { get; set; }
    }
}
