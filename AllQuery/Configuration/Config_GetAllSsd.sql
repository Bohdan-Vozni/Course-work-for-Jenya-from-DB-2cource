USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Config_GetAllSsd') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllSsd;
GO

CREATE PROCEDURE Config_GetAllSsd
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        SSD_ID AS 'ID SSD',
        Title AS 'Назва SSD',
        MemoryQuantity AS 'Обсяг пам’яті',
        ReadingSpeed AS 'Швидкість читання',
        WriteSpeed AS 'Швидкість запису',
        RadiatorType AS 'Тип радіатора',
        Cost AS 'Вартість (грн)'
    FROM SSD;
END
GO
