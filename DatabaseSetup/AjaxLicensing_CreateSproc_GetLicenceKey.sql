USE [AjaxLicensing]
GO

/****** Object:  StoredProcedure [dbo].[GetLicenceKey]    Script Date: 4/07/2015 9:16:42 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetLicenceKey] 
	-- Add the parameters for the stored procedure here
(
	@CustomerID nvarchar(8), 
	@ProductID nvarchar(8)
)
AS
DECLARE @LicenseKey uniqueidentifier = newid(); 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into ProductLicenceKey (CustomerID, ProductID, LicenseKey, ExpiryDate)
	select @CustomerID, @ProductID, @LicenseKey, dateadd(yy, 1, getdate())

	select @LicenseKey

END

GO

