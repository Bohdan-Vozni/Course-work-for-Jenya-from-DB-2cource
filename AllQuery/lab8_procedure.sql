use PC_constructor
go


-- Процедура 1: Додати покупку (і автоматично порахувати вартість ПК)
CREATE PROCEDURE AddPurchase
	@Purchase_ID CHAR(36),
	@Specialist_ID CHAR(36),
	@Client_ID CHAR(36),
	@PC_ID CHAR(36),
	@DateCreate DATE
AS
BEGIN
	DECLARE @TotalCost FLOAT

	SELECT @TotalCost =
		ISNULL(cpu.Cost,0) + ISNULL(gpu.Cost,0) + ISNULL(mb.Cost,0) + ISNULL(ram.Cost,0) +
		ISNULL(hdd.Cost,0) + ISNULL(ssd.Cost,0) + ISNULL(ps.Cost,0) + ISNULL(wc.Cost,0) +
		ISNULL(fc.Cost,0) + ISNULL(wifi.Cost,0) + ISNULL(bt.Cost,0) + ISNULL(twr.Cost,0)
	FROM PC pc
	JOIN CPU cpu ON pc.CPU_ID = cpu.CPU_ID
	JOIN GPU gpu ON pc.GPU_ID = gpu.GPU_ID
	JOIN Motherboard mb ON pc.Motherboard_ID = mb.Motherboard_ID
	JOIN RAM ram ON pc.RAM_ID = ram.RAM_ID
	JOIN HDD hdd ON pc.HDD_ID = hdd.HDD_ID
	JOIN SSD ssd ON pc.SSD_ID = ssd.SSD_ID
	JOIN PowerSupply ps ON pc.PowerSupply_ID = ps.PowerSupply_ID
	JOIN WaterCooling wc ON pc.WaterCooling_ID = wc.WaterCooling_ID
	JOIN FanCooling fc ON pc.FanCooling_ID = fc.FanCooling_ID
	JOIN Wifi wifi ON pc.Wifi_ID = wifi.Wifi_ID
	JOIN Bluetooth bt ON pc.Bluetooth_ID = bt.Bluetooth_ID
	JOIN Tower twr ON pc.Tower_ID = twr.Tower_ID
	WHERE pc.PC_ID = @PC_ID

	UPDATE PC
	SET Cost = @TotalCost
	WHERE PC_ID = @PC_ID

	INSERT INTO Purchase(Purchase_ID, DateCreate, Specialist_ID, Client_ID, PC_ID)
	VALUES (@Purchase_ID, @DateCreate, @Specialist_ID, @Client_ID, @PC_ID)
END
GO

-- Процедура 2: Видалити клієнта разом із його покупками
CREATE PROCEDURE DeleteClientAndPurchases
	@Client_ID CHAR(36)
AS
BEGIN
	DELETE FROM Purchase WHERE Client_ID = @Client_ID
	DELETE FROM Client WHERE Client_ID = @Client_ID
END
GO

-- Тригер 1: Автооновлення вартості ПК при зміні ціни будь-якого компонента (на прикладі CPU)
CREATE TRIGGER UpdatePCCost_OnCPUUpdate
ON CPU
AFTER UPDATE
AS
BEGIN
	UPDATE pc
	SET Cost =
		ISNULL(cpu.Cost,0) + ISNULL(gpu.Cost,0) + ISNULL(mb.Cost,0) + ISNULL(ram.Cost,0) +
		ISNULL(hdd.Cost,0) + ISNULL(ssd.Cost,0) + ISNULL(ps.Cost,0) + ISNULL(wc.Cost,0) +
		ISNULL(fc.Cost,0) + ISNULL(wifi.Cost,0) + ISNULL(bt.Cost,0) + ISNULL(twr.Cost,0)
	FROM PC pc
	JOIN CPU cpu ON pc.CPU_ID = cpu.CPU_ID
	JOIN GPU gpu ON pc.GPU_ID = gpu.GPU_ID
	JOIN Motherboard mb ON pc.Motherboard_ID = mb.Motherboard_ID
	JOIN RAM ram ON pc.RAM_ID = ram.RAM_ID
	JOIN HDD hdd ON pc.HDD_ID = hdd.HDD_ID
	JOIN SSD ssd ON pc.SSD_ID = ssd.SSD_ID
	JOIN PowerSupply ps ON pc.PowerSupply_ID = ps.PowerSupply_ID
	JOIN WaterCooling wc ON pc.WaterCooling_ID = wc.WaterCooling_ID
	JOIN FanCooling fc ON pc.FanCooling_ID = fc.FanCooling_ID
	JOIN Wifi wifi ON pc.Wifi_ID = wifi.Wifi_ID
	JOIN Bluetooth bt ON pc.Bluetooth_ID = bt.Bluetooth_ID
	JOIN Tower twr ON pc.Tower_ID = twr.Tower_ID
	WHERE pc.CPU_ID IN (SELECT CPU_ID FROM inserted)
END
GO

-- Тригер 2: Заборонити видалення ПК, якщо є покупки
CREATE TRIGGER RestrictDeletePC_IfPurchaseExists
ON PC
INSTEAD OF DELETE
AS
BEGIN
	IF EXISTS (
		SELECT 1 FROM Purchase WHERE PC_ID IN (SELECT PC_ID FROM deleted)
	)
	BEGIN
		RAISERROR ('Неможливо видалити ПК, оскільки існують пов''язані покупки.', 16, 1)
		ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN
		DELETE FROM PC WHERE PC_ID IN (SELECT PC_ID FROM deleted)
	END
END
GO
