namespace QLTruongDH
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            nav_drawer_flowLayoutPanel = new FlowLayoutPanel();
            menu_group_panel = new Panel();
            close_menu_pictureBox = new PictureBox();
            show_menu_pictureBox = new PictureBox();
            dashboard_menu_group_flowLayoutPanel = new FlowLayoutPanel();
            dashboard_menu_flowLayoutPanel = new FlowLayoutPanel();
            dashboard_menu_pictureBox = new PictureBox();
            dashboard_menu_label = new Label();
            employee_flowLayoutPanel = new FlowLayoutPanel();
            employee_pictureBox = new PictureBox();
            employee_label = new Label();
            student_flowLayoutPanel = new FlowLayoutPanel();
            student_pictureBox = new PictureBox();
            student_label = new Label();
            assign_flowLayoutPanel = new FlowLayoutPanel();
            assign_pictureBox = new PictureBox();
            assign_label = new Label();
            course_flowLayoutPanel = new FlowLayoutPanel();
            course_pictureBox = new PictureBox();
            course_label = new Label();
            grade_flowLayoutPanel = new FlowLayoutPanel();
            grade_pictureBox = new PictureBox();
            grade_label = new Label();
            setting_menu_flowLayoutPanel = new FlowLayoutPanel();
            setting_menu_pictureBox = new PictureBox();
            setting_menu_label = new Label();
            out_menu_flowLayoutPanel = new FlowLayoutPanel();
            out_menu_pictureBox = new PictureBox();
            out_menu_label = new Label();
            menuTransition = new System.Windows.Forms.Timer(components);
            main_panel = new Panel();
            status_bar_panel = new Panel();
            nav_drawer_flowLayoutPanel.SuspendLayout();
            menu_group_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_menu_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)show_menu_pictureBox).BeginInit();
            dashboard_menu_group_flowLayoutPanel.SuspendLayout();
            dashboard_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_menu_pictureBox).BeginInit();
            employee_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employee_pictureBox).BeginInit();
            student_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_pictureBox).BeginInit();
            assign_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)assign_pictureBox).BeginInit();
            course_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)course_pictureBox).BeginInit();
            grade_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grade_pictureBox).BeginInit();
            setting_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setting_menu_pictureBox).BeginInit();
            out_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)out_menu_pictureBox).BeginInit();
            SuspendLayout();
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
            nav_drawer_flowLayoutPanel.TabIndex = 0;
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
            close_menu_pictureBox.Location = new Point(336, 19);
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
            dashboard_menu_group_flowLayoutPanel.Controls.Add(employee_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(student_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(assign_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(course_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(grade_flowLayoutPanel);
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
            // employee_flowLayoutPanel
            // 
            employee_flowLayoutPanel.BackColor = Color.Transparent;
            employee_flowLayoutPanel.Controls.Add(employee_pictureBox);
            employee_flowLayoutPanel.Controls.Add(employee_label);
            employee_flowLayoutPanel.Location = new Point(0, 80);
            employee_flowLayoutPanel.Margin = new Padding(0);
            employee_flowLayoutPanel.Name = "employee_flowLayoutPanel";
            employee_flowLayoutPanel.Size = new Size(379, 80);
            employee_flowLayoutPanel.TabIndex = 5;
            employee_flowLayoutPanel.WrapContents = false;
            employee_flowLayoutPanel.Click += employee_flowLayoutPanel_Click;
            // 
            // employee_pictureBox
            // 
            employee_pictureBox.Image = Properties.Resources.man;
            employee_pictureBox.Location = new Point(32, 24);
            employee_pictureBox.Margin = new Padding(32, 24, 3, 3);
            employee_pictureBox.Name = "employee_pictureBox";
            employee_pictureBox.Size = new Size(32, 32);
            employee_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            employee_pictureBox.TabIndex = 0;
            employee_pictureBox.TabStop = false;
            employee_pictureBox.Click += employee_pictureBox_Click;
            // 
            // employee_label
            // 
            employee_label.AutoSize = true;
            employee_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employee_label.ForeColor = Color.White;
            employee_label.Location = new Point(117, 24);
            employee_label.Margin = new Padding(50, 24, 3, 0);
            employee_label.Name = "employee_label";
            employee_label.Size = new Size(238, 37);
            employee_label.TabIndex = 1;
            employee_label.Text = "Quản lý nhân viên";
            employee_label.Click += employee_label_Click;
            // 
            // student_flowLayoutPanel
            // 
            student_flowLayoutPanel.BackColor = Color.Transparent;
            student_flowLayoutPanel.Controls.Add(student_pictureBox);
            student_flowLayoutPanel.Controls.Add(student_label);
            student_flowLayoutPanel.Location = new Point(0, 160);
            student_flowLayoutPanel.Margin = new Padding(0);
            student_flowLayoutPanel.Name = "student_flowLayoutPanel";
            student_flowLayoutPanel.Size = new Size(377, 80);
            student_flowLayoutPanel.TabIndex = 7;
            student_flowLayoutPanel.WrapContents = false;
            student_flowLayoutPanel.Click += student_flowLayoutPanel_Click;
            // 
            // student_pictureBox
            // 
            student_pictureBox.Image = Properties.Resources.student;
            student_pictureBox.Location = new Point(32, 24);
            student_pictureBox.Margin = new Padding(32, 24, 3, 3);
            student_pictureBox.Name = "student_pictureBox";
            student_pictureBox.Size = new Size(32, 32);
            student_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            student_pictureBox.TabIndex = 0;
            student_pictureBox.TabStop = false;
            student_pictureBox.Click += student_pictureBox_Click;
            // 
            // student_label
            // 
            student_label.AutoSize = true;
            student_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            student_label.ForeColor = Color.White;
            student_label.Location = new Point(117, 24);
            student_label.Margin = new Padding(50, 24, 3, 0);
            student_label.Name = "student_label";
            student_label.Size = new Size(227, 37);
            student_label.TabIndex = 1;
            student_label.Text = "Quản lý sinh viên";
            student_label.Click += student_label_Click;
            // 
            // assign_flowLayoutPanel
            // 
            assign_flowLayoutPanel.BackColor = Color.Transparent;
            assign_flowLayoutPanel.Controls.Add(assign_pictureBox);
            assign_flowLayoutPanel.Controls.Add(assign_label);
            assign_flowLayoutPanel.Location = new Point(0, 240);
            assign_flowLayoutPanel.Margin = new Padding(0);
            assign_flowLayoutPanel.Name = "assign_flowLayoutPanel";
            assign_flowLayoutPanel.Size = new Size(377, 80);
            assign_flowLayoutPanel.TabIndex = 8;
            assign_flowLayoutPanel.WrapContents = false;
            assign_flowLayoutPanel.Click += assign_flowLayoutPanel_Click;
            // 
            // assign_pictureBox
            // 
            assign_pictureBox.Image = Properties.Resources.task_list;
            assign_pictureBox.Location = new Point(32, 24);
            assign_pictureBox.Margin = new Padding(32, 24, 3, 3);
            assign_pictureBox.Name = "assign_pictureBox";
            assign_pictureBox.Size = new Size(32, 32);
            assign_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            assign_pictureBox.TabIndex = 0;
            assign_pictureBox.TabStop = false;
            assign_pictureBox.Click += assign_pictureBox_Click;
            // 
            // assign_label
            // 
            assign_label.AutoSize = true;
            assign_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assign_label.ForeColor = Color.White;
            assign_label.Location = new Point(117, 24);
            assign_label.Margin = new Padding(50, 24, 3, 0);
            assign_label.Name = "assign_label";
            assign_label.Size = new Size(250, 37);
            assign_label.TabIndex = 1;
            assign_label.Text = "Phân công dạy học";
            assign_label.Click += assign_label_Click;
            // 
            // course_flowLayoutPanel
            // 
            course_flowLayoutPanel.BackColor = Color.Transparent;
            course_flowLayoutPanel.Controls.Add(course_pictureBox);
            course_flowLayoutPanel.Controls.Add(course_label);
            course_flowLayoutPanel.Location = new Point(0, 320);
            course_flowLayoutPanel.Margin = new Padding(0);
            course_flowLayoutPanel.Name = "course_flowLayoutPanel";
            course_flowLayoutPanel.Size = new Size(379, 80);
            course_flowLayoutPanel.TabIndex = 9;
            course_flowLayoutPanel.WrapContents = false;
            course_flowLayoutPanel.Click += course_flowLayoutPanel_Click;
            // 
            // course_pictureBox
            // 
            course_pictureBox.Image = Properties.Resources.register_white;
            course_pictureBox.Location = new Point(32, 24);
            course_pictureBox.Margin = new Padding(32, 24, 3, 3);
            course_pictureBox.Name = "course_pictureBox";
            course_pictureBox.Size = new Size(32, 32);
            course_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            course_pictureBox.TabIndex = 0;
            course_pictureBox.TabStop = false;
            course_pictureBox.Click += course_pictureBox_Click;
            // 
            // course_label
            // 
            course_label.AutoSize = true;
            course_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            course_label.ForeColor = Color.White;
            course_label.Location = new Point(117, 24);
            course_label.Margin = new Padding(50, 24, 3, 0);
            course_label.Name = "course_label";
            course_label.Size = new Size(238, 37);
            course_label.TabIndex = 1;
            course_label.Text = "Đăng ký học phần";
            course_label.Click += course_label_Click;
            // 
            // grade_flowLayoutPanel
            // 
            grade_flowLayoutPanel.BackColor = Color.Transparent;
            grade_flowLayoutPanel.Controls.Add(grade_pictureBox);
            grade_flowLayoutPanel.Controls.Add(grade_label);
            grade_flowLayoutPanel.Location = new Point(0, 400);
            grade_flowLayoutPanel.Margin = new Padding(0);
            grade_flowLayoutPanel.Name = "grade_flowLayoutPanel";
            grade_flowLayoutPanel.Size = new Size(379, 80);
            grade_flowLayoutPanel.TabIndex = 6;
            grade_flowLayoutPanel.WrapContents = false;
            grade_flowLayoutPanel.Click += grade_flowLayoutPanel_Click;
            // 
            // grade_pictureBox
            // 
            grade_pictureBox.Image = Properties.Resources.grade_white;
            grade_pictureBox.Location = new Point(32, 24);
            grade_pictureBox.Margin = new Padding(32, 24, 3, 3);
            grade_pictureBox.Name = "grade_pictureBox";
            grade_pictureBox.Size = new Size(32, 32);
            grade_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            grade_pictureBox.TabIndex = 0;
            grade_pictureBox.TabStop = false;
            grade_pictureBox.Click += grade_pictureBox_Click;
            // 
            // grade_label
            // 
            grade_label.AutoSize = true;
            grade_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grade_label.ForeColor = Color.White;
            grade_label.Location = new Point(117, 24);
            grade_label.Margin = new Padding(50, 24, 3, 0);
            grade_label.Name = "grade_label";
            grade_label.Size = new Size(147, 37);
            grade_label.TabIndex = 1;
            grade_label.Text = "Bảng điểm";
            grade_label.Click += grade_label_Click;
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
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // main_panel
            // 
            main_panel.Location = new Point(98, 0);
            main_panel.Margin = new Padding(0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1625, 1169);
            main_panel.TabIndex = 1;
            // 
            // status_bar_panel
            // 
            status_bar_panel.Location = new Point(98, 1169);
            status_bar_panel.Margin = new Padding(0);
            status_bar_panel.Name = "status_bar_panel";
            status_bar_panel.Size = new Size(1625, 40);
            status_bar_panel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1724, 1209);
            Controls.Add(nav_drawer_flowLayoutPanel);
            Controls.Add(main_panel);
            Controls.Add(status_bar_panel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            nav_drawer_flowLayoutPanel.ResumeLayout(false);
            menu_group_panel.ResumeLayout(false);
            menu_group_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)close_menu_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)show_menu_pictureBox).EndInit();
            dashboard_menu_group_flowLayoutPanel.ResumeLayout(false);
            dashboard_menu_flowLayoutPanel.ResumeLayout(false);
            dashboard_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_menu_pictureBox).EndInit();
            employee_flowLayoutPanel.ResumeLayout(false);
            employee_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employee_pictureBox).EndInit();
            student_flowLayoutPanel.ResumeLayout(false);
            student_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)student_pictureBox).EndInit();
            assign_flowLayoutPanel.ResumeLayout(false);
            assign_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)assign_pictureBox).EndInit();
            course_flowLayoutPanel.ResumeLayout(false);
            course_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)course_pictureBox).EndInit();
            grade_flowLayoutPanel.ResumeLayout(false);
            grade_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grade_pictureBox).EndInit();
            setting_menu_flowLayoutPanel.ResumeLayout(false);
            setting_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)setting_menu_pictureBox).EndInit();
            out_menu_flowLayoutPanel.ResumeLayout(false);
            out_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)out_menu_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel nav_drawer_flowLayoutPanel;
        private PictureBox show_menu_pictureBox;
        private Panel menu_group_panel;
        private PictureBox close_menu_pictureBox;
        private FlowLayoutPanel dashboard_menu_flowLayoutPanel;
        private PictureBox dashboard_menu_pictureBox;
        private Label dashboard_menu_label;
        private FlowLayoutPanel setting_menu_flowLayoutPanel;
        private PictureBox setting_menu_pictureBox;
        private Label setting_menu_label;
        private FlowLayoutPanel out_menu_flowLayoutPanel;
        private PictureBox out_menu_pictureBox;
        private Label out_menu_label;
        private FlowLayoutPanel dashboard_menu_group_flowLayoutPanel;
        private FlowLayoutPanel employee_flowLayoutPanel;
        private PictureBox employee_pictureBox;
        private Label employee_label;
        private FlowLayoutPanel grade_flowLayoutPanel;
        private PictureBox grade_pictureBox;
        private Label grade_label;
        private FlowLayoutPanel student_flowLayoutPanel;
        private PictureBox student_pictureBox;
        private Label student_label;
        private FlowLayoutPanel assign_flowLayoutPanel;
        private PictureBox assign_pictureBox;
        private Label assign_label;
        private FlowLayoutPanel course_flowLayoutPanel;
        private PictureBox course_pictureBox;
        private Label course_label;
        private System.Windows.Forms.Timer menuTransition;
        private Panel main_panel;
        private Panel status_bar_panel;
    }
}
