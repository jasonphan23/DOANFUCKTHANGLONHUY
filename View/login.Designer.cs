namespace WindowsFormsApplication1.View
{
    partial class login
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbwelcome = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button24 = new MetroFramework.Controls.MetroButton();
            this.lbmatkhau = new MetroFramework.Controls.MetroLabel();
            this.textBox7 = new MetroFramework.Controls.MetroTextBox();
            this.textBox6 = new MetroFramework.Controls.MetroTextBox();
            this.lbidnhanvien = new MetroFramework.Controls.MetroLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lbwelcome);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.button24);
            this.metroPanel1.Controls.Add(this.lbmatkhau);
            this.metroPanel1.Controls.Add(this.textBox7);
            this.metroPanel1.Controls.Add(this.textBox6);
            this.metroPanel1.Controls.Add(this.lbidnhanvien);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(203, 129);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(471, 220);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbwelcome
            // 
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Location = new System.Drawing.Point(74, 18);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(346, 19);
            this.lbwelcome.TabIndex = 8;
            this.lbwelcome.Text = "Chào mừng đến với phần mềm quản lý cửa hàng đồ chơi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.login_icon_3058;
            this.pictureBox1.Location = new System.Drawing.Point(24, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(327, 163);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 2;
            this.button24.Text = "Đăng nhập";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(148, 112);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(63, 19);
            this.lbmatkhau.TabIndex = 5;
            this.lbmatkhau.Text = "Mật khẩu";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(242, 112);
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '*';
            this.textBox7.Size = new System.Drawing.Size(208, 23);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(242, 69);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(208, 23);
            this.textBox6.TabIndex = 0;
            // 
            // lbidnhanvien
            // 
            this.lbidnhanvien.AutoSize = true;
            this.lbidnhanvien.Location = new System.Drawing.Point(148, 69);
            this.lbidnhanvien.Name = "lbidnhanvien";
            this.lbidnhanvien.Size = new System.Drawing.Size(85, 19);
            this.lbidnhanvien.TabIndex = 2;
            this.lbidnhanvien.Text = "ID Nhân Viên";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(26, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(565, 37);
            this.label18.TabIndex = 6;
            this.label18.Text = "Phần mềm quản lí cửa hàng đồ chơi";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label18);
            this.Name = "login";
            this.Size = new System.Drawing.Size(883, 522);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbwelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton button24;
        private MetroFramework.Controls.MetroLabel lbmatkhau;
        private MetroFramework.Controls.MetroTextBox textBox7;
        private MetroFramework.Controls.MetroTextBox textBox6;
        private MetroFramework.Controls.MetroLabel lbidnhanvien;
        private System.Windows.Forms.Label label18;
    }
}
