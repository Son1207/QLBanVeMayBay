/*==============================================================*/
/* Table: CHITIETCHUYENBAY                                      */
/*==============================================================*/

create database QL_BanVeMB
create table CHITIETCHUYENBAY (
   MACHITIETCHUYENBAY   char(10)             not null,
   SANBAYTRUNGGIAN      char(10)             null,
   MACHUYENBAY          char(10)             null,
   THOIGIANDUNG         tinyint              null,
   GHICHU               char(50)             null,
   constraint PK_CHITIETCHUYENBAY primary key (MACHITIETCHUYENBAY)
)
go

/*==============================================================*/
/* Table: CHUYENBAY                                             */
/*==============================================================*/
create table CHUYENBAY (
   MACHUYENBAY          char(10)             not null,
   MATUYENBAY           char(10)             null,
   THOIGIANBAY          datetime             null,
   SLGHEHANG1           int                  null,
   SLGHEHANG2           int                  null,
   SLGHETRONG           int                  null,
   SLGHEDAT             int                  null,
   constraint PK_CHUYENBAY primary key (MACHUYENBAY)
)
go

/*==============================================================*/
/* Table: CT_DOANHTHUTHANG                                      */
/*==============================================================*/
create table CT_DOANHTHUTHANG (
   MACTDOANHTHUTHANG    char(10)             not null,
   MACHUYENBAY          char(10)             null,
   MADOANHTHUTHANG      char(10)             null,
   SOVE                 int                  null,
   DOANHTHU             float                null,
   constraint PK_CT_DOANHTHUTHANG primary key (MACTDOANHTHUTHANG)
)
go

/*==============================================================*/
/* Table: DOANHTHUNAM                                           */
/*==============================================================*/
create table DOANHTHUNAM (
   MADOANHTHUNAM        char(10)             not null,
   NAM                  datetime             null,
   TONGDOANHTHUNAM      float                null,
   TILE                 int                  null,
   constraint PK_DOANHTHUNAM primary key (MADOANHTHUNAM)
)
go

/*==============================================================*/
/* Table: DOANHTHUTHANG                                         */
/*==============================================================*/
create table DOANHTHUTHANG (
   MADOANHTHUTHANG      char(10)             not null,
   MADOANHTHUNAM        char(10)             null,
   SLVETHANG            int                  null,
   TONGDOANHTHUTHANG    float                null,
   TILE                 int                  null,
   constraint PK_DOANHTHUTHANG primary key (MADOANHTHUTHANG)
)
go

/*==============================================================*/
/* Table: DONGIA                                                */
/*==============================================================*/
create table DONGIA (
   MADONGIA             char(10)             not null,
   MATUYENBAY           char(10)             null,
   MAHANGVE             char(10)             null,
   GIATIEN              float                null,
   constraint PK_DONGIA primary key (MADONGIA)
)
go

/*==============================================================*/
/* Table: HANGVE                                                */
/*==============================================================*/
create table HANGVE (
   MAHANGVE             char(10)             not null,
   TENHANGVE            nvarchar(30)         null,
   constraint PK_HANGVE primary key (MAHANGVE)
)
go
/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG (
   ID_KH                int                  not null,
   MAKHACHHANG          char(10)             null,
   TENKH                nvarchar(30)         null,
   CMND                 char(10)             null,
   DIENTHOAI            char(11)             null,
   
   constraint PK_KHACHHANG primary key (ID_KH)
)
go

/*==============================================================*/
/* Table: PHIEUDATCHO                                           */
/*==============================================================*/
create table PHIEUDATCHO (
   MAPHIEUDATCHO        char(10)             not null,
   MAHANGVE             char(10)             null,
   ID_KH                int                  null,
   MACHUYENBAY          char(10)             null,
   GIATIEN              float                null,
   NGAYDAT              datetime             null,
   constraint PK_PHIEUDATCHO primary key (MAPHIEUDATCHO)
)
go

/*==============================================================*/
/* Table: SANBAY                                                */
/*==============================================================*/
create table SANBAY (
   MASANBAY             char(10)             not null,
   TENSANBAY            char(30)             null,
   constraint PK_SANBAY primary key (MASANBAY)
)
go

/*==============================================================*/
/* Table: TUYENBAY                                              */
/*==============================================================*/
create table TUYENBAY (
   MATUYENBAY           char(10)             not null,
   SANBAYDI             nvarchar(20)             null,
   SANBAYDEN            nvarchar(20)             null,
   constraint PK_TUYENBAY primary key (MATUYENBAY)
)
go
ALTER TABLE TUYENBAY
ALTER COLUMN SANBAYDEN nvarchar(30)
/*==============================================================*/
/* Table: VECHUYENBAY                                           */
/*==============================================================*/
create table VECHUYENBAY (
   MAVECHUYENBAY        char(10)             not null,
   MACHUYENBAY          char(10)             null,
   ID_KH                char(10)             null,
   MAVITRIGHE           char(10)             null,
   MAHANGVE             char(10)             null,
   constraint PK_VECHUYENBAY primary key (MAVECHUYENBAY)
)
go


/*==============================================================*/
/* Table: VITRIGHE                                              */
/*==============================================================*/
create table VITRIGHE (
   MAVITRIGHE           char(10)             not null,
   TINHTRANGGHE         char(30)             null,
   constraint PK_VITRIGHE primary key (MAVITRIGHE)
)
go

alter table CHITIETCHUYENBAY
   add constraint FK_CHITIETC_RELATIONS_CHUYENBA foreign key (MACHUYENBAY)
      references CHUYENBAY (MACHUYENBAY)
go

alter table CHITIETCHUYENBAY
   add constraint FK_CHITIETC_RELATIONS_SANBAY foreign key (SANBAYTRUNGGIAN)
      references SANBAY (MASANBAY)
go

alter table CHUYENBAY
   add constraint FK_CHUYENBA_RELATIONS_TUYENBAY foreign key (MATUYENBAY)
      references TUYENBAY (MATUYENBAY)
go

alter table CT_DOANHTHUTHANG
   add constraint FK_CT_DOANH_RELATIONS_DOANHTHU foreign key (MADOANHTHUTHANG)
      references DOANHTHUTHANG (MADOANHTHUTHANG)
go

alter table CT_DOANHTHUTHANG
   add constraint FK_CT_DOANH_RELATIONS_CHUYENBA foreign key (MACHUYENBAY)
      references CHUYENBAY (MACHUYENBAY)
go

alter table DOANHTHUTHANG
   add constraint FK_DOANHTHU_RELATIONS_DOANHTHU foreign key (MADOANHTHUNAM)
      references DOANHTHUNAM (MADOANHTHUNAM)
go

alter table DONGIA
   add constraint FK_DONGIA_RELATIONS_TUYENBAY foreign key (MATUYENBAY)
      references TUYENBAY (MATUYENBAY)
go

alter table DONGIA
   add constraint FK_DONGIA_RELATIONS_HANGVE foreign key (MAHANGVE)
      references HANGVE (MAHANGVE)
go

alter table PHIEUDATCHO
   add constraint FK_PHIEUDAT_RELATIONS_KHACHHAN foreign key (ID_KH)
      references KHACHHANG (ID_KH)
go

alter table PHIEUDATCHO
   add constraint FK_PHIEUDAT_RELATIONS_HANGVE foreign key (MAHANGVE)
      references HANGVE (MAHANGVE)
go

alter table PHIEUDATCHO
   add constraint FK_PHIEUDAT_RELATIONS_CHUYENBA foreign key (MACHUYENBAY)
      references CHUYENBAY (MACHUYENBAY)
go

alter table TUYENBAY
   add constraint FK_TUYENBAY_RELATIONS_SANBAY foreign key (SANBAYDI)
      references SANBAY (MASANBAY)
go

alter table VECHUYENBAY
   add constraint FK_VECHUYEN_RELATIONS_HANGVE foreign key (MAHANGVE)
      references HANGVE (MAHANGVE)
go

alter table VECHUYENBAY
   add constraint FK_VECHUYEN_RELATIONS_KHACHHAN foreign key (ID_KH)
      references KHACHHANG (ID_KH)
go

alter table VECHUYENBAY
   add constraint FK_VECHUYEN_RELATIONS_CHUYENBA foreign key (MACHUYENBAY)
      references CHUYENBAY (MACHUYENBAY)
go

alter table VECHUYENBAY
   add constraint FK_VECHUYEN_RELATIONS_VITRIGHE foreign key (MAVITRIGHE)
      references VITRIGHE (MAVITRIGHE)
go
--insert KHACHHANG
Insert into KHACHHANG values ('KH06',N'Nguyễn Văn An','213654873',0435421577)
Insert into KHACHHANG values ('KH07',N'Nguyễn Thị Thúy Tình','212983901',0934638665)
Insert into KHACHHANG values ('KH08',N'Trần Nam','211453522',0345876999)

create table TAIKHOAN(
   TENTAIKHOAN           nvarchar(30)             not null,
   TENHIENTHI            nvarchar(30)             null,
   PASSWORDS             varchar(20)              null,
   constraint PK_TAIKHOAN primary key (TENTAIKHOAN)
)
go
Insert into TAIKHOAN values ('2K4',N'Nam2k4',123456)
Insert into TAIKHOAN values ('An',N'AnNguyen',000000)
Insert into TAIKHOAN values ('tan0123',N'Tấn Tấn',12072002)
--
Insert into PHIEUDATCHO values('P01','HV01','KH06','CB01','2000000',2021-11-20)
--Insert bảng DOANHTHUTHANG
Insert into DOANHTHUTHANG values('TH01','DTN2020','4765','16900000',2)
Insert into DOANHTHUTHANG values('TH02','DTN2020','5000','16900000',1.1)
Insert into DOANHTHUTHANG values('TH03','DTN2020','3678','13000000',2)
Insert into DOANHTHUTHANG values('TH04','DTN2020','7665','31900000',1.9)
Insert into DOANHTHUTHANG values('TH05','DTN2020','5765','23900000',2)
Insert into DOANHTHUTHANG values('TH06','DTN2020','5500','19900000',2)
Insert into DOANHTHUTHANG values('TH07','DTN2020','5665','21300000',1.1)
Insert into DOANHTHUTHANG values('TH08','DTN2020','3004','11900000',1)
Insert into DOANHTHUTHANG values('TH09','DTN2020','3844','14900000',1.2)
Insert into DOANHTHUTHANG values('TH10','DTN2020','2646','10200000',2)
Insert into DOANHTHUTHANG values('TH11','DTN2020','4347','20900000',2)
Insert into DOANHTHUTHANG values('TH12','DTN2020','4637','23900000',1.2)

ALTER TABLE CHUYENBAY
DROP COLUMN NGAYGIO
--Insert bảng TUYENBAY
Insert into TUYENBAY values('T01',N'Hồ Chí Minh',N'Hà Nội')
Insert into TUYENBAY values('T02',N'Hồ Chí Minh',N'Hải Phòng')
Insert into TUYENBAY values('T03',N'Hồ Chí Minh',N'Đà Nẳng')
Insert into TUYENBAY values('T04',N'Đà NẲng',N'Hồ Chí Minh')

select * from TUYENBAY;
UPDATE TUYENBAY SET SANBAYDI = N'Đà Nẳng' , SANBAYDEN = N'Hồ Chí Minh'
WHERE MATUYENBAY='T04';
--insert bang CHUYENBAY
Insert into CHUYENBAY values('CB01','T02','2021-11-09 08:30:00','30','50','3','47')
Insert into CHUYENBAY values('CB02','T04','2021-11-15 16:00:00','40','50','13','77')
Insert into CHUYENBAY values('CB03','T01','2021-12-11 07:30:00','30','60','17','73')
Insert into CHUYENBAY values('CB04','T02','2021-11-21 09:00:00','30','50','21','69')
--Insert bang DOANHTHUNAM
Insert into DOANHTHUNAM values ('DTN2020','2020','139000000',2)
--Insert bang HANGVE
Insert into HANGVE values('HV01',N'Hạng thương gia')
Insert into HANGVE values('HV02',N'Hạng phổ thông')
--insert bảng PHIEUDATCHO
insert into PHIEUDATCHO values('P01','HV02','KH06','CB01','2000000','2021-11-20 20:09:57')
insert into PHIEUDATCHO values('P02','HV02','KH07','CB03','1900000','2021-10-09 08:19:54')
insert into PHIEUDATCHO values('P03','HV01','KH08','CB02','1000000','2021-09-28 15:44:13')

select * from KHACHHANG;

