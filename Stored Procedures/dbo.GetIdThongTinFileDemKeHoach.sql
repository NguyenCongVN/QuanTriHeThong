SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[GetIdThongTinFileDemKeHoach](@maFileDem int , @maKeHoach int)
AS
BEGIN
SELECT MaThongTinDuLieu
FROM dbo.ThongTinFileDemKeHoach
WHERE MaFile = @maFileDem AND MaKeHoach =@maKeHoach
END
GO
