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
using System.Web.UI;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using EcoProject.user_control;

namespace EcoProject
{
    public partial class dashboard : Form
    {
        private string MaNV;
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        private Form currentForm;
        DataProvider dataProvider = new DataProvider();
        public dashboard()
        {
            InitializeComponent();
            //uc_home1 = new uc_home(); //
            //uc_field_data_entry1 = new uc_field_data_entry();
            //uc_historyand_udit_log1 = new uc_historyand_udit_log();
            //uc_lab_analysis_management12 = new uc_lab_analysis_management1();
            //uc_notifications1 = new uc_notifications();
            //uc_reports1 = new uc_reports();
            //uc_order1 = new uc_order();
            //uc_customer2 = new uc_customer();
            //uc_add_customer1 = new uc_add_customer();
        }
        public dashboard(string MaNV) : this() // Constructor nhận mã nhân viên
        {
            this.MaNV = MaNV;
            // Cho phép thay đổi kích thước
            this.WindowState = FormWindowState.Normal; 
            this.TopMost = false; 
            this.Show();
            //this.Controls.Add();
            string query = "select HoTen from NhanVien where MaNV = @MaNV";
            string hoten = (string)dataProvider.ExecuteScalar(query, new object[] { MaNV });
            ListBoxTenNv.Text = hoten;
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("Đổi Mật Khẩu");
            guna2ComboBox1.Items.Add("Đăng Xuất");
           
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
        }
        public void ShowFormOnPanel(Form form)
        {
            // Kiểm tra nếu đã có form hiện tại đang hiển thị trên panel, thì đóng form đó trước khi hiển thị form mới
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Thiết lập form mới để hiển thị
            currentForm = form;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;

            // Thêm form vào panel control (panel1)
            guna2Panel2.Controls.Clear(); // Xóa các control cũ trên panel
            guna2Panel2.Controls.Add(currentForm);
            guna2Panel2.Tag = currentForm;


            // Hiển thị form
            //currentForm.Size = guna2Panel2.Size; // Scale form size to match panel1 size
            currentForm.Show();
            currentForm.BringToFront();
        }

        public void ShowUserControlOnPanel(System.Windows.Forms.UserControl userControl)
        {
            // Kiểm tra nếu đã có form hiện tại đang hiển thị trên panel, thì đóng form đó trước khi hiển thị form mới
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Thêm UserControl vào panel
            userControl.Dock = DockStyle.Top;
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(userControl);
            userControl.Tag = currentForm;
            //userControl.Size = guna2Panel2.Size;
            userControl.Show();

            userControl.BringToFront();

        }



        private void TrangChu(object sender, EventArgs e)
        {

            //uc_home1.Visible = true;
            //uc_customer2.Visible = false;
            //uc_field_data_entry1.Visible = false;
            //uc_historyand_udit_log1.Visible = false;
            //uc_lab_analysis_management12.Visible = false;
            //uc_notifications1.Visible = false;
            //uc_reports1.Visible = false;
            //uc_add_customer1.Visible = false;
            ////uc
            //uc_order1.Visible = false;
            //uc_home1.BringToFront();
            uc_home newLab = new uc_home();
            this.ShowUserControlOnPanel(newLab);

            //((dashboard)this.ParentForm).ShowFormOnPanel(new Form { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Controls = { new uc_home() } });



        }

        private void NhapVaKiemTraDuLieu(object sender, EventArgs e)
        {
            //uc_home1.Visible = false;
            //uc_field_data_entry1.Visible = true;
            //uc_historyand_udit_log1.Visible = false;
            //uc_lab_analysis_management12.Visible = false;
            //uc_notifications1.Visible = false;
            //uc_reports1.Visible = false;
            //uc_order1.Visible = false;
            //uc_customer2.Visible = false;
            //uc_add_customer1.Visible = false;

            //uc_field_data_entry1.BringToFront();
            uc_field_data_entry newLab = new uc_field_data_entry();
            this.ShowUserControlOnPanel(newLab);

        }

        private void QuanLiDonHang(object sender, EventArgs e)
        {
            //uc_home1.Visible = false;
            //uc_field_data_entry1.Visible = false;
            //uc_historyand_udit_log1.Visible = false;
            //uc_lab_analysis_management12.Visible = false;
            //uc_notifications1.Visible = false;
            //uc_reports1.Visible = false;
            //uc_order1.Visible = true;
            //uc_customer2.Visible = false;
            //uc_add_customer1.Visible = false;

            //uc_order1.BringToFront();

            uc_order newLab = new uc_order();
            this.ShowUserControlOnPanel(newLab);
        }

        private void PhanTichMau(object sender, EventArgs e)
        {
            //uc_home1.Visible = false;
            //uc_field_data_entry1.Visible = false;
            //uc_historyand_udit_log1.Visible = false;
            //uc_lab_analysis_management12.Visible = true;
            //uc_notifications1.Visible = false;
            //uc_reports1.Visible = false;
            //uc_order1.Visible = false;
            //uc_customer2.Visible = false;
            //uc_add_customer1.Visible = false;

            //uc_lab_analysis_management12.BringToFront();
            uc_lab_analysis_management1 newLab = new uc_lab_analysis_management1();
            this.ShowUserControlOnPanel(newLab);

            //((dashboard)this.ParentForm).ShowUserControlOnPanel(newLab);
        }

        private void LichSu(object sender, EventArgs e)
        {
            //uc_home1.Visible = false;
            //uc_field_data_entry1.Visible = false;
            //uc_historyand_udit_log1.Visible = true;
            //uc_lab_analysis_management12.Visible = false;
            //uc_notifications1.Visible = false;
            //uc_reports1.Visible = false;
            //uc_order1.Visible = false;
            //uc_customer2.Visible = false;
            //uc_add_customer1.Visible = false;

            //uc_historyand_udit_log1.BringToFront();
            uc_historyand_udit_log newLab = new uc_historyand_udit_log();
            this.ShowUserControlOnPanel(newLab);

            //((dashboard)this.ParentForm).ShowUserControlOnPanel(newLab);
        }

        private void PhieuTraHang(object sender, EventArgs e)
        {
            //uc_home1.Visible = false;
            //uc_field_data_entry1.Visible = false;
            //uc_historyand_udit_log1.Visible = false;
            //uc_lab_analysis_management12.Visible = false;
            //uc_notifications1.Visible = false;
            //uc_reports1.Visible = true;
            //uc_order1.Visible = false;
            //uc_customer2.Visible = false;
            //uc_add_customer1.Visible = false;

            //uc_reports1.BringToFront();

            uc_reports newLab = new uc_reports();
            this.ShowUserControlOnPanel(newLab);

            //((dashboard)this.ParentForm).ShowUserControlOnPanel(newLab);
        }

        private void ThongBao(object sender, EventArgs e)
        {
            //uc_home1.Visible = false;
            //uc_field_data_entry1.Visible = false;
            //uc_historyand_udit_log1.Visible = false;
            //uc_lab_analysis_management12.Visible = false;
            //uc_notifications1.Visible = true;
            //uc_reports1.Visible = false;
            //uc_order1.Visible = false;
            //uc_customer2.Visible = false;
            //uc_add_customer1.Visible = false;

            //uc_notifications1.BringToFront();
            uc_notifications newLab = new uc_notifications();
            this.ShowUserControlOnPanel(newLab);

            //((dashboard)this.ParentForm).ShowUserControlOnPanel(newLab);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
   
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //uc_home1.Visible = true;
            //uc_field_data_entry1.Visible = false;
            //uc_historyand_udit_log1.Visible = false;
            //uc_lab_analysis_management12.Visible = false;
            //uc_notifications1.Visible = false;
            //uc_reports1.Visible = false;
            //uc_order1.Visible = false;
            //uc_customer2.Visible = false;
            //uc_add_customer1.Visible = false;

            //uc_home1.BringToFront();
            uc_home newLab = new uc_home();
            this.ShowUserControlOnPanel(newLab);

            //((dashboard)this.ParentForm).ShowUserControlOnPanel(newLab);
        }

        private void QuanLiKhachHang(object sender, EventArgs e)
        {
            //uc_home1.Visible = false;
            //uc_field_data_entry1.Visible = false;
            //uc_historyand_udit_log1.Visible = false;
            //uc_lab_analysis_management12.Visible = false;
            //uc_notifications1.Visible = false;
            //uc_reports1.Visible = false;
            //uc_order1.Visible = false;
            //uc_customer2.Visible = true;
            //uc_add_customer1.Visible = false;

            //uc_customer2.BringToFront();

            uc_customer newLab = new uc_customer();
            this.ShowUserControlOnPanel(newLab);

            //((dashboard)this.ParentForm).ShowUserControlOnPanel(newLab);
        }

        private void uc_home1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_lab_analysis_management12_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_reports1_Load(object sender, EventArgs e)
        {

        }

        private void uc_notifications1_Load(object sender, EventArgs e)
        {

        }

        private void uc_historyand_udit_log1_Load(object sender, EventArgs e)
        {

        }

        private void uc_order1_Load(object sender, EventArgs e)
        {

        }

        private void uc_customer2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_field_data_entry1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Clear();

            guna2ComboBox1.Items.Add("Đổi Mật Khẩu");
            guna2ComboBox1.Items.Add("Đăng Xuất");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DangXuatDoiMatKhau(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem.ToString()=="Đổi Mật Khẩu") {
                FogetPassword.doi_mat_khau changePass = new FogetPassword.doi_mat_khau(MaNV, this);
                changePass.Show();
            }
            else if(guna2ComboBox1.SelectedItem.ToString()=="Đăng Xuất")
            {
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uc_add_customer1_Load(object sender, EventArgs e)
        {

        }

        private void uc_add_customer1_Load_1(object sender, EventArgs e)
        {

        }

        private void uc_reports1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
