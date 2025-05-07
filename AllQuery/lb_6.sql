USE PC_constructor;
GO

BEGIN TRANSACTION;
DELETE FROM CPU;
INSERT INTO CPU (CPU_ID, Title, Cores, Threads, Cache, Clock, Architecture, Cost)
VALUES 
('CPU001', 'Intel Core i7-10700K', '8', '16', '16MB', '3.8GHz', 'Comet Lake', 349.99),
('CPU002', 'AMD Ryzen 9 5900X', '12', '24', '70MB', '3.7GHz', 'Zen 3', 549.99),
('CPU003', 'Intel Core i5-10600K', '6', '12', '12MB', '4.1GHz', 'Comet Lake', 279.99),
('CPU004', 'AMD Ryzen 5 5600X', '6', '12', '35MB', '3.7GHz', 'Zen 3', 299.99),
('CPU005', 'Intel Core i9-10900K', '10', '20', '20MB', '3.7GHz', 'Comet Lake', 499.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM GPU;
INSERT INTO GPU (GPU_ID, Title, Cores, Threads, VRAMType, VRAMQuantity, Cache, Clock, Cost)
VALUES 
('GPU001', 'NVIDIA GeForce RTX 3080', '8704', '8704', 'GDDR6X', '10GB', '10MB', '1.44GHz', 699.99),
('GPU002', 'AMD Radeon RX 6800 XT', '4608', '4608', 'GDDR6', '16GB', '128MB', '2.02GHz', 649.99),
('GPU003', 'NVIDIA GeForce RTX 3070', '5888', '5888', 'GDDR6', '8GB', '8MB', '1.5GHz', 499.99),
('GPU004', 'AMD Radeon RX 6700 XT', '2560', '2560', 'GDDR6', '12GB', '96MB', '2.42GHz', 479.99),
('GPU005', 'NVIDIA GeForce GTX 1660 Super', '1408', '1408', 'GDDR6', '6GB', '6MB', '1.53GHz', 229.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM Motherboard;
INSERT INTO Motherboard (Motherboard_ID, Title, Chipset, TypeSize, Socket, Cost)
VALUES 
('MB001', 'ASUS ROG Strix Z490-E', 'Z490', 'ATX', 'LGA1200', 299.99),
('MB002', 'MSI MAG B550 TOMAHAWK', 'B550', 'ATX', 'AM4', 179.99),
('MB003', 'Gigabyte Z390 AORUS PRO', 'Z390', 'ATX', 'LGA1151', 189.99),
('MB004', 'ASRock B450M PRO4', 'B450', 'Micro-ATX', 'AM4', 79.99),
('MB005', 'ASUS TUF Gaming X570-Plus', 'X570', 'ATX', 'AM4', 199.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM RAM;
INSERT INTO RAM (RAM_ID, Title, MemoryType, MemoryQuantity, RadiatorType, Cost)
VALUES 
('RAM001', 'Corsair Vengeance LPX 16GB', 'DDR4', '16GB', 'Aluminum', 79.99),
('RAM002', 'G.Skill Trident Z RGB 32GB', 'DDR4', '32GB', 'Aluminum', 169.99),
('RAM003', 'Kingston HyperX Fury 8GB', 'DDR4', '8GB', 'Aluminum', 49.99),
('RAM004', 'Crucial Ballistix 16GB', 'DDR4', '16GB', 'Aluminum', 69.99),
('RAM005', 'Team T-Force Delta RGB 32GB', 'DDR4', '32GB', 'Aluminum', 149.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM HDD;
INSERT INTO HDD (HDD_ID, Title, MemoryQuantity, ReadingSpeed, WriteSpeed, Cost)
VALUES 
('HDD001', 'Seagate BarraCuda 2TB', '2TB', '220MB/s', '220MB/s', 54.99),
('HDD002', 'Western Digital Blue 1TB', '1TB', '150MB/s', '150MB/s', 44.99),
('HDD003', 'Toshiba P300 3TB', '3TB', '180MB/s', '180MB/s', 74.99),
('HDD004', 'Seagate IronWolf 4TB', '4TB', '210MB/s', '210MB/s', 119.99),
('HDD005', 'Western Digital Black 6TB', '6TB', '225MB/s', '225MB/s', 199.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM SSD;
INSERT INTO SSD (SSD_ID, Title, MemoryQuantity, ReadingSpeed, WriteSpeed, RadiatorType, Cost)
VALUES 
('SSD001', 'Samsung 970 EVO Plus 1TB', '1TB', '3500MB/s', '3300MB/s', 'None', 149.99),
('SSD002', 'WD Blue SN550 500GB', '500GB', '2400MB/s', '1750MB/s', 'None', 59.99),
('SSD003', 'Crucial P1 1TB', '1TB', '2000MB/s', '1700MB/s', 'None', 99.99),
('SSD004', 'Kingston A2000 500GB', '500GB', '2200MB/s', '2000MB/s', 'None', 69.99),
('SSD005', 'Sabrent Rocket Q 2TB', '2TB', '3300MB/s', '2900MB/s', 'None', 249.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM PowerSupply;
INSERT INTO PowerSupply (PowerSupply_ID, Title, Strength, Sertificate, Cost)
VALUES 
('PSU001', 'Corsair RM850x', '850W', '80+ Gold', 129.99),
('PSU002', 'EVGA SuperNOVA 750 G5', '750W', '80+ Gold', 119.99),
('PSU003', 'Seasonic FOCUS GX-750', '750W', '80+ Gold', 129.99),
('PSU004', 'Thermaltake Toughpower GF1 850W', '850W', '80+ Gold', 139.99),
('PSU005', 'be quiet! Straight Power 11 750W', '750W', '80+ Platinum', 149.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM WaterCooling;
INSERT INTO WaterCooling (WaterCooling_ID, Title, TypeSize, HeatRemoval, Cost)
VALUES 
('WC001', 'NZXT Kraken X63', '280mm', 'High', 149.99),
('WC002', 'Corsair iCUE H150i Elite Capellix', '360mm', 'Very High', 169.99),
('WC003', 'Cooler Master MasterLiquid ML240R', '240mm', 'Medium', 109.99),
('WC004', 'EVGA CLC 280', '280mm', 'High', 119.99),
('WC005', 'Thermaltake Water 3.0 Riing RGB 360', '360mm', 'Very High', 159.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM FanCooling;
INSERT INTO FanCooling (FanCooling_ID, Title, TypeSize, HeatRemoval, Cost)
VALUES 
('FC001', 'Noctua NH-D15', 'Dual Tower', 'High', 89.99),
('FC002', 'Cooler Master Hyper 212 EVO', 'Single Tower', 'Medium', 39.99),
('FC003', 'be quiet! Dark Rock Pro 4', 'Dual Tower', 'High', 89.99),
('FC004', 'Deepcool GAMMAXX GT', 'Single Tower', 'Medium', 49.99),
('FC005', 'ARCTIC Freezer 34 eSports DUO', 'Dual Tower', 'High', 59.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM Wifi;
INSERT INTO Wifi (Wifi_ID, Title, Generation, Cost)
VALUES 
('WIFI001', 'TP-Link Archer T9E', 'Wi-Fi 5', 69.99),
('WIFI002', 'ASUS PCE-AC88', 'Wi-Fi 5', 109.99),
('WIFI003', 'Intel Wi-Fi 6 AX200', 'Wi-Fi 6', 29.99),
('WIFI004', 'Gigabyte GC-WBAX200', 'Wi-Fi 6', 49.99),
('WIFI005', 'Netgear Nighthawk A7000', 'Wi-Fi 5', 99.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM Bluetooth;
INSERT INTO Bluetooth (Bluetooth_ID, Title, Generation, Cost)
VALUES 
('BT001', 'ASUS USB-BT500', 'Bluetooth 5.0', 19.99),
('BT002', 'TP-Link UB500', 'Bluetooth 5.0', 14.99),
('BT003', 'Kinivo BTD-400', 'Bluetooth 4.0', 12.99),
('BT004', 'Plugable USB Bluetooth Adapter', 'Bluetooth 4.0', 9.99),
('BT005', 'Avantree DG40S', 'Bluetooth 4.0', 24.99);
COMMIT;

BEGIN TRANSACTION;
DELETE FROM Tower;
INSERT INTO Tower (Tower_ID, Title, TypeSize, FanType, FanIncluded, Cost)
VALUES 
('TWR001', 'NZXT H510', 'Mid Tower', '120mm', 'Yes', 79.99),
('TWR002', 'Fractal Design Meshify C', 'Mid Tower', '120mm', 'Yes', 99.99),
('TWR003', 'Corsair iCUE 4000X RGB', 'Mid Tower', '120mm', 'Yes', 139.99),
('TWR004', 'Lian Li PC-O11 Dynamic', 'Full Tower', '120mm', 'No', 149.99),
('TWR005', 'Phanteks Eclipse P400A', 'Mid Tower', '120mm', 'Yes', 89.99);
COMMIT;