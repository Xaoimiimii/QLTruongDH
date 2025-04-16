namespace QLTruongDH
{
    partial class Admin_ThemSuaRole
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
            add_role_tab_checkedListBox = new CheckedListBox();
            add_role_select_table_comboBox = new ComboBox();
            tab_priv_label = new Label();
            add_role_role_checkedListBox = new CheckedListBox();
            role_priv_label = new Label();
            reset_button = new Button();
            sys_priv_label = new Label();
            username_panel = new Panel();
            add_role_label = new Label();
            add_role_textBox = new TextBox();
            add_role_column_checkedListBox = new CheckedListBox();
            add_role_sys_checkedListBox = new CheckedListBox();
            add_button = new Button();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            username_panel.SuspendLayout();
            SuspendLayout();
            // 
            // add_role_tab_checkedListBox
            // 
            add_role_tab_checkedListBox.BorderStyle = BorderStyle.None;
            add_role_tab_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_role_tab_checkedListBox.FormattingEnabled = true;
            add_role_tab_checkedListBox.Items.AddRange(new object[] { "SELECT", "INSERT", "DELETE", "UPDATE" });
            add_role_tab_checkedListBox.Location = new Point(25, 746);
            add_role_tab_checkedListBox.Name = "add_role_tab_checkedListBox";
            add_role_tab_checkedListBox.Size = new Size(178, 160);
            add_role_tab_checkedListBox.TabIndex = 71;
            // 
            // add_role_select_table_comboBox
            // 
            add_role_select_table_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_role_select_table_comboBox.FormattingEnabled = true;
            add_role_select_table_comboBox.Location = new Point(25, 675);
            add_role_select_table_comboBox.Name = "add_role_select_table_comboBox";
            add_role_select_table_comboBox.Size = new Size(339, 45);
            add_role_select_table_comboBox.TabIndex = 70;
            add_role_select_table_comboBox.Text = "Chọn bảng";
            // 
            // tab_priv_label
            // 
            tab_priv_label.AutoSize = true;
            tab_priv_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_priv_label.Location = new Point(25, 620);
            tab_priv_label.Name = "tab_priv_label";
            tab_priv_label.Size = new Size(178, 37);
            tab_priv_label.TabIndex = 69;
            tab_priv_label.Text = "Tab privilege:";
            // 
            // add_role_role_checkedListBox
            // 
            add_role_role_checkedListBox.BorderStyle = BorderStyle.None;
            add_role_role_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_role_role_checkedListBox.FormattingEnabled = true;
            add_role_role_checkedListBox.Location = new Point(650, 287);
            add_role_role_checkedListBox.Name = "add_role_role_checkedListBox";
            add_role_role_checkedListBox.Size = new Size(493, 280);
            add_role_role_checkedListBox.TabIndex = 68;
            // 
            // role_priv_label
            // 
            role_priv_label.AutoSize = true;
            role_priv_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            role_priv_label.Location = new Point(650, 233);
            role_priv_label.Name = "role_priv_label";
            role_priv_label.Size = new Size(189, 37);
            role_priv_label.TabIndex = 67;
            role_priv_label.Text = "Role privilege:";
            // 
            // reset_button
            // 
            reset_button.BackColor = SystemColors.ActiveBorder;
            reset_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset_button.ForeColor = Color.Transparent;
            reset_button.Location = new Point(506, 1049);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(322, 78);
            reset_button.TabIndex = 62;
            reset_button.Text = "Nhập lại";
            reset_button.UseVisualStyleBackColor = false;
            // 
            // sys_priv_label
            // 
            sys_priv_label.AutoSize = true;
            sys_priv_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sys_priv_label.Location = new Point(25, 233);
            sys_priv_label.Name = "sys_priv_label";
            sys_priv_label.Size = new Size(176, 37);
            sys_priv_label.TabIndex = 65;
            sys_priv_label.Text = "Sys privilege:";
            // 
            // username_panel
            // 
            username_panel.Controls.Add(add_role_label);
            username_panel.Controls.Add(add_role_textBox);
            username_panel.Location = new Point(25, 121);
            username_panel.Margin = new Padding(0);
            username_panel.Name = "username_panel";
            username_panel.Size = new Size(554, 69);
            username_panel.TabIndex = 63;
            // 
            // add_role_label
            // 
            add_role_label.AutoSize = true;
            add_role_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_role_label.Location = new Point(0, 19);
            add_role_label.Margin = new Padding(0);
            add_role_label.Name = "add_role_label";
            add_role_label.Size = new Size(120, 37);
            add_role_label.TabIndex = 45;
            add_role_label.Text = "Tên role:";
            // 
            // add_role_textBox
            // 
            add_role_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_role_textBox.Location = new Point(123, 19);
            add_role_textBox.Name = "add_role_textBox";
            add_role_textBox.Size = new Size(422, 43);
            add_role_textBox.TabIndex = 46;
            // 
            // add_role_column_checkedListBox
            // 
            add_role_column_checkedListBox.BorderStyle = BorderStyle.None;
            add_role_column_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_role_column_checkedListBox.FormattingEnabled = true;
            add_role_column_checkedListBox.Location = new Point(650, 620);
            add_role_column_checkedListBox.Name = "add_role_column_checkedListBox";
            add_role_column_checkedListBox.Size = new Size(493, 360);
            add_role_column_checkedListBox.TabIndex = 73;
            // 
            // add_role_sys_checkedListBox
            // 
            add_role_sys_checkedListBox.BorderStyle = BorderStyle.None;
            add_role_sys_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_role_sys_checkedListBox.FormattingEnabled = true;
            add_role_sys_checkedListBox.Items.AddRange(new object[] { "Connect", "Create session", "Create/drop/alter user", "Create/drop/alter function", "Create/drop/alter procedure", "Create/drop/alter table", "Create/drop/alter view" });
            add_role_sys_checkedListBox.Location = new Point(25, 287);
            add_role_sys_checkedListBox.Name = "add_role_sys_checkedListBox";
            add_role_sys_checkedListBox.Size = new Size(394, 280);
            add_role_sys_checkedListBox.TabIndex = 66;
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(848, 1049);
            add_button.Name = "add_button";
            add_button.Size = new Size(322, 78);
            add_button.TabIndex = 61;
            add_button.Text = "Thêm role";
            add_button.UseVisualStyleBackColor = false;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(228, 59);
            label1.TabIndex = 59;
            label1.Text = "Thêm role";
            // 
            // Admin_ThemRole
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(add_role_tab_checkedListBox);
            Controls.Add(add_role_select_table_comboBox);
            Controls.Add(tab_priv_label);
            Controls.Add(add_role_role_checkedListBox);
            Controls.Add(role_priv_label);
            Controls.Add(reset_button);
            Controls.Add(sys_priv_label);
            Controls.Add(username_panel);
            Controls.Add(add_role_column_checkedListBox);
            Controls.Add(add_role_sys_checkedListBox);
            Controls.Add(add_button);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Location = new Point(25, 121);
            Margin = new Padding(0);
            Name = "Admin_ThemRole";
            Size = new Size(1625, 1169);
            username_panel.ResumeLayout(false);
            username_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox add_role_tab_checkedListBox;
        private ComboBox add_role_select_table_comboBox;
        private Label tab_priv_label;
        private CheckedListBox add_role_role_checkedListBox;
        private Label role_priv_label;
        private Button reset_button;
        private Label sys_priv_label;
        private Panel username_panel;
        private Label add_role_label;
        private TextBox add_role_textBox;
        private CheckedListBox add_role_column_checkedListBox;
        private CheckedListBox add_role_sys_checkedListBox;
        private Button add_button;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
    }
}
