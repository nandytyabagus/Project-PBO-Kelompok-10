using Projek_SimBuku.Controller;

namespace Projek_SimBuku
{
    public partial class LoginRegister : Form
    {
        C_LoginRegister Controller;
        private bool dragging = false;
        private Point mouseOffset;
        public LoginRegister()
        {
            InitializeComponent();
            Controller = new C_LoginRegister(this);
        }
        private void button_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                mouseOffset = new Point(e.X, e.Y);
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - mouseOffset.X;
                newLocation.Y += e.Y - mouseOffset.Y;
                this.Location = newLocation;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
