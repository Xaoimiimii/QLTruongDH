namespace QLTruongDH
{
    partial class Admin_QLRoles
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
            search_role_button = new Button();
            add_button = new Button();
            search_role_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            search_role_label = new Label();
            DBA_ROLE_PRIVS_dataGridView = new DataGridView();
            DBA_TAB_PRIVS_dataGridView = new DataGridView();
            DBA_SYS_PRIVS_dataGridView = new DataGridView();
            dataGridView = new DataGridView();
            delete_button = new Button();
            edit_button = new Button();
            ((System.ComponentModel.ISupportInitialize)DBA_ROLE_PRIVS_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DBA_TAB_PRIVS_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DBA_SYS_PRIVS_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
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
            label1.Size = new Size(289, 59);
            label1.TabIndex = 11;
            label1.Text = "Quản lý roles";
            // 
            // search_role_button
            // 
            search_role_button.BackColor = Color.BurlyWood;
            search_role_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_role_button.ForeColor = Color.Transparent;
            search_role_button.Location = new Point(496, 130);
            search_role_button.Name = "search_role_button";
            search_role_button.Size = new Size(181, 63);
            search_role_button.TabIndex = 53;
            search_role_button.Text = "Tra cứu";
            search_role_button.UseVisualStyleBackColor = false;
            search_role_button.Click += search_role_button_Click;
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(1310, 122);
            add_button.Name = "add_button";
            add_button.Size = new Size(298, 78);
            add_button.TabIndex = 52;
            add_button.Text = "Thêm role";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // search_role_guna2TextBox
            // 
            search_role_guna2TextBox.BorderRadius = 20;
            search_role_guna2TextBox.CustomizableEdges = customizableEdges1;
            search_role_guna2TextBox.DefaultText = "";
            search_role_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_role_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_role_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_role_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_role_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_role_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_role_guna2TextBox.HoverState.BorderColor = Color.Gray;
            search_role_guna2TextBox.IconLeft = Properties.Resources.search;
            search_role_guna2TextBox.IconLeftOffset = new Point(10, 0);
            search_role_guna2TextBox.IconRight = Properties.Resources.close__1_;
            search_role_guna2TextBox.IconRightOffset = new Point(10, 0);
            search_role_guna2TextBox.Location = new Point(109, 138);
            search_role_guna2TextBox.Margin = new Padding(7);
            search_role_guna2TextBox.Name = "search_role_guna2TextBox";
            search_role_guna2TextBox.PlaceholderText = "";
            search_role_guna2TextBox.SelectedText = "";
            search_role_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_role_guna2TextBox.Size = new Size(377, 51);
            search_role_guna2TextBox.TabIndex = 51;
            search_role_guna2TextBox.TextOffset = new Point(20, 0);
            search_role_guna2TextBox.IconRightClick += search_role_guna2TextBox_IconRightClick;
            search_role_guna2TextBox.KeyDown += search_role_guna2TextBox_KeyDown;
            // 
            // search_role_label
            // 
            search_role_label.AutoSize = true;
            search_role_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_role_label.Location = new Point(25, 142);
            search_role_label.Margin = new Padding(0);
            search_role_label.Name = "search_role_label";
            search_role_label.Size = new Size(77, 37);
            search_role_label.TabIndex = 50;
            search_role_label.Text = "Role:";
            // 
            // DBA_ROLE_PRIVS_dataGridView
            // 
            DBA_ROLE_PRIVS_dataGridView.AllowUserToAddRows = false;
            DBA_ROLE_PRIVS_dataGridView.AllowUserToDeleteRows = false;
            DBA_ROLE_PRIVS_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DBA_ROLE_PRIVS_dataGridView.BackgroundColor = Color.White;
            DBA_ROLE_PRIVS_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            DBA_ROLE_PRIVS_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DBA_ROLE_PRIVS_dataGridView.GridColor = Color.BurlyWood;
            DBA_ROLE_PRIVS_dataGridView.Location = new Point(1000, 524);
            DBA_ROLE_PRIVS_dataGridView.Name = "DBA_ROLE_PRIVS_dataGridView";
            DBA_ROLE_PRIVS_dataGridView.ReadOnly = true;
            DBA_ROLE_PRIVS_dataGridView.RowHeadersVisible = false;
            DBA_ROLE_PRIVS_dataGridView.RowHeadersWidth = 82;
            DBA_ROLE_PRIVS_dataGridView.Size = new Size(608, 262);
            DBA_ROLE_PRIVS_dataGridView.TabIndex = 49;
            // 
            // DBA_TAB_PRIVS_dataGridView
            // 
            DBA_TAB_PRIVS_dataGridView.AllowUserToAddRows = false;
            DBA_TAB_PRIVS_dataGridView.AllowUserToDeleteRows = false;
            DBA_TAB_PRIVS_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DBA_TAB_PRIVS_dataGridView.BackgroundColor = Color.White;
            DBA_TAB_PRIVS_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            DBA_TAB_PRIVS_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DBA_TAB_PRIVS_dataGridView.GridColor = Color.BurlyWood;
            DBA_TAB_PRIVS_dataGridView.Location = new Point(1000, 792);
            DBA_TAB_PRIVS_dataGridView.Name = "DBA_TAB_PRIVS_dataGridView";
            DBA_TAB_PRIVS_dataGridView.ReadOnly = true;
            DBA_TAB_PRIVS_dataGridView.RowHeadersVisible = false;
            DBA_TAB_PRIVS_dataGridView.RowHeadersWidth = 82;
            DBA_TAB_PRIVS_dataGridView.Size = new Size(608, 244);
            DBA_TAB_PRIVS_dataGridView.TabIndex = 48;
            // 
            // DBA_SYS_PRIVS_dataGridView
            // 
            DBA_SYS_PRIVS_dataGridView.AllowUserToAddRows = false;
            DBA_SYS_PRIVS_dataGridView.AllowUserToDeleteRows = false;
            DBA_SYS_PRIVS_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DBA_SYS_PRIVS_dataGridView.BackgroundColor = Color.White;
            DBA_SYS_PRIVS_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            DBA_SYS_PRIVS_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DBA_SYS_PRIVS_dataGridView.GridColor = Color.BurlyWood;
            DBA_SYS_PRIVS_dataGridView.Location = new Point(1000, 212);
            DBA_SYS_PRIVS_dataGridView.Name = "DBA_SYS_PRIVS_dataGridView";
            DBA_SYS_PRIVS_dataGridView.ReadOnly = true;
            DBA_SYS_PRIVS_dataGridView.RowHeadersVisible = false;
            DBA_SYS_PRIVS_dataGridView.RowHeadersWidth = 82;
            DBA_SYS_PRIVS_dataGridView.Size = new Size(608, 306);
            DBA_SYS_PRIVS_dataGridView.TabIndex = 47;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = Color.BurlyWood;
            dataGridView.Location = new Point(15, 212);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(979, 824);
            dataGridView.TabIndex = 46;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // delete_button
            // 
            delete_button.BackColor = SystemColors.ActiveBorder;
            delete_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_button.ForeColor = Color.Transparent;
            delete_button.Location = new Point(503, 1068);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(322, 78);
            delete_button.TabIndex = 55;
            delete_button.Text = "Xóa role";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // edit_button
            // 
            edit_button.BackColor = Color.BurlyWood;
            edit_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_button.ForeColor = Color.Transparent;
            edit_button.Location = new Point(845, 1068);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(322, 78);
            edit_button.TabIndex = 54;
            edit_button.Text = "Sửa thông tin";
            edit_button.UseVisualStyleBackColor = false;
            edit_button.Click += edit_button_Click;
            // 
            // Admin_QLRoles
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(delete_button);
            Controls.Add(edit_button);
            Controls.Add(search_role_button);
            Controls.Add(add_button);
            Controls.Add(search_role_guna2TextBox);
            Controls.Add(search_role_label);
            Controls.Add(DBA_ROLE_PRIVS_dataGridView);
            Controls.Add(DBA_TAB_PRIVS_dataGridView);
            Controls.Add(DBA_SYS_PRIVS_dataGridView);
            Controls.Add(dataGridView);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "Admin_QLRoles";
            Size = new Size(1625, 1169);
            Click += Admin_QLRoles_Click;
            ((System.ComponentModel.ISupportInitialize)DBA_ROLE_PRIVS_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DBA_TAB_PRIVS_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DBA_SYS_PRIVS_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Button search_role_button;
        private Button add_button;
        private Guna.UI2.WinForms.Guna2TextBox search_role_guna2TextBox;
        private Label search_role_label;
        private DataGridView DBA_ROLE_PRIVS_dataGridView;
        private DataGridView DBA_TAB_PRIVS_dataGridView;
        private DataGridView DBA_SYS_PRIVS_dataGridView;
        private DataGridView dataGridView;
        private Button delete_button;
        private Button edit_button;
    }
}
