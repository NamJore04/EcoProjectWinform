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


namespace EcoProject.Nhap_lieu
{
    public partial class hien_truong_nuoc_mat : Form
    {
        DataProvider provider = new DataProvider();

        public hien_truong_nuoc_mat(string selectedLoaiMau, string selectedMaDonHang, bool IsEditMode, string currentViTriLayMau)
        {
            InitializeComponent();
            loai_mau = selectedLoaiMau;
            maDonHang = selectedMaDonHang;
            edit = IsEditMode;
            viTri = currentViTriLayMau;
        }

        public string maDonHang { get; set; }
        public string loai_mau { get; set; }
        public bool edit { get; set; }
        public string viTri { get; set; }

        private void savechange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vi_tri_lay_mau.Text) || string.IsNullOrEmpty(BoxDO.Text) || string.IsNullOrEmpty(BoxpH.Text) 
                || string.IsNullOrEmpty(BoxTDS.Text) || string.IsNullOrEmpty(TB_nhiet_do.Text))
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

                string nuocMatQuery = "INSERT INTO NuocMat (ViTriLayMau, DO, pH, TDS, NhietDo, MaDH, MaNV) VALUES ( @ViTriLayMau , @DO , @pH , @TDS , @NhietDo , @MaDH , @MaNV )";
                result = provider.ExecuteNonQuery(nuocMatQuery, new object[] {
        vi_tri_lay_mau.Text,
        BoxDO.Text,
        BoxpH.Text,
        BoxTDS.Text,
        TB_nhiet_do.Text,
        maDonHang,
        nhan_vien
    });
            }
            else
            {
                // Trường hợp Cập nhật: Xóa bản ghi cũ và thêm bản ghi mới
                string deleteQuery = "DELETE FROM ChiTieuNuocMat WHERE MaDH = @MaDH AND ViTriLayMau = @OldViTriLayMau ";
                provider.ExecuteNonQuery(deleteQuery, new object[] { maDonHang, viTri });

                deleteQuery = "DELETE FROM NuocMat WHERE MaDH = @MaDH AND ViTriLayMau = @OldViTriLayMau ";
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

                string nuocMatQuery = "INSERT INTO NuocMat (ViTriLayMau, DO, pH, TDS, NhietDo, MaDH, MaNV) VALUES ( @ViTriLayMau , @DO , @pH , @TDS , @NhietDo , @MaDH , @MaNV )";
                result = provider.ExecuteNonQuery(nuocMatQuery, new object[] {
        vi_tri_lay_mau.Text,
        BoxDO.Text,
        BoxpH.Text,
        BoxTDS.Text,
        TB_nhiet_do.Text,
        maDonHang,
        nhan_vien
    });
            }

            // Đóng form hiện tại và hiển thị lại form uc_lab_analysis_management1
            uc_lab_analysis_management1 uc_lab_analysis_management1 = new uc_lab_analysis_management1();
            ((dashboard)this.ParentForm).ShowUserControlOnPanel(uc_lab_analysis_management1);
        }
    }
}
