USE PC_constructor
GO

IF exists ( SELECT name FROM sys.objects WHERE name = 'AddGPU')
  DROP PROCEDURE AddGPU;
GO

CREATE PROCEDURE AddGPU
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
    INSERT INTO GPU (GPU_ID, Title, Cores, Threads, VRAMType, VRAMQuantity, Cache, Clock, Cost)
    VALUES (@GPU_ID, @Title, @Cores, @Threads, @VRAMType, @VRAMQuantity, @Cache, @Clock, @Cost)
END
GO
