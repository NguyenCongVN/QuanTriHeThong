SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[UpdateKeHoach](@maKeHoach INT , @tenKeHoach NVARCHAR(200)
,@thoiGianTao DATETIME)
AS
BEGIN
UPDATE dbo.KeHoach
SET TenKeHoach = @tenKeHoach,
ThoiGianTao = @thoiGianTao
WHERE MaKeHoach = @maKeHoach
END
GO
