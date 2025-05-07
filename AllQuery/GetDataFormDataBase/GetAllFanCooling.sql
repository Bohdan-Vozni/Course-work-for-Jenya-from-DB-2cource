use PC_constructor;
go


IF EXISTS (SELECT name FROM sys.objects WHERE name = 'GetAllFanCooling')
  DROP PROCEDURE GetAllFanCooling;
GO

CREATE PROCEDURE GetAllFanCooling
AS
BEGIN
  SELECT * FROM FanCooling;
END;
GO