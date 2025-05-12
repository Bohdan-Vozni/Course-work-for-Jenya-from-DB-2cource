USE PC_constructor
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'DeleteSpecialist')
    DROP PROCEDURE DeleteSpecialist
GO


CREATE PROCEDURE DeleteSpecialist
    @Specialist_ID CHAR(36)
AS
BEGIN
    DELETE FROM Specialist WHERE Specialist_ID = @Specialist_ID
END
GO
