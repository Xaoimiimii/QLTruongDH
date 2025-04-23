using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongDH
{
    public partial class Admin_MainForm : Form, ILogoutable
    {
        public event Action LogoutRequested;
        public string username;
        string password;
        bool menuExpand = false;
        public bool isInDashboard = false;
        public bool isInQLUser = false;
        public bool isInQLRole = false;
        public string connectionString;
        public Stack<UserControl> controlHistory = new Stack<UserControl>();

        public Admin_MainForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            connectionString = $"User Id={username};Password={password};Data Source=localhost:1521/PDB4;";
            LoadControl(new Admin_Dashboard(this));
            UpdateStatus("Dashboard");
        }


        public void LoadControl(UserControl control)
        {
            if (main_panel.Controls.Count > 0)
            {
                var currentControl = main_panel.Controls[0] as UserControl;
                if (currentControl != null)
                {
                    controlHistory.Push(currentControl); // lưu control hiện tại vào stack
                }
                main_panel.Controls.Clear();
            }

            control.Dock = DockStyle.Fill;
            main_panel.Controls.Add(control);

            //main_panel.Controls.Clear();
            //control.Dock = DockStyle.Fill;
            //main_panel.Controls.Add(control);
        }

        public void UpdateStatus(string currentActivity)
        {
            isInDashboard = false;
            isInQLUser = false;
            isInQLRole = false;

            dashboard_menu_pictureBox.Image = Properties.Resources.dashboard_white;
            user_pictureBox.Image = Properties.Resources.user__11_;
            role_pictureBox.Image = Properties.Resources.setting__1_;

            if (currentActivity == "Dashboard")
            {
                isInDashboard = true;
                dashboard_menu_pictureBox.Image = Properties.Resources.dashboard__2_;
            }
            else if (currentActivity == "QLUser")
            {
                isInQLUser = true;
                user_pictureBox.Image = Properties.Resources.user__10_;
            }
            else if (currentActivity == "QLRole")
            {
                isInQLRole = true;
                role_pictureBox.Image = Properties.Resources.setting__2_;
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
                if (nav_drawer_flowLayoutPanel.Width >= 360)
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
            LoadControl(new Admin_Dashboard(this));
        }

        private void dashboard_menu_label_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new Admin_Dashboard(this));
        }

        private void dashboard_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new Admin_Dashboard(this));
        }

        private void user_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInQLUser)
            {
                return;
            }
            UpdateStatus("QLUser");
            LoadControl(new Admin_QLUsers(this));
        }

        private void user_label_Click(object sender, EventArgs e)
        {
            if (isInQLUser)
            {
                return;
            }
            UpdateStatus("QLUser");
            LoadControl(new Admin_QLUsers(this));
        }

        private void user_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInQLUser)
            {
                return;
            }
            UpdateStatus("QLUser");
            LoadControl(new Admin_QLUsers(this));
        }

        private void role_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInQLRole)
            {
                return;
            }
            UpdateStatus("QLRole");
            LoadControl(new Admin_QLRoles(this));
        }

        private void role_label_Click(object sender, EventArgs e)
        {
            if (isInQLRole)
            {
                return;
            }
            UpdateStatus("QLRole");
            LoadControl(new Admin_QLRoles(this));
        }

        private void role_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInQLRole)
            {
                return;
            }
            UpdateStatus("QLRole");
            LoadControl(new Admin_QLRoles(this));
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

        private void out_menu_label_Click(object sender, EventArgs e)
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
    }
}
