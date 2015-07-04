USE [AjaxLicensing]
GO

/****** Object:  Table [dbo].[ProductLicenceKey]    Script Date: 4/07/2015 9:15:52 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductLicenceKey](
	[CustomerID] [nvarchar](8) NOT NULL,
	[ProductID] [nvarchar](8) NOT NULL,
	[LicenseKey] [uniqueidentifier] NOT NULL,
	[ExpiryDate] [datetime] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ProductLicenceKey]  WITH CHECK ADD  CONSTRAINT [FK_ProductLicenceKey_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO

ALTER TABLE [dbo].[ProductLicenceKey] CHECK CONSTRAINT [FK_ProductLicenceKey_Customer]
GO

ALTER TABLE [dbo].[ProductLicenceKey]  WITH CHECK ADD  CONSTRAINT [FK_ProductLicenceKey_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO

ALTER TABLE [dbo].[ProductLicenceKey] CHECK CONSTRAINT [FK_ProductLicenceKey_Product]
GO

