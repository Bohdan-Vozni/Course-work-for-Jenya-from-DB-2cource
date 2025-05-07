use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'AddFanCooling')
  DROP PROCEDURE AddFanCooling;
GO

-- Процедура для добавления новой системы охлаждения
CREATE PROCEDURE AddFanCooling
  @FanCooling_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @TypeSize NVARCHAR(MAX),
  @HeatRemoval NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  INSERT INTO FanCooling (FanCooling_ID, Title, TypeSize, HeatRemoval, Cost)
  VALUES (@FanCooling_ID, @Title, @TypeSize, @HeatRemoval, @Cost);
END;
GO