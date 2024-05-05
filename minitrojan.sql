CREATE DATABASE  IF NOT EXISTS `minitrojan` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci */;
USE `minitrojan`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: minitrojan
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `detail_transaksi`
--

DROP TABLE IF EXISTS `detail_transaksi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detail_transaksi` (
  `transaksi_id` int(11) NOT NULL,
  `products_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `harga` double NOT NULL,
  PRIMARY KEY (`transaksi_id`,`products_id`),
  KEY `fk_transactions_has_products_products1_idx` (`products_id`),
  KEY `fk_transactions_has_products_transactions1_idx` (`transaksi_id`),
  CONSTRAINT `fk_transactions_has_products_products1` FOREIGN KEY (`products_id`) REFERENCES `produk` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_transactions_has_products_transactions1` FOREIGN KEY (`transaksi_id`) REFERENCES `transaksi` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detail_transaksi`
--

LOCK TABLES `detail_transaksi` WRITE;
/*!40000 ALTER TABLE `detail_transaksi` DISABLE KEYS */;
INSERT INTO `detail_transaksi` VALUES (1,1,1,10000),(1,3,3,15000),(2,1,2,10000),(2,2,3,20000),(3,2,2,20000),(3,3,2,15000);
/*!40000 ALTER TABLE `detail_transaksi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `keranjang`
--

DROP TABLE IF EXISTS `keranjang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `keranjang` (
  `users_id` int(11) NOT NULL,
  `produk_id` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  PRIMARY KEY (`users_id`,`produk_id`),
  KEY `fk_users_has_products_products1_idx` (`produk_id`),
  KEY `fk_users_has_products_users1_idx` (`users_id`),
  CONSTRAINT `fk_users_has_products_products1` FOREIGN KEY (`produk_id`) REFERENCES `produk` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_users_has_products_users1` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `keranjang`
--

LOCK TABLES `keranjang` WRITE;
/*!40000 ALTER TABLE `keranjang` DISABLE KEYS */;
/*!40000 ALTER TABLE `keranjang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produk`
--

DROP TABLE IF EXISTS `produk`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produk` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `deskripsi` text NOT NULL,
  `harga` double NOT NULL,
  `stock` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produk`
--

LOCK TABLES `produk` WRITE;
/*!40000 ALTER TABLE `produk` DISABLE KEYS */;
INSERT INTO `produk` VALUES (1,'Kaos Bear','Kaos ini sangat branded',10000,7),(2,'Kaos Polos','kaos ini sangat baggus',20000,15),(3,'celana','celana ini skena banget',15000,25);
/*!40000 ALTER TABLE `produk` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `topups`
--

DROP TABLE IF EXISTS `topups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `topups` (
  `id` int(11) NOT NULL,
  `users_id` int(11) NOT NULL,
  `topup_date` date NOT NULL,
  `nominal` text NOT NULL,
  `status` enum('SUKSES','PENDING','GAGAL') NOT NULL,
  `bukti_transfer` varchar(45) NOT NULL,
  `staff_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_topups_users1_idx` (`users_id`),
  KEY `fk_topups_users2_idx` (`staff_id`),
  CONSTRAINT `fk_topups_users1` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_topups_users2` FOREIGN KEY (`staff_id`) REFERENCES `users` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `topups`
--

LOCK TABLES `topups` WRITE;
/*!40000 ALTER TABLE `topups` DISABLE KEYS */;
INSERT INTO `topups` VALUES (1,2,'2024-05-02','1000000','SUKSES','topup_1',1),(2,3,'2024-05-02','1000000','SUKSES','topup_2',1),(3,4,'2024-05-02','1000000','SUKSES','topup_3',1);
/*!40000 ALTER TABLE `topups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaksi`
--

DROP TABLE IF EXISTS `transaksi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transaksi` (
  `id` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `total` double NOT NULL,
  `users_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_transactions_users1_idx` (`users_id`),
  CONSTRAINT `fk_transactions_users1` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaksi`
--

LOCK TABLES `transaksi` WRITE;
/*!40000 ALTER TABLE `transaksi` DISABLE KEYS */;
INSERT INTO `transaksi` VALUES (1,'2024-05-02 04:40:53',55000,2),(2,'2024-05-02 04:55:23',80000,3),(3,'2024-05-02 04:56:18',70000,4);
/*!40000 ALTER TABLE `transaksi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` text NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL,
  `nama` text NOT NULL,
  `saldo` text NOT NULL,
  `role` enum('KONSUMEN','ADMIN','STAFF') NOT NULL,
  `sisa_percobaan_login` varchar(45) NOT NULL,
  `photo_id_path` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'AAAAAAAAAAAAAAAAAAAAAOHuQTRe0aShgJlBpx1WEPo=','AAAAAAAAAAAAAAAAAAAAAOHuQTRe0aShgJlBpx1WEPo=','835d6dc88b708bc646d6db82c853ef4182fabbd4a8de59c213f2b5ab3ae7d9be','AAAAAAAAAAAAAAAAAAAAAOHuQTRe0aShgJlBpx1WEPo=','AAAAAAAAAAAAAAAAAAAAAMdt3coCo0X9H/L4SD/EuDo=','ADMIN','3',NULL),(2,'AAAAAAAAAAAAAAAAAAAAAErH6lyh3zOrcFJEhoS2WfI=','AAAAAAAAAAAAAAAAAAAAAErH6lyh3zOrcFJEhoS2WfI=','13aacf62bf7029566aa6488bd4722075f9c8a3fa3e63ae018819998ff619e409','AAAAAAAAAAAAAAAAAAAAAErH6lyh3zOrcFJEhoS2WfI=','AAAAAAAAAAAAAAAAAAAAAEpi9MsobKhDlWMBoB6jquA=','KONSUMEN','3','users_2'),(3,'AAAAAAAAAAAAAAAAAAAAAPgubbfgJDeePpQbwaGwUjU=','AAAAAAAAAAAAAAAAAAAAAPgubbfgJDeePpQbwaGwUjU=','22a9cd4d8ea1f55ccb030b317e5d2f34c1ea7a830e68b3ad2f45063cc4b8628a','AAAAAAAAAAAAAAAAAAAAAPgubbfgJDeePpQbwaGwUjU=','AAAAAAAAAAAAAAAAAAAAAHo5KI/3vekiaNufnZMIzh4=','KONSUMEN','3','users_3'),(4,'AAAAAAAAAAAAAAAAAAAAAG5d89qpWQUmBI02a5qUhqw=','AAAAAAAAAAAAAAAAAAAAAG5d89qpWQUmBI02a5qUhqw=','6c4026e3fe8dcff1a257ceb254bab0b3d57f90687b954523f2100975d27b9fd6','AAAAAAAAAAAAAAAAAAAAAG5d89qpWQUmBI02a5qUhqw=','AAAAAAAAAAAAAAAAAAAAAF+o1VsDjxY9OzfjOIePBHg=','KONSUMEN','3','users_4'),(5,'AAAAAAAAAAAAAAAAAAAAANFq9ROABE9meoN7rDEZkkQ=','AAAAAAAAAAAAAAAAAAAAANFq9ROABE9meoN7rDEZkkQ=','a03ea09072d789adff29aff6a3758e9294c96ce803915c1456384eaa6e2d2df9','AAAAAAAAAAAAAAAAAAAAANFq9ROABE9meoN7rDEZkkQ=','AAAAAAAAAAAAAAAAAAAAAMdt3coCo0X9H/L4SD/EuDo=','STAFF','3','');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-02  4:59:35
