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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            panel4 = new Panel();
            Search = new TextBox();
            button1 = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.c086f66e_0baf_426c_8627_adea8b1f6719;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(60, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(1800, 830);
            panel3.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(9, 131);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1754, 672);
            flowLayoutPanel1.TabIndex = 8;
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
            Search.TextChanged += Search_TextChanged;
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
    }
}
