use PC_constructor
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'AddBluetooth')
  DROP PROCEDURE AddBluetooth;
GO

CREATE PROCEDURE AddBluetooth
  @Bluetooth_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @Generation NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  INSERT INTO Bluetooth (Bluetooth_ID, Title, Generation, Cost)
  VALUES (@Bluetooth_ID, @Title, @Generation, @Cost);
END;
GO