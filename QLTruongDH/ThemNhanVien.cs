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
        private NhanVien emp;

        public ThemNhanVien(MainForm form, string mode, NhanVien selectedEmployee)
        {
            InitializeComponent();
            this.mainForm = form;
            this.mode = mode;
            this.emp = selectedEmployee;

            LoadMaDonViComboBox();
            if (mode == "Add")
            {
                employee_id_label.Visible = false;
                title_label.Text = "Thêm nhân viên mới";
                add_button.Text = "Thêm nhân viên";
            }
            else if (mode == "Edit")
            {
                employee_id_label.Visible = true;
                employee_id_label.Text = emp.MaNV;
                fullname_textBox.Text = emp.HoTen;
                phone_textBox.Text = emp.DienThoai;
                dob_textBox.Text = emp.NgaySinh?.ToString("dd/MM/yyyy");
                luong_textBox.Text = emp.Luong.ToString();
                phucap_textBox.Text = emp.PhuCap.ToString();
                gender_comboBox.SelectedItem = emp.Phai;
                donvi_comboBox.SelectedItem = emp.MaDV;
                role_comboBox.SelectedItem = emp.VaiTro;
                title_label.Text = "Chỉnh sửa thông tin nhân niên";
                add_button.Text = "Cập nhật thông tin";
            }
        }

        
        // === LOAD, INSERT, UPDATE DATA ===
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
                            donvi_comboBox.Items.Add(madv);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khi load mã đơn vị ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddNewEmployee(string fullname, string gender, string dob, decimal luong, decimal phucap, string phone, string vaitro, string donvi)
        {
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
                catch (Exception)
                {
                    //MessageBox.Show("Lỗi ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateAllEmployeeInfo(string fullname, string gender, string dob, decimal luong, decimal phucap, string phone, string vaitro, string donvi)
        {
            bool isEdited = false;

            if (fullname != emp.HoTen || phone != emp.DienThoai || dob != emp.NgaySinh?.ToString("dd/MM/yyyy")
                || gender != emp.Phai || vaitro != emp.VaiTro || donvi != emp.MaDV || luong != emp.Luong || phucap != emp.PhuCap)
            {
                isEdited = true;
            }
            if (isEdited)
            {
                using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("SP_CapNhat_TTNhanVien", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_manv", OracleDbType.Char).Value = emp.MaNV;
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
                    }
                    catch (OracleException)
                    {
                        //MessageBox.Show("Lỗi kết nối Oracle: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có thay đổi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateEmployeePhone(string phone)
        {
            bool isEdited = false;
            if (phone != emp.DienThoai) isEdited = true;
            if (isEdited)
            {
                using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("SP_CapNhat_DTChoNVCB", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = emp.MaNV;
                        cmd.Parameters.Add("p_new_dt", OracleDbType.Varchar2).Value = phone;

                        OracleParameter msgParam = new OracleParameter("p_msg", OracleDbType.Varchar2, 200);
                        msgParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(msgParam);

                        cmd.ExecuteNonQuery();

                        string message = msgParam.Value.ToString();
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OracleException)
                    {
                        //MessageBox.Show("Lỗi kết nối Oracle: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có thay đổi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // === HELPER FUNCTION ===
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


        // === UI INTERACTION ===
        private void add_button_Click(object sender, EventArgs e)
        {
            string fullname = fullname_textBox.Text?.Trim() ?? "";
            string dob = dob_textBox.Text?.Trim() ?? "";
            string phone = phone_textBox.Text?.Trim() ?? "";

            string gender = gender_comboBox.SelectedItem?.ToString().Trim() ?? "";
            string vaitro = role_comboBox.SelectedItem?.ToString().Trim() ?? "";
            string donvi = donvi_comboBox.SelectedItem?.ToString().Trim() ?? "";

            decimal luong = 0;
            decimal phucap = 0;

            decimal.TryParse(luong_textBox.Text, out luong);
            decimal.TryParse(phucap_textBox.Text, out phucap);

            if (mode == "Add")
            {
                AddNewEmployee(fullname, gender, dob, luong, phucap, phone, vaitro, donvi);
            }
            else if (mode == "Edit")
            {
                if (mainForm.roles.Contains("TCHC"))
                {
                    UpdateAllEmployeeInfo(fullname, gender, dob, luong, phucap, phone, vaitro, donvi);
                }
                else if (mainForm.roles.Contains("NVCB"))
                {
                    UpdateEmployeePhone(phone);
                }
            }
        }

        private void reset__button_Click(object sender, EventArgs e)
        {
            if (mode == "Add") Reset();
            else if (mode == "Edit")
            {
                fullname_textBox.Text = emp.HoTen;
                phone_textBox.Text = emp.DienThoai;
                dob_textBox.Text = emp.NgaySinh?.ToString("dd/MM/yyyy");
                luong_textBox.Text = emp.Luong.ToString();
                phucap_textBox.Text = emp.PhuCap.ToString();
                role_comboBox.SelectedItem = emp.VaiTro;
                gender_comboBox.SelectedItem = emp.Phai;
                donvi_comboBox.SelectedItem = emp.MaDV;
            }
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
                if (result == DialogResult.Yes) mainForm.LoadControl(new QLNhanVien(mainForm));
            }
            else mainForm.LoadControl(new QLNhanVien(mainForm));
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
                if (result == DialogResult.Yes) mainForm.LoadControl(new QLNhanVien(mainForm));
            }
            else mainForm.LoadControl(new QLNhanVien(mainForm));
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
                if (result == DialogResult.Yes) mainForm.LoadControl(new QLNhanVien(mainForm));
            }
            else mainForm.LoadControl(new QLNhanVien(mainForm));
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
