use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'AddWaterCooling')
  DROP PROCEDURE AddWaterCooling;
GO

CREATE PROCEDURE AddWaterCooling
  @WaterCooling_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @TypeSize NVARCHAR(MAX),
  @HeatRemoval NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  INSERT INTO WaterCooling (WaterCooling_ID, Title, TypeSize, HeatRemoval, Cost)
  VALUES (@WaterCooling_ID, @Title, @TypeSize, @HeatRemoval, @Cost);
END;
GO
