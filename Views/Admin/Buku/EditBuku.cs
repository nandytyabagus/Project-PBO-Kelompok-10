using Projek_SimBuku.Controller;
using Projek_SimBuku.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projek_SimBuku.Views.Admin.Buku
{
    public partial class EditBuku : UserControl
    {
        C_Buku buku;
        public EditBuku(C_Buku c_Buku)
        {
            InitializeComponent();
            buku = c_Buku;
        }

        private void EditBuku_Load(object sender, EventArgs e)
        {

        }
    }
}
