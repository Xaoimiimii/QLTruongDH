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

        public QLNhanVien(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;

            HienThiDsRoles();

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

                    OracleCommand cmd = new OracleCommand("C##ADMIN." + procName, conn);
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
    }
}
