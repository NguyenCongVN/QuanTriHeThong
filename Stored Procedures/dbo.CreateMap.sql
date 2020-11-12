SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
 CREATE PROC [dbo].[CreateMap](@TenBanDo NVARCHAR(max) , @DuongDanAnh VARCHAR(max))
 AS
 begin
 INSERT INTO dbo.BanDo
         ( TenBanDo, DuongDanAnh )
 VALUES  ( @TenBanDo, -- TenBanDo - nvarchar(max)
           @DuongDanAnh  -- DuongDanAnh - varchar(max)
           )
 end
GO
