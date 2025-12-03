using EcoProject.Nhap_lieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new hien_truong_khong_khi());
            //Application.Run(new hien_truong_khi_thai());
            //Application.Run(new hien_truong_nuoc_mat());
            //Application.Run(new phan_tich_khi_thai());
            //Application.Run(new phan_tich_khong_khi());
            //Application.Run(new phan_tich_nuoc_mat());


        }
    }
}
