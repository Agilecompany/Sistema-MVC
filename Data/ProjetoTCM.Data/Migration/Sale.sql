USE [ProjetoTCMDataBase]
GO

/****** Object:  Table [Sale].[Sale]    Script Date: 24/11/2019 13:38:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Sale].[Sale](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Payment] [smallint] NOT NULL,
	[Date] [datetime] NOT NULL,
	[SalesmanID] [bigint] NOT NULL,
	[ClientID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[ClientName] [nvarchar](100) NOT NULL,
	[ClientCPF] [nvarchar](20) NOT NULL,
	[SalesmanName] [nvarchar](100) NOT NULL,
	[Excluded] [bit] NOT NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Sale].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Client] FOREIGN KEY([ClientID])
REFERENCES [General].[Client] ([ID])
GO

ALTER TABLE [Sale].[Sale] CHECK CONSTRAINT [FK_Sale_Client]
GO

ALTER TABLE [Sale].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Salesman] FOREIGN KEY([SalesmanID])
REFERENCES [General].[Salesman] ([ID])
GO

ALTER TABLE [Sale].[Sale] CHECK CONSTRAINT [FK_Sale_Salesman]
GO

ALTER TABLE [Sale].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_User] FOREIGN KEY([UserID])
REFERENCES [Security].[User] ([ID])
GO

ALTER TABLE [Sale].[Sale] CHECK CONSTRAINT [FK_Sale_User]
GO
