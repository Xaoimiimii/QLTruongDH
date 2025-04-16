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
    public partial class ThemNhanVien : UserControl
    {
        private MainForm mainForm;

        public ThemNhanVien(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
    }
}
