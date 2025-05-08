-- ������� �������� ����� ��� ����������
DECLARE @cpuID CHAR(36) = NEWID(), @gpuID CHAR(36) = NEWID(), @mbID CHAR(36) = NEWID(),
        @ramID CHAR(36) = NEWID(), @hddID CHAR(36) = NEWID(), @ssdID CHAR(36) = NEWID(),
        @psID CHAR(36) = NEWID(), @wcID CHAR(36) = NEWID(), @fcID CHAR(36) = NEWID(),
        @wifiID CHAR(36) = NEWID(), @btID CHAR(36) = NEWID(), @towerID CHAR(36) = NEWID();

INSERT INTO CPU VALUES(@cpuID, N'Intel i5', '6', '12', '12MB', '3.5GHz', 'x86-64', 200)
INSERT INTO GPU VALUES(@gpuID, N'NVIDIA RTX 3060', '3584', '3584', 'GDDR6', '12GB', '2MB', '1.8GHz', 350)
INSERT INTO Motherboard VALUES(@mbID, N'MSI B550', 'B550', 'ATX', 'AM4', 150)
INSERT INTO RAM VALUES(@ramID, N'Kingston 16GB', 'DDR4', '16GB', 'Aluminium', 80)
INSERT INTO HDD VALUES(@hddID, N'Seagate 1TB', '1TB', '150MB/s', '140MB/s', 50)
INSERT INTO SSD VALUES(@ssdID, N'Samsung 970 Evo', '500GB', '3500MB/s', '3300MB/s', 'Copper', 100)
INSERT INTO PowerSupply VALUES(@psID, N'Corsair 650W', '650W', '80+ Gold', 90)
INSERT INTO WaterCooling VALUES(@wcID, N'NZXT Kraken', '240mm', '150W', 120)
INSERT INTO FanCooling VALUES(@fcID, N'Cooler Master Fan', '120mm', '75W', 30)
INSERT INTO Wifi VALUES(@wifiID, N'Intel AX200', 'WiFi 6', 40)
INSERT INTO Bluetooth VALUES(@btID, N'Intel BT5', '5.0', 20)
INSERT INTO Tower VALUES(@towerID, N'NZXT H510', 'Mid Tower', '120mm', 'Yes', 70)

-- ������� ������� � �볺���
DECLARE @specID CHAR(36) = NEWID(), @clientID CHAR(36) = NEWID();
INSERT INTO Specialist VALUES(@specID, N'I��� ������', '380991112233')
INSERT INTO Client VALUES(@clientID, N'����� ��������', '380991112244', N'���, ���. �������� 1')

-- ��������� ��
DECLARE @pcID CHAR(36) = NEWID();
INSERT INTO PC VALUES(
	@pcID, @cpuID, @gpuID, @mbID, @ramID, @hddID, @ssdID,
	@psID, @wcID, @fcID, @wifiID, @btID, @towerID, GETDATE(), NULL)

-- ������ ��������� ��������� �������
DECLARE @purchaseID CHAR(36) = NEWID();
EXEC AddPurchase @purchaseID, @specID, @clientID, @pcID, GETDATE();

-- ��������: ���������� ������� � ��
SELECT * FROM Purchase;
SELECT * FROM PC;

-- ���� �������: ������� ���� CPU � ��������� �� ��������� ������� ��
UPDATE CPU SET Cost = 300 WHERE CPU_ID = @cpuID;
SELECT * FROM PC;

-- ���� ������� �������� ��������� �� (�� ��������� �볺���)
DELETE FROM PC WHERE PC_ID = @pcID; -- ������� ��������� ������� ���� ������� �� �

-- ���� ��������� ��������� �볺��� � ���������
EXEC DeleteClientAndPurchases @clientID;

-- ��������: �볺�� � ������� ������ ���� �������
SELECT * FROM Client;
SELECT * FROM Purchase;

-- ����� ��������� �� ��������� (��������)
DELETE FROM PC WHERE PC_ID = @pcID;
SELECT * FROM PC;
