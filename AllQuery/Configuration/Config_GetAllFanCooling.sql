USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Config_GetAllFanCooling') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllFanCooling;
GO

CREATE PROCEDURE Config_GetAllFanCooling
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        FanCooling_ID AS 'ID Вентиляторного охолодження',
        Title AS 'Назва кулера',
        TypeSize AS 'Розмір',
        HeatRemoval AS 'Відведення тепла',
        Cost AS 'Вартість (грн)'
    FROM FanCooling;
END
GO
