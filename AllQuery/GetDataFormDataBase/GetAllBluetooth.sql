use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'GetAllBluetooth')
  DROP PROCEDURE GetAllBluetooth;
GO

CREATE PROCEDURE GetAllBluetooth
AS
BEGIN
  SELECT * FROM Bluetooth;
END;
GO