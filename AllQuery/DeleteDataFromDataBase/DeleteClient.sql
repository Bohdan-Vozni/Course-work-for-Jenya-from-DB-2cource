USE PC_constructor
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'DeleteClient')
    DROP PROCEDURE DeleteClient
GO

CREATE PROCEDURE DeleteClient
    @Client_ID CHAR(36)
AS
BEGIN
    DELETE FROM Client WHERE Client_ID = @Client_ID
END
GO