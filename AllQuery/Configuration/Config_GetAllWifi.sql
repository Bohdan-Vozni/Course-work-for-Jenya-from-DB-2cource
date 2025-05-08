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
        Wifi_ID AS 'ID Wi-Fi модуля',
        Title AS 'Назва Wi-Fi модуля',
        Generation AS 'Покоління',
        Cost AS 'Вартість (грн)'
    FROM Wifi;
END
GO
