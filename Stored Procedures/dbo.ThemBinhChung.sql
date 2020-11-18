SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[ThemBinhChung](@maBinhChung varCHAR(10), @tenBinhChung NVARCHAR(50))
AS
BEGIN
	IF NOT EXISTS( SELECT MaBinhChung FROM dbo.BinhChung WHERE MaBinhChung = @maBinhChung)
		BEGIN
			INSERT INTO dbo.BinhChung
			(MaBinhChung,TenBinhChung)
			VALUES
			(@maBinhChung, @tenBinhChung)
			PRINT(N'1')
		END
	ELSE
		BEGIN
			PRINT(N'0')
		END
END

GO
