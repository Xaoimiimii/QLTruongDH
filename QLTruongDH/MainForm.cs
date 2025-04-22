namespace QLTruongDH
{
    public partial class MainForm : Form, ILogoutable
    {
        public event Action LogoutRequested;
        bool menuExpand = false;
        bool notiExpand = false;
        public bool isInDashboard = false;
        public bool isInQLNhanVien = false;
        public bool isInQLSinhVien = false;
        public bool isInPhanCong = false;
        public bool isInDKHocPhan = false;
        public bool isInBangDiem = false;
        public bool isInThongBao = false;
        public string connectionString;
        string username;
        string password;
        public List<string> roles = new List<string>();

        public MainForm(string username, string password, List<String> roles)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.roles = roles;
            connectionString = $"User Id={username};Password={password};Data Source=localhost:1521/PDB4;";
            LoadControl(new Dashboard(this));
            UpdateStatus("Dashboard");
        }

        public void LoadControl(UserControl control)
        {
            main_panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            main_panel.Controls.Add(control);
        }

        public void UpdateStatus(string currentActivity)
        {
            isInDashboard = false;
            isInQLNhanVien = false;
            isInQLSinhVien = false;
            isInPhanCong = false;
            isInDKHocPhan = false;
            isInBangDiem = false;
            isInThongBao = false;

            dashboard_menu_pictureBox.Image = Properties.Resources.dashboard_white;
            employee_pictureBox.Image = Properties.Resources.man;
            student_pictureBox.Image = Properties.Resources.student;
            assign_pictureBox.Image = Properties.Resources.use_case__1_;
            course_pictureBox.Image = Properties.Resources.memo__1_;
            grade_pictureBox.Image = Properties.Resources.grade_white;
            notification_pictureBox.Image = Properties.Resources.notification__1_;


            if (currentActivity == "Dashboard")
            {
                isInDashboard = true;
                dashboard_menu_pictureBox.Image = Properties.Resources.dashboard__2_;
            }
            else if (currentActivity == "QLNhanVien")
            {
                isInQLNhanVien = true;
                employee_pictureBox.Image = Properties.Resources.man__1_;
            }
            else if (currentActivity == "QLSinhVien")
            {
                isInQLSinhVien = true;
                student_pictureBox.Image = Properties.Resources.student__1_;
            }
            else if (currentActivity == "PhanCong")
            {
                isInPhanCong = true;
                assign_pictureBox.Image = Properties.Resources.use_case__2_;
            }
            else if (currentActivity == "DKHocPhan")
            {
                isInDKHocPhan = true;
                course_pictureBox.Image = Properties.Resources.memo;
            }
            else if (currentActivity == "BangDiem")
            {
                isInBangDiem = true;
                grade_pictureBox.Image = Properties.Resources.grade;
            }
            else if (currentActivity == "ThongBao")
            {
                isInThongBao = true;
                notification_pictureBox.Image = Properties.Resources.notification__2_;
            }
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                nav_drawer_flowLayoutPanel.Width -= 10;
                if (nav_drawer_flowLayoutPanel.Width <= 98)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
            else
            {
                nav_drawer_flowLayoutPanel.Width += 10;
                if (nav_drawer_flowLayoutPanel.Width >= 380)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
        }

        private void show_menu_pictureBox_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            show_menu_pictureBox.Visible = false;
        }

        private void close_menu_pictureBox_Click(object sender, EventArgs e)
        {
            show_menu_pictureBox.Visible = true;
            menuTransition.Start();
        }

        private void dashboard_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new Dashboard(this));
        }

        private void dashboard_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new Dashboard(this));
        }

        private void dashboard_menu_label_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new Dashboard(this));
        }

        private void out_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogoutRequested?.Invoke();
                this.Close();
            }
        }

        private void out_menu_pictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogoutRequested?.Invoke();
                this.Close();
            }
        }

        private void out_menu_label_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LogoutRequested?.Invoke();
                this.Close();
            }
        }

        private void employee_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInQLNhanVien)
            {
                return;
            }
            UpdateStatus("QLNhanVien");
            LoadControl(new QLNhanVien(this));
        }

        private void employee_label_Click(object sender, EventArgs e)
        {
            if (isInQLNhanVien)
            {
                return;
            }
            UpdateStatus("QLNhanVien");
            LoadControl(new QLNhanVien(this));
        }

        private void employee_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInQLNhanVien)
            {
                return;
            }
            UpdateStatus("QLNhanVien");
            LoadControl(new QLNhanVien(this));
        }

        private void student_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInQLSinhVien)
            {
                return;
            }
            UpdateStatus("QLSinhVien");
            LoadControl(new QLSinhVien(this));
        }

        private void student_label_Click(object sender, EventArgs e)
        {
            if (isInQLSinhVien)
            {
                return;
            }
            UpdateStatus("QLSinhVien");
            LoadControl(new QLSinhVien(this));
        }

        private void student_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInQLSinhVien)
            {
                return;
            }
            UpdateStatus("QLSinhVien");
            LoadControl(new QLSinhVien(this));
        }

        private void assign_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInPhanCong)
            {
                return;
            }
            UpdateStatus("PhanCong");
            LoadControl(new PhanCongDayHoc(this));
        }

        private void assign_label_Click(object sender, EventArgs e)
        {
            if (isInPhanCong)
            {
                return;
            }
            UpdateStatus("PhanCong");
            LoadControl(new PhanCongDayHoc(this));
        }

        private void assign_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInPhanCong)
            {
                return;
            }
            UpdateStatus("PhanCong");
            LoadControl(new PhanCongDayHoc(this));
        }

        private void course_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInDKHocPhan)
            {
                return;
            }
            UpdateStatus("DKHocPhan");
            LoadControl(new DangKyHocPhan(this));
        }

        private void course_label_Click(object sender, EventArgs e)
        {
            if (isInDKHocPhan)
            {
                return;
            }
            UpdateStatus("DKHocPhan");
            LoadControl(new DangKyHocPhan(this));
        }

        private void course_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInDKHocPhan)
            {
                return;
            }
            UpdateStatus("DKHocPhan");
            LoadControl(new DangKyHocPhan(this));
        }

        private void grade_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInBangDiem)
            {
                return;
            }
            UpdateStatus("BangDiem");
            LoadControl(new BangDiem(this));
        }

        private void grade_label_Click(object sender, EventArgs e)
        {
            if (isInBangDiem)
            {
                return;
            }
            UpdateStatus("BangDiem");
            LoadControl(new BangDiem(this));
        }

        private void grade_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInBangDiem)
            {
                return;
            }
            UpdateStatus("BangDiem");
            LoadControl(new BangDiem(this));
        }

        private void notification_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInThongBao)
            {
                return;
            }
            UpdateStatus("ThongBao");
            LoadControl(new ThongBao(this));
        }

        private void notification_label_Click(object sender, EventArgs e)
        {
            if (isInThongBao)
            {
                return;
            }
            UpdateStatus("ThongBao");
            LoadControl(new ThongBao(this));
        }

        private void notification_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInThongBao)
            {
                return;
            }
            UpdateStatus("ThongBao");
            LoadControl(new ThongBao(this));
        }

    }
}
