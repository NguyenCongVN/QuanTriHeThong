SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[LayThongTinNhanVien]
AS
BEGIN
SELECT NguoiDung.MaDangNhapNguoiDung ,
       SoDienThoai ,
       HoTen ,
       Email ,
       NgayTao ,
       DiaChi ,
       NgaySinh ,
       dbo.ChucVu.TenChucVu AS TenChucVu
	   FROM dbo.NguoiDung INNER JOIN dbo.ThongTinNguoiDung ON ThongTinNguoiDung.MaDangNhapNguoiDung = NguoiDung.MaDangNhapNguoiDung
	   INNER JOIN dbo.ChucVu ON ChucVu.MaChucVu = ThongTinNguoiDung.MaChucVu
WHERE dbo.ThongTinNguoiDung.MaChucVu != 'Admin'
END
GO
