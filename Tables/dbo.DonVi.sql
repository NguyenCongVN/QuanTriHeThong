CREATE TABLE [dbo].[DonVi]
(
[MaDonVi] [char] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[TenDonVi] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[DuongDanAnh] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[MaBinhChung] [char] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DonVi] ADD CONSTRAINT [PK__DonVi__DDA5A6CF895941A5] PRIMARY KEY CLUSTERED  ([MaDonVi]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DonVi] ADD CONSTRAINT [FK__DonVi__MaBinhChu__7755B73D] FOREIGN KEY ([MaBinhChung]) REFERENCES [dbo].[BinhChung] ([MaBinhChung])
GO
