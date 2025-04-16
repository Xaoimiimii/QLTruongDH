namespace QLTruongDH
{
    partial class QLSinhVien
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            search_student_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            search_student_label = new Label();
            student_dataGridView = new DataGridView();
            MaSinhVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            Phai = new DataGridViewTextBoxColumn();
            NgSinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Dt = new DataGridViewTextBoxColumn();
            MaKhoa = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            hoTen_textBox = new TextBox();
            hoTen_label = new Label();
            gioiTinh_comboBox = new ComboBox();
            gioiTinh_label = new Label();
            khoa_label = new Label();
            tinhTrang_label = new Label();
            mssv_textBox = new TextBox();
            mssv_label = new Label();
            sdt_textBox = new TextBox();
            sdt_label = new Label();
            tinhTrang_comboBox = new ComboBox();
            khoa_comboBox = new ComboBox();
            diaChi_textBox = new TextBox();
            diaChi_label = new Label();
            ngaySinh_label = new Label();
            ngaySinh_dateTimePicker = new DateTimePicker();
            add_button = new Button();
            alter_button = new Button();
            cancel_button = new Button();
            confirm_button = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            search_student_button = new Button();
            info_panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)student_dataGridView).BeginInit();
            info_panel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(371, 59);
            label1.TabIndex = 9;
            label1.Text = "Quản lý sinh viên";
            // 
            // search_student_guna2TextBox
            // 
            search_student_guna2TextBox.BorderRadius = 20;
            search_student_guna2TextBox.CustomizableEdges = customizableEdges1;
            search_student_guna2TextBox.DefaultText = "";
            search_student_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_student_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_student_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_student_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_student_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_student_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_student_guna2TextBox.HoverState.BorderColor = Color.Gray;
            search_student_guna2TextBox.IconLeftOffset = new Point(10, 0);
            search_student_guna2TextBox.IconRight = Properties.Resources.close__1_;
            search_student_guna2TextBox.IconRightOffset = new Point(10, 0);
            search_student_guna2TextBox.Location = new Point(211, 136);
            search_student_guna2TextBox.Margin = new Padding(7);
            search_student_guna2TextBox.Name = "search_student_guna2TextBox";
            search_student_guna2TextBox.PlaceholderText = "";
            search_student_guna2TextBox.SelectedText = "";
            search_student_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_student_guna2TextBox.Size = new Size(271, 51);
            search_student_guna2TextBox.TabIndex = 43;
            // 
            // search_student_label
            // 
            search_student_label.AutoSize = true;
            search_student_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_student_label.Location = new Point(25, 142);
            search_student_label.Margin = new Padding(0);
            search_student_label.Name = "search_student_label";
            search_student_label.Size = new Size(179, 37);
            search_student_label.TabIndex = 42;
            search_student_label.Text = "Mã sinh viên:";
            // 
            // student_dataGridView
            // 
            student_dataGridView.AllowUserToAddRows = false;
            student_dataGridView.AllowUserToDeleteRows = false;
            student_dataGridView.AllowUserToResizeRows = false;
            student_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            student_dataGridView.BackgroundColor = Color.FloralWhite;
            student_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            student_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaSinhVien, HoTen, Phai, NgSinh, DiaChi, Dt, MaKhoa, TinhTrang });
            student_dataGridView.Location = new Point(25, 214);
            student_dataGridView.Margin = new Padding(0);
            student_dataGridView.MultiSelect = false;
            student_dataGridView.Name = "student_dataGridView";
            student_dataGridView.ReadOnly = true;
            student_dataGridView.RowHeadersVisible = false;
            student_dataGridView.RowHeadersWidth = 82;
            student_dataGridView.Size = new Size(1567, 430);
            student_dataGridView.TabIndex = 45;
            // 
            // MaSinhVien
            // 
            MaSinhVien.FillWeight = 120F;
            MaSinhVien.HeaderText = "Mã sinh viên";
            MaSinhVien.MinimumWidth = 10;
            MaSinhVien.Name = "MaSinhVien";
            MaSinhVien.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // Phai
            // 
            Phai.FillWeight = 70F;
            Phai.HeaderText = "Phái";
            Phai.MinimumWidth = 10;
            Phai.Name = "Phai";
            Phai.ReadOnly = true;
            // 
            // NgSinh
            // 
            NgSinh.HeaderText = "Ngày sinh";
            NgSinh.MinimumWidth = 10;
            NgSinh.Name = "NgSinh";
            NgSinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // Dt
            // 
            Dt.HeaderText = "Sđt";
            Dt.MinimumWidth = 10;
            Dt.Name = "Dt";
            Dt.ReadOnly = true;
            // 
            // MaKhoa
            // 
            MaKhoa.HeaderText = "Khoa";
            MaKhoa.MinimumWidth = 10;
            MaKhoa.Name = "MaKhoa";
            MaKhoa.ReadOnly = true;
            // 
            // TinhTrang
            // 
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 10;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.ReadOnly = true;
            // 
            // hoTen_textBox
            // 
            hoTen_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoTen_textBox.Location = new Point(0, 195);
            hoTen_textBox.Name = "hoTen_textBox";
            hoTen_textBox.Size = new Size(345, 43);
            hoTen_textBox.TabIndex = 84;
            // 
            // hoTen_label
            // 
            hoTen_label.AutoSize = true;
            hoTen_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoTen_label.Location = new Point(0, 145);
            hoTen_label.Margin = new Padding(0);
            hoTen_label.Name = "hoTen_label";
            hoTen_label.Size = new Size(100, 37);
            hoTen_label.TabIndex = 83;
            hoTen_label.Text = "Họ tên";
            // 
            // gioiTinh_comboBox
            // 
            gioiTinh_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gioiTinh_comboBox.FormattingEnabled = true;
            gioiTinh_comboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioiTinh_comboBox.Location = new Point(0, 328);
            gioiTinh_comboBox.Name = "gioiTinh_comboBox";
            gioiTinh_comboBox.Size = new Size(199, 45);
            gioiTinh_comboBox.TabIndex = 82;
            // 
            // gioiTinh_label
            // 
            gioiTinh_label.AutoSize = true;
            gioiTinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioiTinh_label.Location = new Point(0, 278);
            gioiTinh_label.Margin = new Padding(0);
            gioiTinh_label.Name = "gioiTinh_label";
            gioiTinh_label.Size = new Size(123, 37);
            gioiTinh_label.TabIndex = 81;
            gioiTinh_label.Text = "Giới tính";
            // 
            // khoa_label
            // 
            khoa_label.AutoSize = true;
            khoa_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            khoa_label.Location = new Point(477, 145);
            khoa_label.Margin = new Padding(0);
            khoa_label.Name = "khoa_label";
            khoa_label.Size = new Size(80, 37);
            khoa_label.TabIndex = 79;
            khoa_label.Text = "Khoa";
            // 
            // tinhTrang_label
            // 
            tinhTrang_label.AutoSize = true;
            tinhTrang_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tinhTrang_label.Location = new Point(895, 12);
            tinhTrang_label.Margin = new Padding(0);
            tinhTrang_label.Name = "tinhTrang_label";
            tinhTrang_label.Size = new Size(144, 37);
            tinhTrang_label.TabIndex = 77;
            tinhTrang_label.Text = "Tình trạng";
            // 
            // mssv_textBox
            // 
            mssv_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mssv_textBox.Location = new Point(0, 62);
            mssv_textBox.Name = "mssv_textBox";
            mssv_textBox.Size = new Size(345, 43);
            mssv_textBox.TabIndex = 76;
            // 
            // mssv_label
            // 
            mssv_label.AutoSize = true;
            mssv_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mssv_label.Location = new Point(0, 12);
            mssv_label.Margin = new Padding(0);
            mssv_label.Name = "mssv_label";
            mssv_label.Size = new Size(207, 37);
            mssv_label.TabIndex = 75;
            mssv_label.Text = "Mã số sinh viên";
            // 
            // sdt_textBox
            // 
            sdt_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sdt_textBox.Location = new Point(477, 62);
            sdt_textBox.Name = "sdt_textBox";
            sdt_textBox.Size = new Size(286, 43);
            sdt_textBox.TabIndex = 86;
            // 
            // sdt_label
            // 
            sdt_label.AutoSize = true;
            sdt_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sdt_label.Location = new Point(477, 12);
            sdt_label.Margin = new Padding(0);
            sdt_label.Name = "sdt_label";
            sdt_label.Size = new Size(178, 37);
            sdt_label.TabIndex = 85;
            sdt_label.Text = "Số điện thoại";
            // 
            // tinhTrang_comboBox
            // 
            tinhTrang_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tinhTrang_comboBox.FormattingEnabled = true;
            tinhTrang_comboBox.Location = new Point(895, 62);
            tinhTrang_comboBox.Name = "tinhTrang_comboBox";
            tinhTrang_comboBox.Size = new Size(345, 45);
            tinhTrang_comboBox.TabIndex = 87;
            // 
            // khoa_comboBox
            // 
            khoa_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khoa_comboBox.FormattingEnabled = true;
            khoa_comboBox.Location = new Point(477, 195);
            khoa_comboBox.Name = "khoa_comboBox";
            khoa_comboBox.Size = new Size(286, 45);
            khoa_comboBox.TabIndex = 88;
            // 
            // diaChi_textBox
            // 
            diaChi_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diaChi_textBox.Location = new Point(477, 328);
            diaChi_textBox.Name = "diaChi_textBox";
            diaChi_textBox.Size = new Size(763, 43);
            diaChi_textBox.TabIndex = 90;
            // 
            // diaChi_label
            // 
            diaChi_label.AutoSize = true;
            diaChi_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diaChi_label.Location = new Point(477, 278);
            diaChi_label.Margin = new Padding(0);
            diaChi_label.Name = "diaChi_label";
            diaChi_label.Size = new Size(100, 37);
            diaChi_label.TabIndex = 89;
            diaChi_label.Text = "Địa chỉ";
            // 
            // ngaySinh_label
            // 
            ngaySinh_label.AutoSize = true;
            ngaySinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ngaySinh_label.Location = new Point(895, 145);
            ngaySinh_label.Margin = new Padding(0);
            ngaySinh_label.Name = "ngaySinh_label";
            ngaySinh_label.Size = new Size(140, 37);
            ngaySinh_label.TabIndex = 91;
            ngaySinh_label.Text = "Ngày sinh";
            // 
            // ngaySinh_dateTimePicker
            // 
            ngaySinh_dateTimePicker.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaySinh_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            ngaySinh_dateTimePicker.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaySinh_dateTimePicker.Format = DateTimePickerFormat.Custom;
            ngaySinh_dateTimePicker.Location = new Point(895, 195);
            ngaySinh_dateTimePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            ngaySinh_dateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            ngaySinh_dateTimePicker.Name = "ngaySinh_dateTimePicker";
            ngaySinh_dateTimePicker.Size = new Size(345, 43);
            ngaySinh_dateTimePicker.TabIndex = 92;
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(1328, 12);
            add_button.Name = "add_button";
            add_button.Size = new Size(239, 64);
            add_button.TabIndex = 93;
            add_button.Text = "Thêm sinh viên";
            add_button.UseVisualStyleBackColor = false;
            // 
            // alter_button
            // 
            alter_button.BackColor = SystemColors.ActiveBorder;
            alter_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alter_button.ForeColor = Color.Transparent;
            alter_button.Location = new Point(1328, 92);
            alter_button.Name = "alter_button";
            alter_button.Size = new Size(239, 64);
            alter_button.TabIndex = 94;
            alter_button.Text = "Xóa sinh viên";
            alter_button.UseVisualStyleBackColor = false;
            // 
            // cancel_button
            // 
            cancel_button.BackColor = SystemColors.ActiveBorder;
            cancel_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_button.ForeColor = Color.Transparent;
            cancel_button.Location = new Point(1328, 409);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(239, 64);
            cancel_button.TabIndex = 96;
            cancel_button.Text = "Hủy";
            cancel_button.UseVisualStyleBackColor = false;
            // 
            // confirm_button
            // 
            confirm_button.BackColor = Color.BurlyWood;
            confirm_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_button.ForeColor = Color.Transparent;
            confirm_button.Location = new Point(1328, 329);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(239, 64);
            confirm_button.TabIndex = 95;
            confirm_button.Text = "Xác nhận";
            confirm_button.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(665, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 45);
            comboBox1.TabIndex = 98;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(582, 142);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(80, 37);
            label2.TabIndex = 97;
            label2.Text = "Khoa";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1143, 139);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(211, 45);
            comboBox2.TabIndex = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(996, 142);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(144, 37);
            label3.TabIndex = 99;
            label3.Text = "Tình trạng";
            // 
            // search_student_button
            // 
            search_student_button.BackColor = Color.BurlyWood;
            search_student_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_student_button.ForeColor = Color.Transparent;
            search_student_button.Location = new Point(1452, 130);
            search_student_button.Name = "search_student_button";
            search_student_button.Size = new Size(140, 64);
            search_student_button.TabIndex = 44;
            search_student_button.Text = "Tra cứu";
            search_student_button.UseVisualStyleBackColor = false;
            // 
            // info_panel
            // 
            info_panel.Controls.Add(mssv_label);
            info_panel.Controls.Add(mssv_textBox);
            info_panel.Controls.Add(tinhTrang_label);
            info_panel.Controls.Add(khoa_label);
            info_panel.Controls.Add(gioiTinh_label);
            info_panel.Controls.Add(cancel_button);
            info_panel.Controls.Add(gioiTinh_comboBox);
            info_panel.Controls.Add(confirm_button);
            info_panel.Controls.Add(hoTen_label);
            info_panel.Controls.Add(alter_button);
            info_panel.Controls.Add(hoTen_textBox);
            info_panel.Controls.Add(add_button);
            info_panel.Controls.Add(sdt_label);
            info_panel.Controls.Add(ngaySinh_dateTimePicker);
            info_panel.Controls.Add(sdt_textBox);
            info_panel.Controls.Add(ngaySinh_label);
            info_panel.Controls.Add(tinhTrang_comboBox);
            info_panel.Controls.Add(diaChi_textBox);
            info_panel.Controls.Add(khoa_comboBox);
            info_panel.Controls.Add(diaChi_label);
            info_panel.Location = new Point(25, 670);
            info_panel.Margin = new Padding(0);
            info_panel.Name = "info_panel";
            info_panel.Size = new Size(1567, 486);
            info_panel.TabIndex = 101;
            // 
            // QLSinhVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(info_panel);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(student_dataGridView);
            Controls.Add(search_student_button);
            Controls.Add(search_student_guna2TextBox);
            Controls.Add(search_student_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "QLSinhVien";
            Size = new Size(1620, 1169);
            ((System.ComponentModel.ISupportInitialize)student_dataGridView).EndInit();
            info_panel.ResumeLayout(false);
            info_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox search_student_guna2TextBox;
        private Label search_student_label;
        private DataGridView student_dataGridView;
        private DataGridViewTextBoxColumn MaSinhVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Phai;
        private DataGridViewTextBoxColumn NgSinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Dt;
        private DataGridViewTextBoxColumn MaKhoa;
        private DataGridViewTextBoxColumn TinhTrang;
        private TextBox hoTen_textBox;
        private Label hoTen_label;
        private ComboBox gioiTinh_comboBox;
        private Label gioiTinh_label;
        private Label khoa_label;
        private Label tinhTrang_label;
        private TextBox mssv_textBox;
        private Label mssv_label;
        private TextBox sdt_textBox;
        private Label sdt_label;
        private ComboBox tinhTrang_comboBox;
        private ComboBox khoa_comboBox;
        private TextBox diaChi_textBox;
        private Label diaChi_label;
        private Label ngaySinh_label;
        private DateTimePicker ngaySinh_dateTimePicker;
        private Button add_button;
        private Button alter_button;
        private Button cancel_button;
        private Button confirm_button;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private Button search_student_button;
        private Panel info_panel;
    }
}
