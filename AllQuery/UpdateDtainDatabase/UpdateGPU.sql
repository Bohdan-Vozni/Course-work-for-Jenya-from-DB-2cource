USE PC_constructor
GO

IF exists ( SELECT name FROM sys.objects WHERE name = 'UpdateGPU')
  DROP PROCEDURE UpdateGPU;
GO

CREATE PROCEDURE UpdateGPU
    @GPU_ID CHAR(36),
    @Title NVARCHAR(MAX),
    @Cores NVARCHAR(MAX),
    @Threads NVARCHAR(MAX),
    @VRAMType NVARCHAR(MAX),
    @VRAMQuantity NVARCHAR(MAX),
    @Cache NVARCHAR(MAX),
    @Clock NVARCHAR(MAX),
    @Cost FLOAT
AS
BEGIN
    UPDATE GPU
    SET Title = @Title,
        Cores = @Cores,
        Threads = @Threads,
        VRAMType = @VRAMType,
        VRAMQuantity = @VRAMQuantity,
        Cache = @Cache,
        Clock = @Clock,
        Cost = @Cost
    WHERE GPU_ID = @GPU_ID
END
GO
