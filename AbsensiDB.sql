-- Script Date: 10/01/2026 18:36  - ErikEJ.SqlCeScripting version 3.5.2.103
-- Database information:
-- Database: C:\Users\andre\OneDrive\Dokumen\Kuliah SMT 5\Pemograman Visual\Absensi Karyawan\AbsensiApp\bin\Debug\net9.0-windows\AbsensiDB.sqlite
-- ServerVersion: 3.46.1
-- DatabaseSize: 52 KB
-- Created: 10/12/2025 00:54

-- User Table information:
-- Number of tables: 8
-- tblAbsensi: -1 row(s)
-- tblDepartemen: -1 row(s)
-- tblHariLibur: -1 row(s)
-- tblIzinCuti: -1 row(s)
-- tblJabatan: -1 row(s)
-- tblKaryawan: -1 row(s)
-- tblShift: -1 row(s)
-- tblUser: -1 row(s)

SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [tblShift] (
  [IDShift] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [NamaShift] text NOT NULL
, [JamMasuk] text NOT NULL
, [JamPulang] text NOT NULL
, [ToleransiTelatMenit] bigint DEFAULT (0) NULL
);
CREATE TABLE [tblJabatan] (
  [IDJabatan] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [NamaJabatan] text NOT NULL
);
CREATE TABLE [tblHariLibur] (
  [IDLibur] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Tanggal] text NOT NULL
, [Keterangan] text NULL
);
CREATE TABLE [tblDepartemen] (
  [IDDepartemen] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [NamaDepartemen] text NOT NULL
);
CREATE TABLE [tblKaryawan] (
  [KaryawanID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [NIK] text NOT NULL
, [Nama] text NOT NULL
, [JenisKelamin] text NULL
, [TanggalLahir] text NULL
, [IDDepartemen] bigint NULL
, [IDJabatan] bigint NULL
, [TanggalMasuk] text NOT NULL
, [Status] text NULL
, [Alamat] text NULL
, [NoHP] text NULL
, CONSTRAINT [FK_tblKaryawan_0_0] FOREIGN KEY ([IDJabatan]) REFERENCES [tblJabatan] ([IDJabatan]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_tblKaryawan_1_0] FOREIGN KEY ([IDDepartemen]) REFERENCES [tblDepartemen] ([IDDepartemen]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [tblUser] (
  [UserID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Username] text NOT NULL
, [PasswordHash] text NOT NULL
, [Role] text NOT NULL
, [KaryawanID] bigint NULL
, CONSTRAINT [FK_tblUser_0_0] FOREIGN KEY ([KaryawanID]) REFERENCES [tblKaryawan] ([KaryawanID]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [tblIzinCuti] (
  [IDIzin] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [KaryawanID] bigint NULL
, [TanggalMulai] text NOT NULL
, [TanggalSelesai] text NOT NULL
, [Jenis] text NULL
, [Alasan] text NULL
, [StatusPersetujuan] text NULL
, [TanggalPengajuan] text DEFAULT (CURRENT_TIMESTAMP) NULL
, [TanggalPersetujuan] text NULL
, [DisetujuiOleh] bigint NULL
, CONSTRAINT [FK_tblIzinCuti_0_0] FOREIGN KEY ([DisetujuiOleh]) REFERENCES [tblUser] ([UserID]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_tblIzinCuti_1_0] FOREIGN KEY ([KaryawanID]) REFERENCES [tblKaryawan] ([KaryawanID]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [tblAbsensi] (
  [IDAbsensi] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Tanggal] text NOT NULL
, [KaryawanID] bigint NULL
, [IDShift] bigint NULL
, [JamMasuk] text NULL
, [JamPulang] text NULL
, [Status] text NULL
, [TelatMenit] bigint DEFAULT (0) NULL
, [LemburMenit] bigint DEFAULT (0) NULL
, [Keterangan] text NULL
, CONSTRAINT [FK_tblAbsensi_0_0] FOREIGN KEY ([IDShift]) REFERENCES [tblShift] ([IDShift]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_tblAbsensi_1_0] FOREIGN KEY ([KaryawanID]) REFERENCES [tblKaryawan] ([KaryawanID]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
INSERT INTO [tblShift] ([IDShift],[NamaShift],[JamMasuk],[JamPulang],[ToleransiTelatMenit]) VALUES (
1,'Pagi','07:00:00','15:00:00',15);
INSERT INTO [tblShift] ([IDShift],[NamaShift],[JamMasuk],[JamPulang],[ToleransiTelatMenit]) VALUES (
2,'Siang','15:00:00','23:00:00',15);
INSERT INTO [tblShift] ([IDShift],[NamaShift],[JamMasuk],[JamPulang],[ToleransiTelatMenit]) VALUES (
4,'Malam','23:00:00','07:00:00',15);
INSERT INTO [tblJabatan] ([IDJabatan],[NamaJabatan]) VALUES (
1,'Manager');
INSERT INTO [tblJabatan] ([IDJabatan],[NamaJabatan]) VALUES (
2,'Staff');
INSERT INTO [tblJabatan] ([IDJabatan],[NamaJabatan]) VALUES (
3,'Intern');
INSERT INTO [tblDepartemen] ([IDDepartemen],[NamaDepartemen]) VALUES (
1,'IT');
INSERT INTO [tblDepartemen] ([IDDepartemen],[NamaDepartemen]) VALUES (
2,'HRD');
INSERT INTO [tblDepartemen] ([IDDepartemen],[NamaDepartemen]) VALUES (
3,'Finance');
INSERT INTO [tblKaryawan] ([KaryawanID],[NIK],[Nama],[JenisKelamin],[TanggalLahir],[IDDepartemen],[IDJabatan],[TanggalMasuk],[Status],[Alamat],[NoHP]) VALUES (
1,'1213','apa',NULL,NULL,1,2,'2025-12-10 01:07:46.4961497','Aktif',NULL,NULL);
INSERT INTO [tblKaryawan] ([KaryawanID],[NIK],[Nama],[JenisKelamin],[TanggalLahir],[IDDepartemen],[IDJabatan],[TanggalMasuk],[Status],[Alamat],[NoHP]) VALUES (
2,'11111','Agus',NULL,NULL,3,2,'2025-12-10 01:16:42.3132022','Aktif',NULL,NULL);
INSERT INTO [tblKaryawan] ([KaryawanID],[NIK],[Nama],[JenisKelamin],[TanggalLahir],[IDDepartemen],[IDJabatan],[TanggalMasuk],[Status],[Alamat],[NoHP]) VALUES (
3,'12235235','Andrew',NULL,NULL,1,1,'2025-12-19 21:47:50.0761733','Aktif',NULL,NULL);
INSERT INTO [tblKaryawan] ([KaryawanID],[NIK],[Nama],[JenisKelamin],[TanggalLahir],[IDDepartemen],[IDJabatan],[TanggalMasuk],[Status],[Alamat],[NoHP]) VALUES (
4,'12431234','dsadsqd',NULL,NULL,1,1,'2025-12-19 21:55:47.8722829','Aktif',NULL,NULL);
INSERT INTO [tblKaryawan] ([KaryawanID],[NIK],[Nama],[JenisKelamin],[TanggalLahir],[IDDepartemen],[IDJabatan],[TanggalMasuk],[Status],[Alamat],[NoHP]) VALUES (
5,'231312','drew',NULL,NULL,2,1,'2025-12-19 22:03:54.7194427','Aktif',NULL,NULL);
INSERT INTO [tblKaryawan] ([KaryawanID],[NIK],[Nama],[JenisKelamin],[TanggalLahir],[IDDepartemen],[IDJabatan],[TanggalMasuk],[Status],[Alamat],[NoHP]) VALUES (
6,'2131231','And',NULL,NULL,1,2,'2025-12-19 22:11:11.5932461','Aktif',NULL,NULL);
INSERT INTO [tblKaryawan] ([KaryawanID],[NIK],[Nama],[JenisKelamin],[TanggalLahir],[IDDepartemen],[IDJabatan],[TanggalMasuk],[Status],[Alamat],[NoHP]) VALUES (
7,'1286312','Rimek',NULL,NULL,1,1,'2026-01-01 20:55:11.8173324','Aktif',NULL,NULL);
INSERT INTO [tblUser] ([UserID],[Username],[PasswordHash],[Role],[KaryawanID]) VALUES (
1,'admin','admin123','Admin',NULL);
INSERT INTO [tblUser] ([UserID],[Username],[PasswordHash],[Role],[KaryawanID]) VALUES (
2,'budi','budi123','Atasan',1);
INSERT INTO [tblUser] ([UserID],[Username],[PasswordHash],[Role],[KaryawanID]) VALUES (
3,'riski','riski123','Karyawan',1);
INSERT INTO [tblUser] ([UserID],[Username],[PasswordHash],[Role],[KaryawanID]) VALUES (
4,'agus','agus123','Karyawan',2);
INSERT INTO [tblUser] ([UserID],[Username],[PasswordHash],[Role],[KaryawanID]) VALUES (
5,'drewips','123','Karyawan',3);
INSERT INTO [tblUser] ([UserID],[Username],[PasswordHash],[Role],[KaryawanID]) VALUES (
6,'qq','123','Karyawan',4);
INSERT INTO [tblUser] ([UserID],[Username],[PasswordHash],[Role],[KaryawanID]) VALUES (
7,'dd','123','Karyawan',5);
INSERT INTO [tblUser] ([UserID],[Username],[PasswordHash],[Role],[KaryawanID]) VALUES (
8,'ww','123','Karyawan',6);
INSERT INTO [tblUser] ([UserID],[Username],[PasswordHash],[Role],[KaryawanID]) VALUES (
9,'rimek','123','Karyawan',7);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
1,'2025-12-10',1,1,'2025-12-10 01:11:54.9124812','2025-12-10 01:11:57.5912335','H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
2,'2025-12-10',2,1,'2025-12-10 01:20:36.5297038',NULL,'H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
3,'2025-12-19',2,1,'2025-12-19 21:35:16.4606521','2025-12-19 21:35:18.1288526','H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
4,'2025-12-19',1,1,'2025-12-19 21:42:47.5223421','2025-12-19 21:42:48.7812395','H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
5,'2025-12-19',3,1,'2025-12-19 21:48:43.8563979','2025-12-19 21:49:03.745446','H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
6,'2025-12-19',4,1,'2025-12-19 21:56:29.322199','2025-12-19 21:56:33.5109613','H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
7,'2025-12-19',5,1,'2025-12-19 22:04:44.2278616','2025-12-19 22:04:45.1467566','H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
8,'2025-12-19',6,2,'2025-12-19 22:14:48.3202752','2025-12-19 22:14:50.1537225','H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
9,'2026-01-01',7,2,'2026-01-01 21:31:55.091525','2026-01-01 21:32:02.3365822','H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
10,'2026-01-01',2,2,'2026-01-01 21:35:18.6329172','2026-01-01 21:35:21.3598676','H',0,0,NULL);
INSERT INTO [tblAbsensi] ([IDAbsensi],[Tanggal],[KaryawanID],[IDShift],[JamMasuk],[JamPulang],[Status],[TelatMenit],[LemburMenit],[Keterangan]) VALUES (
11,'2026-01-08',2,2,'2026-01-08 22:09:08.0279447','2026-01-08 22:09:11.9749559','H',0,0,NULL);
CREATE UNIQUE INDEX [sqlite_autoindex_tblKaryawan_1] ON [tblKaryawan] ([NIK] ASC);
CREATE UNIQUE INDEX [sqlite_autoindex_tblUser_1] ON [tblUser] ([Username] ASC);
CREATE UNIQUE INDEX [sqlite_autoindex_tblAbsensi_1] ON [tblAbsensi] ([Tanggal] ASC,[KaryawanID] ASC);
CREATE TRIGGER [fki_tblKaryawan_IDJabatan_tblJabatan_IDJabatan] BEFORE Insert ON [tblKaryawan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table tblKaryawan violates foreign key constraint FK_tblKaryawan_0_0') WHERE NEW.IDJabatan IS NOT NULL AND NOT EXISTS (SELECT * FROM tblJabatan WHERE  IDJabatan = NEW.IDJabatan); END;
CREATE TRIGGER [fku_tblKaryawan_IDJabatan_tblJabatan_IDJabatan] BEFORE Update ON [tblKaryawan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table tblKaryawan violates foreign key constraint FK_tblKaryawan_0_0') WHERE NEW.IDJabatan IS NOT NULL AND NOT EXISTS (SELECT * FROM tblJabatan WHERE  IDJabatan = NEW.IDJabatan); END;
CREATE TRIGGER [fki_tblKaryawan_IDDepartemen_tblDepartemen_IDDepartemen] BEFORE Insert ON [tblKaryawan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table tblKaryawan violates foreign key constraint FK_tblKaryawan_1_0') WHERE NEW.IDDepartemen IS NOT NULL AND NOT EXISTS (SELECT * FROM tblDepartemen WHERE  IDDepartemen = NEW.IDDepartemen); END;
CREATE TRIGGER [fku_tblKaryawan_IDDepartemen_tblDepartemen_IDDepartemen] BEFORE Update ON [tblKaryawan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table tblKaryawan violates foreign key constraint FK_tblKaryawan_1_0') WHERE NEW.IDDepartemen IS NOT NULL AND NOT EXISTS (SELECT * FROM tblDepartemen WHERE  IDDepartemen = NEW.IDDepartemen); END;
CREATE TRIGGER [fki_tblUser_KaryawanID_tblKaryawan_KaryawanID] BEFORE Insert ON [tblUser] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table tblUser violates foreign key constraint FK_tblUser_0_0') WHERE NEW.KaryawanID IS NOT NULL AND NOT EXISTS (SELECT * FROM tblKaryawan WHERE  KaryawanID = NEW.KaryawanID); END;
CREATE TRIGGER [fku_tblUser_KaryawanID_tblKaryawan_KaryawanID] BEFORE Update ON [tblUser] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table tblUser violates foreign key constraint FK_tblUser_0_0') WHERE NEW.KaryawanID IS NOT NULL AND NOT EXISTS (SELECT * FROM tblKaryawan WHERE  KaryawanID = NEW.KaryawanID); END;
CREATE TRIGGER [fki_tblIzinCuti_DisetujuiOleh_tblUser_UserID] BEFORE Insert ON [tblIzinCuti] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table tblIzinCuti violates foreign key constraint FK_tblIzinCuti_0_0') WHERE NEW.DisetujuiOleh IS NOT NULL AND NOT EXISTS (SELECT * FROM tblUser WHERE  UserID = NEW.DisetujuiOleh); END;
CREATE TRIGGER [fku_tblIzinCuti_DisetujuiOleh_tblUser_UserID] BEFORE Update ON [tblIzinCuti] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table tblIzinCuti violates foreign key constraint FK_tblIzinCuti_0_0') WHERE NEW.DisetujuiOleh IS NOT NULL AND NOT EXISTS (SELECT * FROM tblUser WHERE  UserID = NEW.DisetujuiOleh); END;
CREATE TRIGGER [fki_tblIzinCuti_KaryawanID_tblKaryawan_KaryawanID] BEFORE Insert ON [tblIzinCuti] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table tblIzinCuti violates foreign key constraint FK_tblIzinCuti_1_0') WHERE NEW.KaryawanID IS NOT NULL AND NOT EXISTS (SELECT * FROM tblKaryawan WHERE  KaryawanID = NEW.KaryawanID); END;
CREATE TRIGGER [fku_tblIzinCuti_KaryawanID_tblKaryawan_KaryawanID] BEFORE Update ON [tblIzinCuti] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table tblIzinCuti violates foreign key constraint FK_tblIzinCuti_1_0') WHERE NEW.KaryawanID IS NOT NULL AND NOT EXISTS (SELECT * FROM tblKaryawan WHERE  KaryawanID = NEW.KaryawanID); END;
CREATE TRIGGER [fki_tblAbsensi_IDShift_tblShift_IDShift] BEFORE Insert ON [tblAbsensi] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table tblAbsensi violates foreign key constraint FK_tblAbsensi_0_0') WHERE NEW.IDShift IS NOT NULL AND NOT EXISTS (SELECT * FROM tblShift WHERE  IDShift = NEW.IDShift); END;
CREATE TRIGGER [fku_tblAbsensi_IDShift_tblShift_IDShift] BEFORE Update ON [tblAbsensi] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table tblAbsensi violates foreign key constraint FK_tblAbsensi_0_0') WHERE NEW.IDShift IS NOT NULL AND NOT EXISTS (SELECT * FROM tblShift WHERE  IDShift = NEW.IDShift); END;
CREATE TRIGGER [fki_tblAbsensi_KaryawanID_tblKaryawan_KaryawanID] BEFORE Insert ON [tblAbsensi] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table tblAbsensi violates foreign key constraint FK_tblAbsensi_1_0') WHERE NEW.KaryawanID IS NOT NULL AND NOT EXISTS (SELECT * FROM tblKaryawan WHERE  KaryawanID = NEW.KaryawanID); END;
CREATE TRIGGER [fku_tblAbsensi_KaryawanID_tblKaryawan_KaryawanID] BEFORE Update ON [tblAbsensi] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table tblAbsensi violates foreign key constraint FK_tblAbsensi_1_0') WHERE NEW.KaryawanID IS NOT NULL AND NOT EXISTS (SELECT * FROM tblKaryawan WHERE  KaryawanID = NEW.KaryawanID); END;
COMMIT;

