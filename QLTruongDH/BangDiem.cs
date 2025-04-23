using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongDH
{
    public partial class BangDiem : UserControl
    {
        private MainForm mainForm;

        public BangDiem(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            LoadBangDiem();
            NapDuLieuComboBoxHK();
            NapDuLieuComboBoxNH();
        }

        private void LoadBangDiem()
        {
            DataTable dt = new DataTable();
            string maSV = mssv_guna2TextBox.Text.Trim();
            string maHP = hocPhan_guna2TextBox.Text.Trim();
            string HK = hocKy_comboBox.SelectedValue?.ToString();
            string NH = nam_comboBox.SelectedValue?.ToString();

            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            using (OracleCommand cmd = new OracleCommand("SP_Xem_DSDangKySearch", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter("p_maSV", string.IsNullOrEmpty(maSV) ? DBNull.Value : (object)maSV));
                cmd.Parameters.Add(new OracleParameter("p_maHP", string.IsNullOrEmpty(maHP) ? DBNull.Value : (object)maHP));
                cmd.Parameters.Add(new OracleParameter("p_HK", string.IsNullOrEmpty(HK) ? DBNull.Value : (object)HK));
                cmd.Parameters.Add(new OracleParameter("p_NH", string.IsNullOrEmpty(NH) ? DBNull.Value : (object)NH));


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
                    MessageBox.Show("Lỗi truy vấn: ");
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
                    danhSachHK.Add(new HocKy { TenHK = "Tất cả", MaHK = "" });
                    hocKy_comboBox.DisplayMember = "TenHK";
                    hocKy_comboBox.ValueMember = "MaHK";
                    hocKy_comboBox.DataSource = danhSachHK;
                    hocKy_comboBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: ");
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
                    danhSachNH.Add(new NamHoc { TenNH = "Tất cả", MaNH = "" });
                    nam_comboBox.DisplayMember = "TenNH";
                    nam_comboBox.ValueMember = "MaNH";
                    nam_comboBox.DataSource = danhSachNH;
                    nam_comboBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: ");

                }
            }
        }

        private void TraCuuBangDiem()
        {
            string maSV = mssv_guna2TextBox.Text.Trim();
            string maHP = hocPhan_guna2TextBox.Text.Trim();
            string HK = hocKy_comboBox.SelectedValue?.ToString();
            string NH = nam_comboBox.SelectedValue?.ToString();

            DataTable dt = new DataTable();
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            using (OracleCommand cmd = new OracleCommand("SP_Xem_DSDangKySearch", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("p_maSV", string.IsNullOrEmpty(maSV) ? DBNull.Value : (object)maSV));
                cmd.Parameters.Add(new OracleParameter("p_maHP", string.IsNullOrEmpty(maHP) ? DBNull.Value : (object)maHP));
                cmd.Parameters.Add(new OracleParameter("p_HK", string.IsNullOrEmpty(HK) ? DBNull.Value : (object)HK));
                cmd.Parameters.Add(new OracleParameter("p_NH", string.IsNullOrEmpty(NH) ? DBNull.Value : (object)NH));

                OracleParameter p_cursor = new OracleParameter("p_cursor", OracleDbType.RefCursor)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(p_cursor);

                try
                {
                    conn.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    hocPhan_dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: ");
                }
            }

        }

        private void UpdateDiem(DataGridViewRow row)
        {
           
            double? diemqt = null;
            double? diemck = null;
            double? diemth = null;

            if (row.Cells["DIEMQT"].Value != null && double.TryParse(row.Cells["DIEMQT"].Value.ToString(), out double tempDiemqt))
            {
                diemqt = tempDiemqt;
            }

            if (row.Cells["DIEMCK"].Value != null && double.TryParse(row.Cells["DIEMCK"].Value.ToString(), out double tempDiemck))
            {
                diemck = tempDiemck;
            }

            if (row.Cells["DIEMTH"].Value != null && double.TryParse(row.Cells["DIEMTH"].Value.ToString(), out double tempDiemth))
            {
                diemth = tempDiemth;
            }
            
            string maSV = row.Cells["MASV"].Value?.ToString();
            string maHP = row.Cells["MAHP"].Value?.ToString();
            int hk = Convert.ToInt32(row.Cells["HK"].Value);
            int nam = Convert.ToInt32(row.Cells["NAM"].Value);

            Console.WriteLine($"Parameters: maSV={maSV}, maHP={maHP}, hk={hk}, nam={nam}, diemqt={diemqt}, diemck={diemck}, diemth={diemth}");


            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                conn.Open();
                try
                {
                    OracleCommand cmd = new OracleCommand("UpdateDiem", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số với kiểu dữ liệu phù hợp
                    cmd.Parameters.Add("p_maSV", OracleDbType.Varchar2).Value = maSV;
                    cmd.Parameters.Add("p_maHP", OracleDbType.Varchar2).Value = maHP;
                    cmd.Parameters.Add("p_hk", OracleDbType.Int32).Value = hk;
                    cmd.Parameters.Add("p_nam", OracleDbType.Int32).Value = nam;


                    // Xử lý các tham số điểm có thể là null
                    cmd.Parameters.Add("p_diemth", OracleDbType.Double).Value = diemth.HasValue ? Convert.ToDouble(diemth.Value) : (object)DBNull.Value;
                    cmd.Parameters.Add("p_diemqt", OracleDbType.Double).Value = diemqt.HasValue ? Convert.ToDouble(diemqt.Value) : (object)DBNull.Value;
                    cmd.Parameters.Add("p_diemck", OracleDbType.Double).Value = diemck.HasValue ? Convert.ToDouble(diemck.Value) : (object)DBNull.Value;


                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: ");
                    throw;
                }
            }
        }


        private void search_button_Click(object sender, EventArgs e)
        {
            TraCuuBangDiem();
        }

        private void luuDiem_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in hocPhan_dataGridView.Rows)
            {
                try
                {
                    double? diemqt = null;
                    double? diemck = null;
                    double? diemth = null;

                    if (row.Cells["DIEMQT"].Value != null && double.TryParse(row.Cells["DIEMQT"].Value.ToString(), out double tempDiemqt))
                    {
                        diemqt = tempDiemqt;
                    }

                    if (row.Cells["DIEMCK"].Value != null && double.TryParse(row.Cells["DIEMCK"].Value.ToString(), out double tempDiemck))
                    {
                        diemck = tempDiemck;
                    }

                    if (row.Cells["DIEMTH"].Value != null && double.TryParse(row.Cells["DIEMTH"].Value.ToString(), out double tempDiemth))
                    {
                        diemth = tempDiemth;
                    }


                    string maSV = row.Cells["MASV"].Value?.ToString();
                    string maHP = row.Cells["MAHP"].Value?.ToString();
                    int hk = Convert.ToInt32(row.Cells["HK"].Value);
                    int nam = Convert.ToInt32(row.Cells["NAM"].Value);

                    UpdateDiem(row);
                    UpdateDiem(row);
                }

                catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật: ");
                        break;
                    }
            }
            LoadBangDiem();

        }
    }
}
