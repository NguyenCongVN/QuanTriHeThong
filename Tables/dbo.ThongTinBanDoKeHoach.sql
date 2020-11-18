CREATE TABLE [dbo].[ThongTinBanDoKeHoach]
(
[MaThongTin] [int] NOT NULL IDENTITY(1, 1),
[MaBanDo] [int] NOT NULL,
[MaKeHoach] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ThongTinBanDoKeHoach] ADD CONSTRAINT [PK_ThongTinBanDoKeHoach] PRIMARY KEY CLUSTERED  ([MaThongTin]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ThongTinBanDoKeHoach] ADD CONSTRAINT [FK_ThongTinBanDoKeHoach_BanDo] FOREIGN KEY ([MaBanDo]) REFERENCES [dbo].[BanDo] ([MaBanDo])
GO
ALTER TABLE [dbo].[ThongTinBanDoKeHoach] ADD CONSTRAINT [FK_ThongTinBanDoKeHoach_KeHoach] FOREIGN KEY ([MaKeHoach]) REFERENCES [dbo].[KeHoach] ([MaKeHoach])
GO
