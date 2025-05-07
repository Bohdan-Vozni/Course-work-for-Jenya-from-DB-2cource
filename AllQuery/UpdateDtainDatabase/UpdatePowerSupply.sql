use PC_constructor;
go

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'UpdatePowerSupply')
  DROP PROCEDURE UpdatePowerSupply;
GO

CREATE PROCEDURE UpdatePowerSupply
  @PowerSupply_ID CHAR(36),
  @Title NVARCHAR(MAX),
  @Strength NVARCHAR(MAX),
  @Sertificate NVARCHAR(MAX),
  @Cost FLOAT
AS
BEGIN
  UPDATE PowerSupply
  SET Title = @Title,
      Strength = @Strength,
      Sertificate = @Sertificate,
      Cost = @Cost
  WHERE PowerSupply_ID = @PowerSupply_ID;
END;
GO