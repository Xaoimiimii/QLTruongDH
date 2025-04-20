namespace QLTruongDH
{
    public partial class MainForm : Form
    {
        bool menuExpand = false;
        public bool isInDashboard = false;
        public bool isInQLNhanVien = false;
        public bool isInQLSinhVien = false;
        public bool isInPhanCong = false;
        public bool isInDKHocPhan = false;
        public bool isInBangDiem = false;
        public  string connectionString;
        string username;
        string password;

        public MainForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
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

            //dashboard_menu_pictureBox.Image = Properties.Resources.dashboard_white;
            //employee_pictureBox.Image = Properties.Resources.register_white;
            //assign_pictureBox.Image = Properties.Resources.grade_white;
            //course_pictureBox.Image = Properties.Resources.cert_white;

            if (currentActivity == "Dashboard")
            {
                isInDashboard = true;
                dashboard_menu_pictureBox.Image = Properties.Resources.dashboard__2_;
            }
            else if (currentActivity == "QLNhanVien")
            {
                isInQLNhanVien = true;
                //employee_pictureBox.Image = Properties.Resources.register_green;
            }
            else if (currentActivity == "QLSinhVien")
            {
                isInQLSinhVien = true;
            }
            else if (currentActivity == "PhanCong")
            {
                isInPhanCong = true;
                //assign_pictureBox.Image = Properties.Resources.grade_green;
            }
            else if (currentActivity == "DKHocPhan")
            {
                isInDKHocPhan = true;
                //course_pictureBox.Image = Properties.Resources.cert_green;
            }
            else if (currentActivity == "BangDiem")
            {
                isInBangDiem = true;
                //grade_pictureBox.Image = Properties.Resources.cert_green;
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

        }

        private void out_menu_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void out_menu_label_Click(object sender, EventArgs e)
        {

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
    }
}
