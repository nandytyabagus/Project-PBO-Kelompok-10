using Projek_SimBuku.Views;
using Projek_SimBuku.Views.Admin.Buku;

namespace Projek_SimBuku
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Homepage_pelanggan());
        }
    }
}