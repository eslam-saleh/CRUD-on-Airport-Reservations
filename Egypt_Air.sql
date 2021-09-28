/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/1/2019 7:28:54 PM                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAG') and o.name = 'FK_BAG_RELATIONS_PASSENGE')
alter table BAG
   drop constraint FK_BAG_RELATIONS_PASSENGE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE_SHIFT') and o.name = 'FK_EMPLOYEE_WORKS_ON_STAFF')
alter table EMPLOYEE_SHIFT
   drop constraint FK_EMPLOYEE_WORKS_ON_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_FLY_ON_PLANE')
alter table FLIGHT
   drop constraint FK_FLIGHT_FLY_ON_PLANE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PASSENGER') and o.name = 'FK_PASSENGE_TRAVEL_ON_FLIGHT')
alter table PASSENGER
   drop constraint FK_PASSENGE_TRAVEL_ON_FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PLANE') and o.name = 'FK_PLANE_LAN_ON_AIRPORT')
alter table PLANE
   drop constraint FK_PLANE_LAN_ON_AIRPORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVE') and o.name = 'FK_RESERVE_RESERVE_PLANE')
alter table RESERVE
   drop constraint FK_RESERVE_RESERVE_PLANE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVE') and o.name = 'FK_RESERVE_RESERVE2_PASSENGE')
alter table RESERVE
   drop constraint FK_RESERVE_RESERVE2_PASSENGE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STAFF') and o.name = 'FK_STAFF_INCLUDES_AIRPORT')
alter table STAFF
   drop constraint FK_STAFF_INCLUDES_AIRPORT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRPORT')
            and   type = 'U')
   drop table AIRPORT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BAG')
            and   name  = 'RELATIONSHIP_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index BAG.RELATIONSHIP_11_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BAG')
            and   type = 'U')
   drop table BAG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE_SHIFT')
            and   name  = 'WORKS_ON_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE_SHIFT.WORKS_ON_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE_SHIFT')
            and   type = 'U')
   drop table EMPLOYEE_SHIFT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHT')
            and   name  = 'FLY_ON_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHT.FLY_ON_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLIGHT')
            and   type = 'U')
   drop table FLIGHT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PASSENGER')
            and   name  = 'TRAVEL_ON_FK'
            and   indid > 0
            and   indid < 255)
   drop index PASSENGER.TRAVEL_ON_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PASSENGER')
            and   type = 'U')
   drop table PASSENGER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PLANE')
            and   name  = 'LAN_ON_FK'
            and   indid > 0
            and   indid < 255)
   drop index PLANE.LAN_ON_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PLANE')
            and   type = 'U')
   drop table PLANE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RESERVE')
            and   name  = 'RESERVE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RESERVE.RESERVE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RESERVE')
            and   name  = 'RESERVE_FK'
            and   indid > 0
            and   indid < 255)
   drop index RESERVE.RESERVE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RESERVE')
            and   type = 'U')
   drop table RESERVE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STAFF')
            and   name  = 'INCLUDES_FK'
            and   indid > 0
            and   indid < 255)
   drop index STAFF.INCLUDES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STAFF')
            and   type = 'U')
   drop table STAFF
go

/*==============================================================*/
/* Table: AIRPORT                                               */
/*==============================================================*/
create table AIRPORT (
   ADDRESS              varchar(30)          not null,
   CITY                 varchar(10)          null,
   COUNTRY              varchar(15)          null,
   TYPE                 varchar(20)          null,	--
   constraint PK_AIRPORT primary key nonclustered (ADDRESS)
)
go

/*==============================================================*/
/* Table: BAG                                                   */
/*==============================================================*/
create table BAG (
   PASSPORT_ID          int                  not null,
   BAGS_NO              smallint             null,
   CUSTOMS              numeric(8,2)         null,
   WEIGHT               smallint             null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_11_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_11_FK on BAG (
PASSPORT_ID ASC
)
go

/*==============================================================*/
/* Table: EMPLOYEE_SHIFT                                        */
/*==============================================================*/
create table EMPLOYEE_SHIFT (
   DATE                 varchar(10)          not null,
   EMP_ID               int			         not null,
   SSN                  int			         not null,
   constraint PK_EMPLOYEE_SHIFT primary key nonclustered (DATE, EMP_ID)
)
go

/*==============================================================*/
/* Index: WORKS_ON_FK                                           */
/*==============================================================*/
create index WORKS_ON_FK on EMPLOYEE_SHIFT (
SSN ASC
)
go

/*==============================================================*/
/* Table: FLIGHT                                                */
/*==============================================================*/
create table FLIGHT (
   FLIGHT_NO            smallint             not null,
   MODEL_NO             varchar(10)          not null,
   _From                varchar(15)          null,
   _To                  varchar(15)          null,
   _Time				varchar(15)			 null,
   IS_STOP              bit		             null,
   constraint PK_FLIGHT primary key nonclustered (FLIGHT_NO)
)
go

/*==============================================================*/
/* Index: FLY_ON_FK                                             */
/*==============================================================*/
create index FLY_ON_FK on FLIGHT (
MODEL_NO ASC
)
go

/*==============================================================*/
/* Table: PASSENGER                                             */
/*==============================================================*/
create table PASSENGER (
   PASSPORT_ID          int                  not null,
   FLIGHT_NO            smallint             not null,
   SOURCE               varchar(20)          null,	--
   DESTINATION          varchar(20)          null,	--
   FIRST_NAME           varchar(15)          null,	--
   SEX                  varchar(6)           null,
   PHONE                int                  null,	--
   constraint PK_PASSENGER primary key nonclustered (PASSPORT_ID)
)
go

/*==============================================================*/
/* Index: TRAVEL_ON_FK                                          */
/*==============================================================*/
create index TRAVEL_ON_FK on PASSENGER (
FLIGHT_NO ASC
)
go

/*==============================================================*/
/* Table: PLANE                                                 */
/*==============================================================*/
create table PLANE (
   MODEL_NO             varchar(10)          not null,
   ADDRESS              varchar(30)          not null,
   AVAILABLE_SEATS      smallint             null,	--
   COMPANY              varchar(15)          null,	--
   TYPE_NAME            varchar(20)          null,
   SPEED                varchar(10)          null,
   constraint PK_PLANE primary key nonclustered (MODEL_NO)
)
go

/*==============================================================*/
/* Index: LAN_ON_FK                                             */
/*==============================================================*/
create index LAN_ON_FK on PLANE (
ADDRESS ASC
)
go

/*==============================================================*/
/* Table: RESERVE                                               */
/*==============================================================*/
create table RESERVE (
   MODEL_NO             varchar(10)           not null,
   PASSPORT_ID          int                   not null,
   constraint PK_RESERVE primary key (MODEL_NO, PASSPORT_ID)
)
go

/*==============================================================*/
/* Index: RESERVE_FK                                            */
/*==============================================================*/
create index RESERVE_FK on RESERVE (
MODEL_NO ASC
)
go

/*==============================================================*/
/* Index: RESERVE2_FK                                           */
/*==============================================================*/
create index RESERVE2_FK on RESERVE (
PASSPORT_ID ASC
)
go

/*==============================================================*/
/* Table: STAFF                                                 */
/*==============================================================*/
create table STAFF (
   SSN                  int					  not null,
   ADDRESS              varchar(30)           not null,
   YEARS_WORK           int					  null,		--
   SALARY               int					  null,		--
   HOME_TWON            varchar(10)           null,
   FIRST_NAME           varchar(15)           null,		--
   POSITION             varchar(20)           null,
   constraint PK_STAFF primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Index: INCLUDES_FK                                           */
/*==============================================================*/
create index INCLUDES_FK on STAFF (
ADDRESS ASC
)
go

alter table BAG
   add constraint FK_BAG_RELATIONS_PASSENGE foreign key (PASSPORT_ID)
      references PASSENGER (PASSPORT_ID)
go

alter table EMPLOYEE_SHIFT
   add constraint FK_EMPLOYEE_WORKS_ON_STAFF foreign key (SSN)
      references STAFF (SSN)
go

alter table FLIGHT
   add constraint FK_FLIGHT_FLY_ON_PLANE foreign key (MODEL_NO)
      references PLANE (MODEL_NO)
go

alter table PASSENGER
   add constraint FK_PASSENGE_TRAVEL_ON_FLIGHT foreign key (FLIGHT_NO)
      references FLIGHT (FLIGHT_NO)
go

alter table PLANE
   add constraint FK_PLANE_LAN_ON_AIRPORT foreign key (ADDRESS)
      references AIRPORT (ADDRESS)
go

alter table RESERVE
   add constraint FK_RESERVE_RESERVE_PLANE foreign key (MODEL_NO)
      references PLANE (MODEL_NO)
go

alter table RESERVE
   add constraint FK_RESERVE_RESERVE2_PASSENGE foreign key (PASSPORT_ID)
      references PASSENGER (PASSPORT_ID)
go

alter table STAFF
   add constraint FK_STAFF_INCLUDES_AIRPORT foreign key (ADDRESS)
      references AIRPORT (ADDRESS)
go



insert into AIRPORT VALUES ('1-123 street-El Nozha','Egypt','Cairo','Global');
Insert into Plane Values( '94564576','1-123 street-El Nozha','170','ABC','Jumbo','800');
insert into Flight VALUES ('13','94564576','A','B','5:00 am',0);
insert into Passenger VALUES ('20170','13','A','B',' Eslam','Male','01234567890');
insert into Bag VALUES ('20170','6','600','150');
insert into Staff VALUES ('1701','1-123 street-El Nozha','3','5300',' Mansora',' Jack','Offiecer');
insert into Employee_Shift VALUES ('12:00 pm','1701','1701');

---------------------------------------------------------------------------------------------

insert into AIRPORT VALUES ('2-234 street-Sphinx','Egypt','Giza','Local');
Insert into Plane Values( '98657479','2-234 street-Sphinx','80','DEF',' Douglas DC-3','1000');
insert into Flight VALUES ('14','98657479','B','C','7:00 am',1);
insert into Passenger VALUES ('20171','14','B','C',' Saleh','Male','01143654765');
insert into Bag VALUES ('20171','5','500','130');
insert into Staff VALUES ('1702','2-234 street-Sphinx','9','4000',' Helwan',' Emilia','Hostess');
insert into Employee_Shift VALUES ('2:00 pm','1702','1702');

---------------------------------------------------------------------------------------------

insert into AIRPORT VALUES ('3-345 street-Borg El Arab','Egypt','Alex','Global');
Insert into Plane Values( '93547878','3-345 street-Borg El Arab','115','GHI',' de Havilland Comet','1020');
insert into Flight VALUES ('15','93547878','C','D','9:00 am',0);
insert into Passenger VALUES ('20172','15','X','Y',' Hatem','Male','01043264577');
insert into Bag VALUES ('20172','4','400','110');
insert into Staff VALUES ('1703','3-345 street-Borg El Arab','14','8000',' Sharqia',' Mohsen','Engineer');
insert into Employee_Shift VALUES ('4:00 pm','1703','1703');

---------------------------------------------------------------------------------------------

insert into AIRPORT VALUES ('456','Egypt','Sharm El Shiekh','Local');
Insert into Plane Values( '99622349','456','140','JKL','United Airlines DC-6','2000');
insert into Flight VALUES ('16','99622349','D','E','11:00 am',1);
insert into Passenger VALUES ('20173','16','Y','Z',' Sayed','Male','01143654768');
insert into Bag VALUES ('20173','3','300','90');
insert into Staff VALUES ('1704','456','40','99999999',' Cairo',' Mohanned','Pilot');
insert into Employee_Shift VALUES ('6:00 pm','1704','1704');

---------------------------------------------------------------------------------------------

insert into AIRPORT VALUES ('5-567 street-Bny Mazar','Egypt','Minia','Local');
Insert into Plane Values( '91627568','5-567 street-Bny Mazar','100','MNO','Boeing 747','3500');
insert into Flight VALUES ('17','91627568','E','F','1:00 pm',0);
insert into Passenger VALUES ('20174','17','I','J',' Ahmed','Male','01243654765');
insert into Bag VALUES ('20174','2','200','70');
insert into Staff VALUES ('1705','5-567 street-Bny Mazar','35','15000',' Assuit',' Samir','Pilot');
insert into Employee_Shift VALUES ('8:00 pm','1705','1705');


