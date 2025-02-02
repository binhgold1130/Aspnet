USE [CvbLesson10]
GO
/****** Object:  Table [dbo].[CvbAccount]    Script Date: 7/3/2024 7:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CvbAccount](
	[CvbID] [int] NOT NULL,
	[CvbUseName] [nvarchar](50) NULL,
	[CvbPassword] [nvarchar](50) NULL,
	[CvbFullName] [nvarchar](50) NULL,
	[CvbEmail] [nvarchar](50) NULL,
	[CvbPhone] [nvarchar](50) NULL,
	[CvbAcive] [bit] NULL,
 CONSTRAINT [PK_CvbAccount] PRIMARY KEY CLUSTERED 
(
	[CvbID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CvbAccount] ([CvbID], [CvbUseName], [CvbPassword], [CvbFullName], [CvbEmail], [CvbPhone], [CvbAcive]) VALUES (1, N'VanBinh', N'123456@', NULL, NULL, NULL, NULL)
GO
