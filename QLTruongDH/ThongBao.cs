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
    public partial class ThongBao : UserControl
    {
        private MainForm mainForm;
        public ThongBao(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new ThemThongBao(mainForm));
        }
    }
}
