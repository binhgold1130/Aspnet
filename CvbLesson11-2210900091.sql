USE [CvbLesson11]
GO
/****** Object:  Table [dbo].[CvbCategory]    Script Date: 7/4/2024 10:41:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CvbCategory](
	[CvbID] [int] NOT NULL,
	[CvbCategory] [nvarchar](50) NULL,
	[CvbStatus] [bit] NULL,
 CONSTRAINT [PK_CvbCategory] PRIMARY KEY CLUSTERED 
(
	[CvbID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CvbProduct]    Script Date: 7/4/2024 10:41:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CvbProduct](
	[CvbId2210900091] [nvarchar](50) NOT NULL,
	[CvbProName] [nvarchar](50) NULL,
	[CvbQty] [int] NULL,
	[CvbPrice] [float] NULL,
	[CvbCateld] [int] NULL,
	[CvbActive] [bit] NULL,
 CONSTRAINT [PK_CvbProDuct] PRIMARY KEY CLUSTERED 
(
	[CvbId2210900091] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CvbCategory] ([CvbID], [CvbCategory], [CvbStatus]) VALUES (1, N'Cao Văn Bình', 1)
GO
INSERT [dbo].[CvbProduct] ([CvbId2210900091], [CvbProName], [CvbQty], [CvbPrice], [CvbCateld], [CvbActive]) VALUES (N'2210900091', N'Cao Văn Bình', 10, 1000, 1, 1)
INSERT [dbo].[CvbProduct] ([CvbId2210900091], [CvbProName], [CvbQty], [CvbPrice], [CvbCateld], [CvbActive]) VALUES (N'P001', N'Iphone 15Pro', 1, 2000, 1, 1)
GO
