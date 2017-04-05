-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: lifematch
-- ------------------------------------------------------
-- Server version	5.7.9-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `user_info`
--

DROP TABLE IF EXISTS `user_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) NOT NULL,
  `email` varchar(30) DEFAULT NULL,
  `password` varchar(30) NOT NULL,
  `facebook_id` varchar(45) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  `country` varchar(45) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `about_user` varchar(250) DEFAULT NULL,
  `gender` enum('Male','Female') DEFAULT NULL,
  `partner_gender` enum('Male','Female') DEFAULT NULL,
  `partner_age_start` int(11) DEFAULT NULL,
  `partner_age_end` int(11) DEFAULT NULL,
  `about_partner` varchar(250) DEFAULT NULL,
  `create_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_info`
--

LOCK TABLES `user_info` WRITE;
/*!40000 ALTER TABLE `user_info` DISABLE KEYS */;
INSERT INTO `user_info` VALUES (1,'idoG','abc@efg.lom','123123','2','1982-02-12',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1982-02-12 21:15:00'),(2,'amirK','ert@efg.lom','321321','24','1986-02-12',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1986-02-12 21:15:00'),(3,'waseemK','sxx@efg.lom','pppppp','15','1988-02-12',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1988-02-12 21:15:00'),(4,'asznsazgn','sfgnsfgn','sfgnsfgn','','2012-01-01','zstgn','zsftgn','szfgn','Male','Female',20,30,'szfgnszfgn','2017-04-04 18:27:49'),(5,'asznsazgn','sfgnsfgn','sfgnsfgn','','2012-01-01','zstgn','zsftgn','szfgn','Male','Female',20,30,'szfgnszfgn','2017-04-04 20:25:55'),(6,'amirk','amirk55@yopmail.com','amir555','','1986-03-06','Israel','Haifa','sfgnsfmsfm','Male','Female',25,40,'dz adf fb','2017-04-04 20:32:07'),(7,'szfdgnartn','sfgnart','asngtagn','','1984-05-01','agn','agn','atgn','Male','Female',20,30,'asgn','2017-04-04 21:07:09'),(8,'ab','afb','arerfb','','1980-01-01','adb','adfb','adfb','Male','Female',20,30,'arrb','2017-04-04 21:11:22'),(9,'sdv','sdva','sdv','','1980-01-01','asdv','sadv','asddv','Male','Female',20,30,'sadba','2017-04-04 21:26:57'),(10,'asd','asd','asd','','1980-01-01','asd','asd','asd','Male','Female',20,30,'asd','2017-04-04 21:39:42'),(11,'asd','asd','asd','','1980-01-01','asd','asd','asd','Male','Female',20,30,'asd','2017-04-04 21:42:45'),(12,'asd','asd','asd','','1980-01-01','asd','asd','asd','Male','Female',20,30,'asd','2017-04-04 21:44:44'),(13,'amir','johnson','kubla555','','1981-02-05','Israel','Haifa','adfhbaerb','Male','Female',30,40,'ADSFbDRB','2017-04-05 17:02:42'),(14,'arg','aerg','aer','','1980-01-01','AERH','AERH','ARHB','Male','Female',20,30,'SRTNSTRBddd','2017-04-05 17:23:52'),(15,'arg','aerg','aer','','1980-01-01','AERH','AERH','ARHB','Male','Female',20,30,'SRTNSTRBddd','2017-04-05 17:31:28'),(16,'arg','aerg','aer','','1980-01-01','AERH','AERH','ARHB','Male','Female',20,30,'SRTNSTRBddd','2017-04-05 17:36:16'),(17,'arg','aerg','aer','','1980-01-01','AERH','AERH','ARHB','Male','Female',20,30,'SRTNSTRBddd','2017-04-05 17:45:44'),(18,'arg','aerg','aer','','1980-01-01','AERH','AERH','ARHB','Male','Female',20,30,'SRTNSTRBddd','2017-04-05 17:48:44'),(19,'dehas','astgnas','tgnasrgtn','','1980-01-01','sgn','sfgn','aszfgn','Male','Female',20,30,'sfzn','2017-04-05 17:49:42'),(20,'sdfb','adfb','ab','','1980-01-01','afhb','adfh','ah','Male','Female',20,30,'azdetj','2017-04-05 17:52:52'),(21,'fsxjn','sfrjsa','azh','','1980-01-01','szftj','szftj','zfgj','Male','Female',20,30,'zsfjj','2017-04-05 17:54:24'),(22,'sdxfvb','sdfb','SDb','','1982-01-01','fng','fgnfg','fgnfg','Male','Female',20,30,'sxdnsfgn','2017-04-05 18:40:30');
/*!40000 ALTER TABLE `user_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-05 19:26:37
