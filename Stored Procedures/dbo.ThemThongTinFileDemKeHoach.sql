SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[ThemThongTinFileDemKeHoach](@maFile INT , @maKeHoach int)
AS
BEGIN
INSERT INTO dbo.ThongTinFileDemKeHoach
        ( MaFile, MaKeHoach )
VALUES  ( @maFile, -- MaFile - int
          @maKeHoach  -- MaKeHoach - int
          )
END
GO
