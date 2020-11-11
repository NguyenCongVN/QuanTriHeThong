SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[LayMaChucVuTheoTen](@tenChucVu NVARCHAR(50))
AS
BEGIN
	SELECT DISTINCT MaChucVu FROM dbo.ChucVu 
	WHERE TenChucVu LIKE @tenChucVu
    
END
GO