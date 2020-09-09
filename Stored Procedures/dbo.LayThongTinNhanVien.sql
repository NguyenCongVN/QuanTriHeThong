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
       MaChucVu	 FROM dbo.NguoiDung
INNER JOIN dbo.ThongTinNguoiDung
ON ThongTinNguoiDung.MaDangNhapNguoiDung = NguoiDung.MaDangNhapNguoiDung
WHERE MaChucVu != 'Admin'
end
GO
