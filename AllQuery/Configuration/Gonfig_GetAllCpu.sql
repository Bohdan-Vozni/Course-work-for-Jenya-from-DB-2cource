use PC_constructor
go

IF exists ( SELECT name FROM sys.objects WHERE name = 'Config_GetAllCPU')
  DROP PROCEDURE Config_GetAllCPU;
GO

CREATE PROCEDURE Config_GetAllCPU
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
		CPU_ID as 'idCPU',
		Title as 'CPU',
		Cores,
		Threads,
		Cache,
		Clock,
		Architecture,
		Cost
    
    
    FROM CPU;
END
GO