USE PC_constructor
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AddClient')
    DROP PROCEDURE AddClient
GO

CREATE PROCEDURE AddClient
    @Client_ID CHAR(36),
    @ClientName NVARCHAR(MAX),
    @Phone NVARCHAR(MAX),
    @HomeAddress NVARCHAR(MAX) 
AS
BEGIN
    INSERT INTO Client (Client_ID, ClientName, Phone, HomeAddress)
    VALUES (@Client_ID, @ClientName, @Phone, @HomeAddress)
END
GO