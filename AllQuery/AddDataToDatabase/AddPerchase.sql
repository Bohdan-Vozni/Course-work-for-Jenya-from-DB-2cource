USE PC_constructor;
GO

IF EXISTS (SELECT name FROM sys.objects WHERE name = 'AddPurchase')
  DROP PROCEDURE AddPurchase;
GO

CREATE PROCEDURE AddPurchase
    @Purchase_ID CHAR(36),
    @DateCreate DATE,
    @Specialist_ID CHAR(36),
    @Client_ID CHAR(36),
    @PC_ID CHAR(36)
AS
BEGIN
    INSERT INTO Purchase (
        Purchase_ID,
        DateCreate,
        Specialist_ID,
        Client_ID,
        PC_ID
    )
    VALUES (
        @Purchase_ID,
        @DateCreate,
        @Specialist_ID,
        @Client_ID,
        @PC_ID
    )
END
GO


-- �������� ������� ����� ���������� ����� ����� (�����������)
DELETE FROM Purchase;
DELETE FROM PC;
DELETE FROM Client;
DELETE FROM Specialist;
GO

-- ��������� �������� �볺��� � ������ ���������� ID
INSERT INTO Client (Client_ID, ClientName, Phone, HomeAddress)
VALUES
    (NEWID(), '���� ��������', '+380991234567', '���. ����������, 10, ��. 5, ���'),
    (NEWID(), '���� ��������', '+380672345678', '���. ��������, 25, ����'),
    (NEWID(), '��������� ���������', '+380503456789', '�����. ��������, 15, �����'),
    (NEWID(), '������ ���������', '+380634567890', '���. �������, 3, �����'),
    (NEWID(), '³���� �������', '+380955678901', '���. ������, 7, �����');
GO

-- ��������� �������� ���������� � ������ ���������� ID
INSERT INTO Specialist (Specialist_ID, SpecialistName, Phone)
VALUES
    (NEWID(), '����� ���������', '+380991112233'),
    (NEWID(), '����� ����''�������', '+380672223344'),
    (NEWID(), '������� ����������', '+380503334455'),
    (NEWID(), '���� ³����������', '+380634445566'),
    (NEWID(), '����� �������������', '+380955556677');
GO