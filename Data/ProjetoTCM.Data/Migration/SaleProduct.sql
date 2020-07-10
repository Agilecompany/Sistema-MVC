USE [ProjetoTCMDataBase]
GO

/****** Object:  Table [Sale].[SaleProduct]    Script Date: 24/11/2019 13:39:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Sale].[SaleProduct](
	[SaleID] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[ExternalCode] [nvarchar](50) NOT NULL,
	[UnitPrice] [decimal](8, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SaleProduct] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Sale].[SaleProduct]  WITH CHECK ADD  CONSTRAINT [FK_SaleProduct_Product] FOREIGN KEY([ProductID])
REFERENCES [General].[Product] ([ID])
GO

ALTER TABLE [Sale].[SaleProduct] CHECK CONSTRAINT [FK_SaleProduct_Product]
GO

ALTER TABLE [Sale].[SaleProduct]  WITH CHECK ADD  CONSTRAINT [FK_SaleProduct_Sale] FOREIGN KEY([SaleID])
REFERENCES [Sale].[Sale] ([ID])
GO

ALTER TABLE [Sale].[SaleProduct] CHECK CONSTRAINT [FK_SaleProduct_Sale]
GO


