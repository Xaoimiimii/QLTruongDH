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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTruongDH
{
    public partial class DangKyHocPhan : UserControl
    {
        private MainForm mainForm;
        private List<string> currentRoles;
        public DangKyHocPhan(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            LoadDangKy();
            NapDuLieuComboBoxHK();
            NapDuLieuComboBoxNH();

        }
        private void DangKyHocPhan_Load(object sender, EventArgs e)
        {
            currentRoles = GetCurrentRole();
        }
        private void LoadDangKy()
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            using (OracleCommand cmd = new OracleCommand("SP_Xem_DSDangKy", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                OracleParameter p_cursor = new OracleParameter("p_cursor", OracleDbType.RefCursor)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(p_cursor);

                try
                {
                    conn.Open();
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    adapter.Fill(dt);
                    hocPhan_dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }
        }

        private void NapDuLieuComboBoxHK()
        {
            List<HocKy> danhSachHK = new List<HocKy>();
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            using (OracleCommand cmd = new OracleCommand("GetDanhSachHocKy", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter p_cursor = new OracleParameter("p_cursor", OracleDbType.RefCursor)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(p_cursor);

                try
                {
                    conn.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        danhSachHK.Add(new HocKy
                        {
                            MaHK = reader.GetString(0),
                            TenHK = reader.GetString(0)
                        });
                    }

                    hocKy_comboBox.DisplayMember = "TenHK";
                    hocKy_comboBox.ValueMember = "MaHK";
                    hocKy_comboBox.DataSource = danhSachHK;
                    hocKy_comboBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }

        }

        private void NapDuLieuComboBoxNH()
        {
            List<NamHoc> danhSachNH = new List<NamHoc>();
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            using (OracleCommand cmd = new OracleCommand("GetDanhSachNamHoc", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter p_cursor = new OracleParameter("p_cursor", OracleDbType.RefCursor)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(p_cursor);

                try
                {
                    conn.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        danhSachNH.Add(new NamHoc
                        {
                            MaNH = reader.GetString(0),
                            TenNH = reader.GetString(0)
                        });
                    }

                    nam_comboBox.DisplayMember = "MaNH";
                    nam_comboBox.ValueMember = "MaNH";
                    nam_comboBox.DataSource = danhSachNH;
                    nam_comboBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }
        }

        private List<string> GetCurrentRole()
        {
            List<string> roles = new List<string>();

            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("xac_dinh_danh_sach_role_user", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter outputCursor = new OracleParameter("p_roles", OracleDbType.RefCursor)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputCursor);

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string role = reader.GetString(0).Trim().ToUpper();
                            roles.Add(role);
                        }
                    }
                }
            }

            return roles;
        }



        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (hocPhan_dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hoc phần đăng ký để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = hocPhan_dataGridView.CurrentRow;
            string maSV = selectedRow.Cells["MaSV"].Value.ToString();
            string maHP = selectedRow.Cells["MaHP"].Value.ToString();
            string HK = selectedRow.Cells["HK"].Value.ToString();
            string NH = selectedRow.Cells["Nam"].Value.ToString();

            // Hiển thị hộp thoại xác nhận
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa đăng ký học phần này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        using (OracleCommand cmd = new OracleCommand("DeleteDangKy", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new OracleParameter("p_maSV", OracleDbType.Varchar2)).Value = maSV;
                            cmd.Parameters.Add(new OracleParameter("p_maHP", OracleDbType.Varchar2)).Value = maHP;
                            cmd.Parameters.Add(new OracleParameter("p_HK", OracleDbType.Varchar2)).Value = HK;
                            cmd.Parameters.Add(new OracleParameter("p_NH", OracleDbType.Varchar2)).Value = NH;

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Học phần đăng ký đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDangKy();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa học phần đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void assign_button_Click(object sender, EventArgs e)
        {
            string maSV = mssv_guna2TextBox.Text.Trim();
            string maHP = hocPhan_guna2TextBox.Text.Trim();
            string HK = hocKy_comboBox.SelectedValue?.ToString();
            string NH = nam_comboBox.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maHP) || string.IsNullOrEmpty(HK) || string.IsNullOrEmpty(NH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("addDangKy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_maSV", OracleDbType.Varchar2).Value = maSV;
                        cmd.Parameters.Add("p_maHP", OracleDbType.Varchar2).Value = maHP;
                        cmd.Parameters.Add("p_HK", OracleDbType.Varchar2).Value = HK;
                        cmd.Parameters.Add("p_NH", OracleDbType.Varchar2).Value = NH;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDangKy();
                        mssv_guna2TextBox.Clear();
                        hocPhan_guna2TextBox.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm đăng ký học phần: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    public class HocKy
    {
        public string MaHK { get; set; }
        public string TenHK { get; set; }
    }
    public class NamHoc
    {
        public string MaNH { get; set; }
        public string TenNH { get; set; }
    }

}
