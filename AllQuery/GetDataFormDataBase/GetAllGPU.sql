use PC_constructor
go

IF exists ( SELECT name FROM sys.objects WHERE name = 'GetAllGPU')
  DROP PROCEDURE GetAllGPU;
GO

CREATE PROCEDURE GetAllGPU
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM GPU;
END
GO