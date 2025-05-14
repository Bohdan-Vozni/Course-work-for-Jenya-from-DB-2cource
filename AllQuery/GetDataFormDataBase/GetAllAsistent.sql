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
        
        PRINT 'Дані про спеціалістів успішно отримано';
    END TRY
    BEGIN CATCH
        PRINT 'Помилка при отриманні даних про спеціалістів: ' + ERROR_MESSAGE();
    END CATCH
END;
GO