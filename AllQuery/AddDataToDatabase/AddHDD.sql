use PC_constructor
go

IF exists ( SELECT name FROM sys.objects WHERE name = 'AddHDD')
  DROP PROCEDURE AddHDD;
GO

CREATE PROCEDURE AddHDD
    @HDD_ID CHAR(36),
    @Title NVARCHAR(MAX),
    @MemoryQuantity NVARCHAR(MAX),
    @ReadingSpeed NVARCHAR(MAX),
    @WriteSpeed NVARCHAR(MAX),
    @Cost FLOAT
AS
BEGIN
    INSERT INTO HDD (HDD_ID, Title, MemoryQuantity, ReadingSpeed, WriteSpeed, Cost)
    VALUES (@HDD_ID, @Title, @MemoryQuantity, @ReadingSpeed, @WriteSpeed, @Cost)
END
GO
