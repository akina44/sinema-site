USE [sinemasitem]
GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 18.5.2014 20:49:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[kullaniciid] [int] NULL,
	[grupid] [int] NULL,
	[meslekid] [int] NULL,
	[sifre] [nvarchar](max) NULL,
	[kullaniciadi] [nvarchar](max) NULL,
	[adsoyad] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[engel] [int] NULL,
	[cinsiyet] [nvarchar](50) NULL,
	[dogum] [date] NULL,
	[resim] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
