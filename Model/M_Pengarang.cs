using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Pengarang
    {
        [Key]
        public int Id_Pengarang { get; set; }
        [Required]
        public string Nama_Pengarang { get; set; }
    }
}
