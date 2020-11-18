SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[XoaThongTinBanDoKeHoach](@ma int)
AS
BEGIN
DELETE dbo.ThongTinBanDoKeHoach
WHERE MaThongTin = @ma
end
GO
