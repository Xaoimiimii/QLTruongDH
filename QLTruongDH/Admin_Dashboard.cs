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
    public partial class Admin_Dashboard : UserControl
    {
        private Admin_MainForm mainForm;

        public Admin_Dashboard(Admin_MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            hello_label.Text = "Xin chào, " + mainForm.username;
            string dayOfWeek = DateTime.Now.ToString("dddd");
            if (dayOfWeek == "Monday") dayOfWeek = "Thứ 2";
            else if (dayOfWeek == "Tuesday") dayOfWeek = "Thứ 3";
            else if (dayOfWeek == "Wednesday") dayOfWeek = "Thứ 4";
            else if (dayOfWeek == "Thursday") dayOfWeek = "Thứ 5";
            else if (dayOfWeek == "Friday") dayOfWeek = "Thứ 6";
            else if (dayOfWeek == "Saturday") dayOfWeek = "Thứ 7";
            else if (dayOfWeek == "Sunday") dayOfWeek = "Chủ nhật";

            date_label.Text = DateTime.Now.ToString(dayOfWeek + ", dd/MM/yyyy");
        }

        private void qlUsers_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLUser");
            mainForm.LoadControl(new Admin_QLUsers(mainForm));
        }

        private void qlUsers_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLUser");
            mainForm.LoadControl(new Admin_QLUsers(mainForm));
        }

        private void qlUsers_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLUser");
            mainForm.LoadControl(new Admin_QLUsers(mainForm));
        }

        private void qlRoles_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLRole");
            mainForm.LoadControl(new Admin_QLRoles(mainForm));
        }

        private void qlRoles_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLRole");
            mainForm.LoadControl(new Admin_QLRoles(mainForm));
        }

        private void qlRoles_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLRole");
            mainForm.LoadControl(new Admin_QLRoles(mainForm));
        }

        private void qlUsers_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            qlUsers_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlUsers_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            qlUsers_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlUsers_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            qlUsers_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlUsers_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            qlUsers_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlUsers_label_MouseEnter(object sender, EventArgs e)
        {
            qlUsers_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlUsers_label_MouseLeave(object sender, EventArgs e)
        {
            qlUsers_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlRoles_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            qlRoles_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlRoles_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            qlRoles_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlRoles_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            qlRoles_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlRoles_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            qlRoles_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlRoles_label_MouseEnter(object sender, EventArgs e)
        {
            qlRoles_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlRoles_label_MouseLeave(object sender, EventArgs e)
        {
            qlRoles_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }
    }
}
