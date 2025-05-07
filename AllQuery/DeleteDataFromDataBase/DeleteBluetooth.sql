use PC_constructor
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'DeleteBluetooth')
  DROP PROCEDURE DeleteBluetooth;
GO

CREATE PROCEDURE DeleteBluetooth
  @Bluetooth_ID CHAR(36)
AS
BEGIN
  DELETE FROM Bluetooth WHERE Bluetooth_ID = @Bluetooth_ID;
END;
GO