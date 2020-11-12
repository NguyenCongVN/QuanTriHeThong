SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[ChinhSuaDonVi](@maDonVi varCHAR(10), @tenDonVi NVARCHAR(50), @duongDanAnh VARCHAR(250))
AS
BEGIN
	IF EXISTS(SELECT MaDonVi FROM dbo.DonVi)
		BEGIN
			UPDATE dbo.DonVi
			SET TenDonVi = @tenDonVi, DuongDanAnh = @duongDanAnh
			WHERE MaDonVi = @maDonVi
			PRINT(N'1')
		END
	ELSE
		BEGIN
			PRINT(N'0')
		END
END

GO
