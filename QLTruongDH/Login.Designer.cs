namespace QLTruongDH
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            username_textBox = new TextBox();
            username_label = new Label();
            panel2 = new Panel();
            password_textBox = new TextBox();
            label1 = new Label();
            login_button = new Button();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(username_textBox);
            panel1.Controls.Add(username_label);
            panel1.Location = new Point(796, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 126);
            panel1.TabIndex = 1;
            // 
            // username_textBox
            // 
            username_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_textBox.Location = new Point(0, 50);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(536, 50);
            username_textBox.TabIndex = 1;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_label.Location = new Point(0, 0);
            username_label.Name = "username_label";
            username_label.Size = new Size(245, 45);
            username_label.TabIndex = 0;
            username_label.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(password_textBox);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(796, 339);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 120);
            panel2.TabIndex = 3;
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_textBox.Location = new Point(0, 50);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(536, 50);
            password_textBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 45);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu:";
            // 
            // login_button
            // 
            login_button.BackColor = Color.OldLace;
            login_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_button.Location = new Point(845, 541);
            login_button.Name = "login_button";
            login_button.Size = new Size(466, 76);
            login_button.TabIndex = 4;
            login_button.Text = "Đăng nhập";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(login_button);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(32, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(1411, 745);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(948, 65);
            label2.Name = "label2";
            label2.Size = new Size(247, 59);
            label2.TabIndex = 6;
            label2.Text = "Đăng nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.college_class_bro;
            pictureBox1.Location = new Point(47, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(683, 678);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1474, 801);
            Controls.Add(panel3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox username_textBox;
        private Label username_label;
        private Panel panel2;
        private TextBox password_textBox;
        private Label label1;
        private Button login_button;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}