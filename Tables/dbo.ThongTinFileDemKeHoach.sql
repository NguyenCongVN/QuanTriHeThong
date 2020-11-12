CREATE TABLE [dbo].[ThongTinFileDemKeHoach]
(
[MaThongTinDuLieu] [int] NOT NULL IDENTITY(1, 1),
[MaFile] [int] NOT NULL,
[MaKeHoach] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ThongTinFileDemKeHoach] ADD CONSTRAINT [PK_ThongTinFileDemKeHoach] PRIMARY KEY CLUSTERED  ([MaThongTinDuLieu]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ThongTinFileDemKeHoach] ADD CONSTRAINT [FK_ThongTinFileDemKeHoach_FileDem] FOREIGN KEY ([MaFile]) REFERENCES [dbo].[FileDem] ([MaFile])
GO
ALTER TABLE [dbo].[ThongTinFileDemKeHoach] ADD CONSTRAINT [FK_ThongTinFileDemKeHoach_KeHoach] FOREIGN KEY ([MaKeHoach]) REFERENCES [dbo].[KeHoach] ([MaKeHoach])
GO
