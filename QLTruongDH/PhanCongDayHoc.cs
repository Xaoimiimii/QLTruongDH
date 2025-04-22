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
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load danh sách phân công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
