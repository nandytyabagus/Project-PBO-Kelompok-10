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
    public partial class MassageBox_NoButton : Form
    {
        int time;
        public MassageBox_NoButton(string massege)
        {
            InitializeComponent();
            timer1.Start();
            Massage.Text = massege;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time < 10)
            {
                time++;
            }
            else
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
