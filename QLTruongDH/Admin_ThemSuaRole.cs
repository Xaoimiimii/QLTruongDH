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
using Oracle.ManagedDataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLTruongDH
{
    public partial class Admin_ThemSuaRole : UserControl
    {
        private Admin_MainForm mainForm;
        private string mode;
        private string roleName;
        private bool isAddMode = false;
        private bool isEditMode = false;
        private List<TablePrivilege> selectedTablePrivileges = new List<TablePrivilege>();

        public Admin_ThemSuaRole(Admin_MainForm form, string mode, string roleName)
        {
            InitializeComponent();
            this.mainForm = form;
            this.mode = mode;
            this.roleName = roleName;

            if (mode == "Add")
            {
                isAddMode = true;
                control_title_label.Text = "Thêm role";
                add_button.Text = "Thêm role";

                LoadRoleCheckedListBox("lay_ds_ten_roles");
            }
            else if (mode == "Edit")
            {
                isEditMode = true;
                control_title_label.Text = "Sửa thông tin role";
                add_button.Text = "Sửa thông tin";

                LoadRoleCheckedListBox("lay_ds_ten_roles_khong_phai_role_hien_tai", roleName);
            }

            LoadTabComboBox();
            add_role_tab_checkedListBox.Visible = false;
        }


        // === CLASS ===
        public class PrivilegeInfo
        {
            public string PrivilegeName { get; set; } // Tên quyền
            public List<string> Columns { get; set; } // Danh sách cột

            public PrivilegeInfo(string privilegeName, List<string> columns)
            {
                PrivilegeName = privilegeName;
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
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi khi load danh sách role trong checkedListBox: " + ex.Message);
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
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi khi load danh sách table trong comboBox");
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
                    MessageBox.Show($"Lỗi khi load danh sách column trong table '{tableName}'");
                }
            }
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

            if (selectedTablePrivileges.Count > 0)
            {
                sb.AppendLine("Các quyền bảng đã chọn: ");
                foreach (var tablePrivilege in selectedTablePrivileges)
                {
                    foreach (var privilege in tablePrivilege.Privileges)
                    {
                        string columns = privilege.Columns.Count > 0 ? string.Join(", ", privilege.Columns) : "ALL";
                        sb.AppendLine($"Bảng: {tablePrivilege.TableName} - Quyền: {privilege.PrivilegeName} - Cột: {columns}");
                    }
                }
            }

            return sb.ToString();
        }

        private void ResetPanel()
        {
            // Reset các trường nhập liệu
            rolename_textBox.Text = string.Empty;

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

            // Xóa danh sách quyền của user
            selectedTablePrivileges.Clear();

            if (mode == "Add") LoadRoleCheckedListBox("lay_ds_ten_roles");
            else if (mode == "Edit") LoadRoleCheckedListBox("lay_ds_ten_roles_khong_phai_role_hien_tai", roleName);

            LoadTabComboBox();
        }


        private void CreateRole()
        {
            string rolename = rolename_textBox.Text.Trim();

            // Kiểm tra username, password có nhập đủ không
            if (string.IsNullOrEmpty(rolename))
            {
                MessageBox.Show("Vui lòng nhập role", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy danh sách quyền hệ thống
            List<string> sysPrivileges = add_role_sys_checkedListBox.CheckedItems.Cast<string>().ToList();

            // Lấy danh sách quyền role
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
                GrantTablePrivilege(rolename);

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
                    MessageBox.Show("Lỗi khi cấp quyền hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GrantTablePrivilege(string rolename)
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
                                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = rolename;
                                    cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = false;
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
                                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = rolename;
                                    cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = false;
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
                    CreateRole();
                }
            }
            else
            {
                CreateRole();
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

                // Load danh sách quyền của bảng đã chọn trước đó
                TablePrivilege entry = selectedTablePrivileges.Find(t => t.TableName == selectedTable);

                if (entry != null)
                {
                    foreach (var priv in entry.Privileges)
                    {
                        int index = add_role_tab_checkedListBox.Items.IndexOf(priv.PrivilegeName);

                        if (index >= 0)
                        {
                            add_role_tab_checkedListBox.SetItemChecked(index, true);
                        }
                    }
                }
            }

            add_role_tab_checkedListBox.ItemCheck += add_role_tab_checkedListBox_ItemCheck;
        }

        private void add_role_tab_checkedListBox_Click(object sender, EventArgs e)
        {
            string selectedTable = add_role_select_table_comboBox.SelectedItem?.ToString();
            string selectedPrivilege = add_role_tab_checkedListBox.SelectedItem?.ToString();

            // Tìm entry theo table
            TablePrivilege entry = selectedTablePrivileges.Find(t => t.TableName == selectedTable);
            var priv = entry?.Privileges.FirstOrDefault(p => p.PrivilegeName == selectedPrivilege);

            add_role_column_checkedListBox.ItemCheck -= add_role_column_checkedListBox_ItemCheck;

            // Xử lý hiển thị danh sách cột SELECT/UPDATE
            if (selectedPrivilege == "SELECT" || selectedPrivilege == "UPDATE")
            {
                add_role_column_checkedListBox.Visible = true;

                // Gọi stored procedure tương ứng
                string procName = selectedPrivilege == "SELECT" ? "lay_ds_cols" : "lay_ds_cols_khong_la_khoa_chinh";
                LoadTableCols(procName, selectedTable);

                // Reset trạng thái checkbox
                for (int i = 0; i < add_role_column_checkedListBox.Items.Count; i++)
                    add_role_column_checkedListBox.SetItemChecked(i, false);

                // Set lại các cột được chọn từ dữ liệu đã lưu
                if (priv != null)
                {
                    foreach (var col in priv.Columns)
                    {
                        int index = add_role_column_checkedListBox.Items.IndexOf(col);
                        if (index >= 0)
                            add_role_column_checkedListBox.SetItemChecked(index, true);
                    }
                }
            }
            else
            {
                add_role_column_checkedListBox.Visible = false;
            }

            add_role_column_checkedListBox.ItemCheck += add_role_column_checkedListBox_ItemCheck;
        }

        private void add_role_tab_checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string selectedTable = add_role_select_table_comboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTable)) return;

            string selectedPrivilege = add_role_tab_checkedListBox.Items[e.Index].ToString();

            // Lấy hoặc tạo TablePrivilege tương ứng với bảng được chọn
            var tablePrivilege = selectedTablePrivileges.FirstOrDefault(t => t.TableName == selectedTable);

            if (tablePrivilege == null)
            {
                tablePrivilege = new TablePrivilege(selectedTable);
                selectedTablePrivileges.Add(tablePrivilege);
            }

            if (e.NewValue == CheckState.Checked)
            {
                // Thêm quyền nếu chưa tồn tại
                if (!tablePrivilege.Privileges.Any(p => p.PrivilegeName == selectedPrivilege))
                {
                    tablePrivilege.Privileges.Add(new PrivilegeInfo(selectedPrivilege, new List<string>()));
                }
            }
            else
            {
                // Xoá quyền nếu bỏ chọn
                var priv = tablePrivilege.Privileges.FirstOrDefault(p => p.PrivilegeName == selectedPrivilege);

                if (priv != null)
                {
                    tablePrivilege.Privileges.Remove(priv);

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
            // Lấy bảng được chọn
            string selectedTable = add_role_select_table_comboBox.SelectedItem?.ToString();

            // Lấy quyền được click
            string selectedPrivilege = add_role_tab_checkedListBox.SelectedItem?.ToString();

            // Lấy cột được chọn
            string selectedColumn = add_role_column_checkedListBox.Items[e.Index].ToString();

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


        private void back_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (rolename_textBox.Text != "") shouldWarn = true;
            if (add_role_sys_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (add_role_role_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (selectedTablePrivileges.Count > 0) shouldWarn = true;

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
            if (rolename_textBox.Text != "") shouldWarn = true;
            if (add_role_sys_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (add_role_role_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (selectedTablePrivileges.Count > 0) shouldWarn = true;

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
            if (rolename_textBox.Text != "") shouldWarn = true;
            if (add_role_sys_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (add_role_role_checkedListBox.CheckedItems.Count > 0) shouldWarn = true;
            if (selectedTablePrivileges.Count > 0) shouldWarn = true;

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
