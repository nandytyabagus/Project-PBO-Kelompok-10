using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Genre
    {
        [Key]
        public int Id_Genre { get; set; }
        [Required]
        public string Genre { get; set; }
    }
}