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
    public partial class QLSinhVien : UserControl
    {
        private MainForm mainForm;
        private List<string> currentRoles; //store user roles
        private Dictionary<int, Dictionary<string, object>> originalValues = new Dictionary<int, Dictionary<string, object>>();  //store old/new edited values

        public QLSinhVien(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            LoadSinhVien();
            NapDuLieuComboBoxTimKiemKhoa();
            NapDuLieuComboBoxTimKiemTinhTrang();
        }

        private void LoadSinhVien()
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            using (OracleCommand cmd = new OracleCommand("GetSinhVien", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("p_maSV", DBNull.Value));  // Truyền giá trị NULL nếu không có giá trị tìm kiếm
                cmd.Parameters.Add(new OracleParameter("p_maKhoa", DBNull.Value));
                cmd.Parameters.Add(new OracleParameter("p_tinhTrang", DBNull.Value));

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
                    student_dataGridView.DataSource = dt;
                    StoreOriginalValues();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }
        }

        private void StoreOriginalValues()
        {
            originalValues.Clear();  // Clear previous data
            foreach (DataGridViewRow row in student_dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                originalValues[row.Index] = new Dictionary<string, object>
        {
            { "Mã số sinh viên", row.Cells["Mã số sinh viên"].Value },
            { "Họ và tên", row.Cells["Họ và tên"].Value },
            { "Địa chỉ", row.Cells["Địa chỉ"].Value },
            { "Điện thoại", row.Cells["Điện thoại"].Value },
            { "Tình trạng", row.Cells["Tình trạng"].Value },
            { "Phái", row.Cells["Phái"].Value },
            { "Khoa", row.Cells["Khoa"].Value },
            { "Ngày sinh", row.Cells["Ngày sinh"].Value }
        };
            }
        }


        private DataTable GetData(string query)
        {
            string connectionString = mainForm.connectionString;
            DataTable dt = new DataTable();
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn Oracle: " + ex.Message);
                }
            }
            return dt;
        }
        private void NapDuLieuComboBoxTimKiemKhoa()
        {
            List<Khoa> danhSachKhoa = new List<Khoa>();
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            using (OracleCommand cmd = new OracleCommand("GetDanhSachKhoa", conn))
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
                        danhSachKhoa.Add(new Khoa
                        {
                            MaKhoa = reader.GetString(0),
                            TenKhoa = reader.GetString(1)
                        });
                    }
                    khoa_comboBox.DisplayMember = "TenKhoa";
                    khoa_comboBox.ValueMember = "MaKhoa";
                    khoa_comboBox.DataSource = danhSachKhoa;
                    khoa_comboBox.SelectedIndex = -1;
                    danhSachKhoa.Add(new Khoa { TenKhoa = "Tất cả", MaKhoa = "" });
                    comboBox1.DisplayMember = "TenKhoa";
                    comboBox1.ValueMember = "MaKhoa";
                    comboBox1.DataSource = danhSachKhoa;
                    comboBox1.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }
        }

        private void NapDuLieuComboBoxTimKiemTinhTrang()
        {
            List<TinhTrang> danhSachTinhTrang = new List<TinhTrang>();
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            using (OracleCommand cmd = new OracleCommand("GetDanhSachTinhTrang", conn))
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
                        danhSachTinhTrang.Add(new TinhTrang
                        {
                            TenTrinhTrang = reader.GetString(0),
                            GiaTriTinhTrang = reader.GetString(0)
                        });
                    }

                    danhSachTinhTrang.Add(new TinhTrang { TenTrinhTrang = "Tất cả", GiaTriTinhTrang = "" });
                    comboBox2.DisplayMember = "TenTrinhTrang";
                    comboBox2.ValueMember = "GiaTriTinhTrang";
                    comboBox2.DataSource = danhSachTinhTrang;
                    comboBox2.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }
        }


        private void TraCuuSinhVien()
        {
            string maSV = search_student_guna2TextBox.Text.Trim();
            string maKhoa = comboBox1.SelectedValue?.ToString();
            string tinhTrang = comboBox2.SelectedValue?.ToString();

            DataTable dt = new DataTable();
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            using (OracleCommand cmd = new OracleCommand("GetSinhVien", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("p_maSV", string.IsNullOrEmpty(maSV) ? DBNull.Value : (object)maSV));
                cmd.Parameters.Add(new OracleParameter("p_maKhoa", string.IsNullOrEmpty(maKhoa) ? DBNull.Value : (object)maKhoa));
                cmd.Parameters.Add(new OracleParameter("p_tinhTrang", string.IsNullOrEmpty(tinhTrang) ? DBNull.Value : (object)tinhTrang));

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
                    student_dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }
        }
        private void search_student_button_Click(object sender, EventArgs e)
        {
            TraCuuSinhVien();
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


        private void UpdateSinhVien(DataGridViewRow row)
        {
            List<string> roles = currentRoles;
            string maSV = row.Cells["Mã số sinh viên"].Value.ToString();
            string hoTen = row.Cells["Họ và tên"].Value?.ToString();
            string dchi = row.Cells["Địa chỉ"].Value?.ToString();
            string dt = row.Cells["Điện thoại"].Value?.ToString();
            string tinhTrang = row.Cells["Tình trạng"].Value?.ToString();
            string phai = row.Cells["Phái"].Value?.ToString();
            string maKhoa = row.Cells["Khoa"].Value?.ToString();
            DateTime? ngaySinh = row.Cells["Ngày sinh"].Value as DateTime?;

            // Get original values
            var originalRow = originalValues[row.Index];
            string originalHoTen = originalRow["Họ và tên"]?.ToString();
            string originalDchi = originalRow["Địa chỉ"]?.ToString();
            string originalDt = originalRow["Điện thoại"]?.ToString();
            string originalTinhTrang = originalRow["Tình trạng"]?.ToString();
            string originalPhai = originalRow["Phái"]?.ToString();
            string originalMaKhoa = originalRow["Khoa"]?.ToString();
            DateTime? originalNgaySinh = originalRow["Ngày sinh"] as DateTime?;

            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                conn.Open();
                try
                {
                    // Cập nhật chỉ khi có thay đổi
                    if (roles.Contains("SINHVIEN"))
                    {
                        // Kiểm tra các cột thay đổi
                        if (dchi != originalDchi || dt != originalDt)
                        {
                            OracleCommand cmd = new OracleCommand("update_sv_by_sv", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("p_maSV", OracleDbType.Char).Value = maSV;
                            if (dchi != null) cmd.Parameters.Add("p_dchi", OracleDbType.Varchar2).Value = dchi;
                            if (dt != null) cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = dt;
                            cmd.ExecuteNonQuery();
                            // new OracleCommand("COMMIT", conn).ExecuteNonQuery();
                        }
                        else if (hoTen != originalHoTen || phai != originalPhai || ngaySinh != originalNgaySinh || maKhoa != originalMaKhoa || tinhTrang != originalTinhTrang)
                        {
                            MessageBox.Show("Bạn không có quyền cập nhật thông tin này!");
                        }

                    }
                    else if (roles.Contains("NV_CTSV"))
                    {
                        // Cập nhật tất cả các thông tin nếu người dùng có quyền
                        if (hoTen != originalHoTen || phai != originalPhai || ngaySinh != originalNgaySinh ||
                            dchi != originalDchi || dt != originalDt || maKhoa != originalMaKhoa)
                        {
                            OracleCommand cmd = new OracleCommand("update_sv_by_pctsv", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("p_maSV", OracleDbType.Char).Value = maSV;
                            if (hoTen != null) cmd.Parameters.Add("p_hoTen", OracleDbType.Varchar2).Value = hoTen;
                            if (phai != null) cmd.Parameters.Add("p_phai", OracleDbType.Varchar2).Value = phai;
                            if (ngaySinh.HasValue) cmd.Parameters.Add("p_ngsinh", OracleDbType.Date).Value = ngaySinh;
                            if (dchi != null) cmd.Parameters.Add("p_dchi", OracleDbType.Varchar2).Value = dchi;
                            if (dt != null) cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = dt;
                            if (maKhoa != null) cmd.Parameters.Add("p_khoa", OracleDbType.Varchar2).Value = maKhoa;
                            cmd.ExecuteNonQuery();
                            //new OracleCommand("COMMIT", conn).ExecuteNonQuery();
                        }
                        else if (tinhTrang != originalTinhTrang)
                        {
                            MessageBox.Show("Bạn không có quyền cập nhật thông tin này!");
                        }
                    }
                    else if (roles.Contains("NV_PDT"))
                    {
                        // Cập nhật tình trạng sinh viên nếu có thay đổi
                        if (tinhTrang != originalTinhTrang)
                        {
                            OracleCommand cmd = new OracleCommand("update_sv_tinhtrang_by_pdt", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("p_maSV", OracleDbType.Char).Value = maSV;
                            cmd.Parameters.Add("p_tinhTrang", OracleDbType.Varchar2).Value = tinhTrang;
                            cmd.ExecuteNonQuery();
                            //new OracleCommand("COMMIT", conn).ExecuteNonQuery();
                        }
                        else if (hoTen != originalHoTen || dchi != originalDchi || dt != originalDt ||
                            phai != originalPhai || maKhoa != originalMaKhoa || ngaySinh != originalNgaySinh)
                        {
                            MessageBox.Show("Bạn không có quyền cập nhật thông tin này!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền cập nhật!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message);
                }
            }
        }

        private void QLSinhVien_Load(object sender, EventArgs e)
        {
            currentRoles = GetCurrentRole();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            bool hasUpdates = false; // Track if any updates were made
            bool isSucccess = false;
            try
            {
                foreach (DataGridViewRow row in student_dataGridView.Rows)
                {
                    if (row.IsNewRow) continue; // Skip the new row (if DataGridView allows adding new rows)

                    // Get original and current values
                    var originalRow = originalValues[row.Index];
                    string maSV = row.Cells["Mã số sinh viên"].Value?.ToString();
                    string hoTen = row.Cells["Họ và tên"].Value?.ToString();
                    string dchi = row.Cells["Địa chỉ"].Value?.ToString();
                    string dt = row.Cells["Điện thoại"].Value?.ToString();
                    string tinhTrang = row.Cells["Tình trạng"].Value?.ToString();
                    string phai = row.Cells["Phái"].Value?.ToString();
                    string maKhoa = row.Cells["Khoa"].Value?.ToString();
                    DateTime? ngaySinh = row.Cells["Ngày Sinh"].Value as DateTime?;

                    string originalHoTen = originalRow["Họ và tên"]?.ToString();
                    string originalDchi = originalRow["Địa chỉ"]?.ToString();
                    string originalDt = originalRow["Điện thoại"]?.ToString();
                    string originalTinhTrang = originalRow["Tình trạng"]?.ToString();
                    string originalPhai = originalRow["Phái"]?.ToString();
                    string originalMaKhoa = originalRow["Khoa"]?.ToString();
                    DateTime? originalNgaySinh = originalRow["Ngày sinh"] as DateTime?;

                    // Check if any field has changed
                    if (hoTen != originalHoTen || dchi != originalDchi || dt != originalDt ||
                        tinhTrang != originalTinhTrang || phai != originalPhai ||
                        maKhoa != originalMaKhoa || ngaySinh != originalNgaySinh)
                    {
                        UpdateSinhVien(row); // Call UpdateSinhVien for this row
                        hasUpdates = true;
                    }
                }

                if (hasUpdates)
                {
                    LoadSinhVien(); // Refresh the grid to reflect changes

                }
                else
                {
                    MessageBox.Show("Không có thay đổi để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSinhVien(string maSV)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                using (OracleCommand cmd = new OracleCommand("DeleteSinhVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new OracleParameter("p_maSV", OracleDbType.Varchar2)).Value = maSV;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void alter_button_Click(object sender, EventArgs e)
        {
            if (currentRoles.Contains("NV_CTSV"))
            {
                if (student_dataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = student_dataGridView.CurrentRow;
                string maSV = selectedRow.Cells["Mã số sinh viên"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Gọi phương thức xóa sinh viên từ thủ tục lưu trữ
                        DeleteSinhVien(maSV);
                        MessageBox.Show("Sinh viên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadSinhVien();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (currentRoles.Contains("NV_CTSV"))
            {
                string maSV = mssv_textBox.Text.Trim();
                string hoTen = hoTen_textBox.Text.Trim();
                string diaChi = diaChi_textBox.Text.Trim();
                string dienThoai = sdt_textBox.Text.Trim();
                string phai = gioiTinh_comboBox.SelectedValue?.ToString();
                string maKhoa = khoa_comboBox.SelectedValue?.ToString();
                DateTime? ngaySinh = ngaySinh_dateTimePicker.Value;


                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(dienThoai) || string.IsNullOrEmpty(maKhoa))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("addsinhvien", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("p_maSV", OracleDbType.Varchar2).Value = maSV;
                            cmd.Parameters.Add("p_hoTen", OracleDbType.Varchar2).Value = hoTen;
                            cmd.Parameters.Add("p_diaChi", OracleDbType.Varchar2).Value = diaChi;
                            cmd.Parameters.Add("p_dienThoai", OracleDbType.Varchar2).Value = dienThoai;
                            cmd.Parameters.Add("p_phai", OracleDbType.Varchar2).Value = phai;
                            cmd.Parameters.Add("p_maKhoa", OracleDbType.Varchar2).Value = maKhoa;
                            cmd.Parameters.Add("p_ngaySinh", OracleDbType.Date).Value = ngaySinh;
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Sinh viên đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSinhVien();
                            mssv_textBox.Clear();
                            hoTen_textBox.Clear();
                            diaChi_textBox.Clear();
                            sdt_textBox.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thêm sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class Khoa
    {
        public string TenKhoa { get; set; }
        public string MaKhoa { get; set; }
    }
    public class TinhTrang
    {
        public string TenTrinhTrang { get; set; }
        public string GiaTriTinhTrang { get; set; }
    }
}
