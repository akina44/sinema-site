USE [sinemasitem]
GO
/****** Object:  Table [dbo].[film]    Script Date: 17.5.2014 19:27:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[film](
	[filmid] [int] NULL,
	[ucboyutlu] [bit] NULL,
	[filmadi] [nvarchar](50) NULL,
	[filmsure] [varchar](50) NULL,
	[yerli] [bit] NULL,
	[filmturid] [int] NULL,
	[oyuncuid] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kategori]    Script Date: 17.5.2014 19:27:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategori](
	[kategoriid] [int] NULL,
	[kategoriadi] [nvarchar](50) NULL,
	[kategorilink] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 17.5.2014 19:27:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[kullaniciid] [int] NOT NULL,
	[kullaniciadi] [nvarchar](50) NOT NULL,
	[parola] [nvarchar](50) NOT NULL,
	[adi] [nvarchar](50) NOT NULL,
	[soyadi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kullanicigrup]    Script Date: 17.5.2014 19:27:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanicigrup](
	[grupid] [int] IDENTITY(1,1) NOT NULL,
	[grupadi] [nvarchar](50) NULL,
 CONSTRAINT [PK_kullanicigrup] PRIMARY KEY CLUSTERED 
(
	[grupid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[kategori] ([kategoriid], [kategoriadi], [kategorilink]) VALUES (1, N'vizyondakifilmler', NULL)
INSERT [dbo].[kategori] ([kategoriid], [kategoriadi], [kategorilink]) VALUES (2, N'yakında', NULL)
INSERT [dbo].[kategori] ([kategoriid], [kategoriadi], [kategorilink]) VALUES (3, N'eniyifilmler', NULL)
INSERT [dbo].[kategori] ([kategoriid], [kategoriadi], [kategorilink]) VALUES (4, N'biletal', NULL)
INSERT [dbo].[kategori] ([kategoriid], [kategoriadi], [kategorilink]) VALUES (NULL, NULL, N'')
INSERT [dbo].[kullanici] ([kullaniciid], [kullaniciadi], [parola], [adi], [soyadi], [email]) VALUES (1, N'fatma', N'123456', N'fatma', N'kurtuluş', N'fatos-derya@hotmail.com')
