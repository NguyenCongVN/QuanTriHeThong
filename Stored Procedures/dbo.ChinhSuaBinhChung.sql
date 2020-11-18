SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[ChinhSuaBinhChung](@maBinhChung varCHAR(10), @tenBinhChung NVARCHAR(50))
AS
BEGIN
	IF EXISTS(SELECT MaBinhChung FROM dbo.BinhChung)
		BEGIN
			UPDATE dbo.BinhChung
			SET TenBinhChung = @tenBinhChung
			WHERE MaBinhChung = @maBinhChung
			PRINT(N'1')
		END
	ELSE
		BEGIN
			PRINT(N'0')
		END
END

GO
