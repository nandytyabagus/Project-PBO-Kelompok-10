using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Peminjaman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_Peminjaman : Connector
    {
        C_Homepage Homepage;
        Peminjaman vpeminjaman;
        M_Transaksi m_transaksi = new M_Transaksi();
        public C_Peminjaman(C_Homepage homepage, Peminjaman peminjaman)
        {
            Homepage = homepage;
            vpeminjaman = peminjaman;
        }

        public void getData()
        {
            //if(m_transaksi)
        }
    }
}
