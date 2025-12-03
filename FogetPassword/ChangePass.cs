using EcoProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoProject.FogetPassword
{

    public partial class doi_mat_khau : Form
    {
        DataProvider dataProvider = new DataProvider();

        public string MaNV { get; set; } // Thuộc tính lưu mã nhân viên
        public dashboard dashboard { get; set; }
        public doi_mat_khau()
        {
            InitializeComponent();

        }
        public doi_mat_khau(string MaNV, dashboard Dashboard) : this()
        {
            this.dashboard = Dashboard;
            this.MaNV = MaNV;
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
            this.Show();
        }


        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //dashboard.BringToFront();
        }

        private void Btn_Return(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Mini(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Btn_Doi_Mat_Khau_Click(object sender, EventArgs e)
        {
            //trả về số dòng có mã nhân viên và mật khẩu match với nhau
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV ";

            //trả về tổng số hàng thỏa điều kiện query
            //ExecuteScalar chỉ trả về một giá trị duy nhất, trong trường hợp này là số lượng tài khoản khớp (1 hoặc 0).
            int result = (int)dataProvider.ExecuteScalar(query, new object[] { this.MaNV});

            //trả về 1 nếu tồn tại mã nhân viên cùng với mật khẩu được nhập trong khung textbox
            if (result == 1)
            {

                if (TB_Mat_Khau_Moi.Text == TB_Xac_Nhan_Mat_Khau.Text)
                {
                    string query_update = "update NhanVien set MatKhau = @MatKhauMoi where MaNV = @MaNV";
                    dataProvider.ExecuteNonQuery(query_update, new object[] { TB_Mat_Khau_Moi.Text, this.MaNV });
                    this.dashboard.Close();
                    Form1 form = new Form1();
                    form.Show();
                    this.Close();

                    //Form1 form1 = new Form1();
                    //form1.Show();
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận lại không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu cũ");
            }
        }
    }
}
