CREATE TABLE [dbo].[DoiTuong]
(
[MaDoiTuong] [int] NOT NULL IDENTITY(1, 1),
[MaDonVi] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[MoTa] [nvarchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[ToaDoX] [int] NOT NULL,
[ToaDoY] [int] NOT NULL,
[MaKeHoach] [int] NOT NULL,
[ChieuRongAnh] [int] NOT NULL,
[ChieuDaiAnh] [int] NOT NULL,
[TenDoiTuong] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[ChieuNgang] [int] NULL,
[ChieuDoc] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DoiTuong] ADD CONSTRAINT [PK_DoiTuong] PRIMARY KEY CLUSTERED  ([MaDoiTuong]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DoiTuong] ADD CONSTRAINT [FK_DonVi] FOREIGN KEY ([MaDonVi]) REFERENCES [dbo].[DonVi] ([MaDonVi])
GO
ALTER TABLE [dbo].[DoiTuong] ADD CONSTRAINT [FK_KeHoach] FOREIGN KEY ([MaKeHoach]) REFERENCES [dbo].[KeHoach] ([MaKeHoach])
GO
