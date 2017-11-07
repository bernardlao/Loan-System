-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: db_loanmanagement
-- ------------------------------------------------------
-- Server version	5.6.21-log

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
-- Dumping data for table `tblcontracts`
--

LOCK TABLES `tblcontracts` WRITE;
/*!40000 ALTER TABLE `tblcontracts` DISABLE KEYS */;
INSERT INTO `tblcontracts` VALUES (1,1,'2016-03-14','2016-03-28',0.03,10000,3433.33,'2016-03-14',3,'Weekly',0.01,'Daily',10300,'Finished','No'),(2,1,'2016-03-14','2016-04-11',0.05,11000,2310,'2016-03-14',5,'Weekly',0.01,'Daily',11550,'Active','No'),(3,2,'2016-03-15','2016-03-15',0,1000,1000,'2016-03-15',1,'Weekly',0,'Daily',1000,'Canceled','No'),(4,2,'2016-03-15','2016-03-15',0,1000,1000,'2016-03-15',1,'Weekly',0,'Daily',1000,'Canceled','No'),(5,2,'2016-03-15','2016-03-15',0,100,100,'2016-03-15',1,'Weekly',0,'Daily',100,'Finished','No'),(6,2,'2016-03-15','2016-03-15',0,200,200,'2016-03-15',1,'Weekly',0,'Daily',200,'Finished','Yes'),(8,2,'2016-03-18','2016-04-01',0.01,1000,336.67,'2016-03-18',3,'Weekly',0.01,'Per Duedate',1010,'Canceled','No'),(9,2,'2016-03-18','2016-04-01',0.01,1000,336.67,'2016-03-18',3,'Weekly',0,'Daily',1010,'Canceled','No'),(10,2,'2016-03-18','2016-03-18',0.01,1000,1010,'2016-03-18',1,'Weekly',0,'Daily',1010,'Canceled','No'),(11,2,'2016-03-18','2016-03-18',0.01,1000,1010,'2016-03-18',1,'Weekly',0,'Daily',1010,'Canceled','No'),(12,2,'2016-03-18','2016-03-18',0.01,1000,1010,'2016-03-18',1,'Weekly',0,'Daily',1010,'Canceled','No'),(13,2,'2016-03-18','2016-03-18',0.01,1000,1010,'2016-03-18',1,'Monthly',0.01,'Daily',1010,'Canceled','No'),(14,2,'2016-03-18','2016-03-18',0.01,1000,1010,'2016-03-18',1,'Monthly',0.01,'Per Duedate',1010,'Canceled','No'),(15,2,'2016-03-18','2016-03-18',0.01,1000,1010,'2016-03-18',1,'Monthly',0.01,'Per Duedate',1010,'Canceled','No'),(16,2,'2016-03-19','2016-03-19',0.01,1000,1010,'2016-03-19',1,'Monthly',0.01,'Per Duedate',1010,'Finished','No'),(17,2,'2016-12-21','2017-02-22',0.01,2000,202,'2016-12-21',10,'Weekly',0,'Daily',2020,'Active','Yes');
/*!40000 ALTER TABLE `tblcontracts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblcustomer`
--

LOCK TABLES `tblcustomer` WRITE;
/*!40000 ALTER TABLE `tblcustomer` DISABLE KEYS */;
INSERT INTO `tblcustomer` VALUES (1,'Bernard','Lao','Herrera','Malabon City','Male','1993-09-28','09100528101','1.png','Bernard Herrera Lao','Active',78695),(2,'Reymond','Lao','Herrera','Malabon City','Male','1992-10-19','123345567','2.png','Reymond Herrera Lao','Active',2020);
/*!40000 ALTER TABLE `tblcustomer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblpayments`
--

LOCK TABLES `tblpayments` WRITE;
/*!40000 ALTER TABLE `tblpayments` DISABLE KEYS */;
INSERT INTO `tblpayments` VALUES (1,1,1,'2016-03-14',3433.33,'Advanced payment due to new contract signing'),(2,1,2,'2016-03-14',3433.33,'Advanced payment due to new contract signing'),(3,1,3,'2016-03-14',3433.33,'Advanced payment due to new contract signing'),(4,2,4,'2016-03-15',1000,'Ordinary Payment'),(5,5,11,'2016-03-15',100,'Advanced payment due to new contract signing'),(6,6,12,'2016-03-15',200,'Ordinary Payment'),(7,16,28,'2016-12-21',10.1,'Advanced payment due to new contract signing');
/*!40000 ALTER TABLE `tblpayments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblschedules`
--

LOCK TABLES `tblschedules` WRITE;
/*!40000 ALTER TABLE `tblschedules` DISABLE KEYS */;
INSERT INTO `tblschedules` VALUES (1,1,'2016-03-14',3433.33,0,3433.33,'Yes','Done'),(2,1,'2016-03-21',3433.33,0,3433.33,'Yes','Done'),(3,1,'2016-03-28',3433.33,0,3433.33,'Yes','Done'),(4,2,'2016-03-14',2310,13952.4,1000,'No','Pending'),(5,2,'2016-03-21',2310,13790.7,0,'No','Pending'),(6,2,'2016-03-28',2310,13629,0,'No','Pending'),(7,2,'2016-04-04',2310,13467.3,0,'No','Pending'),(8,2,'2016-04-11',2310,13305.6,0,'No','Pending'),(9,3,'2016-03-15',1000,0,0,'No','Canceled'),(10,4,'2016-03-15',1000,0,0,'No','Canceled'),(11,5,'2016-03-15',100,0,100,'Yes','Done'),(12,6,'2016-03-15',200,0,200,'Yes','Done'),(16,8,'2016-03-18',336.67,0,0,'No','Canceled'),(17,8,'2016-03-25',336.67,0,0,'No','Canceled'),(18,8,'2016-04-01',336.67,0,0,'No','Canceled'),(19,9,'2016-03-18',336.67,0,0,'No','Canceled'),(20,9,'2016-03-25',336.67,0,0,'No','Canceled'),(21,9,'2016-04-01',336.67,0,0,'No','Canceled'),(22,10,'2016-03-18',1010,0,0,'No','Canceled'),(23,11,'2016-03-18',1010,0,0,'No','Canceled'),(24,12,'2016-03-18',1010,0,0,'No','Canceled'),(25,13,'2016-03-18',1010,0,0,'No','Canceled'),(26,14,'2016-03-18',1010,0,0,'No','Canceled'),(27,15,'2016-03-18',1010,0,0,'No','Canceled'),(28,16,'2016-03-19',1010,10.1,10.1,'Yes','Done'),(29,17,'2016-12-21',202,0,0,'No','Pending'),(30,17,'2016-12-28',202,0,0,'No','Pending'),(31,17,'2017-01-04',202,0,0,'No','Pending'),(32,17,'2017-01-11',202,0,0,'No','Pending'),(33,17,'2017-01-18',202,0,0,'No','Pending'),(34,17,'2017-01-25',202,0,0,'No','Pending'),(35,17,'2017-02-01',202,0,0,'No','Pending'),(36,17,'2017-02-08',202,0,0,'No','Pending'),(37,17,'2017-02-15',202,0,0,'No','Pending'),(38,17,'2017-02-22',202,0,0,'No','Pending');
/*!40000 ALTER TABLE `tblschedules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbluser`
--

LOCK TABLES `tbluser` WRITE;
/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
INSERT INTO `tbluser` VALUES (1,'s','s',3820.1);
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_loanmanagement'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-08  1:46:15
