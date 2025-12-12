# EcoProject - Hệ Thống Quản Trắc Môi Trường

## 📋 Giới Thiệu

EcoProject là một ứng dụng Windows Forms được phát triển bằng C# để quản lý và theo dõi các hoạt động quan trắc môi trường. Hệ thống hỗ trợ quản lý dữ liệu khách hàng, nhân viên, đơn hàng và các mẫu phân tích môi trường (nước, không khí, khí thải).

## 🎯 Tính Năng Chính

### 1. Quản Lý Khách Hàng
- Thêm, sửa, xóa thông tin khách hàng
- Quản lý thông tin công ty, người đại diện
- Theo dõi ngành công nghiệp và địa chỉ

### 2. Quản Lý Đơn Hàng
- Tạo và cập nhật đơn hàng
- Theo dõi trạng thái đơn hàng
- Quản lý nội dung và chi tiết đơn hàng

### 3. Nhập Dữ Liệu Môi Trường
#### Dữ Liệu Hiện Trường:
- Hiện trường không khí
- Hiện trường khí thải
- Hiện trường nước mặt

#### Dữ Liệu Phân Tích:
- Phân tích mẫu không khí
- Phân tích mẫu khí thải
- Phân tích mẫu nước mặt
- Phân tích mẫu đất

#### Quản Lý Chỉ Tiêu:
- Chỉ tiêu không khí
- Chỉ tiêu khí thải
- Chỉ tiêu nước mặt

### 4. Dashboard
- Trang tổng quan với các thống kê
- Quản lý thông báo
- Báo cáo và lịch sử

### 5. Quản Lý Tài Khoản
- Đăng nhập/Đăng xuất
- Quên mật khẩu
- Đổi mật khẩu
- Gửi email xác thực

## 🛠️ Công Nghệ Sử Dụng

### Framework & Ngôn Ngữ
- **.NET Framework 4.7.2**
- **C# Windows Forms**
- **SQL Server LocalDB**

### Thư Viện & Package
- **Guna.UI2.WinForms** (2.0.4.6) - UI Components
- **MailKit** (4.8.0) - Email functionality
- **MimeKit** (4.8.0) - Email processing
- **BouncyCastle.Cryptography** (2.4.0) - Cryptography

## 📁 Cấu Trúc Dự Án

```
EcoProject/
├── Database/                    # Cơ sở dữ liệu SQL Server
│   ├── QuanTracMoiTruong.mdf
│   └── QuanTracMoiTruong_log.ldf
├── Nhap_lieu/                   # Forms nhập liệu
│   ├── hien_truong_*.cs         # Nhập dữ liệu hiện trường
│   ├── phan_tich_*.cs           # Nhập dữ liệu phân tích
│   └── chi_tieu_*.cs            # Quản lý chỉ tiêu
├── user_control/                # User Controls
│   ├── uc_home.cs               # Trang chủ
│   ├── uc_customer.cs           # Quản lý khách hàng
│   ├── uc_order.cs              # Quản lý đơn hàng
│   ├── uc_reports.cs            # Báo cáo
│   └── ...
├── FogetPassword/               # Quên mật khẩu
├── assets/                      # Tài nguyên (icon, img)
├── Form1.cs                     # Form đăng nhập
├── dashboard.cs                 # Form chính
├── ecoproject_DAO.cs           # Data Access Layer
└── Program.cs                   # Entry point

```

## 💾 Cơ Sở Dữ Liệu

Hệ thống sử dụng SQL Server LocalDB với các bảng chính:

- **NhanVien** - Thông tin nhân viên
- **KhachHang** - Thông tin khách hàng
- **DonHang** - Đơn hàng
- **MauPhanTich** - Mẫu phân tích môi trường
- Và các bảng liên quan khác...

### Connection String
```
Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=Database\QuanTracMoiTruong.mdf;
Integrated Security=True;
```

## 🚀 Hướng Dẫn Cài Đặt

### Yêu Cầu Hệ Thống
- Windows OS
- .NET Framework 4.7.2 hoặc cao hơn
- Visual Studio 2017 hoặc cao hơn
- SQL Server LocalDB

### Các Bước Cài Đặt

1. **Clone repository**
   ```bash
   git clone https://github.com/NamJore04/EcoProjectWinform.git
   cd EcoProject
   ```

2. **Mở Solution**
   - Mở file `EcoProject.sln` bằng Visual Studio

3. **Restore NuGet Packages**
   ```
   Tools > NuGet Package Manager > Restore NuGet Packages
   ```

4. **Cấu hình Database**
   - Database file đã có sẵn trong thư mục `Database/`
   - Kết nối tự động qua LocalDB

5. **Build và Run**
   ```
   Build > Build Solution (Ctrl+Shift+B)
   Debug > Start Debugging (F5)
   ```

## 📖 Hướng Dẫn Sử Dụng

### Đăng Nhập
1. Khởi động ứng dụng
2. Nhập mã nhân viên và mật khẩu
3. Click "Đăng Nhập"

### Quản Lý Khách Hàng
1. Vào Dashboard
2. Chọn menu "Khách Hàng"
3. Thêm/Sửa/Xóa thông tin khách hàng

### Nhập Dữ Liệu Môi Trường
1. Chọn loại dữ liệu cần nhập (Hiện trường/Phân tích)
2. Chọn môi trường (Không khí/Khí thải/Nước/Đất)
3. Điền thông tin và lưu

## 🔐 Bảo Mật

- Mật khẩu được mã hóa
- Xác thực email qua MailKit
- Quản lý phiên đăng nhập
- Phân quyền theo nhân viên

## 👥 Đóng Góp

Dự án được phát triển bởi nhóm sinh viên:
- Môn học: Công Nghệ Phần Mềm
- Học kỳ 1, Năm 3

## 📞 Liên Hệ

- Repository: [NamJore04/EcoProjectWinform](https://github.com/NamJore04/EcoProjectWinform)

## 📝 License

Dự án được phát triển cho mục đích học tập.

---

**Note:** Đây là dự án học tập, vui lòng không sử dụng cho mục đích thương mại.
