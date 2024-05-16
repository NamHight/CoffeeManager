USE [QLCF]
GO
/****** Object:  Table [dbo].[cthoadon]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cthoadon](
	[mahd] [nvarchar](20) NOT NULL,
	[madouong] [nvarchar](20) NOT NULL,
	[soluong] [int] NULL,
	[dongia] [money] NULL,
 CONSTRAINT [pk_cthoadon] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC,
	[madouong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[douong]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[douong](
	[madouong] [nvarchar](20) NOT NULL,
	[maloaidouong] [nvarchar](20) NULL,
	[tendouong] [nvarchar](50) NULL,
	[mota] [nvarchar](255) NULL,
	[tthai] [int] NULL,
 CONSTRAINT [pk_douong] PRIMARY KEY CLUSTERED 
(
	[madouong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahd] [nvarchar](20) NOT NULL,
	[manv] [nvarchar](20) NULL,
	[makh] [nvarchar](20) NULL,
	[ngaylap] [datetime] NULL,
	[tthai] [int] NULL,
 CONSTRAINT [pk_hoadon] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[makh] [nvarchar](20) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[dchi] [nvarchar](255) NULL,
	[ngsinh] [datetime] NULL,
	[sdt] [nvarchar](20) NULL,
	[cccd] [nvarchar](20) NULL,
	[gioitinh] [nvarchar](20) NULL,
	[tthai] [int] NULL,
 CONSTRAINT [pk_khachhang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manv] [nvarchar](20) NOT NULL,
	[maca] [nvarchar](20) NULL,
	[tennv] [nvarchar](50) NULL,
	[dchi] [nvarchar](255) NULL,
	[ngsinh] [datetime] NULL,
	[sdt] [nvarchar](20) NULL,
	[cccd] [nvarchar](20) NULL,
	[username] [nvarchar](20) NULL,
	[passwork] [nvarchar](20) NULL,
	[ngaylap] [datetime] NULL,
	[gioitinh] [nvarchar](20) NULL,
	[roller] [int] NULL,
	[tthai] [int] NULL,
 CONSTRAINT [pk_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_HoaDonTong]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_HoaDonTong]
AS
SELECT dbo.hoadon.mahd, dbo.nhanvien.tennv, dbo.khachhang.hoten, dbo.cthoadon.dongia, dbo.hoadon.ngaylap, dbo.douong.tendouong, dbo.cthoadon.soluong, dbo.cthoadon.dongia * dbo.cthoadon.soluong AS 'thanhtien'
FROM     dbo.hoadon INNER JOIN
                  dbo.cthoadon ON dbo.hoadon.mahd = dbo.cthoadon.mahd INNER JOIN
                  dbo.nhanvien ON dbo.hoadon.manv = dbo.nhanvien.manv INNER JOIN
                  dbo.douong ON dbo.cthoadon.madouong = dbo.douong.madouong INNER JOIN
                  dbo.khachhang ON dbo.hoadon.makh = dbo.khachhang.makh
GO
/****** Object:  Table [dbo].[ban]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ban](
	[maban] [nvarchar](20) NOT NULL,
	[tenban] [nvarchar](20) NULL,
	[tthai] [int] NULL,
	[controng] [int] NULL,
 CONSTRAINT [pk_ban] PRIMARY KEY CLUSTERED 
(
	[maban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[calamviec]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calamviec](
	[maca] [nvarchar](20) NOT NULL,
	[tenca] [nvarchar](20) NULL,
	[tgianbd] [time](7) NULL,
	[tgiankt] [time](7) NULL,
	[tthai] [int] NULL,
 CONSTRAINT [pk_calamviec] PRIMARY KEY CLUSTERED 
(
	[maca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chamcong]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chamcong](
	[macc] [nvarchar](20) NOT NULL,
	[manv] [nvarchar](20) NULL,
	[tgianbd] [datetime] NULL,
	[tgiankt] [datetime] NULL,
	[ngaynghi] [int] NULL,
	[tthai] [int] NULL,
 CONSTRAINT [pk_chamcong] PRIMARY KEY CLUSTERED 
(
	[macc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaidouong]    Script Date: 5/16/2024 4:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaidouong](
	[maloai] [nvarchar](20) NOT NULL,
	[tenloai] [nvarchar](50) NULL,
	[tthai] [int] NULL,
 CONSTRAINT [pk_loaidouong] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ban] ([maban], [tenban], [tthai], [controng]) VALUES (N'ban001', N'catago', 1, 0)
INSERT [dbo].[ban] ([maban], [tenban], [tthai], [controng]) VALUES (N'ban002', N'chicago', 1, 1)
INSERT [dbo].[ban] ([maban], [tenban], [tthai], [controng]) VALUES (N'ban003', N'canada', 1, 1)
INSERT [dbo].[ban] ([maban], [tenban], [tthai], [controng]) VALUES (N'ban004', N'nauy', 1, 1)
INSERT [dbo].[ban] ([maban], [tenban], [tthai], [controng]) VALUES (N'ban005', N'thuysi', 1, 1)
INSERT [dbo].[ban] ([maban], [tenban], [tthai], [controng]) VALUES (N'ban006', N'nhatban', 1, 1)
INSERT [dbo].[ban] ([maban], [tenban], [tthai], [controng]) VALUES (N'ban007', N'hanquoc', 0, 0)
GO
INSERT [dbo].[calamviec] ([maca], [tenca], [tgianbd], [tgiankt], [tthai]) VALUES (N'1_ca1', N'ca hanh chinh1', CAST(N'09:00:01' AS Time), CAST(N'13:00:01' AS Time), 1)
INSERT [dbo].[calamviec] ([maca], [tenca], [tgianbd], [tgiankt], [tthai]) VALUES (N'2_ca2', N'ca gay', CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), 1)
INSERT [dbo].[calamviec] ([maca], [tenca], [tgianbd], [tgiankt], [tthai]) VALUES (N'3_ca3', N'ca dem', CAST(N'17:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[calamviec] ([maca], [tenca], [tgianbd], [tgiankt], [tthai]) VALUES (N'4_ca', N'ca khuya', CAST(N'21:00:00' AS Time), CAST(N'01:00:00' AS Time), 1)
INSERT [dbo].[calamviec] ([maca], [tenca], [tgianbd], [tgiankt], [tthai]) VALUES (N'4_ca4', N'ca khuya', CAST(N'21:00:00' AS Time), CAST(N'01:00:00' AS Time), 0)
INSERT [dbo].[calamviec] ([maca], [tenca], [tgianbd], [tgiankt], [tthai]) VALUES (N'all', N'all', CAST(N'09:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[calamviec] ([maca], [tenca], [tgianbd], [tgiankt], [tthai]) VALUES (N'ca5', N'ca rang sang', CAST(N'01:00:00' AS Time), CAST(N'05:00:00' AS Time), NULL)
GO
INSERT [dbo].[chamcong] ([macc], [manv], [tgianbd], [tgiankt], [ngaynghi], [tthai]) VALUES (N'cc001', N'nv001', CAST(N'2024-01-25T00:00:00.000' AS DateTime), CAST(N'2024-02-25T00:00:00.000' AS DateTime), 1, 0)
INSERT [dbo].[chamcong] ([macc], [manv], [tgianbd], [tgiankt], [ngaynghi], [tthai]) VALUES (N'cc002', N'nv002', CAST(N'2024-01-25T00:00:00.000' AS DateTime), CAST(N'2024-02-25T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[chamcong] ([macc], [manv], [tgianbd], [tgiankt], [ngaynghi], [tthai]) VALUES (N'cc003', N'nv004', CAST(N'2024-01-25T00:00:00.000' AS DateTime), CAST(N'2024-02-25T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[chamcong] ([macc], [manv], [tgianbd], [tgiankt], [ngaynghi], [tthai]) VALUES (N'cc004', N'nv004', CAST(N'2024-01-25T00:00:00.000' AS DateTime), CAST(N'2024-02-25T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[chamcong] ([macc], [manv], [tgianbd], [tgiankt], [ngaynghi], [tthai]) VALUES (N'cc005', N'nv005', CAST(N'2024-01-25T00:00:00.000' AS DateTime), CAST(N'2024-02-25T00:00:00.000' AS DateTime), 3, 1)
INSERT [dbo].[chamcong] ([macc], [manv], [tgianbd], [tgiankt], [ngaynghi], [tthai]) VALUES (N'cc006', N'nv007', CAST(N'2024-01-25T00:00:00.000' AS DateTime), CAST(N'2024-02-25T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[chamcong] ([macc], [manv], [tgianbd], [tgiankt], [ngaynghi], [tthai]) VALUES (N'cc007', N'nv009', CAST(N'2024-01-25T00:00:00.000' AS DateTime), CAST(N'2024-02-25T00:00:00.000' AS DateTime), 0, 1)
GO
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd001', N'du011', 1, 50000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd001', N'du012', 1, 100000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd002', N'du012', 2, 100000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd003', N'du001', 1, 50000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd003', N'du002', 1, 20000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd004', N'du002', 1, 20000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd004', N'du012', 1, 100000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd005', N'du003', 1, 100000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd006', N'du004', 1, 60000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd006', N'du011', 1, 50000.0000)
INSERT [dbo].[cthoadon] ([mahd], [madouong], [soluong], [dongia]) VALUES (N'hd007', N'du003', 2, 40000.0000)
GO
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du001', N'ma001', N'Tra sua tran chau duong den', N'thuc uong dinh duong, gioi tre yeu thich', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du002', N'ma004', N'Tra lai', N'thuc uong giup thu gian, tinh tao', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du003', N'ma002', N'Cafe sua da', N'thuc uong gioi tre yeu thich', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du004', N'ma001', N'Tra sua atiso', N'thuc uong gioi tre yeu thich', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du005', N'ma005', N'Banh my kep thit', N'Do an nhanh', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du006', N'ma007', N'Coca cola', N'Nuoc ngot pho bien', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du007', N'ma007', N'Pepsi', N'Nuoc ngot pho bien', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du008', N'ma006', N'Nuoc ep cam', N'Nuoc ep dinh duong', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du009', N'ma006', N'Nuoc ep oi', N'Nuoc ep dinh duong', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du010', N'ma006', N'Nuoc ep tao', N'Nuoc ep dinh duong', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du011', N'ma006', N'Nuoc ep oi', N'Nuoc ep dinh duong', 1)
INSERT [dbo].[douong] ([madouong], [maloaidouong], [tendouong], [mota], [tthai]) VALUES (N'du012', N'ma004', N'Tra atiso', N'thuc uong giup thu gian, tinh tao', 1)
GO
INSERT [dbo].[hoadon] ([mahd], [manv], [makh], [ngaylap], [tthai]) VALUES (N'hd001', N'nv001', N'kh1', CAST(N'2017-02-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[hoadon] ([mahd], [manv], [makh], [ngaylap], [tthai]) VALUES (N'hd002', N'nv001', N'kh2', CAST(N'2018-06-02T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[hoadon] ([mahd], [manv], [makh], [ngaylap], [tthai]) VALUES (N'hd003', N'nv007', N'kh3', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[hoadon] ([mahd], [manv], [makh], [ngaylap], [tthai]) VALUES (N'hd004', N'nv002', N'kh2', CAST(N'2018-09-09T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[hoadon] ([mahd], [manv], [makh], [ngaylap], [tthai]) VALUES (N'hd005', N'nv005', N'kh3', CAST(N'2016-06-09T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[hoadon] ([mahd], [manv], [makh], [ngaylap], [tthai]) VALUES (N'hd006', N'nv004', N'kh2', CAST(N'2017-03-05T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[hoadon] ([mahd], [manv], [makh], [ngaylap], [tthai]) VALUES (N'hd007', N'nv004', NULL, CAST(N'2024-05-15T18:09:14.083' AS DateTime), NULL)
GO
INSERT [dbo].[khachhang] ([makh], [hoten], [dchi], [ngsinh], [sdt], [cccd], [gioitinh], [tthai]) VALUES (N'kh1', N'tran van a', N'66 le chi hieu, quan 1, tphcm', CAST(N'1997-02-06T00:00:00.000' AS DateTime), N'03837754', N'045225622673', N'Nam', 1)
INSERT [dbo].[khachhang] ([makh], [hoten], [dchi], [ngsinh], [sdt], [cccd], [gioitinh], [tthai]) VALUES (N'kh2', N'tran van b', N'63 le chi hieu, quan 1, tphcm', CAST(N'1992-02-08T00:00:00.000' AS DateTime), N'03837790', N'045225626789', N'Nam', 1)
INSERT [dbo].[khachhang] ([makh], [hoten], [dchi], [ngsinh], [sdt], [cccd], [gioitinh], [tthai]) VALUES (N'kh3', N'tran van c', N'65 le chi hieu, quan 1, tphcm', CAST(N'1994-01-06T00:00:00.000' AS DateTime), N'03837777', N'045225621123', N'Nam', 1)
INSERT [dbo].[khachhang] ([makh], [hoten], [dchi], [ngsinh], [sdt], [cccd], [gioitinh], [tthai]) VALUES (N'kh4', N'tran van h', N'68 le chi hieu, quan 1, tphcm', CAST(N'1999-08-06T00:00:00.000' AS DateTime), N'03837725', N'045225629975', N'Nu', 1)
GO
INSERT [dbo].[loaidouong] ([maloai], [tenloai], [tthai]) VALUES (N'ma001', N'Tra sua truyen thong', 1)
INSERT [dbo].[loaidouong] ([maloai], [tenloai], [tthai]) VALUES (N'ma002', N'Cafe sua', 1)
INSERT [dbo].[loaidouong] ([maloai], [tenloai], [tthai]) VALUES (N'ma003', N'Cafe nguyen ban', 1)
INSERT [dbo].[loaidouong] ([maloai], [tenloai], [tthai]) VALUES (N'ma004', N'Tra', 1)
INSERT [dbo].[loaidouong] ([maloai], [tenloai], [tthai]) VALUES (N'ma005', N'Do an', 1)
INSERT [dbo].[loaidouong] ([maloai], [tenloai], [tthai]) VALUES (N'ma006', N'Nuoc ep', 1)
INSERT [dbo].[loaidouong] ([maloai], [tenloai], [tthai]) VALUES (N'ma007', N'Nuoc ngot', 1)
GO
INSERT [dbo].[nhanvien] ([manv], [maca], [tennv], [dchi], [ngsinh], [sdt], [cccd], [username], [passwork], [ngaylap], [gioitinh], [roller], [tthai]) VALUES (N'nv001', N'2_ca2', N'nguyen van a', N'68 le chi hieu, quan 7, tphcm', CAST(N'1998-03-04T00:00:00.000' AS DateTime), N'0383111112', N'0452256987', N'vanaa1998', N'vanaa1998', CAST(N'2009-03-04T00:00:00.000' AS DateTime), N'Nu', 1, 1)
INSERT [dbo].[nhanvien] ([manv], [maca], [tennv], [dchi], [ngsinh], [sdt], [cccd], [username], [passwork], [ngaylap], [gioitinh], [roller], [tthai]) VALUES (N'nv002', N'2_ca2', N'nguyen van b', N'69 le van chieu, quan 8, tphcm', CAST(N'2000-06-03T00:00:00.000' AS DateTime), N'038311112', N'0452256987', N'vanb2000', N'vanb2000', CAST(N'2010-05-03T00:00:00.000' AS DateTime), N'Nam', 1, 1)
INSERT [dbo].[nhanvien] ([manv], [maca], [tennv], [dchi], [ngsinh], [sdt], [cccd], [username], [passwork], [ngaylap], [gioitinh], [roller], [tthai]) VALUES (N'nv003', N'3_ca3', N'nguyen van c', N'70 le van tuyen, quan 10, tphcm', CAST(N'2001-08-02T00:00:00.000' AS DateTime), N'038311113', N'0452256988', N'vanc2001', N'vanc2001', CAST(N'2016-06-06T00:00:00.000' AS DateTime), N'Nam', 1, 1)
INSERT [dbo].[nhanvien] ([manv], [maca], [tennv], [dchi], [ngsinh], [sdt], [cccd], [username], [passwork], [ngaylap], [gioitinh], [roller], [tthai]) VALUES (N'nv004', N'1_ca1', N'nguyen van d', N'70 tran van tuyen, quan 12, tphcm', CAST(N'2003-02-05T00:00:00.000' AS DateTime), N'038311114', N'0452256989', N'vand2003', N'vand2003', CAST(N'2017-08-06T00:00:00.000' AS DateTime), N'Nam', 1, 1)
INSERT [dbo].[nhanvien] ([manv], [maca], [tennv], [dchi], [ngsinh], [sdt], [cccd], [username], [passwork], [ngaylap], [gioitinh], [roller], [tthai]) VALUES (N'nv005', N'1_ca1', N'nguyen van e', N'71 tran van an, quan 2, tphcm', CAST(N'2002-02-02T00:00:00.000' AS DateTime), N'038311115', N'0452256990', N'vane2002', N'vane2002', CAST(N'2015-01-06T00:00:00.000' AS DateTime), N'Nam', 1, 1)
INSERT [dbo].[nhanvien] ([manv], [maca], [tennv], [dchi], [ngsinh], [sdt], [cccd], [username], [passwork], [ngaylap], [gioitinh], [roller], [tthai]) VALUES (N'nv006', N'all', N'nguyen thi boss', N'63 luu trong lu, quan 7, tphcm', CAST(N'1997-02-06T00:00:00.000' AS DateTime), N'0383996833', N'0452256991', N'boss1997', N'boss1997', CAST(N'2008-02-06T00:00:00.000' AS DateTime), N'Nu', 2, 1)
INSERT [dbo].[nhanvien] ([manv], [maca], [tennv], [dchi], [ngsinh], [sdt], [cccd], [username], [passwork], [ngaylap], [gioitinh], [roller], [tthai]) VALUES (N'nv007', N'2_ca2', N'nguyen thi f', N'66 luu trong lu, quan 9, tphcm', CAST(N'1998-02-06T00:00:00.000' AS DateTime), N'0383996835', N'0452256992', N'thif1998', N'thif1998', CAST(N'2009-09-09T00:00:00.000' AS DateTime), N'Nu', 1, 1)
INSERT [dbo].[nhanvien] ([manv], [maca], [tennv], [dchi], [ngsinh], [sdt], [cccd], [username], [passwork], [ngaylap], [gioitinh], [roller], [tthai]) VALUES (N'nv008', N'3_ca3', N'nguyen thi g', N'89 le loi, quan 1, tphcm', CAST(N'1998-02-17T00:05:45.000' AS DateTime), N'095633367', N'4522324657', N'thig1998', N'thig1998', CAST(N'2024-04-17T00:05:45.000' AS DateTime), N'Nu', 1, 1)
INSERT [dbo].[nhanvien] ([manv], [maca], [tennv], [dchi], [ngsinh], [sdt], [cccd], [username], [passwork], [ngaylap], [gioitinh], [roller], [tthai]) VALUES (N'nv009', N'2_ca2', N'nguyen thi k', N'90 le loi, quan 1, tphcm', CAST(N'1999-03-03T00:05:45.000' AS DateTime), N'095633368', N'4522324658', N'thik1999', N'thik1999', CAST(N'2024-04-17T00:05:45.000' AS DateTime), N'Nu', 1, 0)
GO
ALTER TABLE [dbo].[ban] ADD  DEFAULT ((1)) FOR [controng]
GO
ALTER TABLE [dbo].[chamcong] ADD  DEFAULT ((1)) FOR [tthai]
GO
ALTER TABLE [dbo].[chamcong]  WITH CHECK ADD  CONSTRAINT [fk_chamcong_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[chamcong] CHECK CONSTRAINT [fk_chamcong_nhanvien]
GO
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [fk_cthoadon_douong] FOREIGN KEY([madouong])
REFERENCES [dbo].[douong] ([madouong])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [fk_cthoadon_douong]
GO
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [fk_cthoadon_hoadon] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadon] ([mahd])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [fk_cthoadon_hoadon]
GO
ALTER TABLE [dbo].[douong]  WITH CHECK ADD  CONSTRAINT [fk_douong_loaidouong] FOREIGN KEY([maloaidouong])
REFERENCES [dbo].[loaidouong] ([maloai])
GO
ALTER TABLE [dbo].[douong] CHECK CONSTRAINT [fk_douong_loaidouong]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [fk_hoadon_khachhang] FOREIGN KEY([makh])
REFERENCES [dbo].[khachhang] ([makh])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [fk_hoadon_khachhang]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [fk_hoadon_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [fk_hoadon_nhanvien]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien_calamviec] FOREIGN KEY([maca])
REFERENCES [dbo].[calamviec] ([maca])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [fk_nhanvien_calamviec]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "hoadon"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cthoadon"
            Begin Extent = 
               Top = 0
               Left = 312
               Bottom = 163
               Right = 506
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "nhanvien"
            Begin Extent = 
               Top = 7
               Left = 532
               Bottom = 170
               Right = 726
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "douong"
            Begin Extent = 
               Top = 7
               Left = 774
               Bottom = 170
               Right = 968
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "khachhang"
            Begin Extent = 
               Top = 7
               Left = 1016
               Bottom = 170
               Right = 1210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_HoaDonTong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_HoaDonTong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_HoaDonTong'
GO
