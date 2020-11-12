SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[CapNhatThongTinDoiTuong](@moTa NVARCHAR(250)
 ,@maDoiTuong INT , @tenDoiTuong NVARCHAR(50) ,
  @chieuNgang INT , @chieuDoc INT , @toaDoX INT , @toaDoY int)
AS
BEGIN
UPDATE dbo.DoiTuong SET
       MoTa = @moTa ,
       ToaDoX = @toaDoX ,
       ToaDoY = @toaDoY ,
	   ChieuNgang = @chieuNgang,
	   ChieuDoc = @chieuDoc,
	   TenDoiTuong = @tenDoiTuong
	   WHERE MaDoiTuong = @maDoiTuong
END
GO
