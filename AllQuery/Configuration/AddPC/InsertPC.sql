-- Процедура додавання нового ПК із автоматичним підрахунком вартості
USE PC_constructor;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'InsertPC') AND type IN (N'P', N'PC'))
    DROP PROCEDURE InsertPC;
GO

CREATE PROCEDURE InsertPC
	@PC_ID CHAR(36),
	@CPU_ID CHAR(36),
	@GPU_ID CHAR(36),
	@Motherboard_ID CHAR(36),
	@RAM_ID CHAR(36),
	@HDD_ID CHAR(36),
	@SSD_ID CHAR(36),
	@PowerSupply_ID CHAR(36),
	@WaterCooling_ID CHAR(36),
	@FanCooling_ID CHAR(36),
	@Wifi_ID CHAR(36),
	@Bluetooth_ID CHAR(36),
	@Tower_ID CHAR(36),
	@ExecutionDate DATE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @TotalCost FLOAT;

	-- Підрахунок загальної вартості компонентів
	SELECT @TotalCost =
		ISNULL(cpu.Cost,0) + ISNULL(gpu.Cost,0) + ISNULL(mb.Cost,0) + ISNULL(ram.Cost,0) +
		ISNULL(hdd.Cost,0) + ISNULL(ssd.Cost,0) + ISNULL(ps.Cost,0) + ISNULL(wc.Cost,0) +
		ISNULL(fc.Cost,0) + ISNULL(wifi.Cost,0) + ISNULL(bt.Cost,0) + ISNULL(twr.Cost,0)
	FROM CPU cpu
	JOIN GPU gpu ON gpu.GPU_ID = @GPU_ID
	JOIN Motherboard mb ON mb.Motherboard_ID = @Motherboard_ID
	JOIN RAM ram ON ram.RAM_ID = @RAM_ID
	JOIN HDD hdd ON hdd.HDD_ID = @HDD_ID
	JOIN SSD ssd ON ssd.SSD_ID = @SSD_ID
	JOIN PowerSupply ps ON ps.PowerSupply_ID = @PowerSupply_ID
	JOIN WaterCooling wc ON wc.WaterCooling_ID = @WaterCooling_ID
	JOIN FanCooling fc ON fc.FanCooling_ID = @FanCooling_ID
	JOIN Wifi wifi ON wifi.Wifi_ID = @Wifi_ID
	JOIN Bluetooth bt ON bt.Bluetooth_ID = @Bluetooth_ID
	JOIN Tower twr ON twr.Tower_ID = @Tower_ID
	WHERE cpu.CPU_ID = @CPU_ID;

	-- Вставка нового ПК
	INSERT INTO PC (
		PC_ID, CPU_ID, GPU_ID, Motherboard_ID, RAM_ID, HDD_ID, SSD_ID,
		PowerSupply_ID, WaterCooling_ID, FanCooling_ID, Wifi_ID, Bluetooth_ID, Tower_ID,
		ExecutionDate, Cost)
	VALUES (
		@PC_ID, @CPU_ID, @GPU_ID, @Motherboard_ID, @RAM_ID, @HDD_ID, @SSD_ID,
		@PowerSupply_ID, @WaterCooling_ID, @FanCooling_ID, @Wifi_ID, @Bluetooth_ID, @Tower_ID,
		@ExecutionDate, @TotalCost)
END
GO

-- Тригер перевірки наявності компонентів перед вставкою
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'CheckPC_ComponentsNotNull')
    DROP TRIGGER CheckPC_ComponentsNotNull;
GO

CREATE TRIGGER CheckPC_ComponentsNotNull
ON PC
INSTEAD OF INSERT
AS
BEGIN
	SET NOCOUNT ON;

	-- Перевіряємо, чи всі компоненти існують
	IF NOT EXISTS (SELECT 1 FROM CPU WHERE CPU_ID IN (SELECT CPU_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM GPU WHERE GPU_ID IN (SELECT GPU_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM Motherboard WHERE Motherboard_ID IN (SELECT Motherboard_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM RAM WHERE RAM_ID IN (SELECT RAM_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM HDD WHERE HDD_ID IN (SELECT HDD_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM SSD WHERE SSD_ID IN (SELECT SSD_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM PowerSupply WHERE PowerSupply_ID IN (SELECT PowerSupply_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM WaterCooling WHERE WaterCooling_ID IN (SELECT WaterCooling_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM FanCooling WHERE FanCooling_ID IN (SELECT FanCooling_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM Wifi WHERE Wifi_ID IN (SELECT Wifi_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM Bluetooth WHERE Bluetooth_ID IN (SELECT Bluetooth_ID FROM inserted)) OR
	   NOT EXISTS (SELECT 1 FROM Tower WHERE Tower_ID IN (SELECT Tower_ID FROM inserted))
	BEGIN
		RAISERROR ('Один або більше компонентів не існують. Неможливо додати ПК.', 16, 1);
		ROLLBACK TRANSACTION;
	END
	ELSE
	BEGIN
		-- Якщо всі компоненти існують — дозволяємо вставку
		INSERT INTO PC
		SELECT * FROM inserted;
	END
END
GO

