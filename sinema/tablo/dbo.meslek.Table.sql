USE [sinemasitem]
GO
/****** Object:  Table [dbo].[meslek]    Script Date: 18.5.2014 20:49:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[meslek](
	[meslekid] [int] IDENTITY(1,1) NOT NULL,
	[meslekadi] [nvarchar](max) NULL,
 CONSTRAINT [PK_meslek] PRIMARY KEY CLUSTERED 
(
	[meslekid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
