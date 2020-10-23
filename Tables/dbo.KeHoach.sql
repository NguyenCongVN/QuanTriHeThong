CREATE TABLE [dbo].[KeHoach]
(
[MaKeHoach] [int] NOT NULL IDENTITY(1, 1),
[TenKeHoach] [nvarchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[MaNguoiLapKeHoach] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KeHoach] ADD CONSTRAINT [PK_KeHoach] PRIMARY KEY CLUSTERED  ([MaKeHoach]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KeHoach] ADD CONSTRAINT [FK_KeHoach_NguoiDung] FOREIGN KEY ([MaNguoiLapKeHoach]) REFERENCES [dbo].[NguoiDung] ([MaDangNhapNguoiDung])
GO
