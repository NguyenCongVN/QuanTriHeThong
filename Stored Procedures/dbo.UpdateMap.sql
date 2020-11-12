SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
 CREATE PROC [dbo].[UpdateMap](@TenBanDo NVARCHAR(max) , @DuongDanAnh VARCHAR(max) , @MaBanDo int)
 AS
 begin
UPDATE dbo.BanDo
SET TenBanDo = @TenBanDo,
DuongDanAnh = @DuongDanAnh
WHERE MaBanDo = @MaBanDo
 end
GO
