using Projek_SimBuku.Views.Admin.Transaksi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_Transaksi
    {
        C_Homepage chomepage;
        Transaksi vtransaksi;
        public C_Transaksi(C_Homepage homepage, Transaksi transaksi) 
        {
            chomepage = homepage;
            vtransaksi = transaksi;
        }
    }
}
