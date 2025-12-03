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

namespace EcoProject.user_control
{
    public partial class uc_customer : UserControl
    {
        DataProvider provider;
        public uc_customer()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            string query = "select TenCongTy as N'Tên Công Ty', MaDH as N'Mã đơn hàng', NguoiDaiDien as N'Người đại diện' , SDT as N'SĐT', DiaChi as N'Địa chỉ' from KhachHang, DonHang where KhachHang.MaKh = DonHang.MaKH";
            provider = new DataProvider();
            dt = provider.ExecuteQuery(query, new object[0]);
            ShowDanhSach.DataSource = dt;
        }

        private void Btn_Them_Khach_Hang(object sender, EventArgs e)
        {
            Add_customer add_Customer = new Add_customer();
            add_Customer.Show();
            add_Customer.TopMost = true;
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
                add_Customer.FormClosed += (s, args) =>
                {
                    parentForm.Show();
                    LoadData();
                };
            }
            add_Customer.Show();
        }

        private void TimKiem(object sender, EventArgs e)
        {
            {
                string tenCT = TB_TimKimCTy.Text;
                string maDH = TB_TimKiemDH.Text;
                string tinh = ChonTinh.Text;

                if (tinh == "Chọn tỉnh") tinh = "";

                if (string.IsNullOrWhiteSpace(tenCT) && string.IsNullOrWhiteSpace(maDH) && string.IsNullOrWhiteSpace(tinh))
                {
                    LoadData();
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT KhachHang.MaKH AS N'Mã khách hàng', MaDH AS N'Mã hàng', TenCongTy AS N'Tên Công Ty', SDT AS N'SĐT', DiaChi AS N'Địa chỉ' " +
                                   "FROM KhachHang, DonHang WHERE KhachHang.MaKh = DonHang.MaKH AND ";
                    List<string> conditions = new List<string>();

                    if (!string.IsNullOrWhiteSpace(tenCT))
                    {
                        conditions.Add("TenCongTy LIKE N'%" + tenCT + "%'");
                    }
                    if (!string.IsNullOrWhiteSpace(maDH))
                    {
                        conditions.Add("MaDH = '" + maDH + "'");
                    }
                    if (!string.IsNullOrWhiteSpace(tinh))
                    {
                        conditions.Add("DiaChi LIKE N'%" + tinh + "'");
                    }

                    query += string.Join(" AND ", conditions);
                    provider = new DataProvider();
                    dt = provider.ExecuteQuery(query, new object[0]);
                    ShowDanhSach.DataSource = dt;
                }
            }
        }

        private void ShowDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maDH = ShowDanhSach.Rows[e.RowIndex].Cells["Mã đơn hàng"].Value.ToString();
                string query = "select count(*) from KhachHang, Mau, DonHang where KhachHang.MaKH = DonHang.MaKH and DonHang.MaDH = Mau.MaDH and DonHang.MaDH = @madh and TrangThai = N'Đã hoàn thành'";
                object r = provider.ExecuteScalar(query, new object[] { maDH });
                int result = Convert.ToInt32(r);
                if (result > 0)
                {
                    MessageBox.Show("Đơn hàng của khách hàng này đã được xử lý xong.\nKhông thể sửa thông tin của khách hàng này!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query2 = "select KhachHang.* from KhachHang, DonHang where KhachHang.MaKH = DonHang.MaKH and MaDH = '24.001'";
                    dt = provider.ExecuteQuery(query2, new object[] { maDH });
                    foreach (DataRow dr in dt.Rows)
                    {
                        Update_customer update_Customer = new Update_customer
                        (
                            dr["MaKH"].ToString(),
                            dr["NguoiDaiDien"].ToString(),
                            dr["TenCongTy"].ToString(),
                            dr["Email"].ToString(),
                            dr["DiaChi"].ToString(),
                            dr["NganhCongNghiep"].ToString(),
                            dr["SDT"].ToString(),
                            dr["GhiChu"].ToString()
                        );
                        Form parentForm = this.FindForm();
                        if (parentForm != null)
                        {
                            parentForm.Hide();
                            update_Customer.FormClosed += (s, args) =>
                            {
                                parentForm.Show();
                                LoadData();
                            };
                        }
                        update_Customer.Show();
                    }
                }
            }
        }
    }
}
