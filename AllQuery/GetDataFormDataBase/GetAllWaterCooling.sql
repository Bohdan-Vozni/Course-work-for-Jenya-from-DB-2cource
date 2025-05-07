use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'GetAllWaterCooling')
  DROP PROCEDURE GetAllWaterCooling;
GO

CREATE PROCEDURE GetAllWaterCooling
AS
BEGIN
  SELECT * FROM WaterCooling;
END;
GO