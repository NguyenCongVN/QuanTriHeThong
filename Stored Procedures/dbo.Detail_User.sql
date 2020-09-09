SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[Detail_User](@MA VARCHAR(10))
AS
BEGIN
	SELECT MaDangNhapNguoiDung,
            SoDienThoai,
            HoTen,
            Email,
            NgayTao,
            DiaChi,
            NgaySinh,
            MaChucVu FROM ThongTinNguoiDung WHERE MaDangNhapNguoiDung = @MA
END


--sửa đôi thông tin

GO
