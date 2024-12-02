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

namespace Projek_SimBuku.Views.Buku
{
    public partial class Buku : UserControl
    {
        C_Homepage Controller;
        public Buku(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buku_Load(object sender, EventArgs e)
        {

        }
    }
}
