USE [sinemasitem]
GO
/****** Object:  Table [dbo].[film]    Script Date: 18.5.2014 20:49:08 ******/
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
