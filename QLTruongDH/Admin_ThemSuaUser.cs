using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace QLTruongDH
{
    public partial class Admin_ThemSuaUser : UserControl
    {
        private Admin_MainForm mainForm;
        private string mode;
        private string username;
        private bool isAddMode = false;
        private bool isEditMode = false;
        private List<TablePrivilege> selectedTablePrivileges = new List<TablePrivilege>();

        public Admin_ThemSuaUser(Admin_MainForm form, string mode, string username)
        {
            InitializeComponent();
            this.mainForm = form;
            this.mode = mode;
            this.username = username;

            if (mode == "Add")
            {
                isAddMode = true;
                control_title_label.Text = "Thêm user";
                add_button.Text = "Thêm user";
            }
            else if (mode == "Edit")
            {
                isEditMode = true;
                control_title_label.Text = "Sửa thông tin user";
                add_button.Text = "Sửa thông tin";
            }

            LoadRoleCheckedListBox();
            LoadTabComboBox();

            add_user_tab_checkedListBox.Visible = false;
            select_with_grant_option_checkBox.Visible = false;
            update_with_grant_option_checkBox.Visible = false;
        }

        // === CLASS ===
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


        // === LOAD DATA ===
        private void LoadRoleCheckedListBox()
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("lay_ds_ten_roles", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            add_user_role_checkedListBox.Items.Clear();

                            while (reader.Read())
                            {
                                string roleName = reader.GetString(0);
                                add_user_role_checkedListBox.Items.Add(roleName);
                            }
                        }
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load danh sách user trong checkedListBox");
                }
            }
        }

        private void LoadTabComboBox()
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("lay_ds_tables", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            add_user_select_table_comboBox.Items.Clear();

                            while (reader.Read())
                            {
                                string tableName = reader.GetString(0);
                                add_user_select_table_comboBox.Items.Add(tableName);
                            }
                        }
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load danh sách table trong comboBox");
                }
            }
        }

        /// //////////////////////////////////////

        private void LoadTableCols(string procedureName, string tableName)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_tablename", OracleDbType.Varchar2).Value = tableName;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            add_user_column_checkedListBox.Items.Clear();
                            while (reader.Read())
                            {
                                string colName = reader.GetString(0);
                                add_user_column_checkedListBox.Items.Add(colName);
                            }
                        }
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show($"Lỗi khi load danh sách column trong table '{tableName}'");
                }
            }
        }


        // === HELPER FUNCTION ===
        private string GetPrivilegesInfo()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var tablePrivilege in selectedTablePrivileges)
            {
                foreach (var privilege in tablePrivilege.Privileges)
                {
                    string columns = privilege.Columns.Count > 0 ? string.Join(", ", privilege.Columns) : "ALL";
                    sb.AppendLine($"{tablePrivilege.TableName} - {privilege.PrivilegeName} - {privilege.WithGrantOption} - {columns}");
                }
            }

            return sb.ToString();
        }

        private void ResetPanel()
        {
            // Reset các trường nhập liệu
            username_textBox.Text = string.Empty;
            password_textBox.Text = string.Empty;

            // Reset các checkedListBox

            for (int i = 0; i < add_user_sys_checkedListBox.Items.Count; i++)
            {
                add_user_sys_checkedListBox.SetItemChecked(i, false);
            }

            for (int i = 0; i < add_user_role_checkedListBox.Items.Count; i++)
            {
                add_user_role_checkedListBox.SetItemChecked(i, false);
            }

            add_user_tab_checkedListBox.ItemCheck -= add_user_tab_checkedListBox_ItemCheck;
            for (int i = 0; i < add_user_tab_checkedListBox.Items.Count; i++)
            {
                add_user_tab_checkedListBox.SetItemChecked(i, false);
            }
            add_user_tab_checkedListBox.ItemCheck += add_user_tab_checkedListBox_ItemCheck;

            add_user_column_checkedListBox.ItemCheck -= add_user_column_checkedListBox_ItemCheck;
            for (int i = 0; i < add_user_column_checkedListBox.Items.Count; i++)
            {
                add_user_column_checkedListBox.SetItemChecked(i, false);
            }
            add_user_column_checkedListBox.ItemCheck += add_user_column_checkedListBox_ItemCheck;

            // Reset các checkbox
            select_with_grant_option_checkBox.Checked = false;
            update_with_grant_option_checkBox.Checked = false;
            select_with_grant_option_checkBox.Visible = false;
            update_with_grant_option_checkBox.Visible = false;

            // Reset combobox
            add_user_select_table_comboBox.SelectedIndex = -1;

            // Ẩn danh sách cột
            add_user_column_checkedListBox.Visible = false;

            // Ẩn danh sách quyền
            add_user_tab_checkedListBox.Visible = false;


            // Xóa danh sách quyền của user
            selectedTablePrivileges.Clear();

            LoadRoleCheckedListBox();
            LoadTabComboBox();
        }

        private void CreateUser()
        {
            string username = username_textBox.Text.Trim();
            string password = password_textBox.Text.Trim();

            // Kiểm tra username, password có nhập đủ không
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy danh sách quyền hệ thống
            List<string> sysPrivileges = add_user_sys_checkedListBox.CheckedItems.Cast<string>().ToList();

            // Lấy danh sách quyền role
            List<string> rolePrivileges = add_user_role_checkedListBox.CheckedItems.Cast<string>().ToList();

            // Tạo user mới trong cơ sở dữ liệu
            if (CreateUserSp(username, password))
            {
                // Gán các quyền hệ thống (Sys Privileges)
                foreach (var priv in sysPrivileges)
                {
                    GrantPrivilege(username, priv);
                }

                // Gán các quyền role (Role Privileges)
                foreach (var role in rolePrivileges)
                {
                    GrantPrivilege(username, role);
                }

                // Gán các quyền bảng (Table Privileges)
                GrantTablePrivilege(username);

                MessageBox.Show("User đã được tạo và cấp quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset panel
                ResetPanel();
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo user!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CreateUserSp(string username, string password)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("tao_user", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                        cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi tạo user", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void GrantPrivilege(string username, string privilege)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("grant_priv", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                        cmd.Parameters.Add("p_priv", OracleDbType.Varchar2).Value = privilege;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi cấp quyền hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GrantTablePrivilege(string username)
        {
            foreach (var tablePrivilege in selectedTablePrivileges)
            {
                foreach (var privilege in tablePrivilege.Privileges)
                {
                    // Tính số cột của bảng
                    int columnCount = 0;
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (OracleCommand cmd = new OracleCommand("dem_so_cot_cua_bang", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("p_tablename", OracleDbType.Varchar2).Value = tablePrivilege.TableName;
                                cmd.Parameters.Add("p_count", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.ExecuteNonQuery();
                                columnCount = ((OracleDecimal)cmd.Parameters["p_count"].Value).ToInt32();
                            }
                        }
                        catch (OracleException)
                        {
                            MessageBox.Show("Lỗi khi đếm số cột của bảng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    // Nếu số column được chọn > 0 và < số cột của bảng

                    if (privilege.Columns.Count > 0 && privilege.Columns.Count < columnCount)
                    {
                        // Tạo string gồm các column được chọn cách nhau bởi '_'
                        string columns = string.Join("_", privilege.Columns);

                        // Tạo chuỗi tên view
                        string view_name = tablePrivilege.TableName + "_" + columns + "_VIEW";

                        // Goi sp tao_view de tao view
                        using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                        {
                            try
                            {
                                conn.Open();
                                using (OracleCommand cmd = new OracleCommand("tao_view", conn))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add("p_view_name", OracleDbType.Varchar2).Value = view_name;
                                    cmd.Parameters.Add("p_column_list", OracleDbType.Varchar2).Value = string.Join(",", privilege.Columns);
                                    cmd.Parameters.Add("p_tablename", OracleDbType.Varchar2).Value = tablePrivilege.TableName;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            catch (OracleException)
                            {
                                MessageBox.Show("Lỗi khi tạo view", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Gán quyền cho user trên view
                        using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                        {
                            try
                            {
                                conn.Open();
                                using (OracleCommand cmd = new OracleCommand("cap_quyen_view_table", conn))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add("p_privilege_name", OracleDbType.Varchar2).Value = privilege.PrivilegeName;
                                    cmd.Parameters.Add("p_view_name", OracleDbType.Varchar2).Value = view_name;
                                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                                    cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = privilege.WithGrantOption;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            catch (OracleException)
                            {
                                MessageBox.Show("Lỗi khi cấp quyền trên view", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                        {
                            try
                            {
                                conn.Open();
                                using (OracleCommand cmd = new OracleCommand("cap_quyen_view_table", conn))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add("p_privilege_name", OracleDbType.Varchar2).Value = privilege.PrivilegeName;
                                    cmd.Parameters.Add("p_view_name", OracleDbType.Varchar2).Value = tablePrivilege.TableName;
                                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                                    cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = privilege.WithGrantOption;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            catch (OracleException)
                            {
                                MessageBox.Show("Lỗi khi cấp quyền trên table", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
        }


        // === UI (BUTTON, CHECKBOX, COMBOBOX) INTERACT ===
        private void reset_button_Click(object sender, EventArgs e)
        {
            ResetPanel();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string privilegesInfo = GetPrivilegesInfo();

            // Xác nhận các quyền đã chọn
            if (!string.IsNullOrEmpty(privilegesInfo))
            {
                DialogResult result = MessageBox.Show(privilegesInfo, "Xác nhận các quyền đã chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    CreateUser();
                }
            }
            else
            {
                CreateUser();
            }
        }


        private void add_user_select_table_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_user_tab_checkedListBox.Visible = true;

            add_user_tab_checkedListBox.ItemCheck -= add_user_tab_checkedListBox_ItemCheck;
            select_with_grant_option_checkBox.CheckedChanged -= select_with_grant_option_checkBox_CheckedChanged;
            update_with_grant_option_checkBox.CheckedChanged -= update_with_grant_option_checkBox_CheckedChanged;

            // Reset và ẩn with grant option checkbox
            select_with_grant_option_checkBox.Checked = false;
            update_with_grant_option_checkBox.Checked = false;
            update_with_grant_option_checkBox.Checked = false;
            select_with_grant_option_checkBox.Visible = false;
            update_with_grant_option_checkBox.Visible = false;

            select_with_grant_option_checkBox.CheckedChanged -= select_with_grant_option_checkBox_CheckedChanged;
            update_with_grant_option_checkBox.CheckedChanged -= update_with_grant_option_checkBox_CheckedChanged;

            // Reset các lựa chọn trong checkedListBox chọn quyền trên bảng
            for (int i = 0; i < add_user_tab_checkedListBox.Items.Count; i++)
            {
                add_user_tab_checkedListBox.SetItemChecked(i, false);
            }

            // Xóa các item trong checkedListBox chọn cột
            add_user_column_checkedListBox.Items.Clear();

            // Lấy bảng được chọn
            if (add_user_select_table_comboBox.SelectedItem != null)
            {
                string selectedTable = add_user_select_table_comboBox.SelectedItem.ToString();

                // Load danh sách quyền của bảng đã chọn trước đó
                TablePrivilege entry = selectedTablePrivileges.Find(t => t.TableName == selectedTable);

                if (entry != null)
                {
                    foreach (var priv in entry.Privileges)
                    {
                        int index = add_user_tab_checkedListBox.Items.IndexOf(priv.PrivilegeName);

                        if (index >= 0)
                        {
                            add_user_tab_checkedListBox.SetItemChecked(index, true);
                        }
                    }
                }
            }

            add_user_tab_checkedListBox.ItemCheck += add_user_tab_checkedListBox_ItemCheck;
        }

        private void add_user_tab_checkedListBox_Click(object sender, EventArgs e)
        {
            // Lấy bảng được chọn
            string selectedTable = add_user_select_table_comboBox.SelectedItem?.ToString();

            // Lấy quyền được click
            string selectedPrivilege = add_user_tab_checkedListBox.SelectedItem?.ToString();

            // Load with grant option checkbox nếu có
            if (selectedPrivilege == "SELECT")
            {
                select_with_grant_option_checkBox.Visible = true;
                update_with_grant_option_checkBox.Visible = false;
                select_with_grant_option_checkBox.CheckedChanged -= select_with_grant_option_checkBox_CheckedChanged;
            }
            else if (selectedPrivilege == "UPDATE")
            {
                select_with_grant_option_checkBox.Visible = false;
                update_with_grant_option_checkBox.Visible = true;
                update_with_grant_option_checkBox.CheckedChanged -= update_with_grant_option_checkBox_CheckedChanged;
            }
            else
            {
                select_with_grant_option_checkBox.Visible = false;
                update_with_grant_option_checkBox.Visible = false;
            }


            TablePrivilege entry = selectedTablePrivileges.Find(t => t.TableName == selectedTable);

            if (entry != null)
            {
                var priv = entry.Privileges.FirstOrDefault(p => p.PrivilegeName == selectedPrivilege);
                
                if (priv != null && priv.WithGrantOption)
                {
                    if (selectedPrivilege == "SELECT")
                    {
                        select_with_grant_option_checkBox.Checked = true;
                    }
                    else if (selectedPrivilege == "UPDATE")
                    {
                        update_with_grant_option_checkBox.Checked = true;
                    }
                }
                else
                {
                    if (selectedPrivilege == "SELECT")
                    {
                        select_with_grant_option_checkBox.Checked = false;
                    }
                    else if (selectedPrivilege == "UPDATE")
                    {
                        update_with_grant_option_checkBox.Checked = false;
                    }
                }
            }

            if (selectedPrivilege == "SELECT")
            {
                select_with_grant_option_checkBox.CheckedChanged += select_with_grant_option_checkBox_CheckedChanged;
            }
            else if (selectedPrivilege == "UPDATE")
            {
                update_with_grant_option_checkBox.CheckedChanged += update_with_grant_option_checkBox_CheckedChanged;
            }

            add_user_column_checkedListBox.ItemCheck -= add_user_column_checkedListBox_ItemCheck;

            // Nếu quyền được chọn là SELECT hoặc UPDATE, hiển thị danh sách cột được gán quyền
            if (selectedPrivilege == "SELECT")
            {
                add_user_column_checkedListBox.Visible = true;
                LoadTableCols("lay_ds_cols", selectedTable);

                // Reset add_user_column_checkedListBox
                for (int i = 0; i < add_user_column_checkedListBox.Items.Count; i++)
                {
                    add_user_column_checkedListBox.SetItemChecked(i, false);
                }

                // Load lựa chọn cột từ entry nếu có
                if (entry != null)
                {
                    var priv = entry.Privileges.FirstOrDefault(p => p.PrivilegeName == selectedPrivilege);
                    if (priv != null)
                    {
                        foreach (var col in priv.Columns)
                        {
                            int index = add_user_column_checkedListBox.Items.IndexOf(col);
                            if (index >= 0)
                            {
                                add_user_column_checkedListBox.SetItemChecked(index, true);
                            }
                        }
                    }
                }
            }
            else if (selectedPrivilege == "UPDATE")
            {
                add_user_column_checkedListBox.Visible = true;
                LoadTableCols("lay_ds_cols_khong_la_khoa_chinh", selectedTable);

                // Reset add_user_column_checkedListBox
                for (int i = 0; i < add_user_column_checkedListBox.Items.Count; i++)
                {
                    add_user_column_checkedListBox.SetItemChecked(i, false);
                }

                // Load lựa chọn cột từ entry nếu có
                if (entry != null)
                {
                    var priv = entry.Privileges.FirstOrDefault(p => p.PrivilegeName == selectedPrivilege);
                    if (priv != null)
                    {
                        foreach (var col in priv.Columns)
                        {
                            int index = add_user_column_checkedListBox.Items.IndexOf(col);
                            if (index >= 0)
                            {
                                add_user_column_checkedListBox.SetItemChecked(index, true);
                            }
                        }
                    }
                }
            }
            else
            {
                add_user_column_checkedListBox.Visible = false;
            }
            add_user_column_checkedListBox.ItemCheck += add_user_column_checkedListBox_ItemCheck;
        }

        private void add_user_tab_checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (add_user_select_table_comboBox.SelectedItem != null)
            {
                // Lấy bảng được chọn
                string selectedTable = add_user_select_table_comboBox.SelectedItem.ToString();

                // Lấy lựa chọn vừa chọn
                string selectedPrivilege = add_user_tab_checkedListBox.Items[e.Index].ToString();

                // Hiển thị checkbox "WITH GRANT OPTION" nếu quyền là SELECT, UPDATE
                if (selectedPrivilege == "SELECT")
                {
                    select_with_grant_option_checkBox.Visible = true;
                    update_with_grant_option_checkBox.Visible = false;
                }
                else if (selectedPrivilege == "UPDATE")
                {
                    select_with_grant_option_checkBox.Visible = false;
                    update_with_grant_option_checkBox.Visible = true;
                }
                else
                {
                    select_with_grant_option_checkBox.Visible = false;
                    update_with_grant_option_checkBox.Visible = false;
                }

                // Lưu quyền hoặc bỏ lưu quyền được chọn vào danh sách quyền
                if (selectedTable != null)
                {
                    TablePrivilege tablePrivilege = selectedTablePrivileges.Find(t => t.TableName == selectedTable);

                    if (tablePrivilege == null)
                    {
                        tablePrivilege = new TablePrivilege(selectedTable);
                        selectedTablePrivileges.Add(tablePrivilege);
                    }

                    if (e.NewValue == CheckState.Checked)
                    {
                        if (!tablePrivilege.Privileges.Any(p => p.PrivilegeName == selectedPrivilege))
                        {
                            if (selectedPrivilege == "SELECT")
                            {
                                tablePrivilege.Privileges.Add(new PrivilegeInfo(selectedPrivilege, select_with_grant_option_checkBox.Checked, new List<string>()));
                            }
                            else if (selectedPrivilege == "UPDATE")
                            {
                                tablePrivilege.Privileges.Add(new PrivilegeInfo(selectedPrivilege, update_with_grant_option_checkBox.Checked, new List<string>()));
                            }
                            else
                            {
                                tablePrivilege.Privileges.Add(new PrivilegeInfo(selectedPrivilege, false, new List<string>()));
                            }
                        }
                    }
                    else
                    {
                        var priv = tablePrivilege.Privileges.FirstOrDefault(p => p.PrivilegeName == selectedPrivilege);

                        if (priv != null)
                        {
                            tablePrivilege.Privileges.Remove(priv);

                            if (selectedPrivilege == "SELECT")
                            {
                                select_with_grant_option_checkBox.Checked = false;
                            }
                            else if (selectedPrivilege == "UPDATE")
                            {
                                update_with_grant_option_checkBox.Visible = false;
                            }

                            // Bỏ check add_user_column_checkedListBox
                            for (int i = 0; i < add_user_column_checkedListBox.Items.Count; i++)
                            {
                                if (add_user_column_checkedListBox.GetItemChecked(i))
                                {
                                    add_user_column_checkedListBox.SetItemChecked(i, false);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void add_user_column_checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Lấy bảng được chọn
            string selectedTable = add_user_select_table_comboBox.SelectedItem?.ToString();

            // Lấy quyền được click
            string selectedPrivilege = add_user_tab_checkedListBox.SelectedItem?.ToString();

            // Lấy cột được chọn
            string selectedColumn = add_user_column_checkedListBox.Items[e.Index].ToString();

            // Lấy danh sách quyền của bảng
            TablePrivilege tablePrivilege = selectedTablePrivileges.Find(t => t.TableName == selectedTable);

            if (tablePrivilege != null)
            {
                var priv = tablePrivilege.Privileges.FirstOrDefault(p => p.PrivilegeName == selectedPrivilege);

                if (priv != null)
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        if (!priv.Columns.Contains(selectedColumn))
                        {
                            priv.Columns.Add(selectedColumn);
                        }
                    }
                    else
                    {
                        priv.Columns.Remove(selectedColumn);
                    }
                }
            }
        }

        private void select_with_grant_option_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Lấy bảng được chọn
            string selectedTable = add_user_select_table_comboBox.SelectedItem?.ToString();

            // Lấy danh sách quyền của bảng
            TablePrivilege tablePrivilege = selectedTablePrivileges.Find(t => t.TableName == selectedTable);

            if (tablePrivilege != null)
            {
                var priv = tablePrivilege.Privileges.FirstOrDefault(p => p.PrivilegeName == "SELECT");

                if (priv != null)
                {
                    priv.WithGrantOption = select_with_grant_option_checkBox.Checked;
                }
            }
        }

        private void update_with_grant_option_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Lấy bảng được chọn
            string selectedTable = add_user_select_table_comboBox.SelectedItem?.ToString();

            // Lấy danh sách quyền của bảng
            TablePrivilege tablePrivilege = selectedTablePrivileges.Find(t => t.TableName == selectedTable);

            if (tablePrivilege != null)
            {
                var priv = tablePrivilege.Privileges.FirstOrDefault(p => p.PrivilegeName == "UPDATE");

                if (priv != null)
                {
                    priv.WithGrantOption = update_with_grant_option_checkBox.Checked;
                }
            }
        }

        

        /// //////////////////////////////////////
        private void back_label_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (username_textBox.Text != "" || password_textBox.Text != "") shouldWarn = true;
            if (add_user_sys_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (add_user_role_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (selectedTablePrivileges.Count > 0) shouldWarn = true;

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainForm.LoadControl(new Admin_QLUsers(mainForm));
                }
            }
            else
            {
                mainForm.LoadControl(new Admin_QLUsers(mainForm));
            }
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (username_textBox.Text != "" || password_textBox.Text != "") shouldWarn = true;
            if (add_user_sys_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (add_user_role_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (selectedTablePrivileges.Count > 0) shouldWarn = true;

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainForm.LoadControl(new Admin_QLUsers(mainForm));
                }
            }
            else
            {
                mainForm.LoadControl(new Admin_QLUsers(mainForm));
            }
        }

        private void back_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (username_textBox.Text != "" || password_textBox.Text != "") shouldWarn = true;
            if (add_user_sys_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (add_user_role_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (selectedTablePrivileges.Count > 0) shouldWarn = true;

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainForm.LoadControl(new Admin_QLUsers(mainForm));
                }
            }
            else
            {
                mainForm.LoadControl(new Admin_QLUsers(mainForm));
            }
        }

        private void back_flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.BurlyWood;
            back_pictureBox.Image = Properties.Resources.back__2_;
        }

        private void back_flowLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.Black;
            back_pictureBox.Image = Properties.Resources.back__1_;
        }

        private void back_label_MouseEnter(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.BurlyWood;
            back_pictureBox.Image = Properties.Resources.back__2_;
        }

        private void back_label_MouseLeave(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.Black;
            back_pictureBox.Image = Properties.Resources.back__1_;
        }

        private void back_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.BurlyWood;
            back_pictureBox.Image = Properties.Resources.back__2_;
        }

        private void back_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            back_label.ForeColor = Color.Black;
            back_pictureBox.Image = Properties.Resources.back__1_;
        }
    }
}
