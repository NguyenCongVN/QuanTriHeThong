SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[LayTTDonViTheoBinhChung](@mabinhchung CHAR(10))
AS
BEGIN 
	SELECT MaDonVi, TenDonVi, DuongDanAnh
	FROM dbo.BinhChung LEFT JOIN dbo.DonVi ON DonVi.MaBinhChung = BinhChung.MaBinhChung
	WHERE BinhChung.MaBinhChung = @mabinhchung
END
GO
