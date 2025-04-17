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
            rolename_textBox = new TextBox();
            add_role_column_checkedListBox = new CheckedListBox();
            add_role_sys_checkedListBox = new CheckedListBox();
            add_button = new Button();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            control_title_label = new Label();
            back_flowLayoutPanel = new FlowLayoutPanel();
            back_pictureBox = new PictureBox();
            back_label = new Label();
            username_panel.SuspendLayout();
            back_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)back_pictureBox).BeginInit();
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
            add_role_tab_checkedListBox.ItemCheck += add_role_tab_checkedListBox_ItemCheck;
            add_role_tab_checkedListBox.Click += add_role_tab_checkedListBox_Click;
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
            add_role_select_table_comboBox.SelectedIndexChanged += add_role_select_table_comboBox_SelectedIndexChanged;
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
            reset_button.Click += reset_button_Click;
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
            username_panel.Controls.Add(rolename_textBox);
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
            // rolename_textBox
            // 
            rolename_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rolename_textBox.Location = new Point(123, 19);
            rolename_textBox.Name = "rolename_textBox";
            rolename_textBox.Size = new Size(422, 43);
            rolename_textBox.TabIndex = 46;
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
            add_role_column_checkedListBox.ItemCheck += add_role_column_checkedListBox_ItemCheck;
            // 
            // add_role_sys_checkedListBox
            // 
            add_role_sys_checkedListBox.BorderStyle = BorderStyle.None;
            add_role_sys_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_role_sys_checkedListBox.FormattingEnabled = true;
            add_role_sys_checkedListBox.Items.AddRange(new object[] { "Create session", "Create user", "Drop user", "Alter user", "Create procedure", "Create table", "Create view", "Drop any procedure", "Alter any procedure", "Drop any table", "Alter any table" });
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
            add_button.Click += add_button_Click;
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
            // control_title_label
            // 
            control_title_label.AutoSize = true;
            control_title_label.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            control_title_label.Location = new Point(25, 25);
            control_title_label.Margin = new Padding(0);
            control_title_label.Name = "control_title_label";
            control_title_label.Size = new Size(228, 59);
            control_title_label.TabIndex = 59;
            control_title_label.Text = "Thêm role";
            // 
            // back_flowLayoutPanel
            // 
            back_flowLayoutPanel.Controls.Add(back_pictureBox);
            back_flowLayoutPanel.Controls.Add(back_label);
            back_flowLayoutPanel.Location = new Point(25, 1064);
            back_flowLayoutPanel.Margin = new Padding(0);
            back_flowLayoutPanel.Name = "back_flowLayoutPanel";
            back_flowLayoutPanel.Size = new Size(180, 38);
            back_flowLayoutPanel.TabIndex = 74;
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
            // Admin_ThemSuaRole
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(back_flowLayoutPanel);
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
            Controls.Add(control_title_label);
            Location = new Point(25, 121);
            Margin = new Padding(0);
            Name = "Admin_ThemSuaRole";
            Size = new Size(1625, 1169);
            username_panel.ResumeLayout(false);
            username_panel.PerformLayout();
            back_flowLayoutPanel.ResumeLayout(false);
            back_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)back_pictureBox).EndInit();
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
        private TextBox rolename_textBox;
        private CheckedListBox add_role_column_checkedListBox;
        private CheckedListBox add_role_sys_checkedListBox;
        private Button add_button;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label control_title_label;
        private FlowLayoutPanel back_flowLayoutPanel;
        private PictureBox back_pictureBox;
        private Label back_label;
    }
}
