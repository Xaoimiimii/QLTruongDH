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
    public partial class ThemSuaPhanCong : UserControl
    {
        private MainForm mainForm;
        private string mode;
        private MoMon momon;

        public ThemSuaPhanCong(MainForm form, string mode, MoMon selectedMoMon)
        {
            InitializeComponent();
            this.mainForm = form;
            this.mode = mode;
            this.momon = selectedMoMon;
            HienThiData();
            if (mode == "Add")
            {
                mamomon_id_label.Visible = false;
            }
            else if (mode == "Edit")
            {
                mamomon_id_label.Visible = true;
                mamomon_id_label.Text = momon.MaMM;
                mahocphan_textBox.Text = momon.MaHP;
                magiaovien_textBox.Text = momon.MaGV;
                nam_textBox.Text = momon.Nam.ToString();
                hocky_comboBox.SelectedItem = momon.HK.ToString();
                title_label.Text = "Chỉnh sửa thông tin phân công";
                add_button.Text = "Cập nhật thông tin";
            }
        }


        // === LOAD, INSERT, UPDATE DATA ===


        // === HELPER FUNCTION ===
        private void Reset()
        {
            nam_textBox.Text = "";
            mahocphan_textBox.Text = "";
            magiaovien_textBox.Text = "";
            hocky_comboBox.SelectedIndex = -1;
        }

        private void HienThiData()
        {
            MessageBox.Show($"Mã môn mở: {momon.MaMM}\nMã học phần: {momon.MaHP}\nMã giảng viên: {momon.MaGV}\nHọc kỳ: {momon.HK}\nNăm: {momon.Nam}", "Thông tin phân công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // === UI INTERACTION ===
        private void reset__button_Click(object sender, EventArgs e)
        {
            if (mode == "Add") Reset();
            else if (mode == "Edit")
            {
                mahocphan_textBox.Text = momon.MaHP;
                magiaovien_textBox.Text = momon.MaGV;
                nam_textBox.Text = momon.Nam.ToString();
                hocky_comboBox.SelectedItem = momon.HK;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string mahocphan = mahocphan_textBox.Text?.Trim() ?? "";
            string magiaovien = magiaovien_textBox.Text?.Trim() ?? "";
            string nam = nam_textBox.Text?.Trim() ?? "";
            string hocky = hocky_comboBox.SelectedItem?.ToString().Trim() ?? "";
        }

        private void back_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (nam_textBox.Text != "" || magiaovien_textBox.Text != "" || mahocphan_textBox.Text != "" || hocky_comboBox.SelectedIndex != -1)
                    shouldWarn = true;
            }

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) mainForm.LoadControl(new PhanCongDayHoc(mainForm));
            }
            else mainForm.LoadControl(new PhanCongDayHoc(mainForm));
        }

        private void back_label_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (nam_textBox.Text != "" || magiaovien_textBox.Text != "" || mahocphan_textBox.Text != "" || hocky_comboBox.SelectedIndex != -1)
                    shouldWarn = true;
            }

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) mainForm.LoadControl(new PhanCongDayHoc(mainForm));
            }
            else mainForm.LoadControl(new PhanCongDayHoc(mainForm));
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (nam_textBox.Text != "" || magiaovien_textBox.Text != "" || mahocphan_textBox.Text != "" || hocky_comboBox.SelectedIndex != -1)
                    shouldWarn = true;
            }

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) mainForm.LoadControl(new PhanCongDayHoc(mainForm));
            }
            else mainForm.LoadControl(new PhanCongDayHoc(mainForm));
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

        private void back_flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.BurlyWood;
            back_pictureBox.Image = Properties.Resources.back__2_;
        }

        private void back_flowLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.Black;
            back_pictureBox.Image = Properties.Resources.back__1_;
        }
    }
}
