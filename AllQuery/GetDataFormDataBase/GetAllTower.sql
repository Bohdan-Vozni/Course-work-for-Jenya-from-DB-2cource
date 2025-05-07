use PC_constructor
go

IF exists ( SELECT name FROM sys.objects WHERE name = 'GetAllTower')
  DROP PROCEDURE GetAllTower;
GO

CREATE PROCEDURE GetAllTower
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Tower;
END
GO