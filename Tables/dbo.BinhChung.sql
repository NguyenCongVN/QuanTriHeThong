CREATE TABLE [dbo].[BinhChung]
(
[MaBinhChung] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[TenBinhChung] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BinhChung] ADD CONSTRAINT [PK__BinhChun__F79756074896008A] PRIMARY KEY CLUSTERED  ([MaBinhChung]) ON [PRIMARY]
GO
