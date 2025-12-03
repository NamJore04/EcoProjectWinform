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
using Guna.UI2.WinForms;

namespace EcoProject.user_control
{
    public partial class uc_notifications : UserControl
    {
        DataProvider dp = new DataProvider();
        public uc_notifications()
        {
            InitializeComponent();
        }


        private void Btn_Tat_Ca_Click(object sender, EventArgs e)
        {
            load_all();
        }

        private void uc_notifications_Load_1(object sender, EventArgs e)
        {
            Guna2Panel panel_a = new Guna2Panel();
            panel_a.Size = new Size(1277, 60);
            panel_a.BorderRadius = 15;
            panel_a.Margin = new Padding(0, 10, 0, 10);

            // Label TenCongTy
            Label lbl_a = new Label();
            lbl_a.BackColor = Color.Transparent;
            lbl_a.Location = new Point(20, 20);
            lbl_a.AutoSize = true;
            lbl_a.Text = "Tên công ty";
            lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Label MaDH
            Label lbl_b = new Label();
            lbl_b.BackColor = Color.Transparent;
            lbl_b.Location = new Point(220, 20);
            lbl_b.AutoSize = true;
            lbl_b.Text = "Mã đơn hàng";
            lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Label NgayKetThucHD
            Label lbl_c = new Label();
            lbl_c.BackColor = Color.Transparent;
            lbl_c.Location = new Point(400, 20);
            lbl_c.AutoSize = true;
            lbl_c.Text = "Hạn trả hàng";
            lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Label trạng thái hạn
            Label lbl_d = new Label();
            lbl_d.Location = new Point(600, 20);
            lbl_d.AutoSize = true;
            lbl_d.Text = "Trạng thái";
            lbl_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            panel_a.Controls.Add(lbl_a);
            panel_a.Controls.Add(lbl_b);
            panel_a.Controls.Add(lbl_c);
            panel_a.Controls.Add(lbl_d);
            listDenHan.Controls.Add(panel_a);

            load_all();
        }
        private void load_all()
        {
            string query = "select TenCongTy, DonHang.MaDH, HanTraHang, TrangThai from DonHang, KhachHang, Mau where DonHang.MaKH = KhachHang.MaKH and (Datediff(day, DonHang.HanTraHang, GetDate()) < 4 or Datediff(day, DonHang.HanTraHang, GetDate()) < 0) and DonHang.MaDH = Mau.MaDH\r\n";
            DataTable dt = new DataTable();
            dt = dp.ExecuteQuery(query);

            foreach (DataRow dr in dt.Rows)
            {
                DateTime now = DateTime.Now;
                DateTime dateTime = DateTime.Parse(dr[2].ToString());
                TimeSpan timeSpan = dateTime.Subtract(now);
                string note;

                if (dr[3].ToString().Equals("Đã hoàn thành"))
                {
                    continue;
                }
                else if (timeSpan.Days < 0)
                {
                    note = "Quá hạn";
                }
                else if (timeSpan.Days < 4)
                {
                    note = "Sắp đến hạn";
                }
                else
                {
                    continue;
                }

                // Tạo Panel mới cho mỗi dòng dữ liệu
                Guna2Panel panel = new Guna2Panel();
                panel.Size = new Size(1277, 60);
                panel.BorderRadius = 15;
                panel.Margin = new Padding(0, 10, 0, 10);

                // Label TenCongTy
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.Location = new Point(20, 20);
                lbl.AutoSize = true;
                lbl.Text = dr[0].ToString().Trim();

                // Label MaDH
                Label lbl2 = new Label();
                lbl2.BackColor = Color.Transparent;
                lbl2.Location = new Point(220, 20);
                lbl2.AutoSize = true;
                lbl2.Text = dr[1].ToString().Trim();

                // Label HanTraHang
                Label lbl3 = new Label();
                lbl3.BackColor = Color.Transparent;
                lbl3.Location = new Point(400, 20);
                lbl3.AutoSize = true;
                lbl3.Text = dr[2].ToString().Trim();

                // Label trạng thái hạn
                Label lbl4 = new Label();
                lbl4.BackColor = Color.LightCoral;
                lbl4.Location = new Point(600, 20);
                lbl4.AutoSize = true;
                lbl4.Text = note;

                // Tạo Button Giải Quyết
                Guna2Button btn_Da_Giai_Quyet = new Guna2Button();
                btn_Da_Giai_Quyet.Animated = true;
                btn_Da_Giai_Quyet.AutoRoundedCorners = true;
                btn_Da_Giai_Quyet.BorderRadius = 13;
                btn_Da_Giai_Quyet.FillColor = Color.Black;
                btn_Da_Giai_Quyet.ForeColor = Color.White;
                btn_Da_Giai_Quyet.Font = new Font("Segoe UI", 9F);
                btn_Da_Giai_Quyet.Location = new Point(750, 15);  // Đảm bảo đủ không gian cho button
                btn_Da_Giai_Quyet.Size = new Size(202, 28);
                btn_Da_Giai_Quyet.Text = "Giải quyết";
                btn_Da_Giai_Quyet.Click += (s, ev) =>
                {
                    Update_content up = new Update_content(lbl2.Text);
                    up.Show();
                };

                // Thêm các Label và Button vào Panel
                panel.Controls.Add(lbl);
                panel.Controls.Add(lbl2);
                panel.Controls.Add(lbl3);
                panel.Controls.Add(lbl4);
                panel.Controls.Add(btn_Da_Giai_Quyet);

                // Thêm Panel vào FlowLayoutPanel
                listDenHan.Controls.Add(panel);
            }
        }

        private void Btn_Qua_Han_Click(object sender, EventArgs e)
        {
            string query = "select TenCongTy, DonHang.MaDH, HanTraHang, TrangThai from DonHang, KhachHang, Mau where DonHang.MaKH = KhachHang.MaKH and (Datediff(day, DonHang.HanTraHang, GetDate()) < 0) and DonHang.MaDH = Mau.MaDH\r\n";
            DataTable dt = new DataTable();
            dt = dp.ExecuteQuery(query);

            foreach (DataRow dr in dt.Rows)
            {
                DateTime now = DateTime.Now;
                DateTime dateTime = DateTime.Parse(dr[2].ToString());
                TimeSpan timeSpan = dateTime.Subtract(now);
                string note;

                if (dr[3].ToString().Equals("Đã hoàn thành"))
                {
                    continue;
                }
                else if (timeSpan.Days < 0)
                {
                    note = "Quá hạn";
                }
                else
                {
                    continue;
                }

                // Tạo Panel mới cho mỗi dòng dữ liệu
                Guna2Panel panel = new Guna2Panel();
                panel.Size = new Size(1277, 60);
                panel.BorderRadius = 15;
                panel.Margin = new Padding(0, 10, 0, 10);

                // Label TenCongTy
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.Location = new Point(20, 20);
                lbl.AutoSize = true;
                lbl.Text = dr[0].ToString().Trim();

                // Label MaDH
                Label lbl2 = new Label();
                lbl2.BackColor = Color.Transparent;
                lbl2.Location = new Point(220, 20);
                lbl2.AutoSize = true;
                lbl2.Text = dr[1].ToString().Trim();

                // Label HanTraHang
                Label lbl3 = new Label();
                lbl3.BackColor = Color.Transparent;
                lbl3.Location = new Point(400, 20);
                lbl3.AutoSize = true;
                lbl3.Text = dr[2].ToString().Trim();

                // Label trạng thái hạn
                Label lbl4 = new Label();
                lbl4.BackColor = Color.LightCoral;
                lbl4.Location = new Point(600, 20);
                lbl4.AutoSize = true;
                lbl4.Text = note;

                // Tạo Button Giải Quyết
                Guna2Button btn_Da_Giai_Quyet = new Guna2Button();
                btn_Da_Giai_Quyet.Animated = true;
                btn_Da_Giai_Quyet.AutoRoundedCorners = true;
                btn_Da_Giai_Quyet.BorderRadius = 13;
                btn_Da_Giai_Quyet.FillColor = Color.Black;
                btn_Da_Giai_Quyet.ForeColor = Color.White;
                btn_Da_Giai_Quyet.Font = new Font("Segoe UI", 9F);
                btn_Da_Giai_Quyet.Location = new Point(750, 15);  // Đảm bảo đủ không gian cho button
                btn_Da_Giai_Quyet.Size = new Size(202, 28);
                btn_Da_Giai_Quyet.Text = "Giải quyết";
                btn_Da_Giai_Quyet.Click += (s, ev) =>
                {
                    Update_content up = new Update_content(lbl2.Text);
                    up.Show();
                };

                // Thêm các Label và Button vào Panel
                panel.Controls.Add(lbl);
                panel.Controls.Add(lbl2);
                panel.Controls.Add(lbl3);
                panel.Controls.Add(lbl4);
                panel.Controls.Add(btn_Da_Giai_Quyet);

                // Thêm Panel vào FlowLayoutPanel
                listDenHan.Controls.Add(panel);
            }
        }

        private void Btn_Sap_Het_Han_Click(object sender, EventArgs e)
        {
            string query = "select TenCongTy, DonHang.MaDH, HanTraHang, TrangThai from DonHang, KhachHang, Mau where DonHang.MaKH = KhachHang.MaKH and (Datediff(day, DonHang.HanTraHang, GetDate()) < 4) and DonHang.MaDH = Mau.MaDH\r\n";
            DataTable dt = new DataTable();
            dt = dp.ExecuteQuery(query);

            foreach (DataRow dr in dt.Rows)
            {
                DateTime now = DateTime.Now;
                DateTime dateTime = DateTime.Parse(dr[2].ToString());
                TimeSpan timeSpan = dateTime.Subtract(now);
                string note;

                if (dr[3].ToString().Equals("Đã hoàn thành"))
                {
                    continue;
                }
                else if (timeSpan.Days < 4)
                {
                    note = "Sắp đến hạn";
                }
                else
                {
                    continue;
                }

                // Tạo Panel mới cho mỗi dòng dữ liệu
                Guna2Panel panel = new Guna2Panel();
                panel.Size = new Size(1277, 60);
                panel.BorderRadius = 15;
                panel.Margin = new Padding(0, 10, 0, 10);

                // Label TenCongTy
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.Location = new Point(20, 20);
                lbl.AutoSize = true;
                lbl.Text = dr[0].ToString().Trim();

                // Label MaDH
                Label lbl2 = new Label();
                lbl2.BackColor = Color.Transparent;
                lbl2.Location = new Point(220, 20);
                lbl2.AutoSize = true;
                lbl2.Text = dr[1].ToString().Trim();

                // Label HanTraHang
                Label lbl3 = new Label();
                lbl3.BackColor = Color.Transparent;
                lbl3.Location = new Point(400, 20);
                lbl3.AutoSize = true;
                lbl3.Text = dr[2].ToString().Trim();

                // Label trạng thái hạn
                Label lbl4 = new Label();
                lbl4.BackColor = Color.LightCoral;
                lbl4.Location = new Point(600, 20);
                lbl4.AutoSize = true;
                lbl4.Text = note;

                // Tạo Button Giải Quyết
                Guna2Button btn_Da_Giai_Quyet = new Guna2Button();
                btn_Da_Giai_Quyet.Animated = true;
                btn_Da_Giai_Quyet.AutoRoundedCorners = true;
                btn_Da_Giai_Quyet.BorderRadius = 13;
                btn_Da_Giai_Quyet.FillColor = Color.Black;
                btn_Da_Giai_Quyet.ForeColor = Color.White;
                btn_Da_Giai_Quyet.Font = new Font("Segoe UI", 9F);
                btn_Da_Giai_Quyet.Location = new Point(750, 15);  // Đảm bảo đủ không gian cho button
                btn_Da_Giai_Quyet.Size = new Size(202, 28);
                btn_Da_Giai_Quyet.Text = "Giải quyết";
                btn_Da_Giai_Quyet.Click += (s, ev) =>
                {
                    Update_content up = new Update_content(lbl2.Text);
                    up.Show();
                };

                // Thêm các Label và Button vào Panel
                panel.Controls.Add(lbl);
                panel.Controls.Add(lbl2);
                panel.Controls.Add(lbl3);
                panel.Controls.Add(lbl4);
                panel.Controls.Add(btn_Da_Giai_Quyet);

                // Thêm Panel vào FlowLayoutPanel
                listDenHan.Controls.Add(panel);
            }
        }
    }
}
