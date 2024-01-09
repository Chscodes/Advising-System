-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2021 at 09:13 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_advisng`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_adviser`
--

CREATE TABLE `tbl_adviser` (
  `col_Username` varchar(20) NOT NULL,
  `col_Pass` varchar(20) NOT NULL,
  `col_Name` varchar(50) NOT NULL,
  `col_Birthday` date NOT NULL,
  `col_Age` int(3) NOT NULL,
  `col_Gender` varchar(10) NOT NULL,
  `col_coreP1` int(4) NOT NULL,
  `col_corep2` int(4) NOT NULL,
  `col_verCode` varchar(10) NOT NULL,
  `col_email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_adviser`
--

INSERT INTO `tbl_adviser` (`col_Username`, `col_Pass`, `col_Name`, `col_Birthday`, `col_Age`, `col_Gender`, `col_coreP1`, `col_corep2`, `col_verCode`, `col_email`) VALUES
('VC', 'vccc', 'vc', '1988-12-26', 33, 'Male', 3123, 21312, '2021_3086', ''),
('VC2', 'sdada', 'dsadsad', '1988-12-26', 33, 'Male', 4234, 43543, '2021_3086', ''),
('sana ok na lahat', 'dadsad', 'saba', '2000-02-02', 21, 'Female', 32432, 5435, '2021_3086', ''),
('ano un', 'dsadad', 'dsada', '2000-02-02', 21, 'Female', 42342, 52434, '2021_3086', ''),
('testing', 'command', 'recovery', '2001-02-23', 20, 'Male', 909, 9090, '2021_3086', 'chesterclenn02232gmail.com'),
('kapoy na jd', 'plsss lang btaw', 'recovery2', '2000-04-05', 21, 'Female', 11111, 22222, '2021_3086', 'gwapokokaayo287@gmail.com'),
('yes', 'sana', 'chesterww', '2001-02-23', 20, 'Male', 2323, 3232, '2021_0426', 'chesterclenn0223@gmail.com'),
('test34', 'comannnn', 'chestere', '2000-02-23', 21, 'Male', 2323, 3232, '2021_3086', 'chesterclenn0223@gmail.com'),
('gmail', '1234', 'gmail error', '2000-02-01', 21, 'Female', 3232, 2323, '2021_8452', 'chshlasl2323@gmail.com'),
('gmail1', 'chsha', 'chesss', '1999-12-29', 22, 'Male', 34242, 12321, '2021_2221', 'gdqydwq2gmail.com'),
('3243', 'weqwe', 'cascas', '2000-02-01', 21, 'Female', 2323, 4213, '2021_0051', 'sacsacas42341'),
('sanaa', 'sssss', 'errrr', '2001-02-28', 20, 'Female', 4321, 1234, '2021_0472', 'chesterclenn0223@gmail.com'),
('324432422', 'asdad', 'eqwewqe', '2000-02-23', 21, 'Female', 4234, 23432, '2021_7438', 'chesterclenn0223@gmail.com'),
('gsgagag', '3212312', '1232143', '2000-02-01', 21, 'Female', 3212, 3231, '2021_7378', 'chesterclenn0223@gmail.com'),
('yes1', '111', 'ches', '2021-10-26', 0, 'Male', 1, 0, '2021_4458', 'chesterclenn0223@gmail.com'),
('', '', '', '2001-02-23', 0, '', 0, 0, '', ''),
('', '', '', '2001-02-23', 0, '', 0, 0, '', ''),
('chestah', '123', 'Chester Clenn Minoza', '2000-02-01', 21, 'Male', 1212, 0, '2021_6014', 'chesterclenn0223@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_grades`
--

CREATE TABLE `tbl_grades` (
  `col_ID` int(11) NOT NULL,
  `col_studentID` varchar(20) NOT NULL,
  `col_subcode` varchar(50) NOT NULL,
  `col_grades` varchar(4) NOT NULL,
  `col_yrLvl` varchar(50) NOT NULL,
  `col_Sem` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_grades`
--

INSERT INTO `tbl_grades` (`col_ID`, `col_studentID`, `col_subcode`, `col_grades`, `col_yrLvl`, `col_Sem`) VALUES
(860, '44', 'PE3', 'INC', '', ''),
(861, '55', 'PE1', '2', '', ''),
(862, '55', 'PE2', '3', '', ''),
(863, '55', 'PE3', '2', '', ''),
(882, '1', 'ITFUND', 'Fail', 'First Year', 'First Semester'),
(883, '1', 'KOMFIL', '1', 'First Year', 'First Semester'),
(884, '1', 'LEAD1', '1', 'First Year', 'First Semester'),
(885, '1', 'MATWRLD', '1', 'First Year', 'First Semester'),
(886, '1', 'NSTP1', '1', 'First Year', 'First Semester'),
(887, '1', 'PE1', '1', 'First Year', 'First Semester'),
(888, '1', 'PHILHIS', '1', 'First Year', 'First Semester'),
(889, '1', 'PURPCOMM', '1', 'First Year', 'First Semester'),
(890, '1', 'UNDSELF', '1', 'First Year', 'First Semester'),
(891, '1', 'CONWRLD', '1', 'First Year', 'Second Semester'),
(892, '1', 'ETHICS', '1', 'First Year', 'Second Semester'),
(893, '1', 'HCI1', '1', 'First Year', 'Second Semester'),
(894, '1', 'LEAD2', '1', 'First Year', 'Second Semester'),
(895, '1', 'NSTP2', '1', 'First Year', 'Second Semester'),
(896, '1', 'PE2', '1', 'First Year', 'Second Semester'),
(897, '1', 'PROG1', '1', 'First Year', 'Second Semester'),
(898, '1', 'PSPEAK', '1', 'First Year', 'Second Semester'),
(899, '1', 'SCITECH', '1', 'First Year', 'Second Semester'),
(900, '1', 'ANVID', '1', 'Second Year', 'First Semester'),
(901, '1', 'ENVSCI', '1', 'Second Year', 'First Semester'),
(902, '1', 'IPTECH1', '1', 'Second Year', 'First Semester'),
(903, '1', 'LEAD3', '1', 'Second Year', 'First Semester'),
(904, '1', 'NET1', '1', 'Second Year', 'First Semester'),
(905, '1', 'PE3', '1', 'Second Year', 'First Semester'),
(906, '1', 'PLATECH', '1', 'Second Year', 'First Semester'),
(907, '1', 'PROG2', '1', 'Second Year', 'First Semester'),
(908, '1', 'APPDEV', '1', 'Second Year', 'Second Semester'),
(909, '1', 'DBMS', '1', 'Second Year', 'Second Semester'),
(910, '1', 'DSTRUCT', '1', 'Second Year', 'Second Semester'),
(911, '1', 'LEAD4', '1', 'Second Year', 'Second Semester'),
(912, '1', 'OOP', '1', 'Second Year', 'Second Semester'),
(913, '1', 'PE4', '1', 'Second Year', 'Second Semester'),
(914, '1', 'SOSLIT', '3', 'Second Year', 'Second Semester'),
(915, '1', 'SYSARCH1', '1', 'Second Year', 'Second Semester'),
(916, '1', 'ARTAPP', '2.7', 'Third Year', 'First Semester'),
(917, '1', 'BASCMOB', '1', 'Third Year', 'First Semester'),
(918, '1', 'DMATH', '1', 'Third Year', 'First Semester'),
(919, '1', 'INFOMGT', '1', 'Third Year', 'First Semester'),
(920, '1', 'IPTECH2', '1', 'Third Year', 'First Semester'),
(921, '1', 'LEAD5', '1', 'Third Year', 'First Semester'),
(922, '1', 'NET2', '1', 'Third Year', 'First Semester'),
(923, '1', 'SYSARCH2', '1', 'Third Year', 'First Semester'),
(924, '1', 'ADVMOB', '1', 'Third Year', 'Second Semester'),
(925, '1', 'ARCHORG', '3', 'Third Year', 'Second Semester'),
(926, '1', 'CAPSTONE1', 'Fail', 'Third Year', 'Second Semester'),
(927, '1', 'INFOSEC1', 'INC', 'Third Year', 'Second Semester'),
(928, '1', 'LEAD6', '1', 'Third Year', 'Second Semester'),
(929, '1', 'QMTHODS', '', 'Third Year', 'Second Semester'),
(930, '1', 'RIZAL', '', 'Third Year', 'Second Semester'),
(931, '1', 'WEBSYS', '', 'Third Year', 'Second Semester'),
(932, '2', 'pe1', '3', '', ''),
(951, '2', 'CONWRLD', '', 'First Year', 'Second Semester'),
(952, '2', 'ETHICS', '', 'First Year', 'Second Semester'),
(953, '22', 'CONWRLD', '', 'First Year', 'Second Semester'),
(954, '22', 'ETHICS', '', 'First Year', 'Second Semester'),
(955, '22', 'HCI1', '', 'First Year', 'Second Semester'),
(956, '2019-05-00201', 'ITFUND', '1', 'First Year', 'First Semester'),
(957, '2019-05-00201', 'KOMFIL', '1.6', 'First Year', 'First Semester'),
(958, '2019-05-00201', 'LEAD1', '3', 'First Year', 'First Semester'),
(959, '2019-05-00201', 'MATWRLD', 'INC', 'First Year', 'First Semester'),
(960, '2019-05-00201', 'NSTP1', 'INC', 'First Year', 'First Semester'),
(961, '2019-05-00201', 'PE1', '1', 'First Year', 'First Semester'),
(962, '2019-05-00201', 'PHILHIS', '2', 'First Year', 'First Semester'),
(963, '2019-05-00201', 'PURPCOMM', '1', 'First Year', 'First Semester'),
(964, '2019-05-00201', 'UNDSELF', '1', 'First Year', 'First Semester'),
(965, '2019-05-00201', 'CONWRLD', '', 'First Year', 'Second Semester'),
(966, '2019-05-00201', 'ETHICS', '', 'First Year', 'Second Semester'),
(967, '2019-05-00201', 'HCI1', '', 'First Year', 'Second Semester'),
(968, '2019-05-00201', 'LEAD2', '', 'First Year', 'Second Semester'),
(969, '2019-05-00201', 'PROG1', '', 'First Year', 'Second Semester'),
(970, '2019-05-00201', 'PSPEAK', '', 'First Year', 'Second Semester'),
(971, '2019-05-00201', 'SCITECH', '', 'First Year', 'Second Semester'),
(972, '2019-05-00201', 'PE2', '', 'First Year', 'Second Semester'),
(973, '2019-05-00201', 'NSTP1', '', 'First Year', 'Second Semester');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_history`
--

CREATE TABLE `tbl_history` (
  `DATE` datetime NOT NULL DEFAULT current_timestamp(),
  `Description` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_history`
--

INSERT INTO `tbl_history` (`DATE`, `Description`) VALUES
('2021-11-21 15:07:14', 'Adviser \'yes\' advised the student \'STU\' (\'2020\')!'),
('2021-11-21 16:39:49', 'Adviser \'YES\' advised student \'TRANSFEREE\' (\'22\') in the \'First Semester\' of \'First Semester\''),
('2021-11-22 00:05:22', 'Adviser \'YES\' advised student \'\' (\'\') in the \'\' of \'\''),
('2021-11-22 00:19:18', 'Adviser \'YES\' advised student \'\' (\'\') in the \'\' of \'\''),
('2021-11-22 14:15:37', 'Adviser \'YES\' advised student \'TRANSFEREE\' (\'22\') in the \'Second Semester\' of \'First Year\''),
('2021-11-22 14:48:38', 'Adviser \'CHESTAH\' ADDED a new subject \'EX\' at the \'FIRST SEMESTER\' of \'FIRST YEAR\''),
('2021-11-22 14:49:34', 'Adviser \'CHESTAH\' UPDATED the subject \'EX\' at the \'FIRST SEMESTER\' of \'FIRST YEAR\''),
('2021-11-22 14:49:47', 'Adviser \'CHESTAH\' DELETED the subject \'EX\' at the \'FIRST SEMESTER\' of \'FIRST YEAR\''),
('2021-11-22 14:51:27', 'Adviser \'CHESTAH\' ADDED new \'Regular\' student named \'JAYROLD\' (\'2019-00-0000\')'),
('2021-11-22 15:06:01', 'Adviser \'CHESTAH\' ADDED a new subject \'EXAM\' at the \'FIRST SEMESTER\' of \'FIRST YEAR\''),
('2021-11-22 15:06:43', 'Adviser \'CHESTAH\' UPDATED the subject \'EXAM\' at the \'FIRST SEMESTER\' of \'FIRST YEAR\''),
('2021-11-22 15:07:13', 'Adviser \'CHESTAH\' DELETED the subject \'EXAM\' at the \'FIRST SEMESTER\' of \'FIRST YEAR\''),
('2021-11-22 15:08:42', 'Adviser \'CHESTAH\' ADDED new \'\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:09:12', 'Adviser \'CHESTAH\' UPDATED an information of a \'Regular\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:09:38', 'Adviser \'CHESTAH\' DELETED the information of a \'\' student named \'STU\' (\'2020\')'),
('2021-11-22 15:12:05', 'Adviser \'CHESTAH\' advised student \'CHRISTIAN KYLE\' (\'2019-05-00201\') in the \'First Semester\' of \'First Year\''),
('2021-11-22 15:12:34', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:12:41', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:12:48', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:13:00', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:13:07', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:13:14', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:13:21', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:13:28', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:13:35', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:13:51', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:14:57', 'Adviser \'CHESTAH\' GRADED a \'REGULAR\' student named \'CHRISTIAN KYLE\' (\'2019-05-00201\')'),
('2021-11-22 15:15:32', 'Adviser \'CHESTAH\' advised student \'CHRISTIAN KYLE\' (\'2019-05-00201\') in the \'Second Semester\' of \'First Year\''),
('2021-11-22 15:21:37', 'Adviser \'CHESTAH\' UPDATED an information of a \'Irregular\' student named \'CHESTER CLENN\' (\'2019-05-00203\')'),
('2021-11-22 15:44:26', 'Adviser \'YES\' ADDED new \'Irregular\' student named \'DASDSA\' (\'3123\')'),
('2021-11-22 15:44:34', 'Adviser \'YES\' DELETED the information of a \'\' student named \'DASDSA\' (\'3123\')');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_prspctus`
--

CREATE TABLE `tbl_prspctus` (
  `col_ID` int(11) NOT NULL,
  `col_Name` int(11) NOT NULL,
  `col_YearLevel` int(11) NOT NULL,
  `col_Grade` int(11) NOT NULL,
  `col_SCode` int(11) NOT NULL,
  `col_STitle` int(11) NOT NULL,
  `col_Units` int(11) NOT NULL,
  `col_PreR` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_student`
--

CREATE TABLE `tbl_student` (
  `col_StudID` varchar(50) NOT NULL,
  `col_Fname` varchar(50) DEFAULT NULL,
  `col_Lname` varchar(50) DEFAULT NULL,
  `col_MN` varchar(30) DEFAULT NULL,
  `col_cNum` bigint(15) DEFAULT NULL,
  `col_add` varchar(100) DEFAULT NULL,
  `col_sex` varchar(6) NOT NULL,
  `col_type` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_student`
--

INSERT INTO `tbl_student` (`col_StudID`, `col_Fname`, `col_Lname`, `col_MN`, `col_cNum`, `col_add`, `col_sex`, `col_type`) VALUES
('1', 'regular', 'fresh', 'gggg', 98765423, 'jsjsjsjsj', 'Male', 'Regular'),
('123', 'test', 'ltest', 'test', 2121212, 'bulcan', 'Female', 'Irregular'),
('2', 'transferee', 'trass', 'transss', 7837827382, 'bulacan', 'Male', 'Transferee'),
('2019-00-0000', 'Jayrold', 'Laguyo', 'Esteban', 9239765114, 'Bernavie sa Tandang Sorapala yun', 'Male', 'Regular'),
('2019-05-00201', 'Christian Kyle', 'Villafuerte', 'Esteban', 9876265442, 'si Bernavie na taga Tandang sora 23 pala', 'Male', 'Irregular'),
('2019-05-00203', 'Chester Clenn', 'Minoza', 'Abrantes', 9239765114, '23A Balubad Alley Balingasa Quezon City', 'Male', 'Transferee'),
('2021', 'www', 'sadas', 'eeeee', 923444423232, 'kjsjsjsjsjsjsjs', 'Female', 'Irregular');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_subject`
--

CREATE TABLE `tbl_subject` (
  `col_subcode` varchar(50) NOT NULL,
  `col_subTitle` varchar(50) NOT NULL,
  `col_Units` float DEFAULT NULL,
  `col_lab` int(4) NOT NULL,
  `col_lec` float DEFAULT NULL,
  `col_PreRequisite` varchar(50) NOT NULL,
  `col_yrLvl` varchar(50) NOT NULL,
  `col_Sem` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_subject`
--

INSERT INTO `tbl_subject` (`col_subcode`, `col_subTitle`, `col_Units`, `col_lab`, `col_lec`, `col_PreRequisite`, `col_yrLvl`, `col_Sem`) VALUES
('ADVMOB', 'Advance of Mobile Computing', 3, 1, 2, 'BASCMOB', 'Third Year', 'Second Semester'),
('ANVID', 'Animation and Editing Videos', 3, 1, 2, 'None', 'Second Year', 'First Semester'),
('APPDEV', 'Application Development and Emerging Technologies', 3, 1, 2, 'PROG2', 'Second Year', 'Second Semester'),
('ARCHORG', 'Computer Architecture and Organization', 3, 1, 2, 'DMATH', 'Third Year', 'Second Semester'),
('ARTAPP', 'Art Appreciation', 3, 0, 3, 'None', 'Third Year', 'First Semester'),
('BASCMOB', 'Basic Mobile Computing', 3, 1, 2, 'OOP', 'Third Year', 'First Semester'),
('BUSANA', 'Business Analytics', 3, 0, 3, 'None', 'Fourth Year', 'First Semester'),
('CAPSTONE1', 'Capstone Project and Research 1', 3, 1, 2, 'SYSARCH2', 'Third Year', 'Second Semester'),
('CAPSTONE2', 'Capstone Project and Research 2', 3, 1, 2, 'Capstone1', 'Fourth Year', 'First Semester'),
('CONWRLD', 'The Contemporary World', 3, 0, 3, 'None', 'First Year', 'Second Semester'),
('DBMS', 'Databse Managment System', 3, 1, 2, 'None', 'Second Year', 'Second Semester'),
('DMATH', 'Discrete Mathematics', 3, 0, 3, 'None', 'Third Year', 'First Semester'),
('DSTRUCT', 'Data Structures and Algorithims', 3, 1, 2, 'PROG2', 'Second Year', 'Second Semester'),
('ENVSCI', 'Enviromental Science', 3, 0, 3, 'None', 'Second Year', 'First Semester'),
('ETHICS', 'Ethics', 3, 0, 3, 'None', 'First Year', 'Second Semester'),
('HCI1', 'Introduction to Human Computer Interaction', 3, 1, 2, 'None', 'First Year', 'Second Semester'),
('INFOMGT', 'Information Management', 3, 1, 2, 'DSTRUCT', 'Third Year', 'First Semester'),
('INFOSEC1', 'Information Assurance and Security 1', 3, 1, 2, 'None', 'Third Year', 'Second Semester'),
('INFOSEC2', 'Inforamation Assurance and Security 2', 3, 1, 2, 'INFOSEC1', 'Fourth Year', 'First Semester'),
('IPTECH1', 'Intergrative Programming Technologies 1', 3, 1, 2, 'None', 'Second Year', 'First Semester'),
('IPTECH2', 'Intergrative Programming and Technologies 2', 3, 1, 2, 'IPTECH1', 'Third Year', 'First Semester'),
('IT-PLUS1', 'IT-PLUS1', 3, 1, 2, 'None', 'Bridging', 'Bridging'),
('IT-PLUS2', 'IT-PLUS2', 3, 1, 2, 'None', 'Bridging', 'Bridging'),
('IT-PLUS3', 'IT-PLUS3', 3, 1, 2, 'None', 'Bridging', 'Bridging'),
('IT-PLUS4', 'IT-PLUS4', 3, 1, 2, 'None', 'Bridging', 'Bridging'),
('ITFUND', 'Introduction to Computing', 3, 1, 2, 'None', 'First Year', 'First Semester'),
('KOMFIL', 'Kontekwalisadong Komunikasyon sa Filipino', 3, 0, 3, 'None', 'First Year', 'First Semester'),
('LEAD1', 'Values Formation 1', 1.5, 0, 1.5, 'None', 'First Year', 'First Semester'),
('LEAD2', 'Values Formation 2', 1.5, 0, 1.5, 'LEAD1', 'First Year', 'Second Semester'),
('LEAD3', 'Values Formation 3', 1.5, 0, 1.5, 'LEAD2', 'Second Year', 'First Semester'),
('LEAD4', 'Values Formation 4', 1.5, 0, 1.5, 'LEAD3', 'Second Year', 'Second Semester'),
('LEAD5', 'Values Formation 5', 1.5, 0, 1.5, 'LEAD4', 'Third Year', 'First Semester'),
('LEAD6', 'Values Formation 6', 1.5, 0, 1.5, 'LEAD5', 'Third Year', 'Second Semester'),
('LEAD7', 'Values Formation 7', 1.5, 0, 1.5, 'LEAD6', 'Fourth Year', 'First Semester'),
('LEAD8', 'Values Formation 8', 1.5, 0, 1.5, 'LEAD7', 'Fourth Year', 'Second Semester'),
('MATWRLD', 'Mathematics in the Modern World', 3, 0, 3, 'None', 'First Year', 'First Semester'),
('NET1', 'Networking 1', 3, 1, 2, 'None', 'Second Year', 'First Semester'),
('NET2', 'Networking 2', 3, 1, 2, 'NET1', 'Third Year', 'First Semester'),
('NSTP1', 'National Service Training Program 1', 3, 0, 3, 'None', 'First Year', 'First Semester'),
('NSTP2', 'National Service Training Program 2', 3, 0, 3, 'NSTP1', 'First Year', 'Second Semester'),
('OJT', 'On the Job Training (600 hrs)', 6, 0, 6, '70% of academic requirements', 'Fourth Year', 'Second Semester'),
('OOP', 'Object Oriented Programmig', 3, 1, 2, 'PROG2', 'Second Year', 'Second Semester'),
('PE1', 'Physical Educartion 1', 2, 0, 2, 'None', 'First Year', 'First Semester'),
('PE2', 'Physical Education 2', 2, 0, 2, 'PE1', 'First Year', 'Second Semester'),
('PE3', 'Physical Education 3', 2, 0, 2, 'PE2', 'Second Year', 'First Semester'),
('PE4', 'Physical Education 4', 2, 0, 2, 'PE3', 'Second Year', 'Second Semester'),
('PHILHIS', 'Reading in Philippine History', 3, 0, 3, 'None', 'First Year', 'First Semester'),
('PLATECH', 'Platform Technologies', 3, 1, 2, 'None', 'Second Year', 'First Semester'),
('PROG1', 'Computer Programming 1', 3, 1, 2, 'ITFUND', 'First Year', 'Second Semester'),
('PROG2', 'Computer Programming 2', 3, 1, 2, 'PROG1', 'Second Year', 'First Semester'),
('PSPEAK', 'Public Speaking', 3, 0, 3, 'None', 'First Year', 'Second Semester'),
('PURPCOMM', 'Purposive Communication', 3, 0, 3, 'None', 'First Year', 'First Semester'),
('QMTHODS', 'Quantitative Methods (incl modeling and simulation', 3, 0, 3, 'DMATH', 'Third Year', 'Second Semester'),
('RIZAL', 'Rizal\'s Life and Works', 3, 0, 3, 'None', 'Third Year', 'Second Semester'),
('SCITECH', 'Science, Technology and Society', 3, 0, 3, 'None', 'First Year', 'Second Semester'),
('SICI', 'Social and Professional Issues', 3, 0, 3, 'None', 'Fourth Year', 'First Semester'),
('SOSLIT', 'Sosyelidad at Literatura/Panitikang Panlipunan ', 3, 0, 3, 'None', 'Second Year', 'Second Semester'),
('SYSARCH1', 'System Intergration and Architecture 1', 3, 1, 2, 'None', 'Second Year', 'Second Semester'),
('SYSARCH2', 'System Intergration and Architecture 2', 3, 1, 2, 'SYSARCH1', 'Third Year', 'First Semester'),
('SYSMAIN', 'System Admin Maintenance', 3, 0, 2, 'CAPSTONE2', 'Fourth Year', 'Second Semester'),
('UNDSELF', 'Understanding the Self', 3, 0, 3, 'None', 'First Year', 'First Semester'),
('WEBSYS', 'Web System and Technologies', 3, 1, 2, 'None', 'Third Year', 'Second Semester');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_verification`
--

CREATE TABLE `tbl_verification` (
  `Code` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_verification`
--

INSERT INTO `tbl_verification` (`Code`) VALUES
('2021_5208'),
('2021_4485'),
('2021_8020'),
('2021_3022'),
('2021_4373'),
('2021_3274'),
('commander'),
('commander'),
('commander'),
('2021_4827'),
('2021_1460'),
('2021_2320'),
('2021_0328'),
('2021_2232'),
('2021_6677'),
('2021_3584'),
('2021_5565'),
('2021_8754'),
('2021_0271'),
('2021_5387'),
('2021_8188'),
('2021_2670'),
('2021_5686'),
('2021_0153'),
('2021_6683'),
('2021_8812'),
('2021_5046'),
('2021_3847'),
('2021_2165'),
('2021_6302'),
('2021_3716'),
('2021_5471'),
('2021_5171'),
('2021_5631'),
('2021_2886'),
('2021_2274'),
('2021_7616'),
('2021_4885'),
('2021_1057'),
('2021_7656'),
('2021_8646'),
('2021_5446'),
('2021_3678'),
('2021_3768'),
('2021_8452'),
('2021_8112'),
('2021_3617'),
('2021_2074'),
('2021_8448'),
('2021_3217'),
('2021_4052'),
('2021_5645'),
('2021_5753'),
('2021_1473'),
('2021_3081'),
('2021_6852'),
('2021_1432'),
('2021_7146');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_grades`
--
ALTER TABLE `tbl_grades`
  ADD PRIMARY KEY (`col_ID`);

--
-- Indexes for table `tbl_student`
--
ALTER TABLE `tbl_student`
  ADD PRIMARY KEY (`col_StudID`),
  ADD UNIQUE KEY `col_StudID` (`col_StudID`);

--
-- Indexes for table `tbl_subject`
--
ALTER TABLE `tbl_subject`
  ADD PRIMARY KEY (`col_subcode`),
  ADD UNIQUE KEY `col_subcode` (`col_subcode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_grades`
--
ALTER TABLE `tbl_grades`
  MODIFY `col_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=974;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
