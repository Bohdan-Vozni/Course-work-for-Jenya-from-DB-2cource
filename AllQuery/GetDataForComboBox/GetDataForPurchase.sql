USE PC_constructor;
GO

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'GetDataForPurchase')
  DROP PROCEDURE GetDataForPurchase;
GO

CREATE PROCEDURE GetDataForPurchase
  
AS
BEGIN
    SELECT 
        Client_ID,
        ClientName 
    FROM 
        Client
    
END
GO