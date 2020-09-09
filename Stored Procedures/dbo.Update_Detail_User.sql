SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE proc [dbo].[Update_Detail_User](@MA char(10), @SDT varCHAR(10), @HOTEN NVARCHAR(50),
@EMAIL VARCHAR(50), @NGAYTAO DATETIME, @DC NVARCHAR(200), @NS DATE, @CHUCVU VARCHAR(50))
as begin
	update ThongTinNguoiDung
	SET SoDienThoai = @SDT, HoTen = @HOTEN, Email = @EMAIL,
	NgaySinh = @NS, NgayTao = @NGAYTAO, DiaChi = @DC,MaChucVu = @CHUCVU
	WHERE MaDangNhapNguoiDung = @MA
END


GO
