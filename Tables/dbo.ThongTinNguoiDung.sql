CREATE TABLE [dbo].[ThongTinNguoiDung]
(
[MaDangNhapNguoiDung] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[SoDienThoai] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[HoTen] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[NgayTao] [datetime] NULL CONSTRAINT [DF__ThongTinN__NgayT__571DF1D5] DEFAULT (getdate()),
[DiaChi] [nvarchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[NgaySinh] [date] NULL,
[MaChucVu] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ThongTinNguoiDung] ADD CONSTRAINT [PK__ThongTin__DFF10D99FE8E43EC] PRIMARY KEY CLUSTERED  ([MaDangNhapNguoiDung]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ThongTinNguoiDung] ADD CONSTRAINT [FK_ThongTinNguoiDung_ChucVu] FOREIGN KEY ([MaChucVu]) REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[ThongTinNguoiDung] ADD CONSTRAINT [FK__ThongTinN__MaDan__5629CD9C] FOREIGN KEY ([MaDangNhapNguoiDung]) REFERENCES [dbo].[NguoiDung] ([MaDangNhapNguoiDung])
GO
