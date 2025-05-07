use PC_constructor
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'DeleteWifi')
  DROP PROCEDURE DeleteWifi;
GO

CREATE PROCEDURE DeleteWifi
  @Wifi_ID CHAR(36)
AS
BEGIN
  DELETE FROM Wifi WHERE Wifi_ID = @Wifi_ID;
END;
GO