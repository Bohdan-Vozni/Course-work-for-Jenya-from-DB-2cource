USE PC_constructor
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'UpdateSpecialist')
    DROP PROCEDURE UpdateSpecialist
GO


CREATE PROCEDURE UpdateSpecialist
    @Specialist_ID CHAR(36),
    @SpecialistName NVARCHAR(MAX),
    @Phone NVARCHAR(MAX)
AS
BEGIN
    UPDATE Specialist
    SET SpecialistName = @SpecialistName,
        Phone = @Phone
    WHERE Specialist_ID = @Specialist_ID
END
GO