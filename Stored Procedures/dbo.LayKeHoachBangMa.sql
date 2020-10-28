SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[LayKeHoachBangMa](@maKeHoach INT)
AS
BEGIN
SELECT keHoach.MaKeHoach ,
       keHoach.TenKeHoach ,
	   thongTinNguoiDung.HoTen ,
	   keHoach.ThoiGianTao,
       nguoiDung.MaDangNhapNguoiDung
	    FROM dbo.KeHoach keHoach
INNER JOIN dbo.NguoiDung nguoiDung
ON nguoiDung.MaDangNhapNguoiDung = keHoach.MaNguoiLapKeHoach
INNER JOIN dbo.ThongTinNguoiDung thongTinNguoiDung
ON thongTinNguoiDung.MaDangNhapNguoiDung = nguoiDung.MaDangNhapNguoiDung
WHERE keHoach.MaKeHoach = @maKeHoach
End
GO
