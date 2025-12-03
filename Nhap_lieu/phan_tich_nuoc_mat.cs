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
using static Guna.UI2.Native.WinApi;
using EcoProject.user_control;
using EcoProject.Nhap_lieu;

namespace EcoProject
{
    public partial class phan_tich_nuoc_mat : Form
    {
        DataProvider provider = new DataProvider();
        public phan_tich_nuoc_mat(string MaDH, string MaNV, string ViTriLayMau, bool IsEditMode)
        {
            InitializeComponent();
            currentMaDH = MaDH;
            currentMaNV = MaNV;
            currentViTriLayMau = ViTriLayMau;
            edit = IsEditMode;
        }
        public string currentMaDH { get; set; }
        public string currentMaNV { get; set; }
        public string currentViTriLayMau { get; set; }
        public bool edit { get; set; }



        private void savechange_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_NH4.Text) || string.IsNullOrEmpty(TB_NO3.Text) || string.IsNullOrEmpty(TB_PO4.Text) ||
    string.IsNullOrEmpty(TB_tongN.Text) || string.IsNullOrEmpty(TB_TSS.Text) || string.IsNullOrEmpty(BoxCOD.Text) ||
    string.IsNullOrEmpty(BoxTOC.Text) || string.IsNullOrEmpty(BoxtongP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật trạng thái
            if(!edit)
            {
                string queryCapNhatTrangThai = "UPDATE Mau SET TrangThai = N'Đã hoàn thành' WHERE MaDH = @MaDH and ViTriLayMau = @ViTriLayMau ";
                int resultCapNhatTrangThai = provider.ExecuteNonQuery(queryCapNhatTrangThai, new object[] { currentMaDH, currentViTriLayMau });

            } 

            //// Chuyển đổi dữ liệu từ TextBox thành float
            //float nh4, no3, po4, cod, tss, tongN, toc, tongP;
            //if (float.TryParse(TB_NH4.Text, out nh4) &&
            //    float.TryParse(TB_NO3.Text, out no3) &&
            //    float.TryParse(TB_PO4.Text, out po4) &&
            //    float.TryParse(BoxCOD.Text, out cod) &&
            //    float.TryParse(TB_TSS.Text, out tss) &&
            //    float.TryParse(TB_tongN.Text, out tongN) &&
            //    float.TryParse(BoxTOC.Text, out toc) &&
            //    float.TryParse(BoxtongP.Text, out tongP))
            //{
                // Cập nhật bảng NuocMat (vì bảng KhongKhi không có các cột như NH4, NO3...)
                string query = "UPDATE NuocMat SET NH4 = @NH4 , NO3 = @NO3 , PO4 = @PO4 , COD = @COD , TSS = @TSS , tongN = @tongN , TOC = @TOC , tongP = @tongP WHERE MaDH = @MaDH AND ViTriLayMau = @ViTriLayMau ";
                int result = provider.ExecuteNonQuery(query, new object[] { TB_NH4.Text, TB_NO3.Text, TB_PO4.Text, BoxCOD.Text, TB_TSS.Text, TB_tongN.Text, BoxTOC.Text, BoxtongP.Text, currentMaDH, currentViTriLayMau });

            //    // Kiểm tra kết quả
            if (result == 0)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật thành công.");
                //uc_lab_analysis_management1 uc_lab_analysis_management1 = new uc_lab_analysis_management1();
                chi_tieu_nuoc_mat chi_tieu_nuoc_mat = new chi_tieu_nuoc_mat(currentMaDH, currentViTriLayMau);
                ((dashboard)this.ParentForm).ShowFormOnPanel(chi_tieu_nuoc_mat);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu cần cập nhật.");
            }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đúng định dạng số cho các trường NH4, NO3, PO4, COD, TSS, tongN, TOC và tongP.");
            //}
        }
    }
}
