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

namespace EcoProject
{
    public partial class Update_content : Form
    {
        string MaDh;
        DataProvider dp = new DataProvider();
        public Update_content(string madh)
        {
            InitializeComponent();
            MaDh = madh;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (capnhat.Text != "")
                {
                    try
                    {
                        string query = "update DuLieuKiemDinh set TrangThai = @TrangThai where DuLieuKiemDinh.MaDH = @MaDH ";
                        dp.ExecuteNonQuery(query, new object[] { capnhat.Text, MaDh });
                        MessageBox.Show("Update successfull!");
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
                }
            }
            else if (rs == DialogResult.No)
            {

            }

        }
    }


}
