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

namespace Projek_SimBuku.Views.Pengembalian
{
    public partial class Pengembalian : UserControl
    {
        C_Homepage Controller;
        public Pengembalian(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
        }
    }
}
