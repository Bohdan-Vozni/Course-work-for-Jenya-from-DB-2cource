USE PC_constructor
GO

IF EXISTS (
    SELECT name FROM sys.views WHERE name = 'vw_SpecialistSales'
)
DROP VIEW vw_SpecialistSales
GO

IF EXISTS (
    SELECT name FROM sys.views WHERE name = 'vw_ClientPurchases'
)
DROP VIEW vw_ClientPurchases
GO

IF EXISTS (
    SELECT name FROM sys.views WHERE name = 'vw_PC_Details'
)
DROP VIEW vw_PC_Details
GO

IF EXISTS (
    SELECT name FROM sys.views WHERE name = 'vw_FullClientInfo'
)
DROP VIEW vw_FullClientInfo
GO

CREATE VIEW vw_PC_Details AS
SELECT 
    PC.PC_ID,
    CPU.Title AS CPU_Title,
    GPU.Title AS GPU_Title,
    Motherboard.Title AS Motherboard_Title,
    RAM.Title AS RAM_Title,
    HDD.Title AS HDD_Title,
    SSD.Title AS SSD_Title,
    PowerSupply.Title AS PowerSupply_Title,
    WaterCooling.Title AS WaterCooling_Title,
    FanCooling.Title AS FanCooling_Title,
    Wifi.Title AS Wifi_Title,
    Bluetooth.Title AS Bluetooth_Title,
    Tower.Title AS Tower_Title,
    PC.ExecutionDate,
    PC.Cost,
    Client.ClientName AS FullName  
FROM PC
JOIN CPU ON PC.CPU_ID = CPU.CPU_ID
JOIN GPU ON PC.GPU_ID = GPU.GPU_ID
JOIN Motherboard ON PC.Motherboard_ID = Motherboard.Motherboard_ID
JOIN RAM ON PC.RAM_ID = RAM.RAM_ID
LEFT JOIN HDD ON PC.HDD_ID = HDD.HDD_ID
LEFT JOIN SSD ON PC.SSD_ID = SSD.SSD_ID
JOIN PowerSupply ON PC.PowerSupply_ID = PowerSupply.PowerSupply_ID
LEFT JOIN WaterCooling ON PC.WaterCooling_ID = WaterCooling.WaterCooling_ID
LEFT JOIN FanCooling ON PC.FanCooling_ID = FanCooling.FanCooling_ID
JOIN Wifi ON PC.Wifi_ID = Wifi.Wifi_ID
JOIN Bluetooth ON PC.Bluetooth_ID = Bluetooth.Bluetooth_ID
JOIN Tower ON PC.Tower_ID = Tower.Tower_ID
JOIN Purchase ON Purchase.PC_ID = PC.PC_ID         
JOIN Client ON Purchase.Client_ID = Client.Client_ID;
GO


CREATE VIEW vw_ClientPurchases AS
SELECT 
    Purchase.Purchase_ID,
    Client.ClientName,
    Client.Phone AS ClientPhone,
    Specialist.SpecialistName,
    PC.Cost AS PCCost,
    Purchase.DateCreate
FROM Purchase
JOIN Client ON Purchase.Client_ID = Client.Client_ID
JOIN Specialist ON Purchase.Specialist_ID = Specialist.Specialist_ID
JOIN PC ON Purchase.PC_ID = PC.PC_ID;
GO

CREATE VIEW vw_SpecialistSales AS
SELECT 
    Specialist.Specialist_ID,
    Specialist.SpecialistName,
    COUNT(Purchase.Purchase_ID) AS TotalSales,
    SUM(PC.Cost) AS TotalRevenue
FROM Purchase
JOIN Specialist ON Purchase.Specialist_ID = Specialist.Specialist_ID
JOIN PC ON Purchase.PC_ID = PC.PC_ID
GROUP BY Specialist.Specialist_ID, Specialist.SpecialistName;
GO

CREATE VIEW vw_FullClientInfo AS
SELECT 
    Cl.Client_ID,
    Cl.ClientName,
    Cl.Phone AS ClientPhone,
    Cl.HomeAddress,

    Sp.Specialist_ID,
    Sp.SpecialistName,
    Sp.Phone AS SpecialistPhone,

    Pu.Purchase_ID,
    Pu.DateCreate,

    PC.PC_ID,	
    CPU.Title AS CPU_Title,
    GPU.Title AS GPU_Title,
    MB.Title AS Motherboard_Title,
    RAM.Title AS RAM_Title,
    HDD.Title AS HDD_Title,
    SSD.Title AS SSD_Title,
    PS.Title AS PowerSupply_Title,
    WC.Title AS WaterCooling_Title,
    FC.Title AS FanCooling_Title,
    WF.Title AS Wifi_Title,
    BT.Title AS Bluetooth_Title,
    TWR.Title AS Tower_Title,
    PC.Cost

FROM Purchase Pu
JOIN Client Cl ON Pu.Client_ID = Cl.Client_ID
JOIN Specialist Sp ON Pu.Specialist_ID = Sp.Specialist_ID
JOIN PC ON Pu.PC_ID = PC.PC_ID

JOIN CPU ON PC.CPU_ID = CPU.CPU_ID
JOIN GPU ON PC.GPU_ID = GPU.GPU_ID
JOIN Motherboard MB ON PC.Motherboard_ID = MB.Motherboard_ID
JOIN RAM ON PC.RAM_ID = RAM.RAM_ID
LEFT JOIN HDD ON PC.HDD_ID = HDD.HDD_ID
LEFT JOIN SSD ON PC.SSD_ID = SSD.SSD_ID
JOIN PowerSupply PS ON PC.PowerSupply_ID = PS.PowerSupply_ID
LEFT JOIN WaterCooling WC ON PC.WaterCooling_ID = WC.WaterCooling_ID
LEFT JOIN FanCooling FC ON PC.FanCooling_ID = FC.FanCooling_ID
JOIN Wifi WF ON PC.Wifi_ID = WF.Wifi_ID
JOIN Bluetooth BT ON PC.Bluetooth_ID = BT.Bluetooth_ID
JOIN Tower TWR ON PC.Tower_ID = TWR.Tower_ID;
GO
