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
        private NhanVien selectedEmployee = new NhanVien();

        public QLNhanVien(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            delete_button.Visible = false;
            edit_button.Visible = false;
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
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
                    employee_dataGridView.Columns["CoSo"].DataPropertyName = "COSO";

                    employee_dataGridView.DataSource = dt;

                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load danh sách nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // === UI INTERACTION ===
        private void employee_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employee_dataGridView.Rows[e.RowIndex];
                selectedEmployee = new NhanVien
                {
                    MaNV = row.Cells[0].Value?.ToString(),
                    HoTen = row.Cells[1].Value?.ToString(),
                    Phai = row.Cells[2].Value?.ToString(),
                    NgaySinh = row.Cells[3].Value == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(row.Cells[3].Value).Date,
                    Luong = row.Cells[4].Value == DBNull.Value ? null : (decimal?)Convert.ToDecimal(row.Cells[4].Value),
                    PhuCap = row.Cells[5].Value == DBNull.Value ? null : (decimal?)Convert.ToDecimal(row.Cells[5].Value),
                    DienThoai = row.Cells[6].Value?.ToString(),
                    VaiTro = row.Cells[7].Value?.ToString(),
                    MaDV = row.Cells[8].Value?.ToString(),
                    CoSo = row.Cells[9].Value?.ToString()
                };
                selectedEmployeeID = selectedEmployee.MaNV;
                delete_button.Visible = true;
                edit_button.Visible = true;

            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteEmployee();
            }
        }

        private void DeleteEmployee()
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
                catch (OracleException)
                {
                    MessageBox.Show($"Lỗi khi xóa nhân viên: {selectedEmployeeID}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new ThemSuaNhanVien(mainForm, "Add", selectedEmployee));
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new ThemSuaNhanVien(mainForm, "Edit", selectedEmployee));
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

        private void QLNhanVien_Click(object sender, EventArgs e)
        {
            delete_button.Visible = false;
            edit_button.Visible = false;
            selectedEmployeeID = string.Empty;
            selectedEmployee = new NhanVien();
        }
    }
}
