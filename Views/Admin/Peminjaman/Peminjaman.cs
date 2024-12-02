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

namespace Projek_SimBuku.Views.Peminjaman
{
    public partial class Peminjaman : UserControl
    {
        C_Homepage Controller;
        public Peminjaman(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
        }
    }
}
