use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'GetAllMotherboard')
  DROP PROCEDURE GetAllMotherboard;
GO

CREATE PROCEDURE GetAllMotherboard
AS
BEGIN
  SELECT * FROM Motherboard;
END;
GO