CREATE TABLE NhanVien (
    NhanVienID INT IDENTITY(1,1) PRIMARY KEY,
    MaNhanVien NVARCHAR(50) NOT NULL UNIQUE,
    HoTen NVARCHAR(150) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(20),
    Email NVARCHAR(100),
    CMND_CCCD NVARCHAR(20),
    NgayVaoLam DATE,
    TrangThaiLamViec NVARCHAR(50) DEFAULT N'Đang làm việc',
    PhongBanID INT NULL,
    ChucVuID INT NULL,
	TrinhDoID INT null,
	CONSTRAINT FK_NhanVien_TrinhDo FOREIGN KEY (TrinhDoID) REFERENCES TrinhDo(TrinhDoID),
	CONSTRAINT FK_NhanVien_PhongBan FOREIGN KEY (PhongBanID) REFERENCES PhongBan(PhongBanID),
    CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY (ChucVuID) REFERENCES ChucVu(ChucVuID),
);
GO

CREATE TABLE PhongBan (
    PhongBanID INT IDENTITY(1,1) PRIMARY KEY,
    MaPhongBan NVARCHAR(50) NOT NULL UNIQUE,
    TenPhongBan NVARCHAR(100) NOT NULL,
);
GO

CREATE TABLE ChucVu (
    ChucVuID INT IDENTITY(1,1) PRIMARY KEY,
    TenChucVu NVARCHAR(100) NOT NULL,
	Luong Decimal(18,2)
);
GO


CREATE TABLE TrinhDo (
	TrinhDoID int IDENTITY(1,1) PRIMARY KEY,
	TenTrinhDo NVARCHAR(50)
);
GO

ALTER TABLE TrinhDo
ADD MaTrinhDo NVARCHAR(50) NULL;
UPDATE TrinhDo SET MaTrinhDo = 'TD001' WHERE TrinhDoID = 1; 
UPDATE TrinhDo SET MaTrinhDo = 'TD002' WHERE TrinhDoID = 2; 
UPDATE TrinhDo SET MaTrinhDo = 'TD003' WHERE TrinhDoID = 3; 
UPDATE TrinhDo SET MaTrinhDo = 'TD004' WHERE TrinhDoID = 4; 
UPDATE TrinhDo SET MaTrinhDo = 'TD005' WHERE TrinhDoID = 5; 

CREATE TABLE PhuCap (
    PhuCapID INT IDENTITY(1,1) PRIMARY KEY,
    MaPhuCap NVARCHAR(50) NOT NULL UNIQUE,
    TenPhuCap NVARCHAR(100) NOT NULL,
    SoTien Decimal(18,2) NOT NULL
);
GO


CREATE TABLE TinhLuong (
    TinhLuongID INT IDENTITY(1,1) PRIMARY KEY,
    MaLuong NVARCHAR(50) NOT NULL UNIQUE,    
    NhanVienID INT NOT NULL,                 
    SoNgayCong INT NOT NULL,                  
    TongPhuCap DECIMAL(18, 2) DEFAULT 0,               
    TongLuong DECIMAL(18, 2) DEFAULT 0,                
    NgayTinhLuong DATE DEFAULT GETDATE(),      
    CONSTRAINT FK_TinhLuong_NhanVien FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);
GO

UPDATE TinhLuong
SET TongLuong = (cv.Luong / 26 * tl.SoNgayCong) + tl.TongPhuCap
FROM TinhLuong tl
JOIN NhanVien nv ON tl.NhanVienID = nv.NhanVienID
JOIN ChucVu cv ON nv.ChucVuID = cv.ChucVuID;

CREATE TABLE Luong (
    LuongID INT IDENTITY(1,1) PRIMARY KEY,       
    MaLuongTong NVARCHAR(50) NOT NULL UNIQUE,    
    NhanVienID INT NOT NULL,                     
    SoNgayCong INT,
    TongPhuCap DECIMAL(18, 2),
    TongLuong DECIMAL(18, 2),
    NgayTinhLuong DATE,
    NgayLap DATE DEFAULT GETDATE(),              
    CONSTRAINT FK_Luong_NhanVien FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);

CREATE TABLE CongViec (
    CongViecID INT IDENTITY(1,1) PRIMARY KEY,         
    NhanVienID INT NOT NULL,                           
    TenCongViec NVARCHAR(100) NOT NULL,               
    NgayGiao DATE DEFAULT GETDATE(),                
    HanHoanThanh DATE,                              
    TrangThai NVARCHAR(50) 
        CHECK (TrangThai IN (N'Chưa hoàn thành', N'Hoàn thành')) 
        DEFAULT N'Chưa hoàn thành',              
    CONSTRAINT FK_CongViec_NhanVien FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);

CREATE TABLE Quyen (
    QuyenID INT IDENTITY(1,1) PRIMARY KEY,
    TenQuyen NVARCHAR(100) NOT NULL UNIQUE,
    MoTa NVARCHAR(255)
);

CREATE TABLE NhanVien_PhuCap (
    NhanVienID INT NOT NULL,
    PhuCapID INT NOT NULL,
    SoTien DECIMAL(18,2) NOT NULL DEFAULT 0,
    PRIMARY KEY (NhanVienID, PhuCapID),
    CONSTRAINT FK_NVPC_NhanVien FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID),
    CONSTRAINT FK_NVPC_PhuCap FOREIGN KEY (PhuCapID) REFERENCES PhuCap(PhuCapID)
);
GO

CREATE TABLE TaiKhoan (
    TaiKhoanID INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(255) NOT NULL,      
    NhanVienID INT NOT NULL,
    QuyenID INT NOT NULL,

    CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID),
    CONSTRAINT FK_TaiKhoan_Quyen FOREIGN KEY (QuyenID) REFERENCES Quyen(QuyenID)
);
GO

CREATE TABLE Quyen_Form (
    QuyenID INT,
    TenForm NVARCHAR(100),   
    PRIMARY KEY (QuyenID, TenForm),

    CONSTRAINT FK_QF_Quyen FOREIGN KEY (QuyenID) REFERENCES Quyen(QuyenID)
);
GO


CREATE TABLE ChamCong (
    ChamCongID INT IDENTITY(1,1) PRIMARY KEY,
    NhanVienID INT NOT NULL,
    NgayChamCong DATE NOT NULL,
    GioVao DATETIME NOT NULL,
    GioRa DATETIME NULL,             
    TongGioLam DECIMAL(4, 2) NULL,     
    TrangThai NVARCHAR(50) NOT NULL,   
    GhiChu NVARCHAR(255) NULL,
    CONSTRAINT FK_ChamCong_NhanVien FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID),
	CONSTRAINT UQ_NhanVien_Ngay UNIQUE (NhanVienID, NgayChamCong)
);
GO

CREATE TABLE NgayCongThang (
    NgayCongThangID INT IDENTITY(1,1) PRIMARY KEY,
    NhanVienID INT NOT NULL,
    Thang INT NOT NULL,
    Nam INT NOT NULL,
    SoNgayCong DECIMAL(4, 2) NOT NULL DEFAULT 0,
    CONSTRAINT FK_NgayCongThang_NhanVien FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID),
    CONSTRAINT UQ_NhanVien_ThangNam UNIQUE (NhanVienID, Thang, Nam)
);
GO

INSERT INTO NhanVien 
(MaNhanVien, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, CMND_CCCD, NgayVaoLam, TrinhDoID, PhongBanID, ChucVuID)
VALUES
(N'NV001', N'Nguyễn Văn A', '1990-05-12', N'Nam', N'123 Nguyễn Trãi, Hà Nội', N'0912345678', N'a.nguyen@fpt.com', N'012345678', '2020-03-15', 3, 1, 2),  
(N'NV002', N'Trần Thị B', '1993-07-20', N'Nữ', N'45 Lê Lợi, Đà Nẵng', N'0938123456', N'b.tran@fpt.com', N'123456789', '2021-06-10', 4, 2, 2),          
(N'NV003', N'Lê Văn C', '1988-02-02', N'Nam', N'89 Pasteur, TP.HCM', N'0905123987', N'c.le@fpt.com', N'234567890', '2019-01-25', 3, 3, 1),           
(N'NV004', N'Phạm Thị D', '1995-09-14', N'Nữ', N'22 Nguyễn Huệ, Cần Thơ', N'0978456123', N'd.pham@fpt.com', N'345678901', '2022-08-01', 2, 1, 1),   
(N'NV005', N'Hoàng Văn E', '1992-11-03', N'Nam', N'55 Hai Bà Trưng, Hải Phòng', N'0987345612', N'e.hoang@fpt.com', N'456789012', '2018-12-10', 3, 4, 3);
GO

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, NhanVienID, QuyenID)
VALUES
(N'NV001', N'123', 8, 2),
(N'NV002', N'123', 9, 2),
(N'NV003', N'123', 10, 4),
(N'nv004', N'123', 11, 3),
(N'NV005', N'123', 12, 1);
GO

INSERT INTO TrinhDo (TenTrinhDo)
VALUES 
(N'Trung cấp'),
(N'Cao đẳng'),
(N'Đại học'),
(N'Thạc sĩ'),
(N'Tốt nghiệp phổ thông');
GO

INSERT INTO PhongBan (MaPhongBan, TenPhongBan)
VALUES 
(N'PB001', N'Hành chính - Nhân sự'),
(N'PB002', N'Kế toán - Tài chính'),
(N'PB003', N'Kỹ thuật'),
(N'PB004', N'Kinh doanh'),
(N'PB005', N'Marketing');
GO

INSERT INTO ChucVu (ChucVuID ,TenChucVu, Luong) VALUES
(1,N'Thực tập sinh', 4000000),
(2,N'Nhân viên', 7000000),
(3,N'Phó phòng', 10000000),
(4,N'Trưởng phòng', 15000000),
(5,N'Giám đốc', 25000000);
INSERT INTO PhuCap (MaPhuCap, TenPhuCap, SoTien)
VALUES
(N'PC001', N'Phụ cấp ăn trưa', 1000000),
(N'PC002', N'Phụ cấp chuyên cần', 500000),
(N'PC003', N'Phụ cấp làm thêm giờ', 300000),
(N'PC004', N'Thưởng năng suất', 1500000),
(N'PC005', N'Phụ cấp xăng xe', 400000);
Go

INSERT INTO Quyen (TenQuyen, MoTa)
VALUES
(N'Admin', N'Quyền cao nhất'),
(N'NhanVien', N'Nhân viên bình thường'),
(N'TruongPhong', N'Trưởng phòng'),
(N'KeToan', N'Trách nhiệm tính lương');

INSERT INTO CongViec (NhanVienID, TenCongViec, NgayGiao, HanHoanThanh, TrangThai)
VALUES
(8, N'Phân tích yêu cầu dự án A', GETDATE(), DATEADD(day, 7, GETDATE()), N'Chưa hoàn thành'), -- Công việc của NV001 (ID=8)
(8, N'Viết báo cáo hàng tuần', DATEADD(day, -5, GETDATE()), DATEADD(day, -1, GETDATE()), N'Hoàn thành'), -- Công việc của NV001 (ID=8)
(9, N'Chuẩn bị hồ sơ thanh toán tháng 11', GETDATE(), DATEADD(day, 10, GETDATE()), N'Chưa hoàn thành'), -- Công việc của NV002 (ID=9)
(12, N'Kiểm tra hiệu suất hệ thống', GETDATE(), DATEADD(day, 5, GETDATE()), N'Chưa hoàn thành'); -- Công việc của NV005 (Admin, ID=12)
GO