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
    public partial class PhanCongDayHoc : UserControl
    {
        private MainForm mainForm;

        public PhanCongDayHoc(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
    }
}
