-- SQLite Schema for Absensi App

-- 1. Tabel User
CREATE TABLE IF NOT EXISTS tblUser (
    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT UNIQUE NOT NULL,
    PasswordHash TEXT NOT NULL,
    Role TEXT NOT NULL CHECK (Role IN ('Admin', 'HR', 'Atasan', 'Karyawan')),
    KaryawanID INTEGER, -- FK added later
    FOREIGN KEY (KaryawanID) REFERENCES tblKaryawan(KaryawanID)
);

-- 2. Tabel Departemen
CREATE TABLE IF NOT EXISTS tblDepartemen (
    IDDepartemen INTEGER PRIMARY KEY AUTOINCREMENT,
    NamaDepartemen TEXT NOT NULL
);

-- 3. Tabel Jabatan
CREATE TABLE IF NOT EXISTS tblJabatan (
    IDJabatan INTEGER PRIMARY KEY AUTOINCREMENT,
    NamaJabatan TEXT NOT NULL
);

-- 4. Tabel Karyawan
CREATE TABLE IF NOT EXISTS tblKaryawan (
    KaryawanID INTEGER PRIMARY KEY AUTOINCREMENT,
    NIK TEXT UNIQUE NOT NULL,
    Nama TEXT NOT NULL,
    JenisKelamin TEXT CHECK (JenisKelamin IN ('L', 'P')),
    TanggalLahir TEXT, -- YYYY-MM-DD
    IDDepartemen INTEGER,
    IDJabatan INTEGER,
    TanggalMasuk TEXT NOT NULL, -- YYYY-MM-DD
    Status TEXT CHECK (Status IN ('Aktif', 'Nonaktif')),
    Alamat TEXT,
    NoHP TEXT,
    FOREIGN KEY (IDDepartemen) REFERENCES tblDepartemen(IDDepartemen),
    FOREIGN KEY (IDJabatan) REFERENCES tblJabatan(IDJabatan)
);

-- 5. Tabel Shift
CREATE TABLE IF NOT EXISTS tblShift (
    IDShift INTEGER PRIMARY KEY AUTOINCREMENT,
    NamaShift TEXT NOT NULL,
    JamMasuk TEXT NOT NULL, -- HH:MM
    JamPulang TEXT NOT NULL, -- HH:MM
    ToleransiTelatMenit INTEGER DEFAULT 0
);

-- 6. Tabel Hari Libur
CREATE TABLE IF NOT EXISTS tblHariLibur (
    IDLibur INTEGER PRIMARY KEY AUTOINCREMENT,
    Tanggal TEXT NOT NULL, -- YYYY-MM-DD
    Keterangan TEXT
);

-- 7. Tabel Absensi
CREATE TABLE IF NOT EXISTS tblAbsensi (
    IDAbsensi INTEGER PRIMARY KEY AUTOINCREMENT,
    Tanggal TEXT NOT NULL, -- YYYY-MM-DD
    KaryawanID INTEGER,
    IDShift INTEGER,
    JamMasuk TEXT, -- YYYY-MM-DD HH:MM:SS
    JamPulang TEXT, -- YYYY-MM-DD HH:MM:SS
    Status TEXT CHECK (Status IN ('H', 'A', 'I', 'S', 'C')),
    TelatMenit INTEGER DEFAULT 0,
    LemburMenit INTEGER DEFAULT 0,
    Keterangan TEXT,
    UNIQUE (Tanggal, KaryawanID),
    FOREIGN KEY (KaryawanID) REFERENCES tblKaryawan(KaryawanID),
    FOREIGN KEY (IDShift) REFERENCES tblShift(IDShift)
);

-- 8. Tabel Izin/Cuti
CREATE TABLE IF NOT EXISTS tblIzinCuti (
    IDIzin INTEGER PRIMARY KEY AUTOINCREMENT,
    KaryawanID INTEGER,
    TanggalMulai TEXT NOT NULL,
    TanggalSelesai TEXT NOT NULL,
    Jenis TEXT CHECK (Jenis IN ('Izin', 'Cuti', 'Sakit')),
    Alasan TEXT,
    StatusPersetujuan TEXT CHECK (StatusPersetujuan IN ('Pending', 'Disetujui', 'Ditolak')),
    TanggalPengajuan TEXT DEFAULT CURRENT_TIMESTAMP,
    TanggalPersetujuan TEXT,
    DisetujuiOleh INTEGER,
    FOREIGN KEY (KaryawanID) REFERENCES tblKaryawan(KaryawanID),
    FOREIGN KEY (DisetujuiOleh) REFERENCES tblUser(UserID)
);

-- Seed Data
INSERT OR IGNORE INTO tblUser (Username, PasswordHash, Role) VALUES ('admin', 'admin123', 'Admin');

INSERT OR IGNORE INTO tblDepartemen (NamaDepartemen) VALUES ('IT'), ('HRD'), ('Finance');
INSERT OR IGNORE INTO tblJabatan (NamaJabatan) VALUES ('Manager'), ('Staff'), ('Intern');
INSERT OR IGNORE INTO tblShift (NamaShift, JamMasuk, JamPulang, ToleransiTelatMenit) VALUES 
('Pagi', '08:00', '17:00', 15),
('Siang', '13:00', '21:00', 15);
