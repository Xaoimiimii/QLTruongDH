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
    public partial class Admin_ThemSuaUser : UserControl
    {
        private Admin_MainForm mainForm;
        private string mode;
        private string username;
        private bool isAddMode = false;
        private bool isEditMode = false;

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
            this.username = username;
        }

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
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi khi load danh sách user trong checkedListBox");
                }
            }
        }

        private void back_label_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.LoadControl(new Admin_QLUsers(mainForm));
            }
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.LoadControl(new Admin_QLUsers(mainForm));
            }
        }

        private void back_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
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
