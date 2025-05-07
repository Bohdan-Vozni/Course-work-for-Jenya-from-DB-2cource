use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'DeleteFanCooling')
  DROP PROCEDURE DeleteFanCooling;
GO

CREATE PROCEDURE DeleteFanCooling
  @FanCooling_ID CHAR(36)
AS
BEGIN
  DELETE FROM FanCooling WHERE FanCooling_ID = @FanCooling_ID;
END;
GO