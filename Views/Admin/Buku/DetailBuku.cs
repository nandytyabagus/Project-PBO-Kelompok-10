using Projek_SimBuku.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_SimBuku.Views.Admin.Buku
{
    public partial class DetailBuku : UserControl
    {
        C_Buku buku;
        public DetailBuku(C_Buku c_Buku)
        {
            InitializeComponent();
            buku = c_Buku;
        }
    }
}
