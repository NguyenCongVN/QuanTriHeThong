SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[LayThongTinCacQuyen]
AS
BEGIN
SELECT QuyenId, Quyen.MoTa, Quyen.LoaiQuyenId
FROM dbo.Quyen JOIN dbo.LoaiQuyen ON LoaiQuyen.LoaiQuyenId = Quyen.LoaiQuyenId
END
GO
