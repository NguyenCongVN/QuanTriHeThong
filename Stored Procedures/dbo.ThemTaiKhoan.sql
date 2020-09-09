SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[ThemTaiKhoan](@maDangNhapNguoiDung VARCHAR(10), 
@matKhau VARCHAR(100) , @chucVu VARCHAR(50),@soDienThoai VARCHAR(10),@hoTen NVARCHAR(50),
@email VARCHAR(50) , @diaChi NVARCHAR(200),
@ngaySinh DATE)
AS
BEGIN 
-- Gan thong tin vao hai bang nguoi dung va thong tin nguoi dung

IF NOT EXISTS(SELECT MaDangNhapNguoiDung FROM dbo.NguoiDung WHERE MaDangNhapNguoiDung = @maDangNhapNguoiDung)
BEGIN
INSERT INTO dbo.NguoiDung
        ( MaDangNhapNguoiDung, MatKhau )
VALUES  ( @maDangNhapNguoiDung, -- MaDangNhapNguoiDung - varchar(10)
          @matKhau  -- MatKhau - varchar(50)
          )
INSERT INTO dbo.ThongTinNguoiDung
        ( MaDangNhapNguoiDung ,
          SoDienThoai ,
          HoTen ,
          Email ,
          DiaChi ,
          NgaySinh ,
		  MaChucVu
        )
VALUES  ( @maDangNhapNguoiDung , -- MaDangNhapNguoiDung - varchar(10)
          @soDienThoai , -- SoDienThoai - char(10)
          @hoTen , -- HoTen - nvarchar(50)
          @email , -- Email - varchar(50)
          @diaChi , -- DiaChi - nvarchar(200)
          @ngaySinh,  -- NgaySinh - date
		  @chucVu
        )
PRINT(N'1')
END
ELSE
BEGIN
PRINT(N'0')
END
END

GO
