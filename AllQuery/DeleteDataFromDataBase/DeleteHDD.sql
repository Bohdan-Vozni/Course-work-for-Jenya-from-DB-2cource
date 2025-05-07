use PC_constructor
go

IF exists ( SELECT name FROM sys.objects WHERE name = 'DeleteHDD')
  DROP PROCEDURE DeleteHDD;
GO


CREATE PROCEDURE DeleteHDD
    @HDD_ID CHAR(36)
AS
BEGIN
    DELETE FROM HDD WHERE HDD_ID = @HDD_ID
END
GO