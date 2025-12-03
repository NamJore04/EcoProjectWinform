using EcoProject.DAO;
using Guna.UI2.WinForms;
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

namespace EcoProject.user_control
{
    public partial class uc_order : UserControl
    {

        DataProvider dp = new DataProvider();
        public uc_order()
        {
            InitializeComponent();
        }

        private void Btn_TaoMoi(object sender, EventArgs e)
        {
            Add_Orders add_Orders = new Add_Orders();
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
                add_Orders.FormClosed += (s, args) => parentForm.Show();
                add_Orders.FormClosed += (s, args) => loadData();
            }
            add_Orders.Show();
        }

        private void loadData()
        {
            try
            {
                View.Rows.Clear();
                string query = "Select MaDH, TenCongTy, NgayTaoDH, HanTraHang from DonHang, KhachHang where DonHang.MaKH = KhachHang.MaKH";
                DataTable dt = new DataTable();
                dt = dp.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    int index = View.Rows.Add(); // Thêm một hàng mới và lấy chỉ số hàng
                    DataGridViewRow newRow = View.Rows[index];

                    // Gán giá trị cho các cột dựa trên chỉ số cột
                    newRow.Cells[0].Value = row["MaDH"];            // Gán giá trị cho cột đầu tiên
                    newRow.Cells[1].Value = row["TenCongTy"];     // Gán giá trị cho cột thứ hai
                    newRow.Cells[2].Value = row["NgayTaoDH"];      // Gán giá trị cho cột thứ ba
                    newRow.Cells[3].Value = row["HanTraHang"]; // Gán giá trị cho cột thứ tư
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể lấy thông tin đơn hàng! Chi tiết lỗi: {ex.Message}");
            }
        }


        private void uc_order_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void tboxTimKiem_TextChanged(object sender, EventArgs e)
        {
            string query = "Select MaDH, TenCongTy, NgayTaoDH, HanTraHang from DonHang, KhachHang where DonHang.MaKH = KhachHang.MaKH and MaDH LIKE '%' + @madh + '%'";

            if (tboxTimKiem.Text != "")
            {
                View.Rows.Clear();
                try
                {
                    DataTable dt = new DataTable();
                    dt = dp.ExecuteQuery(query, new object[] { tboxTimKiem.Text });
                    foreach (DataRow row in dt.Rows)
                    {
                        int index = View.Rows.Add(); // Thêm một hàng mới và lấy chỉ số hàng
                        DataGridViewRow newRow = View.Rows[index];

                        // Gán giá trị cho các cột dựa trên chỉ số cột
                        newRow.Cells[0].Value = row["MaDH"];            // Gán giá trị cho cột đầu tiên
                        newRow.Cells[1].Value = row["TenCongTy"];     // Gán giá trị cho cột thứ hai
                        newRow.Cells[2].Value = row["NgayTaoDH"];      // Gán giá trị cho cột thứ ba
                        newRow.Cells[3].Value = row["HanTraHang"]; // Gán giá trị cho cột thứ tư
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
            }
        }

        private void View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string madh = View.CurrentRow.Cells[0].Value.ToString();
                MessageBox.Show(madh);
                Update_content up = new Update_content(madh);
                up.ShowDialog();
                up.BringToFront();
            }
        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}
