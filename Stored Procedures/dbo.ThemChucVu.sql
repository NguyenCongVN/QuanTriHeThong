SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[ThemChucVu](@maChucVu VARCHAR(50), @tenChucVu NVARCHAR(50))
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM dbo.ChucVu WHERE TenChucVu LIKE @tenChucVu OR MaChucVu LIKE @maChucVu)
		BEGIN
			INSERT INTO dbo.ChucVu
			(MaChucVu,TenChucVu)
			VALUES
			(@maChucVu, @tenChucVu)	
			PRINT N'1'
		END
	ELSE
		BEGIN
			PRINT(N'0')
        END
END
GO
