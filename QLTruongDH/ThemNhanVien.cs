using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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
            LoadMaDonViComboBox();
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

        private void LoadMaDonViComboBox()
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("SP_LAY_DS_MA_DON_VI", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string madv = reader.GetString(0);
                            // Thêm vào comboBox
                            donvi_comboBox.Items.Add(madv);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Reset()
        {
            fullname_textBox.Text = "";
            phone_textBox.Text = "";
            dob_textBox.Text = "";
            luong_textBox.Text = "";
            phucap_textBox.Text = "";
            donvi_comboBox.SelectedIndex = -1;
            gender_comboBox.SelectedIndex = -1;
            role_comboBox.SelectedIndex = -1;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string fullname = fullname_textBox.Text.Trim();
            string dob = dob_textBox.Text.Trim();
            string phone = phone_textBox.Text.Trim();
            string gender = gender_comboBox.SelectedItem.ToString();
            string vaitro = role_comboBox.SelectedItem.ToString();
            string donvi = donvi_comboBox.SelectedItem.ToString();

            decimal luong = 0;
            decimal phucap = 0;

            decimal.TryParse(luong_textBox.Text, out luong);
            decimal.TryParse(phucap_textBox.Text, out phucap);


            if (fullname == "" || gender == "" || dob == "" || phone == "" || vaitro == "" || donvi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("SP_Them_NhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_hoten", OracleDbType.Varchar2).Value = fullname;
                    cmd.Parameters.Add("p_phai", OracleDbType.Varchar2).Value = gender;
                    cmd.Parameters.Add("p_ngsinh", OracleDbType.Date).Value = dob;
                    cmd.Parameters.Add("p_luong", OracleDbType.Decimal).Value = luong;
                    cmd.Parameters.Add("p_phucap", OracleDbType.Decimal).Value = phucap;
                    cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = phone;
                    cmd.Parameters.Add("p_vaitro", OracleDbType.Varchar2).Value = vaitro;
                    cmd.Parameters.Add("p_madv", OracleDbType.Varchar2).Value = donvi;

                    OracleParameter msgParam = new OracleParameter("p_msg", OracleDbType.Varchar2, 200);
                    msgParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(msgParam);

                    cmd.ExecuteNonQuery();

                    string message = msgParam.Value.ToString();
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void reset__button_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void back_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (fullname_textBox.Text != "" || phone_textBox.Text != ""
                    || dob_textBox.Text != "" || donvi_comboBox.SelectedIndex != -1
                    || gender_comboBox.SelectedIndex != -1 || role_comboBox.SelectedIndex != -1) 
                    shouldWarn = true;
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
                    || dob_textBox.Text != "" || donvi_comboBox.SelectedIndex != -1
                    || gender_comboBox.SelectedIndex != -1 || role_comboBox.SelectedIndex != -1)
                    shouldWarn = true;
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
                    || dob_textBox.Text != "" || donvi_comboBox.SelectedIndex != -1
                    || gender_comboBox.SelectedIndex != -1 || role_comboBox.SelectedIndex != -1)
                    shouldWarn = true;
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
            back_label.ForeColor = Color.Black;
            back_pictureBox.Image = Properties.Resources.back__1_;
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
