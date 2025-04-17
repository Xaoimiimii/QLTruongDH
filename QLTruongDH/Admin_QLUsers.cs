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
using static QLTruongDH.Admin_MainForm;

namespace QLTruongDH
{
    public partial class Admin_QLUsers : UserControl
    {
        private Admin_MainForm mainForm;
        private List<TablePrivilege> selectedTablePrivileges = new List<TablePrivilege>();

        public Admin_QLUsers(Admin_MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            LoadUser();
        }

        public class PrivilegeInfo
        {
            public string PrivilegeName { get; set; } // Tên quyền
            public bool WithGrantOption { get; set; } // Có WITH GRANT OPTION hay không
            public List<string> Columns { get; set; } // Danh sách cột

            public PrivilegeInfo(string privilegeName, bool withGrantOption, List<string> columns)
            {
                PrivilegeName = privilegeName;
                WithGrantOption = withGrantOption;
                Columns = columns;
            }
        }

        class TablePrivilege
        {
            public string TableName { get; set; }
            public List<PrivilegeInfo> Privileges { get; set; }

            public TablePrivilege(string tableName)
            {
                TableName = tableName;
                Privileges = new List<PrivilegeInfo>();
            }
        }

        private void updateStatus(string currentActivity)
        {
        }

        private void LoadUser()
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("lay_ds_users", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView.DataSource = dt;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi khi load danh sách user");
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new Admin_ThemSuaUser(mainForm, "Add"));
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new Admin_ThemSuaUser(mainForm, "Edit"));
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void search_employee_button_Click(object sender, EventArgs e)
        {
            string searchText = search_username_guna2TextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("tim_user_theo_username", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = searchText;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Lỗi khi tìm kiếm user");
                    }
                }
            }
        }

        private void search_username_guna2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = search_username_guna2TextBox.Text.Trim();

                if (!string.IsNullOrEmpty(searchText))
                {
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("tim_user_theo_username", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = searchText;
                            cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView.DataSource = dt;
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("Lỗi khi tìm kiếm user");
                        }
                    }
                }
            }
        }

        private void search_username_guna2TextBox_IconRightClick(object sender, EventArgs e)
        {
            search_username_guna2TextBox.Clear();
            LoadUser();
        }
    }
}
