USE PC_constructor
GO

IF exists ( SELECT name FROM sys.objects WHERE name = 'DeleteTower')
  DROP PROCEDURE DeleteTower;
GO

CREATE PROCEDURE DeleteTower
    @Tower_ID CHAR(36)
AS
BEGIN
    DELETE FROM Tower
    WHERE Tower_ID = @Tower_ID
END
GO