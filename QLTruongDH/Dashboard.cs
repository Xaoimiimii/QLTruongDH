using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLTruongDH
{
    public partial class Dashboard : UserControl
    {
        private MainForm mainForm;

        public Dashboard(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            //hello_label.Location = bg_pictureBox.PointToClient(hello_label.PointToScreen(Point.Empty));
            //date_label.Location = bg_pictureBox.PointToClient(date_label.PointToScreen(Point.Empty));
            //hello_label.Parent = bg_pictureBox;
            //date_label.Parent = bg_pictureBox;
            //hello_label.BackColor = Color.Transparent;
            //date_label.BackColor = Color.Transparent;

            hello_label.Text = "Xin chào, " + mainForm.username;
            string dayOfWeek = DateTime.Now.ToString("dddd");
            if (dayOfWeek == "Monday") dayOfWeek = "Thứ 2";
            else if (dayOfWeek == "Tuesday") dayOfWeek = "Thứ 3";
            else if (dayOfWeek == "Wednesday") dayOfWeek = "Thứ 4";
            else if (dayOfWeek == "Thursday") dayOfWeek = "Thứ 5";
            else if (dayOfWeek == "Friday") dayOfWeek = "Thứ 6";
            else if (dayOfWeek == "Saturday") dayOfWeek = "Thứ 7";
            else if (dayOfWeek == "Sunday") dayOfWeek = "Chủ nhật";

            date_label.Text = DateTime.Now.ToString(dayOfWeek + ", dd/MM/yyyy");
        }

        private void qlNhanVien_guna2ShadowPanel_Click(object sender, EventArgs e)
        {

            mainForm.UpdateStatus("QLNhanVien");
            mainForm.LoadControl(new QLNhanVien(mainForm));
        }

        private void qlNhanVien_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLNhanVien");
            mainForm.LoadControl(new QLNhanVien(mainForm));
        }

        private void qlNhanVien_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLNhanVien");
            mainForm.LoadControl(new QLNhanVien(mainForm));
        }

        private void qlSinhVien_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLSinhVien");
            mainForm.LoadControl(new QLSinhVien(mainForm));
        }

        private void qlSinhVien_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLSinhVien");
            mainForm.LoadControl(new QLSinhVien(mainForm));
        }

        private void qlSinhVien_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLSinhVien");
            mainForm.LoadControl(new QLSinhVien(mainForm));
        }

        private void phanCongDayHoc_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("PhanCong");
            mainForm.LoadControl(new PhanCongDayHoc(mainForm));
        }

        private void phanCongDayHoc_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("PhanCong");
            mainForm.LoadControl(new PhanCongDayHoc(mainForm));
        }

        private void phanCongDayHoc_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("PhanCong");
            mainForm.LoadControl(new PhanCongDayHoc(mainForm));
        }

        private void dkHocPhan_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("DKHocPhan");
            mainForm.LoadControl(new DangKyHocPhan(mainForm));
        }

        private void dkHocPhan_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("DKHocPhan");
            mainForm.LoadControl(new DangKyHocPhan(mainForm));
        }

        private void dkHocPhan_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("DKHocPhan");
            mainForm.LoadControl(new DangKyHocPhan(mainForm));
        }

        private void bangDiem_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("BangDiem");
            mainForm.LoadControl(new BangDiem(mainForm));
        }

        private void bangDiem_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("BangDiem");
            mainForm.LoadControl(new BangDiem(mainForm));
        }

        private void bangDiem_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("BangDiem");
            mainForm.LoadControl(new BangDiem(mainForm));
        }

        private void thongBao_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ThongBao");
            mainForm.LoadControl(new ThongBao(mainForm));
        }

        private void thongBao_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ThongBao");
            mainForm.LoadControl(new ThongBao(mainForm));
        }

        private void thongBao_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ThongBao");
            mainForm.LoadControl(new ThongBao(mainForm));
        }

        private void qlNhanVien_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            qlNhanVien_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlNhanVien_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            qlNhanVien_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlNhanVien_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            qlNhanVien_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlNhanVien_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            qlNhanVien_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlNhanVien_label_MouseEnter(object sender, EventArgs e)
        {
            qlNhanVien_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlNhanVien_label_MouseLeave(object sender, EventArgs e)
        {
            qlNhanVien_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlSinhVien_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            qlSinhVien_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlSinhVien_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            qlSinhVien_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlSinhVien_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            qlSinhVien_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlSinhVien_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            qlSinhVien_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void qlSinhVien_label_MouseEnter(object sender, EventArgs e)
        {
            qlSinhVien_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void qlSinhVien_label_MouseLeave(object sender, EventArgs e)
        {
            qlSinhVien_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void thongBao_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            thongBao_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void thongBao_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            thongBao_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void thongBao_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            thongBao_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void thongBao_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            thongBao_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void thongBao_label_MouseEnter(object sender, EventArgs e)
        {
            thongBao_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void thongBao_label_MouseLeave(object sender, EventArgs e)
        {
            thongBao_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void phanCongDayHoc_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            phanCongDayHoc_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void phanCongDayHoc_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            phanCongDayHoc_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void phanCongDayHoc_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            phanCongDayHoc_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void phanCongDayHoc_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            phanCongDayHoc_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void phanCongDayHoc_label_MouseEnter(object sender, EventArgs e)
        {
            phanCongDayHoc_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void phanCongDayHoc_label_MouseLeave(object sender, EventArgs e)
        {
            phanCongDayHoc_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void dkHocPhan_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            dkHocPhan_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void dkHocPhan_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            dkHocPhan_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void dkHocPhan_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            dkHocPhan_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void dkHocPhan_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            dkHocPhan_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void dkHocPhan_label_MouseEnter(object sender, EventArgs e)
        {
            dkHocPhan_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void dkHocPhan_label_MouseLeave(object sender, EventArgs e)
        {
            dkHocPhan_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void bangDiem_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            bangDiem_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void bangDiem_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            bangDiem_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void bangDiem_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            bangDiem_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void bangDiem_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            bangDiem_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }

        private void bangDiem_label_MouseEnter(object sender, EventArgs e)
        {
            bangDiem_guna2ShadowPanel.FillColor = Color.NavajoWhite;
        }

        private void bangDiem_label_MouseLeave(object sender, EventArgs e)
        {
            bangDiem_guna2ShadowPanel.FillColor = Color.BlanchedAlmond;
        }
    }
}
