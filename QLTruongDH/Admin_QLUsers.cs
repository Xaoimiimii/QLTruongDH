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
    public partial class Admin_QLUsers : UserControl
    {
        private Admin_MainForm mainForm;

        public Admin_QLUsers(Admin_MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new Admin_ThemSuaUser(mainForm, "Add"));
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new Admin_ThemSuaUser(mainForm, "Edit"));
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void search_employee_button_Click(object sender, EventArgs e)
        {

        }
    }
}
