CREATE TABLE [dbo].[Products]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [Name] VARCHAR(50) NULL, 
    [Code] VARCHAR(50) NULL, 
    [ReleaseDate] VARCHAR(50) NULL DEFAULT GETDATE(), 
    [Price] NUMERIC(18, 5) NULL DEFAULT 0.0, 
    [Description] VARCHAR(50) NULL, 
    [IsActive] BIT NULL DEFAULT 0,
    [Rating] NUMERIC(5, 2) NULL DEFAULT 2.5, 
    [ImageUrl] VARCHAR(100) NULL, 
)
