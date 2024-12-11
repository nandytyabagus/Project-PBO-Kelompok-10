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

namespace Projek_SimBuku.Views.Admin.Buku
{
    public partial class CRUtambah : Form
    {
        C_Buku buku;
        bool EditMode;
        bool DetailMode;
        public CRUtambah(C_Buku c_Buku)
        {
            InitializeComponent();
            this.buku = c_Buku;
            buku.genre(this);
            EditMode = false;
            DetailMode = false;
        }
        public CRUtambah(M_Buku data, C_Buku c_Buku)
        {
            InitializeComponent();
            this.buku = c_Buku;
            buku.genre(this);
            EditMode = true;
            DetailMode = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                //UpdateBuku(); 
            }
            else
            {
                buku.Tambahbuku(this);
            }
            this.Close();
        }

        private void CRUtambah_Load(object sender, EventArgs e)
        {
            buku.ShowDataBuku();
        }
    }
}
