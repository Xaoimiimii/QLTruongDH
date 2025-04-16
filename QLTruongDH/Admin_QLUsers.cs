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
    }
}
