USE [sinemasitem]
GO
/****** Object:  Table [dbo].[kullanicigrup]    Script Date: 18.5.2014 20:49:08 ******/
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
