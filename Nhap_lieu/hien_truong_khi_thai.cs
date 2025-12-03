using EcoProject.DAO;
using EcoProject.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoProject.Nhap_lieu
{
    public partial class hien_truong_khi_thai : Form
    {
        DataProvider provider = new DataProvider(); 

        public hien_truong_khi_thai(string selectedLoaiMau, string selectedMaDonHang, bool IsEditMode, string currentViTriLayMau)
        {
            InitializeComponent();
            loai_mau = selectedLoaiMau;
            maDonHang = selectedMaDonHang;
            edit = IsEditMode;
            viTri = currentViTriLayMau;
        }
        
        public string maDonHang { get ; set; }
        public string loai_mau { get; set; }
        public bool edit { get; set; }
        public string viTri { get; set; }


        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void savechange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vi_tri_lay_mau.Text) || string.IsNullOrEmpty(TB_SO2.Text) ||
    string.IsNullOrEmpty(BoxNO2.Text) || string.IsNullOrEmpty(BoxPM.Text) || string.IsNullOrEmpty(TB_nhiet_do.Text))
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

                string khiThaiQuery = "INSERT INTO KhiThai (ViTriLayMau, SO2, NO2, PM, NhietDo, MaNV, MaDH) VALUES ( @ViTriLayMau , @SO2 , @NO2 , @PM , @NhietDo , @MaNV , @MaDH )";
                result = provider.ExecuteNonQuery(khiThaiQuery, new object[] {
            vi_tri_lay_mau.Text,
            TB_SO2.Text,
            BoxNO2.Text,
            BoxPM.Text,
            TB_nhiet_do.Text,
            nhan_vien,
            maDonHang
        });
            }
            else
            {
                // Trường hợp Cập nhật: Xóa bản ghi cũ và thêm bản ghi mới
                string deleteQuery = "DELETE FROM ChiTieuKhiThai WHERE MaDH = @MaDH AND ViTriLayMau = @OldViTriLayMau ";
                provider.ExecuteNonQuery(deleteQuery, new object[] {  maDonHang , viTri });

                deleteQuery = "DELETE FROM KhiThai WHERE MaDH = @MaDH AND ViTriLayMau = @OldViTriLayMau ";
                provider.ExecuteNonQuery(deleteQuery, new object[] { maDonHang, viTri });

                deleteQuery = "DELETE FROM Mau WHERE MaDH = @MaDH AND ViTriLayMau = @OldViTriLayMau ";
                provider.ExecuteNonQuery(deleteQuery, new object[] { maDonHang , viTri});



                // Thêm lại bản ghi mới với giá trị ViTriLayMau đã cập nhật
                string mauQuery = "INSERT INTO Mau (ViTriLayMau, MaDH, MaNV, LoaiMau, Trangthai) VALUES ( @ViTriLayMau , @MaDH , @MaNV , @LoaiMau , @Trangthai )";
                int mauResult = provider.ExecuteNonQuery(mauQuery, new object[] {
            vi_tri_lay_mau.Text,
            maDonHang,
            nhan_vien,
            loai_mau,
            "Đang xử lý mẫu"
        });

                string khiThaiQuery = "INSERT INTO KhiThai (ViTriLayMau, SO2, NO2, PM, NhietDo, MaNV, MaDH) VALUES ( @ViTriLayMau , @SO2 , @NO2 , @PM , @NhietDo , @MaNV , @MaDH )";
                result = provider.ExecuteNonQuery(khiThaiQuery, new object[] {
            vi_tri_lay_mau.Text,
            TB_SO2.Text,
            BoxNO2.Text,
            BoxPM.Text,
            TB_nhiet_do.Text,
            nhan_vien,
            maDonHang
        });
            }

            // Đóng form hiện tại và hiển thị lại form uc_lab_analysis_management1
            uc_lab_analysis_management1 uc_lab_analysis_management1 = new uc_lab_analysis_management1();
            ((dashboard)this.ParentForm).ShowUserControlOnPanel(uc_lab_analysis_management1);
        }

        private void vi_tri_lay_mau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
