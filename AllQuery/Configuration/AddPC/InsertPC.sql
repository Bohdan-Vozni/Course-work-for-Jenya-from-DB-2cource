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
    @HDD_ID CHAR(36) = NULL,
    @SSD_ID CHAR(36) = NULL,
    @PowerSupply_ID CHAR(36),
    @WaterCooling_ID CHAR(36) = NULL,
    @FanCooling_ID CHAR(36) = NULL,
    @Wifi_ID CHAR(36),
    @Bluetooth_ID CHAR(36),
    @Tower_ID CHAR(36),
    @ExecutionDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Вставка нового ПК (тригер автоматично перевірить компоненти)
    INSERT INTO PC (
        PC_ID, CPU_ID, GPU_ID, Motherboard_ID, RAM_ID, 
        HDD_ID, SSD_ID, PowerSupply_ID, 
        WaterCooling_ID, FanCooling_ID, 
        Wifi_ID, Bluetooth_ID, Tower_ID, 
        ExecutionDate
    )
    VALUES (
        @PC_ID, @CPU_ID, @GPU_ID, @Motherboard_ID, @RAM_ID, 
        @HDD_ID, @SSD_ID, @PowerSupply_ID, 
        @WaterCooling_ID, @FanCooling_ID, 
        @Wifi_ID, @Bluetooth_ID, @Tower_ID, 
        @ExecutionDate
    );
END
GO



IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'PC_CheckComponentsAndCalculateCost')
    DROP TRIGGER PC_CheckComponentsAndCalculateCost;
GO

CREATE TRIGGER PC_CheckComponentsAndCalculateCost
ON PC
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        -- Перевірка обов'язкових компонентів
        IF EXISTS (
            SELECT 1 FROM inserted i
            WHERE i.CPU_ID IS NULL OR
                  i.GPU_ID IS NULL OR
                  i.Motherboard_ID IS NULL OR
                  i.RAM_ID IS NULL OR
                  i.PowerSupply_ID IS NULL OR
                  i.Wifi_ID IS NULL OR
                  i.Bluetooth_ID IS NULL OR
                  i.Tower_ID IS NULL
        )
        BEGIN
            RAISERROR('Не всі обов''язкові компоненти вказані', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
        
        -- Перевірка, що вказано хоча б один тип накопичувача
        IF EXISTS (
            SELECT 1 FROM inserted i
            WHERE i.HDD_ID IS NULL AND i.SSD_ID IS NULL
        )
        BEGIN
            RAISERROR('Потрібно вказати хоча б один тип накопичувача (HDD або SSD)', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
        
        -- Перевірка, що вказано хоча б один тип охолодження
        IF EXISTS (
            SELECT 1 FROM inserted i
            WHERE i.WaterCooling_ID IS NULL AND i.FanCooling_ID IS NULL
        )
        BEGIN
            RAISERROR('Потрібно вказати хоча б один тип охолодження (водяне або повітряне)', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
        
        -- Оновлення вартості для нових записів
        UPDATE pc
        SET pc.Cost = (
            SELECT ISNULL(cpu.Cost, 0) + ISNULL(gpu.Cost, 0) + ISNULL(mb.Cost, 0) + 
                   ISNULL(ram.Cost, 0) + ISNULL(hdd.Cost, 0) + ISNULL(ssd.Cost, 0) + 
                   ISNULL(ps.Cost, 0) + ISNULL(wc.Cost, 0) + ISNULL(fc.Cost, 0) + 
                   ISNULL(wifi.Cost, 0) + ISNULL(bt.Cost, 0) + ISNULL(twr.Cost, 0)
            FROM inserted i
            LEFT JOIN CPU cpu ON cpu.CPU_ID = i.CPU_ID
            LEFT JOIN GPU gpu ON gpu.GPU_ID = i.GPU_ID
            LEFT JOIN Motherboard mb ON mb.Motherboard_ID = i.Motherboard_ID
            LEFT JOIN RAM ram ON ram.RAM_ID = i.RAM_ID
            LEFT JOIN HDD hdd ON hdd.HDD_ID = i.HDD_ID
            LEFT JOIN SSD ssd ON ssd.SSD_ID = i.SSD_ID
            LEFT JOIN PowerSupply ps ON ps.PowerSupply_ID = i.PowerSupply_ID
            LEFT JOIN WaterCooling wc ON wc.WaterCooling_ID = i.WaterCooling_ID
            LEFT JOIN FanCooling fc ON fc.FanCooling_ID = i.FanCooling_ID
            LEFT JOIN Wifi wifi ON wifi.Wifi_ID = i.Wifi_ID
            LEFT JOIN Bluetooth bt ON bt.Bluetooth_ID = i.Bluetooth_ID
            LEFT JOIN Tower twr ON twr.Tower_ID = i.Tower_ID
            WHERE pc.PC_ID = i.PC_ID
        )
        FROM PC pc
        INNER JOIN inserted i ON pc.PC_ID = i.PC_ID;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        THROW;
    END CATCH
END
GO