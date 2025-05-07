use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'AddMotherboard')
  DROP PROCEDURE AddMotherboard;
GO

CREATE PROCEDURE AddMotherboard
  @Motherboard_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @Chipset NVARCHAR(MAX),
  @TypeSize NVARCHAR(MAX),
  @Socket NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  INSERT INTO Motherboard (Motherboard_ID, Title, Chipset, TypeSize, Socket, Cost)
  VALUES (@Motherboard_ID, @Title, @Chipset, @TypeSize, @Socket, @Cost);
END;
GO