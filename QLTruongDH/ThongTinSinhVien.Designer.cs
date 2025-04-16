namespace QLTruongDH
{
    partial class ThongTinSinhVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            back__button = new Button();
            alter_button = new Button();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label = new Label();
            ngaySinh_dateTimePicker = new DateTimePicker();
            ngaySinh_label = new Label();
            diaChi_textBox = new TextBox();
            diaChi_label = new Label();
            khoa_comboBox = new ComboBox();
            tinhTrang_comboBox = new ComboBox();
            sdt_textBox = new TextBox();
            sdt_label = new Label();
            hoTen_textBox = new TextBox();
            hoTen_label = new Label();
            gioiTinh_comboBox = new ComboBox();
            gioiTinh_label = new Label();
            khoa_label = new Label();
            tinhTrang_label = new Label();
            mssv_textBox = new TextBox();
            mssv_label = new Label();
            SuspendLayout();
            // 
            // back__button
            // 
            back__button.BackColor = SystemColors.ActiveBorder;
            back__button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back__button.ForeColor = Color.Transparent;
            back__button.Location = new Point(477, 919);
            back__button.Name = "back__button";
            back__button.Size = new Size(322, 78);
            back__button.TabIndex = 87;
            back__button.Text = "Trở về";
            back__button.UseVisualStyleBackColor = false;
            // 
            // alter_button
            // 
            alter_button.BackColor = Color.BurlyWood;
            alter_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alter_button.ForeColor = Color.Transparent;
            alter_button.Location = new Point(819, 919);
            alter_button.Name = "alter_button";
            alter_button.Size = new Size(322, 78);
            alter_button.TabIndex = 86;
            alter_button.Text = "Sửa thông tin";
            alter_button.UseVisualStyleBackColor = false;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 84;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(25, 25);
            label.Margin = new Padding(0);
            label.Name = "label";
            label.Size = new Size(413, 59);
            label.TabIndex = 83;
            label.Text = "Thông tin sinh viên";
            // 
            // ngaySinh_dateTimePicker
            // 
            ngaySinh_dateTimePicker.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaySinh_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            ngaySinh_dateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaySinh_dateTimePicker.Format = DateTimePickerFormat.Custom;
            ngaySinh_dateTimePicker.Location = new Point(600, 365);
            ngaySinh_dateTimePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            ngaySinh_dateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            ngaySinh_dateTimePicker.Name = "ngaySinh_dateTimePicker";
            ngaySinh_dateTimePicker.Size = new Size(286, 50);
            ngaySinh_dateTimePicker.TabIndex = 108;
            // 
            // ngaySinh_label
            // 
            ngaySinh_label.AutoSize = true;
            ngaySinh_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ngaySinh_label.Location = new Point(600, 315);
            ngaySinh_label.Margin = new Padding(0);
            ngaySinh_label.Name = "ngaySinh_label";
            ngaySinh_label.Size = new Size(166, 45);
            ngaySinh_label.TabIndex = 107;
            ngaySinh_label.Text = "Ngày sinh";
            // 
            // diaChi_textBox
            // 
            diaChi_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diaChi_textBox.Location = new Point(600, 665);
            diaChi_textBox.Name = "diaChi_textBox";
            diaChi_textBox.Size = new Size(913, 50);
            diaChi_textBox.TabIndex = 106;
            // 
            // diaChi_label
            // 
            diaChi_label.AutoSize = true;
            diaChi_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diaChi_label.Location = new Point(600, 615);
            diaChi_label.Margin = new Padding(0);
            diaChi_label.Name = "diaChi_label";
            diaChi_label.Size = new Size(119, 45);
            diaChi_label.TabIndex = 105;
            diaChi_label.Text = "Địa chỉ";
            // 
            // khoa_comboBox
            // 
            khoa_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khoa_comboBox.FormattingEnabled = true;
            khoa_comboBox.Location = new Point(600, 212);
            khoa_comboBox.Name = "khoa_comboBox";
            khoa_comboBox.Size = new Size(286, 53);
            khoa_comboBox.TabIndex = 104;
            // 
            // tinhTrang_comboBox
            // 
            tinhTrang_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tinhTrang_comboBox.FormattingEnabled = true;
            tinhTrang_comboBox.Location = new Point(25, 665);
            tinhTrang_comboBox.Name = "tinhTrang_comboBox";
            tinhTrang_comboBox.Size = new Size(392, 53);
            tinhTrang_comboBox.TabIndex = 103;
            // 
            // sdt_textBox
            // 
            sdt_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sdt_textBox.Location = new Point(600, 515);
            sdt_textBox.Name = "sdt_textBox";
            sdt_textBox.Size = new Size(286, 50);
            sdt_textBox.TabIndex = 102;
            // 
            // sdt_label
            // 
            sdt_label.AutoSize = true;
            sdt_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sdt_label.Location = new Point(600, 465);
            sdt_label.Margin = new Padding(0);
            sdt_label.Name = "sdt_label";
            sdt_label.Size = new Size(212, 45);
            sdt_label.TabIndex = 101;
            sdt_label.Text = "Số điện thoại";
            // 
            // hoTen_textBox
            // 
            hoTen_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoTen_textBox.Location = new Point(25, 365);
            hoTen_textBox.Name = "hoTen_textBox";
            hoTen_textBox.Size = new Size(392, 50);
            hoTen_textBox.TabIndex = 100;
            // 
            // hoTen_label
            // 
            hoTen_label.AutoSize = true;
            hoTen_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoTen_label.Location = new Point(25, 315);
            hoTen_label.Margin = new Padding(0);
            hoTen_label.Name = "hoTen_label";
            hoTen_label.Size = new Size(120, 45);
            hoTen_label.TabIndex = 99;
            hoTen_label.Text = "Họ tên";
            // 
            // gioiTinh_comboBox
            // 
            gioiTinh_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gioiTinh_comboBox.FormattingEnabled = true;
            gioiTinh_comboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioiTinh_comboBox.Location = new Point(25, 515);
            gioiTinh_comboBox.Name = "gioiTinh_comboBox";
            gioiTinh_comboBox.Size = new Size(199, 53);
            gioiTinh_comboBox.TabIndex = 98;
            // 
            // gioiTinh_label
            // 
            gioiTinh_label.AutoSize = true;
            gioiTinh_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioiTinh_label.Location = new Point(25, 465);
            gioiTinh_label.Margin = new Padding(0);
            gioiTinh_label.Name = "gioiTinh_label";
            gioiTinh_label.Size = new Size(145, 45);
            gioiTinh_label.TabIndex = 97;
            gioiTinh_label.Text = "Giới tính";
            // 
            // khoa_label
            // 
            khoa_label.AutoSize = true;
            khoa_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            khoa_label.Location = new Point(600, 162);
            khoa_label.Margin = new Padding(0);
            khoa_label.Name = "khoa_label";
            khoa_label.Size = new Size(95, 45);
            khoa_label.TabIndex = 96;
            khoa_label.Text = "Khoa";
            // 
            // tinhTrang_label
            // 
            tinhTrang_label.AutoSize = true;
            tinhTrang_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tinhTrang_label.Location = new Point(25, 615);
            tinhTrang_label.Margin = new Padding(0);
            tinhTrang_label.Name = "tinhTrang_label";
            tinhTrang_label.Size = new Size(172, 45);
            tinhTrang_label.TabIndex = 95;
            tinhTrang_label.Text = "Tình trạng";
            // 
            // mssv_textBox
            // 
            mssv_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mssv_textBox.Location = new Point(25, 215);
            mssv_textBox.Name = "mssv_textBox";
            mssv_textBox.Size = new Size(392, 50);
            mssv_textBox.TabIndex = 94;
            // 
            // mssv_label
            // 
            mssv_label.AutoSize = true;
            mssv_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mssv_label.Location = new Point(25, 165);
            mssv_label.Margin = new Padding(0);
            mssv_label.Name = "mssv_label";
            mssv_label.Size = new Size(247, 45);
            mssv_label.TabIndex = 93;
            mssv_label.Text = "Mã số sinh viên";
            // 
            // ThongTinSinhVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ngaySinh_dateTimePicker);
            Controls.Add(ngaySinh_label);
            Controls.Add(diaChi_textBox);
            Controls.Add(diaChi_label);
            Controls.Add(khoa_comboBox);
            Controls.Add(tinhTrang_comboBox);
            Controls.Add(sdt_textBox);
            Controls.Add(sdt_label);
            Controls.Add(hoTen_textBox);
            Controls.Add(hoTen_label);
            Controls.Add(gioiTinh_comboBox);
            Controls.Add(gioiTinh_label);
            Controls.Add(khoa_label);
            Controls.Add(tinhTrang_label);
            Controls.Add(mssv_textBox);
            Controls.Add(mssv_label);
            Controls.Add(back__button);
            Controls.Add(alter_button);
            Controls.Add(guna2Separator1);
            Controls.Add(label);
            Margin = new Padding(0);
            Name = "ThongTinSinhVien";
            Size = new Size(1620, 1169);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button back__button;
        private Button alter_button;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label;
        private DateTimePicker ngaySinh_dateTimePicker;
        private Label ngaySinh_label;
        private TextBox diaChi_textBox;
        private Label diaChi_label;
        private ComboBox khoa_comboBox;
        private ComboBox tinhTrang_comboBox;
        private TextBox sdt_textBox;
        private Label sdt_label;
        private TextBox hoTen_textBox;
        private Label hoTen_label;
        private ComboBox gioiTinh_comboBox;
        private Label gioiTinh_label;
        private Label khoa_label;
        private Label tinhTrang_label;
        private TextBox mssv_textBox;
        private Label mssv_label;
    }
}
