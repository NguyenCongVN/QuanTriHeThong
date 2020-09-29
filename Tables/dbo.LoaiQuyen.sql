CREATE TABLE [dbo].[LoaiQuyen]
(
[LoaiQuyenId] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[MoTa] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LoaiQuyen] ADD CONSTRAINT [PK_LoaiQuyen] PRIMARY KEY CLUSTERED  ([LoaiQuyenId]) ON [PRIMARY]
GO
