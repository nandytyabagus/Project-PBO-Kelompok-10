using Projek_SimBuku.Controller;
using Projek_SimBuku.Views.Pelanggan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_SimBuku.Views
{
    public partial class Homepage_pelanggan : Form
    {
        C_Homepage Controller;
        public Homepage_pelanggan()
        {
            InitializeComponent();
            Controller = new C_Homepage(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Vhome = new Home(Controller);
            Controller.switchViewPelanggan(Controller.Vhome);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.VPeminjamanPelanggan = new PeminjamanPelanggan(Controller);
            Controller.switchViewPelanggan(Controller.VPeminjamanPelanggan);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Controller.VriwayatPelanggan = new RiwayatPelanggan(Controller);
            Controller.switchViewPelanggan(Controller.VriwayatPelanggan);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Controller.Vsetting = new Setting(Controller);
            Controller.switchViewPelanggan(Controller.Vsetting);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
