USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Config_GetAllWifi') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllWifi;
GO

CREATE PROCEDURE Config_GetAllWifi
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Wifi_ID AS 'ID Wi-Fi ������',
        Title AS '����� Wi-Fi ������',
        Generation AS '��������',
        Cost AS '������� (���)'
    FROM Wifi;
END
GO
