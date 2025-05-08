USE PC_constructor
GO

IF exists ( SELECT name FROM sys.objects WHERE name = 'UpdateCPU')
  DROP PROCEDURE UpdateCPU;
GO

CREATE PROCEDURE UpdateCPU
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
    UPDATE CPU
    SET 
        Title = @Title,
        Cores = @Cores,
        Threads = @Threads,
        Cache = @Cache,
        Clock = @Clock,
        Architecture = @Architecture,
        Cost = @Cost
    WHERE CPU_ID = @CPU_ID;
END
GO