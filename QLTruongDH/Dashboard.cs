using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //hello_label.Parent = bg_pictureBox;
            //date_label.Parent = bg_pictureBox;
            //hello_label.BackColor = Color.Transparent;
            //date_label.BackColor = Color.Transparent;
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

    }
}
