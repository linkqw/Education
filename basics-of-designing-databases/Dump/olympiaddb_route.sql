CREATE DATABASE  IF NOT EXISTS `olympiaddb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `olympiaddb`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: olympiaddb
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `route`
--

DROP TABLE IF EXISTS `route`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `route` (
  `routeId` int NOT NULL AUTO_INCREMENT,
  `startPoint` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `endPoint` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `travelTime` time DEFAULT NULL,
  `transportTypeId` int NOT NULL,
  `carrierId` int NOT NULL,
  PRIMARY KEY (`routeId`),
  KEY `transportTypeId` (`transportTypeId`),
  KEY `carrierId` (`carrierId`),
  CONSTRAINT `route_ibfk_1` FOREIGN KEY (`transportTypeId`) REFERENCES `transporttype` (`typeId`),
  CONSTRAINT `route_ibfk_2` FOREIGN KEY (`carrierId`) REFERENCES `carrier` (`carrierId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `route`
--

LOCK TABLES `route` WRITE;
/*!40000 ALTER TABLE `route` DISABLE KEYS */;
INSERT INTO `route` VALUES (1,'Новосибирск-Главный','Пригородный простор','01:27:00',1,1),(2,'Новосибирск-Главный','Сокур','01:32:00',1,2),(3,'Новосибирск-Главный','Болотная','01:50:00',2,2),(4,'Инская','Речной вокзал','00:25:00',2,1),(5,'Цветущая плющиха','Ботанический жилмассив','02:30:00',3,3),(6,'Пригородный простор','Улица Тюленина','03:58:00',3,4),(7,'Цветущая плющиха','Ботанический жилмассив','01:59:00',4,4),(8,'Котельная','Колыванская улица','02:40:00',4,3),(9,'Бугринская роща','Бугринская роща','01:15:00',5,5),(10,'Юго-Западный ж/м','Бугринская роща','01:47:00',5,6);
/*!40000 ALTER TABLE `route` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-19  2:48:38
