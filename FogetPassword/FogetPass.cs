using EcoProject.DAO;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;
using EcoProject.DAO;
namespace EcoProject.FogetPassword
{
    public partial class FogetPass : Form
    {

        public string verificationCode;
        DataProvider dataProvider = new DataProvider();
        public FogetPass()
        {
            InitializeComponent();
            this.TopMost = true;
            
        }
        private void FogetPassword_Load(object sender, EventArgs e)
        {
            tb_ma_xac_nhan.Visible = true;
        }



    
        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại
            //Form1 form1 = new Form1();
            //form1.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void FogetPass_Load(object sender, EventArgs e)
        {
        }

        private async void Btn_Nhap_Mat_khau_Click(object sender, EventArgs e)
        {
            
        }

        private async void btn_gui_email_Click(object sender, EventArgs e)
        {
            // Tạo mã xác thực 6 chữ số ngẫu nhiên
            Random random = new Random();
            verificationCode = random.Next(100000, 999999).ToString();
            string email_nguoi_dung = TB_TK_Email.Text;

            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("EcoProject: ", "cnpmn25@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", email_nguoi_dung));
            emailMessage.Subject = "Mã xác thực của bạn";
            emailMessage.Body = new TextPart("plain") { Text = $"Mã xác thực của bạn là: {verificationCode}" };

            //Check email có trong database hay không
            //trả về số dòng có mã nhân viên và mật khẩu match với nhau
            string query = "SELECT COUNT(*) FROM NhanVien WHERE Email = @Email";

            //trả về tổng số hàng thỏa điều kiện query
            //ExecuteScalar chỉ trả về một giá trị duy nhất, trong trường hợp này là số lượng tài khoản khớp (1 hoặc 0).
            int result = (int)dataProvider.ExecuteScalar(query, new object[] { email_nguoi_dung });

            //trả về 1 nếu tồn tại mã nhân viên cùng với mật khẩu được nhập trong khung textbox
            if (result == 1)
            {
                try
                {
                    using (var client = new SmtpClient())
                    {
                        await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        client.Authenticate("cnpmn25@gmail.com", "pnrv yvqe bhtt lwdp");
                        await client.SendAsync(emailMessage);
                        await client.DisconnectAsync(true);
                    }

                    MessageBox.Show("Mã xác thực đã được gửi đến email của bạn.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gửi email không thành công: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Email không tồn tại");
            }
        }

        private void btn_doi_mat_khau(object sender, EventArgs e)
        {
            if (tb_ma_xac_nhan.Text == verificationCode)
            {
                string query_update = "update NhanVien set MatKhau = @MatKhauMoi where Email = @Email";

                dataProvider.ExecuteNonQuery(query_update, new object[] { tb_nhap_mat_khau.Text, TB_TK_Email.Text });

                Form1 form = new Form1();
                form.Show();
                this.Close();
            }
        }
    }
}
