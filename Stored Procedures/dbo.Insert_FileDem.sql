SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [dbo].[Insert_FileDem] (@TenFile VARCHAR(50), @DuongDan VARCHAR(150))
AS BEGIN
	INSERT  FileDem(TenFile, DuongDan) VALUES(@TenFile, @DuongDan)
	END


GO