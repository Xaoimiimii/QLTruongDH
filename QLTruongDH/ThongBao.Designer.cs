namespace QLTruongDH
{
    partial class ThongBao
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
            employee_dataGridView = new DataGridView();
            search_employee_button = new Button();
            add_button = new Button();
            search_employee_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            search_employee_label = new Label();
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
            guna2Separator1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(243, 59);
            label1.TabIndex = 9;
            label1.Text = "Thông báo";
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
            employee_dataGridView.GridColor = Color.BurlyWood;
            employee_dataGridView.Location = new Point(27, 233);
            employee_dataGridView.Margin = new Padding(0);
            employee_dataGridView.MultiSelect = false;
            employee_dataGridView.Name = "employee_dataGridView";
            employee_dataGridView.ReadOnly = true;
            employee_dataGridView.RowHeadersVisible = false;
            employee_dataGridView.RowHeadersWidth = 82;
            employee_dataGridView.Size = new Size(1571, 951);
            employee_dataGridView.TabIndex = 35;
            // 
            // search_employee_button
            // 
            search_employee_button.BackColor = Color.BurlyWood;
            search_employee_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_employee_button.ForeColor = Color.Transparent;
            search_employee_button.Location = new Point(592, 140);
            search_employee_button.Name = "search_employee_button";
            search_employee_button.Size = new Size(149, 63);
            search_employee_button.TabIndex = 45;
            search_employee_button.Text = "Tra cứu";
            search_employee_button.UseVisualStyleBackColor = false;
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(1274, 132);
            add_button.Name = "add_button";
            add_button.Size = new Size(322, 78);
            add_button.TabIndex = 44;
            add_button.Text = "Thêm thông báo";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
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
            search_employee_guna2TextBox.TabIndex = 43;
            search_employee_guna2TextBox.TextOffset = new Point(20, 0);
            // 
            // search_employee_label
            // 
            search_employee_label.AutoSize = true;
            search_employee_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_employee_label.Location = new Point(25, 152);
            search_employee_label.Margin = new Padding(0);
            search_employee_label.Name = "search_employee_label";
            search_employee_label.Size = new Size(190, 37);
            search_employee_label.TabIndex = 42;
            search_employee_label.Text = "Mã nhân viên:";
            // 
            // ThongBao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(search_employee_button);
            Controls.Add(add_button);
            Controls.Add(search_employee_guna2TextBox);
            Controls.Add(search_employee_label);
            Controls.Add(employee_dataGridView);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "ThongBao";
            Size = new Size(1620, 1209);
            ((System.ComponentModel.ISupportInitialize)employee_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private DataGridView employee_dataGridView;
        private Button search_employee_button;
        private Button add_button;
        private Guna.UI2.WinForms.Guna2TextBox search_employee_guna2TextBox;
        private Label search_employee_label;
        private TextBox mamomon_textBox;
        private TextBox nam_textBox;
        private Label label4;
        private TextBox magiaovien_textBox;
        private Label magiaovien_label;
        private TextBox mahocphan_textBox;
        private Label mahocphan_label;
    }
}
