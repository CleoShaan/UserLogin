Create database Modules;
use Modules;
create table tblModules(
[ModuleCode]int IDENTITY(1,1)NOT NULL PRIMARY KEY,
[ModuleName] varchar(255) NOT NULL,
[NumberCredits] varchar(255) NOT NULL,
[ClassHoursPerweek] varchar(255) NOT NULL,
Username varchar(255)NOT NULL,
);
create table tblUsers1(
Username varchar(255) not null,
[Password] varchar(255) not null
);
insert into tblUsers values('Jack','#######');
