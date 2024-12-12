namespace Projek_SimBuku.Views.Pelanggan
{
    partial class HomeKatalog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeKatalog));
            panel3 = new Panel();
            vScrollBar1 = new VScrollBar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Katalog = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            Search = new TextBox();
            button1 = new Button();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            Katalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.c086f66e_0baf_426c_8627_adea8b1f6719;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(vScrollBar1);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(60, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(1800, 830);
            panel3.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1772, 149);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(20, 647);
            vScrollBar1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Katalog);
            flowLayoutPanel1.Location = new Point(35, 131);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1730, 672);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // Katalog
            // 
            Katalog.BackColor = Color.White;
            Katalog.BackgroundImageLayout = ImageLayout.Stretch;
            Katalog.Controls.Add(pictureBox1);
            Katalog.Controls.Add(label1);
            Katalog.Location = new Point(35, 30);
            Katalog.Margin = new Padding(35, 30, 0, 0);
            Katalog.Name = "Katalog";
            Katalog.Size = new Size(250, 400);
            Katalog.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 337);
            label1.Name = "label1";
            label1.Size = new Size(220, 62);
            label1.TabIndex = 1;
            label1.Text = "Judul Buku";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(35, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(1730, 5);
            panel5.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Controls.Add(Search);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(35, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 80);
            panel4.TabIndex = 6;
            // 
            // Search
            // 
            Search.BackColor = Color.White;
            Search.BorderStyle = BorderStyle.None;
            Search.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.ForeColor = Color.Black;
            Search.Location = new Point(105, 22);
            Search.Name = "Search";
            Search.PlaceholderText = "Search";
            Search.Size = new Size(272, 39);
            Search.TabIndex = 1;
            Search.TextChanged += this.Search_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources._02de674a_a51c_4cd4_bad8_25a1c70748c4;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // HomeKatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Name = "HomeKatalog";
            Size = new Size(1920, 890);
            Load += Home_Load;
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            Katalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private TextBox Search;
        private Button button1;
        public FlowLayoutPanel flowLayoutPanel1;
        public Panel Katalog;
        private VScrollBar vScrollBar1;
        public PictureBox pictureBox1;
        private Label label1;
    }
}
