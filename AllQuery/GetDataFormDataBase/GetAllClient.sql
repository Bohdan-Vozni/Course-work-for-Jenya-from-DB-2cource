USE PC_constructor
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetAllClient')
    DROP PROCEDURE GetAllClient
GO

CREATE PROCEDURE GetAllClient
AS
BEGIN
    SELECT * FROM Client 
END
GO