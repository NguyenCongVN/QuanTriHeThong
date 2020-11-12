SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[ThemDonVi](@maDonVi CHAR(10), @tenDonVi NVARCHAR(50), @duongDanAnh VARCHAR(250), @maBinhChung CHAR(10))
AS
BEGIN
	IF NOT EXISTS( SELECT MaDonVi FROM dbo.DonVi WHERE MaDonVi = @maDonVi)
		BEGIN
			INSERT INTO dbo.DonVi
			(MaDonVi,TenDonVi,DuongDanAnh,MaBinhChung)
			VALUES
			(@maDonVi,@tenDonVi,@duongDanAnh,@maBinhChung)
			PRINT(N'1')
		END
	ELSE
		BEGIN
			PRINT(N'0')
		END
END
GO
