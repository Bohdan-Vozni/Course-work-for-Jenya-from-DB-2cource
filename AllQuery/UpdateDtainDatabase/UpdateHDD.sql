use PC_constructor
go

IF exists ( SELECT name FROM sys.objects WHERE name = 'UpdateHDD')
  DROP PROCEDURE UpdateHDD;
GO

CREATE PROCEDURE UpdateHDD
    @HDD_ID CHAR(36),
    @Title NVARCHAR(MAX),
    @MemoryQuantity NVARCHAR(MAX),
    @ReadingSpeed NVARCHAR(MAX),
    @WriteSpeed NVARCHAR(MAX),
    @Cost FLOAT
AS
BEGIN
    UPDATE HDD
    SET
        Title = @Title,
        MemoryQuantity = @MemoryQuantity,
        ReadingSpeed = @ReadingSpeed,
        WriteSpeed = @WriteSpeed,
        Cost = @Cost
    WHERE HDD_ID = @HDD_ID
END
GO