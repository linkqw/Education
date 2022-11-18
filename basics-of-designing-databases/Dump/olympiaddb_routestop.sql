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
-- Table structure for table `routestop`
--

DROP TABLE IF EXISTS `routestop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `routestop` (
  `stopId` int NOT NULL AUTO_INCREMENT,
  `stopName` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `stopLocation` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `pavilionPresence` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`stopId`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `routestop`
--

LOCK TABLES `routestop` WRITE;
/*!40000 ALTER TABLE `routestop` DISABLE KEYS */;
INSERT INTO `routestop` VALUES (1,'Лазурная Улица','Октябрьский р-н',1),(2,'Пригородный простор','Объ',0),(3,'Сокур','Мошково',0),(4,'Болотная','Новосибирская обл.',1),(5,'Инская','Первомайский р-н',1),(6,'Речной вокзал','Новосибирская обл.',1),(7,'Цветущая плющиха','Октябрьский р-н',0),(8,'Ботанический жилмассив','Заельцовский р-н',0),(9,'Улица Тюленина','Новосибирская обл.',1),(10,'Котельная','Советский р-н',0),(11,'Колыванская улица','Новосибирская обл.',0),(12,'Бугринская роща','Новосибирская обл.',1),(13,'Юго-Западный ж/м','Ленинский р-н',1),(14,'Улица Петухова','Новосибирская обл.',0),(15,'Метро Площадь Маркса','Новосибирская обл.',1),(16,'Северо-Чемской ж/м','Кировский р-н',0),(17,'Затулинский ж/м','Кировский р-н',0),(18,'Ленинградская Улица','Новосибирская обл.',1),(19,'Завод медпрепоратов','Новосибирская обл.',0),(20,'Горный','Мошково',0),(21,'Белово','Искитимский р-н',1),(22,'ТЭЦ-5','Октябрьский р-н',0),(23,'Диагностический центр','Новосибирская обл.',0),(24,'ПКиО Заельцовский','Заельцовский р-н',0),(25,'Новосибирск-Главный','Центральный р-н',1),(26,'Метро Речной вокзал','Новосибирская обл.',1);
/*!40000 ALTER TABLE `routestop` ENABLE KEYS */;
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
