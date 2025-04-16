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
    public partial class Admin_ThemSuaRole : UserControl
    {
        private Admin_MainForm mainForm;
        private string mode;
        private bool isAddMode = false;
        private bool isEditMode = false;

        public Admin_ThemSuaRole(Admin_MainForm form, string mode)
        {
            InitializeComponent();
            this.mainForm = form;
            this.mode = mode;
        }
    }
}
