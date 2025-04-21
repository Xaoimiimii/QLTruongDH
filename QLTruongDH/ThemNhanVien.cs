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
        private string mode;

        public ThemNhanVien(MainForm form, string mode)
        {
            InitializeComponent();
            this.mainForm = form;
            this.mode = mode;

            if (mode == "Add")
            {
                title_label.Text = "Thêm nhân viên mới";
                add_button.Text = "Thêm nhân viên";
            }
            else if (mode == "Edit")
            {
                title_label.Text = "Chỉnh sửa thông tin nhân niên";
                add_button.Text = "Cập nhật thông tin";
            }
        }
    }
}
