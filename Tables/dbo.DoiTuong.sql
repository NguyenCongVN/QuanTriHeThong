CREATE TABLE [dbo].[DoiTuong]
(
[MaDonVi] [char] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[MoTa] [nvarchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[ToaDoX] [int] NOT NULL,
[ToaDoY] [int] NOT NULL,
[MaKeHoach] [int] NOT NULL,
[ChieuRongAnh] [int] NOT NULL,
[ChieuDaiAnh] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DoiTuong] ADD CONSTRAINT [PK_DoiTuong] PRIMARY KEY CLUSTERED  ([MaDonVi], [MaKeHoach]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DoiTuong] ADD CONSTRAINT [FK_DonVi] FOREIGN KEY ([MaDonVi]) REFERENCES [dbo].[DonVi] ([MaDonVi])
GO
ALTER TABLE [dbo].[DoiTuong] ADD CONSTRAINT [FK_DoiTuong_KeHoach] FOREIGN KEY ([MaKeHoach]) REFERENCES [dbo].[KeHoach] ([MaKeHoach])
GO
