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
        RAM_ID AS 'ID ���',
        Title AS '����� ���������� �����',
        MemoryType AS '��� �����',
        MemoryQuantity AS '����� �����',
        RadiatorType AS '��� ��������',
        Cost AS '������� (���)'
    FROM RAM;
END
GO
