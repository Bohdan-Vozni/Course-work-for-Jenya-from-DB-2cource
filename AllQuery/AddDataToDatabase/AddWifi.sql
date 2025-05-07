use PC_constructor
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'AddWifi')
  DROP PROCEDURE AddWifi;
GO

CREATE PROCEDURE AddWifi
  @Wifi_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @Generation NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  INSERT INTO Wifi (Wifi_ID, Title, Generation, Cost)
  VALUES (@Wifi_ID, @Title, @Generation, @Cost);
END;
GO