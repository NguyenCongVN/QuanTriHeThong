SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[XoaNhanVien](@maDangNhap VARCHAR(10))
AS
BEGIN
	DELETE FROM dbo.ThongTinNguoiDung WHERE MaDangNhapNguoiDung LIKE @maDangNhap
	DELETE FROM dbo.NguoiDung WHERE MaDangNhapNguoiDung LIKE @maDangNhap
END
GO
