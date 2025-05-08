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
        Motherboard_ID AS 'ID ����������� �����',
        Title AS '����� ����������� �����',
        Chipset AS '������',
        TypeSize AS '����-������',
        Socket AS '�����',
        Cost AS '������� (���)'
    FROM Motherboard;
END
GO
