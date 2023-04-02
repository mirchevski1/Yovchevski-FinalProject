CREATE TABLE [dbo].[Customer]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [first_name] NCHAR(10) NOT NULL, 
    [last_name] NCHAR(10) NOT NULL, 
    [gender] NCHAR(10) NULL, 
    [email] NCHAR(10) NOT NULL
)
