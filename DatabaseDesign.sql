go
use QLDaiLy
create table DAILY(
	MaDaiLy varchar(100) not null primary key,
	TenDaiLy nvarchar(500) not null,
	MaLoaiDaiLy int not null,
	SDT varchar(50) not null,
	DiaChi nvarchar(100) not null,
	Quan nvarchar(50) not null,
	NgayTiepNhan date not null
)

create table PHIEUXUATHANG(
	MaXuatHang varchar(100) not null primary key,
	MaDaiLy varchar(100) not null,
	MaHang varchar(100) not null,
	TenMatHang nvarchar(500) not null,
	DonViTinh nvarchar(100) not null,
	SoLuong int not null,
	DonGia float not null,
	ThanhTien float not null,
	NgayLapPhieu date not null,
	TongTien float not null,
	SoTienTra float not null
)

create table LOAIDAILY(
	MaLoaiDaiLy int not null primary key,
	LoaiDaiLy int not null
)

create table PHIEUTHUTIEN(
	MaThuTien varchar(100) not null primary key,
	SoTienThu float not null,
	NgayThuTien date not null,
	TienConLai float not null
)

create table BAOCAOCONGNODAILY(
	MaBaoCao varchar(100) not null primary key,
	Thang int not null
)

create table PHIEUTHUTIENNO(
	MaPhieu varchar(100) not null primary key,
	MaDaiLy varchar(100) not null,
	MaThuTien varchar(100) not null,
	SoTienThu float not null,
	TienConLai float not null
)

create table CTPHIEUXUATHANG(
	MaCTPXH varchar(100) not null primary key,
	MaXuatHang varchar(100) not null,
	MaHang varchar(100) not null
)

create table CTPHIEUTHUTIEN(
	MaCTPTT varchar(100) not null primary key,
	MaThuTien varchar(100) not null,
	MaCTPXH varchar(100) not null,
	TongTien float not null
)

create table MATHANG(
	MaHang varchar(100) not null primary key,
	MaLoaiHang varchar(100) not null,
	TenMatHang nvarchar(500) not null,
	LoaiHang nvarchar(500) not null,
	DonViTinh nvarchar(100) not null,
	DonGia float not null
)

create table LOAIMATHANG(
	MaLoaiHang varchar(100) not null primary key,
	LoaiHang nvarchar(500) not null
)

create table CTBAOCAOCONGNODAILY(
	MaBaoCaoCongNo varchar(100) not null primary key,
	MaBaoCao varchar(100) not null,
	NoDau float not null,
	NoCuoi float not null,
	PhatSinh float not null,
	MaCTPXH varchar(100) not null
)

create table BAOCAODOANHSO(
	MaBCDS varchar(100) not null primary key,
	Thang int not null,
	SoPhieuXuat bigint not null,
	TongTriGia float not null
)

create table CTBAOCAODOANHSO(
	MaCTBCDS varchar(100) not null primary key,
	MaBCDS varchar(100) not null,
	MaLoaiHang varchar(100) not null,
	TriGia float not null,
	TiLe float not null
)

