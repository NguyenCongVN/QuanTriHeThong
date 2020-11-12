SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[LayKeHoachBanDoFileBangMa](@maKeHoach INT)
AS
BEGIN
SELECT KeHoach.MaKeHoach ,
       TenKeHoach ,
       HoTen ,
	   NguoiDung.MaDangNhapNguoiDung,
       ThoiGianTao ,
       BanDo.MaBanDo ,
       TenBanDo ,
       DuongDanAnh ,
       TenFile ,
       DuongDan ,
       FileDem.MaFile
	    FROM dbo.KeHoach
INNER JOIN dbo.NguoiDung
ON NguoiDung.MaDangNhapNguoiDung = KeHoach.MaNguoiLapKeHoach
INNER JOIN dbo.ThongTinNguoiDung
ON ThongTinNguoiDung.MaDangNhapNguoiDung = NguoiDung.MaDangNhapNguoiDung
LEFT JOIN dbo.ThongTinFileDemKeHoach
ON ThongTinFileDemKeHoach.MaKeHoach = KeHoach.MaKeHoach
LEFT JOIN dbo.ThongTinBanDoKeHoach
ON ThongTinBanDoKeHoach.MaKeHoach = KeHoach.MaKeHoach
LEFT JOIN dbo.BanDo
ON BanDo.MaBanDo = ThongTinBanDoKeHoach.MaBanDo
LEFT JOIN dbo.FileDem
ON FileDem.MaFile = ThongTinFileDemKeHoach.MaFile
WHERE KeHoach.MaKeHoach = @maKeHoach
END
GO
