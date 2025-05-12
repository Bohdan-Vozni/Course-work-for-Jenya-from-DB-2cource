USE PC_constructor
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetAllSpecialist')
    DROP PROCEDURE GetAllSpecialist
GO

CREATE PROCEDURE GetAllSpecialist
    @Specialist_ID CHAR(36)
AS
BEGIN
    SELECT * FROM Specialist 
END
GO