use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'UpdateWaterCooling')
  DROP PROCEDURE UpdateWaterCooling;
GO

CREATE PROCEDURE UpdateWaterCooling
  @WaterCooling_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @TypeSize NVARCHAR(MAX),
  @HeatRemoval NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  UPDATE WaterCooling
  SET Title = @Title,
      TypeSize = @TypeSize,
      HeatRemoval = @HeatRemoval,
      Cost = @Cost
  WHERE WaterCooling_ID = @WaterCooling_ID;
END;
GO