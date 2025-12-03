using EcoProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoProject
{
    public partial class Update_customer : Form
    {
        public string MaKH { get; set; }
        public string NguoiDaiDien { get; set; }
        public string TenCongTy { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string NganhCongNghiep { get; set; }
        public string SDT { get; set; }
        public string GhiChu { get; set; }

        //public Update_customer() { }
        public Update_customer(string MaKH, string NguoiDaiDien, string TenCongTy, string Email, string DiaChi, string NganhCongNghiep, string SDT, string GhiChu)
        {
            InitializeComponent();
            this.MaKH = MaKH;
            this.NguoiDaiDien = NguoiDaiDien;
            this.TenCongTy = TenCongTy;
            this.Email = Email;
            this.DiaChi = DiaChi;
            this.NganhCongNghiep = NganhCongNghiep;
            this.SDT = SDT;
            this.GhiChu = GhiChu;
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
            this.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool KiemTraEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        private bool KiemTraSDT(string phoneNumber)
        {
            string pattern = @"^0\d{9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            string email = TextMail.Text;
            string sdt = TextSDT.Text;

            if (string.IsNullOrWhiteSpace(TextTenCT.Text) || string.IsNullOrWhiteSpace(TextNguoiDD.Text) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(TextDiaChi.Text) || string.IsNullOrWhiteSpace(TextNganhCN.Text))
            {
                label_loi_tt.Visible = true;
            }
            else
            {
                label_loi_tt.Visible = false;
                bool isEmailValid = KiemTraEmail(email);
                bool isSDTValid = KiemTraSDT(sdt);

                label_loi_email.Visible = false;
                label_loi_sdt.Visible = false;

                if (!isEmailValid && !isSDTValid)
                {
                    label_loi_email.Visible = true;
                    label_loi_sdt.Visible = true;
                    TextMail.Focus();
                }
                else if (!isEmailValid)
                {
                    label_loi_email.Visible = true;
                    TextMail.Focus();
                }
                else if (!isSDTValid)
                {
                    label_loi_sdt.Visible = true;
                    TextSDT.Focus();
                }
                else
                {
                    string query = "UPDATE KhachHang SET NguoiDaiDien = @NguoiDaiDien , TenCongTy = @TenCongTy , Email = @Email , DiaChi = @DiaChi , NganhCongNghiep = @NganhCongNghiep , SDT = @SDT , GhiChu = @GhiChu WHERE MaKH = @MaKH";

                    DataProvider provider = new DataProvider();

                    int row = provider.ExecuteNonQuery(query, new object[] { TextNguoiDD.Text, TextTenCT.Text, email, TextDiaChi.Text, TextNganhCN.Text, sdt, TextGhiChu.Text, MaKH });

                    if (row == 0)
                    {
                        MessageBox.Show("Thông tin khách hàng đã được sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi sửa thông tin khách hàng!");
                    }
                }
            }
        }

        private void Update_customer_Load(object sender, EventArgs e)
        {
            TextNguoiDD.Text = NguoiDaiDien;
            TextTenCT.Text = TenCongTy;
            TextMail.Text = Email;
            TextDiaChi.Text = DiaChi;
            TextNganhCN.Text = NganhCongNghiep;
            TextSDT.Text = SDT;
            TextGhiChu.Text = GhiChu;
        }
    }
}
