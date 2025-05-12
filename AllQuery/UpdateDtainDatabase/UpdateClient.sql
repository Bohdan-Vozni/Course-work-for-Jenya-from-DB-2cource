USE PC_constructor
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'UpdateClient')
    DROP PROCEDURE UpdateClient
GO

CREATE PROCEDURE UpdateClient
    @Client_ID CHAR(36),
    @ClientName NVARCHAR(MAX),
    @Phone NVARCHAR(MAX),
    @HomeAddress NVARCHAR(MAX) = NULL
AS
BEGIN
    UPDATE Client
    SET ClientName = @ClientName,
        Phone = @Phone,
        HomeAddress = @HomeAddress
    WHERE Client_ID = @Client_ID
END
GO