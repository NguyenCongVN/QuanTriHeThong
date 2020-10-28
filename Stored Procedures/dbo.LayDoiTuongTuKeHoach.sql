SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[LayDoiTuongTuKeHoach](@maKeHoach int)
AS
BEGIN
SELECT * FROM dbo.DoiTuong
WHERE MaKeHoach = @maKeHoach
end
GO
