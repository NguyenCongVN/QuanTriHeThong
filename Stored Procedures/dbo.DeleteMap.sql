SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[DeleteMap](@maBanDo INT)
AS
BEGIN
DELETE FROM dbo.BanDo
WHERE MaBanDo = @maBanDo
end
GO
