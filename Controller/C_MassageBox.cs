using Projek_SimBuku.Views.Massage_Box;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_MassageBox
    {
        public bool confirmasi;
        public void showMassageBox(string massage)
        {
            MassageBox_NoButton massageBox = new MassageBox_NoButton(massage);
            massageBox.ShowDialog();
        }
        public bool showConfirm(string message)
        {
            MassageBox messagebox = new MassageBox(this, message);
            messagebox.ShowDialog();
            if (confirmasi)
            {
                confirmasi = false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
