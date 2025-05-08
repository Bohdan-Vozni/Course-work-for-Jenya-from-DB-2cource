IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'AdminDatabase')
    CREATE LOGIN AdminDatabase WITH PASSWORD = '1234';

USE PC_constructor;

IF EXISTS (SELECT name FROM sys.database_principals WHERE name = 'AdminDatabase')
    DROP USER AdminDatabase;

CREATE USER AdminDatabase FOR LOGIN AdminDatabase;

ALTER ROLE db_datareader ADD MEMBER AdminDatabase;
ALTER ROLE db_datawriter ADD MEMBER AdminDatabase;
Grant execute to AdminDatabase;




if not exists (select name from sys.server_principals where name  = 'Customer')
	create login Customer with password = '1234';


use PC_constructor;


if exists (select name from sys.database_principals where name = 'Customer')
   drop user Customer;


create user Customer from login Customer


alter role db_datareader add member Customer

