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
        GPU_ID AS 'ID ³��������',
        Title AS '����� ���������',
        Cores AS 'ʳ������ ����',
        Threads AS 'ʳ������ ������',
        VRAMType AS '��� ���������',
        VRAMQuantity AS '����� ���������',
        Cache AS '���',
        Clock AS '������� �������',
        Cost AS '������� (���)'
    FROM GPU;
END
GO
