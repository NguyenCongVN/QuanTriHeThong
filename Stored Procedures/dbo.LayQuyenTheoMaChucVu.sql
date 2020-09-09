SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[LayQuyenTheoMaChucVu](@maChucVu varchar(50))
AS
BEGIN
SELECT Quyen.QuyenId
FROM dbo.Quyen
INNER JOIN dbo.ThongTinPhanQuyen
ON ThongTinPhanQuyen.QuyenId = Quyen.QuyenId
INNER JOIN dbo.ChucVu
ON ChucVu.MaChucVu = ThongTinPhanQuyen.MaChucVu
WHERE ChucVu.MaChucVu = @maChucVu
end
GO
