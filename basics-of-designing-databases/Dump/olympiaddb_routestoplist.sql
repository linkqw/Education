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
-- Table structure for table `routestoplist`
--

DROP TABLE IF EXISTS `routestoplist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `routestoplist` (
  `id` int NOT NULL AUTO_INCREMENT,
  `routeId` int NOT NULL,
  `stopId` int NOT NULL,
  `stopNumberInRoute` int NOT NULL,
  `timeToNextStop` time DEFAULT NULL,
  `distanceToNextStop` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `routeId` (`routeId`),
  KEY `stopId` (`stopId`),
  CONSTRAINT `routestoplist_ibfk_1` FOREIGN KEY (`routeId`) REFERENCES `route` (`routeId`),
  CONSTRAINT `routestoplist_ibfk_2` FOREIGN KEY (`stopId`) REFERENCES `routestop` (`stopId`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `routestoplist`
--

LOCK TABLES `routestoplist` WRITE;
/*!40000 ALTER TABLE `routestoplist` DISABLE KEYS */;
INSERT INTO `routestoplist` VALUES (1,1,25,1,'00:03:00',233),(2,1,9,2,'00:05:00',306),(3,1,2,3,'00:05:00',306),(4,2,25,1,'00:10:00',2654),(5,2,20,2,'00:02:00',273),(6,2,3,3,'00:02:00',273),(7,3,25,1,'00:10:00',2654),(8,3,11,2,'00:02:00',273),(9,3,4,3,'00:02:00',273),(10,4,5,1,'00:09:00',2120),(11,4,11,2,'00:08:00',1965),(12,4,26,3,'00:02:00',1965),(13,5,7,1,'00:06:00',1233),(14,5,16,2,'00:03:00',233),(15,5,8,3,'00:03:00',233),(16,6,5,1,'00:04:00',565),(17,6,11,2,'00:18:00',2789),(18,6,26,3,'00:18:00',2789),(19,7,7,1,'00:44:00',10655),(20,7,9,2,'00:18:00',2789),(21,7,8,3,'00:18:00',2789),(22,8,7,1,'00:14:00',1523),(23,8,9,2,'00:08:00',512),(24,8,8,3,'00:08:00',512),(25,9,7,1,'00:44:00',10655),(26,9,9,2,'00:18:00',2789),(27,9,8,3,'00:18:00',2789),(28,10,12,1,'00:08:00',512),(29,10,20,2,'00:08:00',512),(30,10,12,3,'00:08:00',512);
/*!40000 ALTER TABLE `routestoplist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-19  2:48:39
