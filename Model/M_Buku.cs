using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Name { get; set; }
    }
}
