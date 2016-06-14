CREATE TABLE [dbo].[Table] (
    [Name]         NVARCHAR (50) NOT NULL,
    [Level]        TINYINT       NULL,
    [Type]         NVARCHAR (50) NULL,
    [School]       NVARCHAR (50) NULL,
    [Casting Time] NVARCHAR (50) NULL,
    [Range]        NVARCHAR (50) NULL,
    [Target]       NVARCHAR (MAX) NULL,
    [Area]         NVARCHAR (50) NULL,
    [Effect]       NVARCHAR (MAX) NULL,
    [Duration]     NVARCHAR (50) NULL,
    [Saving Throw] NVARCHAR (50) NULL,
    [Description]  NTEXT         NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

