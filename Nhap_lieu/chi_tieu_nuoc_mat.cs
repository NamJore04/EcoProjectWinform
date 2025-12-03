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

namespace EcoProject.Nhap_lieu
{

    public partial class chi_tieu_nuoc_mat : Form
    {
        DataProvider provider = new DataProvider();
        public chi_tieu_nuoc_mat(string maDonHang, string viTriLayMau)
        {
            InitializeComponent();
            currentMaDH = maDonHang;
            currentViTriLayMau = viTriLayMau;
        }
        public string currentMaDH { get; set; }
        public string currentViTriLayMau { get; set; }

        private void savechange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_NH4.Text) || string.IsNullOrEmpty(TB_NO3.Text) || string.IsNullOrEmpty(TB_PO4.Text) ||
string.IsNullOrEmpty(TB_tongN.Text) || string.IsNullOrEmpty(TB_TSS.Text) || string.IsNullOrEmpty(BoxCOD.Text) ||
string.IsNullOrEmpty(BoxTOC.Text) || string.IsNullOrEmpty(BoxtongP.Text) || string.IsNullOrEmpty(BoxDO.Text) || string.IsNullOrEmpty(BoxpH.Text)
                || string.IsNullOrEmpty(BoxTDS.Text) || string.IsNullOrEmpty(TB_nhiet_do.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                string queryCapNhatTrangThai = "UPDATE Mau SET Ketqua = N'Đạt yêu cầu' WHERE MaDH = @MaDH and ViTriLayMau = @ViTriLayMau ";
                int resultCapNhatTrangThai = provider.ExecuteNonQuery(queryCapNhatTrangThai, new object[] { currentMaDH, currentViTriLayMau });
                string query = "INSERT INTO ChiTieuNuocMat (ViTriLayMau, MaDH, MaNV, NH4, NO3, PO4, TongN, TSS, COD, TOC, TongP, DO, pH, TDS, NhietDo) VALUES ( @ViTriLayMau , @MaDH , @MaNV , @NH4 , @NO3 , @PO4 , @TongN , @TSS , @COD , @TOC , @TongP , @DO , @pH , @TDS , @NhietDo )";
                int result = provider.ExecuteNonQuery(query, new object[] {
                    currentViTriLayMau,
                    currentMaDH,
                    SessionInfo.MaNV,
                    TB_NH4.Text,
                    TB_NO3.Text,
                    TB_PO4.Text,
                    TB_tongN.Text,
                    TB_TSS.Text,
                    BoxCOD.Text,
                    BoxTOC.Text,
                    BoxtongP.Text,
                    BoxDO.Text,
                    BoxpH.Text,
                    BoxTDS.Text,
                    TB_nhiet_do.Text
                });
            }
        }
    }
}
