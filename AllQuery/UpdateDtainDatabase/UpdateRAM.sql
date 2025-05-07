use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'UpdateRAM')
  DROP PROCEDURE UpdateRAM;
GO

CREATE PROCEDURE UpdateRAM
  @RAM_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @MemoryType NVARCHAR(MAX),
  @MemoryQuantity NVARCHAR(MAX),
  @RadiatorType NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  UPDATE RAM
  SET Title = @Title,
      MemoryType = @MemoryType,
      MemoryQuantity = @MemoryQuantity,
      RadiatorType = @RadiatorType,
      Cost = @Cost
  WHERE RAM_ID = @RAM_ID;
END;
GO