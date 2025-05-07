use PC_constructor
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'UpdateWifi')
  DROP PROCEDURE UpdateWifi;
GO

CREATE PROCEDURE UpdateWifi
  @Wifi_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @Generation NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  UPDATE Wifi
  SET Title = @Title,
      Generation = @Generation,
      Cost = @Cost
  WHERE Wifi_ID = @Wifi_ID;
END;
GO