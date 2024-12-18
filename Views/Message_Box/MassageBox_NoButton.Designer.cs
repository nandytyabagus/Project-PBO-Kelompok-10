namespace Projek_SimBuku.Views.Massage_Box
{
    partial class MassageBox_NoButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Massage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Massage
            // 
            Massage.BackColor = Color.Transparent;
            Massage.FlatStyle = FlatStyle.Flat;
            Massage.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Massage.Location = new Point(12, 67);
            Massage.Name = "Massage";
            Massage.Size = new Size(476, 94);
            Massage.TabIndex = 3;
            Massage.Text = "Massage";
            Massage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MassageBox_NoButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_13__2_1;
            ClientSize = new Size(500, 300);
            Controls.Add(Massage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MassageBox_NoButton";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MassageBox_NoButton";
            ResumeLayout(false);
        }

        #endregion

        private Label Massage;
        private System.Windows.Forms.Timer timer1;
    }
}