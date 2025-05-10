USE PC_constructor;
GO

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'GetDataSpecialistForPurchase')
  DROP PROCEDURE GetDataSpecialistForPurchase;
GO

CREATE PROCEDURE GetDataSpecialistForPurchase
AS
BEGIN
    SELECT 
        Specialist_ID,
        SpecialistName 
    FROM 
        Specialist
END
GO