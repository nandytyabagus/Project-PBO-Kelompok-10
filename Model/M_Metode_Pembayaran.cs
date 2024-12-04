using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Metode_Pembayaran
    {
        [Key]
        public int Id_Metode_Pembayaran {  get; set; }
        [Required]
        public string Metode { get; set; }
    }
}
