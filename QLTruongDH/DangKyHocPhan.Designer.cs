namespace QLTruongDH
{
    partial class DangKyHocPhan
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            nam_comboBox = new ComboBox();
            nam_label = new Label();
            hocKy_comboBox = new ComboBox();
            hocKy_label = new Label();
            hocPhan_dataGridView = new DataGridView();
            MSSV = new DataGridViewTextBoxColumn();
            TenSinhVien = new DataGridViewTextBoxColumn();
            MaHocPhan = new DataGridViewTextBoxColumn();
            TenHocPhan = new DataGridViewTextBoxColumn();
            HocKy = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            DiemTH = new DataGridViewTextBoxColumn();
            DiemQT = new DataGridViewTextBoxColumn();
            DiemCK = new DataGridViewTextBoxColumn();
            DiemTK = new DataGridViewTextBoxColumn();
            assign_button = new Button();
            mssv_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            mssv_label = new Label();
            hocPhan_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            hocPhan_label = new Label();
            cancel_button = new Button();
            ((System.ComponentModel.ISupportInitialize)hocPhan_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(391, 59);
            label1.TabIndex = 11;
            label1.Text = "Đăng ký học phần";
            // 
            // nam_comboBox
            // 
            nam_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nam_comboBox.FormattingEnabled = true;
            nam_comboBox.Location = new Point(1094, 151);
            nam_comboBox.Name = "nam_comboBox";
            nam_comboBox.Size = new Size(112, 45);
            nam_comboBox.TabIndex = 108;
            // 
            // nam_label
            // 
            nam_label.AutoSize = true;
            nam_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nam_label.Location = new Point(956, 154);
            nam_label.Margin = new Padding(0);
            nam_label.Name = "nam_label";
            nam_label.Size = new Size(135, 37);
            nam_label.TabIndex = 107;
            nam_label.Text = "Năm học:";
            // 
            // hocKy_comboBox
            // 
            hocKy_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hocKy_comboBox.FormattingEnabled = true;
            hocKy_comboBox.Location = new Point(854, 151);
            hocKy_comboBox.Name = "hocKy_comboBox";
            hocKy_comboBox.Size = new Size(69, 45);
            hocKy_comboBox.TabIndex = 106;
            // 
            // hocKy_label
            // 
            hocKy_label.AutoSize = true;
            hocKy_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hocKy_label.Location = new Point(750, 154);
            hocKy_label.Margin = new Padding(0);
            hocKy_label.Name = "hocKy_label";
            hocKy_label.Size = new Size(101, 37);
            hocKy_label.TabIndex = 105;
            hocKy_label.Text = "Học kỳ";
            // 
            // hocPhan_dataGridView
            // 
            hocPhan_dataGridView.AllowUserToAddRows = false;
            hocPhan_dataGridView.AllowUserToDeleteRows = false;
            hocPhan_dataGridView.AllowUserToResizeRows = false;
            hocPhan_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hocPhan_dataGridView.BackgroundColor = Color.FloralWhite;
            hocPhan_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            hocPhan_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hocPhan_dataGridView.Columns.AddRange(new DataGridViewColumn[] { MSSV, TenSinhVien, MaHocPhan, TenHocPhan, HocKy, NamHoc, DiemTH, DiemQT, DiemCK, DiemTK });
            hocPhan_dataGridView.Location = new Point(25, 226);
            hocPhan_dataGridView.Margin = new Padding(0);
            hocPhan_dataGridView.MultiSelect = false;
            hocPhan_dataGridView.Name = "hocPhan_dataGridView";
            hocPhan_dataGridView.ReadOnly = true;
            hocPhan_dataGridView.RowHeadersVisible = false;
            hocPhan_dataGridView.RowHeadersWidth = 82;
            hocPhan_dataGridView.Size = new Size(1567, 915);
            hocPhan_dataGridView.TabIndex = 104;
            // 
            // MSSV
            // 
            MSSV.HeaderText = "MSSV";
            MSSV.MinimumWidth = 10;
            MSSV.Name = "MSSV";
            MSSV.ReadOnly = true;
            // 
            // TenSinhVien
            // 
            TenSinhVien.FillWeight = 120F;
            TenSinhVien.HeaderText = "Tên sinh viên";
            TenSinhVien.MinimumWidth = 10;
            TenSinhVien.Name = "TenSinhVien";
            TenSinhVien.ReadOnly = true;
            // 
            // MaHocPhan
            // 
            MaHocPhan.FillWeight = 120F;
            MaHocPhan.HeaderText = "Mã học phần";
            MaHocPhan.MinimumWidth = 10;
            MaHocPhan.Name = "MaHocPhan";
            MaHocPhan.ReadOnly = true;
            // 
            // TenHocPhan
            // 
            TenHocPhan.FillWeight = 140F;
            TenHocPhan.HeaderText = "Tên học phần";
            TenHocPhan.MinimumWidth = 10;
            TenHocPhan.Name = "TenHocPhan";
            TenHocPhan.ReadOnly = true;
            // 
            // HocKy
            // 
            HocKy.FillWeight = 80F;
            HocKy.HeaderText = "Học kỳ";
            HocKy.MinimumWidth = 10;
            HocKy.Name = "HocKy";
            HocKy.ReadOnly = true;
            // 
            // NamHoc
            // 
            NamHoc.FillWeight = 80F;
            NamHoc.HeaderText = "Năm học";
            NamHoc.MinimumWidth = 10;
            NamHoc.Name = "NamHoc";
            NamHoc.ReadOnly = true;
            // 
            // DiemTH
            // 
            DiemTH.FillWeight = 70F;
            DiemTH.HeaderText = "Điểm TH";
            DiemTH.MinimumWidth = 10;
            DiemTH.Name = "DiemTH";
            DiemTH.ReadOnly = true;
            // 
            // DiemQT
            // 
            DiemQT.FillWeight = 70F;
            DiemQT.HeaderText = "Điểm QT";
            DiemQT.MinimumWidth = 10;
            DiemQT.Name = "DiemQT";
            DiemQT.ReadOnly = true;
            // 
            // DiemCK
            // 
            DiemCK.FillWeight = 70F;
            DiemCK.HeaderText = "Điểm CK";
            DiemCK.MinimumWidth = 10;
            DiemCK.Name = "DiemCK";
            DiemCK.ReadOnly = true;
            // 
            // DiemTK
            // 
            DiemTK.FillWeight = 70F;
            DiemTK.HeaderText = "Điểm TK";
            DiemTK.MinimumWidth = 10;
            DiemTK.Name = "DiemTK";
            DiemTK.ReadOnly = true;
            // 
            // assign_button
            // 
            assign_button.BackColor = Color.BurlyWood;
            assign_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assign_button.ForeColor = Color.Transparent;
            assign_button.Location = new Point(1251, 142);
            assign_button.Name = "assign_button";
            assign_button.Size = new Size(172, 64);
            assign_button.TabIndex = 103;
            assign_button.Text = "Đăng ký";
            assign_button.UseVisualStyleBackColor = false;
            // 
            // mssv_guna2TextBox
            // 
            mssv_guna2TextBox.BorderRadius = 20;
            mssv_guna2TextBox.CustomizableEdges = customizableEdges5;
            mssv_guna2TextBox.DefaultText = "";
            mssv_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            mssv_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            mssv_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            mssv_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            mssv_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            mssv_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mssv_guna2TextBox.ForeColor = Color.Black;
            mssv_guna2TextBox.HoverState.BorderColor = Color.Gray;
            mssv_guna2TextBox.IconLeftOffset = new Point(10, 0);
            mssv_guna2TextBox.IconRight = Properties.Resources.close__1_;
            mssv_guna2TextBox.IconRightOffset = new Point(10, 0);
            mssv_guna2TextBox.Location = new Point(128, 148);
            mssv_guna2TextBox.Margin = new Padding(7);
            mssv_guna2TextBox.Name = "mssv_guna2TextBox";
            mssv_guna2TextBox.PlaceholderText = "";
            mssv_guna2TextBox.SelectedText = "";
            mssv_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            mssv_guna2TextBox.Size = new Size(190, 51);
            mssv_guna2TextBox.TabIndex = 102;
            // 
            // mssv_label
            // 
            mssv_label.AutoSize = true;
            mssv_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mssv_label.Location = new Point(25, 154);
            mssv_label.Margin = new Padding(0);
            mssv_label.Name = "mssv_label";
            mssv_label.Size = new Size(96, 37);
            mssv_label.TabIndex = 101;
            mssv_label.Text = "MSSV:";
            // 
            // hocPhan_guna2TextBox
            // 
            hocPhan_guna2TextBox.BorderRadius = 20;
            hocPhan_guna2TextBox.CustomizableEdges = customizableEdges7;
            hocPhan_guna2TextBox.DefaultText = "";
            hocPhan_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            hocPhan_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            hocPhan_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            hocPhan_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            hocPhan_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            hocPhan_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hocPhan_guna2TextBox.ForeColor = Color.Black;
            hocPhan_guna2TextBox.HoverState.BorderColor = Color.Gray;
            hocPhan_guna2TextBox.IconLeftOffset = new Point(10, 0);
            hocPhan_guna2TextBox.IconRight = Properties.Resources.close__1_;
            hocPhan_guna2TextBox.IconRightOffset = new Point(10, 0);
            hocPhan_guna2TextBox.Location = new Point(532, 148);
            hocPhan_guna2TextBox.Margin = new Padding(7);
            hocPhan_guna2TextBox.Name = "hocPhan_guna2TextBox";
            hocPhan_guna2TextBox.PlaceholderText = "";
            hocPhan_guna2TextBox.SelectedText = "";
            hocPhan_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            hocPhan_guna2TextBox.Size = new Size(190, 51);
            hocPhan_guna2TextBox.TabIndex = 110;
            // 
            // hocPhan_label
            // 
            hocPhan_label.AutoSize = true;
            hocPhan_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hocPhan_label.Location = new Point(348, 154);
            hocPhan_label.Margin = new Padding(0);
            hocPhan_label.Name = "hocPhan_label";
            hocPhan_label.Size = new Size(184, 37);
            hocPhan_label.TabIndex = 109;
            hocPhan_label.Text = "Mã học phần:";
            // 
            // cancel_button
            // 
            cancel_button.BackColor = SystemColors.ActiveBorder;
            cancel_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_button.ForeColor = Color.Transparent;
            cancel_button.Location = new Point(1429, 142);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(163, 64);
            cancel_button.TabIndex = 111;
            cancel_button.Text = "Hủy";
            cancel_button.UseVisualStyleBackColor = false;
            // 
            // DangKyHocPhan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cancel_button);
            Controls.Add(hocPhan_guna2TextBox);
            Controls.Add(hocPhan_label);
            Controls.Add(nam_comboBox);
            Controls.Add(nam_label);
            Controls.Add(hocKy_comboBox);
            Controls.Add(hocKy_label);
            Controls.Add(hocPhan_dataGridView);
            Controls.Add(assign_button);
            Controls.Add(mssv_guna2TextBox);
            Controls.Add(mssv_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "DangKyHocPhan";
            Size = new Size(1620, 1169);
            ((System.ComponentModel.ISupportInitialize)hocPhan_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private ComboBox nam_comboBox;
        private Label nam_label;
        private ComboBox hocKy_comboBox;
        private Label hocKy_label;
        private DataGridView hocPhan_dataGridView;
        private Button assign_button;
        private Guna.UI2.WinForms.Guna2TextBox mssv_guna2TextBox;
        private Label mssv_label;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn TenSinhVien;
        private DataGridViewTextBoxColumn MaHocPhan;
        private DataGridViewTextBoxColumn TenHocPhan;
        private DataGridViewTextBoxColumn HocKy;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewTextBoxColumn DiemTH;
        private DataGridViewTextBoxColumn DiemQT;
        private DataGridViewTextBoxColumn DiemCK;
        private DataGridViewTextBoxColumn DiemTK;
        private Guna.UI2.WinForms.Guna2TextBox hocPhan_guna2TextBox;
        private Label hocPhan_label;
        private Button cancel_button;
    }
}
