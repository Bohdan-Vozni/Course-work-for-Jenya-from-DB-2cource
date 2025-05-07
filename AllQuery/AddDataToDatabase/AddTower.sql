USE PC_constructor
GO

IF exists ( SELECT name FROM sys.objects WHERE name = 'AddTower')
  DROP PROCEDURE AddTower;
GO

CREATE PROCEDURE AddTower
    @Tower_ID CHAR(36),
    @Title NVARCHAR(MAX),
    @TypeSize NVARCHAR(MAX),
    @FanType NVARCHAR(MAX),
    @FanIncluded NVARCHAR(MAX),
    @Cost FLOAT
AS
BEGIN
    INSERT INTO Tower (Tower_ID, Title, TypeSize, FanType, FanIncluded, Cost)
    VALUES (@Tower_ID, @Title, @TypeSize, @FanType, @FanIncluded, @Cost)
END
GO
