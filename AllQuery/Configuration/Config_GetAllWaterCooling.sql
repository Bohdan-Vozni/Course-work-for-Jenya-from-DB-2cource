USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Config_GetAllWaterCooling') AND type IN (N'P', N'PC'))
    DROP PROCEDURE Config_GetAllWaterCooling;
GO

CREATE PROCEDURE Config_GetAllWaterCooling
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        WaterCooling_ID AS 'ID �������� �����������',
        Title AS '����� �������� �����������',
        TypeSize AS '�����',
        HeatRemoval AS '³�������� �����',
        Cost AS '������� (���)'
    FROM WaterCooling;
END
GO
