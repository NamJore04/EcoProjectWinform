namespace EcoProject.user_control
{
    partial class uc_customer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ThemKh = new Guna.UI2.WinForms.Guna2Button();
            this.TB_TimKimCTy = new Guna.UI2.WinForms.Guna2TextBox();
            this.TB_TimKiemDH = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ShowDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChonTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1289, 60);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(11, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(229, 28);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Quản Lý Khách Hàng";
            // 
            // ThemKh
            // 
            this.ThemKh.Animated = true;
            this.ThemKh.AutoRoundedCorners = true;
            this.ThemKh.BackColor = System.Drawing.Color.Transparent;
            this.ThemKh.BorderRadius = 16;
            this.ThemKh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ThemKh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ThemKh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ThemKh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ThemKh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.ThemKh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ThemKh.ForeColor = System.Drawing.Color.White;
            this.ThemKh.IndicateFocus = true;
            this.ThemKh.Location = new System.Drawing.Point(1086, 130);
            this.ThemKh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThemKh.Name = "ThemKh";
            this.ThemKh.Size = new System.Drawing.Size(196, 35);
            this.ThemKh.TabIndex = 2;
            this.ThemKh.Text = "Thêm Khách Hàng";
            this.ThemKh.UseTransparentBackground = true;
            this.ThemKh.Click += new System.EventHandler(this.Btn_Them_Khach_Hang);
            // 
            // TB_TimKimCTy
            // 
            this.TB_TimKimCTy.Animated = true;
            this.TB_TimKimCTy.AutoRoundedCorners = true;
            this.TB_TimKimCTy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(202)))), ((int)(((byte)(144)))));
            this.TB_TimKimCTy.BorderRadius = 16;
            this.TB_TimKimCTy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_TimKimCTy.DefaultText = "";
            this.TB_TimKimCTy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_TimKimCTy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_TimKimCTy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_TimKimCTy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_TimKimCTy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_TimKimCTy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_TimKimCTy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_TimKimCTy.Location = new System.Drawing.Point(38, 74);
            this.TB_TimKimCTy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_TimKimCTy.Name = "TB_TimKimCTy";
            this.TB_TimKimCTy.PasswordChar = '\0';
            this.TB_TimKimCTy.PlaceholderText = "Tìm kiếm theo tên công ty";
            this.TB_TimKimCTy.SelectedText = "";
            this.TB_TimKimCTy.Size = new System.Drawing.Size(288, 35);
            this.TB_TimKimCTy.TabIndex = 1;
            this.TB_TimKimCTy.TextChanged += new System.EventHandler(this.TimKiem);
            // 
            // TB_TimKiemDH
            // 
            this.TB_TimKiemDH.Animated = true;
            this.TB_TimKiemDH.AutoRoundedCorners = true;
            this.TB_TimKiemDH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(202)))), ((int)(((byte)(144)))));
            this.TB_TimKiemDH.BorderRadius = 16;
            this.TB_TimKiemDH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_TimKiemDH.DefaultText = "";
            this.TB_TimKiemDH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_TimKiemDH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_TimKiemDH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_TimKiemDH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_TimKiemDH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_TimKiemDH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_TimKiemDH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_TimKiemDH.Location = new System.Drawing.Point(38, 119);
            this.TB_TimKiemDH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_TimKiemDH.Name = "TB_TimKiemDH";
            this.TB_TimKiemDH.PasswordChar = '\0';
            this.TB_TimKiemDH.PlaceholderText = "Tìm kiếm theo mã đơn hàng";
            this.TB_TimKiemDH.SelectedText = "";
            this.TB_TimKiemDH.Size = new System.Drawing.Size(288, 35);
            this.TB_TimKiemDH.TabIndex = 2;
            this.TB_TimKiemDH.TextChanged += new System.EventHandler(this.TimKiem);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.ShowDanhSach);
            this.guna2Panel2.Location = new System.Drawing.Point(5, 38);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1244, 400);
            this.guna2Panel2.TabIndex = 3;
            // 
            // ShowDanhSach
            // 
            this.ShowDanhSach.AllowUserToAddRows = false;
            this.ShowDanhSach.AllowUserToDeleteRows = false;
            this.ShowDanhSach.AllowUserToOrderColumns = true;
            this.ShowDanhSach.AllowUserToResizeColumns = false;
            this.ShowDanhSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.ShowDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ShowDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ShowDanhSach.ColumnHeadersHeight = 27;
            this.ShowDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowDanhSach.DefaultCellStyle = dataGridViewCellStyle13;
            this.ShowDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowDanhSach.GridColor = System.Drawing.Color.Black;
            this.ShowDanhSach.Location = new System.Drawing.Point(0, 0);
            this.ShowDanhSach.Name = "ShowDanhSach";
            this.ShowDanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowDanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ShowDanhSach.RowHeadersVisible = false;
            this.ShowDanhSach.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.ShowDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.ShowDanhSach.RowTemplate.Height = 24;
            this.ShowDanhSach.Size = new System.Drawing.Size(1244, 400);
            this.ShowDanhSach.TabIndex = 0;
            this.ShowDanhSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowDanhSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ShowDanhSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ShowDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ShowDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ShowDanhSach.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ShowDanhSach.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.ShowDanhSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ShowDanhSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ShowDanhSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDanhSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ShowDanhSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ShowDanhSach.ThemeStyle.HeaderStyle.Height = 27;
            this.ShowDanhSach.ThemeStyle.ReadOnly = false;
            this.ShowDanhSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowDanhSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ShowDanhSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDanhSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ShowDanhSach.ThemeStyle.RowsStyle.Height = 24;
            this.ShowDanhSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowDanhSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ShowDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDanhSach_CellClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2Panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1256, 442);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH CÁC CÔNG TY";
            // 
            // ChonTinh
            // 
            this.ChonTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonTinh.FormattingEnabled = true;
            this.ChonTinh.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa – Vũng Tàu",
            "Bạc Liêu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Hồ Chí Minh",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.ChonTinh.Location = new System.Drawing.Point(360, 74);
            this.ChonTinh.Name = "ChonTinh";
            this.ChonTinh.Size = new System.Drawing.Size(308, 30);
            this.ChonTinh.TabIndex = 12;
            this.ChonTinh.Text = "Chọn tỉnh";
            this.ChonTinh.TextChanged += new System.EventHandler(this.TimKiem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Click vào dòng dữ liệu để sửa thông tin khách hàng.";
            // 
            // uc_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChonTinh);
            this.Controls.Add(this.ThemKh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TB_TimKiemDH);
            this.Controls.Add(this.TB_TimKimCTy);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_customer";
            this.Size = new System.Drawing.Size(1309, 636);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button ThemKh;
        private Guna.UI2.WinForms.Guna2TextBox TB_TimKimCTy;
        private Guna.UI2.WinForms.Guna2TextBox TB_TimKiemDH;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView ShowDanhSach;
        private System.Windows.Forms.ComboBox ChonTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
