USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('Config_GetAllGpu') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllGpu;
GO

CREATE PROCEDURE Config_GetAllGpu
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        GPU_ID AS 'ID Відеокарти',
        Title AS 'Назва відеокарти',
        Cores AS 'Кількість ядер',
        Threads AS 'Кількість потоків',
        VRAMType AS 'Тип відеопам’яті',
        VRAMQuantity AS 'Обсяг відеопам’яті',
        Cache AS 'Кеш',
        Clock AS 'Тактова частота',
        Cost AS 'Вартість (грн)'
    FROM GPU;
END
GO
