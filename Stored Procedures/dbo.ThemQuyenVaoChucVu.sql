SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[ThemQuyenVaoChucVu](@QuyenId VARCHAR(10) , @MaChucVu VARCHAR(50))
AS
BEGIN
INSERT INTO dbo.ThongTinPhanQuyen
        ( QuyenId, MaChucVu )
VALUES  ( @QuyenId, -- QuyenId - varchar(10)
          @MaChucVu  -- MaChucVu - varchar(50)
          )
END
GO
