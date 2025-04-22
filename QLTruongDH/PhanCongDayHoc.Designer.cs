namespace QLTruongDH
{
    partial class PhanCongDayHoc
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            title_label = new Label();
            add_button = new Button();
            search_hocphan_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            delete_button = new Button();
            edit_button = new Button();
            hocphan_label = new Label();
            phanCong_dataGridView = new DataGridView();
            MaMoMon = new DataGridViewTextBoxColumn();
            MaHocPhan = new DataGridViewTextBoxColumn();
            MaGiaoVien = new DataGridViewTextBoxColumn();
            HocKi = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            search_giaovien_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            giaovien_label = new Label();
            hocky_label = new Label();
            hocky_comboBox = new ComboBox();
            nam_label = new Label();
            search_nam_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)phanCong_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_label.Location = new Point(25, 25);
            title_label.Margin = new Padding(0);
            title_label.Name = "title_label";
            title_label.Size = new Size(450, 59);
            title_label.TabIndex = 11;
            title_label.Text = "Phân công giảng học";
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(1327, 20);
            add_button.Name = "add_button";
            add_button.Size = new Size(269, 65);
            add_button.TabIndex = 50;
            add_button.Text = "Thêm phân công";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // search_hocphan_guna2TextBox
            // 
            search_hocphan_guna2TextBox.BorderRadius = 20;
            search_hocphan_guna2TextBox.CustomizableEdges = customizableEdges1;
            search_hocphan_guna2TextBox.DefaultText = "";
            search_hocphan_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_hocphan_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_hocphan_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_hocphan_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_hocphan_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_hocphan_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_hocphan_guna2TextBox.HoverState.BorderColor = Color.Gray;
            search_hocphan_guna2TextBox.IconLeftOffset = new Point(10, 0);
            search_hocphan_guna2TextBox.IconRight = Properties.Resources.close__1_;
            search_hocphan_guna2TextBox.IconRightOffset = new Point(10, 0);
            search_hocphan_guna2TextBox.Location = new Point(220, 136);
            search_hocphan_guna2TextBox.Margin = new Padding(7);
            search_hocphan_guna2TextBox.Name = "search_hocphan_guna2TextBox";
            search_hocphan_guna2TextBox.PlaceholderText = "";
            search_hocphan_guna2TextBox.SelectedText = "";
            search_hocphan_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_hocphan_guna2TextBox.Size = new Size(226, 51);
            search_hocphan_guna2TextBox.TabIndex = 49;
            search_hocphan_guna2TextBox.IconRightClick += search_hocphan_guna2TextBox_IconRightClick;
            search_hocphan_guna2TextBox.KeyDown += search_hocphan_guna2TextBox_KeyDown;
            // 
            // delete_button
            // 
            delete_button.BackColor = SystemColors.ActiveBorder;
            delete_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_button.ForeColor = Color.Transparent;
            delete_button.Location = new Point(477, 1055);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(322, 78);
            delete_button.TabIndex = 48;
            delete_button.Text = "Xóa phân công";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // edit_button
            // 
            edit_button.BackColor = Color.BurlyWood;
            edit_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_button.ForeColor = Color.Transparent;
            edit_button.Location = new Point(819, 1055);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(322, 78);
            edit_button.TabIndex = 47;
            edit_button.Text = "Sửa phân công";
            edit_button.UseVisualStyleBackColor = false;
            edit_button.Click += edit_button_Click;
            // 
            // hocphan_label
            // 
            hocphan_label.AutoSize = true;
            hocphan_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hocphan_label.Location = new Point(25, 143);
            hocphan_label.Margin = new Padding(0);
            hocphan_label.Name = "hocphan_label";
            hocphan_label.Size = new Size(184, 37);
            hocphan_label.TabIndex = 45;
            hocphan_label.Text = "Mã học phần:";
            // 
            // phanCong_dataGridView
            // 
            phanCong_dataGridView.AllowUserToAddRows = false;
            phanCong_dataGridView.AllowUserToDeleteRows = false;
            phanCong_dataGridView.AllowUserToResizeRows = false;
            phanCong_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            phanCong_dataGridView.BackgroundColor = Color.FloralWhite;
            phanCong_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            phanCong_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phanCong_dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaMoMon, MaHocPhan, MaGiaoVien, HocKi, Nam });
            phanCong_dataGridView.Location = new Point(25, 218);
            phanCong_dataGridView.Margin = new Padding(0);
            phanCong_dataGridView.MultiSelect = false;
            phanCong_dataGridView.Name = "phanCong_dataGridView";
            phanCong_dataGridView.ReadOnly = true;
            phanCong_dataGridView.RowHeadersVisible = false;
            phanCong_dataGridView.RowHeadersWidth = 82;
            phanCong_dataGridView.Size = new Size(1571, 803);
            phanCong_dataGridView.TabIndex = 44;
            phanCong_dataGridView.CellClick += phanCong_dataGridView_CellClick;
            // 
            // MaMoMon
            // 
            MaMoMon.FillWeight = 120F;
            MaMoMon.HeaderText = "Mã mở môn";
            MaMoMon.MinimumWidth = 10;
            MaMoMon.Name = "MaMoMon";
            MaMoMon.ReadOnly = true;
            // 
            // MaHocPhan
            // 
            MaHocPhan.HeaderText = "Mã học phần";
            MaHocPhan.MinimumWidth = 10;
            MaHocPhan.Name = "MaHocPhan";
            MaHocPhan.ReadOnly = true;
            // 
            // MaGiaoVien
            // 
            MaGiaoVien.HeaderText = "Mã giáo viên";
            MaGiaoVien.MinimumWidth = 10;
            MaGiaoVien.Name = "MaGiaoVien";
            MaGiaoVien.ReadOnly = true;
            // 
            // HocKi
            // 
            HocKi.FillWeight = 50F;
            HocKi.HeaderText = "Học kì";
            HocKi.MinimumWidth = 10;
            HocKi.Name = "HocKi";
            HocKi.ReadOnly = true;
            // 
            // Nam
            // 
            Nam.HeaderText = "Năm";
            Nam.MinimumWidth = 10;
            Nam.Name = "Nam";
            Nam.ReadOnly = true;
            // 
            // guna2Separator2
            // 
            guna2Separator2.FillThickness = 2;
            guna2Separator2.Location = new Point(0, 100);
            guna2Separator2.Margin = new Padding(0);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(1620, 21);
            guna2Separator2.TabIndex = 43;
            // 
            // search_giaovien_guna2TextBox
            // 
            search_giaovien_guna2TextBox.BorderRadius = 20;
            search_giaovien_guna2TextBox.CustomizableEdges = customizableEdges3;
            search_giaovien_guna2TextBox.DefaultText = "";
            search_giaovien_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_giaovien_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_giaovien_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_giaovien_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_giaovien_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_giaovien_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_giaovien_guna2TextBox.HoverState.BorderColor = Color.Gray;
            search_giaovien_guna2TextBox.IconLeftOffset = new Point(10, 0);
            search_giaovien_guna2TextBox.IconRight = Properties.Resources.close__1_;
            search_giaovien_guna2TextBox.IconRightOffset = new Point(10, 0);
            search_giaovien_guna2TextBox.Location = new Point(698, 136);
            search_giaovien_guna2TextBox.Margin = new Padding(7);
            search_giaovien_guna2TextBox.Name = "search_giaovien_guna2TextBox";
            search_giaovien_guna2TextBox.PlaceholderText = "";
            search_giaovien_guna2TextBox.SelectedText = "";
            search_giaovien_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            search_giaovien_guna2TextBox.Size = new Size(226, 51);
            search_giaovien_guna2TextBox.TabIndex = 52;
            search_giaovien_guna2TextBox.IconRightClick += search_giaovien_guna2TextBox_IconRightClick;
            search_giaovien_guna2TextBox.KeyDown += search_giaovien_guna2TextBox_KeyDown;
            // 
            // giaovien_label
            // 
            giaovien_label.AutoSize = true;
            giaovien_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            giaovien_label.Location = new Point(505, 143);
            giaovien_label.Margin = new Padding(0);
            giaovien_label.Name = "giaovien_label";
            giaovien_label.Size = new Size(181, 37);
            giaovien_label.TabIndex = 51;
            giaovien_label.Text = "Mã giáo viên:";
            // 
            // hocky_label
            // 
            hocky_label.AutoSize = true;
            hocky_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hocky_label.Location = new Point(980, 143);
            hocky_label.Margin = new Padding(0);
            hocky_label.Name = "hocky_label";
            hocky_label.Size = new Size(108, 37);
            hocky_label.TabIndex = 53;
            hocky_label.Text = "Học kỳ:";
            // 
            // hocky_comboBox
            // 
            hocky_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hocky_comboBox.FormattingEnabled = true;
            hocky_comboBox.Items.AddRange(new object[] { "1", "2", "3" });
            hocky_comboBox.Location = new Point(1100, 140);
            hocky_comboBox.Name = "hocky_comboBox";
            hocky_comboBox.Size = new Size(92, 45);
            hocky_comboBox.TabIndex = 54;
            hocky_comboBox.SelectedValueChanged += hocky_comboBox_SelectedValueChanged;
            // 
            // nam_label
            // 
            nam_label.AutoSize = true;
            nam_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nam_label.Location = new Point(1297, 143);
            nam_label.Margin = new Padding(0);
            nam_label.Name = "nam_label";
            nam_label.Size = new Size(83, 37);
            nam_label.TabIndex = 55;
            nam_label.Text = "Năm:";
            // 
            // search_nam_guna2TextBox
            // 
            search_nam_guna2TextBox.BorderRadius = 20;
            search_nam_guna2TextBox.CustomizableEdges = customizableEdges5;
            search_nam_guna2TextBox.DefaultText = "";
            search_nam_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_nam_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_nam_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_nam_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_nam_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_nam_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_nam_guna2TextBox.HoverState.BorderColor = Color.Gray;
            search_nam_guna2TextBox.IconLeftOffset = new Point(10, 0);
            search_nam_guna2TextBox.IconRight = Properties.Resources.close__1_;
            search_nam_guna2TextBox.IconRightOffset = new Point(10, 0);
            search_nam_guna2TextBox.Location = new Point(1387, 136);
            search_nam_guna2TextBox.Margin = new Padding(7);
            search_nam_guna2TextBox.Name = "search_nam_guna2TextBox";
            search_nam_guna2TextBox.PlaceholderText = "";
            search_nam_guna2TextBox.SelectedText = "";
            search_nam_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            search_nam_guna2TextBox.Size = new Size(209, 51);
            search_nam_guna2TextBox.TabIndex = 57;
            search_nam_guna2TextBox.IconRightClick += search_nam_guna2TextBox_IconRightClick;
            search_nam_guna2TextBox.KeyDown += search_nam_guna2TextBox_KeyDown;
            // 
            // PhanCongDayHoc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(search_nam_guna2TextBox);
            Controls.Add(nam_label);
            Controls.Add(hocky_comboBox);
            Controls.Add(hocky_label);
            Controls.Add(search_giaovien_guna2TextBox);
            Controls.Add(giaovien_label);
            Controls.Add(add_button);
            Controls.Add(search_hocphan_guna2TextBox);
            Controls.Add(delete_button);
            Controls.Add(edit_button);
            Controls.Add(hocphan_label);
            Controls.Add(phanCong_dataGridView);
            Controls.Add(guna2Separator2);
            Controls.Add(title_label);
            Margin = new Padding(0);
            Name = "PhanCongDayHoc";
            Size = new Size(1620, 1169);
            Load += PhanCongDayHoc_Load;
            Click += PhanCongDayHoc_Click;
            ((System.ComponentModel.ISupportInitialize)phanCong_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label title_label;
        private Button add_button;
        private Guna.UI2.WinForms.Guna2TextBox search_hocphan_guna2TextBox;
        private Button delete_button;
        private Button edit_button;
        private Label hocphan_label;
        private DataGridView phanCong_dataGridView;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox search_giaovien_guna2TextBox;
        private Label giaovien_label;
        private Label hocky_label;
        private ComboBox hocky_comboBox;
        private Label nam_label;
        private DataGridViewTextBoxColumn MaMoMon;
        private DataGridViewTextBoxColumn MaHocPhan;
        private DataGridViewTextBoxColumn MaGiaoVien;
        private DataGridViewTextBoxColumn HocKi;
        private DataGridViewTextBoxColumn Nam;
        private Guna.UI2.WinForms.Guna2TextBox search_nam_guna2TextBox;
    }
}
