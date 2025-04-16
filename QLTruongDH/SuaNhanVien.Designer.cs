namespace QLTruongDH
{
    partial class SuaNhanVien
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
            phucap_textBox = new TextBox();
            phucap_label = new Label();
            textBox1 = new TextBox();
            luong_label = new Label();
            role_comboBox = new ComboBox();
            role_label = new Label();
            donvi_textBox = new TextBox();
            donvi_label = new Label();
            phone_textBox = new TextBox();
            phone_label = new Label();
            gender_comboBox = new ComboBox();
            gender_label = new Label();
            dob_textBox = new TextBox();
            dob_label = new Label();
            fullname_textBox = new TextBox();
            fullnane_label = new Label();
            employee_id_textBox = new TextBox();
            back__button = new Button();
            alter_button = new Button();
            employee_id_label = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            SuspendLayout();
            // 
            // phucap_textBox
            // 
            phucap_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phucap_textBox.Location = new Point(854, 502);
            phucap_textBox.Name = "phucap_textBox";
            phucap_textBox.Size = new Size(352, 50);
            phucap_textBox.TabIndex = 82;
            // 
            // phucap_label
            // 
            phucap_label.AutoSize = true;
            phucap_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phucap_label.Location = new Point(706, 505);
            phucap_label.Margin = new Padding(0);
            phucap_label.Name = "phucap_label";
            phucap_label.Size = new Size(145, 45);
            phucap_label.TabIndex = 81;
            phucap_label.Text = "Phụ cấp:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(150, 502);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 50);
            textBox1.TabIndex = 80;
            // 
            // luong_label
            // 
            luong_label.AutoSize = true;
            luong_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            luong_label.Location = new Point(25, 505);
            luong_label.Margin = new Padding(0);
            luong_label.Name = "luong_label";
            luong_label.Size = new Size(122, 45);
            luong_label.TabIndex = 79;
            luong_label.Text = "Lương:";
            // 
            // role_comboBox
            // 
            role_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            role_comboBox.FormattingEnabled = true;
            role_comboBox.Items.AddRange(new object[] { "NVCB", "Giáo viên", "NV PĐT", "NV PKT", "NV TCHC", "NV CTSV", "Trưởng đơn vị" });
            role_comboBox.Location = new Point(841, 384);
            role_comboBox.Name = "role_comboBox";
            role_comboBox.Size = new Size(278, 53);
            role_comboBox.TabIndex = 78;
            // 
            // role_label
            // 
            role_label.AutoSize = true;
            role_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            role_label.Location = new Point(706, 389);
            role_label.Margin = new Padding(0);
            role_label.Name = "role_label";
            role_label.Size = new Size(124, 45);
            role_label.TabIndex = 77;
            role_label.Text = "Vai trò:";
            // 
            // donvi_textBox
            // 
            donvi_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            donvi_textBox.Location = new Point(202, 384);
            donvi_textBox.Name = "donvi_textBox";
            donvi_textBox.Size = new Size(356, 50);
            donvi_textBox.TabIndex = 76;
            // 
            // donvi_label
            // 
            donvi_label.AutoSize = true;
            donvi_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donvi_label.Location = new Point(25, 389);
            donvi_label.Margin = new Padding(0);
            donvi_label.Name = "donvi_label";
            donvi_label.Size = new Size(175, 45);
            donvi_label.TabIndex = 75;
            donvi_label.Text = "Mã đơn vị:";
            // 
            // phone_textBox
            // 
            phone_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone_textBox.Location = new Point(248, 270);
            phone_textBox.Name = "phone_textBox";
            phone_textBox.Size = new Size(310, 50);
            phone_textBox.TabIndex = 74;
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone_label.Location = new Point(25, 273);
            phone_label.Margin = new Padding(0);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(220, 45);
            phone_label.TabIndex = 73;
            phone_label.Text = "Số điện thoại:";
            // 
            // gender_comboBox
            // 
            gender_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender_comboBox.FormattingEnabled = true;
            gender_comboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            gender_comboBox.Location = new Point(1404, 270);
            gender_comboBox.Name = "gender_comboBox";
            gender_comboBox.Size = new Size(174, 53);
            gender_comboBox.TabIndex = 72;
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender_label.Location = new Point(1310, 273);
            gender_label.Margin = new Padding(0);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(91, 45);
            gender_label.TabIndex = 71;
            gender_label.Text = "Phái:";
            // 
            // dob_textBox
            // 
            dob_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dob_textBox.Location = new Point(883, 270);
            dob_textBox.Name = "dob_textBox";
            dob_textBox.Size = new Size(267, 50);
            dob_textBox.TabIndex = 70;
            // 
            // dob_label
            // 
            dob_label.AutoSize = true;
            dob_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dob_label.Location = new Point(706, 273);
            dob_label.Margin = new Padding(0);
            dob_label.Name = "dob_label";
            dob_label.Size = new Size(174, 45);
            dob_label.TabIndex = 69;
            dob_label.Text = "Ngày sinh:";
            // 
            // fullname_textBox
            // 
            fullname_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullname_textBox.Location = new Point(841, 157);
            fullname_textBox.Name = "fullname_textBox";
            fullname_textBox.Size = new Size(627, 50);
            fullname_textBox.TabIndex = 68;
            // 
            // fullnane_label
            // 
            fullnane_label.AutoSize = true;
            fullnane_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullnane_label.Location = new Point(706, 157);
            fullnane_label.Margin = new Padding(0);
            fullnane_label.Name = "fullnane_label";
            fullnane_label.Size = new Size(128, 45);
            fullnane_label.TabIndex = 67;
            fullnane_label.Text = "Họ tên:";
            // 
            // employee_id_textBox
            // 
            employee_id_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee_id_textBox.Location = new Point(255, 157);
            employee_id_textBox.Name = "employee_id_textBox";
            employee_id_textBox.Size = new Size(303, 50);
            employee_id_textBox.TabIndex = 66;
            // 
            // back__button
            // 
            back__button.BackColor = SystemColors.ActiveBorder;
            back__button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back__button.ForeColor = Color.Transparent;
            back__button.Location = new Point(477, 773);
            back__button.Name = "back__button";
            back__button.Size = new Size(322, 78);
            back__button.TabIndex = 65;
            back__button.Text = "Trở về";
            back__button.UseVisualStyleBackColor = false;
            // 
            // alter_button
            // 
            alter_button.BackColor = Color.BurlyWood;
            alter_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alter_button.ForeColor = Color.Transparent;
            alter_button.Location = new Point(819, 773);
            alter_button.Name = "alter_button";
            alter_button.Size = new Size(322, 78);
            alter_button.TabIndex = 64;
            alter_button.Text = "Sửa thông tin";
            alter_button.UseVisualStyleBackColor = false;
            // 
            // employee_id_label
            // 
            employee_id_label.AutoSize = true;
            employee_id_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employee_id_label.Location = new Point(25, 157);
            employee_id_label.Margin = new Padding(0);
            employee_id_label.Name = "employee_id_label";
            employee_id_label.Size = new Size(227, 45);
            employee_id_label.TabIndex = 63;
            employee_id_label.Text = "Mã nhân viên:";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(511, 59);
            label1.TabIndex = 61;
            label1.Text = "Sửa thông tin nhân viên";
            // 
            // SuaNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(phucap_textBox);
            Controls.Add(phucap_label);
            Controls.Add(textBox1);
            Controls.Add(luong_label);
            Controls.Add(role_comboBox);
            Controls.Add(role_label);
            Controls.Add(donvi_textBox);
            Controls.Add(donvi_label);
            Controls.Add(phone_textBox);
            Controls.Add(phone_label);
            Controls.Add(gender_comboBox);
            Controls.Add(gender_label);
            Controls.Add(dob_textBox);
            Controls.Add(dob_label);
            Controls.Add(fullname_textBox);
            Controls.Add(fullnane_label);
            Controls.Add(employee_id_textBox);
            Controls.Add(back__button);
            Controls.Add(alter_button);
            Controls.Add(employee_id_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "SuaNhanVien";
            Size = new Size(1620, 1169);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox phucap_textBox;
        private Label phucap_label;
        private TextBox textBox1;
        private Label luong_label;
        private ComboBox role_comboBox;
        private Label role_label;
        private TextBox donvi_textBox;
        private Label donvi_label;
        private TextBox phone_textBox;
        private Label phone_label;
        private ComboBox gender_comboBox;
        private Label gender_label;
        private TextBox dob_textBox;
        private Label dob_label;
        private TextBox fullname_textBox;
        private Label fullnane_label;
        private TextBox employee_id_textBox;
        private Button back__button;
        private Button alter_button;
        private Label employee_id_label;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
    }
}
