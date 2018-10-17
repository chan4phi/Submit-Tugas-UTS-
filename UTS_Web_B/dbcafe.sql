-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.34-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for dbcafe
DROP DATABASE IF EXISTS `dbcafe`;
CREATE DATABASE IF NOT EXISTS `dbcafe` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `dbcafe`;

-- Dumping structure for table dbcafe.inputan
DROP TABLE IF EXISTS `inputan`;
CREATE TABLE IF NOT EXISTS `inputan` (
  `Kode_produk` varchar(20) NOT NULL,
  `Nama_produk` varchar(50) NOT NULL,
  `Kategori_id` varchar(15) NOT NULL,
  `harga` int(11) NOT NULL,
  `Foto_produk` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Kode_produk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dbcafe.inputan: ~0 rows (approximately)
/*!40000 ALTER TABLE `inputan` DISABLE KEYS */;
INSERT INTO `inputan` (`Kode_produk`, `Nama_produk`, `Kategori_id`, `harga`, `Foto_produk`) VALUES
	('CID0000001', 'test1', 'Makanan', 1231, 'gambar/'),
	('CID0000002', 'asssaaa', 'Makanan', 222, 'gambar/'),
	('CID0000003', 'asssaaa', 'Makanan', 222, 'gambar/'),
	('CID0000004', 'tessyy', '', 9, 'gambar/'),
	('CID0000005', 'aadada', '', 121, 'gambar/'),
	('CID0000006', 'adooadaodaodaodas', 'Minuman', 4242, 'gambar/'),
	('CID0000007', 'adooadaodaodaodas', '', 111111, 'gambar/');
/*!40000 ALTER TABLE `inputan` ENABLE KEYS */;

-- Dumping structure for table dbcafe.kategori
DROP TABLE IF EXISTS `kategori`;
CREATE TABLE IF NOT EXISTS `kategori` (
  `Kategori_id` varchar(15) NOT NULL,
  `Kategori_desc` varchar(35) NOT NULL,
  PRIMARY KEY (`Kategori_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dbcafe.kategori: ~3 rows (approximately)
/*!40000 ALTER TABLE `kategori` DISABLE KEYS */;
INSERT INTO `kategori` (`Kategori_id`, `Kategori_desc`) VALUES
	('K001', 'Makanan'),
	('K002', 'Minuman'),
	('K003', 'Jajanan Ringan');
/*!40000 ALTER TABLE `kategori` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
