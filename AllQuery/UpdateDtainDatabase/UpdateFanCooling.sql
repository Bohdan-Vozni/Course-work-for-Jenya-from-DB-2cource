use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'UpdateFanCooling')
  DROP PROCEDURE UpdateFanCooling;
GO

CREATE PROCEDURE UpdateFanCooling
  @FanCooling_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @TypeSize NVARCHAR(MAX),
  @HeatRemoval NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  UPDATE FanCooling
  SET Title = @Title,
      TypeSize = @TypeSize,
      HeatRemoval = @HeatRemoval,
      Cost = @Cost
  WHERE FanCooling_ID = @FanCooling_ID;
END;
GO