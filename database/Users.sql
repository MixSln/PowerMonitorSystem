use master
go 

if DB_ID('PowerMonitor') is not null
	drop database PowerMonitor;
GO

create database PowerMonitor;
GO

use PowerMonitor
gO	

if OBJECT_ID('Users') is not null
	drop table dbo.Users;
	
create table dbo.Users(userid int
	,userName int
	,loginName int
	,passwd varchar(2000)
	,active char(1)
	constraint PK_users primary key(userId)
	);
	
if OBJECT_ID('Permission') is not null
	drop table dbo.Permission;

create table dbo.Permission(
	permId int
	,permDesc varchar(2000)
	,active char(1)
	,constraint PK_Permission primary key (permId)
	);
	
if OBJECT_ID('Roles') is not null
	drop table dbo.Roles
	
create table dbo.Roles(
	roleId int 
	,roleName varchar(200)
	,roleDesc varchar(2000)
	,active char(1)
	,constraint PK_Roles primary key (roleId)
	);
	
if OBJECT_ID('RolePermission') is not null
	drop table dbo.RolePermission;
	
create table dbo.RolePermission(
	roleId int
	,permId int
	,constraint FK_RolePermission_roleId_Role foreign key (roleId) references dbo.Roles(roleId)
	,constraint FK_RolePermission_permId_Perm foreign key(permId) references dbo.Permission(permId)
	);
	
if OBJECT_ID('UserRole') is not null
	drop table dbo.UserRole;
	
create table dbo.UserRole(
	userId int,
	roleId int
	,constraint FK_UserRole_userId_users foreign key(userId) references dbo.Users(userId)
	,constraint FK_UserRole_roleId_roles foreign key(roleId) references dbo.Roles(roleId)
	);
	
