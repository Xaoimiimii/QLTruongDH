namespace QLTruongDH
{
    partial class Admin_Dashboard
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
            bg_pictureBox = new PictureBox();
            qlRoles_label = new Label();
            qlRoles_guna2ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            qlRoles_pictureBox = new PictureBox();
            qlUsers_label = new Label();
            qlUsers_pictureBox = new PictureBox();
            qlUsers_guna2ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            date_label = new Label();
            hello_label = new Label();
            ((System.ComponentModel.ISupportInitialize)bg_pictureBox).BeginInit();
            qlRoles_guna2ShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qlRoles_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qlUsers_pictureBox).BeginInit();
            qlUsers_guna2ShadowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bg_pictureBox
            // 
            bg_pictureBox.Image = Properties.Resources._46565226;
            bg_pictureBox.Location = new Point(0, -340);
            bg_pictureBox.Margin = new Padding(0);
            bg_pictureBox.Name = "bg_pictureBox";
            bg_pictureBox.Size = new Size(1625, 897);
            bg_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bg_pictureBox.TabIndex = 17;
            bg_pictureBox.TabStop = false;
            // 
            // qlRoles_label
            // 
            qlRoles_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qlRoles_label.ForeColor = Color.Black;
            qlRoles_label.Location = new Point(109, 250);
            qlRoles_label.Margin = new Padding(0);
            qlRoles_label.Name = "qlRoles_label";
            qlRoles_label.Size = new Size(456, 64);
            qlRoles_label.TabIndex = 1;
            qlRoles_label.Text = "Quản lý role";
            qlRoles_label.TextAlign = ContentAlignment.MiddleCenter;
            qlRoles_label.Click += qlRoles_label_Click;
            qlRoles_label.MouseEnter += qlRoles_label_MouseEnter;
            qlRoles_label.MouseLeave += qlRoles_label_MouseLeave;
            // 
            // qlRoles_guna2ShadowPanel
            // 
            qlRoles_guna2ShadowPanel.BackColor = Color.Transparent;
            qlRoles_guna2ShadowPanel.Controls.Add(qlRoles_label);
            qlRoles_guna2ShadowPanel.Controls.Add(qlRoles_pictureBox);
            qlRoles_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
            qlRoles_guna2ShadowPanel.Location = new Point(855, 640);
            qlRoles_guna2ShadowPanel.Margin = new Padding(0);
            qlRoles_guna2ShadowPanel.Name = "qlRoles_guna2ShadowPanel";
            qlRoles_guna2ShadowPanel.Radius = 10;
            qlRoles_guna2ShadowPanel.ShadowColor = Color.DimGray;
            qlRoles_guna2ShadowPanel.ShadowShift = 10;
            qlRoles_guna2ShadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            qlRoles_guna2ShadowPanel.Size = new Size(680, 488);
            qlRoles_guna2ShadowPanel.TabIndex = 13;
            qlRoles_guna2ShadowPanel.Click += qlRoles_guna2ShadowPanel_Click;
            qlRoles_guna2ShadowPanel.MouseEnter += qlRoles_guna2ShadowPanel_MouseEnter;
            qlRoles_guna2ShadowPanel.MouseLeave += qlRoles_guna2ShadowPanel_MouseLeave;
            // 
            // qlRoles_pictureBox
            // 
            qlRoles_pictureBox.Image = Properties.Resources.setting;
            qlRoles_pictureBox.Location = new Point(291, 145);
            qlRoles_pictureBox.Margin = new Padding(0);
            qlRoles_pictureBox.Name = "qlRoles_pictureBox";
            qlRoles_pictureBox.Size = new Size(100, 100);
            qlRoles_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            qlRoles_pictureBox.TabIndex = 0;
            qlRoles_pictureBox.TabStop = false;
            qlRoles_pictureBox.Click += qlRoles_pictureBox_Click;
            qlRoles_pictureBox.MouseEnter += qlRoles_pictureBox_MouseEnter;
            qlRoles_pictureBox.MouseLeave += qlRoles_pictureBox_MouseLeave;
            // 
            // qlUsers_label
            // 
            qlUsers_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qlUsers_label.ForeColor = Color.Black;
            qlUsers_label.Location = new Point(105, 250);
            qlUsers_label.Margin = new Padding(0);
            qlUsers_label.Name = "qlUsers_label";
            qlUsers_label.Size = new Size(456, 64);
            qlUsers_label.TabIndex = 1;
            qlUsers_label.Text = "Quản lý user";
            qlUsers_label.TextAlign = ContentAlignment.MiddleCenter;
            qlUsers_label.Click += qlUsers_label_Click;
            qlUsers_label.MouseEnter += qlUsers_label_MouseEnter;
            qlUsers_label.MouseLeave += qlUsers_label_MouseLeave;
            // 
            // qlUsers_pictureBox
            // 
            qlUsers_pictureBox.Image = Properties.Resources.user__9_;
            qlUsers_pictureBox.Location = new Point(287, 145);
            qlUsers_pictureBox.Margin = new Padding(0);
            qlUsers_pictureBox.Name = "qlUsers_pictureBox";
            qlUsers_pictureBox.Size = new Size(100, 100);
            qlUsers_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            qlUsers_pictureBox.TabIndex = 0;
            qlUsers_pictureBox.TabStop = false;
            qlUsers_pictureBox.Click += qlUsers_pictureBox_Click;
            qlUsers_pictureBox.MouseEnter += qlUsers_pictureBox_MouseEnter;
            qlUsers_pictureBox.MouseLeave += qlUsers_pictureBox_MouseLeave;
            // 
            // qlUsers_guna2ShadowPanel
            // 
            qlUsers_guna2ShadowPanel.BackColor = Color.Transparent;
            qlUsers_guna2ShadowPanel.Controls.Add(qlUsers_label);
            qlUsers_guna2ShadowPanel.Controls.Add(qlUsers_pictureBox);
            qlUsers_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
            qlUsers_guna2ShadowPanel.Location = new Point(92, 640);
            qlUsers_guna2ShadowPanel.Margin = new Padding(0);
            qlUsers_guna2ShadowPanel.Name = "qlUsers_guna2ShadowPanel";
            qlUsers_guna2ShadowPanel.Radius = 10;
            qlUsers_guna2ShadowPanel.ShadowColor = Color.DimGray;
            qlUsers_guna2ShadowPanel.ShadowShift = 10;
            qlUsers_guna2ShadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            qlUsers_guna2ShadowPanel.Size = new Size(680, 488);
            qlUsers_guna2ShadowPanel.TabIndex = 11;
            qlUsers_guna2ShadowPanel.Click += qlUsers_guna2ShadowPanel_Click;
            qlUsers_guna2ShadowPanel.MouseEnter += qlUsers_guna2ShadowPanel_MouseEnter;
            qlUsers_guna2ShadowPanel.MouseLeave += qlUsers_guna2ShadowPanel_MouseLeave;
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.BackColor = Color.White;
            date_label.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_label.ForeColor = Color.FromArgb(64, 64, 64);
            date_label.Location = new Point(92, 182);
            date_label.Margin = new Padding(0);
            date_label.Name = "date_label";
            date_label.Size = new Size(308, 50);
            date_label.TabIndex = 19;
            date_label.Text = "Thứ tư, 4/9/2025";
            // 
            // hello_label
            // 
            hello_label.AutoSize = true;
            hello_label.BackColor = Color.White;
            hello_label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hello_label.ForeColor = Color.Black;
            hello_label.Location = new Point(92, 83);
            hello_label.Margin = new Padding(0);
            hello_label.Name = "hello_label";
            hello_label.Size = new Size(459, 86);
            hello_label.TabIndex = 18;
            hello_label.Text = "Xin chào, user";
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(date_label);
            Controls.Add(hello_label);
            Controls.Add(bg_pictureBox);
            Controls.Add(qlRoles_guna2ShadowPanel);
            Controls.Add(qlUsers_guna2ShadowPanel);
            Name = "Admin_Dashboard";
            Size = new Size(1625, 1209);
            Load += Admin_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)bg_pictureBox).EndInit();
            qlRoles_guna2ShadowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)qlRoles_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)qlUsers_pictureBox).EndInit();
            qlUsers_guna2ShadowPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bg_pictureBox;
        private Label qlRoles_label;
        private Guna.UI2.WinForms.Guna2ShadowPanel qlRoles_guna2ShadowPanel;
        private PictureBox qlRoles_pictureBox;
        private Label qlUsers_label;
        private PictureBox qlUsers_pictureBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel qlUsers_guna2ShadowPanel;
        private Label date_label;
        private Label hello_label;
    }
}
