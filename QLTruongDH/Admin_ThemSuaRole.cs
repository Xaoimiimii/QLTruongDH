﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLTruongDH
{
    public partial class Admin_ThemSuaRole : UserControl
    {
        private Admin_MainForm mainForm;
        private string mode;
        private string roleName;

        private List<string> sysPrivsList = new List<string>();
        private List<string> rolePrivsList = new List<string>();

        private List<string> tableNameList = new List<string>();
        private List<string> tablePrivsList = new List<string>();
        private List<string> typeList = new List<string>();
        private List<string> grantableList = new List<string>();

        Dictionary<(string TableName, string PrivilegeName), PrivilegeState> pre_privilegeMap = new();
        Dictionary<(string TableName, string PrivilegeName), PrivilegeState> privilegeMap = new();

        public Admin_ThemSuaRole(Admin_MainForm form, string mode, string roleName,
            List<string> sysPrivsList, List<string> rolePrivsList, List<string> pre_tableNameList,
            List<string> pre_tablePrivsList, List<string> pre_typeList, List<string> pre_grantableList)
        {
            InitializeComponent();
            this.mainForm = form;
            this.mode = mode;
            this.roleName = roleName;
            this.sysPrivsList = sysPrivsList;
            this.rolePrivsList = rolePrivsList;
            this.tableNameList = pre_tableNameList;
            this.tablePrivsList = pre_tablePrivsList;
            this.typeList = pre_typeList;
            this.grantableList = pre_grantableList;

            LoadTabComboBox();

            if (mode == "Add")
            {
                control_title_label.Text = "Thêm role";
                add_button.Text = "Thêm role";
                LoadRoleCheckedListBox("lay_ds_ten_roles");
            }
            else if (mode == "Edit")
            {
                control_title_label.Text = "Sửa thông tin role";
                add_button.Text = "Sửa thông tin";
                rolename_textBox.Text = roleName;
                rolename_textBox.Enabled = false;
                LoadRoleCheckedListBox("lay_ds_ten_roles_khong_phai_role_hien_tai", roleName);

                LoadSysPrivsFromSysPrivsList();
                LoadRolePrivsFromRolePrivsList();

                pre_privilegeMap = ProcessPreTabPrivilegeData();
                privilegeMap = DeepCopyPrivilegeMap(pre_privilegeMap);

                //HienThiDataNhanDuoc();
            }

            add_role_tab_checkedListBox.Visible = false;
        }




        // === HELPER FUNCTION ===
        private string GetPrivilegesInfo()
        {
            StringBuilder sb = new StringBuilder();

            if (add_role_sys_checkedListBox.CheckedItems.Count > 0)
            {
                sb.AppendLine("Các quyền hệ thống đã chọn: ");
                foreach (var item in add_role_sys_checkedListBox.CheckedItems)
                {
                    sb.AppendLine(item.ToString());
                }
                sb.AppendLine();
            }

            if (add_role_role_checkedListBox.CheckedItems.Count > 0)
            {
                sb.AppendLine("Các quyền role đã chọn: ");
                foreach (var item in add_role_role_checkedListBox.CheckedItems)
                {
                    sb.AppendLine(item.ToString());
                }
                sb.AppendLine();
            }

            // privilegeMap
            if (privilegeMap.Count > 0)
            {
                sb.AppendLine("Các quyền bảng đã chọn: ");
                foreach (var item in privilegeMap)
                {
                    var (tableName, privilegeName) = item.Key;
                    var privilegeState = item.Value;
                    string columns;

                    if (privilegeState.Columns.Count > 0) columns = string.Join(", ", privilegeState.Columns);
                    else columns = "ALL";

                    sb.AppendLine($"Bảng: {tableName} - Quyền: {privilegeName} - Grantable: {privilegeState.WithGrantOption} - Cột: {columns}");
                }
            }

            return sb.ToString();
        }


        private void ResetPanel()
        {
            // Reset các trường nhập liệu
            if (mode == "Add")
            {
                rolename_textBox.Text = string.Empty;
            }

            // Reset các checkedListBox
            for (int i = 0; i < add_role_sys_checkedListBox.Items.Count; i++)
            {
                add_role_sys_checkedListBox.SetItemChecked(i, false);
            }

            for (int i = 0; i < add_role_role_checkedListBox.Items.Count; i++)
            {
                add_role_role_checkedListBox.SetItemChecked(i, false);
            }

            for (int i = 0; i < add_role_tab_checkedListBox.Items.Count; i++)
            {
                add_role_tab_checkedListBox.SetItemChecked(i, false);
            }

            for (int i = 0; i < add_role_column_checkedListBox.Items.Count; i++)
            {
                add_role_column_checkedListBox.SetItemChecked(i, false);
            }

            // Reset combobox
            add_role_select_table_comboBox.SelectedIndex = -1;

            // Ẩn danh sách cột
            add_role_column_checkedListBox.Visible = false;

            // Ẩn danh sách quyền
            add_role_tab_checkedListBox.Visible = false;

            // Xóa/reset privilegeMap
            if (mode == "Add")
            {
                privilegeMap.Clear();
            }
            else if (mode == "Edit")
            {
                privilegeMap.Clear();
                privilegeMap = DeepCopyPrivilegeMap(pre_privilegeMap);

            }

            if (mode == "Add") LoadRoleCheckedListBox("lay_ds_ten_roles");
            else if (mode == "Edit") LoadRoleCheckedListBox("lay_ds_ten_roles_khong_phai_role_hien_tai", roleName);

            LoadTabComboBox();
        }


        private Dictionary<(string TableName, string PrivilegeName), PrivilegeState> DeepCopyPrivilegeMap(
            Dictionary<(string TableName, string PrivilegeName), PrivilegeState> original)
        {
            var copy = new Dictionary<(string TableName, string PrivilegeName), PrivilegeState>();

            foreach (var item in original)
            {
                var key = item.Key;
                var state = item.Value;

                var copiedState = new PrivilegeState(state.WithGrantOption, new List<string>(state.Columns));

                copy[key] = copiedState;
            }

            return copy;
        }


        private Dictionary<(string TableName, string PrivilegeName), PrivilegeState> ProcessPreTabPrivilegeData()
        {
            Dictionary<(string TableName, string PrivilegeName), PrivilegeState> privilegeMap = new();

            for (int i = 0; i < tableNameList.Count; i++)
            {
                string tableName = tableNameList[i];
                string tablePriv = tablePrivsList[i];
                string type = typeList[i];
                List<string> columns = new List<string>();

                bool grantable = false;
                if (grantableList[i] == "YES")
                {
                    grantable = true;
                }
                else if (grantableList[i] == "NO")
                {
                    grantable = false;
                }

                if (type == "VIEW")
                {
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (OracleCommand cmd = new OracleCommand("lay_ds_cols", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("p_tablename", OracleDbType.Varchar2).Value = tableName;
                                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                                using (OracleDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string colName = reader.GetString(0);
                                        columns.Add(colName);
                                    }
                                }
                            }
                        }
                        catch (OracleException)
                        {
                            MessageBox.Show($"Lỗi khi load danh sách column trong table '{tableName}'", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Lấy tên bảng từ tên view
                    int underscoreIndex = tableName.IndexOf('_');
                    if (underscoreIndex != -1)
                    {
                        tableName = tableName.Substring(0, underscoreIndex);
                    }
                }


                var key = (tableName, tablePrivsList[i]);
                var privilegeState = new PrivilegeState(grantable, columns);
                privilegeMap[key] = privilegeState;
            }
            return privilegeMap;
        }

        private void LoadSysPrivsFromSysPrivsList()
        {
            foreach (string item in sysPrivsList)
            {
                int index = add_role_sys_checkedListBox.Items.IndexOf(item);
                if (index != -1)
                {
                    add_role_sys_checkedListBox.SetItemChecked(index, true);
                }
            }
        }

        private void LoadRolePrivsFromRolePrivsList()
        {
            foreach (string item in rolePrivsList)
            {
                int index = add_role_role_checkedListBox.Items.IndexOf(item);
                if (index != -1)
                {
                    add_role_role_checkedListBox.SetItemChecked(index, true);
                }
            }
        }



        // === LOAD DATA ===
        private void LoadRoleCheckedListBox(string procedureName, string? inputParamValue = null)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Nếu có parameter input thì thêm vào
                        if (!string.IsNullOrEmpty(inputParamValue))
                        {
                            cmd.Parameters.Add("p_rolename", OracleDbType.Varchar2).Value = inputParamValue;
                        }

                        // Thêm parameter output cho cursor
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            add_role_role_checkedListBox.Items.Clear();

                            while (reader.Read())
                            {
                                string roleName = reader.GetString(0);
                                add_role_role_checkedListBox.Items.Add(roleName);
                            }
                        }
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load danh sách role trong checkedListBox","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            add_role_select_table_comboBox.Items.Clear();

                            while (reader.Read())
                            {
                                string tableName = reader.GetString(0);
                                add_role_select_table_comboBox.Items.Add(tableName);
                            }
                        }
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi load danh sách table trong comboBox", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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
                            add_role_column_checkedListBox.Items.Clear();
                            while (reader.Read())
                            {
                                string colName = reader.GetString(0);
                                add_role_column_checkedListBox.Items.Add(colName);
                            }
                        }
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show($"Lỗi khi load danh sách column trong table '{tableName}'", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        // === CREATE, ALTER, GRANT PRIVS FUNCTION ===
        private void CreateRole()
        {
            string rolename = rolename_textBox.Text.Trim();

            // Kiểm tra username, password có nhập đủ không
            if (string.IsNullOrEmpty(rolename))
            {
                MessageBox.Show("Vui lòng nhập role", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy danh sách quyền hệ thống và role
            List<string> sysPrivileges = add_role_sys_checkedListBox.CheckedItems.Cast<string>().ToList();
            List<string> rolePrivileges = add_role_role_checkedListBox.CheckedItems.Cast<string>().ToList();

            // Tạo user mới trong cơ sở dữ liệu
            if (CreateRoleSp(rolename))
            {
                // Gán các quyền hệ thống (Sys Privileges)
                foreach (var priv in sysPrivileges)
                {
                    GrantPrivilege(rolename, priv);
                }

                // Gán các quyền role (Role Privileges)
                foreach (var role in rolePrivileges)
                {
                    GrantPrivilege(rolename, role);
                }

                // Gán các quyền bảng (Table Privileges)
                GrantTablePrivilege(privilegeMap, rolename);

                MessageBox.Show("Role đã được tạo và cấp quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset panel
                ResetPanel();
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo role!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CreateRoleSp(string rolename)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("tao_role", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = rolename;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi tạo role", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool AlterSysPrivs()
        {
            bool isChanged = false;

            // Lấy danh sách quyền hệ thống
            List<string> sysPrivileges = add_role_sys_checkedListBox.CheckedItems.Cast<string>().ToList();

            // Kiểm tra sysPrivileges có thay đổi không
            List<string> sysPrivilegesToRemove = sysPrivsList.Except(sysPrivileges).ToList();
            List<string> sysPrivilegesToAdd = sysPrivileges.Except(sysPrivsList).ToList();

            // Gán các quyền hệ thống thêm vào
            if (sysPrivilegesToAdd.Count > 0)
            {
                foreach (var priv in sysPrivilegesToAdd)
                {
                    GrantPrivilege(roleName, priv);
                }
                isChanged = true;
            }

            // Gỡ bỏ các quyền hệ thống không còn được chọn
            if (sysPrivilegesToRemove.Count > 0)
            {
                foreach (var priv in sysPrivilegesToRemove)
                {
                    RevokeSysRolePrivilege(priv);
                }
                isChanged = true;
            }

            return isChanged;
        }

        private bool AlterRolePrivs()
        {
            bool isChanged = false;

            // Lấy danh sách quyền role
            List<string> rolePrivileges = add_role_role_checkedListBox.CheckedItems.Cast<string>().ToList();

            // Kiểm tra rolePrivileges có thay đổi không
            List<string> rolePrivilegesToRemove = rolePrivsList.Except(rolePrivileges).ToList();
            List<string> rolePrivilegesToAdd = rolePrivileges.Except(rolePrivsList).ToList();

            // Gán các quyền role thêm vào
            if (rolePrivilegesToAdd.Count > 0)
            {
                foreach (var role in rolePrivilegesToAdd)
                {
                    GrantPrivilege(roleName, role);
                }
            }

            // Gỡ bỏ các quyền role không còn được chọn
            if (rolePrivilegesToRemove.Count > 0)
            {
                foreach (var role in rolePrivilegesToRemove)
                {
                    RevokeSysRolePrivilege(role);
                }
            }

            return isChanged;
        }

        private bool AlterTabPrivs()
        {
            bool isChanged = false;

            Dictionary<(string TableName, string PrivilegeName), PrivilegeState> toGrant = new();
            Dictionary<(string TableName, string PrivilegeName), PrivilegeState> toRevoke = new();

            // Tìm quyền bị revoke (có trong preMap nhưng không còn hoặc khác trong curMap)
            foreach (var item in pre_privilegeMap)
            {
                if (!privilegeMap.TryGetValue(item.Key, out var curState) || !item.Value.Equals(curState))
                {
                    toRevoke[item.Key] = item.Value;
                }
            }

            // Tìm quyền cần cấp thêm (có trong curMap nhưng không có hoặc khác trong preMap)
            foreach (var item in privilegeMap)
            {
                if (!pre_privilegeMap.TryGetValue(item.Key, out var preState) || !item.Value.Equals(preState))
                {
                    toGrant[item.Key] = item.Value;
                }
            }

            // Gỡ bỏ các quyền tab không còn được chọn
            if (toRevoke.Count > 0)
            {
                // Duyệt qua các quyền bảng cũ
                foreach (var item in toRevoke)
                {
                    var (tableName, privilegeName) = item.Key;
                    var privilegeState = item.Value;

                    if (privilegeState.Columns.Count > 0)
                    {
                        // Sort các cột được chọn theo tên
                        privilegeState.Columns.Sort();

                        // Nếu có cột được chọn, gỡ bỏ quyền trên view
                        string columnsForViewName = string.Join("_", privilegeState.Columns);
                        string viewName = $"{tableName}_{columnsForViewName}_VIEW";

                        //// Show messageBox để xác nhận tên view, privilegeName, username
                        //MessageBox.Show($"Gỡ bỏ quyền {privilegeName} trên view {viewName} cho user {username}", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Gỡ bỏ quyền trên view
                        RevokeTabPrivilege(privilegeName, viewName);
                    }
                    else
                    {
                        //MessageBox.Show($"Gỡ bỏ quyền {privilegeName} trên bảng {tableName} cho user {username}", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Nếu không có cột nào được chọn, gỡ bỏ quyền trên bảng
                        RevokeTabPrivilege(privilegeName, tableName);
                    }
                }
                isChanged = true;
            }

            // Gán các quyền bảng mới
            if (toGrant.Count > 0)
            {
                GrantTablePrivilege(toGrant, roleName);
                isChanged = true;
            }

            return isChanged;
        }



        private void GrantPrivilege(string rolename, string privilege)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("grant_priv", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = rolename;
                        cmd.Parameters.Add("p_priv", OracleDbType.Varchar2).Value = privilege;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show($"Lỗi khi cấp quyền hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GrantTablePrivilege(Dictionary<(string TableName, string PrivilegeName), PrivilegeState> privilegeMap, string rolename)
        {
            foreach (var item in privilegeMap)
            {
                string tableName = item.Key.TableName;
                string privilegeName = item.Key.PrivilegeName;
                PrivilegeState state = item.Value;

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
                            cmd.Parameters.Add("p_tablename", OracleDbType.Varchar2).Value = tableName;
                            cmd.Parameters.Add("p_count", OracleDbType.Int32).Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();
                            columnCount = ((OracleDecimal)cmd.Parameters["p_count"].Value).ToInt32();
                        }
                    }
                    catch (OracleException)
                    {
                        MessageBox.Show($"Lỗi khi đếm số cột của bảng {tableName}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                }

                // Sort các cột được chọn theo tên
                state.Columns.Sort();
                List<string> selectedColumns = state.Columns ?? new List<string>();

                if (selectedColumns.Count > 0 && selectedColumns.Count < columnCount)
                {
                    // Tạo tên view và danh sách cột
                    string columnsForViewName = string.Join("_", selectedColumns);
                    string columnsForSql = string.Join(",", selectedColumns);
                    string viewName = $"{tableName}_{columnsForViewName}_VIEW";

                    // Tạo view
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (OracleCommand cmd = new OracleCommand("tao_view", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("p_view_name", OracleDbType.Varchar2).Value = viewName;
                                cmd.Parameters.Add("p_column_list", OracleDbType.Varchar2).Value = columnsForSql;
                                cmd.Parameters.Add("p_tablename", OracleDbType.Varchar2).Value = tableName;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (OracleException)
                        {
                            MessageBox.Show($"Lỗi khi tạo view {viewName}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                    }

                    // Gán quyền trên view
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (OracleCommand cmd = new OracleCommand("cap_quyen_view_table", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("p_privilege_name", OracleDbType.Varchar2).Value = privilegeName;
                                cmd.Parameters.Add("p_view_name", OracleDbType.Varchar2).Value = viewName;
                                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = rolename;
                                cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = state.WithGrantOption;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (OracleException)
                        {
                            MessageBox.Show($"Lỗi khi cấp quyền {privilegeName} trên view {viewName}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                    }
                }
                else
                {
                    // Gán quyền trực tiếp trên bảng
                    using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (OracleCommand cmd = new OracleCommand("cap_quyen_view_table", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("p_privilege_name", OracleDbType.Varchar2).Value = privilegeName;
                                cmd.Parameters.Add("p_view_name", OracleDbType.Varchar2).Value = tableName;
                                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = rolename;
                                cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = state.WithGrantOption;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (OracleException)
                        {
                            MessageBox.Show($"Lỗi khi cấp quyền {privilegeName} trên bảng {tableName}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                    }
                }
            }
        }


        private void RevokeSysRolePrivilege(string privilege)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("revoke_sys_role_priv", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = roleName;
                        cmd.Parameters.Add("p_priv", OracleDbType.Varchar2).Value = privilege;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Lỗi khi gỡ quyền hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RevokeTabPrivilege(string privilege, string tablename)
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("revoke_tab_priv", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_tablename", OracleDbType.Varchar2).Value = tablename;
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = roleName;
                        cmd.Parameters.Add("p_priv", OracleDbType.Varchar2).Value = privilege;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show($"Lỗi khi gỡ quyền {privilege} trên bảng {tablename}",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (mode == "Add") CreateRole();
                    else if (mode == "Edit")
                    {
                        bool isSysPrivsChanged = AlterSysPrivs();
                        bool isRolePrivsChanged = AlterRolePrivs();
                        bool isTabPrivsChanged = AlterTabPrivs();
                        if (isSysPrivsChanged || isRolePrivsChanged || isTabPrivsChanged)
                        {
                            MessageBox.Show("Cập nhật quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có thay đổi nào được thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                if (mode == "Add") CreateRole();
                else if (mode == "Edit")
                {
                    bool isSysPrivsChanged = AlterSysPrivs();
                    bool isRolePrivsChanged = AlterRolePrivs();
                    bool isTabPrivsChanged = AlterTabPrivs();
                    if (isSysPrivsChanged || isRolePrivsChanged || isTabPrivsChanged)
                    {
                        MessageBox.Show("Cập nhật quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void add_role_select_table_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_role_tab_checkedListBox.Visible = true;

            add_role_tab_checkedListBox.ItemCheck -= add_role_tab_checkedListBox_ItemCheck;

            // Reset các lựa chọn trong checkedListBox chọn quyền trên bảng
            for (int i = 0; i < add_role_tab_checkedListBox.Items.Count; i++)
            {
                add_role_tab_checkedListBox.SetItemChecked(i, false);
            }

            // Xóa các item trong checkedListBox chọn cột
            add_role_column_checkedListBox.Items.Clear();

            // Lấy bảng được chọn
            if (add_role_select_table_comboBox.SelectedItem != null)
            {
                string selectedTable = add_role_select_table_comboBox.SelectedItem.ToString();

                // Tạo key từ bảng đã chọn và 4 quyền
                var key1 = (selectedTable, "SELECT");
                var key2 = (selectedTable, "INSERT");
                var key3 = (selectedTable, "DELETE");
                var key4 = (selectedTable, "UPDATE");

                // Kiểm tra nếu có quyền trong privilegeMap
                if (privilegeMap.ContainsKey(key1)) add_role_tab_checkedListBox.SetItemChecked(0, true);
                if (privilegeMap.ContainsKey(key2)) add_role_tab_checkedListBox.SetItemChecked(1, true);
                if (privilegeMap.ContainsKey(key3)) add_role_tab_checkedListBox.SetItemChecked(2, true);
                if (privilegeMap.ContainsKey(key4)) add_role_tab_checkedListBox.SetItemChecked(3, true);

            }

            add_role_tab_checkedListBox.ItemCheck += add_role_tab_checkedListBox_ItemCheck;
        }

        private void add_role_tab_checkedListBox_Click(object sender, EventArgs e)
        {
            string selectedTable = add_role_select_table_comboBox.SelectedItem?.ToString();
            string selectedPrivilege = add_role_tab_checkedListBox.SelectedItem?.ToString();

            add_role_column_checkedListBox.ItemCheck -= add_role_column_checkedListBox_ItemCheck;

            if (selectedPrivilege == "SELECT")
            {
                add_role_column_checkedListBox.Visible = true;
                LoadTableCols("lay_ds_cols", selectedTable);
            }
            else if (selectedPrivilege == "UPDATE")
            {
                add_role_column_checkedListBox.Visible = true;
                LoadTableCols("lay_ds_cols_khong_la_khoa_chinh", selectedTable);
            }
            else
            {
                add_role_column_checkedListBox.Visible = false;
            }

            var key = (selectedTable, selectedPrivilege);

            // Kiểm tra nếu có quyền tồn tại trong privilegeMap
            if (privilegeMap.ContainsKey(key))
            {
                var privState = privilegeMap[key];

                // Reset trạng thái checkbox cho tất cả các cột
                for (int i = 0; i < add_role_column_checkedListBox.Items.Count; i++)
                    add_role_column_checkedListBox.SetItemChecked(i, false);

                // Set lại các cột được chọn từ dữ liệu đã lưu
                foreach (var col in privState.Columns)
                {
                    int index = add_role_column_checkedListBox.Items.IndexOf(col);
                    if (index >= 0)
                        add_role_column_checkedListBox.SetItemChecked(index, true);
                }
            }

            add_role_column_checkedListBox.ItemCheck += add_role_column_checkedListBox_ItemCheck;
        }

        private void add_role_tab_checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string selectedTable = add_role_select_table_comboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTable)) return;

            string selectedPrivilege = add_role_tab_checkedListBox.Items[e.Index].ToString();

            if (selectedPrivilege == "SELECT" || selectedPrivilege == "UPDATE") add_role_column_checkedListBox.Visible = true;
            else add_role_column_checkedListBox.Visible = false;

            var key = (selectedTable, selectedPrivilege);

            if (e.NewValue == CheckState.Checked)
            {
                if (privilegeMap.ContainsKey(key))
                {
                    // Cập nhật Grant Option nếu đã tồn tại
                    privilegeMap[key].WithGrantOption = false;
                }
                else
                {
                    // Tạo mới PrivilegeState nếu chưa có
                    privilegeMap[key] = new PrivilegeState(false, new List<string>());
                }
            }
            else // Nếu bỏ chọn
            {
                if (privilegeMap.ContainsKey(key))
                {
                    privilegeMap.Remove(key);

                    // Bỏ check tất cả các cột trong danh sách cột
                    for (int i = 0; i < add_role_column_checkedListBox.Items.Count; i++)
                    {
                        if (add_role_column_checkedListBox.GetItemChecked(i))
                            add_role_column_checkedListBox.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void add_role_column_checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string selectedTable = add_role_select_table_comboBox.SelectedItem?.ToString();
            string selectedPrivilege = add_role_tab_checkedListBox.SelectedItem?.ToString();
            string selectedColumn = add_role_column_checkedListBox.Items[e.Index].ToString();

            var key = (selectedTable, selectedPrivilege);

            if (e.NewValue == CheckState.Checked)
            {
                if (privilegeMap.ContainsKey(key))
                {
                    var privState = privilegeMap[key];
                    if (!privState.Columns.Contains(selectedColumn))
                    {
                        privState.Columns.Add(selectedColumn);
                    }
                }
                //else
                //{
                //    // Nếu chưa có trong map, tạo mới PrivilegeState với danh sách cột rỗng
                //    var newPrivState = new PrivilegeState(false, new List<string> { selectedColumn });
                //    privilegeMap[key] = newPrivState;
                //}
            }
            else
            {
                // Xoá cột khỏi danh sách
                if (privilegeMap.ContainsKey(key))
                {
                    var privState = privilegeMap[key];
                    privState.Columns.Remove(selectedColumn);
                }
            }
        }


        private void back_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (rolename_textBox.Text != "") shouldWarn = true;
                if (add_role_sys_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
                if (add_role_role_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
                if (privilegeMap.Count > 0) shouldWarn = true;
            }

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainForm.LoadControl(new Admin_QLRoles(mainForm));
                }
            }
            else
            {
                mainForm.LoadControl(new Admin_QLRoles(mainForm));
            }
        }

        private void back_label_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (rolename_textBox.Text != "") shouldWarn = true;
                if (add_role_sys_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
                if (add_role_role_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
                if (privilegeMap.Count > 0) shouldWarn = true;
            }

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainForm.LoadControl(new Admin_QLRoles(mainForm));
                }
            }
            else
            {
                mainForm.LoadControl(new Admin_QLRoles(mainForm));
            }
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (mode == "Add")
            {
                if (rolename_textBox.Text != "") shouldWarn = true;
                if (add_role_sys_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
                if (add_role_role_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
                if (privilegeMap.Count > 0) shouldWarn = true;
            }

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainForm.LoadControl(new Admin_QLRoles(mainForm));
                }
            }
            else
            {
                mainForm.LoadControl(new Admin_QLRoles(mainForm));
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
