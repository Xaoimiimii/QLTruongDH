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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_textBox.Text.Trim().ToUpper();
            string password = password_textBox.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Hãy nhập đủ các thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = $"User Id={username};Password={password};Data Source=localhost:1521/Proj_DKHP;";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // Gọi procedure lấy roles
                    OracleCommand cmd = new OracleCommand("xac_dinh_danh_sach_role_user", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter outputCursor = new OracleParameter
                    {
                        ParameterName = "p_roles",
                        OracleDbType = OracleDbType.RefCursor,
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(outputCursor);

                    List<string> roles = new List<string>();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string role = reader.GetString(0).Trim().ToUpper();
                            roles.Add(role);
                        }
                    }

                    // Nếu không có role nào thì thông báo lỗi
                    //if (roles.Count == 0)
                    //{
                    //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập thất bại",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}

                    // Kiểm tra có DBA không
                    if (roles.Contains("DBA"))
                    {
                        this.Hide();
                        Admin_MainForm adminForm = new Admin_MainForm(username, password);
                        adminForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        //MainForm userForm = new MainForm(roles); // Truyền danh sách role vào MainForm
                        MainForm userForm = new MainForm(username, password);
                        userForm.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
