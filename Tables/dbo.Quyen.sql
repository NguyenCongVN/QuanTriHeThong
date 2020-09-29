CREATE TABLE [dbo].[Quyen]
(
[QuyenId] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[MoTa] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[LoaiQuyenId] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Quyen] ADD CONSTRAINT [PK__Quyen__12926E6C39DA440F] PRIMARY KEY CLUSTERED  ([QuyenId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Quyen] ADD CONSTRAINT [FK_Quyen_LoaiQuyen1] FOREIGN KEY ([LoaiQuyenId]) REFERENCES [dbo].[LoaiQuyen] ([LoaiQuyenId])
GO
