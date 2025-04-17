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
    public partial class Admin_ThemSuaRole : UserControl
    {
        private Admin_MainForm mainForm;
        private string mode;
        private string roleName;
        private bool isAddMode = false;
        private bool isEditMode = false;

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
        }

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


        private void back_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.LoadControl(new Admin_QLRoles(mainForm));
            }
        }

        private void back_label_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.LoadControl(new Admin_QLRoles(mainForm));
            }
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
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
