use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'GetAllPowerSupply')
  DROP PROCEDURE GetAllPowerSupply;
GO

CREATE PROCEDURE GetAllPowerSupply
AS
BEGIN
  SELECT * FROM PowerSupply;
END;
GO