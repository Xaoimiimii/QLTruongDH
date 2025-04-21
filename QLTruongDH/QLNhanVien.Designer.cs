namespace QLTruongDH
{
    partial class QLNhanVien
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
            search_employee_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            delete_button = new Button();
            edit_button = new Button();
            search_employee_label = new Label();
            employee_dataGridView = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            Phai = new DataGridViewTextBoxColumn();
            NgSinh = new DataGridViewTextBoxColumn();
            Luong = new DataGridViewTextBoxColumn();
            PhuCap = new DataGridViewTextBoxColumn();
            Dt = new DataGridViewTextBoxColumn();
            VaiTro = new DataGridViewTextBoxColumn();
            MaDonVi = new DataGridViewTextBoxColumn();
            add_button = new Button();
            search_employee_button = new Button();
            ((System.ComponentModel.ISupportInitialize)employee_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(389, 59);
            label1.TabIndex = 7;
            label1.Text = "Quản lý nhân viên";
            // 
            // search_employee_guna2TextBox
            // 
            search_employee_guna2TextBox.BorderRadius = 20;
            search_employee_guna2TextBox.CustomizableEdges = customizableEdges1;
            search_employee_guna2TextBox.DefaultText = "";
            search_employee_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_employee_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_employee_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_employee_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_employee_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_employee_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_employee_guna2TextBox.HoverState.BorderColor = Color.Gray;
            search_employee_guna2TextBox.IconLeft = Properties.Resources.search;
            search_employee_guna2TextBox.IconLeftOffset = new Point(10, 0);
            search_employee_guna2TextBox.IconRight = Properties.Resources.close__1_;
            search_employee_guna2TextBox.IconRightOffset = new Point(10, 0);
            search_employee_guna2TextBox.Location = new Point(222, 148);
            search_employee_guna2TextBox.Margin = new Padding(7);
            search_employee_guna2TextBox.Name = "search_employee_guna2TextBox";
            search_employee_guna2TextBox.PlaceholderText = "";
            search_employee_guna2TextBox.SelectedText = "";
            search_employee_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_employee_guna2TextBox.Size = new Size(360, 51);
            search_employee_guna2TextBox.TabIndex = 39;
            search_employee_guna2TextBox.TextOffset = new Point(20, 0);
            search_employee_guna2TextBox.IconRightClick += search_employee_guna2TextBox_IconRightClick;
            search_employee_guna2TextBox.KeyDown += search_employee_guna2TextBox_KeyDown;
            // 
            // delete_button
            // 
            delete_button.BackColor = SystemColors.ActiveBorder;
            delete_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_button.ForeColor = Color.Transparent;
            delete_button.Location = new Point(477, 1044);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(322, 78);
            delete_button.TabIndex = 38;
            delete_button.Text = "Xóa nhân viên";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // edit_button
            // 
            edit_button.BackColor = Color.BurlyWood;
            edit_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_button.ForeColor = Color.Transparent;
            edit_button.Location = new Point(819, 1044);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(322, 78);
            edit_button.TabIndex = 37;
            edit_button.Text = "Sửa thông tin";
            edit_button.UseVisualStyleBackColor = false;
            edit_button.Click += edit_button_Click;
            // 
            // search_employee_label
            // 
            search_employee_label.AutoSize = true;
            search_employee_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_employee_label.Location = new Point(25, 152);
            search_employee_label.Margin = new Padding(0);
            search_employee_label.Name = "search_employee_label";
            search_employee_label.Size = new Size(190, 37);
            search_employee_label.TabIndex = 35;
            search_employee_label.Text = "Mã nhân viên:";
            // 
            // employee_dataGridView
            // 
            employee_dataGridView.AllowUserToAddRows = false;
            employee_dataGridView.AllowUserToDeleteRows = false;
            employee_dataGridView.AllowUserToResizeRows = false;
            employee_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employee_dataGridView.BackgroundColor = Color.FloralWhite;
            employee_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            employee_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employee_dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, HoTen, Phai, NgSinh, Luong, PhuCap, Dt, VaiTro, MaDonVi });
            employee_dataGridView.GridColor = Color.BurlyWood;
            employee_dataGridView.Location = new Point(25, 231);
            employee_dataGridView.Margin = new Padding(0);
            employee_dataGridView.MultiSelect = false;
            employee_dataGridView.Name = "employee_dataGridView";
            employee_dataGridView.ReadOnly = true;
            employee_dataGridView.RowHeadersVisible = false;
            employee_dataGridView.RowHeadersWidth = 82;
            employee_dataGridView.Size = new Size(1571, 772);
            employee_dataGridView.TabIndex = 34;
            employee_dataGridView.CellClick += employee_dataGridView_CellClick;
            // 
            // MaNhanVien
            // 
            MaNhanVien.HeaderText = "Mã NV";
            MaNhanVien.MinimumWidth = 10;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.FillWeight = 140F;
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
            NgSinh.FillWeight = 90F;
            NgSinh.HeaderText = "Ngày sinh";
            NgSinh.MinimumWidth = 10;
            NgSinh.Name = "NgSinh";
            NgSinh.ReadOnly = true;
            // 
            // Luong
            // 
            Luong.FillWeight = 90F;
            Luong.HeaderText = "Lương";
            Luong.MinimumWidth = 10;
            Luong.Name = "Luong";
            Luong.ReadOnly = true;
            // 
            // PhuCap
            // 
            PhuCap.FillWeight = 90F;
            PhuCap.HeaderText = "Phụ cấp";
            PhuCap.MinimumWidth = 10;
            PhuCap.Name = "PhuCap";
            PhuCap.ReadOnly = true;
            // 
            // Dt
            // 
            Dt.FillWeight = 90F;
            Dt.HeaderText = "Sđt";
            Dt.MinimumWidth = 10;
            Dt.Name = "Dt";
            Dt.ReadOnly = true;
            // 
            // VaiTro
            // 
            VaiTro.FillWeight = 90F;
            VaiTro.HeaderText = "Vai trò";
            VaiTro.MinimumWidth = 2;
            VaiTro.Name = "VaiTro";
            VaiTro.ReadOnly = true;
            // 
            // MaDonVi
            // 
            MaDonVi.HeaderText = "Mã đơn vị";
            MaDonVi.MinimumWidth = 2;
            MaDonVi.Name = "MaDonVi";
            MaDonVi.ReadOnly = true;
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(1274, 132);
            add_button.Name = "add_button";
            add_button.Size = new Size(322, 78);
            add_button.TabIndex = 40;
            add_button.Text = "Thêm nhân viên";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // search_employee_button
            // 
            search_employee_button.BackColor = Color.BurlyWood;
            search_employee_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_employee_button.ForeColor = Color.Transparent;
            search_employee_button.Location = new Point(592, 140);
            search_employee_button.Name = "search_employee_button";
            search_employee_button.Size = new Size(149, 63);
            search_employee_button.TabIndex = 41;
            search_employee_button.Text = "Tra cứu";
            search_employee_button.UseVisualStyleBackColor = false;
            search_employee_button.Click += search_employee_button_Click;
            // 
            // QLNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(search_employee_button);
            Controls.Add(add_button);
            Controls.Add(search_employee_guna2TextBox);
            Controls.Add(delete_button);
            Controls.Add(edit_button);
            Controls.Add(search_employee_label);
            Controls.Add(employee_dataGridView);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "QLNhanVien";
            Size = new Size(1625, 1169);
            Click += QLNhanVien_Click;
            ((System.ComponentModel.ISupportInitialize)employee_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox search_employee_guna2TextBox;
        private Button delete_button;
        private Button edit_button;
        private Label search_employee_label;
        private DataGridView employee_dataGridView;
        private Button add_button;
        private Button search_employee_button;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Phai;
        private DataGridViewTextBoxColumn NgSinh;
        private DataGridViewTextBoxColumn Luong;
        private DataGridViewTextBoxColumn PhuCap;
        private DataGridViewTextBoxColumn Dt;
        private DataGridViewTextBoxColumn VaiTro;
        private DataGridViewTextBoxColumn MaDonVi;
    }
}
