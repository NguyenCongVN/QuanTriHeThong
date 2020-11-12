SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[GetIdThongTinBanDoKeHoach](@maBanDo INT , @maKeHoach INT)
AS
BEGIN
SELECT MaThongTin
FROM dbo.ThongTinBanDoKeHoach
WHERE MaBanDo = @maBanDo AND MaKeHoach = @maKeHoach
END
GO
