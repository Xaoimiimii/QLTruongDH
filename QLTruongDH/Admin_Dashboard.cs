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
    }
}
