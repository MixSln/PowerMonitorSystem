if OBJECT_ID('distribution') is not null
	drop table dbo.distribution;
	
create table distribution(
	distId int
	,distName varchar(200)
	,distDesc nvarchar(2000)
	,contact nvarchar(200)
	,phoneNumber nvarchar(200)
	,constraint PK_distribution primary key(distId)
	);
	
if OBJECT_ID('device') is not null
	drop table dbo.device;
	
create table dbo.device(
	devId int
	,devName nvarchar(200)
	,addressCode nvarchar(200)
	,current_max decimal(5,2)
	,current_warning decimal(5,2)
	,voltage_warning_high decimal(10,2)
	,voltage_warning_low decimal(10,2)
	,devStatus char(1)
	,constraint PK_device primary key(devId)
	,constraint Unique_devName UNIQUE(devName)
	,constraint Unique_addresscode unique(addressCode)
	);
	
if OBJECT_ID('distDevice') is not null
	drop table dbo.distDevice;

create table dbo.distDevice(
	distId int
	,devId int
	,active char(1) default('A')
	,constraint FK_distDevice_distId Foreign key(distId) references dbo.distribution(distId)
	,constraint FK_distDevice_devId foreign key(devId) references dbo.device(devId)
	);
	
if OBJECT_ID('deviceMonitor') is not null
	drop table dbo.deviceMonitor;
	
create table dbo.deviceMonitor(
	statusDate datetime
	,devId int
	,voltage_A int
	,voltage_B int
	,voltage_C int
	,voltage_AB int
	,voltage_CA int
	,voltage_BC int
	,current_A int
	,current_B int
	,current_C int
	,realPower_A int
	,realPower_B int
	,realPower_C int
	,realPower_total int
	,reactivePower_A int
	,reactivePower_B int
	,reactivePower_C int
	,reactivePower_total int
	,apparentPower_total int
	,powerFactor decimal(3,2)
	,frequency decimal(3,2)
	,activePowerEnergy_pos decimal(10,2)
	,activePowerEnergy_neg decimal(10,2)
	,reactivePowerEnergy_pos decimal(10,2)
	,reactivePowerEnergy_neg decimal(10,2)
	,switchValue int
	);
	
alter table dbo.Users add maxDevices int
	
