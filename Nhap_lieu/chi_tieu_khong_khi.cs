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

namespace EcoProject.Nhap_lieu
{
    public partial class chi_tieu_khong_khi : Form
    {
        DataProvider provider = new DataProvider();

        public chi_tieu_khong_khi(string maDonHang, string viTriLayMau)
        {
            InitializeComponent();
            currentMaDH = maDonHang;
            currentViTriLayMau = viTriLayMau;
        }
        public string currentMaDH { get; set; }
        public string currentViTriLayMau { get; set; }

        private void savechange_Click(object sender, EventArgs e)
        {
            string nhanvien = SessionInfo.MaNV;
            if (string.IsNullOrEmpty(BoxPM2dot5.Text) ||
             string.IsNullOrEmpty(BoxCO.Text) || string.IsNullOrEmpty(BoxNO2.Text) || 
             string.IsNullOrEmpty(TB_nhiet_do.Text) || string.IsNullOrEmpty(TB_PM10.Text) || 
             string.IsNullOrEmpty(TB_SO2.Text) || string.IsNullOrEmpty(BoxO3.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string queryCapNhatTrangThai = "UPDATE Mau SET Ketqua = N'Đạt yêu cầu' WHERE MaDH = @MaDH and ViTriLayMau = @ViTriLayMau ";
                int resultCapNhatTrangThai = provider.ExecuteNonQuery(queryCapNhatTrangThai, new object[] { currentMaDH, currentViTriLayMau });
                string chiTieuKhongKhiQuery = "INSERT INTO ChiTieuKK (ViTriLayMau, MaDH, MaNV, PM2dot5, CO, NO2, NhietDo, PM10, SO2, O3) VALUES ( @ViTriLayMau , @MaDH , @MaNV , @PM2dot5 , @CO , @NO2 , @NhietDo , @PM10 , @SO2 , @O3 )";
                int result = provider.ExecuteNonQuery(chiTieuKhongKhiQuery, new object[] { currentViTriLayMau, currentMaDH, nhanvien, BoxPM2dot5.Text, BoxCO.Text, BoxNO2.Text, TB_nhiet_do.Text, TB_PM10.Text, TB_SO2.Text, BoxO3.Text });

                MessageBox.Show("Dữ liệu đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
