namespace QLTruongDH
{
    partial class ThemThongBao
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
            input_panel = new Panel();
            group_checkedListBox = new CheckedListBox();
            compartment_checkedListBox = new CheckedListBox();
            level_checkedListBox = new CheckedListBox();
            group_label = new Label();
            level_label = new Label();
            compartment_label = new Label();
            content_label = new Label();
            content_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            reset__button = new Button();
            add_button = new Button();
            back_flowLayoutPanel = new FlowLayoutPanel();
            back_pictureBox = new PictureBox();
            back_label = new Label();
            input_panel.SuspendLayout();
            back_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)back_pictureBox).BeginInit();
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
            label1.Size = new Size(360, 59);
            label1.TabIndex = 11;
            label1.Text = "Thêm thông báo";
            // 
            // input_panel
            // 
            input_panel.Controls.Add(group_checkedListBox);
            input_panel.Controls.Add(compartment_checkedListBox);
            input_panel.Controls.Add(level_checkedListBox);
            input_panel.Controls.Add(group_label);
            input_panel.Controls.Add(level_label);
            input_panel.Controls.Add(compartment_label);
            input_panel.Location = new Point(25, 124);
            input_panel.Name = "input_panel";
            input_panel.Size = new Size(1567, 316);
            input_panel.TabIndex = 101;
            // 
            // group_checkedListBox
            // 
            group_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            group_checkedListBox.FormattingEnabled = true;
            group_checkedListBox.Items.AddRange(new object[] { "CS1", "CS2" });
            group_checkedListBox.Location = new Point(1044, 50);
            group_checkedListBox.Name = "group_checkedListBox";
            group_checkedListBox.Size = new Size(309, 244);
            group_checkedListBox.TabIndex = 103;
            // 
            // compartment_checkedListBox
            // 
            compartment_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            compartment_checkedListBox.FormattingEnabled = true;
            compartment_checkedListBox.Items.AddRange(new object[] { "Khoa CNTT", "Khoa Toán - Toán tin", "Khoa Vật lý", "Khoa Hóa học", "Khoa Sinh học", "Khoa Môi trường", "Khoa Địa chất", "Khoa Điện tử viễn thông", "Khoa Công nghệ vật liệu", "Khoa Khoa học liên ngành", "Viện Tế bào gốc", "Phòng Đào tạo", "Phòng Khảo thí", "Phòng Công tác sinh viên", "Phòng tổ chức hành chính" });
            compartment_checkedListBox.Location = new Point(436, 50);
            compartment_checkedListBox.Name = "compartment_checkedListBox";
            compartment_checkedListBox.Size = new Size(477, 244);
            compartment_checkedListBox.TabIndex = 102;
            // 
            // level_checkedListBox
            // 
            level_checkedListBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            level_checkedListBox.FormattingEnabled = true;
            level_checkedListBox.Location = new Point(3, 50);
            level_checkedListBox.Name = "level_checkedListBox";
            level_checkedListBox.Size = new Size(309, 244);
            level_checkedListBox.TabIndex = 101;
            // 
            // group_label
            // 
            group_label.AutoSize = true;
            group_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            group_label.Location = new Point(1044, 6);
            group_label.Margin = new Padding(0);
            group_label.Name = "group_label";
            group_label.Size = new Size(252, 37);
            group_label.TabIndex = 100;
            group_label.Text = "Nhóm người dùng:";
            // 
            // level_label
            // 
            level_label.AutoSize = true;
            level_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            level_label.Location = new Point(0, 6);
            level_label.Margin = new Padding(0);
            level_label.Name = "level_label";
            level_label.Size = new Size(226, 37);
            level_label.TabIndex = 96;
            level_label.Text = "Mức độ bảo mật:";
            // 
            // compartment_label
            // 
            compartment_label.AutoSize = true;
            compartment_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            compartment_label.Location = new Point(436, 6);
            compartment_label.Margin = new Padding(0);
            compartment_label.Name = "compartment_label";
            compartment_label.Size = new Size(276, 37);
            compartment_label.TabIndex = 95;
            compartment_label.Text = "Phân vùng thông tin:";
            // 
            // content_label
            // 
            content_label.AutoSize = true;
            content_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            content_label.Location = new Point(25, 465);
            content_label.Margin = new Padding(0);
            content_label.Name = "content_label";
            content_label.Size = new Size(273, 37);
            content_label.TabIndex = 102;
            content_label.Text = "Nội dung thông báo:";
            // 
            // content_guna2TextBox
            // 
            content_guna2TextBox.BorderRadius = 10;
            content_guna2TextBox.CustomizableEdges = customizableEdges1;
            content_guna2TextBox.DefaultText = "";
            content_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            content_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            content_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            content_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            content_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            content_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            content_guna2TextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            content_guna2TextBox.Location = new Point(25, 520);
            content_guna2TextBox.Margin = new Padding(7, 7, 7, 7);
            content_guna2TextBox.Multiline = true;
            content_guna2TextBox.Name = "content_guna2TextBox";
            content_guna2TextBox.PlaceholderText = "";
            content_guna2TextBox.SelectedText = "";
            content_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            content_guna2TextBox.Size = new Size(1567, 556);
            content_guna2TextBox.TabIndex = 103;
            // 
            // reset__button
            // 
            reset__button.BackColor = SystemColors.ActiveBorder;
            reset__button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset__button.ForeColor = Color.Transparent;
            reset__button.Location = new Point(477, 1104);
            reset__button.Name = "reset__button";
            reset__button.Size = new Size(322, 78);
            reset__button.TabIndex = 105;
            reset__button.Text = "Nhập lại";
            reset__button.UseVisualStyleBackColor = false;
            reset__button.Click += reset__button_Click;
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(819, 1104);
            add_button.Name = "add_button";
            add_button.Size = new Size(322, 78);
            add_button.TabIndex = 104;
            add_button.Text = "Thêm thông báo";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // back_flowLayoutPanel
            // 
            back_flowLayoutPanel.Controls.Add(back_pictureBox);
            back_flowLayoutPanel.Controls.Add(back_label);
            back_flowLayoutPanel.Location = new Point(25, 1127);
            back_flowLayoutPanel.Margin = new Padding(0);
            back_flowLayoutPanel.Name = "back_flowLayoutPanel";
            back_flowLayoutPanel.Size = new Size(180, 38);
            back_flowLayoutPanel.TabIndex = 106;
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
            // ThemThongBao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(back_flowLayoutPanel);
            Controls.Add(reset__button);
            Controls.Add(add_button);
            Controls.Add(content_guna2TextBox);
            Controls.Add(content_label);
            Controls.Add(input_panel);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "ThemThongBao";
            Size = new Size(1620, 1209);
            Load += ThemThongBao_Load;
            input_panel.ResumeLayout(false);
            input_panel.PerformLayout();
            back_flowLayoutPanel.ResumeLayout(false);
            back_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)back_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Panel input_panel;
        private Label group_label;
        private Label level_label;
        private Label compartment_label;
        private Label content_label;
        private Guna.UI2.WinForms.Guna2TextBox content_guna2TextBox;
        private Button reset__button;
        private Button add_button;
        private FlowLayoutPanel back_flowLayoutPanel;
        private PictureBox back_pictureBox;
        private Label back_label;
        private CheckedListBox group_checkedListBox;
        private CheckedListBox compartment_checkedListBox;
        private CheckedListBox level_checkedListBox;
    }
}
