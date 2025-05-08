use PC_constructor
go

IF exists ( SELECT name FROM sys.objects WHERE name = 'Config_GetAllHDD')
  DROP PROCEDURE Config_GetAllHDD;
GO


CREATE PROCEDURE Config_GetAllHDD
AS
BEGIN
    SELECT 
        HDD_ID,
        Title as 'Назва жосткого диску',
        MemoryQuantity,
        ReadingSpeed,
        WriteSpeed,
        Cost
    FROM HDD;
END
GO
