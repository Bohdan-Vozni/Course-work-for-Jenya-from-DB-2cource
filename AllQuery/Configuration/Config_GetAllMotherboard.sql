USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Config_GetAllMotherboard') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllMotherboard;
GO

CREATE PROCEDURE Config_GetAllMotherboard
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Motherboard_ID AS 'ID Материнської плати',
        Title AS 'Назва материнської плати',
        Chipset AS 'Чипсет',
        TypeSize AS 'Форм-фактор',
        Socket AS 'Сокет',
        Cost AS 'Вартість (грн)'
    FROM Motherboard;
END
GO
