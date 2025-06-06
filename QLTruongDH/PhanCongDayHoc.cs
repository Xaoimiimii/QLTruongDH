﻿using System;
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
    public partial class PhanCongDayHoc : UserControl
    {
        private MainForm mainForm;
        private string mode;
        private MoMon selectedMoMon = new MoMon();

        public PhanCongDayHoc(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            edit_panel.Visible = false;
            VisibleAddMode();
        }

        private void PhanCongDayHoc_Load(object sender, EventArgs e)
        {
            LoadDsPhanCongTheoRole();
        }

        // === LOAD DATA ===
        private void LoadDsPhanCongTheoRole()
        {
            if (mainForm.roles.Contains("TRGDV"))
            {
                LoadDsPhanCong("SP_Xem_DSMoMonChoTRGDV");
                phanCong_dataGridView.Columns[0].HeaderText = "Mã MM";
                phanCong_dataGridView.Columns[1].HeaderText = "Mã HP";
                phanCong_dataGridView.Columns[2].HeaderText = "Tên HP";
                phanCong_dataGridView.Columns[3].HeaderText = "Mã GV";
                phanCong_dataGridView.Columns[4].HeaderText = "Tên GV";
                phanCong_dataGridView.Columns[5].HeaderText = "Học kỳ";
                phanCong_dataGridView.Columns[6].HeaderText = "Năm";

            }
            else if (mainForm.roles.Contains("PDT"))
            {
                LoadDsPhanCong("SP_Xem_DSMoMonChoNVPDT");
                phanCong_dataGridView.Columns[0].HeaderText = "Mã MM";
                phanCong_dataGridView.Columns[1].HeaderText = "Mã HP";
                phanCong_dataGridView.Columns[2].HeaderText = "Tên HP";
                phanCong_dataGridView.Columns[3].HeaderText = "Mã GV";
                phanCong_dataGridView.Columns[4].HeaderText = "Học kỳ";
                phanCong_dataGridView.Columns[5].HeaderText = "Năm";
            }
            else if (mainForm.roles.Contains("GIAOVIEN"))
            {
                LoadDsPhanCong("SP_Xem_DSMoMonChoGV");
                phanCong_dataGridView.Columns[0].HeaderText = "Mã MM";
                phanCong_dataGridView.Columns[1].HeaderText = "Mã HP";
                phanCong_dataGridView.Columns[2].HeaderText = "Tên HP";
                phanCong_dataGridView.Columns[3].HeaderText = "Mã GV";
                phanCong_dataGridView.Columns[4].HeaderText = "Tên GV";
                phanCong_dataGridView.Columns[5].HeaderText = "Học kỳ";
                phanCong_dataGridView.Columns[6].HeaderText = "Năm";
            }
            else if (mainForm.roles.Contains("SINHVIEN"))
            {
                title_label.Text = "Danh sách mở học phần";
                LoadDsPhanCong("SP_Xem_DSMoMonChoSV");
                phanCong_dataGridView.Columns[0].HeaderText = "Mã MM";
                phanCong_dataGridView.Columns[1].HeaderText = "Mã HP";
                phanCong_dataGridView.Columns[2].HeaderText = "Tên HP";
                phanCong_dataGridView.Columns[3].HeaderText = "Mã GV";
                phanCong_dataGridView.Columns[4].HeaderText = "Học kỳ";
                phanCong_dataGridView.Columns[5].HeaderText = "Năm";
            }
        }

        private void LoadDsPhanCong(string procName)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand(procName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //phanCong_dataGridView.AutoGenerateColumns = false;

                    //phanCong_dataGridView.Columns["MaMoMon"].DataPropertyName = "MAMM";
                    //phanCong_dataGridView.Columns["MaHocPhan"].DataPropertyName = "MAHP";
                    //phanCong_dataGridView.Columns["MaGiaoVien"].DataPropertyName = "MAGV";
                    //phanCong_dataGridView.Columns["HocKi"].DataPropertyName = "HK";
                    //phanCong_dataGridView.Columns["Nam"].DataPropertyName = "NAM";

                    phanCong_dataGridView.DataSource = dt;

                }
                catch (OracleException)
                {
                    MessageBox.Show($"Lỗi khi load danh sách phân công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ThemPhanCong()
        {
            string mahp = mahocphan_textBox.Text?.Trim() ?? "";
            string magv = magiaovien_textBox.Text?.Trim() ?? "";
            string nam = nam_textBox.Text?.Trim() ?? "";
            string hocky = hk_comboBox.SelectedItem?.ToString().Trim() ?? "";

            if (mahp == "" || magv == "" || hocky == "" || nam == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("SP_Them_MoMon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_mahp", OracleDbType.Varchar2).Value = mahp;
                    cmd.Parameters.Add("p_magv", OracleDbType.Varchar2).Value = magv;
                    cmd.Parameters.Add("p_hk", OracleDbType.Decimal).Value = hocky;
                    cmd.Parameters.Add("p_nam", OracleDbType.Decimal).Value = nam;

                    OracleParameter msgParam = new OracleParameter("p_msg", OracleDbType.Varchar2, 200);
                    msgParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(msgParam);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"{msgParam.Value.ToString()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetInputTextbox();
                    LoadDsPhanCongTheoRole();

                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khi thêm phân công mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SuaPhanCong()
        {
            string mahp = mahocphan_textBox.Text?.Trim() ?? "";
            string magv = magiaovien_textBox.Text?.Trim() ?? "";
            string nam = nam_textBox.Text?.Trim() ?? "";
            string hocky = hk_comboBox.SelectedItem?.ToString().Trim() ?? "";

            if (mahp == selectedMoMon.MaHP && magv == selectedMoMon.MaGV 
                && hocky == selectedMoMon.HK.ToString() && nam == selectedMoMon.Nam.ToString())
            {
                MessageBox.Show("Không có thay đổi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("SP_CapNhat_TTMoMon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_mamon", OracleDbType.Varchar2).Value = selectedMoMon.MaMM;
                    cmd.Parameters.Add("p_mahp", OracleDbType.Varchar2).Value = mahp;
                    cmd.Parameters.Add("p_magv", OracleDbType.Varchar2).Value = magv;
                    cmd.Parameters.Add("p_hk", OracleDbType.Decimal).Value = hocky;
                    cmd.Parameters.Add("p_nam", OracleDbType.Decimal).Value = nam;

                    OracleParameter msgParam = new OracleParameter("p_msg", OracleDbType.Varchar2, 200);
                    msgParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(msgParam);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"{msgParam.Value.ToString()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetInputTextbox();
                    LoadDsPhanCongTheoRole();

                }
                catch (Exception)
                {
                    MessageBox.Show($"Lỗi khi sửa phân công {selectedMoMon.MaMM}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XoaPhanCong()
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("SP_Xoa_MoMon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_mamon", OracleDbType.Varchar2, 10).Value = selectedMoMon.MaMM;
                    OracleParameter msgParam = new OracleParameter("p_msg", OracleDbType.Varchar2, 200);
                    msgParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(msgParam);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(msgParam.Value.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDsPhanCongTheoRole();
                }
                catch (OracleException)
                {
                    MessageBox.Show($"Lỗi khi xóa mở môn: {selectedMoMon.MaMM}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // === HELPER FUNCTION ===
        private void ResetInputTextbox()
        {
            mamomon_textBox.Text = "";
            nam_textBox.Text = "";
            mahocphan_textBox.Text = "";
            magiaovien_textBox.Text = "";
            hk_comboBox.SelectedIndex = -1;
        }

        private void VisibleEditMode()
        {
            mode = "Edit";
            edit_panel.Visible = true;
            input_panel.Visible = true;
            add_panel.Visible = false;
            action_label.Text = "Chỉnh sửa phân công:";
        }

        private void VisibleAddMode()
        {
            mode = "Add";
            add_panel.Visible = true;
            input_panel.Visible = true;
            edit_panel.Visible = false;
            action_label.Text = "Thêm phân công mới:";
        }

        private void ApplyFilters()
        {
            if (phanCong_dataGridView.DataSource is DataTable dt)
            {
                string searchHP = search_hocphan_guna2TextBox.Text.Trim();
                string searchGV = search_giaovien_guna2TextBox.Text.Trim();
                string searchHK = hocky_comboBox.SelectedItem?.ToString();
                string searchNam = search_nam_guna2TextBox.Text.Trim();

                List<string> filters = new List<string>();

                if (!string.IsNullOrEmpty(searchHP))
                    filters.Add($"MAHP LIKE '%{searchHP}%'");

                if (!string.IsNullOrEmpty(searchGV))
                    filters.Add($"MAGV LIKE '%{searchGV}%'");

                if (!string.IsNullOrEmpty(searchHK))
                    filters.Add($"HK = {searchHK}");

                if (!string.IsNullOrEmpty(searchNam))
                    filters.Add($"NAM = {searchNam}");

                string finalFilter = string.Join(" AND ", filters);
                dt.DefaultView.RowFilter = finalFilter;
            }
        }


        // === UI INTERACTION ===
        private void phanCong_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = phanCong_dataGridView.Rows[e.RowIndex];

                string maMM = row.Cells[0].Value?.ToString();
                string maHP = row.Cells[1].Value?.ToString();
                string maGV = row.Cells[3].Value?.ToString();
                int hk = 1;
                int nam = 2025;
                if (mainForm.roles.Contains("TRGDV") || mainForm.roles.Contains("GIAOVIEN"))
                {
                    hk = Convert.ToInt32(row.Cells[5].Value);
                    nam = Convert.ToInt32(row.Cells[6].Value);
                }
                else if (mainForm.roles.Contains("PDT") || mainForm.roles.Contains("SINHVIEN"))
                {
                    hk = Convert.ToInt32(row.Cells[4].Value);
                    nam = Convert.ToInt32(row.Cells[5].Value);
                }

                selectedMoMon = new MoMon
                {
                    MaMM = maMM,
                    MaHP = maHP,
                    MaGV = maGV,
                    HK = hk,
                    Nam = nam
                }
                ;

                ResetInputTextbox();
                VisibleEditMode();

                mamomon_textBox.Text = selectedMoMon.MaMM;
                mahocphan_textBox.Text = selectedMoMon.MaHP;
                magiaovien_textBox.Text = selectedMoMon.MaGV;
                nam_textBox.Text = selectedMoMon.Nam.ToString();
                hk_comboBox.SelectedItem = selectedMoMon.HK.ToString();
            }
        }

        private void PhanCongDayHoc_Click(object sender, EventArgs e)
        {
            if (mode != "Add")
            {
                VisibleAddMode();
                selectedMoMon = new MoMon();
                ResetInputTextbox();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa mở môn {selectedMoMon.MaMM} không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                XoaPhanCong();
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            ThemPhanCong();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            SuaPhanCong();
        }

        private void search_hocphan_guna2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyFilters();
            }
        }

        private void search_giaovien_guna2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyFilters();
            }
        }

        private void hocky_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void search_nam_guna2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyFilters();
            }
        }

        private void search_hocphan_guna2TextBox_IconRightClick(object sender, EventArgs e)
        {
            search_hocphan_guna2TextBox.Clear();
            LoadDsPhanCongTheoRole();
        }

        private void search_giaovien_guna2TextBox_IconRightClick(object sender, EventArgs e)
        {
            search_giaovien_guna2TextBox.Clear();
            LoadDsPhanCongTheoRole();
        }

        private void search_nam_guna2TextBox_IconRightClick(object sender, EventArgs e)
        {
            search_nam_guna2TextBox.Clear();
            LoadDsPhanCongTheoRole();
        }

        private void visible_add_button_Click(object sender, EventArgs e)
        {
            VisibleAddMode();
        }

        private void reset__button_Click(object sender, EventArgs e)
        {
            ResetInputTextbox();
        }
    }
}
