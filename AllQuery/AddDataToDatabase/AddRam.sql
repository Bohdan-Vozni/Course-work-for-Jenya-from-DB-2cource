use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'AddRAM')
  DROP PROCEDURE AddRAM;
GO

CREATE PROCEDURE AddRAM
  @RAM_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @MemoryType NVARCHAR(MAX),
  @MemoryQuantity NVARCHAR(MAX),
  @RadiatorType NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  INSERT INTO RAM (RAM_ID, Title, MemoryType, MemoryQuantity, RadiatorType, Cost)
  VALUES (@RAM_ID, @Title, @MemoryType, @MemoryQuantity, @RadiatorType, @Cost);
END;
GO