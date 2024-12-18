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

namespace Projek_SimBuku.Views.Massage_Box
{
    public partial class MassageBox : Form
    {
        C_MassageBox Controller;
        string Message;
        public MassageBox(C_MassageBox controller, string message)
        {
            InitializeComponent();
            this.Controller = controller;
            this.Message = message;
        }

        private void Iya_Click(object sender, EventArgs e)
        {
            Controller.confirmasi = true;
            this.Close();
        }

        private void Tidak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MassageBox_Load(object sender, EventArgs e)
        {
            Massage.Text = Message;
        }
    }
}
