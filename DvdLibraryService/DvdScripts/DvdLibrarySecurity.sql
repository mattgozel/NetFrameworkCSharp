use master
go

if exists (select name from master.sys.server_principals where name = 'DvdLibraryApp')

begin
drop login DvdLibraryApp
end

create login DvdLibraryApp with password='testing123'

use Dvds
go

if exists (select name from Dvds.sys.server_principals where name = 'DvdLibraryApp')

begin
drop user DvdLibraryApp
end

create user DvdLibraryApp for login DvdLibraryApp
go

if DATABASE_PRINCIPAL_ID('db_executor') is not null

begin
drop role db_executor
end

create role db_executor

grant execute to db_executor

alter role db_executor add member DvdLibraryApp
go

grant select on Dvd to DvdLibraryApp
grant insert on Dvd to DvdLibraryApp
grant update on Dvd to DvdLibraryApp
grant delete on Dvd to DvdLibraryApp
go