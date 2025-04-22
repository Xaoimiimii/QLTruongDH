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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLTruongDH
{
    public partial class Admin_QLRoles : UserControl
    {
        private Admin_MainForm mainForm;
        private string selectedRole = string.Empty;
        private List<string> sysPrivsList = new List<string>();
        private List<string> rolePrivsList = new List<string>();

        private List<string> tableNameList = new List<string>();
        private List<string> tablePrivsList = new List<string>();
        private List<string> typeList = new List<string>();
        private List<string> grantableList = new List<string>();

        public Admin_QLRoles(Admin_MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            delete_button.Visible = false;
            edit_button.Visible = false;
            LoadRole();
        }


        // === LOAD DATA ===
        private void LoadRole()
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("lay_ds_roles", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView.DataSource = dt;
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load danh sách role", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadPrivs(string rolename)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    // --- Load System Privileges ---
                    OracleCommand sys = new OracleCommand("lay_user_sys_privs", conn);
                    sys.CommandType = CommandType.StoredProcedure;
                    sys.Parameters.Add("p_username", OracleDbType.Varchar2).Value = rolename;
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
                    role.Parameters.Add("p_username", OracleDbType.Varchar2).Value = rolename;
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
                    tab.Parameters.Add("p_username", OracleDbType.Varchar2).Value = rolename;
                    tab.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter tab_adapter = new OracleDataAdapter(tab);
                    DataTable tab_dt = new DataTable();
                    tab_adapter.Fill(tab_dt);
                    DBA_TAB_PRIVS_dataGridView.DataSource = tab_dt;

                    foreach (DataRow row in tab_dt.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        string privilege = row["TAB_PRIVS"].ToString();
                        string type = row["TYPE"].ToString();
                        string grantable = row["GRANTABLE"].ToString();

                        tableNameList.Add(tableName);
                        tablePrivsList.Add(privilege);
                        typeList.Add(type);
                        grantableList.Add(grantable);
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load privileges", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Reset()
        {
            delete_button.Visible = false;
            edit_button.Visible = false;
            selectedRole = string.Empty;
            sysPrivsList.Clear();
            rolePrivsList.Clear();
            tableNameList.Clear();
            tablePrivsList.Clear();
            typeList.Clear();
            grantableList.Clear();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new Admin_ThemSuaRole(mainForm, "Add", selectedRole, sysPrivsList, rolePrivsList, tableNameList, tablePrivsList, typeList, grantableList));
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Vui lòng chọn một role để sửa");
                return;
            }
            mainForm.LoadControl(new Admin_ThemSuaRole(mainForm, "Edit", selectedRole, sysPrivsList, rolePrivsList, tableNameList, tablePrivsList, typeList, grantableList));
        }

        private void Admin_QLRoles_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void search_role_button_Click(object sender, EventArgs e)
        {
            string searchText = search_role_guna2TextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("tim_role_theo_rolename", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_rolename", OracleDbType.Varchar2).Value = searchText;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (OracleException)
                    {
                        MessageBox.Show("Lỗi khi tìm kiếm role", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void search_role_guna2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = search_role_guna2TextBox.Text.Trim();

                if (!string.IsNullOrEmpty(searchText))
                {
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("tim_role_theo_rolename", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("p_rolename", OracleDbType.Varchar2).Value = searchText;
                            cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView.DataSource = dt;
                        }
                        catch (OracleException)
                        {
                            MessageBox.Show("Lỗi khi tìm kiếm role", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void search_role_guna2TextBox_IconRightClick(object sender, EventArgs e)
        {
            search_role_guna2TextBox.Clear();
            LoadRole();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dataGridView.Rows[e.RowIndex].Cells[1].Value;
                if (cellValue != null)
                {
                    Reset();
                    selectedRole = cellValue.ToString();
                    LoadPrivs(selectedRole);
                    delete_button.Visible = true;
                    edit_button.Visible = true;
                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (selectedRole != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa role này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("xoa_role", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = selectedRole;
                            cmd.ExecuteNonQuery();
                            LoadRole();
                            Reset();
                        }
                        catch (OracleException)
                        {
                            MessageBox.Show($"Lỗi khi xóa role {selectedRole}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


    }
}
