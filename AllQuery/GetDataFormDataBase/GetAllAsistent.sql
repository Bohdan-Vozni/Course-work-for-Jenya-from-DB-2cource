USE PC_constructor
GO

CREATE OR ALTER PROCEDURE GetAllSpecialists
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        SELECT 
            Specialist_ID ,
            SpecialistName ,
            Phone 
        FROM 
            Specialist
        ORDER BY 
            SpecialistName;
        
        PRINT '��� ��� ���������� ������ ��������';
    END TRY
    BEGIN CATCH
        PRINT '������� ��� �������� ����� ��� ����������: ' + ERROR_MESSAGE();
    END CATCH
END;
GO