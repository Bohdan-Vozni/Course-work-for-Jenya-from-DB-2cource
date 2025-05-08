USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Config_GetAllBluetooth') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllBluetooth;
GO

CREATE PROCEDURE Config_GetAllBluetooth
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Bluetooth_ID AS 'ID Bluetooth',
        Title AS 'Назва Bluetooth модуля',
        Generation AS 'Покоління',
        Cost AS 'Вартість (грн)'
    FROM Bluetooth;
END
GO
