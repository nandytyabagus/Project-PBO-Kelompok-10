using Projek_SimBuku.Views.Pengembalian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_Pengembalian : Connector
    {
        C_Homepage c_Homepage;
        Pengembalian vpengembalian;
        public C_Pengembalian(C_Homepage homepage, Pengembalian pengembalian) 
        {
            c_Homepage = homepage;
            vpengembalian = pengembalian;
        }
        public void update()
        {

        }
    }
}
