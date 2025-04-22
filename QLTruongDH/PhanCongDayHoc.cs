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
    public partial class PhanCongDayHoc : UserControl
    {
        private MainForm mainForm;
        private MoMon selectedMoMon = new MoMon();

        public PhanCongDayHoc(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            delete_button.Visible = false;
            edit_button.Visible = false;
        }

        private void PhanCongDayHoc_Load(object sender, EventArgs e)
        {
            if (mainForm.roles.Contains("TRGDV"))
            {
                LoadDsPhanCong("SP_Xem_DSMoMonChoTRGDV");
            }
            else if (mainForm.roles.Contains("PDT"))
            {
                LoadDsPhanCong("SP_Xem_DSMoMonChoNVPDT");
            }
            else if (mainForm.roles.Contains("GIAOVIEN"))
            {
                LoadDsPhanCong("SP_Xem_DSMoMonChoGV");
            }
            else if (mainForm.roles.Contains("SINHVIEN"))
            {
                title_label.Text = "Danh sách mở học phần";
                LoadDsPhanCong("SP_Xem_DSMoMonChoSV");
            }
        }

        // === LOAD DATA ===
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

                    phanCong_dataGridView.AutoGenerateColumns = false;

                    phanCong_dataGridView.Columns["MaMoMon"].DataPropertyName = "MAMM";
                    phanCong_dataGridView.Columns["MaHocPhan"].DataPropertyName = "MAHP";
                    phanCong_dataGridView.Columns["MaGiaoVien"].DataPropertyName = "MAGV";
                    phanCong_dataGridView.Columns["HocKi"].DataPropertyName = "HK";
                    phanCong_dataGridView.Columns["Nam"].DataPropertyName = "NAM";

                    phanCong_dataGridView.DataSource = dt;

                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Lỗi khi load danh sách phân công {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // === UI INTERACTION ===
        private void phanCong_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = phanCong_dataGridView.Rows[e.RowIndex];
                selectedMoMon = new MoMon
                {
                    MaMM = row.Cells[0].Value?.ToString(),
                    MaHP = row.Cells[1].Value?.ToString(),
                    MaGV = row.Cells[2].Value?.ToString(),
                    HK = Convert.ToInt32(row.Cells[3].Value),
                    Nam = Convert.ToInt32(row.Cells[4].Value)
                };
                delete_button.Visible = true;
                edit_button.Visible = true;
                //MessageBox.Show($"Selected: {selectedMoMon.MaMM}, {selectedMoMon.MaHP}, {selectedMoMon.MaGV}, {selectedMoMon.HK}, {selectedMoMon.Nam}");
            }
        }

        private void PhanCongDayHoc_Click(object sender, EventArgs e)
        {
            delete_button.Visible = false;
            edit_button.Visible = false;
            selectedMoMon = new MoMon();
        }

        private void delete_button_Click(object sender, EventArgs e)
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

                    string message = msgParam.Value.ToString();
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (mainForm.roles.Contains("TRGDV"))
                    {
                        LoadDsPhanCong("SP_Xem_DSMoMonChoTRGDV");
                    }
                    else if (mainForm.roles.Contains("PDT"))
                    {
                        LoadDsPhanCong("SP_Xem_DSMoMonChoNVPDT");
                    }
                    else if (mainForm.roles.Contains("GIAOVIEN"))
                    {
                        LoadDsPhanCong("SP_Xem_DSMoMonChoGV");
                    }
                    else if (mainForm.roles.Contains("SINHVIEN"))
                    {
                        title_label.Text = "Danh sách mở học phần";
                        LoadDsPhanCong("SP_Xem_DSMoMonChoSV");
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show($"Lỗi khi xóa mở môn: {selectedMoMon.MaMM}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void search_hocphan_guna2TextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void search_giaovien_guna2TextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void hocky_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void nam_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
