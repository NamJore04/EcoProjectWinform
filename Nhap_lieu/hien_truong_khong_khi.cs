using System;
using EcoProject.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using EcoProject.user_control;

namespace EcoProject
{
    public partial class hien_truong_khong_khi : Form
    {
        DataProvider provider = new DataProvider();

        public hien_truong_khong_khi(string selectedLoaiMau, string selectedMaDonHang, bool IsEditMode, string currentViTriLayMau)
        {
            InitializeComponent();
            loai_mau = selectedLoaiMau;
            maDonHang = selectedMaDonHang;
            edit = IsEditMode;
            viTri = currentViTriLayMau;
        }
        public string maDonHang { get; set; }
        public string loai_mau { get; set; }
        public string viTri { get; set; }
        public bool edit { get; set; }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hien_truong_khong_khi_Load(object sender, EventArgs e)
        {

        }

        private void savechange_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu các trường bắt buộc đều có giá trị
            if (string.IsNullOrEmpty(vi_tri_lay_mau.Text) || string.IsNullOrEmpty(BoxPM2dot5.Text) ||
                string.IsNullOrEmpty(BoxCO.Text) || string.IsNullOrEmpty(BoxNO2.Text) || string.IsNullOrEmpty(TB_nhiet_do.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nhan_vien = SessionInfo.MaNV;
            int result;

            if (!edit)
            {
                // Trường hợp Thêm mới
                string mauQuery = "INSERT INTO Mau (ViTriLayMau, MaDH, MaNV, LoaiMau, Trangthai) VALUES ( @ViTriLayMau , @MaDH , @MaNV , @LoaiMau , @Trangthai )";
                int mauResult = provider.ExecuteNonQuery(mauQuery, new object[] {
        vi_tri_lay_mau.Text,
        maDonHang,
        nhan_vien,
        loai_mau,
        "Đang xử lý mẫu"
    });

                string khongKhiQuery = "INSERT INTO KhongKhi (ViTriLayMau, PM2dot5, CO, NO2, NhietDo, MaDH, MaNV) VALUES ( @ViTriLayMau , @PM2dot5 , @CO , @NO2 , @NhietDo , @MaDH , @MaNV )";
                result = provider.ExecuteNonQuery(khongKhiQuery, new object[] {
        vi_tri_lay_mau.Text,
        BoxPM2dot5.Text,
        BoxCO.Text,
        BoxNO2.Text,
        TB_nhiet_do.Text,
        maDonHang,
        nhan_vien
    });
            }
            else
            {

                // Trường hợp Cập nhật: Xóa bản ghi cũ và thêm bản ghi mới
                string deleteQuery = "DELETE FROM ChiTieuKK WHERE MaDH = @MaDH AND ViTriLayMau = @OldViTriLayMau ";
                provider.ExecuteNonQuery(deleteQuery, new object[] { maDonHang, viTri });

                deleteQuery = "DELETE FROM KhongKhi WHERE MaDH = @MaDH AND ViTriLayMau = @OldViTriLayMau ";
                provider.ExecuteNonQuery(deleteQuery, new object[] { maDonHang, viTri });

                deleteQuery = "DELETE FROM Mau WHERE MaDH = @MaDH AND ViTriLayMau = @OldViTriLayMau ";
                provider.ExecuteNonQuery(deleteQuery, new object[] { maDonHang, viTri });

                // Thêm lại bản ghi mới với giá trị ViTriLayMau đã cập nhật
                string mauQuery = "INSERT INTO Mau (ViTriLayMau, MaDH, MaNV, LoaiMau, Trangthai) VALUES ( @ViTriLayMau , @MaDH , @MaNV , @LoaiMau , @Trangthai )";
                int mauResult = provider.ExecuteNonQuery(mauQuery, new object[] {
        vi_tri_lay_mau.Text,
        maDonHang,
        nhan_vien,
        loai_mau,
        "Đang xử lý mẫu"
    });

                string khongKhiQuery = "INSERT INTO KhongKhi (ViTriLayMau, PM2dot5, CO, NO2, NhietDo, MaDH, MaNV) VALUES ( @ViTriLayMau , @PM2dot5 , @CO , @NO2 , @NhietDo , @MaDH , @MaNV )";
                result = provider.ExecuteNonQuery(khongKhiQuery, new object[] {
        vi_tri_lay_mau.Text,
        BoxPM2dot5.Text,
        BoxCO.Text,
        BoxNO2.Text,
        TB_nhiet_do.Text,
        maDonHang,
        nhan_vien
    });
            }

            // Đóng form hiện tại và chuyển sang uc_lab_analysis_management1
            uc_lab_analysis_management1 uc_lab_analysis_management1 = new uc_lab_analysis_management1();

            ((dashboard)this.ParentForm).ShowUserControlOnPanel(uc_lab_analysis_management1);

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
