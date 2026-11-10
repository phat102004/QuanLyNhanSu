# HỆ THỐNG QUẢN LÝ NHÂN SỰ

## Giới thiệu dự án

**Hệ thống Quản lý Nhân sự (Human Resource Management System)** là ứng dụng desktop được phát triển bằng **C# Windows Forms (WinForms)** và **Microsoft SQL Server**.

Ứng dụng hỗ trợ quản lý thông tin nhân viên, phòng ban, chức vụ, trình độ chuyên môn, chấm công, tính lương, phụ cấp, phân công công việc và tài khoản người dùng.

Hệ thống được xây dựng nhằm hỗ trợ việc quản lý nhân sự trong doanh nghiệp, giảm bớt thao tác thủ công và tạo điều kiện thuận lợi cho việc tra cứu, theo dõi và tổng hợp dữ liệu.

Dự án được thực hiện nhằm vận dụng kiến thức lập trình hướng đối tượng, thiết kế giao diện Windows Forms, xử lý dữ liệu SQL Server và xây dựng các chức năng quản lý theo nghiệp vụ thực tế.

---

## Công nghệ sử dụng

| Công nghệ | Mục đích |
|---|---|
| C# | Ngôn ngữ lập trình chính |
| Windows Forms | Xây dựng giao diện ứng dụng desktop |
| .NET | Nền tảng phát triển ứng dụng |
| Microsoft SQL Server | Lưu trữ và quản lý cơ sở dữ liệu |
| ADO.NET / SqlClient | Kết nối và thao tác với SQL Server |
| Visual Studio 2022 | Môi trường phát triển |
| Git & GitHub | Quản lý phiên bản và lưu trữ mã nguồn |

---

## Các chức năng chính

### 1. Đăng nhập và quản lý tài khoản

- Đăng nhập vào hệ thống bằng tài khoản người dùng.
- Quản lý thông tin tài khoản.
- Hỗ trợ các giao diện chức năng phù hợp với vai trò người sử dụng.

### 2. Trang tổng quan quản trị

- Hiển thị giao diện tổng quan dành cho người quản trị.
- Hỗ trợ truy cập các chức năng quản lý nhân sự.
- Theo dõi thông tin tổng hợp phục vụ công tác quản lý.

### 3. Quản lý nhân viên

- Hiển thị danh sách nhân viên.
- Thêm, sửa và quản lý hồ sơ nhân viên.
- Tìm kiếm, tra cứu thông tin nhân viên.
- Theo dõi thông tin cá nhân và thông tin công việc.

### 4. Quản lý phòng ban và chức vụ

- Quản lý danh sách phòng ban.
- Quản lý các chức vụ trong doanh nghiệp.
- Hỗ trợ phân loại nhân viên theo cơ cấu tổ chức.

### 5. Quản lý trình độ chuyên môn

- Lưu trữ thông tin trình độ chuyên môn của nhân viên.
- Tra cứu và quản lý các thông tin liên quan đến trình độ, bằng cấp.

### 6. Quản lý chấm công

- Ghi nhận thông tin chấm công.
- Theo dõi dữ liệu chấm công của nhân viên.
- Tra cứu và quản lý lịch sử chấm công.

### 7. Quản lý lương và phụ cấp

- Quản lý thông tin bảng lương nhân viên.
- Hỗ trợ tính lương dựa trên dữ liệu liên quan.
- Quản lý các khoản phụ cấp.
- Theo dõi kết quả tính lương và lập báo cáo.

### 8. Quản lý và phân công công việc

- Quản lý thông tin công việc.
- Phân công nhiệm vụ cho nhân viên.
- Theo dõi danh sách và thông tin công việc được giao.
- Xem báo cáo liên quan đến phân công công việc.

### 9. Chức năng dành cho nhân viên

- Xem thông tin hồ sơ cá nhân.
- Xem công việc được giao.
- Tra cứu thông tin lương cá nhân.
- Sử dụng các chức năng chấm công theo quyền được cấp.

---

# HÌNH ẢNH GIAO DIỆN ỨNG DỤNG

Dưới đây là các màn hình giao diện chính của hệ thống, được chia thành từng nhóm chức năng.

## I. Đăng nhập và tổng quan hệ thống

### 1. Giao diện đăng nhập

Màn hình đăng nhập cho phép người dùng truy cập hệ thống thông qua thông tin tài khoản.

![Giao diện đăng nhập](docs/screenshots/login.png)

### 2. Trang tổng quan Admin

Giao diện dành cho người quản trị, hỗ trợ truy cập và theo dõi các chức năng quản lý nhân sự.

![Trang tổng quan Admin](docs/screenshots/admin-dashboard.png)

---

## II. Quản lý thông tin nhân sự

### 3. Danh sách nhân viên

Giao diện hiển thị và quản lý danh sách nhân viên trong doanh nghiệp.

![Quản lý nhân viên](docs/screenshots/employee-management.png)

### 4. Thêm nhân viên

Biểu mẫu nhập thông tin để bổ sung hồ sơ nhân viên vào hệ thống.

![Thêm nhân viên](docs/screenshots/add-employee.png)

### 5. Quản lý phòng ban

Giao diện quản lý các phòng ban và cơ cấu tổ chức.

![Quản lý phòng ban](docs/screenshots/department-management.png)

### 6. Quản lý chức vụ

Giao diện quản lý các chức vụ và thông tin liên quan.

![Quản lý chức vụ](docs/screenshots/position-management.png)

### 7. Quản lý trình độ chuyên môn

Giao diện theo dõi thông tin trình độ chuyên môn của nhân viên.

![Quản lý trình độ chuyên môn](docs/screenshots/qualification-management.png)

### 8. Chọn nhân viên

Giao diện hỗ trợ tìm kiếm và lựa chọn nhân viên khi thực hiện các nghiệp vụ quản lý.

![Chọn nhân viên](docs/screenshots/employee-selection.png)

---

## III. Quản lý chấm công

### 9. Chấm công nhân viên

Giao diện thực hiện các thao tác chấm công cho nhân viên.

![Chấm công nhân viên](docs/screenshots/attendance.png)

### 10. Quản lý chấm công

Giao diện theo dõi và quản lý dữ liệu chấm công trong hệ thống.

![Quản lý chấm công](docs/screenshots/attendance-management.png)

---

## IV. Quản lý lương và phụ cấp

### 11. Quản lý bảng lương

Giao diện quản lý thông tin bảng lương nhân viên.

![Quản lý bảng lương](docs/screenshots/payroll-management.png)

### 12. Tính lương nhân viên

Giao diện hỗ trợ thực hiện nghiệp vụ tính lương.

![Tính lương nhân viên](docs/screenshots/salary-calculation.png)

### 13. Quản lý phụ cấp

Giao diện quản lý các khoản phụ cấp dành cho nhân viên.

![Quản lý phụ cấp](docs/screenshots/allowance-management.png)

### 14. Tính phụ cấp

Giao diện tính toán các khoản phụ cấp liên quan đến nhân viên.

![Tính phụ cấp](docs/screenshots/allowance-calculation.png)

### 15. Báo cáo bảng lương

Giao diện tổng hợp và theo dõi báo cáo lương.

![Báo cáo bảng lương](docs/screenshots/payroll-report.png)

---

## V. Quản lý và phân công công việc

### 16. Phân công công việc

Giao diện hỗ trợ quản lý việc giao nhiệm vụ cho nhân viên.

![Phân công công việc](docs/screenshots/task-assignment.png)

### 17. Báo cáo phân công công việc

Giao diện tra cứu và tổng hợp thông tin phân công nhiệm vụ.

![Báo cáo phân công công việc](docs/screenshots/task-assignment-report.png)

---

## VI. Quản lý tài khoản

### 18. Quản lý tài khoản người dùng

Giao diện quản lý thông tin tài khoản và quyền truy cập của người dùng.

![Quản lý tài khoản](docs/screenshots/account-management.png)

---

## VII. Giao diện dành cho nhân viên

### 19. Hồ sơ cá nhân

Cho phép nhân viên xem thông tin cá nhân và thông tin công việc của mình.

![Hồ sơ nhân viên](docs/screenshots/employee-profile.png)

### 20. Công việc của tôi

Giao diện để nhân viên theo dõi các công việc được phân công.

![Công việc của tôi](docs/screenshots/my-tasks.png)

### 21. Lương của tôi

Giao diện để nhân viên xem thông tin lương cá nhân.

![Lương của tôi](docs/screenshots/my-salary.png)

---

## Hướng dẫn cài đặt và chạy ứng dụng

### Yêu cầu hệ thống

- Hệ điều hành Windows.
- Visual Studio 2022.
- Bộ công cụ phát triển .NET Desktop.
- Microsoft SQL Server.
- .NET SDK hoặc runtime phù hợp với cấu hình dự án.

### Các bước cài đặt

**Bước 1: Tải mã nguồn**

Mở PowerShell, Terminal hoặc Git Bash và chạy:

```bash
git clone https://github.com/phat102004/QuanLyNhanSu.git
```

**Bước 2: Mở dự án**

- Mở thư mục mã nguồn vừa tải về.
- Tìm file Solution (`.sln`) hoặc file project (`.csproj`).
- Mở dự án bằng Visual Studio 2022.

**Bước 3: Cấu hình cơ sở dữ liệu**

- Chuẩn bị cơ sở dữ liệu SQL Server theo cấu trúc của dự án.
- Cấu hình chuỗi kết nối phù hợp với SQL Server trên máy.
- Kiểm tra các bảng dữ liệu và tài khoản cần thiết.

**Bước 4: Build và chạy ứng dụng**

- Sử dụng chức năng **Build Solution** trong Visual Studio.
- Kiểm tra và xử lý các lỗi cấu hình nếu có.
- Khởi chạy ứng dụng.
- Đăng nhập bằng tài khoản được thiết lập trong cơ sở dữ liệu.

**Lưu ý:** Ứng dụng yêu cầu kết nối SQL Server. Người dùng cần có cơ sở dữ liệu và cấu hình môi trường phù hợp trước khi sử dụng.

---

## Kiến thức và kỹ năng áp dụng

Thông qua dự án, tôi đã thực hành và vận dụng:

- Lập trình hướng đối tượng bằng C#.
- Xây dựng ứng dụng desktop với Windows Forms.
- Thiết kế giao diện Form và UserControl.
- Kết nối và xử lý dữ liệu với Microsoft SQL Server.
- Thực hiện các thao tác CRUD.
- Xây dựng giao diện theo vai trò người dùng.
- Quản lý nghiệp vụ nhân sự, phòng ban và chức vụ.
- Xử lý nghiệp vụ chấm công, lương và phụ cấp.
- Xây dựng chức năng phân công và theo dõi công việc.
- Quản lý mã nguồn bằng Git và GitHub.

---

## Mục tiêu dự án

Dự án được xây dựng nhằm củng cố kiến thức phát triển ứng dụng quản lý, nâng cao kỹ năng xử lý nghiệp vụ và tổ chức mã nguồn, đồng thời tạo ra sản phẩm thực hành phục vụ học tập và xây dựng Portfolio cá nhân.

## Thông tin tác giả

**GitHub:** [phat102004](https://github.com/phat102004)

**Mã nguồn dự án:** [QuanLyNhanSu](https://github.com/phat102004/QuanLyNhanSu)

---

*Dự án được phát triển nhằm mục đích học tập, thực hành và nâng cao kỹ năng xây dựng ứng dụng quản lý bằng C# WinForms và SQL Server.*
