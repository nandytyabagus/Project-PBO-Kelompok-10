namespace Projek_SimBuku.Views.Massage_Box
{
    partial class MassageBox
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
            Tidak = new Button();
            Iya = new Button();
            Massage = new Label();
            SuspendLayout();
            // 
            // Tidak
            // 
            Tidak.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            Tidak.Location = new Point(86, 199);
            Tidak.Name = "Tidak";
            Tidak.Padding = new Padding(0, 5, 0, 0);
            Tidak.Size = new Size(150, 45);
            Tidak.TabIndex = 0;
            Tidak.Text = "TIDAK";
            Tidak.UseVisualStyleBackColor = true;
            Tidak.Click += Tidak_Click;
            // 
            // Iya
            // 
            Iya.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            Iya.Location = new Point(269, 199);
            Iya.Name = "Iya";
            Iya.Padding = new Padding(0, 5, 0, 0);
            Iya.Size = new Size(150, 45);
            Iya.TabIndex = 1;
            Iya.Text = "YA";
            Iya.UseVisualStyleBackColor = true;
            Iya.Click += Iya_Click;
            // 
            // Massage
            // 
            Massage.BackColor = Color.Transparent;
            Massage.FlatStyle = FlatStyle.Flat;
            Massage.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Massage.Location = new Point(12, 40);
            Massage.Name = "Massage";
            Massage.Size = new Size(476, 94);
            Massage.TabIndex = 2;
            Massage.Text = "Massage";
            Massage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MassageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_13__2_;
            ClientSize = new Size(500, 300);
            Controls.Add(Massage);
            Controls.Add(Iya);
            Controls.Add(Tidak);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MassageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MassageBox";
            Load += MassageBox_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Tidak;
        private Button Iya;
        private Label Massage;
    }
}