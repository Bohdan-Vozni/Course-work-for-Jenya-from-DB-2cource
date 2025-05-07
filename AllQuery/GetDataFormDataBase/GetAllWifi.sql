use PC_constructor
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'GetAllWifi')
  DROP PROCEDURE GetAllWifi;
GO

CREATE PROCEDURE GetAllWifi
AS
BEGIN
  SELECT * FROM Wifi;
END;
GO
