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
    public partial class ThongBao : UserControl
    {
        private MainForm mainForm;
        public ThongBao(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            LoadThongBao();
            noti_dataGridView.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            noti_dataGridView.Columns[1].Width = 800;
            noti_dataGridView.Columns[0].HeaderText = "Thời gian";
            noti_dataGridView.Columns[1].HeaderText = "Nội dung thông báo";
            noti_dataGridView.Columns[2].HeaderText = "Cấp độ";
            noti_dataGridView.Columns[3].HeaderText = "Phân vùng";
            noti_dataGridView.Columns[4].HeaderText = "Nhóm";
        }

        private void LoadThongBao()
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("OLS_ADMIN.SP_Xem_DSThongBao", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    noti_dataGridView.DataSource = dt;
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load danh sách thông báo", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new ThemThongBao(mainForm));
        }


    }
}
