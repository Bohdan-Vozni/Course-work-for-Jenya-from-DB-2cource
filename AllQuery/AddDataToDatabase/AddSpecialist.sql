USE PC_constructor
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AddSpecialist')
    DROP PROCEDURE AddSpecialist
GO

CREATE PROCEDURE AddSpecialist
    @Specialist_ID CHAR(36),
    @SpecialistName NVARCHAR(MAX),
    @Phone NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Specialist (Specialist_ID, SpecialistName, Phone)
    VALUES (@Specialist_ID, @SpecialistName, @Phone)
END
GO