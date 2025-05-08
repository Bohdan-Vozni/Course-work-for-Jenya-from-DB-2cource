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
        Title AS '����� SSD',
        MemoryQuantity AS '����� �����',
        ReadingSpeed AS '�������� �������',
        WriteSpeed AS '�������� ������',
        RadiatorType AS '��� ��������',
        Cost AS '������� (���)'
    FROM SSD;
END
GO
