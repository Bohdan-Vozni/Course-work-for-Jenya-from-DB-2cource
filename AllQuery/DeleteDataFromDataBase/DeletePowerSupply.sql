use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'DeletePowerSupply')
  DROP PROCEDURE DeletePowerSupply;
GO

CREATE PROCEDURE DeletePowerSupply
  @PowerSupply_ID CHAR(36)
AS
BEGIN
  DELETE FROM PowerSupply WHERE PowerSupply_ID = @PowerSupply_ID;
END;
GO