-- ============================================================
--  DATABASE  : db_kemas
--  APLIKASI  : KemasProject (C# WinForms + MySQL)
--  DBMS      : MySQL 5.7+ / MariaDB 10.3+  (XAMPP / Laragon OK)
--  KONEKSI   : server=127.0.0.1; user=root; password=''; db=db_kemas
--
--  Cara impor:
--    * phpMyAdmin : tab Import -> pilih file ini -> Go
--    * CLI        : mysql -u root < db_kemas.sql
-- ============================================================

CREATE DATABASE IF NOT EXISTS `db_kemas`
  DEFAULT CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;

USE `db_kemas`;

DROP TABLE IF EXISTS `log_activities`;
DROP TABLE IF EXISTS `perizinan`;
DROP TABLE IF EXISTS `siswa`;
DROP TABLE IF EXISTS `users`;
DROP TABLE IF EXISTS `tb_users`;
DROP TABLE IF EXISTS `tb_guru`;
DROP TABLE IF EXISTS `tb_roles`;

-- ============================================================
--  (Tanpa foreign key; relasi hanya lewat kolom + index)
--  1. TABEL UTAMA (dipakai signIn, FormTransaksi, FormTransaksiBaru,
--     FormDetailTransaksi, FormLaporanTransaksi)
-- ============================================================

-- ---------- users : akun login aplikasi ----------
-- password = hash SHA256 (hex lowercase), sesuai HashPassword() di signIn.cs
CREATE TABLE `users` (
  `id`         INT(11)      NOT NULL AUTO_INCREMENT,
  `nama`       VARCHAR(100) NOT NULL,
  `username`   VARCHAR(50)  NOT NULL,
  `password`   CHAR(64)     NOT NULL COMMENT 'SHA256 hex',
  `status`     VARCHAR(10) NOT NULL DEFAULT 'Aktif',
  `created_at` DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uk_users_username` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ---------- siswa : data siswa ----------
CREATE TABLE `siswa` (
  `id`         INT(11)      NOT NULL AUTO_INCREMENT,
  `nis`        VARCHAR(20)  NOT NULL,
  `nama_siswa` VARCHAR(100) NOT NULL,
  `kelas`      VARCHAR(20)  NOT NULL,
  `created_at` DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uk_siswa_nis` (`nis`),
  KEY `idx_siswa_nama` (`nama_siswa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ---------- perizinan : transaksi izin masuk / keluar ----------
-- nomor_surat contoh : KEMAS/IZM/20260918/001  (IZM = Izin Masuk, IZK = Izin Keluar)
-- alur status        : Menunggu -> Disetujui -> Selesai
--                      Menunggu -> Ditolak
--                      (Dibatalkan tersedia sebagai status di filter)
CREATE TABLE `perizinan` (
  `id`                INT(11)      NOT NULL AUTO_INCREMENT,
  `nomor_surat`       VARCHAR(50)  NOT NULL,
  `siswa_id`          INT(11)      NOT NULL,
  `jenis_izin`        VARCHAR(20) NOT NULL,
  `waktu_izin`        DATETIME     NOT NULL,
  `perkiraan_kembali` DATETIME     DEFAULT NULL COMMENT 'Hanya terisi untuk Izin Keluar',
  `keperluan`         VARCHAR(255) NOT NULL,
  `keterangan`        TEXT         DEFAULT NULL,
  `status`            VARCHAR(20) NOT NULL DEFAULT 'Menunggu',
  `petugas_id`        INT(11)      DEFAULT NULL COMMENT 'users.id yang memproses',
  `waktu_proses`      DATETIME     DEFAULT NULL,
  `alasan_penolakan`  VARCHAR(255) DEFAULT NULL,
  `created_at`        DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at`        DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
                      ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uk_perizinan_nomor_surat` (`nomor_surat`),
  KEY `idx_perizinan_siswa`  (`siswa_id`),
  KEY `idx_perizinan_petugas` (`petugas_id`),
  KEY `idx_perizinan_status` (`status`),
  KEY `idx_perizinan_waktu`  (`waktu_izin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ---------- log_activities : jejak aktivitas pengguna ----------
CREATE TABLE `log_activities` (
  `id`         INT(11)      NOT NULL AUTO_INCREMENT,
  `user_id`    INT(11)      DEFAULT NULL,
  `aktivitas`  VARCHAR(255) NOT NULL,
  `created_at` DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `idx_log_user` (`user_id`),
  KEY `idx_log_created` (`created_at`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ============================================================
--  2. TABEL DATA MASTER (dipakai form data-master/role.cs & user.cs)
--     Urutan kolom WAJIB sama karena kode memakai
--     INSERT INTO ... VALUES (null, ...) tanpa daftar kolom.
-- ============================================================

-- tb_roles : (id_role, role_name, status)
CREATE TABLE `tb_roles` (
  `id_role`   INT(11)      NOT NULL AUTO_INCREMENT,
  `role_name` VARCHAR(50)  NOT NULL,
  `status`    VARCHAR(10)  NOT NULL DEFAULT 'Aktif',
  PRIMARY KEY (`id_role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- tb_guru : (id_guru, nama, status)
CREATE TABLE `tb_guru` (
  `id_guru` INT(11)      NOT NULL AUTO_INCREMENT,
  `nama`    VARCHAR(100) NOT NULL,
  `status`  VARCHAR(10)  NOT NULL DEFAULT 'Aktif',
  PRIMARY KEY (`id_guru`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- tb_users : (id_user, username, password, id_guru, id_role, status)
CREATE TABLE `tb_users` (
  `id_user`  INT(11)      NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(50)  NOT NULL,
  `password` VARCHAR(255) NOT NULL,
  `id_guru`  INT(11)      DEFAULT NULL,
  `id_role`  INT(11)      DEFAULT NULL,
  `status`   VARCHAR(10)  NOT NULL DEFAULT 'Aktif',
  PRIMARY KEY (`id_user`),
  UNIQUE KEY `uk_tb_users_username` (`username`),
  KEY `idx_tb_users_guru` (`id_guru`),
  KEY `idx_tb_users_role` (`id_role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ============================================================
--  3. DATA AWAL (CONTOH)
-- ============================================================

-- Password login (SHA256):
--   admin   -> admin123
--   piket   -> piket123
--   kepsek  -> kepsek123
INSERT INTO `users` (`id`, `nama`, `username`, `password`, `status`) VALUES
(1, 'Administrator',        'admin',  '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Aktif'),
(2, 'Guru Piket',           'piket',  '73a28f589b034f7b600aeeab9d1fb91e34571694e50cea4958a0648dc8e9ee7e', 'Aktif'),
(3, 'Kepala Sekolah',       'kepsek', 'f78817be1857666abaef390a47aa285ad6bb043f3d4a9c08dfa59fb4f03bf76b', 'Aktif');

INSERT INTO `siswa` (`id`, `nis`, `nama_siswa`, `kelas`) VALUES
(1, '2024001', 'Ahmad Fauzi',     'X RPL 1'),
(2, '2024002', 'Bunga Lestari',   'X RPL 1'),
(3, '2024003', 'Cahya Pratama',   'X RPL 2'),
(4, '2024004', 'Dewi Anggraini',  'XI RPL 1'),
(5, '2024005', 'Eko Prasetyo',    'XI RPL 2'),
(6, '2024006', 'Fitri Handayani', 'XII RPL 1'),
(7, '2024007', 'Gilang Ramadhan', 'XII RPL 2');

INSERT INTO `perizinan`
(`id`, `nomor_surat`, `siswa_id`, `jenis_izin`, `waktu_izin`, `perkiraan_kembali`,
 `keperluan`, `keterangan`, `status`, `petugas_id`, `waktu_proses`, `alasan_penolakan`,
 `created_at`, `updated_at`) VALUES
(1, 'KEMAS/IZM/20260918/001', 1, 'Izin Masuk',  '2026-09-18 07:30:00', NULL,
    'Terlambat karena ban bocor', NULL, 'Selesai', 2, '2026-09-18 07:35:00', NULL,
    '2026-09-18 07:30:00', '2026-09-18 08:00:00'),
(2, 'KEMAS/IZK/20260918/001', 2, 'Izin Keluar', '2026-09-18 10:00:00', '2026-09-18 12:00:00',
    'Kontrol ke dokter gigi', 'Membawa surat dari orang tua', 'Disetujui', 2, '2026-09-18 10:05:00', NULL,
    '2026-09-18 09:55:00', '2026-09-18 10:05:00'),
(3, 'KEMAS/IZK/20260918/002', 3, 'Izin Keluar', '2026-09-18 11:00:00', '2026-09-18 13:00:00',
    'Keperluan keluarga', NULL, 'Ditolak', 2, '2026-09-18 11:05:00', 'Tidak ada surat dari orang tua',
    '2026-09-18 10:58:00', '2026-09-18 11:05:00'),
(4, 'KEMAS/IZM/20260920/001', 4, 'Izin Masuk',  '2026-09-20 08:15:00', NULL,
    'Mengantar adik ke sekolah', NULL, 'Menunggu', NULL, NULL, NULL,
    '2026-09-20 08:15:00', '2026-09-20 08:15:00');

INSERT INTO `log_activities` (`user_id`, `aktivitas`, `created_at`) VALUES
(2, 'Membuat transaksi perizinan KEMAS/IZM/20260918/001 dengan status Menunggu', '2026-09-18 07:30:00'),
(2, 'Mengubah status transaksi #1 menjadi Disetujui',                            '2026-09-18 07:35:00'),
(2, 'Mengubah status transaksi #1 menjadi Selesai',                              '2026-09-18 08:00:00'),
(2, 'Membuat transaksi perizinan KEMAS/IZK/20260918/001 dengan status Menunggu', '2026-09-18 09:55:00'),
(2, 'Mengubah status transaksi #2 menjadi Disetujui',                            '2026-09-18 10:05:00'),
(2, 'Membuat transaksi perizinan KEMAS/IZK/20260918/002 dengan status Menunggu', '2026-09-18 10:58:00'),
(2, 'Mengubah status transaksi #3 menjadi Ditolak',                              '2026-09-18 11:05:00'),
(2, 'Membuat transaksi perizinan KEMAS/IZM/20260920/001 dengan status Menunggu', '2026-09-20 08:15:00');

-- Data master (tb_*) contoh
INSERT INTO `tb_roles` (`id_role`, `role_name`, `status`) VALUES
(1, 'Admin',          'Aktif'),
(2, 'Guru Piket',     'Aktif'),
(3, 'Kepala Sekolah', 'Aktif');

INSERT INTO `tb_guru` (`id_guru`, `nama`, `status`) VALUES
(1, 'Administrator',  'Aktif'),
(2, 'Guru Piket',     'Aktif'),
(3, 'Kepala Sekolah', 'Aktif');

INSERT INTO `tb_users` (`id_user`, `username`, `password`, `id_guru`, `id_role`, `status`) VALUES
(1, 'admin',  'admin123',  1, 1, 'Aktif'),
(2, 'piket',  'piket123',  2, 2, 'Aktif'),
(3, 'kepsek', 'kepsek123', 3, 3, 'Aktif');
