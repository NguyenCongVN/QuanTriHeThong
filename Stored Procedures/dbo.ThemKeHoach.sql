
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [dbo].[ThemKeHoach](@name NVARCHAR(200) , @maNguoiLapKeHoach VARCHAR(10))
AS
BEGIN
INSERT INTO dbo.KeHoach
        ( TenKeHoach, MaNguoiLapKeHoach ,ThoiGianTao )
OUTPUT Inserted.MaKeHoach
VALUES  ( @name, -- TenKeHoach - nvarchar(200)
          @maNguoiLapKeHoach  -- MaNguoiLapKeHoach - varchar(10)
          , GETDATE())
END
GO
