USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Config_GetAllTower') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllTower;
GO

CREATE PROCEDURE Config_GetAllTower
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Tower_ID AS 'ID Корпуса',
        Title AS 'Назва корпуса',
        TypeSize AS 'Типорозмір',
        FanType AS 'Тип вентилятора',
        FanIncluded AS 'Вентилятори в комплекті',
        Cost AS 'Вартість (грн)'
    FROM Tower;
END
GO
