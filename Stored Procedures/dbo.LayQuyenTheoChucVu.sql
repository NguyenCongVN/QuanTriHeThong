SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[LayQuyenTheoChucVu](@tenChucVu NVARCHAR(50))
AS
BEGIN
	SELECT TenChucVu, LoaiQuyen.MoTa AS LoaiQuyen, Quyen.MoTa AS Quyen
	FROM dbo.ChucVu JOIN dbo.ThongTinPhanQuyen ON ThongTinPhanQuyen.MaChucVu = ChucVu.MaChucVu
	JOIN dbo.Quyen ON Quyen.QuyenId = ThongTinPhanQuyen.QuyenId 
	JOIN dbo.LoaiQuyen ON LoaiQuyen.LoaiQuyenId = Quyen.LoaiQuyenId
	WHERE dbo.ChucVu.TenChucVu LIKE @tenChucVu
END
-------

GO
