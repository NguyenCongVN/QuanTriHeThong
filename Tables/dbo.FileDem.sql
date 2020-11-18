CREATE TABLE [dbo].[FileDem]
(
[TenFile] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[DuongDan] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[MaFile] [int] NOT NULL IDENTITY(1, 1)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[FileDem] ADD CONSTRAINT [PK_FileDem] PRIMARY KEY CLUSTERED  ([MaFile]) ON [PRIMARY]
GO
