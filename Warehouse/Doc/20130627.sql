CREATE DATABASE  IF NOT EXISTS `warehouse` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `warehouse`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: warehouse
-- ------------------------------------------------------
-- Server version	5.5.25

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
-- Table structure for table `my_aspnet_users`
--

DROP TABLE IF EXISTS `my_aspnet_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `applicationId` int(11) NOT NULL,
  `name` varchar(256) NOT NULL,
  `isAnonymous` tinyint(1) NOT NULL DEFAULT '1',
  `lastActivityDate` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_users`
--

LOCK TABLES `my_aspnet_users` WRITE;
/*!40000 ALTER TABLE `my_aspnet_users` DISABLE KEYS */;
INSERT INTO `my_aspnet_users` VALUES (7,1,'adminstrator',0,'2013-06-27 20:15:26'),(9,1,'班长1',0,'2013-06-15 16:24:43'),(10,1,'班长2',0,'2013-06-27 21:18:44'),(11,1,'入库员1',0,'2013-06-24 20:03:33'),(12,1,'入库员2',0,'2013-06-27 20:27:32'),(13,1,'gjz',0,'2013-06-23 15:31:23'),(14,1,'gjz测试',0,'2013-06-25 21:03:01'),(15,1,'7777777',0,'2013-06-25 21:01:35'),(16,1,'入库1',0,'2013-06-23 15:34:43'),(17,1,'入库2',0,'2013-06-23 15:39:52'),(18,1,'gjz2',0,'2013-06-25 21:09:36');
/*!40000 ALTER TABLE `my_aspnet_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_warehouse`
--

DROP TABLE IF EXISTS `t_warehouse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_warehouse` (
  `WarehouseID` int(11) NOT NULL AUTO_INCREMENT,
  `BarCode` varchar(50) DEFAULT NULL,
  `TwoDimensioncodeID` int(11) DEFAULT NULL,
  `WarehouseTime` datetime NOT NULL,
  `StateID` int(11) NOT NULL,
  `Place` varchar(100) DEFAULT NULL,
  `PutInUserName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`WarehouseID`),
  KEY `FK_TwoDimensiionCode_T_Warehouse_idx` (`TwoDimensioncodeID`),
  CONSTRAINT `FK_TwoDimensiionCode_T_Warehouse` FOREIGN KEY (`TwoDimensioncodeID`) REFERENCES `t_ twodimensioncode` (`TwoDimensioncodeID`) ON DELETE SET NULL ON UPDATE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_warehouse`
--

LOCK TABLES `t_warehouse` WRITE;
/*!40000 ALTER TABLE `t_warehouse` DISABLE KEYS */;
INSERT INTO `t_warehouse` VALUES (79,'6956416200029',60,'2013-06-27 20:32:29',1,'111','入库员2');
/*!40000 ALTER TABLE `t_warehouse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_alarm`
--

DROP TABLE IF EXISTS `t_alarm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_alarm` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `AlarmTime` datetime NOT NULL,
  `AlarmContent` varchar(200) DEFAULT NULL,
  `AlarmTypeInt` int(11) NOT NULL,
  `Operator` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_alarm`
--

LOCK TABLES `t_alarm` WRITE;
/*!40000 ALTER TABLE `t_alarm` DISABLE KEYS */;
INSERT INTO `t_alarm` VALUES (1,'2013-06-23 17:05:12','当前出库数量已经大于设置的出库数量',2,''),(2,'2013-06-23 17:10:12','当前出库数量已经大于设置的出库数量',2,''),(3,'2013-06-23 17:10:50','当前出库数量已经大于设置的出库数量',2,''),(4,'2013-06-23 18:36:31','变速箱型号不一致',2,''),(5,'2013-06-23 18:37:43','变速箱型号不一致',2,''),(6,'2013-06-23 18:38:30','变速箱型号不一致',2,''),(7,'2013-06-23 18:39:40','变速箱型号不一致',2,''),(8,'2013-06-23 18:40:48','变速箱型号不一致',2,''),(9,'2013-06-23 18:41:35','当前出库数量已经大于设置的出库数量',2,''),(10,'2013-06-23 18:41:56','当前出库数量已经大于设置的出库数量',2,''),(11,'2013-06-23 18:52:46','变速箱型号不一致',2,''),(12,'2013-06-23 18:53:00','变速箱型号不一致',2,''),(13,'2013-06-23 19:03:46','变速箱型号不一致',2,''),(14,'2013-06-23 19:04:48','变速箱型号不一致',2,'入库员1'),(15,'2013-06-23 19:05:06','变速箱型号不一致',2,'入库员1'),(16,'2013-06-23 19:05:27','变速箱型号不一致',2,'入库员1'),(17,'2013-06-24 19:54:48','变速箱型号不一致',2,'入库员1'),(18,'2013-06-24 19:55:28','变速箱型号不一致',2,'入库员1'),(19,'2013-06-24 20:52:48','当前出库数量已经大于设置的出库数量',2,'入库员2'),(20,'2013-06-24 20:53:47','当前出库数量已经大于设置的出库数量',2,'入库员2'),(21,'2013-06-25 20:17:01','当前出库数量已经大于设置的出库数量',2,'入库员2'),(22,'2013-06-25 20:18:50','当前出库数量已经大于设置的出库数量',2,'入库员2'),(23,'2013-06-25 20:30:40','当前出库数量已经大于设置的出库数量',2,'入库员2'),(24,'2013-06-25 20:30:56','当前出库数量已经大于设置的出库数量',2,'入库员2');
/*!40000 ALTER TABLE `t_alarm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_removalwarehouserecord`
--

DROP TABLE IF EXISTS `t_removalwarehouserecord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_removalwarehouserecord` (
  `RemovalWarehourseRecordID` int(11) NOT NULL AUTO_INCREMENT,
  `WarehouseID` int(11) DEFAULT NULL,
  `StateID` int(11) NOT NULL,
  `RemovalWarehouseTime` datetime NOT NULL,
  `OrderID` int(11) NOT NULL,
  `SpeedChangeBoxName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`RemovalWarehourseRecordID`),
  KEY `FK_Warehouse_T_RemovalWarehourseRecord_idx` (`WarehouseID`),
  KEY `FK_T_RemovalWarehouseOrder_T_RemovalWarehouseRecord_idx` (`OrderID`),
  CONSTRAINT `FK_T_RemovalWarehouseRecord_T_RemovalWarehouseOrder` FOREIGN KEY (`OrderID`) REFERENCES `t_removalwarehouseorder` (`OrderID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `FK_T_Warehouse_T_RemovalWarehouse` FOREIGN KEY (`WarehouseID`) REFERENCES `t_warehouse` (`WarehouseID`) ON DELETE SET NULL ON UPDATE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_removalwarehouserecord`
--

LOCK TABLES `t_removalwarehouserecord` WRITE;
/*!40000 ALTER TABLE `t_removalwarehouserecord` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_removalwarehouserecord` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_schemaversion`
--

DROP TABLE IF EXISTS `my_aspnet_schemaversion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_schemaversion` (
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_schemaversion`
--

LOCK TABLES `my_aspnet_schemaversion` WRITE;
/*!40000 ALTER TABLE `my_aspnet_schemaversion` DISABLE KEYS */;
INSERT INTO `my_aspnet_schemaversion` VALUES (7);
/*!40000 ALTER TABLE `my_aspnet_schemaversion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_ twodimensioncode`
--

DROP TABLE IF EXISTS `t_ twodimensioncode`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_ twodimensioncode` (
  `TwoDimensioncodeID` int(11) NOT NULL AUTO_INCREMENT,
  `TwoDimensionCodeNum` varchar(500) NOT NULL,
  `Count` int(11) NOT NULL,
  `SpeedChangeBoxTypeID` int(11) DEFAULT NULL,
  `StateID` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`TwoDimensioncodeID`),
  KEY `FK_T_SpeedChangeBoxType_T_ TwoDimensionCode_idx` (`SpeedChangeBoxTypeID`),
  CONSTRAINT `FK_T_SpeedChangeBoxType_T_ TwoDimensionCode` FOREIGN KEY (`SpeedChangeBoxTypeID`) REFERENCES `t_speedchangeboxtype` (`SpeedChangeBoxTypeID`) ON DELETE SET NULL ON UPDATE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_ twodimensioncode`
--

LOCK TABLES `t_ twodimensioncode` WRITE;
/*!40000 ALTER TABLE `t_ twodimensioncode` DISABLE KEYS */;
INSERT INTO `t_ twodimensioncode` VALUES (60,'6956416200029?49bc0553-43f1-4af5-ad4c-186f9cb4d372',1,4,1);
/*!40000 ALTER TABLE `t_ twodimensioncode` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_profiles`
--

DROP TABLE IF EXISTS `my_aspnet_profiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_profiles` (
  `userId` int(11) NOT NULL,
  `valueindex` longtext,
  `stringdata` longtext,
  `binarydata` longblob,
  `lastUpdatedDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_profiles`
--

LOCK TABLES `my_aspnet_profiles` WRITE;
/*!40000 ALTER TABLE `my_aspnet_profiles` DISABLE KEYS */;
/*!40000 ALTER TABLE `my_aspnet_profiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_applications`
--

DROP TABLE IF EXISTS `my_aspnet_applications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_applications` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(256) DEFAULT NULL,
  `description` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_applications`
--

LOCK TABLES `my_aspnet_applications` WRITE;
/*!40000 ALTER TABLE `my_aspnet_applications` DISABLE KEYS */;
INSERT INTO `my_aspnet_applications` VALUES (1,'/','MySQL default application');
/*!40000 ALTER TABLE `my_aspnet_applications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_removalwarehouseorder`
--

DROP TABLE IF EXISTS `t_removalwarehouseorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_removalwarehouseorder` (
  `OrderID` int(11) NOT NULL AUTO_INCREMENT,
  `Staff` varchar(50) DEFAULT NULL,
  `DispathPlace` varchar(100) DEFAULT NULL,
  `DispathTime` datetime NOT NULL,
  `StateID` int(11) NOT NULL,
  `SpeedChangeBoxName` varchar(50) DEFAULT NULL,
  `PlanCount` int(11) NOT NULL,
  PRIMARY KEY (`OrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_removalwarehouseorder`
--

LOCK TABLES `t_removalwarehouseorder` WRITE;
/*!40000 ALTER TABLE `t_removalwarehouseorder` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_removalwarehouseorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_sessions`
--

DROP TABLE IF EXISTS `my_aspnet_sessions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_sessions` (
  `SessionId` varchar(255) NOT NULL,
  `ApplicationId` int(11) NOT NULL,
  `Created` datetime NOT NULL,
  `Expires` datetime NOT NULL,
  `LockDate` datetime NOT NULL,
  `LockId` int(11) NOT NULL,
  `Timeout` int(11) NOT NULL,
  `Locked` tinyint(1) NOT NULL,
  `SessionItems` longblob,
  `Flags` int(11) NOT NULL,
  PRIMARY KEY (`SessionId`,`ApplicationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_sessions`
--

LOCK TABLES `my_aspnet_sessions` WRITE;
/*!40000 ALTER TABLE `my_aspnet_sessions` DISABLE KEYS */;
/*!40000 ALTER TABLE `my_aspnet_sessions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_speedchangeboxtype`
--

DROP TABLE IF EXISTS `t_speedchangeboxtype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_speedchangeboxtype` (
  `SpeedChangeBoxTypeID` int(11) NOT NULL AUTO_INCREMENT,
  `SpeedChangeBoxName` varchar(50) NOT NULL,
  PRIMARY KEY (`SpeedChangeBoxTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_speedchangeboxtype`
--

LOCK TABLES `t_speedchangeboxtype` WRITE;
/*!40000 ALTER TABLE `t_speedchangeboxtype` DISABLE KEYS */;
INSERT INTO `t_speedchangeboxtype` VALUES (1,'QR512MHA'),(2,'69317'),(3,'9'),(4,'6'),(5,'1');
/*!40000 ALTER TABLE `t_speedchangeboxtype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_roles`
--

DROP TABLE IF EXISTS `my_aspnet_roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_roles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `applicationId` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_roles`
--

LOCK TABLES `my_aspnet_roles` WRITE;
/*!40000 ALTER TABLE `my_aspnet_roles` DISABLE KEYS */;
INSERT INTO `my_aspnet_roles` VALUES (1,1,'入库员'),(2,1,'出库员'),(3,1,'班长'),(4,1,'系统管理员');
/*!40000 ALTER TABLE `my_aspnet_roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_usersinfo`
--

DROP TABLE IF EXISTS `my_aspnet_usersinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_usersinfo` (
  `ID` int(11) NOT NULL,
  `Phone` varchar(11) DEFAULT NULL,
  `Adress` varchar(100) DEFAULT NULL,
  `DepartmentID` int(11) DEFAULT NULL,
  `StateID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Department_UserInfo_idx` (`DepartmentID`),
  CONSTRAINT `FK_Department_UserInfo` FOREIGN KEY (`DepartmentID`) REFERENCES `my_aspnet_department` (`DepartmentID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_usersinfo`
--

LOCK TABLES `my_aspnet_usersinfo` WRITE;
/*!40000 ALTER TABLE `my_aspnet_usersinfo` DISABLE KEYS */;
INSERT INTO `my_aspnet_usersinfo` VALUES (7,'','222',5,1),(8,NULL,'111',2,1),(9,'','444',2,1),(10,'13621242807','',2,1),(11,'','地方撒啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊撒地方地方地方地方地方地方地方地方地方地方地',2,2),(12,NULL,'',2,1),(13,NULL,'邓州市，构林镇',2,1),(14,'13621242807','邓州市，构林镇',2,1),(15,'13051993639','邓州市，构林镇',4,1),(16,NULL,'',4,1),(17,NULL,'',4,1),(18,'11111111111','11111',2,1);
/*!40000 ALTER TABLE `my_aspnet_usersinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_sessioncleanup`
--

DROP TABLE IF EXISTS `my_aspnet_sessioncleanup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_sessioncleanup` (
  `LastRun` datetime NOT NULL,
  `IntervalMinutes` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_sessioncleanup`
--

LOCK TABLES `my_aspnet_sessioncleanup` WRITE;
/*!40000 ALTER TABLE `my_aspnet_sessioncleanup` DISABLE KEYS */;
INSERT INTO `my_aspnet_sessioncleanup` VALUES ('2013-06-10 11:40:52',10);
/*!40000 ALTER TABLE `my_aspnet_sessioncleanup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_usersinroles`
--

DROP TABLE IF EXISTS `my_aspnet_usersinroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_usersinroles` (
  `userId` int(11) NOT NULL DEFAULT '0',
  `roleId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`userId`,`roleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_usersinroles`
--

LOCK TABLES `my_aspnet_usersinroles` WRITE;
/*!40000 ALTER TABLE `my_aspnet_usersinroles` DISABLE KEYS */;
INSERT INTO `my_aspnet_usersinroles` VALUES (7,4),(9,1),(9,2),(9,3),(10,1),(10,2),(10,3),(11,1),(12,1),(12,2),(13,1),(13,2),(13,3),(15,1),(15,2),(15,3),(16,1),(17,1);
/*!40000 ALTER TABLE `my_aspnet_usersinroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_membership`
--

DROP TABLE IF EXISTS `my_aspnet_membership`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_membership` (
  `userId` int(11) NOT NULL DEFAULT '0',
  `Email` varchar(128) DEFAULT NULL,
  `Comment` varchar(255) DEFAULT NULL,
  `Password` varchar(128) NOT NULL,
  `PasswordKey` char(32) DEFAULT NULL,
  `PasswordFormat` tinyint(4) DEFAULT NULL,
  `PasswordQuestion` varchar(255) DEFAULT NULL,
  `PasswordAnswer` varchar(255) DEFAULT NULL,
  `IsApproved` tinyint(1) DEFAULT NULL,
  `LastActivityDate` datetime DEFAULT NULL,
  `LastLoginDate` datetime DEFAULT NULL,
  `LastPasswordChangedDate` datetime DEFAULT NULL,
  `CreationDate` datetime DEFAULT NULL,
  `IsLockedOut` tinyint(1) DEFAULT NULL,
  `LastLockedOutDate` datetime DEFAULT NULL,
  `FailedPasswordAttemptCount` int(10) unsigned DEFAULT NULL,
  `FailedPasswordAttemptWindowStart` datetime DEFAULT NULL,
  `FailedPasswordAnswerAttemptCount` int(10) unsigned DEFAULT NULL,
  `FailedPasswordAnswerAttemptWindowStart` datetime DEFAULT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='2';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_membership`
--

LOCK TABLES `my_aspnet_membership` WRITE;
/*!40000 ALTER TABLE `my_aspnet_membership` DISABLE KEYS */;
INSERT INTO `my_aspnet_membership` VALUES (1,NULL,'','v79iT/FII5fsRJr4j7fLutc4YzrO9UitGMuvpAPXEQ8=','7XhbEnM2xTEctyZSgXVjjA==',1,NULL,NULL,1,'2013-06-10 12:40:53','2013-06-10 12:40:53','2013-06-10 12:40:53','2013-06-10 12:40:53',0,'2013-06-10 12:40:53',0,'2013-06-10 12:40:53',0,'2013-06-10 12:40:53'),(2,NULL,'','g/bBdhPBReTna9fM+Cd4z48+JgtvdV/tHi46tUNS26s=','a8pt3pIoCJwaCPtPHQFdDw==',1,NULL,NULL,1,'2013-06-13 22:28:36','2013-06-13 22:28:36','2013-06-13 22:28:36','2013-06-13 22:28:36',0,'2013-06-13 22:28:36',0,'2013-06-13 22:28:36',0,'2013-06-13 22:28:36'),(3,NULL,'','H0OoAaLUAg1vPHaSLsYmTIYowUDFqFvEBRwPG3e6OwE=','ppPcsw579Fmp0G4jD+DMqg==',1,NULL,NULL,1,'2013-06-13 22:29:12','2013-06-13 22:29:12','2013-06-13 22:29:12','2013-06-13 22:29:12',0,'2013-06-13 22:29:12',0,'2013-06-13 22:29:12',0,'2013-06-13 22:29:12'),(4,NULL,'','NA6wkMmjmbrJmxoSsS94E0+Tan8L5NcI0RZVfVfxjHE=','2eUZLYe6qt9lWVmhr/fzbA==',1,NULL,NULL,1,'2013-06-15 12:25:28','2013-06-15 12:25:28','2013-06-13 22:33:02','2013-06-13 22:33:02',0,'2013-06-13 22:33:02',0,'2013-06-13 22:33:02',0,'2013-06-13 22:33:02'),(5,NULL,'','a+39mvq7qel/y8TFSHNuwsw9ybt7Et7NvYfQnujJud4=','uNnXaAiqVak9a9gHtH+z5g==',1,NULL,NULL,1,'2013-06-15 11:07:45','2013-06-15 11:07:45','2013-06-15 11:07:45','2013-06-15 11:07:45',0,'2013-06-15 11:07:45',0,'2013-06-15 11:07:45',0,'2013-06-15 11:07:45'),(6,NULL,'','JGrTqSMZwsW2nHhCuqBuwSDKPW6nqbzO5tbRvTJefDI=','80E/+zLX//RYjZgDh2Ta1A==',1,NULL,NULL,1,'2013-06-15 11:15:15','2013-06-15 11:15:15','2013-06-15 11:15:15','2013-06-15 11:15:15',0,'2013-06-15 11:15:15',0,'2013-06-15 11:15:15',0,'2013-06-15 11:15:15'),(7,NULL,'','9zek6hlbCnOuVnnycQqxqwcJZIg0kRg/Ls8ThTDZL/A=','SpgDh5p6nj8ceuB0IixFDQ==',1,NULL,NULL,1,'2013-06-27 20:15:26','2013-06-27 20:15:26','2013-06-22 14:56:28','2013-06-15 12:34:51',0,'2013-06-15 12:34:51',1,'2013-06-25 20:57:13',0,'2013-06-15 12:34:51'),(9,NULL,'','hJNOIwHO80XrNtur5YmbAyCAwCwC1+3Q+hs6TQImquQ=','JB1ahXabynAGdqqyNS80Ng==',1,NULL,NULL,1,'2013-06-15 16:24:43','2013-06-15 16:24:43','2013-06-15 16:24:43','2013-06-15 16:24:43',0,'2013-06-15 16:24:43',0,'2013-06-15 16:24:43',0,'2013-06-15 16:24:43'),(10,NULL,'','sIFGXcRhb3KZSVJjeTNM/DZ6iat5LxNdZ0fAJ42amG8=','SnJRegWBier8zeyvEKj1aQ==',1,NULL,NULL,1,'2013-06-27 21:18:44','2013-06-27 21:18:44','2013-06-24 20:11:53','2013-06-15 16:33:16',0,'2013-06-15 16:33:16',1,'2013-06-27 20:56:25',0,'2013-06-15 16:33:16'),(11,NULL,'','QtjhibyxL/0zxxMQbL0Jqd6WI3vZqgKqIuH+7kMKr44=','+sebrZMqrvHJFNC7J1E6nQ==',1,NULL,NULL,0,'2013-06-24 20:03:33','2013-06-24 20:03:33','2013-06-15 16:38:56','2013-06-15 16:38:56',0,'2013-06-15 16:38:56',1,'2013-06-27 20:17:17',0,'2013-06-15 16:38:56'),(12,NULL,'','dWvrEMgof70f+sVUDDIWnLCKugWPROsB7c32bd0kp0E=','pgp1mo4wQZ5Tt+TmWYMfOg==',1,NULL,NULL,1,'2013-06-27 20:27:32','2013-06-27 20:27:32','2013-06-23 12:46:27','2013-06-23 12:46:27',0,'2013-06-23 12:46:27',2,'2013-06-27 20:27:24',0,'2013-06-23 12:46:27'),(13,NULL,'','q7uWtPksqgue4pM4hh2OPtWKWs5nnDsHGgBrJoKhT3w=','wTdm6v33vrqVHbzmd7mGiw==',1,NULL,NULL,1,'2013-06-23 15:31:23','2013-06-23 15:31:23','2013-06-23 15:09:10','2013-06-23 15:09:10',0,'2013-06-23 15:09:10',0,'2013-06-23 15:09:10',0,'2013-06-23 15:09:10'),(14,NULL,'','6/waY36DqXNNmKllP7iizIuiFVkbQqDzDYUIleBXhH8=','JZfgj1/ceYd1fNgRlNhjoA==',1,NULL,NULL,1,'2013-06-25 21:03:01','2013-06-25 21:03:01','2013-06-25 21:03:01','2013-06-23 15:12:11',0,'2013-06-23 15:12:11',0,'2013-06-23 15:12:11',0,'2013-06-23 15:12:11'),(15,NULL,'','eu1lkuIpTwOD83FLBKXI0Uj5kT2h/VJiQThOfgEz4to=','AD4y35T3tybjA4GwjtlgZQ==',1,NULL,NULL,1,'2013-06-25 21:01:35','2013-06-25 21:01:35','2013-06-25 21:01:35','2013-06-23 15:33:11',0,'2013-06-23 15:33:11',0,'2013-06-23 15:33:11',0,'2013-06-23 15:33:11'),(16,NULL,'','EC4MTtRCIqKY2EW2kNwbDXs0M/78doOj+0GBfpNdSnw=','9bfnYbJCdC7rwJ3RtbqRXg==',1,NULL,NULL,1,'2013-06-23 15:35:03','2013-06-23 15:35:03','2013-06-23 15:35:03','2013-06-23 15:35:03',0,'2013-06-23 15:35:03',0,'2013-06-23 15:35:03',0,'2013-06-23 15:35:03'),(17,NULL,'','OqWVejsxsW7j8q3piphqIAzDAsLlGG4KiLYaCyVet3g=','eESwI+cTDQdWM/i2Qn7okA==',1,NULL,NULL,1,'2013-06-23 15:40:12','2013-06-23 15:40:12','2013-06-23 15:40:12','2013-06-23 15:40:12',0,'2013-06-23 15:40:12',0,'2013-06-23 15:40:12',0,'2013-06-23 15:40:12'),(18,NULL,'','pVTcve5/bIU8CgxyPRIrbozeIRyCZxz76sQ8dMzkBc4=','fphL8Ky2fdOaH9Li1+JTCg==',1,NULL,NULL,1,'2013-06-25 21:09:36','2013-06-25 21:09:36','2013-06-25 21:09:36','2013-06-25 21:09:36',0,'2013-06-25 21:09:36',0,'2013-06-25 21:09:36',0,'2013-06-25 21:09:36');
/*!40000 ALTER TABLE `my_aspnet_membership` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_department`
--

DROP TABLE IF EXISTS `my_aspnet_department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_department` (
  `DepartmentID` int(11) NOT NULL AUTO_INCREMENT,
  `DepartmentName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`DepartmentID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_department`
--

LOCK TABLES `my_aspnet_department` WRITE;
/*!40000 ALTER TABLE `my_aspnet_department` DISABLE KEYS */;
INSERT INTO `my_aspnet_department` VALUES (2,'44'),(3,'4'),(4,'7'),(5,'系统管理');
/*!40000 ALTER TABLE `my_aspnet_department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_putinwarehouserecord`
--

DROP TABLE IF EXISTS `t_putinwarehouserecord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_putinwarehouserecord` (
  `PutInWarehouseRecordID` int(11) NOT NULL AUTO_INCREMENT,
  `PutInTime` datetime NOT NULL,
  `Place` varchar(100) DEFAULT NULL,
  `WarehouseID` int(11) DEFAULT NULL,
  `StateID` int(11) NOT NULL,
  `PutInUserName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PutInWarehouseRecordID`),
  KEY `FK_T_Warehouse_t_putinwarehouserecord_idx` (`WarehouseID`),
  CONSTRAINT `FK_T_Warehouse_t_putinwarehouserecord` FOREIGN KEY (`WarehouseID`) REFERENCES `t_warehouse` (`WarehouseID`) ON DELETE SET NULL ON UPDATE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=91 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_putinwarehouserecord`
--

LOCK TABLES `t_putinwarehouserecord` WRITE;
/*!40000 ALTER TABLE `t_putinwarehouserecord` DISABLE KEYS */;
INSERT INTO `t_putinwarehouserecord` VALUES (90,'2013-06-27 20:32:29','111',79,1,'入库员2');
/*!40000 ALTER TABLE `t_putinwarehouserecord` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-06-27 21:29:26
