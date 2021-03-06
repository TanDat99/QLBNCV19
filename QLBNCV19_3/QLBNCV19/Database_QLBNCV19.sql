create Database QLBNCV19
go

use QLBNCV19
go

--Account
--BenhNhan
--BacSi
--KhamBenh
--KetQua

create table Account
(
	TaiKhoan nvarchar(100) primary key,
	MatKhau nvarchar(100),
)
go

create table BenhNhan
(	
	MaBN int identity(1,1) primary key,
	HoVaTen nvarchar(100) not null,
	NgaySinh date,
	DiaChi nvarchar(100),
	MoTa nvarchar(1000)
)
go

create table BacSi
(
	MaBS int identity(1,1) primary key,
	HoVaTenBS nvarchar(100)not null ,
	
)
go
create table KhamBenh
(
	ID int identity(1,1) primary key,
	MaBN int not null,
	HoVaTen nvarchar(100) not null,
	MaBS int not null,
	HoVaTenBS nvarchar(100) not null,
	TinhTrang nvarchar(100) not null
	foreign key (MaBN) references BenhNhan(MaBN),	
	foreign key (MaBS) references BacSi(MaBS)
)
go




set IDENTITY_INSERT BenhNhan on
insert BenhNhan (MaBN, HoVaTen, NgaySinh, DiaChi,MoTa)
Values(1,N'Nguyễn Văn A','1/1/1990',N'123,Bình Đa,Biên Hoà ,Đồng Nai',N'Đang điều trị')
insert BenhNhan (MaBN, HoVaTen, NgaySinh, DiaChi,MoTa)
Values(2,N'Nguyễn Văn B','2/2/1992',N'365,Tân Phong,Biên Hoà ,Đồng Nai',N'Xuất viện')
set IDENTITY_INSERT BenhNhan off
go

set IDENTITY_INSERT BacSi on
insert BacSi (MaBS, HoVaTenBS)
Values(1,N'Lê Văn C')
insert BacSi (MaBS, HoVaTenBS)
Values(2,N'Lê Văn D')
set IDENTITY_INSERT BacSi off
go

set IDENTITY_INSERT KhamBenh on
insert KhamBenh (ID, MaBN,HoVaTen, MaBS,HoVaTenBS, TinhTrang)
Values(1, 2,N'Nguyễn Văn B', 1,N'Lê Văn C', N'Âm Tính')
insert KhamBenh(ID, MaBN,HoVaTen, MaBS,HoVaTenBS, TinhTrang)
Values(2, 1,N'Nguyễn Văn A', 2,N'Lê Văn D', N'Dương Tính')
set IDENTITY_INSERT KhamBenh off
go


insert into Account (TaiKhoan, MatKhau)
values (N'Admin', N'Admin')
go
