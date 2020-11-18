SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[XoaBinhChung](@maBinhChung varCHAR(10))
AS
BEGIN
	DELETE dbo.DonVi WHERE MaBinhChung = @maBinhChung
	DELETE dbo.BinhChung WHERE MaBinhChung = @maBinhChung
END

GO
