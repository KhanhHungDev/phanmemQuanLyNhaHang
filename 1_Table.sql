
create database QL_NhaHang
go
use QL_NhaHang
go
create table NHANVIEN
(
	MANV		char(10) 	not null primary key,
	TENNV		nvarchar(30)	not null,
	TENDANGNHAP	nvarchar(256)	not null,
	NGAYSINH	datetime	not null,
	PHAI		nchar(10)	not null,
	DIACHI		nvarchar(50)	not null,
	DIENTHOAI	nvarchar(10)	null,
	SO_HD_THUCHIEN	int		null,
	NGAYDANGNHAP	datetime	null,
	SOLANDN		int		null,
	QUYENHAN	nvarchar(20)	not null
)
go
create table KHACHHANG
(
	MsKH		char(10) primary key 	not null,
	TENKH		nvarchar(30)		not null,
	PHAI		nchar(10)		null,
	DIACHI		nvarchar(50)		not null,
	DIENTHOAI	varchar(10)		null
)
go
create table MONAN
(
	MAMON		char(10)primary key	not null,
	TENMON		nvarchar(50)		not null,
	SL		int,
	DONGIA		float,
	DONVITINH	nchar(10)
)
go
create table HOADON
(
	MSHD		char(15) primary key	not null,
	MANV		char(10)		not null,
	MSKH		char(10)		not null,
	NGAYHD		datetime		not null,
	TONGTIEN	float			null
	constraint	FK_HD_NV foreign key(MANV) references NHANVIEN(MANV),
	constraint	FK_HD_KH foreign key(MSKH) references KHACHHANG(MSKH)
)
go
create table CHITIET_HD
(
	MSHD		char(15)		not null,
	MAMON		char(10)		not null,
	SOLUONG		int			null,
	THANHTIEN	money			null
	constraint PK_CTHD primary key(MSHD,MAMON),
	constraint	FK_CT_MH foreign key(MAMON) references MONAN(MAMON),
	constraint	FK_CT_HD foreign key(MSHD) references HOADON(MSHD)
)
drop database QL_NhaHang
go