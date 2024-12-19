using Projek_SimBuku.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projek_SimBuku.Controller
{
    public class C_Dashboard : Connector
    {
        C_Homepage c_hompage;
        Dashboard Vdashboard;
        Info info;

        public C_Dashboard(C_Homepage homepage, Dashboard vdashboard)
        {
            c_hompage = homepage;
            Vdashboard = vdashboard;
            info = new Info();
            LoadAndShowInfo();
        }

        public void LoadAndShowInfo()
        {
            DataTable DataAkun = Execute_With_Return("SELECT COUNT(*) AS total FROM data_akun");
            info.dataAkun = Convert.ToInt32(DataAkun.Rows[0]["total"]);

            DataTable DataBuku = Execute_With_Return("SELECT COUNT(*) AS total FROM buku");
            info.dataBuku = Convert.ToInt32(DataBuku.Rows[0]["total"]);

            DataTable DataPeminjaman = Execute_With_Return("SELECT COUNT(*) AS total FROM transaksi WHERE status = 'Dipinjam'");
            info.dataPeminjaman = Convert.ToInt32(DataPeminjaman.Rows[0]["total"]);

            DataTable DataPengembalian = Execute_With_Return("SELECT COUNT(*) AS total FROM transaksi WHERE status = 'Kembali'");
            info.dataPengembalian = Convert.ToInt32(DataPengembalian.Rows[0]["total"]);

            if (info.dataAkun != 0)
            {
                Vdashboard.label8.Text = $"{info.dataAkun}";
            }
            else
            {
                Vdashboard.label8.Text = "00";
            }

            if (info.dataBuku != 0)
            {
                Vdashboard.label7.Text = $"{info.dataBuku}";
            }
            else
            {
                Vdashboard.label7.Text = "00";
            }
            if (info.dataPeminjaman != 0)
            {
                Vdashboard.label5.Text = $"{info.dataPeminjaman}";
            }
            else
            {
                Vdashboard.label5.Text = "00";
            }
            if (info.dataPengembalian != 0)
            {
                Vdashboard.label6.Text = $"{info.dataPengembalian}";
            }
            else
            {
                Vdashboard.label6.Text = "00";
            }
        }

        public class Info
        {
            public int dataPeminjaman { get; set; }
            public int dataPengembalian { get; set; }
            public int dataBuku { get; set; }
            public int dataAkun { get; set; }
        }
    }
}
