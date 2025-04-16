namespace QLTruongDH
{
    partial class Admin_ThemUser
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
            reset_button = new Button();
            add_button = new Button();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            username_textBox = new TextBox();
            username_label = new Label();
            username_panel = new Panel();
            password_panel = new Panel();
            password_label = new Label();
            password_textBox = new TextBox();
            sys_priv_label = new Label();
            add_user_sys_checkedListBox = new CheckedListBox();
            role_priv_label = new Label();
            add_user_role_checkedListBox = new CheckedListBox();
            tab_priv_label = new Label();
            add_user_select_table_comboBox = new ComboBox();
            add_user_tab_checkedListBox = new CheckedListBox();
            add_user_with_grant_option_checkBox = new CheckBox();
            add_user_column_checkedListBox = new CheckedListBox();
            checkBox1 = new CheckBox();
            username_panel.SuspendLayout();
            password_panel.SuspendLayout();
            SuspendLayout();
            // 
            // reset_button
            // 
            reset_button.BackColor = SystemColors.ActiveBorder;
            reset_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset_button.ForeColor = Color.Transparent;
            reset_button.Location = new Point(504, 1033);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(322, 78);
            reset_button.TabIndex = 44;
            reset_button.Text = "Nhập lại";
            reset_button.UseVisualStyleBackColor = false;
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(846, 1033);
            add_button.Name = "add_button";
            add_button.Size = new Size(322, 78);
            add_button.TabIndex = 43;
            add_button.Text = "Thêm user";
            add_button.UseVisualStyleBackColor = false;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(235, 59);
            label1.TabIndex = 41;
            label1.Text = "Thêm user";
            // 
            // username_textBox
            // 
            username_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_textBox.Location = new Point(248, 19);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(297, 43);
            username_textBox.TabIndex = 46;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_label.Location = new Point(0, 19);
            username_label.Margin = new Padding(0);
            username_label.Name = "username_label";
            username_label.Size = new Size(204, 37);
            username_label.TabIndex = 45;
            username_label.Text = "Tên đăng nhập:";
            // 
            // username_panel
            // 
            username_panel.Controls.Add(username_label);
            username_panel.Controls.Add(username_textBox);
            username_panel.Location = new Point(25, 121);
            username_panel.Margin = new Padding(0);
            username_panel.Name = "username_panel";
            username_panel.Size = new Size(554, 69);
            username_panel.TabIndex = 47;
            // 
            // password_panel
            // 
            password_panel.Controls.Add(password_label);
            password_panel.Controls.Add(password_textBox);
            password_panel.Location = new Point(650, 121);
            password_panel.Name = "password_panel";
            password_panel.Size = new Size(554, 69);
            password_panel.TabIndex = 48;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_label.Location = new Point(0, 19);
            password_label.Margin = new Padding(0);
            password_label.Name = "password_label";
            password_label.Size = new Size(140, 37);
            password_label.TabIndex = 45;
            password_label.Text = "Mật khẩu:";
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_textBox.Location = new Point(171, 19);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(374, 43);
            password_textBox.TabIndex = 46;
            // 
            // sys_priv_label
            // 
            sys_priv_label.AutoSize = true;
            sys_priv_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sys_priv_label.Location = new Point(25, 233);
            sys_priv_label.Name = "sys_priv_label";
            sys_priv_label.Size = new Size(176, 37);
            sys_priv_label.TabIndex = 49;
            sys_priv_label.Text = "Sys privilege:";
            // 
            // add_user_sys_checkedListBox
            // 
            add_user_sys_checkedListBox.BorderStyle = BorderStyle.None;
            add_user_sys_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_user_sys_checkedListBox.FormattingEnabled = true;
            add_user_sys_checkedListBox.Items.AddRange(new object[] { "Connect", "Create session", "Create/drop/alter user", "Create/drop/alter function", "Create/drop/alter procedure", "Create/drop/alter table", "Create/drop/alter view" });
            add_user_sys_checkedListBox.Location = new Point(25, 287);
            add_user_sys_checkedListBox.Name = "add_user_sys_checkedListBox";
            add_user_sys_checkedListBox.Size = new Size(394, 280);
            add_user_sys_checkedListBox.TabIndex = 50;
            // 
            // role_priv_label
            // 
            role_priv_label.AutoSize = true;
            role_priv_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            role_priv_label.Location = new Point(650, 233);
            role_priv_label.Name = "role_priv_label";
            role_priv_label.Size = new Size(189, 37);
            role_priv_label.TabIndex = 51;
            role_priv_label.Text = "Role privilege:";
            // 
            // add_user_role_checkedListBox
            // 
            add_user_role_checkedListBox.BorderStyle = BorderStyle.None;
            add_user_role_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_user_role_checkedListBox.FormattingEnabled = true;
            add_user_role_checkedListBox.Location = new Point(650, 287);
            add_user_role_checkedListBox.Name = "add_user_role_checkedListBox";
            add_user_role_checkedListBox.Size = new Size(493, 280);
            add_user_role_checkedListBox.TabIndex = 52;
            // 
            // tab_priv_label
            // 
            tab_priv_label.AutoSize = true;
            tab_priv_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_priv_label.Location = new Point(25, 620);
            tab_priv_label.Name = "tab_priv_label";
            tab_priv_label.Size = new Size(178, 37);
            tab_priv_label.TabIndex = 53;
            tab_priv_label.Text = "Tab privilege:";
            // 
            // add_user_select_table_comboBox
            // 
            add_user_select_table_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_user_select_table_comboBox.FormattingEnabled = true;
            add_user_select_table_comboBox.Location = new Point(25, 675);
            add_user_select_table_comboBox.Name = "add_user_select_table_comboBox";
            add_user_select_table_comboBox.Size = new Size(339, 45);
            add_user_select_table_comboBox.TabIndex = 54;
            add_user_select_table_comboBox.Text = "Chọn bảng";
            // 
            // add_user_tab_checkedListBox
            // 
            add_user_tab_checkedListBox.BorderStyle = BorderStyle.None;
            add_user_tab_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_user_tab_checkedListBox.FormattingEnabled = true;
            add_user_tab_checkedListBox.Items.AddRange(new object[] { "SELECT", "INSERT", "DELETE", "UPDATE" });
            add_user_tab_checkedListBox.Location = new Point(25, 746);
            add_user_tab_checkedListBox.Name = "add_user_tab_checkedListBox";
            add_user_tab_checkedListBox.Size = new Size(178, 160);
            add_user_tab_checkedListBox.TabIndex = 55;
            // 
            // add_user_with_grant_option_checkBox
            // 
            add_user_with_grant_option_checkBox.AutoSize = true;
            add_user_with_grant_option_checkBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_user_with_grant_option_checkBox.ForeColor = Color.Goldenrod;
            add_user_with_grant_option_checkBox.Location = new Point(209, 746);
            add_user_with_grant_option_checkBox.Name = "add_user_with_grant_option_checkBox";
            add_user_with_grant_option_checkBox.Size = new Size(310, 41);
            add_user_with_grant_option_checkBox.TabIndex = 56;
            add_user_with_grant_option_checkBox.Text = "WITH GRANT OPTION";
            add_user_with_grant_option_checkBox.UseVisualStyleBackColor = true;
            // 
            // add_user_column_checkedListBox
            // 
            add_user_column_checkedListBox.BorderStyle = BorderStyle.None;
            add_user_column_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_user_column_checkedListBox.FormattingEnabled = true;
            add_user_column_checkedListBox.Location = new Point(650, 620);
            add_user_column_checkedListBox.Name = "add_user_column_checkedListBox";
            add_user_column_checkedListBox.Size = new Size(493, 360);
            add_user_column_checkedListBox.TabIndex = 57;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.Goldenrod;
            checkBox1.Location = new Point(209, 793);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(310, 41);
            checkBox1.TabIndex = 58;
            checkBox1.Text = "WITH GRANT OPTION";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Admin_ThemUser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(checkBox1);
            Controls.Add(add_user_column_checkedListBox);
            Controls.Add(add_user_with_grant_option_checkBox);
            Controls.Add(add_user_tab_checkedListBox);
            Controls.Add(add_user_select_table_comboBox);
            Controls.Add(tab_priv_label);
            Controls.Add(add_user_role_checkedListBox);
            Controls.Add(role_priv_label);
            Controls.Add(add_user_sys_checkedListBox);
            Controls.Add(sys_priv_label);
            Controls.Add(password_panel);
            Controls.Add(username_panel);
            Controls.Add(reset_button);
            Controls.Add(add_button);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "Admin_ThemUser";
            Size = new Size(1625, 1169);
            username_panel.ResumeLayout(false);
            username_panel.PerformLayout();
            password_panel.ResumeLayout(false);
            password_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reset_button;
        private Button add_button;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private TextBox username_textBox;
        private Label username_label;
        private Panel username_panel;
        private Panel password_panel;
        private Label password_label;
        private TextBox password_textBox;
        private Label sys_priv_label;
        private CheckedListBox add_user_sys_checkedListBox;
        private Label role_priv_label;
        private CheckedListBox add_user_role_checkedListBox;
        private Label tab_priv_label;
        private ComboBox add_user_select_table_comboBox;
        private CheckedListBox add_user_tab_checkedListBox;
        private CheckBox add_user_with_grant_option_checkBox;
        private CheckedListBox add_user_column_checkedListBox;
        private CheckBox checkBox1;
    }
}
