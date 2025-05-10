USE PC_constructor;
GO

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'GetDataClientForPurchase')
  DROP PROCEDURE GetDataClientForPurchase;
GO

CREATE PROCEDURE GetDataClientForPurchase
    @client_id CHAR(36) = NULL,
    @name NVARCHAR(MAX) = NULL
AS
BEGIN
    SELECT 
        Client_ID,
        ClientName AS 'Client Name'
    FROM 
        Client
    WHERE 
        (@client_id IS NULL OR Client_ID = @client_id)
        AND
        (@name IS NULL OR ClientName LIKE '%' + @name + '%');
END
GO