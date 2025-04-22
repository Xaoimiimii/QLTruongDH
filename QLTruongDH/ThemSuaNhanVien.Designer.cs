namespace QLTruongDH
{
    partial class ThemSuaNhanVien
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
            reset__button = new Button();
            add_button = new Button();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            title_label = new Label();
            fullname_textBox = new TextBox();
            fullnane_label = new Label();
            dob_textBox = new TextBox();
            dob_label = new Label();
            gender_label = new Label();
            gender_comboBox = new ComboBox();
            phone_textBox = new TextBox();
            phone_label = new Label();
            donvi_label = new Label();
            role_comboBox = new ComboBox();
            role_label = new Label();
            luong_textBox = new TextBox();
            luong_label = new Label();
            phucap_textBox = new TextBox();
            phucap_label = new Label();
            back_flowLayoutPanel = new FlowLayoutPanel();
            back_pictureBox = new PictureBox();
            back_label = new Label();
            donvi_comboBox = new ComboBox();
            employee_id_label = new Label();
            back_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)back_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // reset__button
            // 
            reset__button.BackColor = SystemColors.ActiveBorder;
            reset__button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset__button.ForeColor = Color.Transparent;
            reset__button.Location = new Point(477, 773);
            reset__button.Name = "reset__button";
            reset__button.Size = new Size(322, 78);
            reset__button.TabIndex = 43;
            reset__button.Text = "Nhập lại";
            reset__button.UseVisualStyleBackColor = false;
            reset__button.Click += reset__button_Click;
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(819, 773);
            add_button.Name = "add_button";
            add_button.Size = new Size(322, 78);
            add_button.TabIndex = 42;
            add_button.Text = "Thêm nhân viên";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 40;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_label.Location = new Point(25, 25);
            title_label.Margin = new Padding(0);
            title_label.Name = "title_label";
            title_label.Size = new Size(437, 59);
            title_label.TabIndex = 39;
            title_label.Text = "Thêm nhân viên mới";
            // 
            // fullname_textBox
            // 
            fullname_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullname_textBox.Location = new Point(160, 157);
            fullname_textBox.Name = "fullname_textBox";
            fullname_textBox.Size = new Size(627, 50);
            fullname_textBox.TabIndex = 46;
            // 
            // fullnane_label
            // 
            fullnane_label.AutoSize = true;
            fullnane_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullnane_label.Location = new Point(25, 157);
            fullnane_label.Margin = new Padding(0);
            fullnane_label.Name = "fullnane_label";
            fullnane_label.Size = new Size(128, 45);
            fullnane_label.TabIndex = 45;
            fullnane_label.Text = "Họ tên:";
            // 
            // dob_textBox
            // 
            dob_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dob_textBox.Location = new Point(883, 270);
            dob_textBox.Name = "dob_textBox";
            dob_textBox.Size = new Size(323, 50);
            dob_textBox.TabIndex = 48;
            // 
            // dob_label
            // 
            dob_label.AutoSize = true;
            dob_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dob_label.Location = new Point(706, 273);
            dob_label.Margin = new Padding(0);
            dob_label.Name = "dob_label";
            dob_label.Size = new Size(174, 45);
            dob_label.TabIndex = 47;
            dob_label.Text = "Ngày sinh:";
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender_label.Location = new Point(883, 157);
            gender_label.Margin = new Padding(0);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(91, 45);
            gender_label.TabIndex = 49;
            gender_label.Text = "Phái:";
            // 
            // gender_comboBox
            // 
            gender_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender_comboBox.FormattingEnabled = true;
            gender_comboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            gender_comboBox.Location = new Point(977, 154);
            gender_comboBox.Name = "gender_comboBox";
            gender_comboBox.Size = new Size(229, 53);
            gender_comboBox.TabIndex = 50;
            // 
            // phone_textBox
            // 
            phone_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone_textBox.Location = new Point(248, 270);
            phone_textBox.Name = "phone_textBox";
            phone_textBox.Size = new Size(310, 50);
            phone_textBox.TabIndex = 52;
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone_label.Location = new Point(25, 273);
            phone_label.Margin = new Padding(0);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(220, 45);
            phone_label.TabIndex = 51;
            phone_label.Text = "Số điện thoại:";
            // 
            // donvi_label
            // 
            donvi_label.AutoSize = true;
            donvi_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donvi_label.Location = new Point(25, 389);
            donvi_label.Margin = new Padding(0);
            donvi_label.Name = "donvi_label";
            donvi_label.Size = new Size(175, 45);
            donvi_label.TabIndex = 53;
            donvi_label.Text = "Mã đơn vị:";
            // 
            // role_comboBox
            // 
            role_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            role_comboBox.FormattingEnabled = true;
            role_comboBox.Items.AddRange(new object[] { "NVCB", "GV", "NV PDT", "NV PKT", "NV TCHC", "NV CTSV", "TRGDV" });
            role_comboBox.Location = new Point(841, 384);
            role_comboBox.Name = "role_comboBox";
            role_comboBox.Size = new Size(365, 53);
            role_comboBox.TabIndex = 56;
            // 
            // role_label
            // 
            role_label.AutoSize = true;
            role_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            role_label.Location = new Point(706, 389);
            role_label.Margin = new Padding(0);
            role_label.Name = "role_label";
            role_label.Size = new Size(124, 45);
            role_label.TabIndex = 55;
            role_label.Text = "Vai trò:";
            // 
            // luong_textBox
            // 
            luong_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            luong_textBox.Location = new Point(150, 502);
            luong_textBox.Name = "luong_textBox";
            luong_textBox.Size = new Size(408, 50);
            luong_textBox.TabIndex = 58;
            // 
            // luong_label
            // 
            luong_label.AutoSize = true;
            luong_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            luong_label.Location = new Point(25, 505);
            luong_label.Margin = new Padding(0);
            luong_label.Name = "luong_label";
            luong_label.Size = new Size(122, 45);
            luong_label.TabIndex = 57;
            luong_label.Text = "Lương:";
            // 
            // phucap_textBox
            // 
            phucap_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phucap_textBox.Location = new Point(854, 502);
            phucap_textBox.Name = "phucap_textBox";
            phucap_textBox.Size = new Size(352, 50);
            phucap_textBox.TabIndex = 60;
            // 
            // phucap_label
            // 
            phucap_label.AutoSize = true;
            phucap_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phucap_label.Location = new Point(706, 505);
            phucap_label.Margin = new Padding(0);
            phucap_label.Name = "phucap_label";
            phucap_label.Size = new Size(145, 45);
            phucap_label.TabIndex = 59;
            phucap_label.Text = "Phụ cấp:";
            // 
            // back_flowLayoutPanel
            // 
            back_flowLayoutPanel.Controls.Add(back_pictureBox);
            back_flowLayoutPanel.Controls.Add(back_label);
            back_flowLayoutPanel.Location = new Point(25, 1110);
            back_flowLayoutPanel.Margin = new Padding(0);
            back_flowLayoutPanel.Name = "back_flowLayoutPanel";
            back_flowLayoutPanel.Size = new Size(180, 38);
            back_flowLayoutPanel.TabIndex = 61;
            back_flowLayoutPanel.Click += back_flowLayoutPanel_Click;
            back_flowLayoutPanel.MouseEnter += back_flowLayoutPanel_MouseEnter;
            back_flowLayoutPanel.MouseLeave += back_flowLayoutPanel_MouseLeave;
            // 
            // back_pictureBox
            // 
            back_pictureBox.Dock = DockStyle.Fill;
            back_pictureBox.Image = Properties.Resources.back__1_;
            back_pictureBox.Location = new Point(3, 3);
            back_pictureBox.Name = "back_pictureBox";
            back_pictureBox.Size = new Size(32, 32);
            back_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            back_pictureBox.TabIndex = 0;
            back_pictureBox.TabStop = false;
            back_pictureBox.Click += back_pictureBox_Click;
            back_pictureBox.MouseEnter += back_pictureBox_MouseEnter;
            back_pictureBox.MouseLeave += back_pictureBox_MouseLeave;
            // 
            // back_label
            // 
            back_label.AutoSize = true;
            back_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_label.Location = new Point(41, 0);
            back_label.Name = "back_label";
            back_label.Size = new Size(116, 37);
            back_label.TabIndex = 1;
            back_label.Text = "Quay về";
            back_label.Click += back_label_Click;
            back_label.MouseEnter += back_label_MouseEnter;
            back_label.MouseLeave += back_label_MouseLeave;
            // 
            // donvi_comboBox
            // 
            donvi_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            donvi_comboBox.FormattingEnabled = true;
            donvi_comboBox.Location = new Point(203, 381);
            donvi_comboBox.Name = "donvi_comboBox";
            donvi_comboBox.Size = new Size(355, 53);
            donvi_comboBox.TabIndex = 62;
            // 
            // employee_id_label
            // 
            employee_id_label.AutoSize = true;
            employee_id_label.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee_id_label.ForeColor = Color.BurlyWood;
            employee_id_label.Location = new Point(660, 32);
            employee_id_label.Name = "employee_id_label";
            employee_id_label.Size = new Size(125, 50);
            employee_id_label.TabIndex = 63;
            employee_id_label.Text = "MaNV";
            // 
            // ThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(employee_id_label);
            Controls.Add(donvi_comboBox);
            Controls.Add(back_flowLayoutPanel);
            Controls.Add(phucap_textBox);
            Controls.Add(phucap_label);
            Controls.Add(luong_textBox);
            Controls.Add(luong_label);
            Controls.Add(role_comboBox);
            Controls.Add(role_label);
            Controls.Add(donvi_label);
            Controls.Add(phone_textBox);
            Controls.Add(phone_label);
            Controls.Add(gender_comboBox);
            Controls.Add(gender_label);
            Controls.Add(dob_textBox);
            Controls.Add(dob_label);
            Controls.Add(fullname_textBox);
            Controls.Add(fullnane_label);
            Controls.Add(reset__button);
            Controls.Add(add_button);
            Controls.Add(guna2Separator1);
            Controls.Add(title_label);
            Margin = new Padding(0);
            Name = "ThemNhanVien";
            Size = new Size(1625, 1169);
            back_flowLayoutPanel.ResumeLayout(false);
            back_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)back_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reset__button;
        private Button add_button;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label title_label;
        private TextBox fullname_textBox;
        private Label fullnane_label;
        private TextBox dob_textBox;
        private Label dob_label;
        private Label gender_label;
        private ComboBox gender_comboBox;
        private TextBox phone_textBox;
        private Label phone_label;
        private Label donvi_label;
        private ComboBox role_comboBox;
        private Label role_label;
        private TextBox luong_textBox;
        private Label luong_label;
        private TextBox phucap_textBox;
        private Label phucap_label;
        private FlowLayoutPanel back_flowLayoutPanel;
        private PictureBox back_pictureBox;
        private Label back_label;
        private ComboBox donvi_comboBox;
        private Label employee_id_label;
    }
}
