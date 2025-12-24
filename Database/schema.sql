CREATE DATABASE AbsensiDB;
GO

USE AbsensiDB;
GO

-- 1. Tabel User
CREATE TABLE tblUser (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL, -- Plain text for now as per request, but named Hash for future
    Role VARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'HR', 'Atasan')),
    KaryawanID INT NULL -- FK added later
);

-- 2. Tabel Departemen
CREATE TABLE tblDepartemen (
    IDDepartemen INT IDENTITY(1,1) PRIMARY KEY,
    NamaDepartemen VARCHAR(100) NOT NULL
);

-- 3. Tabel Jabatan
CREATE TABLE tblJabatan (
    IDJabatan INT IDENTITY(1,1) PRIMARY KEY,
    NamaJabatan VARCHAR(100) NOT NULL
);

-- 4. Tabel Karyawan
CREATE TABLE tblKaryawan (
    KaryawanID INT IDENTITY(1,1) PRIMARY KEY,
    NIK VARCHAR(50) UNIQUE NOT NULL,
    Nama VARCHAR(100) NOT NULL,
    JenisKelamin CHAR(1) CHECK (JenisKelamin IN ('L', 'P')),
    TanggalLahir DATE,
    IDDepartemen INT FOREIGN KEY REFERENCES tblDepartemen(IDDepartemen),
    IDJabatan INT FOREIGN KEY REFERENCES tblJabatan(IDJabatan),
    TanggalMasuk DATE NOT NULL,
    Status VARCHAR(10) CHECK (Status IN ('Aktif', 'Nonaktif')),
    Alamat VARCHAR(200),
    NoHP VARCHAR(20)
);

-- Add FK to tblUser
ALTER TABLE tblUser ADD CONSTRAINT FK_User_Karyawan FOREIGN KEY (KaryawanID) REFERENCES tblKaryawan(KaryawanID);

-- 5. Tabel Shift
CREATE TABLE tblShift (
    IDShift INT IDENTITY(1,1) PRIMARY KEY,
    NamaShift VARCHAR(50) NOT NULL,
    JamMasuk TIME NOT NULL,
    JamPulang TIME NOT NULL,
    ToleransiTelatMenit INT DEFAULT 0
);

-- 6. Tabel Hari Libur
CREATE TABLE tblHariLibur (
    IDLibur INT IDENTITY(1,1) PRIMARY KEY,
    Tanggal DATE NOT NULL,
    Keterangan VARCHAR(100)
);

-- 7. Tabel Absensi
CREATE TABLE tblAbsensi (
    IDAbsensi INT IDENTITY(1,1) PRIMARY KEY,
    Tanggal DATE NOT NULL,
    KaryawanID INT FOREIGN KEY REFERENCES tblKaryawan(KaryawanID),
    IDShift INT FOREIGN KEY REFERENCES tblShift(IDShift),
    JamMasuk DATETIME,
    JamPulang DATETIME,
    Status CHAR(1) CHECK (Status IN ('H', 'A', 'I', 'S', 'C')), -- Hadir, Alpha, Izin, Sakit, Cuti
    TelatMenit INT DEFAULT 0,
    LemburMenit INT DEFAULT 0,
    Keterangan VARCHAR(200),
    CONSTRAINT UQ_Absensi_Harian UNIQUE (Tanggal, KaryawanID)
);

-- 8. Tabel Izin/Cuti
CREATE TABLE tblIzinCuti (
    IDIzin INT IDENTITY(1,1) PRIMARY KEY,
    KaryawanID INT FOREIGN KEY REFERENCES tblKaryawan(KaryawanID),
    TanggalMulai DATE NOT NULL,
    TanggalSelesai DATE NOT NULL,
    Jenis VARCHAR(10) CHECK (Jenis IN ('Izin', 'Cuti', 'Sakit')),
    Alasan VARCHAR(200),
    StatusPersetujuan VARCHAR(20) CHECK (StatusPersetujuan IN ('Pending', 'Disetujui', 'Ditolak')),
    TanggalPengajuan DATETIME DEFAULT GETDATE(),
    TanggalPersetujuan DATETIME,
    DisetujuiOleh INT FOREIGN KEY REFERENCES tblUser(UserID)
);

-- Seed Data
INSERT INTO tblUser (Username, PasswordHash, Role) VALUES ('admin', 'admin123', 'Admin');

INSERT INTO tblDepartemen (NamaDepartemen) VALUES ('IT'), ('HRD'), ('Finance');
INSERT INTO tblJabatan (NamaJabatan) VALUES ('Manager'), ('Staff'), ('Intern');
INSERT INTO tblShift (NamaShift, JamMasuk, JamPulang, ToleransiTelatMenit) VALUES 
('Pagi', '08:00', '17:00', 15),
('Siang', '13:00', '21:00', 15);
GO


