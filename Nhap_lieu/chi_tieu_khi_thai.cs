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
    public partial class chi_tieu_khi_thai : Form
    {
        DataProvider provider = new DataProvider();

        public chi_tieu_khi_thai(string viTriLayMau, string maDongHang)
        {
            InitializeComponent();
            vi_tri_lay_mau = viTriLayMau;
            ma_dong_hang = maDongHang;
        }
        private string vi_tri_lay_mau { get; set; }
        private string ma_dong_hang { get; set; }

        private void savechange_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TB_ap_suat.Text) || string.IsNullOrEmpty(TB_CO.Text) || string.IsNullOrEmpty(TB_H2S.Text) ||
        string.IsNullOrEmpty(TB_NO.Text) || string.IsNullOrEmpty(BoxHg.Text) ||
        string.IsNullOrEmpty(BoxNH3.Text) || string.IsNullOrEmpty(BoxO2.Text) || string.IsNullOrEmpty(TB_SO2.Text) ||
        string.IsNullOrEmpty(BoxNO2.Text) || string.IsNullOrEmpty(BoxPM.Text) || string.IsNullOrEmpty(TB_nhiet_do.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật trạng thái
            string queryCapNhatTrangThai = "UPDATE Mau SET Ketqua = N'Đạt yêu cầu' WHERE MaDH = @MaDH and ViTriLayMau = @ViTriLayMau ";
            int resultCapNhatTrangThai = provider.ExecuteNonQuery(queryCapNhatTrangThai, new object[] { ma_dong_hang, vi_tri_lay_mau });

            // Chuyển đổi dữ liệu từ TextBox thành float
            //float apSuat, co, h2s, o2, nh3, hg, no;
            //if (float.TryParse(TB_ap_suat.Text, out apSuat) &&
            //    float.TryParse(TB_CO.Text, out co) &&
            //    float.TryParse(TB_H2S.Text, out h2s) &&
            //    float.TryParse(BoxO2.Text, out o2) &&
            //    float.TryParse(BoxNH3.Text, out nh3) &&
            //    float.TryParse(BoxHg.Text, out hg) &&
            //    float.TryParse(TB_NO.Text, out no))
            //float apSuat, co, h2s, o2, nh3, hg, no, so2, no2, pm, nhietDo;
            //if (float.TryParse(TB_ap_suat.Text, out apSuat) &&
            //    float.TryParse(TB_CO.Text, out co) &&
            //    float.TryParse(TB_H2S.Text, out h2s) &&
            //    float.TryParse(BoxO2.Text, out o2) &&
            //    float.TryParse(BoxNH3.Text, out nh3) &&
            //    float.TryParse(BoxHg.Text, out hg) &&
            //    float.TryParse(TB_NO.Text, out no) &&
            //    float.TryParse(TB_SO2.Text, out so2) &&
            //    float.TryParse(BoxNO2.Text, out no2) &&
            //    float.TryParse(BoxPM.Text, out pm) &&
            //    float.TryParse(TB_nhiet_do.Text, out nhietDo)
            string nhavien = SessionInfo.MaNV;
            string chiTieuQuery = "INSERT INTO ChiTieuKhiThai (ViTriLayMau, MaDH, MaNV, ApSuat, CO, H2S, O2, NH3, Hg, N_O, SO2, NO2, PM, NhietDo) VALUES ( @ViTriLayMau , @MaDH , @MaNV , @ApSuat , @CO , @H2S , @O2 , @NH3 , @Hg , @NO , @SO2 , @NO2 , @PM , @NhietDo )";
            int result = provider.ExecuteNonQuery(chiTieuQuery, new object[] { vi_tri_lay_mau, ma_dong_hang, nhavien , TB_ap_suat.Text, TB_CO.Text, TB_H2S.Text, BoxO2.Text, BoxNH3.Text, BoxHg.Text, TB_NO.Text, TB_SO2.Text, BoxNO2.Text, BoxPM.Text, TB_nhiet_do.Text });
            if (result == 0) {
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                uc_lab_analysis_management1 uc_lab_analysis_management1 = new uc_lab_analysis_management1();
                ((dashboard)this.ParentForm).ShowUserControlOnPanel(uc_lab_analysis_management1);

            }
        }
    }
}
