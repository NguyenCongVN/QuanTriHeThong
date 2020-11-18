SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[XoaThongTinFileDemKeHoach](@maThongTin int)
AS
BEGIN
DELETE
FROM dbo.ThongTinFileDemKeHoach
WHERE MaThongTinDuLieu = @maThongTin
END
GO
