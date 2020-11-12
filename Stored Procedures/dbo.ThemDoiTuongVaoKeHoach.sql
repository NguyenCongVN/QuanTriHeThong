SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO


CREATE PROC [dbo].[ThemDoiTuongVaoKeHoach](@maDonVi VARCHAR(10) ,
@moTa NVARCHAR(250),
@toaDoX INT,
@toaDoY INT,
@maKeHoach INT,
@chieuRongAnh INT,
@chieuDaiAnh INT,
@chieuNgang INT , 
@chieuDoc INT,
@tenDoiTuong nvarchar(50))
AS
BEGIN
INSERT INTO dbo.DoiTuong
        ( MaDonVi ,
          MoTa ,
          ToaDoX ,
          ToaDoY ,
          MaKeHoach ,
          ChieuRongAnh ,
          ChieuDaiAnh,
		  ChieuNgang,
		  ChieuDoc,
		  TenDoiTuong
        )
VALUES  ( @maDonVi , -- MaDonVi - char(10)
          @moTa , -- MoTa - nvarchar(250)
          @toaDoX , -- ToaDoX - int
          @toaDoY , -- ToaDoY - int
          @maKeHoach , -- MaKeHoach - int
          @chieuRongAnh , -- ChieuRongAnh - int
          @chieuDaiAnh,  -- ChieuDaiAnh - int
		  @chieuNgang,
		  @chieuDoc,
		  @tenDoiTuong
        )
END


GO
