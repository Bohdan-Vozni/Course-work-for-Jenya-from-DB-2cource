USE PC_constructor
GO

IF exists ( SELECT name FROM sys.objects WHERE name = 'DeleteCPU')
  DROP PROCEDURE DeleteCPU;
GO

CREATE PROCEDURE DeleteCPU
    @CPU_ID CHAR(36)
AS
BEGIN
    DELETE FROM CPU
    WHERE CPU_ID = @CPU_ID;
END
GO
