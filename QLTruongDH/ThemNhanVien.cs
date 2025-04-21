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

        private void back_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (fullname_textBox.Text != "" || phone_textBox.Text != ""
                    || dob_textBox.Text != "" || donvi_textBox.Text != "") shouldWarn = true;
                if (gender_comboBox.SelectedIndex != -1 || role_comboBox.SelectedIndex != -1) shouldWarn = true;
            }

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainForm.LoadControl(new QLNhanVien(mainForm));
                }
            }
            else
            {
                mainForm.LoadControl(new QLNhanVien(mainForm));
            }
        }

        private void back_label_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (fullname_textBox.Text != "" || phone_textBox.Text != ""
                    || dob_textBox.Text != "" || donvi_textBox.Text != "") shouldWarn = true;
                if (gender_comboBox.SelectedIndex != -1 || role_comboBox.SelectedIndex != -1) shouldWarn = true;
            }

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainForm.LoadControl(new QLNhanVien(mainForm));
                }
            }
            else
            {
                mainForm.LoadControl(new QLNhanVien(mainForm));
            }
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (fullname_textBox.Text != "" || phone_textBox.Text != ""
                    || dob_textBox.Text != "" || donvi_textBox.Text != "") shouldWarn = true;
                if (gender_comboBox.SelectedIndex != -1 || role_comboBox.SelectedIndex != -1) shouldWarn = true;
            }

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainForm.LoadControl(new QLNhanVien(mainForm));
                }
            }
            else
            {
                mainForm.LoadControl(new QLNhanVien(mainForm));
            }
        }

        private void back_flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.BurlyWood;
            back_pictureBox.Image = Properties.Resources.back__2_;
        }

        private void back_flowLayoutPanel_MouseLeave(object sender, EventArgs e)
        {

        }

        private void back_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.BurlyWood;
            back_pictureBox.Image = Properties.Resources.back__2_;
        }

        private void back_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.Black;
            back_pictureBox.Image = Properties.Resources.back__1_;
        }

        private void back_label_MouseEnter(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.BurlyWood;
            back_pictureBox.Image = Properties.Resources.back__2_;
        }

        private void back_label_MouseLeave(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.Black;
            back_pictureBox.Image = Properties.Resources.back__1_;
        }
    }
}
