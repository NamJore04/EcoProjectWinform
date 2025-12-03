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
using EcoProject;
using System.Data.SqlClient;
using EcoProject.Nhap_lieu;


namespace EcoProject.user_control
{
    
    public partial class uc_lab_analysis_management1 : UserControl
    {
        private string currentMaDH;
        private string currentViTriLayMau;
        private string currentMaNV;
        private string currentLoaiMau;
        DataProvider dataProvider = new DataProvider();
        public event EventHandler FormClosedEvent;
        public bool IsEditMode { get; set; }

        public uc_lab_analysis_management1()
        {
            InitializeComponent();
            LoadDonHang();
            LoadData();
            //Check_bbx_maDh_bbx_loaiMau();


        }

        private void uc_lab_analysis_management_Load(object sender, EventArgs e)
        {

        }

        private void Sua(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentMaDH) && !string.IsNullOrEmpty(currentMaNV) && !string.IsNullOrEmpty(currentViTriLayMau))
            {
                // Lấy thông tin từ cell click
                DataGridViewRow selectedRow = DGV_danh_sach_mau.SelectedRows[0];
                string selectedLoaiMau = selectedRow.Cells["Loại Mẫu"].Value.ToString();
                IsEditMode = true;

                // Kiểm tra nếu thông tin đã thay đổi


                Form formToDisplay;
                    switch (selectedLoaiMau)
                    {


                        case "Khí thải":
                            formToDisplay = new hien_truong_khi_thai(selectedLoaiMau, currentMaDH, IsEditMode, currentViTriLayMau);
                            break;
                        case "Không khí xung quanh":
                            formToDisplay = new hien_truong_khong_khi(selectedLoaiMau, currentMaDH, IsEditMode, currentViTriLayMau);
                            break;
                        case "Nước mặt":
                            formToDisplay = new hien_truong_nuoc_mat(selectedLoaiMau, currentMaDH, IsEditMode, currentViTriLayMau);
                            break;
                        default:
                            // Handle the case when an invalid value is selected
                            MessageBox.Show("Invalid value selected for CBB_loai_mau.");
                            return;
                    }
                ((dashboard)this.ParentForm).ShowFormOnPanel(formToDisplay);


            }
            else
            {
                // Hiển thị thông báo yêu cầu nhập đầy đủ thông tin
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }




        private void Btn_them_du_lieu_hien_truong_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve selected values from ComboBox controls
            string selectedMaDonHang = CBB_ma_don_hang.SelectedItem.ToString();
            string selectedLoaiMau = CBB_loai_mau.SelectedItem.ToString();
            currentViTriLayMau = "";

            

            // Step 2: Check if selectedMaDonHang exists in the database
            bool maDonHangExists = CheckMaDonHangExists(selectedMaDonHang);

            if (maDonHangExists)
            {
                // Step 3: Determine which form to display based on selectedLoaiMau
                Form formToDisplay;
                switch (selectedLoaiMau)
                {


                    case "Khí thải":
                        formToDisplay = new hien_truong_khi_thai(selectedLoaiMau, selectedMaDonHang, IsEditMode, currentViTriLayMau);
                        break;
                    case "Không khí xung quanh":
                        formToDisplay = new hien_truong_khong_khi(selectedLoaiMau, selectedMaDonHang, IsEditMode, currentViTriLayMau);
                        break;
                    case "Nước mặt":
                        formToDisplay = new hien_truong_nuoc_mat(selectedLoaiMau, selectedMaDonHang, IsEditMode, currentViTriLayMau);
                        break;
                    default:
                        // Handle the case when an invalid value is selected
                        MessageBox.Show("Invalid value selected for CBB_loai_mau.");
                        return;
                }

                //// Step 4: Set the position of the newly created form
                //formToDisplay.StartPosition = FormStartPosition.Manual;
                //formToDisplay.Location = this.Location;

                // Step 5: Show the form on the panel control (panel1) of the dashboard.cs
                ((dashboard)this.ParentForm).ShowFormOnPanel(formToDisplay);
            }
            else
            {
                MessageBox.Show("Selected MaDonHang does not exist in the database.");
            }
        }
        private bool CheckMaDonHangExists(string maDonHang)
        {
            string query = "SELECT COUNT(*) FROM DonHang WHERE MaDH = '" + maDonHang + "'";
            int count = (int)dataProvider.ExecuteScalar(query);
            //int count = dataProvider.;
            //MessageBox.Show(count.ToString());
            //MessageBox.Show(query);
            if (count > 0)
            {
                return true;
            }
            return false;

        }

        private void CBB_ma_don_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check_bbx_maDh_bbx_loaiMau();
        }
        private void LoadDonHang()
        {
            // Thực hiện truy vấn để lấy danh sách đơn hàng từ cơ sở dữ liệu
            string query = "SELECT MaDH FROM DonHang";
            DataTable dt = dataProvider.ExecuteQuery(query);

            // Xóa các mục hiện tại trong ComboBox
            CBB_ma_don_hang.Items.Clear();

            // Thêm các mã đơn hàng vào ComboBox
            foreach (DataRow row in dt.Rows)
            {
                string maDonHang = row["MaDH"].ToString();
                CBB_ma_don_hang.Items.Add(maDonHang);
            }
        }

        private void Check_bbx_maDh_bbx_loaiMau()
        {
            if (CBB_ma_don_hang.SelectedItem != null && CBB_loai_mau.SelectedItem != null)
            {
                Btn_them_du_lieu_hien_truong.Enabled = true;
                Btn_them_du_lieu_phan_tich.Enabled = false;
                Btn_sua_du_lieu_hien_truong.Enabled = false;
                Btn_sua_du_lieu_phan_tich.Enabled = false;
            }
        }

        //private void FormToDisplay_FormClosedEvent(object sender, EventArgs e)
        //{
        //    // Check if ParentForm is not null
        //    if (this.ParentForm != null)
        //    {
        //        // Hiển thị lại uc_lab_analysis_management trên panel của dashboard
        //        var dashboardForm = this.ParentForm as dashboard;
        //        if (dashboardForm != null)
        //        {
        //            dashboardForm.ShowUserControlOnPanel(this);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Parent form is not of type 'dashboard'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Parent form is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void Btn_them_du_lieu_phan_tich_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(currentMaDH);
            //MessageBox.Show(currentMaNV);
            //MessageBox.Show(currentViTriLayMau);
            IsEditMode = false;

            if (!string.IsNullOrEmpty(currentMaDH) && !string.IsNullOrEmpty(currentMaNV) && !string.IsNullOrEmpty(currentViTriLayMau))
            {
                Form formToDisplay = null;

                // Kiểm tra vị trí lấy mẫu và xác định form cần mở
                if (currentLoaiMau.Equals("Nước mặt"))
                {
                    //formToDisplay = new hien_truong_nuoc_mat(currentMaDH, currentMaNV);
                    formToDisplay = new phan_tich_nuoc_mat(currentMaDH, currentMaNV, currentViTriLayMau, IsEditMode);

                }
                else if (currentLoaiMau.Equals("Khí thải"))
                {
                    //formToDisplay = new hien_truong_khi_thai(currentMaDH, currentMaNV);
                    formToDisplay = new phan_tich_khi_thai(currentMaDH, currentMaNV, currentViTriLayMau, IsEditMode);

                }
                else
                {
                    //formToDisplay = new hien_truong_khong_khi(currentMaDH, currentMaNV);
                    formToDisplay = new phan_tich_khong_khi(currentMaDH, currentMaNV, currentViTriLayMau, IsEditMode);

                }

                // Hiển thị form đã được xác định
                if (formToDisplay != null)
                {
                    //formToDisplay.FormClosed += FormToDisplay_FormClosedEvent;
                    //formToDisplay.ShowDialog();
                    ((dashboard)this.ParentForm).ShowFormOnPanel(formToDisplay);

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Mã Đơn Hàng, Mã Nhân Viên và Vị Trí Lấy Mẫu.");
            }
        }

        private void LoadData()
        {
            // Step 1: Define the query to retrieve specific columns from the "Mau" table
            string query = "SELECT MaDH AS 'Mã Đơn Hàng', ViTriLayMau AS 'Vị Trí Lấy Mẫu', LoaiMau AS 'Loại Mẫu', Trangthai AS 'Trạng Thái', Ketqua AS 'Kết Quả' FROM Mau";

            // Step 2: Execute the query and retrieve the data
            DataTable data = dataProvider.ExecuteQuery(query);

            // Step 3: Display the data in the DataGridView control
            DGV_danh_sach_mau.DataSource = data;
        }

        private void DGV_danh_sach_mau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_chon_don_hang_de_nhap_phan_tich(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0) {
                DataGridViewRow selectedRow = DGV_danh_sach_mau.Rows[e.RowIndex];
                string maDonHang = selectedRow.Cells["Mã Đơn Hàng"].Value.ToString();
                string viTriLayMau = selectedRow.Cells["Vị Trí Lấy Mẫu"].Value.ToString();
                string trangThai = selectedRow.Cells["Trạng Thái"].Value.ToString();
                string ketQua = selectedRow.Cells["Kết Quả"].Value.ToString();
                string loaiMau = selectedRow.Cells["Loại Mẫu"].Value.ToString();

                currentMaDH = maDonHang;
                currentViTriLayMau = viTriLayMau;
                currentMaNV = SessionInfo.MaNV;         
                currentLoaiMau = loaiMau;
                //cur

                CBB_loai_mau.SelectedIndex = -1;
                CBB_ma_don_hang.SelectedIndex = -1;


                // Kiểm tra giá trị của cột "Trạng Thái"
                if (trangThai == "Đã hoàn thành")
                {
                    // Nếu trạng thái là "Đã hoàn thành", vô hiệu hóa các nút liên quan
                    Btn_them_du_lieu_hien_truong.Enabled = false;
                    Btn_them_du_lieu_phan_tich.Enabled = false;
                    Btn_sua_du_lieu_hien_truong.Enabled = true;
                    Btn_sua_du_lieu_phan_tich.Enabled = true;
                }
                else
                {
                    // Nếu trạng thái không phải là "Đã hoàn thành", bật tất cả các nút
                    Btn_them_du_lieu_hien_truong.Enabled = false;
                    Btn_them_du_lieu_phan_tich.Enabled = true;
                    Btn_sua_du_lieu_hien_truong.Enabled = false;
                    Btn_sua_du_lieu_phan_tich.Enabled = false;
                }
            }
        }

        private void Btn_sua_du_lieu_phan_tich_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            if (!string.IsNullOrEmpty(currentMaDH) && !string.IsNullOrEmpty(currentMaNV) && !string.IsNullOrEmpty(currentViTriLayMau))
            {
                Form formToDisplay = null;

                // Kiểm tra vị trí lấy mẫu và xác định form cần mở
                if (currentLoaiMau.Equals("Nước mặt"))
                {
                    //formToDisplay = new hien_truong_nuoc_mat(currentMaDH, currentMaNV);
                    formToDisplay = new phan_tich_nuoc_mat(currentMaDH, currentMaNV, currentViTriLayMau, IsEditMode);

                }
                else if (currentLoaiMau.Equals("Khí thải"))
                {
                    //formToDisplay = new hien_truong_khi_thai(currentMaDH, currentMaNV);
                    formToDisplay = new phan_tich_khi_thai(currentMaDH, currentMaNV, currentViTriLayMau, IsEditMode);

                }
                else
                {
                    //formToDisplay = new hien_truong_khong_khi(currentMaDH, currentMaNV);
                    formToDisplay = new phan_tich_khong_khi(currentMaDH, currentMaNV, currentViTriLayMau, IsEditMode);

                }

                // Hiển thị form đã được xác định
                if (formToDisplay != null)
                {
                    //DataTable dt = GetSampleDataFromDatabase(currentMaDH, currentViTriLayMau, currentMaNV);

                    //formToDisplay.FormClosed += FormToDisplay_FormClosedEvent;
                    //formToDisplay.ShowDialog();
                    ((dashboard)this.ParentForm).ShowFormOnPanel(formToDisplay);

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Mã Đơn Hàng, Mã Nhân Viên và Vị Trí Lấy Mẫu.");
            }
        }

        private void dat_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CBB_loai_mau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check_bbx_maDh_bbx_loaiMau();
        }
    }
}
