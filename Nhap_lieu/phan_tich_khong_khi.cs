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
using EcoProject.user_control;
using EcoProject.Nhap_lieu; 

namespace EcoProject
{
    public partial class phan_tich_khong_khi : Form
    {
        DataProvider provider = new DataProvider();

        public phan_tich_khong_khi(string MaDH, string MaNV, string ViTriLayMau, bool IsEditMode)
        {
            InitializeComponent();
            currentMaDH = MaDH;
            currentMaNV = MaNV;
            currentViTriLayMau = ViTriLayMau;
            edit = IsEditMode;
            //MessageBox.Show(this.currentMaDH + " " + this.currentViTriLayMau + " " + this.currentMaNV);

        }
        public string currentMaDH { get; set; }
        public string currentMaNV { get; set; }
        public string currentViTriLayMau { get; set; }
        public bool edit { get; set; }


        private void savechange_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trường nào trống hay không
            if (string.IsNullOrEmpty(TB_PM10.Text) || string.IsNullOrEmpty(TB_SO2.Text) || string.IsNullOrEmpty(BoxO3.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (edit)
            {
                // Cập nhật trạng thái
                string queryCapNhatTrangThai = "UPDATE Mau SET TrangThai = N'Đang xử lý mẫu' WHERE MaDH = @MaDH and ViTriLayMau = @ViTriLayMau ";
                int resultCapNhatTrangThai = provider.ExecuteNonQuery(queryCapNhatTrangThai, new object[] { currentMaDH, currentViTriLayMau });
            }
            else
            {
                // Cập nhật trạng thái
                string queryCapNhatTrangThai = "UPDATE Mau SET TrangThai = N'Đã hoàn thành' WHERE MaDH = @MaDH and ViTriLayMau = @ViTriLayMau ";
                int resultCapNhatTrangThai = provider.ExecuteNonQuery(queryCapNhatTrangThai, new object[] { currentMaDH, currentViTriLayMau });
            }

            // Chuyển đổi dữ liệu từ TextBox thành float
            //float pm10, so2, o3;
            //if (float.TryParse(TB_PM10.Text, out pm10) &&
            //    float.TryParse(TB_SO2.Text, out so2) &&
            //    float.TryParse(BoxO3.Text, out o3))
            //{
                // Cập nhật bảng KhongKhi với các giá trị nhập từ người dùng
                string query = "UPDATE KhongKhi SET PM10 = @PM10 , SO2 = @SO2 , O3 = @O3 WHERE MaDH = @MaDH AND ViTriLayMau = @ViTriLayMau ";

                // Thực hiện câu lệnh UPDATE
                int result = provider.ExecuteNonQuery(query, new object[] { TB_PM10.Text, TB_SO2.Text, BoxO3.Text, currentMaDH, currentViTriLayMau });
            //    // Kiểm tra kết quả và thông báo cho người dùng
            if (result == 0)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //uc_lab_analysis_management1 uc_lab_analysis_management1 = new uc_lab_analysis_management1();
                chi_tieu_khong_khi chi_tieu_khong_khi = new chi_tieu_khong_khi(currentMaDH, currentViTriLayMau);
                ((dashboard)this.ParentForm).ShowFormOnPanel(chi_tieu_khong_khi);
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            //else
            //{
            //    // Nếu có lỗi trong việc chuyển đổi giá trị từ TextBox
            //    MessageBox.Show("Vui lòng nhập đúng định dạng số cho các trường PM10, SO2, O3.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
