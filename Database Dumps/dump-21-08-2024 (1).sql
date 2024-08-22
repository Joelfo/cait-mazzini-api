-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: cait_mazzini_app
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `alergies`
--

DROP TABLE IF EXISTS `alergies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alergies` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `baar_exams`
--

DROP TABLE IF EXISTS `baar_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `baar_exams` (
  `id` int NOT NULL,
  `isMaterialSputum` tinyint NOT NULL,
  `otherMaterial` text,
  `sampleNumber` int NOT NULL,
  `monthNumber` int NOT NULL,
  `result` int NOT NULL,
  `sputumAspect` int NOT NULL,
  `observations` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `biopsy_exams`
--

DROP TABLE IF EXISTS `biopsy_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `biopsy_exams` (
  `id` int NOT NULL,
  `analyzed_tissue` text NOT NULL,
  `result` text NOT NULL,
  `is_positive_result` tinyint NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `biopsy_exams_complementary_exams` FOREIGN KEY (`id`) REFERENCES `complementary_exams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `bladder_eliminations_info`
--

DROP TABLE IF EXISTS `bladder_eliminations_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bladder_eliminations_info` (
  `id` int NOT NULL AUTO_INCREMENT,
  `characteristics` text NOT NULL,
  `times_per_day` int NOT NULL,
  `has_pain` tinyint NOT NULL,
  `life_habits_info_int` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_bladder_eliminations_info_life_habits_info1_idx` (`life_habits_info_int`),
  CONSTRAINT `fk_bladder_eliminations_info_life_habits_info1` FOREIGN KEY (`life_habits_info_int`) REFERENCES `life_habits_infos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cities`
--

DROP TABLE IF EXISTS `cities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cities` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=70 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `clinical_histories`
--

DROP TABLE IF EXISTS `clinical_histories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clinical_histories` (
  `id` int NOT NULL AUTO_INCREMENT,
  `otherPreviousDeseases` text NOT NULL,
  `isAlergic` tinyint NOT NULL,
  `alergyObs` text,
  `hasPreviousSurgery` tinyint NOT NULL,
  `previousSurgeryObs` text,
  `hasPreviousHospitalizations` tinyint NOT NULL,
  `previousHospitalizationsObs` text,
  `timeFromLastHospitalization` text NOT NULL,
  `otherImmunizations` text,
  `patientId` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_clinical_histories_patient1_idx` (`patientId`),
  CONSTRAINT `fk_clinical_histories_patient1` FOREIGN KEY (`patientId`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=529 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `clinical_histories_has_dated_immunizations`
--

DROP TABLE IF EXISTS `clinical_histories_has_dated_immunizations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clinical_histories_has_dated_immunizations` (
  `clinicalHistoryId` int NOT NULL,
  `datedImmunizationId` int NOT NULL,
  `lastDoseDate` date NOT NULL,
  PRIMARY KEY (`clinicalHistoryId`,`datedImmunizationId`),
  KEY `dated_immunization_id` (`datedImmunizationId`),
  CONSTRAINT `dated_immunization_id` FOREIGN KEY (`datedImmunizationId`) REFERENCES `dated_immunizations` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `clinical_histories_has_immunizations`
--

DROP TABLE IF EXISTS `clinical_histories_has_immunizations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clinical_histories_has_immunizations` (
  `clinicalHistoryId` int NOT NULL,
  `immunizationId` int NOT NULL,
  PRIMARY KEY (`clinicalHistoryId`,`immunizationId`),
  KEY `fk_clinical_histories_has_Immunizations_Immunizations1_idx` (`immunizationId`),
  KEY `fk_clinical_histories_has_Immunizations_clinical_histories1_idx` (`clinicalHistoryId`),
  CONSTRAINT `fk_clinical_histories_has_Immunizations_clinical_histories1` FOREIGN KEY (`clinicalHistoryId`) REFERENCES `clinical_histories` (`id`),
  CONSTRAINT `fk_clinical_histories_has_Immunizations_Immunizations1` FOREIGN KEY (`immunizationId`) REFERENCES `immunizations` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `clinical_histories_has_previous_deseases`
--

DROP TABLE IF EXISTS `clinical_histories_has_previous_deseases`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clinical_histories_has_previous_deseases` (
  `clinicalHistoryId` int NOT NULL,
  `deseaseId` int NOT NULL,
  PRIMARY KEY (`clinicalHistoryId`,`deseaseId`),
  KEY `fk_clinical_histories_has_previous_deseases_desease_idx` (`deseaseId`),
  KEY `fk_clinical_histories_has_deseases_clinical_histories1_idx` (`clinicalHistoryId`),
  CONSTRAINT `fk_clinical_histories_has_previous_deseases_clinical_histories1` FOREIGN KEY (`clinicalHistoryId`) REFERENCES `clinical_histories` (`id`),
  CONSTRAINT `fk_clinical_histories_has_previous_deseases_deseases1` FOREIGN KEY (`deseaseId`) REFERENCES `deseases` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `clinical_history`
--

DROP TABLE IF EXISTS `clinical_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clinical_history` (
  `id` int NOT NULL AUTO_INCREMENT,
  `patient_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_clinical_history_patient1_idx` (`patient_id`),
  CONSTRAINT `fk_clinical_history_patient1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `complementary_exams`
--

DROP TABLE IF EXISTS `complementary_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `complementary_exams` (
  `id` int NOT NULL AUTO_INCREMENT,
  `observations` text,
  `date` date NOT NULL,
  `patient_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `complementary_exams_patients_idx` (`patient_id`),
  CONSTRAINT `complementary_exams_patients` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `contraceptive_methods`
--

DROP TABLE IF EXISTS `contraceptive_methods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contraceptive_methods` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `countries`
--

DROP TABLE IF EXISTS `countries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `countries` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cultures_exams`
--

DROP TABLE IF EXISTS `cultures_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cultures_exams` (
  `id` int NOT NULL,
  `is_positive_result` tinyint NOT NULL,
  `site` text NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `cultures_exams_complementary_exams` FOREIGN KEY (`id`) REFERENCES `complementary_exams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `dated_immunizations`
--

DROP TABLE IF EXISTS `dated_immunizations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dated_immunizations` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `deseases`
--

DROP TABLE IF EXISTS `deseases`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deseases` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `districts`
--

DROP TABLE IF EXISTS `districts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `districts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `cityId` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_district_city1_idx` (`cityId`),
  CONSTRAINT `fk_district_city1` FOREIGN KEY (`cityId`) REFERENCES `cities` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=207 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `exam_files`
--

DROP TABLE IF EXISTS `exam_files`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `exam_files` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `file_path` text NOT NULL,
  `name` text NOT NULL,
  `complementary_exam_id` int NOT NULL,
  PRIMARY KEY (`id`,`complementary_exam_id`),
  KEY `exam_files_complementary_exams_1_idx` (`complementary_exam_id`),
  CONSTRAINT `exam_files_complementary_exam` FOREIGN KEY (`complementary_exam_id`) REFERENCES `complementary_exams` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `federative_unities`
--

DROP TABLE IF EXISTS `federative_unities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `federative_unities` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text,
  `country_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ft_federative_unities_country1_idx` (`country_id`),
  CONSTRAINT `ft_federative_unities_country1` FOREIGN KEY (`country_id`) REFERENCES `countries` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `first_medical_appointment_charts`
--

DROP TABLE IF EXISTS `first_medical_appointment_charts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `first_medical_appointment_charts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `mainIssues` text NOT NULL,
  `drugsInUse` text,
  `requestedLaboratoryExams` text,
  `complementaryInfo` text,
  `conduct` text NOT NULL,
  `creatorId` int NOT NULL,
  `patientId` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_first_medical_appointment_charts_user_idx` (`creatorId`),
  KEY `fk_first_medical_appointment_charts_patients_idx` (`patientId`),
  CONSTRAINT `fk_first_medical_appointment_charts_patients` FOREIGN KEY (`patientId`) REFERENCES `patients` (`id`),
  CONSTRAINT `fk_first_medical_appointment_charts_user` FOREIGN KEY (`creatorId`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `first_nursery_appointment_charts`
--

DROP TABLE IF EXISTS `first_nursery_appointment_charts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `first_nursery_appointment_charts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `mainIssues` text NOT NULL,
  `drugsInUse` text,
  `complementaryInfo` text,
  `nurseryDiagnostic` text NOT NULL,
  `conduct` text NOT NULL,
  `patientId` int NOT NULL,
  `creatorId` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `patientId_UNIQUE` (`patientId`),
  KEY `FK_first_nursery_appointment_charts_user_idx` (`creatorId`),
  CONSTRAINT `first_nursery_appointment_charts_patients` FOREIGN KEY (`patientId`) REFERENCES `patients` (`id`),
  CONSTRAINT `FK_first_nursery_appointment_charts_user` FOREIGN KEY (`creatorId`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `first_nursery_chart`
--

DROP TABLE IF EXISTS `first_nursery_chart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `first_nursery_chart` (
  `id` int NOT NULL,
  `diagnostic` text,
  `conduct` text,
  `patient_id` int NOT NULL,
  `vital_signs_measurements_id` int NOT NULL AUTO_INCREMENT,
  `staff_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_first_nursery_chart_patient1_idx` (`patient_id`),
  KEY `fk_first_nursery_chart_vital_signs_measurements1_idx` (`vital_signs_measurements_id`),
  KEY `fk_first_nursery_chart_staff1_idx` (`staff_id`),
  CONSTRAINT `fk_first_nursery_chart_patient1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`),
  CONSTRAINT `fk_first_nursery_chart_staff1` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`id`),
  CONSTRAINT `fk_first_nursery_chart_vital_signs_measurements1` FOREIGN KEY (`vital_signs_measurements_id`) REFERENCES `vital_signs_measurements` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `health_unities`
--

DROP TABLE IF EXISTS `health_unities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `health_unities` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `igra_exams`
--

DROP TABLE IF EXISTS `igra_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `igra_exams` (
  `id` int NOT NULL,
  `isPositiveResult` tinyint NOT NULL,
  `material` text NOT NULL,
  `kit` text NOT NULL,
  `method` text NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `igra_exam_complementary_exam` FOREIGN KEY (`id`) REFERENCES `complementary_exams` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `image_exams`
--

DROP TABLE IF EXISTS `image_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `image_exams` (
  `id` int NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `image_exam_complementary_exam` FOREIGN KEY (`id`) REFERENCES `complementary_exams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `immunizations`
--

DROP TABLE IF EXISTS `immunizations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `immunizations` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `intestinal_eliminations`
--

DROP TABLE IF EXISTS `intestinal_eliminations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `intestinal_eliminations` (
  `id` int NOT NULL AUTO_INCREMENT,
  `characteristics` text NOT NULL,
  `times_per_day` int NOT NULL,
  `has_pain` int NOT NULL,
  `life_habits_info_int` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_intestinal_eliminations_life_habits_info1_idx` (`life_habits_info_int`),
  CONSTRAINT `fk_intestinal_eliminations_life_habits_info1` FOREIGN KEY (`life_habits_info_int`) REFERENCES `life_habits_infos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `life_habits_info`
--

DROP TABLE IF EXISTS `life_habits_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `life_habits_info` (
  `id` int NOT NULL AUTO_INCREMENT,
  `patientId` int NOT NULL,
  `mealsPerDay` int NOT NULL,
  `waterCupsPerDay` int NOT NULL,
  `eatingAndWaterObs` text,
  `bladderEliminationsCharacteristic` text NOT NULL,
  `bladderEliminationTimesPerDay` int NOT NULL,
  `hasPainOnBladderEliminations` tinyint NOT NULL,
  `intestinalEliminationsCharacteristic` text NOT NULL,
  `intestinalEliminationTimesPerDay` int NOT NULL,
  `hasPainOnIntestinalEliminations` tinyint NOT NULL,
  `isAlcoholUser` tinyint NOT NULL,
  `alcoholQuantityObs` text,
  `isSmoker` tinyint NOT NULL,
  `cigarretesPerDay` int DEFAULT NULL,
  `formerSmoker` tinyint NOT NULL,
  `timeWithoutSmoking` text,
  `usesIllicitDrugs` tinyint NOT NULL,
  `IllicitDrugsUsingObs` text,
  `hasSatisfactorySleepingTime` tinyint NOT NULL,
  `sleepingHoursPerNight` int NOT NULL,
  `sleepingTimeObs` text,
  `physicalActivitiesObservation` text,
  `leisureObservation` text,
  `sexualActivityLevel` int NOT NULL,
  `hasPrEP` tinyint NOT NULL,
  `hasPEP` tinyint NOT NULL,
  `sexualPartnersQuantity` int NOT NULL,
  `usesPreservative` tinyint DEFAULT NULL,
  `physicalActivityTimesPerWeek` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_life_habits_info_patient2_idx` (`patientId`),
  CONSTRAINT `fk_life_habits_info_patient2` FOREIGN KEY (`patientId`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=143 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `life_habits_info_has_contraceptive_methods`
--

DROP TABLE IF EXISTS `life_habits_info_has_contraceptive_methods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `life_habits_info_has_contraceptive_methods` (
  `lifeHabitsInfoId` int NOT NULL,
  `contraceptiveMethodId` int NOT NULL,
  PRIMARY KEY (`lifeHabitsInfoId`,`contraceptiveMethodId`),
  KEY `fk_life_habits_info_has_contraceptive_methods_contraceptive_idx` (`contraceptiveMethodId`),
  KEY `fk_life_habits_info_has_contraceptive_methods_life_habits_i_idx` (`lifeHabitsInfoId`),
  CONSTRAINT `fk_life_habits_info_has_contraceptive_methods_contraceptive_m1` FOREIGN KEY (`contraceptiveMethodId`) REFERENCES `contraceptive_methods` (`id`),
  CONSTRAINT `fk_life_habits_info_has_contraceptive_methods_life_habits_info1` FOREIGN KEY (`lifeHabitsInfoId`) REFERENCES `life_habits_info` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `life_habits_info_has_physical_activities`
--

DROP TABLE IF EXISTS `life_habits_info_has_physical_activities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `life_habits_info_has_physical_activities` (
  `lifeHabitsInfoId` int NOT NULL,
  `physicalActivitiesId` int NOT NULL,
  PRIMARY KEY (`lifeHabitsInfoId`,`physicalActivitiesId`),
  KEY `fk_life_habits_info_has_physical_activities_physical_activi_idx` (`physicalActivitiesId`),
  KEY `fk_life_habits_info_has_physical_activities_life_habits_inf_idx` (`lifeHabitsInfoId`),
  CONSTRAINT `fk_life_habits_info_has_physical_activities_life_habits_info1` FOREIGN KEY (`lifeHabitsInfoId`) REFERENCES `life_habits_info` (`id`),
  CONSTRAINT `fk_life_habits_info_has_physical_activities_physical_activiti1` FOREIGN KEY (`physicalActivitiesId`) REFERENCES `physical_activities` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `life_habits_infos`
--

DROP TABLE IF EXISTS `life_habits_infos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `life_habits_infos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `sexual_habitual_level` enum('Ativa','Eventual','Inexistente') NOT NULL,
  `partners_quantity` int DEFAULT NULL,
  `uses_preservative` tinyint NOT NULL,
  `uses_prep` tinyint NOT NULL,
  `uses_contraceptive_method` tinyint NOT NULL,
  `sexual_habits_observation` text,
  `has_satisfying_sleeping` tinyint NOT NULL,
  `sleeping_hours_per_night` int NOT NULL,
  `meals_per_day` int NOT NULL,
  `water_cups_per_day` int NOT NULL,
  `eating_and_water_observation` text,
  `patient_id` int NOT NULL,
  `leisure_time_observation` text,
  PRIMARY KEY (`id`),
  KEY `fk_life_habits_info_patient1_idx` (`patient_id`),
  CONSTRAINT `fk_life_habits_info_patient1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `other_exams`
--

DROP TABLE IF EXISTS `other_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `other_exams` (
  `id` int NOT NULL,
  `name` text NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `other_exam_complementary_exam` FOREIGN KEY (`id`) REFERENCES `complementary_exams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `patient_exams`
--

DROP TABLE IF EXISTS `patient_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient_exams` (
  `id` int NOT NULL AUTO_INCREMENT,
  `file_path` text,
  `file_type` text,
  `patient_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_patient_exams_patient1_idx` (`patient_id`),
  CONSTRAINT `fk_patient_exams_patient1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `patient_has_alergies`
--

DROP TABLE IF EXISTS `patient_has_alergies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient_has_alergies` (
  `alergies_id` int NOT NULL,
  `clinical_history_id` int NOT NULL,
  PRIMARY KEY (`alergies_id`,`clinical_history_id`),
  KEY `fk_patient_has_alergies_alergies1_idx` (`alergies_id`),
  KEY `fk_patient_has_alergies_clinical_history1_idx` (`clinical_history_id`),
  CONSTRAINT `fk_patient_has_alergies_alergies1` FOREIGN KEY (`alergies_id`) REFERENCES `alergies` (`id`),
  CONSTRAINT `fk_patient_has_alergies_clinical_history1` FOREIGN KEY (`clinical_history_id`) REFERENCES `clinical_history` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `patient_has_deseases`
--

DROP TABLE IF EXISTS `patient_has_deseases`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient_has_deseases` (
  `deseases_id` int NOT NULL,
  `clinical_history_id` int NOT NULL,
  PRIMARY KEY (`deseases_id`,`clinical_history_id`),
  KEY `fk_patient_has_deseases_deseases1_idx` (`deseases_id`),
  KEY `fk_patient_has_deseases_clinical_history1_idx` (`clinical_history_id`),
  CONSTRAINT `fk_patient_has_deseases_clinical_history1` FOREIGN KEY (`clinical_history_id`) REFERENCES `clinical_history` (`id`),
  CONSTRAINT `fk_patient_has_deseases_deseases1` FOREIGN KEY (`deseases_id`) REFERENCES `deseases` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `patient_has_immunization`
--

DROP TABLE IF EXISTS `patient_has_immunization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient_has_immunization` (
  `immunizations_id` int NOT NULL,
  `clinical_history_id` int NOT NULL,
  PRIMARY KEY (`immunizations_id`,`clinical_history_id`),
  KEY `fk_immunizations_has_patient_immunizations1_idx` (`immunizations_id`),
  KEY `fk_patient_has_immunization_clinical_history1_idx` (`clinical_history_id`),
  CONSTRAINT `fk_immunizations_has_patient_immunizations1` FOREIGN KEY (`immunizations_id`) REFERENCES `immunizations` (`id`),
  CONSTRAINT `fk_patient_has_immunization_clinical_history1` FOREIGN KEY (`clinical_history_id`) REFERENCES `clinical_history` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patients` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  `recordCode` varchar(10) NOT NULL,
  `susCard` varchar(15) NOT NULL,
  `rg` varchar(15) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `admissionDate` datetime NOT NULL,
  `type` int NOT NULL,
  `arrivalType` int NOT NULL,
  `telephone1` varchar(14) NOT NULL,
  `telephone2` varchar(14) DEFAULT NULL,
  `cep` varchar(9) NOT NULL,
  `birthDate` datetime NOT NULL,
  `motherName` text NOT NULL,
  `birthplaceId` int NOT NULL,
  `districtId` int NOT NULL,
  `healthUnityId` int DEFAULT NULL,
  `biologicalGender` int NOT NULL,
  `addressStreet` text NOT NULL,
  `isPregnant` tinyint NOT NULL,
  `addressNumber` int DEFAULT NULL,
  `addressComplement` text,
  `specialPopulationType` int NOT NULL,
  `otherSpecialPopulation` text,
  PRIMARY KEY (`id`),
  UNIQUE KEY `sus_card_UNIQUE` (`susCard`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`),
  UNIQUE KEY `rg_UNIQUE` (`rg`),
  UNIQUE KEY `record_code_UNIQUE` (`recordCode`),
  KEY `fk_patient_healthUnity1_idx` (`healthUnityId`),
  KEY `fk_patient_district1_idx` (`districtId`),
  KEY `fk_patient_federativeUnity1_idx` (`birthplaceId`),
  CONSTRAINT `fk_patient_district1` FOREIGN KEY (`districtId`) REFERENCES `districts` (`id`),
  CONSTRAINT `fk_patient_federativeUnity1` FOREIGN KEY (`birthplaceId`) REFERENCES `federative_unities` (`id`),
  CONSTRAINT `fk_patient_healthUnity1` FOREIGN KEY (`healthUnityId`) REFERENCES `health_unities` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=190 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `patients_appointment_line`
--

DROP TABLE IF EXISTS `patients_appointment_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patients_appointment_line` (
  `patientId` int NOT NULL,
  `order` int NOT NULL,
  PRIMARY KEY (`patientId`),
  UNIQUE KEY `order_UNIQUE` (`order`),
  CONSTRAINT `patients_appointment_line_patients` FOREIGN KEY (`patientId`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pcr_exams`
--

DROP TABLE IF EXISTS `pcr_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pcr_exams` (
  `id` int NOT NULL,
  `is_positive_result` tinyint NOT NULL,
  `method` text NOT NULL,
  `material` text NOT NULL,
  `kit` text NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `pcr_exams_complementary_exams` FOREIGN KEY (`id`) REFERENCES `complementary_exams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `physical_activities`
--

DROP TABLE IF EXISTS `physical_activities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `physical_activities` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=347 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `physical_exams`
--

DROP TABLE IF EXISTS `physical_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `physical_exams` (
  `id` int NOT NULL AUTO_INCREMENT,
  `generalAspect` text,
  `hygieneConditionsObs` text,
  `headObs` text,
  `neckObs` text,
  `chestObs` text,
  `abdomenObs` text,
  `mmssMmiiObs` text,
  `urinaryTrackObs` text,
  `skinAndMucousObs` text,
  `patientId` int NOT NULL,
  `date` date NOT NULL,
  `type` int NOT NULL,
  `creatorId` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_physical_exam_patient1_idx` (`patientId`),
  KEY `fk_physical_exam_user_idx` (`creatorId`),
  CONSTRAINT `fk_physical_exam_patient1` FOREIGN KEY (`patientId`) REFERENCES `patients` (`id`),
  CONSTRAINT `fk_physical_exam_user` FOREIGN KEY (`creatorId`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=464 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pnt_appointments`
--

DROP TABLE IF EXISTS `pnt_appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pnt_appointments` (
  `patient_id` int NOT NULL,
  `appointment_type` text NOT NULL,
  `id` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`),
  KEY `patient_id` (`patient_id`),
  CONSTRAINT `pnt_appointments_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ppd_exams`
--

DROP TABLE IF EXISTS `ppd_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ppd_exams` (
  `id` int NOT NULL,
  `is_reactive_result` tinyint NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `ppd_exams_complementary_exams` FOREIGN KEY (`id`) REFERENCES `complementary_exams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `previous_hospitalizations`
--

DROP TABLE IF EXISTS `previous_hospitalizations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `previous_hospitalizations` (
  `id` int NOT NULL AUTO_INCREMENT,
  `reason` text NOT NULL,
  `time_passed` text NOT NULL,
  `clinical_history_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_previous_hospitalizations_clinical_history1_idx` (`clinical_history_id`),
  CONSTRAINT `fk_previous_hospitalizations_clinical_history1` FOREIGN KEY (`clinical_history_id`) REFERENCES `clinical_history` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `previous_surgeries`
--

DROP TABLE IF EXISTS `previous_surgeries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `previous_surgeries` (
  `id` int NOT NULL AUTO_INCREMENT,
  `reason` text,
  `clinical_history_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_previous_surgeries_clinical_history1_idx` (`clinical_history_id`),
  CONSTRAINT `fk_previous_surgeries_clinical_history1` FOREIGN KEY (`clinical_history_id`) REFERENCES `clinical_history` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `relapse`
--

DROP TABLE IF EXISTS `relapse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `relapse` (
  `id` int NOT NULL AUTO_INCREMENT,
  `reason` text,
  `patient_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_relapse_patient1_idx` (`patient_id`),
  CONSTRAINT `fk_relapse_patient1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `release`
--

DROP TABLE IF EXISTS `release`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `release` (
  `id` int NOT NULL AUTO_INCREMENT,
  `six_months_flag` tinyint NOT NULL,
  `reason` enum('CURA','ABANDONO','NOVO DIAGNOSTICO','OBITO') NOT NULL COMMENT 'Values:\n0 = "CURA"\n1 = "ABANDONO"\n',
  `aditional_info` text,
  `patient_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_release_patient1_idx` (`patient_id`),
  CONSTRAINT `fk_release_patient1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `scanned_charts_metadata`
--

DROP TABLE IF EXISTS `scanned_charts_metadata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `scanned_charts_metadata` (
  `id` int NOT NULL AUTO_INCREMENT,
  `file_path` text NOT NULL,
  `patient_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `special_populations`
--

DROP TABLE IF EXISTS `special_populations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `special_populations` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `id` int NOT NULL AUTO_INCREMENT,
  `cpf` varchar(14) NOT NULL,
  `email` varchar(255) NOT NULL,
  `name` text NOT NULL,
  `role` enum('secretario','admin','enfermeiro','médico','farmacêutico') NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `substances_used_info`
--

DROP TABLE IF EXISTS `substances_used_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `substances_used_info` (
  `id` int NOT NULL AUTO_INCREMENT,
  `substance` enum('Cigarro','Alcool','Drogas Ilícitas') NOT NULL,
  `quantity_observation` text NOT NULL,
  `observation` text,
  `life_habits_info_int` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_substances_used_info_life_habits_info1_idx` (`life_habits_info_int`),
  CONSTRAINT `fk_substances_used_info_life_habits_info1` FOREIGN KEY (`life_habits_info_int`) REFERENCES `life_habits_infos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_appointments`
--

DROP TABLE IF EXISTS `tb_appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_appointments` (
  `id` int NOT NULL AUTO_INCREMENT,
  `appointment_type` text NOT NULL,
  `patient_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `patient_id_idx` (`patient_id`),
  CONSTRAINT `patient` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_tracking_appointment_charts`
--

DROP TABLE IF EXISTS `tb_tracking_appointment_charts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_tracking_appointment_charts` (
  `id` bigint NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `id` FOREIGN KEY (`id`) REFERENCES `tracking_appointment_charts` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `torax_x_ray_exams`
--

DROP TABLE IF EXISTS `torax_x_ray_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `torax_x_ray_exams` (
  `id` int NOT NULL,
  `x_ray_result` int NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `torax_x_ray_exams_complementary_exams1` FOREIGN KEY (`id`) REFERENCES `complementary_exams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tracking_appointment_charts`
--

DROP TABLE IF EXISTS `tracking_appointment_charts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tracking_appointment_charts` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `evolution` text NOT NULL,
  `conduct` text NOT NULL,
  `date` date NOT NULL,
  `schema` text NOT NULL,
  `type` int NOT NULL,
  `patientId` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `patient_id_idx` (`patientId`),
  CONSTRAINT `patient_id` FOREIGN KEY (`patientId`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tracking_charts_has_patient_exams`
--

DROP TABLE IF EXISTS `tracking_charts_has_patient_exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tracking_charts_has_patient_exams` (
  `tracking_charts_id` bigint NOT NULL,
  `patient_exams_id` int NOT NULL,
  PRIMARY KEY (`tracking_charts_id`,`patient_exams_id`),
  KEY `fk_tracking_charts_has_patient_exams_patient_exams1_idx` (`patient_exams_id`),
  KEY `fk_tracking_charts_has_patient_exams_tracking_charts1_idx` (`tracking_charts_id`),
  CONSTRAINT `fk_tracking_charts_has_patient_exams_patient_exams1` FOREIGN KEY (`patient_exams_id`) REFERENCES `patient_exams` (`id`),
  CONSTRAINT `fk_tracking_charts_has_patient_exams_tracking_charts1` FOREIGN KEY (`tracking_charts_id`) REFERENCES `tracking_appointment_charts` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tubercolosis_ocurrence`
--

DROP TABLE IF EXISTS `tubercolosis_ocurrence`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tubercolosis_ocurrence` (
  `id` int NOT NULL AUTO_INCREMENT,
  `type` enum('Pulmonar','Extrapulmonar') NOT NULL,
  `dateObservation` text,
  `patient_previous_hospitalizations_id` int NOT NULL,
  `patient_life_habits_info_int` int NOT NULL,
  `patient_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_tubercolosis_ocurrence_patient1_idx` (`patient_id`),
  CONSTRAINT `fk_tubercolosis_ocurrence_patient1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `role` int NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `hashed_password` text NOT NULL,
  `email` text NOT NULL,
  `name` text NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `vital_signs_measurements`
--

DROP TABLE IF EXISTS `vital_signs_measurements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vital_signs_measurements` (
  `id` int NOT NULL AUTO_INCREMENT,
  `mmhgPa` text NOT NULL,
  `bpmFc` decimal(5,2) NOT NULL,
  `irpmFr` decimal(5,2) NOT NULL,
  `celsiusTax` decimal(5,2) NOT NULL,
  `oxygenSaturationPercentage` decimal(5,2) NOT NULL,
  `kgWeight` decimal(5,2) NOT NULL,
  `mHeight` decimal(4,2) NOT NULL,
  `patientId` int NOT NULL,
  `measurementDateTime` datetime NOT NULL,
  `vital_signs_measurementscol` varchar(45) DEFAULT NULL,
  `mgdlHgt` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-08-21 21:28:45
