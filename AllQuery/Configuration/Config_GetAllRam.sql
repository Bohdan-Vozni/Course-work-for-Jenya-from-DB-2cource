USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Config_GetAllRam') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllRam;
GO

CREATE PROCEDURE Config_GetAllRam
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        RAM_ID AS 'ID ОЗП',
        Title AS 'Назва оперативної пам’яті',
        MemoryType AS 'Тип пам’яті',
        MemoryQuantity AS 'Обсяг пам’яті',
        RadiatorType AS 'Тип радіатора',
        Cost AS 'Вартість (грн)'
    FROM RAM;
END
GO
