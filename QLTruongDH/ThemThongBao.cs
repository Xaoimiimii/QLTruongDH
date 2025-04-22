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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLTruongDH
{
    public partial class ThemThongBao : UserControl
    {
        private MainForm mainForm;
        public ThemThongBao(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void ThemThongBao_Load(object sender, EventArgs e)
        {

        }

        private void LoadLevelLabels()
        {
            using (OracleConnection conn = new OracleConnection(mainForm.connectionString))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("SP_LAY_DS_MA_DON_VI", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string madv = reader.GetString(0);
                            //donvi_comboBox.Items.Add(madv);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khi load mã đơn vị ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void Reset()
        {
            content_guna2TextBox.Text = "";

            for (int i = 0; i < level_checkedListBox.Items.Count; i++)
            {
                level_checkedListBox.SetItemChecked(i, false);
            }

            for (int i = 0; i < compartment_checkedListBox.Items.Count; i++)
            {
                compartment_checkedListBox.SetItemChecked(i, false);
            }

            for (int i = 0; i < group_checkedListBox.Items.Count; i++)
            {
                group_checkedListBox.SetItemChecked(i, false);
            }

            level_checkedListBox.ClearSelected();
            compartment_checkedListBox.ClearSelected();
            group_checkedListBox.ClearSelected();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string content = content_guna2TextBox.Text.Trim();
            List<String> selectedLevels = new List<string>();
            List<String> selectedCompartment = new List<string>();
            List<String> selectedGroups = new List<string>();

            foreach (var item in level_checkedListBox.CheckedItems)
            {
                selectedLevels.Add(item.ToString());
            }

            foreach (var item in compartment_checkedListBox.CheckedItems)
            {
                if (item == "Khoa CNTT") selectedCompartment.Add("CNTT");
                else if (item == "Khoa Toán - Toán tin") selectedCompartment.Add("TOAN");
                else if (item == "Khoa Vật lý") selectedCompartment.Add("LY");
                else if (item == "Khoa Hóa học") selectedCompartment.Add("HOA");
                else if (item == "Khoa Sinh học") selectedCompartment.Add("SH");
                else if (item == "Khoa Môi trường") selectedCompartment.Add("MT");
                else if (item == "Khoa Địa chất") selectedCompartment.Add("DC");
                else if (item == "Khoa Điện tử viễn thông") selectedCompartment.Add("DTVT");
                else if (item == "Khoa Công nghệ vật liệu") selectedCompartment.Add("CNVL");
                else if (item == "Khoa Khoa học liên ngành") selectedCompartment.Add("KHLN");
                else if (item == "Viện Tế bào gốc") selectedCompartment.Add("TBG");
                else if (item == "Phòng Đào tạo") selectedCompartment.Add("PDT");
                else if (item == "Phòng Khảo thí") selectedCompartment.Add("PKT");
                else if (item == "Phòng Công tác sinh viên") selectedCompartment.Add("CTSV");
                else if (item == "Phòng tổ chức hành chính") selectedCompartment.Add("TCHC");
            }

            foreach (var item in group_checkedListBox.CheckedItems)
            {
                selectedGroups.Add(item.ToString());
            }

            // Show the selected items in a message box
            string message = "Nội dung: " + content + "\n";
            message += "Mức độ: " + string.Join(", ", selectedLevels) + "\n";
            message += "Đơn vị: " + string.Join(", ", selectedCompartment) + "\n";
            message += "Nhóm: " + string.Join(", ", selectedGroups) + "\n";
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reset__button_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void back_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (content_guna2TextBox.Text != "" || level_checkedListBox.CheckedItems.Count != 0
                || compartment_checkedListBox.CheckedItems.Count != 0 || group_checkedListBox.CheckedItems.Count != 0)
                shouldWarn = true;

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) mainForm.LoadControl(new ThongBao(mainForm));
            }
            else mainForm.LoadControl(new ThongBao(mainForm));
        }

        private void back_label_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (content_guna2TextBox.Text != "" || level_checkedListBox.CheckedItems.Count != 0
                || compartment_checkedListBox.CheckedItems.Count != 0 || group_checkedListBox.CheckedItems.Count != 0)
                shouldWarn = true;

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) mainForm.LoadControl(new ThongBao(mainForm));
            }
            else mainForm.LoadControl(new ThongBao(mainForm));
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            bool shouldWarn = false;
            if (content_guna2TextBox.Text != "" || level_checkedListBox.CheckedItems.Count != 0
                || compartment_checkedListBox.CheckedItems.Count != 0 || group_checkedListBox.CheckedItems.Count != 0)
                shouldWarn = true;

            if (shouldWarn)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại? Dữ liệu đã nhập sẽ không lưu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) mainForm.LoadControl(new ThongBao(mainForm));
            }
            else mainForm.LoadControl(new ThongBao(mainForm));
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
