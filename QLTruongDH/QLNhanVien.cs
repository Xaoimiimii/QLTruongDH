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
    public partial class QLNhanVien : UserControl
    {
        private MainForm mainForm;
        private string selectedEmployeeID = string.Empty;

        public QLNhanVien(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;

            //HienThiDsRoles();

            // Nếu mainForm roles có chứa "TRGDV"
            if (mainForm.roles.Contains("TRGDV"))
            {
                LoadDsNhanVien("SP_Xem_DSNhanVienChoTRGDV");
            }
            else if (mainForm.roles.Contains("TCHC"))
            {
                LoadDsNhanVien("SP_Xem_DSNhanVien");
            }
            else if (mainForm.roles.Contains("NVCB"))
            {
                LoadDsNhanVien("SP_Xem_TTNhanVienChoNVCB");
            }

        }




        // === HELPER FUNCTION ===
        private void HienThiDsRoles()
        {
            string roles = string.Join(", ", mainForm.roles);
            MessageBox.Show($"Roles: {roles}", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // === LOAD DATA ===
        private void LoadDsNhanVien(string procName)
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

                    //employee_dataGridView.DataSource = dt;
                    employee_dataGridView.AutoGenerateColumns = false;

                    employee_dataGridView.Columns["MaNhanVien"].DataPropertyName = "MANV";
                    employee_dataGridView.Columns["HoTen"].DataPropertyName = "HOTEN";
                    employee_dataGridView.Columns["Phai"].DataPropertyName = "PHAI";
                    employee_dataGridView.Columns["NgSinh"].DataPropertyName = "NGSINH";
                    employee_dataGridView.Columns["Luong"].DataPropertyName = "LUONG";
                    employee_dataGridView.Columns["PhuCap"].DataPropertyName = "PHUCAP";
                    employee_dataGridView.Columns["Dt"].DataPropertyName = "DT";
                    employee_dataGridView.Columns["VaiTro"].DataPropertyName = "VAITRO";
                    employee_dataGridView.Columns["MaDonVi"].DataPropertyName = "MADV";

                    employee_dataGridView.DataSource = dt;

                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Lỗi khi load danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // === UI INTERACTION ===
        private void add_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new ThemNhanVien(mainForm, "Add"));
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new ThemNhanVien(mainForm, "Edit"));
        }

        private void search_employee_guna2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = search_employee_guna2TextBox.Text.Trim();
                if (employee_dataGridView.DataSource is DataTable dt)
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = $"MANV LIKE '%{searchText}%'";
                }
            }
        }

        private void search_employee_button_Click(object sender, EventArgs e)
        {
            string searchText = search_employee_guna2TextBox.Text.Trim();
            if (employee_dataGridView.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"MANV LIKE '%{searchText}%'";
            }
        }

        private void search_employee_guna2TextBox_IconRightClick(object sender, EventArgs e)
        {
            search_employee_guna2TextBox.Text = string.Empty;
        }

        private void employee_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = employee_dataGridView.Rows[e.RowIndex].Cells[0].Value;
                if (cellValue != null)
                {
                    selectedEmployeeID = string.Empty;
                    selectedEmployeeID = cellValue.ToString();
                    delete_button.Visible = true;
                    edit_button.Visible = true;
                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("SP_Xoa_NhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("p_manv", OracleDbType.Varchar2, 10).Value = selectedEmployeeID;
                    OracleParameter msgParam = new OracleParameter("p_msg", OracleDbType.Varchar2, 200);
                    msgParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(msgParam);

                    cmd.ExecuteNonQuery();

                    string message = msgParam.Value.ToString();
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDsNhanVien("SP_Xem_DSNhanVien");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
