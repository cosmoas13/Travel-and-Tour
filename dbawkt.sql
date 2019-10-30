-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 13, 2017 at 06:05 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbawkt`
--
CREATE DATABASE IF NOT EXISTS `dbawkt` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `dbawkt`;

-- --------------------------------------------------------

--
-- Table structure for table `tbdetail`
--

CREATE TABLE `tbdetail` (
  `no_pemesanan` char(4) NOT NULL,
  `kode_pelanggan` char(4) NOT NULL,
  `kode_travel` char(4) NOT NULL,
  `nama_travel` varchar(50) NOT NULL,
  `harga_travel` int(11) NOT NULL,
  `jumlah_tiket` int(11) NOT NULL,
  `total_bayar` int(11) NOT NULL,
  `bayar` int(11) NOT NULL,
  `kembalian` int(11) NOT NULL,
  `status` varchar(50) NOT NULL,
  `kendaraan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbdetail`
--

INSERT INTO `tbdetail` (`no_pemesanan`, `kode_pelanggan`, `kode_travel`, `nama_travel`, `harga_travel`, `jumlah_tiket`, `total_bayar`, `bayar`, `kembalian`, `status`, `kendaraan`) VALUES
('M001', 'P001', 'T001', 'Palembang - Kertapati', 250000, 1, 250000, 260000, 10000, 'Lunas', 'Jazz');

-- --------------------------------------------------------

--
-- Table structure for table `tbladmin`
--

CREATE TABLE `tbladmin` (
  `kode_admin` char(4) NOT NULL,
  `nama_admin` varchar(50) NOT NULL,
  `jenis_kelamin` char(1) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `email` varchar(50) NOT NULL,
  `telpon` varchar(12) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbladmin`
--

INSERT INTO `tbladmin` (`kode_admin`, `nama_admin`, `jenis_kelamin`, `tanggal_lahir`, `email`, `telpon`, `password`) VALUES
('A001', 'Ahmad Wildan Rizky Ramadhan', 'L', '1998-08-13', 'awildanrr@gmail.com', '0', '123456'),
('A002', 'Kevin', 'L', '1997-08-12', 'Arta@gmail.com', '0', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `tblmobil`
--

CREATE TABLE `tblmobil` (
  `kode_mobil` char(4) NOT NULL,
  `nama_mobil` varchar(50) NOT NULL,
  `tipe_mobil` varchar(50) NOT NULL,
  `kapasitas_penumpang` int(50) NOT NULL,
  `tahun_keluaran` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblmobil`
--

INSERT INTO `tblmobil` (`kode_mobil`, `nama_mobil`, `tipe_mobil`, `kapasitas_penumpang`, `tahun_keluaran`) VALUES
('C001', 'Jazz', 'BMX', 0, '2017-05-01'),
('C002', 'Hondaz', 'BGMV', 0, '2017-05-24');

-- --------------------------------------------------------

--
-- Table structure for table `tblpelanggan`
--

CREATE TABLE `tblpelanggan` (
  `kode_pelanggan` char(4) NOT NULL,
  `nama_pelanggan` varchar(50) NOT NULL,
  `jenis_kelamin` char(1) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `email` varchar(50) NOT NULL,
  `telpon` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpelanggan`
--

INSERT INTO `tblpelanggan` (`kode_pelanggan`, `nama_pelanggan`, `jenis_kelamin`, `tanggal_lahir`, `email`, `telpon`) VALUES
('M002', 'T001', 'P', '2040-00-00', '2017-06-13', '2017-06-085'),
('P001', 'Otis', 'L', '1997-05-09', 'OtisBack@gmail.com', '081212131235'),
('P002', 'Elli', 'P', '1998-05-30', 'Elli@gmail.com', '081728173812'),
('P003', 'Sugi', 'L', '1997-05-02', 'Sugi@gmail.com', '082132423452'),
('P004', 'Aruta', 'L', '1997-05-29', 'narta@mhs.mdp.ac.id', '089812314563'),
('P005', 'Auuuuu', 'P', '1998-05-09', 'auu@gmail.com', '089812342187'),
('P006', 'Soya', 'L', '1998-05-31', 'SoyaCheeseCracker@gmail.com', '089876759878'),
('P007', 'Oii', 'L', '1995-06-13', 'a@gmail.com', '089779798787');

-- --------------------------------------------------------

--
-- Table structure for table `tbltravel`
--

CREATE TABLE `tbltravel` (
  `kode_travel` char(4) NOT NULL,
  `nama_travel` varchar(50) NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltravel`
--

INSERT INTO `tbltravel` (`kode_travel`, `nama_travel`, `harga`) VALUES
('T001', 'Palembang - Indralaya', 40000),
('T002', 'Palembang - Prabumulih', 60000),
('T003', 'Palembang - Muaraenim', 75000),
('T004', 'Palembang - Lampung', 100000),
('T005', 'Palembang - KayuAgung', 60000),
('T006', 'Palembang - Baturaja', 60000);

-- --------------------------------------------------------

--
-- Table structure for table `tbpemesanan`
--

CREATE TABLE `tbpemesanan` (
  `no_pemesanan` char(4) NOT NULL,
  `kode_pelanggan` char(4) NOT NULL,
  `kode_travel` char(4) NOT NULL,
  `nama_travel` varchar(50) NOT NULL,
  `harga_travel` int(11) NOT NULL,
  `tanggal_pesan` date NOT NULL,
  `tanggal_berangkat` date NOT NULL,
  `jumlah_tiket` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbpemesanan`
--

INSERT INTO `tbpemesanan` (`no_pemesanan`, `kode_pelanggan`, `kode_travel`, `nama_travel`, `harga_travel`, `tanggal_pesan`, `tanggal_berangkat`, `jumlah_tiket`) VALUES
('M001', 'P001', 'T001', 'Palembang - Kertapati', 250000, '2017-06-13', '2017-06-21', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbladmin`
--
ALTER TABLE `tbladmin`
  ADD PRIMARY KEY (`kode_admin`);

--
-- Indexes for table `tblmobil`
--
ALTER TABLE `tblmobil`
  ADD PRIMARY KEY (`kode_mobil`);

--
-- Indexes for table `tblpelanggan`
--
ALTER TABLE `tblpelanggan`
  ADD PRIMARY KEY (`kode_pelanggan`);

--
-- Indexes for table `tbltravel`
--
ALTER TABLE `tbltravel`
  ADD PRIMARY KEY (`kode_travel`);

--
-- Indexes for table `tbpemesanan`
--
ALTER TABLE `tbpemesanan`
  ADD PRIMARY KEY (`no_pemesanan`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
