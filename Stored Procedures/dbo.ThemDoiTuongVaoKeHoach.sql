SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[ThemDoiTuongVaoKeHoach](@maDonVi char(10) ,
@moTa nvarchar(250),
@toaDoX INT,
@toaDoY INT,
@maKeHoach INT,
@chieuRongAnh INT,
@chieuDaiAnh int )
AS
BEGIN
INSERT INTO dbo.DoiTuong
        ( MaDonVi ,
          MoTa ,
          ToaDoX ,
          ToaDoY ,
          MaKeHoach ,
          ChieuRongAnh ,
          ChieuDaiAnh
        )
VALUES  ( @maDonVi , -- MaDonVi - char(10)
          @moTa , -- MoTa - nvarchar(250)
          @toaDoX , -- ToaDoX - int
          @toaDoY , -- ToaDoY - int
          @maKeHoach , -- MaKeHoach - int
          @chieuRongAnh , -- ChieuRongAnh - int
          @chieuDaiAnh  -- ChieuDaiAnh - int
        )
end
GO
