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
    public partial class Add_customer : Form
    {
        DataProvider provider = new DataProvider();
        public Add_customer()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
            this.Show();
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

        private void Btn_Them_Khach_Hang_Click(object sender, EventArgs e)
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
                    string query = "INSERT INTO khachhang (NguoiDaiDien, TenCongTy, Email, DiaChi, NganhCongNghiep, SDT, GhiChu) " +
                                   "VALUES ( @NguoiDaiDien , @TenCongTy , @Email , @DiaChi , @NganhCongNghiep , @SDT , @GhiChu )";

                    DataProvider provider = new DataProvider();

                    int row = provider.ExecuteNonQuery(query, new object[] { TextNguoiDD.Text, TextTenCT.Text, email, TextDiaChi.Text, TextNganhCN.Text, sdt, TextGhiChu.Text });

                    if (row == 0)
                    {
                        MessageBox.Show("Khách hàng mới đã được thêm!");
                        TextTenCT.Clear();
                        TextNguoiDD.Clear();
                        TextMail.Clear();
                        TextSDT.Clear();
                        TextDiaChi.Clear();
                        TextNganhCN.Clear();
                        TextGhiChu.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm khách hàng!");
                    }
                }
            }
        }

        private void Btn_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
