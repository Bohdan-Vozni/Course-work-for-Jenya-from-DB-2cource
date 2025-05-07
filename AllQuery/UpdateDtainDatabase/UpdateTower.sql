USE PC_constructor
GO

IF exists ( SELECT name FROM sys.objects WHERE name = 'UpdateTower')
  DROP PROCEDURE UpdateTower;
GO

CREATE PROCEDURE UpdateTower
    @Tower_ID CHAR(36),
    @Title NVARCHAR(MAX),
    @TypeSize NVARCHAR(MAX),
    @FanType NVARCHAR(MAX),
    @FanIncluded NVARCHAR(MAX),
    @Cost FLOAT
AS
BEGIN
    UPDATE Tower
    SET Title = @Title,
        TypeSize = @TypeSize,
        FanType = @FanType,
        FanIncluded = @FanIncluded,
        Cost = @Cost
    WHERE Tower_ID = @Tower_ID
END
GO
