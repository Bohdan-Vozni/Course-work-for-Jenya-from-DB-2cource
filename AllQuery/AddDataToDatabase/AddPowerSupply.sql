use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'AddPowerSupply')
  DROP PROCEDURE AddPowerSupply;
GO

CREATE PROCEDURE AddPowerSupply
  @PowerSupply_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @Strength NVARCHAR(MAX),
  @Sertificate NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  INSERT INTO PowerSupply (PowerSupply_ID, Title, Strength, Sertificate, Cost)
  VALUES (@PowerSupply_ID, @Title, @Strength, @Sertificate, @Cost);
END;
GO
