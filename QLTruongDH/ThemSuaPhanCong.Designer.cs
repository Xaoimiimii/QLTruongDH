namespace QLTruongDH
{
    partial class ThemSuaPhanCong
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
            mamomon_id_label = new Label();
            back_pictureBox = new PictureBox();
            back_label = new Label();
            hocky_comboBox = new ComboBox();
            back_flowLayoutPanel = new FlowLayoutPanel();
            nam_textBox = new TextBox();
            nam_label = new Label();
            mahocphan_textBox = new TextBox();
            mahocphan_label = new Label();
            reset__button = new Button();
            add_button = new Button();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            title_label = new Label();
            magiaovien_textBox = new TextBox();
            magiaovien_label = new Label();
            hocky_label = new Label();
            ((System.ComponentModel.ISupportInitialize)back_pictureBox).BeginInit();
            back_flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mamomon_id_label
            // 
            mamomon_id_label.AutoSize = true;
            mamomon_id_label.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mamomon_id_label.ForeColor = Color.BurlyWood;
            mamomon_id_label.Location = new Point(672, 32);
            mamomon_id_label.Name = "mamomon_id_label";
            mamomon_id_label.Size = new Size(140, 50);
            mamomon_id_label.TabIndex = 85;
            mamomon_id_label.Text = "MaMM";
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
            // hocky_comboBox
            // 
            hocky_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hocky_comboBox.FormattingEnabled = true;
            hocky_comboBox.Items.AddRange(new object[] { "1", "2", "3" });
            hocky_comboBox.Location = new Point(156, 157);
            hocky_comboBox.Name = "hocky_comboBox";
            hocky_comboBox.Size = new Size(102, 53);
            hocky_comboBox.TabIndex = 84;
            // 
            // back_flowLayoutPanel
            // 
            back_flowLayoutPanel.Controls.Add(back_pictureBox);
            back_flowLayoutPanel.Controls.Add(back_label);
            back_flowLayoutPanel.Location = new Point(25, 1110);
            back_flowLayoutPanel.Margin = new Padding(0);
            back_flowLayoutPanel.Name = "back_flowLayoutPanel";
            back_flowLayoutPanel.Size = new Size(180, 38);
            back_flowLayoutPanel.TabIndex = 83;
            back_flowLayoutPanel.Click += back_flowLayoutPanel_Click;
            back_flowLayoutPanel.MouseEnter += back_flowLayoutPanel_MouseEnter;
            back_flowLayoutPanel.MouseLeave += back_flowLayoutPanel_MouseLeave;
            // 
            // nam_textBox
            // 
            nam_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nam_textBox.Location = new Point(869, 157);
            nam_textBox.Name = "nam_textBox";
            nam_textBox.Size = new Size(169, 50);
            nam_textBox.TabIndex = 82;
            // 
            // nam_label
            // 
            nam_label.AutoSize = true;
            nam_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nam_label.Location = new Point(706, 157);
            nam_label.Margin = new Padding(0);
            nam_label.Name = "nam_label";
            nam_label.Size = new Size(160, 45);
            nam_label.TabIndex = 77;
            nam_label.Text = "Năm học:";
            // 
            // mahocphan_textBox
            // 
            mahocphan_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mahocphan_textBox.Location = new Point(248, 257);
            mahocphan_textBox.Name = "mahocphan_textBox";
            mahocphan_textBox.Size = new Size(310, 50);
            mahocphan_textBox.TabIndex = 69;
            // 
            // mahocphan_label
            // 
            mahocphan_label.AutoSize = true;
            mahocphan_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mahocphan_label.Location = new Point(25, 257);
            mahocphan_label.Margin = new Padding(0);
            mahocphan_label.Name = "mahocphan_label";
            mahocphan_label.Size = new Size(220, 45);
            mahocphan_label.TabIndex = 68;
            mahocphan_label.Text = "Mã học phần:";
            // 
            // reset__button
            // 
            reset__button.BackColor = SystemColors.ActiveBorder;
            reset__button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset__button.ForeColor = Color.Transparent;
            reset__button.Location = new Point(477, 773);
            reset__button.Name = "reset__button";
            reset__button.Size = new Size(322, 78);
            reset__button.TabIndex = 67;
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
            add_button.TabIndex = 66;
            add_button.Text = "Thêm phân công";
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
            guna2Separator1.TabIndex = 65;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_label.Location = new Point(25, 25);
            title_label.Margin = new Padding(0);
            title_label.Name = "title_label";
            title_label.Size = new Size(454, 59);
            title_label.TabIndex = 64;
            title_label.Text = "Thêm phân công mới";
            // 
            // magiaovien_textBox
            // 
            magiaovien_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            magiaovien_textBox.Location = new Point(925, 257);
            magiaovien_textBox.Name = "magiaovien_textBox";
            magiaovien_textBox.Size = new Size(277, 50);
            magiaovien_textBox.TabIndex = 87;
            // 
            // magiaovien_label
            // 
            magiaovien_label.AutoSize = true;
            magiaovien_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            magiaovien_label.Location = new Point(706, 257);
            magiaovien_label.Margin = new Padding(0);
            magiaovien_label.Name = "magiaovien_label";
            magiaovien_label.Size = new Size(216, 45);
            magiaovien_label.TabIndex = 86;
            magiaovien_label.Text = "Mã giáo viên:";
            // 
            // hocky_label
            // 
            hocky_label.AutoSize = true;
            hocky_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hocky_label.Location = new Point(25, 157);
            hocky_label.Margin = new Padding(0);
            hocky_label.Name = "hocky_label";
            hocky_label.Size = new Size(128, 45);
            hocky_label.TabIndex = 88;
            hocky_label.Text = "Học kỳ:";
            // 
            // ThemSuaPhanCong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(hocky_label);
            Controls.Add(magiaovien_textBox);
            Controls.Add(magiaovien_label);
            Controls.Add(mamomon_id_label);
            Controls.Add(hocky_comboBox);
            Controls.Add(back_flowLayoutPanel);
            Controls.Add(nam_textBox);
            Controls.Add(nam_label);
            Controls.Add(mahocphan_textBox);
            Controls.Add(mahocphan_label);
            Controls.Add(reset__button);
            Controls.Add(add_button);
            Controls.Add(guna2Separator1);
            Controls.Add(title_label);
            Margin = new Padding(0);
            Name = "ThemSuaPhanCong";
            Size = new Size(1625, 1169);
            ((System.ComponentModel.ISupportInitialize)back_pictureBox).EndInit();
            back_flowLayoutPanel.ResumeLayout(false);
            back_flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mamomon_id_label;
        private PictureBox back_pictureBox;
        private Label back_label;
        private ComboBox hocky_comboBox;
        private FlowLayoutPanel back_flowLayoutPanel;
        private TextBox nam_textBox;
        private Label nam_label;
        private TextBox mahocphan_textBox;
        private Label mahocphan_label;
        private Button reset__button;
        private Button add_button;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label title_label;
        private TextBox magiaovien_textBox;
        private Label magiaovien_label;
        private Label hocky_label;
    }
}
