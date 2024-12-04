using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Penerbit
    {
        [Key]
        public int Id_Penerbit { get; set; }
        [Required]
        public string Penerbit { get; set; }
    }
}
