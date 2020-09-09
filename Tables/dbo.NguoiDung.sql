CREATE TABLE [dbo].[NguoiDung]
(
[MaDangNhapNguoiDung] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[MatKhau] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NguoiDung] ADD CONSTRAINT [PK__NguoiDun__DFF10D99BB0B9AD7] PRIMARY KEY CLUSTERED  ([MaDangNhapNguoiDung]) ON [PRIMARY]
GO
