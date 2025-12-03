namespace EcoProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.check_mk = new System.Windows.Forms.Label();
            this.check_tk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Btn_QuenMk = new Guna.UI2.WinForms.Guna2Button();
            this.MK_DangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.TK_DangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_DangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.check_mk);
            this.guna2Panel1.Controls.Add(this.check_tk);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel1.Controls.Add(this.guna2CircleButton2);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel1.Controls.Add(this.Btn_QuenMk);
            this.guna2Panel1.Controls.Add(this.MK_DangNhap);
            this.guna2Panel1.Controls.Add(this.TK_DangNhap);
            this.guna2Panel1.Controls.Add(this.Btn_DangNhap);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Location = new System.Drawing.Point(14, 14);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1112, 690);
            this.guna2Panel1.TabIndex = 1;
            // 
            // check_mk
            // 
            this.check_mk.AutoSize = true;
            this.check_mk.Location = new System.Drawing.Point(612, 525);
            this.check_mk.Name = "check_mk";
            this.check_mk.Size = new System.Drawing.Size(51, 20);
            this.check_mk.TabIndex = 13;
            this.check_mk.Text = "label4";
            // 
            // check_tk
            // 
            this.check_tk.AutoSize = true;
            this.check_tk.Location = new System.Drawing.Point(612, 362);
            this.check_tk.Name = "check_tk";
            this.check_tk.Size = new System.Drawing.Size(51, 20);
            this.check_tk.TabIndex = 13;
            this.check_tk.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 55);
            this.label3.TabIndex = 12;
            this.label3.Text = "ĐĂNG NHẬP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(611, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật Khẩu";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(611, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tài Khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.BackColor = System.Drawing.Color.White;
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.White;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.IndicateFocus = true;
            this.guna2CircleButton1.Location = new System.Drawing.Point(22, 2);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(55, 55);
            this.guna2CircleButton1.TabIndex = 10;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.Animated = true;
            this.guna2CircleButton2.BackColor = System.Drawing.Color.White;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton2.IndicateFocus = true;
            this.guna2CircleButton2.Location = new System.Drawing.Point(84, 2);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(55, 55);
            this.guna2CircleButton2.TabIndex = 3;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(84, 50);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(105, 116);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(186, -18);
            this.guna2CirclePictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(303, 245);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 5;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.UseTransparentBackground = true;
            // 
            // Btn_QuenMk
            // 
            this.Btn_QuenMk.Animated = true;
            this.Btn_QuenMk.AutoRoundedCorners = true;
            this.Btn_QuenMk.BackColor = System.Drawing.Color.Transparent;
            this.Btn_QuenMk.BorderRadius = 28;
            this.Btn_QuenMk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_QuenMk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_QuenMk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_QuenMk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_QuenMk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_QuenMk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_QuenMk.ForeColor = System.Drawing.Color.White;
            this.Btn_QuenMk.IndicateFocus = true;
            this.Btn_QuenMk.Location = new System.Drawing.Point(847, 574);
            this.Btn_QuenMk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_QuenMk.Name = "Btn_QuenMk";
            this.Btn_QuenMk.Size = new System.Drawing.Size(171, 58);
            this.Btn_QuenMk.TabIndex = 4;
            this.Btn_QuenMk.Text = "Quên Mật Khẩu";
            this.Btn_QuenMk.UseTransparentBackground = true;
            this.Btn_QuenMk.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // MK_DangNhap
            // 
            this.MK_DangNhap.Animated = true;
            this.MK_DangNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(202)))), ((int)(((byte)(144)))));
            this.MK_DangNhap.BorderRadius = 18;
            this.MK_DangNhap.BorderThickness = 2;
            this.MK_DangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MK_DangNhap.DefaultText = "";
            this.MK_DangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MK_DangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MK_DangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MK_DangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MK_DangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MK_DangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MK_DangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MK_DangNhap.Location = new System.Drawing.Point(604, 460);
            this.MK_DangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MK_DangNhap.Name = "MK_DangNhap";
            this.MK_DangNhap.PasswordChar = '●';
            this.MK_DangNhap.PlaceholderText = "Mật khẩu";
            this.MK_DangNhap.SelectedText = "";
            this.MK_DangNhap.Size = new System.Drawing.Size(414, 60);
            this.MK_DangNhap.TabIndex = 1;
            this.MK_DangNhap.UseSystemPasswordChar = true;
            // 
            // TK_DangNhap
            // 
            this.TK_DangNhap.Animated = true;
            this.TK_DangNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(202)))), ((int)(((byte)(144)))));
            this.TK_DangNhap.BorderRadius = 18;
            this.TK_DangNhap.BorderThickness = 2;
            this.TK_DangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TK_DangNhap.DefaultText = "";
            this.TK_DangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TK_DangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TK_DangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TK_DangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TK_DangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TK_DangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TK_DangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TK_DangNhap.Location = new System.Drawing.Point(604, 298);
            this.TK_DangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TK_DangNhap.Name = "TK_DangNhap";
            this.TK_DangNhap.PasswordChar = '\0';
            this.TK_DangNhap.PlaceholderText = "Tên đăng nhập";
            this.TK_DangNhap.SelectedText = "";
            this.TK_DangNhap.Size = new System.Drawing.Size(414, 60);
            this.TK_DangNhap.TabIndex = 0;
            // 
            // Btn_DangNhap
            // 
            this.Btn_DangNhap.Animated = true;
            this.Btn_DangNhap.AutoRoundedCorners = true;
            this.Btn_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.Btn_DangNhap.BorderRadius = 28;
            this.Btn_DangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_DangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_DangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_DangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_DangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_DangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.Btn_DangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_DangNhap.IndicateFocus = true;
            this.Btn_DangNhap.Location = new System.Drawing.Point(604, 574);
            this.Btn_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_DangNhap.Name = "Btn_DangNhap";
            this.Btn_DangNhap.Size = new System.Drawing.Size(171, 58);
            this.Btn_DangNhap.TabIndex = 2;
            this.Btn_DangNhap.Text = "Đăng Nhập";
            this.Btn_DangNhap.UseTransparentBackground = true;
            this.Btn_DangNhap.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 18;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(84, 152);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(390, 514);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.Btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(202)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1138, 714);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox TK_DangNhap;
        private Guna.UI2.WinForms.Guna2Button Btn_DangNhap;
        private Guna.UI2.WinForms.Guna2TextBox MK_DangNhap;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2Button Btn_QuenMk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label check_mk;
        private System.Windows.Forms.Label check_tk;
        //private FogetPassword.FogetPass FogetPass1;
    }
}

