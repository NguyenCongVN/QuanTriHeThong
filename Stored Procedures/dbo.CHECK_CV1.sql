SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[CHECK_CV1](@maDN varchar(10))
as begin
	select *from Quyen
	where QuyenId in
	(select QuyenId from ThongTinPhanQuyen where MaChucVu in
	(select MaChucVu from ThongTinNguoiDung where MaDangNhapNguoiDung = @maDN))
	end
GO
