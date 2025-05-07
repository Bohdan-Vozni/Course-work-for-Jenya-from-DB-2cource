use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'UpdateSSD')
  DROP PROCEDURE UpdateSSD;
GO

CREATE PROCEDURE UpdateSSD
  @SSD_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @MemoryQuantity NVARCHAR(MAX),
  @ReadingSpeed NVARCHAR(MAX),
  @WriteSpeed NVARCHAR(MAX),
  @RadiatorType NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  UPDATE SSD
  SET Title = @Title,
      MemoryQuantity = @MemoryQuantity,
      ReadingSpeed = @ReadingSpeed,
      WriteSpeed = @WriteSpeed,
      RadiatorType = @RadiatorType,
      Cost = @Cost
  WHERE SSD_ID = @SSD_ID;
END;
GO