SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[SuaTenChucVu](@tenChucVu_Cu NVARCHAR(50),@tenChucVu_Moi NVARCHAR(50))
AS
BEGIN
	IF @tenChucVu_Cu IN (SELECT TenChucVu FROM dbo.ChucVu)
	BEGIN
		UPDATE dbo.ChucVu 
		SET TenChucVu = @tenChucVu_Moi
		WHERE MaChucVu IN (SELECT MaChucVu FROM dbo.ChucVu WHERE TenChucVu LIKE @tenChucVu_Cu)
	END
END
GO
