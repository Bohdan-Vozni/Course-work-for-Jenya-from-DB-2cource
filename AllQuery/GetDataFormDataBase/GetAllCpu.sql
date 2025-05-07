use PC_constructor
go

IF exists ( SELECT name FROM sys.objects WHERE name = 'GetAllCPU')
  DROP PROCEDURE GetAllCPU;
GO

CREATE PROCEDURE GetAllCPU
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM CPU;
END
GO