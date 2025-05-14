USE PC_constructor
GO

-- 1. Додавання процесорів (CPU)
BEGIN TRANSACTION;
INSERT INTO CPU (CPU_ID, Title, Cores, Threads, Cache, Clock, Architecture, Cost)
VALUES 
(NEWID(), 'Intel Core i9-13900K', '24', '32', '36MB', '3.0-5.8 GHz', 'Raptor Lake', 650.00),
(NEWID(), 'AMD Ryzen 9 7950X', '16', '32', '80MB', '4.5-5.7 GHz', 'Zen 4', 600.00),
(NEWID(), 'Intel Core i7-13700K', '16', '24', '30MB', '3.4-5.4 GHz', 'Raptor Lake', 420.00),
(NEWID(), 'AMD Ryzen 7 7700X', '8', '16', '40MB', '4.5-5.4 GHz', 'Zen 4', 350.00),
(NEWID(), 'Intel Core i5-13600K', '14', '20', '24MB', '3.5-5.1 GHz', 'Raptor Lake', 300.00);
COMMIT TRANSACTION;
GO

-- 2. Додавання відеокарт (GPU)
BEGIN TRANSACTION;
INSERT INTO GPU (GPU_ID, Title, Cores, Threads, VRAMType, VRAMQuantity, Cache, Clock, Cost)
VALUES 
(NEWID(), 'NVIDIA RTX 4090', '16384', '32768', 'GDDR6X', '24GB', '72MB', '2.23-2.52 GHz', 1600.00),
(NEWID(), 'AMD RX 7900 XTX', '6144', '12288', 'GDDR6', '24GB', '96MB', '1.9-2.5 GHz', 1000.00),
(NEWID(), 'NVIDIA RTX 4080', '9728', '19456', 'GDDR6X', '16GB', '64MB', '2.21-2.51 GHz', 1200.00),
(NEWID(), 'AMD RX 7800 XT', '3840', '7680', 'GDDR6', '16GB', '64MB', '1.8-2.4 GHz', 500.00),
(NEWID(), 'NVIDIA RTX 4070 Ti', '7680', '15360', 'GDDR6X', '12GB', '48MB', '2.31-2.61 GHz', 800.00);
COMMIT TRANSACTION;
GO

-- 3. Додавання материнських плат (Motherboard)
BEGIN TRANSACTION;
INSERT INTO Motherboard (Motherboard_ID, Title, Chipset, TypeSize, Socket, Cost)
VALUES 
(NEWID(), 'ASUS ROG Maximus Z790 Hero', 'Z790', 'ATX', 'LGA 1700', 600.00),
(NEWID(), 'Gigabyte X670E AORUS Master', 'X670E', 'ATX', 'AM5', 500.00),
(NEWID(), 'MSI MPG B650 Carbon WiFi', 'B650', 'ATX', 'AM5', 300.00),
(NEWID(), 'ASRock Z690 Steel Legend', 'Z690', 'ATX', 'LGA 1700', 250.00),
(NEWID(), 'ASUS TUF Gaming B550-Plus', 'B550', 'ATX', 'AM4', 150.00);
COMMIT TRANSACTION;
GO

-- 4. Додавання оперативної пам'яті (RAM)
BEGIN TRANSACTION;
INSERT INTO RAM (RAM_ID, Title, MemoryType, MemoryQuantity, RadiatorType, Cost)
VALUES 
(NEWID(), 'Corsair Dominator Platinum RGB', 'DDR5', '32GB (2x16GB)', 'Aluminum', 250.00),
(NEWID(), 'G.Skill Trident Z5 RGB', 'DDR5', '64GB (2x32GB)', 'Aluminum', 300.00),
(NEWID(), 'Kingston Fury Beast', 'DDR4', '16GB (2x8GB)', 'None', 80.00),
(NEWID(), 'Crucial Ballistix', 'DDR4', '32GB (2x16GB)', 'Aluminum', 120.00),
(NEWID(), 'TeamGroup T-Force Delta RGB', 'DDR4', '16GB (2x8GB)', 'Aluminum', 90.00);
COMMIT TRANSACTION;
GO

-- 5. Додавання HDD
BEGIN TRANSACTION;
INSERT INTO HDD (HDD_ID, Title, MemoryQuantity, ReadingSpeed, WriteSpeed, Cost)
VALUES 
(NEWID(), 'Seagate IronWolf Pro', '8TB', '250MB/s', '250MB/s', 200.00),
(NEWID(), 'WD Black', '4TB', '220MB/s', '220MB/s', 150.00),
(NEWID(), 'Toshiba X300', '6TB', '230MB/s', '230MB/s', 180.00),
(NEWID(), 'Seagate BarraCuda', '2TB', '190MB/s', '190MB/s', 70.00),
(NEWID(), 'WD Blue', '1TB', '180MB/s', '180MB/s', 50.00);
COMMIT TRANSACTION;
GO

-- 6. Додавання SSD
BEGIN TRANSACTION;
INSERT INTO SSD (SSD_ID, Title, MemoryQuantity, ReadingSpeed, WriteSpeed, RadiatorType, Cost)
VALUES 
(NEWID(), 'Samsung 980 Pro', '1TB', '7000MB/s', '5000MB/s', 'None', 150.00),
(NEWID(), 'WD Black SN850X', '2TB', '7300MB/s', '6600MB/s', 'None', 250.00),
(NEWID(), 'Crucial P5 Plus', '1TB', '6600MB/s', '5000MB/s', 'None', 120.00),
(NEWID(), 'Samsung 870 EVO', '1TB', '560MB/s', '530MB/s', 'None', 100.00),
(NEWID(), 'Kingston KC3000', '2TB', '7000MB/s', '7000MB/s', 'None', 220.00);
COMMIT TRANSACTION;
GO

-- 7. Додавання блоків живлення (PowerSupply)
BEGIN TRANSACTION;
INSERT INTO PowerSupply (PowerSupply_ID, Title, Strength, Sertificate, Cost)
VALUES 
(NEWID(), 'Corsair HX1200', '1200W', '80+ Platinum', 250.00),
(NEWID(), 'Seasonic PRIME TX-1000', '1000W', '80+ Titanium', 300.00),
(NEWID(), 'EVGA SuperNOVA 850 G6', '850W', '80+ Gold', 150.00),
(NEWID(), 'be quiet! Straight Power 11 750W', '750W', '80+ Platinum', 180.00),
(NEWID(), 'Cooler Master MWE Gold 650', '650W', '80+ Gold', 100.00);
COMMIT TRANSACTION;
GO

-- 8. Додавання водяного охолодження (WaterCooling)
BEGIN TRANSACTION;
INSERT INTO WaterCooling (WaterCooling_ID, Title, TypeSize, HeatRemoval, Cost)
VALUES 
(NEWID(), 'Corsair iCUE H150i ELITE CAPELLIX', '360mm', 'High', 200.00),
(NEWID(), 'NZXT Kraken X73', '360mm', 'High', 180.00),
(NEWID(), 'Lian Li Galahad AIO 240', '240mm', 'Medium', 150.00),
(NEWID(), 'ARCTIC Liquid Freezer II 280', '280mm', 'High', 120.00),
(NEWID(), 'Cooler Master MasterLiquid ML240L', '240mm', 'Medium', 90.00);
COMMIT TRANSACTION;
GO

-- 9. Додавання вентиляторного охолодження (FanCooling)
BEGIN TRANSACTION;
INSERT INTO FanCooling (FanCooling_ID, Title, TypeSize, HeatRemoval, Cost)
VALUES 
(NEWID(), 'Noctua NH-D15', 'Dual Tower', 'High', 100.00),
(NEWID(), 'be quiet! Dark Rock Pro 4', 'Dual Tower', 'High', 90.00),
(NEWID(), 'Cooler Master Hyper 212', 'Single Tower', 'Medium', 50.00),
(NEWID(), 'Deepcool AK620', 'Dual Tower', 'High', 70.00),
(NEWID(), 'Scythe Fuma 2', 'Dual Tower', 'High', 60.00);
COMMIT TRANSACTION;
GO

-- 10. Додавання Wi-Fi модулів
BEGIN TRANSACTION;
INSERT INTO Wifi (Wifi_ID, Title, Generation, Cost)
VALUES 
(NEWID(), 'ASUS PCE-AX58BT', 'Wi-Fi 6', 80.00),
(NEWID(), 'TP-Link Archer TX50E', 'Wi-Fi 6', 60.00),
(NEWID(), 'Gigabyte GC-WBAX210', 'Wi-Fi 6E', 70.00),
(NEWID(), 'Intel AX200', 'Wi-Fi 6', 40.00),
(NEWID(), 'ASUS USB-AX56', 'Wi-Fi 6', 50.00);
COMMIT TRANSACTION;
GO

-- 11. Додавання Bluetooth модулів
BEGIN TRANSACTION;
INSERT INTO Bluetooth (Bluetooth_ID, Title, Generation, Cost)
VALUES 
(NEWID(), 'ASUS USB-BT500', '5.0', 30.00),
(NEWID(), 'TP-Link UB500', '5.0', 25.00),
(NEWID(), 'ASRock BLUETOOTH 5.2', '5.2', 35.00),
(NEWID(), 'Gigabyte GC-WBAX210 (Combo)', '5.2', 0.00),
(NEWID(), 'Intel AX210 (Combo)', '5.2', 0.00);
COMMIT TRANSACTION;
GO

-- 12. Додавання корпусів (Tower)
BEGIN TRANSACTION;
INSERT INTO Tower (Tower_ID, Title, TypeSize, FanType, FanIncluded, Cost)
VALUES 
(NEWID(), 'Lian Li PC-O11 Dynamic', 'Full Tower', '120mm', 'No', 150.00),
(NEWID(), 'Fractal Design Meshify C', 'Mid Tower', '120/140mm', '2x 120mm', 90.00),
(NEWID(), 'NZXT H510 Elite', 'Mid Tower', '120/140mm', '2x 140mm', 150.00),
(NEWID(), 'Corsair 4000D Airflow', 'Mid Tower', '120/140mm', '2x 120mm', 95.00),
(NEWID(), 'Cooler Master MasterBox Q300L', 'Micro ATX', '120mm', '1x 120mm', 50.00);
COMMIT TRANSACTION;
GO

PRINT 'Базу даних успішно наповнено тестовими даними (по 5 записів для кожної таблиці)';