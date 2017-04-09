create TABLE [dbo].[Map]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Location] NCHAR(1000) NOT NULL, 
    [url] NCHAR(1000) NOT NULL, 
    [time] DATETIME NOT NULL
)
