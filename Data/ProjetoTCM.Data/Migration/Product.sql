USE [ProjetoTCMDataBase]
GO

/****** Object:  Table [General].[Product]    Script Date: 22/11/2019 01:34:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [General].[Product](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ExternalCode] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[Brand] [nvarchar](50) NULL,
	[Model] [varchar](50) NULL,
	[UnitPrice] [decimal](8, 2) NOT NULL,
	[Excluded] [bit] NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


