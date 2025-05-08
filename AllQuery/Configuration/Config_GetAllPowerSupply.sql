USE PC_constructor
GO

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'Config_GetAllPowerSupply')
    DROP PROCEDURE Config_GetAllPowerSupply;
GO

CREATE PROCEDURE Config_GetAllPowerSupply
AS
BEGIN
    SELECT 
        PowerSupply_ID,
        Title AS 'Назва блоку живлення',
        Strength AS 'Потужність',
        Sertificate AS 'Сертифікат',
        Cost AS 'Вартість'
    FROM PowerSupply;
END
GO
