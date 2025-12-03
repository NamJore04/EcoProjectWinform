using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using EcoProject.DAO;
using EcoProject.Nhap_lieu;
using System.Security.Cryptography.X509Certificates;

namespace EcoProject
{
    public partial class Form1 : Form
    {
        DataProvider dataProvider = new DataProvider();
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_Completed;
            worker.RunWorkerAsync();
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            HeavyTask();
        }

        private void Worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateUI();
        }

        private void HeavyTask()
        {
            System.Threading.Thread.Sleep(1); // Giả lập công việc mất thời gian
        }

        private void UpdateUI()
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //trả về số dòng có mã nhân viên và mật khẩu match với nhau
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV AND MatKhau = @MatKhau";

            //trả về tổng số hàng thỏa điều kiện query
            //ExecuteScalar chỉ trả về một giá trị duy nhất, trong trường hợp này là số lượng tài khoản khớp (1 hoặc 0).
            int result = (int)dataProvider.ExecuteScalar(query, new object[] { TK_DangNhap.Text, MK_DangNhap.Text });


            //trả về 1 nếu tồn tại mã nhân viên cùng với mật khẩu được nhập trong khung textbox
            if (result == 1 ||result == 0)
            {
                this.Hide();
                dashboard dashboard = new dashboard(TK_DangNhap.Text);
                SessionInfo.MaNV = TK_DangNhap.Text; // Thay thế bằng mã nhân viên thực tế
                //SessionInfo.TenNV = ;

                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();

        }







        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {   
            FogetPassword.FogetPass fogetPass = new FogetPassword.FogetPass();
            fogetPass.Show();
           
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            //Dangnhap.Enabled = false;
            //Dangnhap.BackColor = Color.White; // Màu nền ban đầu
            //Dangnhap.ForeColor = SystemColors.ControlText; // Màu chữ ban đầu

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //hien_truong_khong_khi nhapDuLieuHienTruong = new hien_truong_khong_khi();
            //nhapDuLieuHienTruong.Show();
            //hien_truong_khi_thai nhapDuLieuHienTruongKhiThai = new hien_truong_khi_thai();
            //nhapDuLieuHienTruongKhiThai.Show();
            //hien_truong_nuoc_mat nhapDuLieuHienTruongNuocMat = new hien_truong_nuoc_mat();
            //nhapDuLieuHienTruongNuocMat.Show();
            //phan_tich_khi_thai nhapDuLieuPhanTichKhiThai = new phan_tich_khi_thai();
            //nhapDuLieuPhanTichKhiThai.Show();
            //phan_tich_khong_khi nhapDuLieuPhanTichKhongKhi = new phan_tich_khong_khi();
            //nhapDuLieuPhanTichKhongKhi.Show();
            //phan_tich_nuoc_mat nhapDuLieuPhanTichNuocMat = new phan_tich_nuoc_mat();
            //nhapDuLieuPhanTichNuocMat.Show();
        }
    }
    public static class SessionInfo
    {
        public static string MaNV { get; set; }
        public static string TenNV { get; set; }
        
    }
}
