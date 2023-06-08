-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 19, 2023 at 04:55 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `alldetails`
--

-- --------------------------------------------------------

--
-- Table structure for table `familydetails`
--

CREATE TABLE `familydetails` (
  `FamilyID` varchar(5) NOT NULL,
  `AddressType` varchar(25) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Members` int(2) DEFAULT NULL,
  `MonthlyAllowance` decimal(8,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `familydetails`
--

INSERT INTO `familydetails` (`FamilyID`, `AddressType`, `Address`, `Members`, `MonthlyAllowance`) VALUES
('FD001', 'Permanent', 'Batticaloa', 3, '56000.00'),
('FD002', 'Permanent', 'Valaichenai', 2, '78000.00'),
('FD003', 'Permanent', 'Vantharamoolai', 2, '56000.00');

-- --------------------------------------------------------

--
-- Table structure for table `familymembers`
--

CREATE TABLE `familymembers` (
  `ID` varchar(5) NOT NULL,
  `Name` varchar(35) DEFAULT NULL,
  `FamilyID` varchar(5) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Gender` varchar(6) DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `NIC` varchar(12) DEFAULT NULL,
  `Contact` varchar(10) DEFAULT NULL,
  `Relationship` varchar(18) DEFAULT NULL,
  `Education` varchar(18) DEFAULT NULL,
  `Job` varchar(25) DEFAULT NULL,
  `JobType` varchar(35) DEFAULT NULL,
  `Allowance` decimal(8,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `familymembers`
--

INSERT INTO `familymembers` (`ID`, `Name`, `FamilyID`, `Address`, `Gender`, `DOB`, `NIC`, `Contact`, `Relationship`, `Education`, `Job`, `JobType`, `Allowance`) VALUES
('FM001', 'Raja', 'FD001', 'Batticaloa', 'Male', '1971-06-16', '768989898V', '0754132585', 'Family Leader (M)', 'Degree', 'GS', 'Government', '45000.00'),
('FM002', 'Rani', 'FD002', 'Valaichenai', 'Female', '1989-02-19', '896756789V', '0768976878', 'Family Leader (F)', 'Diploma', 'House Wife', 'Other', '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` varchar(2) NOT NULL,
  `UserName` varchar(25) DEFAULT NULL,
  `Password` varchar(4) DEFAULT NULL,
  `UserType` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `UserName`, `Password`, `UserType`) VALUES
('01', 'Vaishu', '1234', 'Administrator'),
('02', 'Brintha', '5566', 'User');

-- --------------------------------------------------------

--
-- Table structure for table `visits`
--

CREATE TABLE `visits` (
  `Date` date DEFAULT NULL,
  `VisitID` varchar(5) NOT NULL,
  `ID` varchar(5) DEFAULT NULL,
  `FamilyID` varchar(5) DEFAULT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Gender` varchar(6) DEFAULT NULL,
  `NIC` varchar(12) DEFAULT NULL,
  `Contact` varchar(10) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Purpose` varchar(50) DEFAULT NULL,
  `Department` varchar(50) DEFAULT NULL,
  `WorkCondition` varchar(10) DEFAULT NULL,
  `FinishDate` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `visits`
--

INSERT INTO `visits` (`Date`, `VisitID`, `ID`, `FamilyID`, `Name`, `Gender`, `NIC`, `Contact`, `Address`, `Purpose`, `Department`, `WorkCondition`, `FinishDate`) VALUES
('2023-02-18', 'VT001', 'FM001', 'FD001', 'Raja', 'Male', '768989898V', '0754132585', 'Batticaloa', 'Death certificate', 'Registration', 'Finished', '2023-02-18'),
('2023-02-19', 'VT002', 'FM002', 'FD002', 'Rani', 'Female', '896756789V', '0768976878', 'Valaichenai', 'Licence', 'Motor Traffic', 'Pending', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `familydetails`
--
ALTER TABLE `familydetails`
  ADD PRIMARY KEY (`FamilyID`);

--
-- Indexes for table `familymembers`
--
ALTER TABLE `familymembers`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FamilyID` (`FamilyID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `visits`
--
ALTER TABLE `visits`
  ADD PRIMARY KEY (`VisitID`),
  ADD KEY `ID` (`ID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `familymembers`
--
ALTER TABLE `familymembers`
  ADD CONSTRAINT `familymembers_ibfk_1` FOREIGN KEY (`FamilyID`) REFERENCES `familydetails` (`FamilyID`);

--
-- Constraints for table `visits`
--
ALTER TABLE `visits`
  ADD CONSTRAINT `visits_ibfk_1` FOREIGN KEY (`ID`) REFERENCES `familymembers` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
