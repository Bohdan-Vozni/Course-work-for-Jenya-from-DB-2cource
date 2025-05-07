use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'AddSSD')
  DROP PROCEDURE AddSSD;
GO

CREATE PROCEDURE AddSSD
  @SSD_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @MemoryQuantity NVARCHAR(MAX),
  @ReadingSpeed NVARCHAR(MAX),
  @WriteSpeed NVARCHAR(MAX),
  @RadiatorType NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  INSERT INTO SSD (SSD_ID, Title, MemoryQuantity, ReadingSpeed, WriteSpeed, RadiatorType, Cost)
  VALUES (@SSD_ID, @Title, @MemoryQuantity, @ReadingSpeed, @WriteSpeed, @RadiatorType, @Cost);
END;
GO