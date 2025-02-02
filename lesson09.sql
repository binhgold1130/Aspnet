USE [qlsv]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 6/26/2024 3:26:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSV] [nvarchar](50) NOT NULL,
	[MaMH] [nvarchar](50) NOT NULL,
	[Diem] [nchar](10) NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/26/2024 3:26:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 6/26/2024 3:26:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [nchar](10) NOT NULL,
	[TenMH] [nchar](10) NOT NULL,
	[SoTiet] [nchar](10) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/26/2024 3:26:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nvarchar](50) NOT NULL,
	[HoSV] [nvarchar](50) NULL,
	[TenSV] [nvarchar](50) NULL,
	[Phai] [bit] NULL,
	[NgaySinh] [nvarchar](50) NULL,
	[NoiSinh] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[HocBong] [nvarchar](50) NULL,
	[DiemTrungBinh] [numeric](18, 2) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SinhVien] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [MaKH], [HocBong], [DiemTrungBinh]) VALUES (N'2210900091', N'Cao Văn', N'Bình', 1, N'2004/01/21', N'Thanh Hóa', N'K22CNT4', N'Không', CAST(5.00 AS Numeric(18, 2)))
GO
