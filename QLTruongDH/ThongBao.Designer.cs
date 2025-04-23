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
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            noti_dataGridView = new DataGridView();
            add_button = new Button();
            ((System.ComponentModel.ISupportInitialize)noti_dataGridView).BeginInit();
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
            // noti_dataGridView
            // 
            noti_dataGridView.AllowUserToAddRows = false;
            noti_dataGridView.AllowUserToDeleteRows = false;
            noti_dataGridView.AllowUserToResizeRows = false;
            noti_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            noti_dataGridView.BackgroundColor = Color.FloralWhite;
            noti_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            noti_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            noti_dataGridView.GridColor = Color.BurlyWood;
            noti_dataGridView.Location = new Point(27, 140);
            noti_dataGridView.Margin = new Padding(0);
            noti_dataGridView.MultiSelect = false;
            noti_dataGridView.Name = "noti_dataGridView";
            noti_dataGridView.ReadOnly = true;
            noti_dataGridView.RowHeadersVisible = false;
            noti_dataGridView.RowHeadersWidth = 82;
            noti_dataGridView.Size = new Size(1571, 1044);
            noti_dataGridView.TabIndex = 35;
            // 
            // add_button
            // 
            add_button.BackColor = Color.BurlyWood;
            add_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(1276, 19);
            add_button.Name = "add_button";
            add_button.Size = new Size(322, 78);
            add_button.TabIndex = 44;
            add_button.Text = "Thêm thông báo";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // ThongBao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(add_button);
            Controls.Add(noti_dataGridView);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "ThongBao";
            Size = new Size(1620, 1209);
            Load += ThongBao_Load;
            ((System.ComponentModel.ISupportInitialize)noti_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private DataGridView noti_dataGridView;
        private Button add_button;
        private TextBox mamomon_textBox;
        private TextBox nam_textBox;
        private Label label4;
        private TextBox magiaovien_textBox;
        private Label magiaovien_label;
        private TextBox mahocphan_textBox;
        private Label mahocphan_label;
    }
}
