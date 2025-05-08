USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Config_GetAllWaterCooling') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllWaterCooling;
GO

CREATE PROCEDURE Config_GetAllWaterCooling
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        WaterCooling_ID AS 'ID Водяного охолодження',
        Title AS 'Назва водяного охолодження',
        TypeSize AS 'Розмір',
        HeatRemoval AS 'Відведення тепла',
        Cost AS 'Вартість (грн)'
    FROM WaterCooling;
END
GO
