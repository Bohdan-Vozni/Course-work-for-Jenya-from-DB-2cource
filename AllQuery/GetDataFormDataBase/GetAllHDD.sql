use PC_constructor
go

IF exists ( SELECT name FROM sys.objects WHERE name = 'GetAllHDD')
  DROP PROCEDURE GetAllHDD;
GO


CREATE PROCEDURE GetAllHDD
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM HDD;
END
GO