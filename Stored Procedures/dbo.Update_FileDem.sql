SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[Update_FileDem](@TenFile VARCHAR(50), @DuongDan VARCHAR(150) , @MaFile int)
AS BEGIN
	UPDATE FileDem SET DuongDan = @DuongDan,
	TenFile = @TenFile
	WHERE MaFile = @MaFile
END


GO
