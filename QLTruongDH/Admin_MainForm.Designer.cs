namespace QLTruongDH
{
    partial class Admin_MainForm
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
            status_bar_panel = new Panel();
            menuTransition = new System.Windows.Forms.Timer(components);
            out_menu_pictureBox = new PictureBox();
            out_menu_label = new Label();
            out_menu_flowLayoutPanel = new FlowLayoutPanel();
            setting_menu_pictureBox = new PictureBox();
            setting_menu_label = new Label();
            setting_menu_flowLayoutPanel = new FlowLayoutPanel();
            main_panel = new Panel();
            user_label = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            nav_drawer_flowLayoutPanel = new FlowLayoutPanel();
            menu_group_panel = new Panel();
            close_menu_pictureBox = new PictureBox();
            show_menu_pictureBox = new PictureBox();
            dashboard_menu_group_flowLayoutPanel = new FlowLayoutPanel();
            dashboard_menu_flowLayoutPanel = new FlowLayoutPanel();
            dashboard_menu_pictureBox = new PictureBox();
            dashboard_menu_label = new Label();
            user_flowLayoutPanel = new FlowLayoutPanel();
            user_pictureBox = new PictureBox();
            role_flowLayoutPanel = new FlowLayoutPanel();
            role_pictureBox = new PictureBox();
            role_label = new Label();
            ((System.ComponentModel.ISupportInitialize)out_menu_pictureBox).BeginInit();
            out_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setting_menu_pictureBox).BeginInit();
            setting_menu_flowLayoutPanel.SuspendLayout();
            nav_drawer_flowLayoutPanel.SuspendLayout();
            menu_group_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_menu_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)show_menu_pictureBox).BeginInit();
            dashboard_menu_group_flowLayoutPanel.SuspendLayout();
            dashboard_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_menu_pictureBox).BeginInit();
            user_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_pictureBox).BeginInit();
            role_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)role_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // status_bar_panel
            // 
            status_bar_panel.Location = new Point(98, 1169);
            status_bar_panel.Margin = new Padding(0);
            status_bar_panel.Name = "status_bar_panel";
            status_bar_panel.Size = new Size(1625, 40);
            status_bar_panel.TabIndex = 2;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // out_menu_pictureBox
            // 
            out_menu_pictureBox.Image = Properties.Resources.out_whitee;
            out_menu_pictureBox.Location = new Point(32, 24);
            out_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            out_menu_pictureBox.Name = "out_menu_pictureBox";
            out_menu_pictureBox.Size = new Size(32, 32);
            out_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            out_menu_pictureBox.TabIndex = 0;
            out_menu_pictureBox.TabStop = false;
            out_menu_pictureBox.Click += out_menu_pictureBox_Click;
            // 
            // out_menu_label
            // 
            out_menu_label.AutoSize = true;
            out_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            out_menu_label.ForeColor = Color.White;
            out_menu_label.Location = new Point(117, 24);
            out_menu_label.Margin = new Padding(50, 24, 3, 0);
            out_menu_label.Name = "out_menu_label";
            out_menu_label.Size = new Size(143, 37);
            out_menu_label.TabIndex = 1;
            out_menu_label.Text = "Đăng xuất";
            out_menu_label.Click += out_menu_label_Click;
            // 
            // out_menu_flowLayoutPanel
            // 
            out_menu_flowLayoutPanel.Controls.Add(out_menu_pictureBox);
            out_menu_flowLayoutPanel.Controls.Add(out_menu_label);
            out_menu_flowLayoutPanel.Location = new Point(0, 1045);
            out_menu_flowLayoutPanel.Margin = new Padding(0);
            out_menu_flowLayoutPanel.Name = "out_menu_flowLayoutPanel";
            out_menu_flowLayoutPanel.Size = new Size(380, 80);
            out_menu_flowLayoutPanel.TabIndex = 3;
            out_menu_flowLayoutPanel.WrapContents = false;
            out_menu_flowLayoutPanel.Click += out_menu_flowLayoutPanel_Click;
            // 
            // setting_menu_pictureBox
            // 
            setting_menu_pictureBox.Image = Properties.Resources.setting_whitee;
            setting_menu_pictureBox.Location = new Point(32, 24);
            setting_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            setting_menu_pictureBox.Name = "setting_menu_pictureBox";
            setting_menu_pictureBox.Size = new Size(32, 32);
            setting_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            setting_menu_pictureBox.TabIndex = 0;
            setting_menu_pictureBox.TabStop = false;
            // 
            // setting_menu_label
            // 
            setting_menu_label.AutoSize = true;
            setting_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            setting_menu_label.ForeColor = Color.White;
            setting_menu_label.Location = new Point(117, 24);
            setting_menu_label.Margin = new Padding(50, 24, 3, 0);
            setting_menu_label.Name = "setting_menu_label";
            setting_menu_label.Size = new Size(102, 37);
            setting_menu_label.TabIndex = 1;
            setting_menu_label.Text = "Cài đặt";
            // 
            // setting_menu_flowLayoutPanel
            // 
            setting_menu_flowLayoutPanel.Controls.Add(setting_menu_pictureBox);
            setting_menu_flowLayoutPanel.Controls.Add(setting_menu_label);
            setting_menu_flowLayoutPanel.Location = new Point(0, 965);
            setting_menu_flowLayoutPanel.Margin = new Padding(0);
            setting_menu_flowLayoutPanel.Name = "setting_menu_flowLayoutPanel";
            setting_menu_flowLayoutPanel.Size = new Size(380, 80);
            setting_menu_flowLayoutPanel.TabIndex = 2;
            setting_menu_flowLayoutPanel.WrapContents = false;
            // 
            // main_panel
            // 
            main_panel.Location = new Point(98, 0);
            main_panel.Margin = new Padding(0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1625, 1169);
            main_panel.TabIndex = 4;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_label.ForeColor = Color.White;
            user_label.Location = new Point(117, 24);
            user_label.Margin = new Padding(50, 24, 3, 0);
            user_label.Name = "user_label";
            user_label.Size = new Size(170, 37);
            user_label.TabIndex = 1;
            user_label.Text = "Quản lý user";
            user_label.Click += user_label_Click;
            // 
            // nav_drawer_flowLayoutPanel
            // 
            nav_drawer_flowLayoutPanel.BackColor = SystemColors.ActiveCaptionText;
            nav_drawer_flowLayoutPanel.Controls.Add(menu_group_panel);
            nav_drawer_flowLayoutPanel.Controls.Add(dashboard_menu_group_flowLayoutPanel);
            nav_drawer_flowLayoutPanel.Controls.Add(setting_menu_flowLayoutPanel);
            nav_drawer_flowLayoutPanel.Controls.Add(out_menu_flowLayoutPanel);
            nav_drawer_flowLayoutPanel.Dock = DockStyle.Left;
            nav_drawer_flowLayoutPanel.Location = new Point(0, 0);
            nav_drawer_flowLayoutPanel.Name = "nav_drawer_flowLayoutPanel";
            nav_drawer_flowLayoutPanel.Size = new Size(98, 1209);
            nav_drawer_flowLayoutPanel.TabIndex = 3;
            // 
            // menu_group_panel
            // 
            menu_group_panel.Controls.Add(close_menu_pictureBox);
            menu_group_panel.Controls.Add(show_menu_pictureBox);
            menu_group_panel.Location = new Point(0, 0);
            menu_group_panel.Margin = new Padding(0, 0, 0, 64);
            menu_group_panel.Name = "menu_group_panel";
            menu_group_panel.Size = new Size(388, 61);
            menu_group_panel.TabIndex = 2;
            // 
            // close_menu_pictureBox
            // 
            close_menu_pictureBox.Image = Properties.Resources.close1;
            close_menu_pictureBox.Location = new Point(310, 19);
            close_menu_pictureBox.Name = "close_menu_pictureBox";
            close_menu_pictureBox.Size = new Size(32, 32);
            close_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            close_menu_pictureBox.TabIndex = 1;
            close_menu_pictureBox.TabStop = false;
            close_menu_pictureBox.Click += close_menu_pictureBox_Click;
            // 
            // show_menu_pictureBox
            // 
            show_menu_pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            show_menu_pictureBox.Image = Properties.Resources.menu_icon;
            show_menu_pictureBox.Location = new Point(32, 19);
            show_menu_pictureBox.Margin = new Padding(0);
            show_menu_pictureBox.Name = "show_menu_pictureBox";
            show_menu_pictureBox.Size = new Size(32, 32);
            show_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            show_menu_pictureBox.TabIndex = 1;
            show_menu_pictureBox.TabStop = false;
            show_menu_pictureBox.Click += show_menu_pictureBox_Click;
            // 
            // dashboard_menu_group_flowLayoutPanel
            // 
            dashboard_menu_group_flowLayoutPanel.Controls.Add(dashboard_menu_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(user_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(role_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Location = new Point(0, 125);
            dashboard_menu_group_flowLayoutPanel.Margin = new Padding(0, 0, 0, 40);
            dashboard_menu_group_flowLayoutPanel.Name = "dashboard_menu_group_flowLayoutPanel";
            dashboard_menu_group_flowLayoutPanel.Size = new Size(380, 800);
            dashboard_menu_group_flowLayoutPanel.TabIndex = 4;
            // 
            // dashboard_menu_flowLayoutPanel
            // 
            dashboard_menu_flowLayoutPanel.BackColor = Color.Transparent;
            dashboard_menu_flowLayoutPanel.Controls.Add(dashboard_menu_pictureBox);
            dashboard_menu_flowLayoutPanel.Controls.Add(dashboard_menu_label);
            dashboard_menu_flowLayoutPanel.Location = new Point(0, 0);
            dashboard_menu_flowLayoutPanel.Margin = new Padding(0);
            dashboard_menu_flowLayoutPanel.Name = "dashboard_menu_flowLayoutPanel";
            dashboard_menu_flowLayoutPanel.Size = new Size(377, 80);
            dashboard_menu_flowLayoutPanel.TabIndex = 1;
            dashboard_menu_flowLayoutPanel.WrapContents = false;
            dashboard_menu_flowLayoutPanel.Click += dashboard_menu_flowLayoutPanel_Click;
            // 
            // dashboard_menu_pictureBox
            // 
            dashboard_menu_pictureBox.Image = Properties.Resources.dashboard_white;
            dashboard_menu_pictureBox.Location = new Point(32, 24);
            dashboard_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            dashboard_menu_pictureBox.Name = "dashboard_menu_pictureBox";
            dashboard_menu_pictureBox.Size = new Size(32, 32);
            dashboard_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            dashboard_menu_pictureBox.TabIndex = 0;
            dashboard_menu_pictureBox.TabStop = false;
            dashboard_menu_pictureBox.Click += dashboard_menu_pictureBox_Click;
            // 
            // dashboard_menu_label
            // 
            dashboard_menu_label.AutoSize = true;
            dashboard_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_menu_label.ForeColor = Color.White;
            dashboard_menu_label.Location = new Point(117, 24);
            dashboard_menu_label.Margin = new Padding(50, 24, 3, 0);
            dashboard_menu_label.Name = "dashboard_menu_label";
            dashboard_menu_label.Size = new Size(138, 37);
            dashboard_menu_label.TabIndex = 1;
            dashboard_menu_label.Text = "Trang chủ";
            dashboard_menu_label.Click += dashboard_menu_label_Click;
            // 
            // user_flowLayoutPanel
            // 
            user_flowLayoutPanel.BackColor = Color.Transparent;
            user_flowLayoutPanel.Controls.Add(user_pictureBox);
            user_flowLayoutPanel.Controls.Add(user_label);
            user_flowLayoutPanel.Location = new Point(0, 80);
            user_flowLayoutPanel.Margin = new Padding(0);
            user_flowLayoutPanel.Name = "user_flowLayoutPanel";
            user_flowLayoutPanel.Size = new Size(379, 80);
            user_flowLayoutPanel.TabIndex = 5;
            user_flowLayoutPanel.WrapContents = false;
            user_flowLayoutPanel.Click += user_flowLayoutPanel_Click;
            // 
            // user_pictureBox
            // 
            user_pictureBox.Image = Properties.Resources.user__11_;
            user_pictureBox.Location = new Point(32, 24);
            user_pictureBox.Margin = new Padding(32, 24, 3, 3);
            user_pictureBox.Name = "user_pictureBox";
            user_pictureBox.Size = new Size(32, 32);
            user_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            user_pictureBox.TabIndex = 0;
            user_pictureBox.TabStop = false;
            user_pictureBox.Click += user_pictureBox_Click;
            // 
            // role_flowLayoutPanel
            // 
            role_flowLayoutPanel.BackColor = Color.Transparent;
            role_flowLayoutPanel.Controls.Add(role_pictureBox);
            role_flowLayoutPanel.Controls.Add(role_label);
            role_flowLayoutPanel.Location = new Point(0, 160);
            role_flowLayoutPanel.Margin = new Padding(0);
            role_flowLayoutPanel.Name = "role_flowLayoutPanel";
            role_flowLayoutPanel.Size = new Size(377, 80);
            role_flowLayoutPanel.TabIndex = 7;
            role_flowLayoutPanel.WrapContents = false;
            role_flowLayoutPanel.Click += role_flowLayoutPanel_Click;
            // 
            // role_pictureBox
            // 
            role_pictureBox.Image = Properties.Resources.setting__1_;
            role_pictureBox.Location = new Point(32, 24);
            role_pictureBox.Margin = new Padding(32, 24, 3, 3);
            role_pictureBox.Name = "role_pictureBox";
            role_pictureBox.Size = new Size(32, 32);
            role_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            role_pictureBox.TabIndex = 0;
            role_pictureBox.TabStop = false;
            role_pictureBox.Click += role_pictureBox_Click;
            // 
            // role_label
            // 
            role_label.AutoSize = true;
            role_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            role_label.ForeColor = Color.White;
            role_label.Location = new Point(117, 24);
            role_label.Margin = new Padding(50, 24, 3, 0);
            role_label.Name = "role_label";
            role_label.Size = new Size(165, 37);
            role_label.TabIndex = 1;
            role_label.Text = "Quản lý role";
            role_label.Click += role_label_Click;
            // 
            // Admin_MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1724, 1209);
            Controls.Add(nav_drawer_flowLayoutPanel);
            Controls.Add(main_panel);
            Controls.Add(status_bar_panel);
            Name = "Admin_MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)out_menu_pictureBox).EndInit();
            out_menu_flowLayoutPanel.ResumeLayout(false);
            out_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)setting_menu_pictureBox).EndInit();
            setting_menu_flowLayoutPanel.ResumeLayout(false);
            setting_menu_flowLayoutPanel.PerformLayout();
            nav_drawer_flowLayoutPanel.ResumeLayout(false);
            menu_group_panel.ResumeLayout(false);
            menu_group_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)close_menu_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)show_menu_pictureBox).EndInit();
            dashboard_menu_group_flowLayoutPanel.ResumeLayout(false);
            dashboard_menu_flowLayoutPanel.ResumeLayout(false);
            dashboard_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_menu_pictureBox).EndInit();
            user_flowLayoutPanel.ResumeLayout(false);
            user_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user_pictureBox).EndInit();
            role_flowLayoutPanel.ResumeLayout(false);
            role_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)role_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel status_bar_panel;
        private System.Windows.Forms.Timer menuTransition;
        private PictureBox out_menu_pictureBox;
        private Label out_menu_label;
        private FlowLayoutPanel out_menu_flowLayoutPanel;
        private PictureBox setting_menu_pictureBox;
        private Label setting_menu_label;
        private FlowLayoutPanel setting_menu_flowLayoutPanel;
        private Panel main_panel;
        private Label user_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel nav_drawer_flowLayoutPanel;
        private Panel menu_group_panel;
        private PictureBox close_menu_pictureBox;
        private PictureBox show_menu_pictureBox;
        private FlowLayoutPanel dashboard_menu_group_flowLayoutPanel;
        private FlowLayoutPanel dashboard_menu_flowLayoutPanel;
        private PictureBox dashboard_menu_pictureBox;
        private Label dashboard_menu_label;
        private FlowLayoutPanel user_flowLayoutPanel;
        private PictureBox user_pictureBox;
        private FlowLayoutPanel role_flowLayoutPanel;
        private PictureBox role_pictureBox;
        private Label role_label;
    }
}