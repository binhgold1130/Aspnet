USE [CvbK22CNT4Lesson07db]
GO
/****** Object:  Table [dbo].[cvbKhoa]    Script Date: 6/12/2024 5:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cvbKhoa](
	[CvbMaKH] [nchar](10) NOT NULL,
	[CvbTenKH] [nvarchar](50) NULL,
	[CvbTrangThai] [bit] NULL,
 CONSTRAINT [PK_cvbKhoa] PRIMARY KEY CLUSTERED 
(
	[CvbMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cvbSinhVien]    Script Date: 6/12/2024 5:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cvbSinhVien](
	[CvbMaSV] [nvarchar](50) NOT NULL,
	[CvbHoSV] [nvarchar](50) NULL,
	[CvbTenSV] [nvarchar](50) NULL,
	[CvbNgaySinh] [date] NULL,
	[CvbPhai] [bit] NULL,
	[CvbPhone] [nchar](10) NULL,
	[CvbEmail] [nvarchar](50) NULL,
	[CvbMaKh] [nchar](10) NULL,
 CONSTRAINT [PK_cvbSinhVien] PRIMARY KEY CLUSTERED 
(
	[CvbMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cvbSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_cvbSinhVien_cvbKhoa] FOREIGN KEY([CvbMaKh])
REFERENCES [dbo].[cvbKhoa] ([CvbMaKH])
GO
ALTER TABLE [dbo].[cvbSinhVien] CHECK CONSTRAINT [FK_cvbSinhVien_cvbKhoa]
GO
