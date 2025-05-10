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


-- Очищення таблиць перед додаванням нових даних (опціонально)
DELETE FROM Purchase;
DELETE FROM PC;
DELETE FROM Client;
DELETE FROM Specialist;
GO

-- Додавання тестових клієнтів з новими унікальними ID
INSERT INTO Client (Client_ID, ClientName, Phone, HomeAddress)
VALUES
    (NEWID(), 'Іван Петренко', '+380991234567', 'вул. Центральна, 10, кв. 5, Київ'),
    (NEWID(), 'Марія Сидорова', '+380672345678', 'вул. Шевченка, 25, Львів'),
    (NEWID(), 'Олександр Коваленко', '+380503456789', 'просп. Перемоги, 15, Харків'),
    (NEWID(), 'Наталія Іванченко', '+380634567890', 'вул. Гагаріна, 3, Одеса'),
    (NEWID(), 'Віктор Мельник', '+380955678901', 'вул. Садова, 7, Дніпро');
GO

-- Додавання тестових спеціалістів з новими унікальними ID
INSERT INTO Specialist (Specialist_ID, SpecialistName, Phone)
VALUES
    (NEWID(), 'Сергій Техніченко', '+380991112233'),
    (NEWID(), 'Ольга Комп''ютерова', '+380672223344'),
    (NEWID(), 'Михайло Процесоров', '+380503334455'),
    (NEWID(), 'Анна Відеокартова', '+380634445566'),
    (NEWID(), 'Павло Жорсткодисков', '+380955556677');
GO