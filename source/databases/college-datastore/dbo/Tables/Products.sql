CREATE TABLE [dbo].[Products]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [ProductId] INT NOT NULL, 
    [ProductName] VARCHAR(50) NULL, 
    [ProductCode] VARCHAR(50) NULL, 
    [ReleaseDate] VARCHAR(50) NULL, 
    [Price] NUMERIC(18, 5) NULL, 
    [Description] VARCHAR(50) NULL, 
    [StarRating] NUMERIC(5, 2) NULL, 
    [ImageUrl] VARCHAR(100) NULL
)
