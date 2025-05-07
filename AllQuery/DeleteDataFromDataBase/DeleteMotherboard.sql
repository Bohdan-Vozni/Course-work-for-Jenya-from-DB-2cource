use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'DeleteMotherboard')
  DROP PROCEDURE DeleteMotherboard;
GO

CREATE PROCEDURE DeleteMotherboard
  @Motherboard_ID CHAR(36)
AS
BEGIN
  DELETE FROM Motherboard WHERE Motherboard_ID = @Motherboard_ID;
END;
GO