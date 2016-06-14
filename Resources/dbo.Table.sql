CREATE TABLE [dbo].[Table]
(
	[Name] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Level] TINYINT NULL, 
    [Type] NVARCHAR(50) NULL, 
    [Casting Time] NVARCHAR(50) NULL, 
    [Range] NVARCHAR(50) NULL, 
    [Target] NVARCHAR(50) NULL, 
    [Duration] NVARCHAR(50) NULL, 
    [Saving Throw] NVARCHAR(50) NULL, 
    [Effect] NVARCHAR(50) NULL, 
    [Description] TEXT NULL 
)
