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
    public partial class phan_tich_khi_thai : Form
    {
        DataProvider provider = new DataProvider();
        public event EventHandler FormClosedEvent;
        public phan_tich_khi_thai(string MaDH, string MaNV, string ViTriLayMau, bool IsEditMode)
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

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void savechange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_ap_suat.Text) || string.IsNullOrEmpty(TB_CO.Text) || string.IsNullOrEmpty(TB_H2S.Text) ||
                    string.IsNullOrEmpty(TB_NO.Text) || string.IsNullOrEmpty(BoxHg.Text) ||
                    string.IsNullOrEmpty(BoxNH3.Text) || string.IsNullOrEmpty(BoxO2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!edit)
            {
                // Cập nhật trạng thái
                string queryCapNhatTrangThai = "UPDATE Mau SET TrangThai = N'Đã hoàn thành' WHERE MaDH = @MaDH and ViTriLayMau = @ViTriLayMau ";
                int resultCapNhatTrangThai = provider.ExecuteNonQuery(queryCapNhatTrangThai, new object[] { currentMaDH, currentViTriLayMau });
            }


            // Chuyển đổi dữ liệu từ TextBox thành float
            //float apSuat, co, h2s, o2, nh3, hg, no;
            //if (float.TryParse(TB_ap_suat.Text, out apSuat) &&
            //    float.TryParse(TB_CO.Text, out co) &&
            //    float.TryParse(TB_H2S.Text, out h2s) &&
            //    float.TryParse(BoxO2.Text, out o2) &&
            //    float.TryParse(BoxNH3.Text, out nh3) &&
            //    float.TryParse(BoxHg.Text, out hg) &&
            //    float.TryParse(TB_NO.Text, out no))
            //{
                //MessageBox.Show(apSuat + " " + co + " " + h2s + " " + o2 + " " + nh3 + " " + hg + " " + no);

                // Cập nhật bảng KhiThai (có thể thay đổi theo các trường phù hợp với cơ sở dữ liệu)
            string query = "UPDATE KhiThai SET ApSuat = @ApSuat , CO = @CO , H2S = @H2S , O2 = @O2 , NH3 = @NH3 , Hg = @Hg , N_O = @N_O WHERE MaDH = @MaDH AND ViTriLayMau = @ViTriLayMau  ";
            int result = provider.ExecuteNonQuery(query, new object[] { TB_ap_suat.Text, TB_CO.Text, TB_H2S.Text, BoxO2.Text, BoxNH3.Text, BoxHg.Text, TB_NO.Text, currentMaDH, currentViTriLayMau });


            // Thực hiện câu lệnh UPDATE


            if (result == 0)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                //return;
                //FormClosedEvent?.Invoke(this, EventArgs.Empty);
                //this.Close();
                //uc_lab_analysis_management1 uc_lab_analysis_management1 = new uc_lab_analysis_management1();
                chi_tieu_khi_thai chi_tieu_khi_thai = new chi_tieu_khi_thai(currentViTriLayMau, currentMaDH);
                ((dashboard)this.ParentForm).ShowFormOnPanel(chi_tieu_khi_thai);

            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đúng định dạng số cho các trường ApSuat, CO, H2S, O2, NH3, Hg, NO.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
