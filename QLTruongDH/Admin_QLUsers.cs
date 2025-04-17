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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static QLTruongDH.Admin_MainForm;

namespace QLTruongDH
{
    public partial class Admin_QLUsers : UserControl
    {
        private Admin_MainForm mainForm;
        private string selectedUsername = string.Empty;
        private List<string> sysPrivsList = new List<string>();
        private List<string> rolePrivsList = new List<string>();
        private List<TablePrivilege> selectedTablePrivileges = new List<TablePrivilege>();

        public Admin_QLUsers(Admin_MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            delete_button.Visible = false;
            edit_button.Visible = false;
            LoadUser();
        }


        // === LOAD DATA ===
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
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load danh sách user", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadPrivs(string username)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    // --- Load System Privileges ---
                    OracleCommand sys = new OracleCommand("lay_user_sys_privs", conn);
                    sys.CommandType = CommandType.StoredProcedure;
                    sys.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    sys.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter sys_adapter = new OracleDataAdapter(sys);
                    DataTable sys_dt = new DataTable();
                    sys_adapter.Fill(sys_dt);
                    DBA_SYS_PRIVS_dataGridView.DataSource = sys_dt;

                    foreach (DataRow row in sys_dt.Rows)
                    {
                        sysPrivsList.Add(row["SYS_PRIVS"].ToString());
                    }

                    // --- Load Role Privileges ---
                    OracleCommand role = new OracleCommand("lay_user_role_privs", conn);
                    role.CommandType = CommandType.StoredProcedure;
                    role.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    role.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter role_adapter = new OracleDataAdapter(role);
                    DataTable role_dt = new DataTable();
                    role_adapter.Fill(role_dt);
                    DBA_ROLE_PRIVS_dataGridView.DataSource = role_dt;

                    foreach (DataRow row in role_dt.Rows)
                    {
                        rolePrivsList.Add(row["GRANTED_ROLE"].ToString());
                    }


                    // --- Load Table Privileges ---
                    OracleCommand tab = new OracleCommand("lay_user_tab_privs", conn);
                    tab.CommandType = CommandType.StoredProcedure;
                    tab.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    tab.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter tab_adapter = new OracleDataAdapter(tab);
                    DataTable tab_dt = new DataTable();
                    tab_adapter.Fill(tab_dt);
                    DBA_TAB_PRIVS_dataGridView.DataSource = tab_dt;

                    foreach (DataRow row in tab_dt.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        string privilege = row["TAB_PRIVS"].ToString();
                        string grantable = row["GRANTABLE"].ToString();

                        TablePrivilege tablePrivilege = selectedTablePrivileges.FirstOrDefault(t => t.TableName == tableName);

                        if (tablePrivilege == null)
                        {
                            tablePrivilege = new TablePrivilege(tableName);
                            selectedTablePrivileges.Add(tablePrivilege);
                        }

                        bool withGrantOption;
                        if (grantable == "YES") withGrantOption = true;
                        else if (grantable == "NO") withGrantOption = false;
                        else withGrantOption = false;

                        PrivilegeInfo privInfo = new PrivilegeInfo(privilege, withGrantOption, new List<string>());
                        tablePrivilege.Privileges.Add(privInfo);
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load privileges", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //private void LoadPrivs(string username)
        //{
        //    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();

        //            // Load system privileges
        //            OracleCommand sys = new OracleCommand("lay_user_sys_privs", conn);
        //            sys.CommandType = CommandType.StoredProcedure;
        //            sys.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
        //            sys.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

        //            OracleDataAdapter sys_adapter = new OracleDataAdapter(sys);
        //            DataTable sys_dt = new DataTable();
        //            sys_adapter.Fill(sys_dt);
        //            DBA_SYS_PRIVS_dataGridView.DataSource = sys_dt;

        //            // Load table privileges
        //            OracleCommand tab = new OracleCommand("lay_user_tab_privs", conn);
        //            tab.CommandType = CommandType.StoredProcedure;
        //            tab.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
        //            tab.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

        //            OracleDataAdapter tab_adapter = new OracleDataAdapter(tab);
        //            DataTable tab_dt = new DataTable();
        //            tab_adapter.Fill(tab_dt);
        //            DBA_TAB_PRIVS_dataGridView.DataSource = tab_dt;

        //            // Load role privileges
        //            OracleCommand role = new OracleCommand("lay_user_role_privs", conn);
        //            role.CommandType = CommandType.StoredProcedure;
        //            role.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
        //            role.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

        //            OracleDataAdapter role_adapter = new OracleDataAdapter(role);
        //            DataTable role_dt = new DataTable();
        //            role_adapter.Fill(role_dt);
        //            DBA_ROLE_PRIVS_dataGridView.DataSource = role_dt;
        //        }
        //        catch (OracleException)
        //        {
        //            MessageBox.Show("Lỗi khi load sys privileges", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        private void add_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new Admin_ThemSuaUser(mainForm, "Add", selectedUsername, sysPrivsList, rolePrivsList, selectedTablePrivileges));
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUsername))
            {
                MessageBox.Show("Vui lòng chọn một user để sửa");
                return;
            }
            mainForm.LoadControl(new Admin_ThemSuaUser(mainForm, "Edit", selectedUsername, sysPrivsList, rolePrivsList, selectedTablePrivileges));
        }

        private void Admin_QLUsers_Click(object sender, EventArgs e)
        {
            Reset();
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
                    catch (OracleException)
                    {
                        MessageBox.Show("Lỗi khi tìm kiếm user", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        catch (OracleException)
                        {
                            MessageBox.Show("Lỗi khi tìm kiếm user", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dataGridView.Rows[e.RowIndex].Cells[1].Value;
                if (cellValue != null)
                {
                    Reset();
                    selectedUsername = cellValue.ToString();
                    LoadPrivs(selectedUsername);
                    delete_button.Visible = true;
                    edit_button.Visible = true;
                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (selectedUsername != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa user này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("xoa_user", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = selectedUsername;
                            cmd.ExecuteNonQuery();
                            LoadUser();
                            Reset();
                        }
                        catch (OracleException)
                        {
                            MessageBox.Show($"Lỗi khi xóa user {selectedUsername}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Reset()
        {
            delete_button.Visible = false;
            edit_button.Visible = false;
            selectedUsername = string.Empty;
            sysPrivsList.Clear();
            rolePrivsList.Clear();
            selectedTablePrivileges.Clear();
        }
    }
}
