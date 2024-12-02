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

namespace Projek_SimBuku.Views
{
    public partial class HomePage : Form
    {
        C_Homepage Controller;
        public HomePage()
        {
            InitializeComponent();
            Controller = new C_Homepage(this);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Controller.logOut_Admin();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Controller.switchView(Controller.Vdashboard);
        }

        private void buttonBuku_Click(object sender, EventArgs e)
        {
            Controller.switchView(Controller.Vbuku);
        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {
            Controller.switchView(Controller.Vpeminjaman);
        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            Controller.switchView(Controller.VPengembalian);
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            Controller.switchView(Controller.Vtransaksi);
        }
    }
}
