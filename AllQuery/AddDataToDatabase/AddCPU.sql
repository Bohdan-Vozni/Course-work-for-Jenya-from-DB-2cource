USE PC_constructor
GO

IF exists ( SELECT name FROM sys.objects WHERE name = 'AddCPU')
  DROP PROCEDURE AddCPU;
GO

CREATE PROCEDURE AddCPU
    @CPU_ID CHAR(36),
    @Title NVARCHAR(MAX),
    @Cores NVARCHAR(MAX),
    @Threads NVARCHAR(MAX),
    @Cache NVARCHAR(MAX),
    @Clock NVARCHAR(MAX),
    @Architecture NVARCHAR(MAX),
    @Cost FLOAT
AS
BEGIN
    INSERT INTO CPU (CPU_ID, Title, Cores, Threads, Cache, Clock, Architecture, Cost)
    VALUES (@CPU_ID, @Title, @Cores, @Threads, @Cache, @Clock, @Architecture, @Cost);
END
GO