use PC_constructor
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'UpdateBluetooth')
  DROP PROCEDURE UpdateBluetooth;
GO

CREATE PROCEDURE UpdateBluetooth
  @Bluetooth_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @Generation NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  UPDATE Bluetooth
  SET Title = @Title,
      Generation = @Generation,
      Cost = @Cost
  WHERE Bluetooth_ID = @Bluetooth_ID;
END;
GO