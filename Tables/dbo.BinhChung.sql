CREATE TABLE [dbo].[BinhChung]
(
[MaBinhChung] [char] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[TenBinhChung] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BinhChung] ADD CONSTRAINT [PK__BinhChun__F7975607045416AA] PRIMARY KEY CLUSTERED  ([MaBinhChung]) ON [PRIMARY]
GO
