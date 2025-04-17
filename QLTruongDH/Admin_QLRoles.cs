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
    public partial class Admin_QLRoles : UserControl
    {
        private Admin_MainForm mainForm;
        private List<TablePrivilege> selectedTablePrivileges = new List<TablePrivilege>();

        public Admin_QLRoles(Admin_MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            LoadRole();
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
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi khi load danh sách role");
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new Admin_ThemSuaRole(mainForm, "Add"));
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new Admin_ThemSuaRole(mainForm, "Edit"));
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void search_role_button_Click(object sender, EventArgs e)
        {

        }
    }
}
