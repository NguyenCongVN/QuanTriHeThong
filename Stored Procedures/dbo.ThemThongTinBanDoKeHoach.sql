SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[ThemThongTinBanDoKeHoach](@maBanDo INT , @maKeHoach INT) AS 
BEGIN
INSERT INTO dbo.ThongTinBanDoKeHoach
        ( MaBanDo ,
          MaKeHoach 
        )
VALUES  ( @maBanDo , -- MaBanDo - int
          @maKeHoach  -- MaKeHoach - int
        )
END
GO
