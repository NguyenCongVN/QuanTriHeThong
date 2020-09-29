CREATE TABLE [dbo].[ThongTinPhanQuyen]
(
[ThongTinPhanQuyenId] [int] NOT NULL IDENTITY(1, 1),
[QuyenId] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[MaChucVu] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ThongTinPhanQuyen] ADD CONSTRAINT [PK__ThongTin__95A7319AAA9F0F23] PRIMARY KEY CLUSTERED  ([ThongTinPhanQuyenId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ThongTinPhanQuyen] ADD CONSTRAINT [FK_ThongTinPhanQuyen_ChucVu] FOREIGN KEY ([MaChucVu]) REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[ThongTinPhanQuyen] ADD CONSTRAINT [FK_ThongTinPhanQuyen_Quyen] FOREIGN KEY ([QuyenId]) REFERENCES [dbo].[Quyen] ([QuyenId])
GO
