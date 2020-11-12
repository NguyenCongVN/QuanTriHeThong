CREATE TABLE [dbo].[DonVi]
(
[MaDonVi] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[TenDonVi] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[DuongDanAnh] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[MaBinhChung] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DonVi] ADD CONSTRAINT [PK__DonVi__DDA5A6CF1A53F8AB] PRIMARY KEY CLUSTERED  ([MaDonVi]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DonVi] ADD CONSTRAINT [FK__DonVi__MaBinhChu__681373AD] FOREIGN KEY ([MaBinhChung]) REFERENCES [dbo].[BinhChung] ([MaBinhChung])
GO
ALTER TABLE [dbo].[DonVi] ADD CONSTRAINT [FK__DonVi__MaBinhChu__690797E6] FOREIGN KEY ([MaBinhChung]) REFERENCES [dbo].[BinhChung] ([MaBinhChung])
GO
ALTER TABLE [dbo].[DonVi] ADD CONSTRAINT [FK__DonVi__MaBinhChu__69FBBC1F] FOREIGN KEY ([MaBinhChung]) REFERENCES [dbo].[BinhChung] ([MaBinhChung])
GO
