use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'DeleteWaterCooling')
  DROP PROCEDURE DeleteWaterCooling;
GO

CREATE PROCEDURE DeleteWaterCooling
  @WaterCooling_ID CHAR(36)
AS
BEGIN
  DELETE FROM WaterCooling WHERE WaterCooling_ID = @WaterCooling_ID;
END;
GO