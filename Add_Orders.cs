using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoProject.DAO;

namespace EcoProject
{
    public partial class Add_Orders : Form
    {
        DataProvider dp = new DataProvider();
        public Add_Orders()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true; 
            this.Show();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            //this.
            this.WindowState = FormWindowState.Minimized; // Thu nhỏ form hiện tại

        }

        private void ThemDonHang(object sender, EventArgs e)
        {
            foreach(Control item in panelOrder.Controls)
            {
                if (item.Text == "")
                {
                    item.Focus();
                    return;
                }
            }
            DateTime ngaytraketqua = DateTime.Parse(traketqua.Text);
            DateTime laymau = DateTime.Parse(ngaylaymau.Text);
            TimeSpan day = ngaytraketqua.Subtract(laymau);
            while (true) {
                if (day.Days < 10 || day.Days > 15)
                {
                    MessageBox.Show("Ngày trả kết quả phải nằm trong khoảng thời gian từ 10 đến 15 ngày!");
                    traketqua.Focus();
                    return;
                }
                break;
            }
            try
            {
                string makh = (string)dp.ExecuteScalar("select MaKH from KhachHang where TenCongTy = @tencongty", new object[] { tenkhachhang.Text });
                string query_them_DonHang = "insert into DonHang (NgayKetThucHD, NgayKyHD, MaKH) values( @ngayketthuc , @ngayky , @makh )";
                dp.ExecuteNonQuery(query_them_DonHang, new object[]
                {
                    traketqua.Value,
                    ngaydathang.Value,
                    makh
                });
                string query_them_DuLieuKiemDinh = "insert into DuLieuKiemDinh (MaNV, Quy, HanTraHang, NgayLayMau, MaDH, TrangThai) values ( @manv , @quy , @hantrahang , @ngaylaymau , (select top 1 MaDH from DonHang order by MaDH desc), N'Đang lấy mẫu' )";
                dp.ExecuteNonQuery(query_them_DuLieuKiemDinh, new object[] 
                {
                    nhanvien.Text,
                    quy.Text,
                    traketqua.Value,
                    ngaylaymau.Value
                });
                MessageBox.Show("Bạn đã thêm đơn hàng thành công!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Add_Orders_Load(object sender, EventArgs e)
        {

        }

        private void ngaylaymau_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
