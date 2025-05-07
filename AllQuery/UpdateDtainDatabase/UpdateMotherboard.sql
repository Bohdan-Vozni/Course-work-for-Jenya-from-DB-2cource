use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'UpdateMotherboard')
  DROP PROCEDURE UpdateMotherboard;
GO

CREATE PROCEDURE UpdateMotherboard
  @Motherboard_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @Chipset NVARCHAR(MAX),
  @TypeSize NVARCHAR(MAX),
  @Socket NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  UPDATE Motherboard
  SET Title = @Title,
      Chipset = @Chipset,
      TypeSize = @TypeSize,
      Socket = @Socket,
      Cost = @Cost
  WHERE Motherboard_ID = @Motherboard_ID;
END;
GO