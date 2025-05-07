USE PC_constructor
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'Purchase')
DROP TABLE Purchase;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'PC')
DROP TABLE PC;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'Client')
DROP TABLE Client;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'Specialist')
DROP TABLE Specialist;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'CPU')
DROP TABLE CPU;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'GPU')
DROP TABLE GPU;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'Motherboard')
DROP TABLE Motherboard;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'RAM')
DROP TABLE RAM;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'HDD')
DROP TABLE HDD;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'SSD')
DROP TABLE SSD;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'PowerSupply')
DROP TABLE PowerSupply;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'WaterCooling')
DROP TABLE WaterCooling;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'FanCooling')
DROP TABLE FanCooling;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'Wifi')
DROP TABLE Wifi;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'Bluetooth')
DROP TABLE Bluetooth;
GO

IF EXISTS(
	SELECT name
	FROM sys.objects
	WHERE name = 'Tower')
DROP TABLE Tower;
GO

CREATE TABLE Tower
(
	Tower_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	TypeSize NVARCHAR(max) NOT NULL,
	FanType NVARCHAR(max),
	FanIncluded NVARCHAR(max),
	Cost FLOAT,
)
GO

CREATE TABLE Bluetooth
(
	Bluetooth_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	Generation NVARCHAR(max) NOT NULL,
	Cost FLOAT,
)
GO

CREATE TABLE Wifi
(
	Wifi_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	Generation NVARCHAR(max) NOT NULL,
	Cost FLOAT,
)
GO

CREATE TABLE FanCooling
(
	FanCooling_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	TypeSize NVARCHAR(max) NOT NULL,
	HeatRemoval NVARCHAR(max) NOT NULL,
	Cost FLOAT,
)
GO

CREATE TABLE WaterCooling
(
	WaterCooling_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	TypeSize NVARCHAR(max) NOT NULL,
	HeatRemoval NVARCHAR(max) NOT NULL,
	Cost FLOAT,
)
GO

CREATE TABLE PowerSupply
(
	PowerSupply_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	Strength NVARCHAR(max) NOT NULL,
	Sertificate NVARCHAR(max),
	Cost FLOAT,
)
GO

CREATE TABLE SSD
(
	SSD_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	MemoryQuantity NVARCHAR(max) NOT NULL,
	ReadingSpeed NVARCHAR(max) NOT NULL,
	WriteSpeed NVARCHAR(max) NOT NULL,
	RadiatorType NVARCHAR(max),
	Cost FLOAT,
)
GO

CREATE TABLE HDD
(
	HDD_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	MemoryQuantity NVARCHAR(max) NOT NULL,
	ReadingSpeed NVARCHAR(max) NOT NULL,
	WriteSpeed NVARCHAR(max) NOT NULL,
	Cost FLOAT,
)
GO

CREATE TABLE RAM
(
	RAM_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	MemoryType NVARCHAR(max) NOT NULL,
	MemoryQuantity NVARCHAR(max) NOT NULL,
	RadiatorType NVARCHAR(max),
	Cost FLOAT,
)
GO

CREATE TABLE Motherboard
(
	Motherboard_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	Chipset NVARCHAR(max) NOT NULL,
	TypeSize NVARCHAR(max) NOT NULL,
	Socket NVARCHAR(max) NOT NULL,
	Cost FLOAT,
)
GO

CREATE TABLE GPU
(
	GPU_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	Cores NVARCHAR(max) NOT NULL,
	Threads NVARCHAR(max) NOT NULL,
	VRAMType NVARCHAR(max) NOT NULL,
	VRAMQuantity NVARCHAR(max) NOT NULL,
	Cache NVARCHAR(max) NOT NULL,
	Clock NVARCHAR(max) NOT NULL,
	Cost FLOAT,
)
GO

CREATE TABLE CPU
(
	CPU_ID CHAR(36) PRIMARY KEY,
	Title NVARCHAR(max) NOT NULL,
	Cores NVARCHAR(max) NOT NULL,
	Threads NVARCHAR(max) NOT NULL,
	Cache NVARCHAR(max) NOT NULL,
	Clock NVARCHAR(max) NOT NULL,
	Architecture NVARCHAR(max) NOT NULL,
	Cost FLOAT,
)
GO

CREATE TABLE Specialist
(
	Specialist_ID CHAR(36) PRIMARY KEY,
	SpecialistName NVARCHAR(max) NOT NULL,
	Phone NVARCHAR(max) NOT NULL,
)
GO

CREATE TABLE Client
(
	Client_ID CHAR(36) PRIMARY KEY,
	ClientName NVARCHAR(max) NOT NULL,
	Phone NVARCHAR(max) NOT NULL,
	HomeAddress NVARCHAR(max),
)
GO

CREATE TABLE PC
(
	PC_ID CHAR(36) PRIMARY KEY,
	CPU_ID CHAR(36) NOT NULL FOREIGN KEY(CPU_ID) REFERENCES CPU(CPU_ID),
	GPU_ID CHAR(36) NOT NULL FOREIGN KEY(GPU_ID) REFERENCES GPU(GPU_ID),
	Motherboard_ID CHAR(36) NOT NULL FOREIGN KEY(Motherboard_ID) REFERENCES Motherboard(Motherboard_ID),
	RAM_ID CHAR(36) NOT NULL FOREIGN KEY(RAM_ID) REFERENCES RAM(RAM_ID),
	HDD_ID CHAR(36) NOT NULL FOREIGN KEY(HDD_ID) REFERENCES HDD(HDD_ID),
	SSD_ID CHAR(36) NOT NULL FOREIGN KEY(SSD_ID) REFERENCES SSD(SSD_ID),
	PowerSupply_ID CHAR(36) NOT NULL FOREIGN KEY(PowerSupply_ID) REFERENCES PowerSupply(PowerSupply_ID),
	WaterCooling_ID CHAR(36) NOT NULL FOREIGN KEY(WaterCooling_ID) REFERENCES WaterCooling(WaterCooling_ID),
	FanCooling_ID CHAR(36) NOT NULL FOREIGN KEY(FanCooling_ID) REFERENCES FanCooling(FanCooling_ID),
	Wifi_ID CHAR(36) NOT NULL FOREIGN KEY(Wifi_ID) REFERENCES Wifi(Wifi_ID),
	Bluetooth_ID CHAR(36) NOT NULL FOREIGN KEY(Bluetooth_ID) REFERENCES Bluetooth(Bluetooth_ID),
	Tower_ID CHAR(36) NOT NULL FOREIGN KEY(Tower_ID) REFERENCES Tower(Tower_ID),
	ExecutionDate DATE,
	Cost FLOAT,
)
GO

CREATE TABLE Purchase
(
	Purchase_ID CHAR(36) PRIMARY KEY,
	DateCreate DATE,

	Specialist_ID CHAR(36) NOT NULL FOREIGN KEY(Specialist_ID) REFERENCES Specialist(Specialist_ID),
	Client_ID CHAR(36) NOT NULL FOREIGN KEY(Client_ID) REFERENCES Client(Client_ID),
	PC_ID CHAR(36) NOT NULL FOREIGN KEY(PC_ID) REFERENCES PC(PC_ID),
)
GO


