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

namespace Projek_SimBuku.Views.Pelanggan
{
    public partial class PeminjamanPelanggan : UserControl
    {
        C_Homepage Controller;
        public PeminjamanPelanggan(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
        }
    }
}
