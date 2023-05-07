-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 07, 2023 at 08:50 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eventmanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustId` int(11) NOT NULL,
  `CustName` varchar(50) DEFAULT NULL,
  `CustPhone` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`CustId`, `CustName`, `CustPhone`) VALUES
(1, 'Ali Khan', '09123455');

-- --------------------------------------------------------

--
-- Table structure for table `eventtbl`
--

CREATE TABLE `eventtbl` (
  `EvId` int(11) NOT NULL,
  `EvName` varchar(50) DEFAULT NULL,
  `EvDate` date DEFAULT NULL,
  `VenueId` int(11) DEFAULT NULL,
  `EvVenue` varchar(50) DEFAULT NULL,
  `EvDurartion` int(11) DEFAULT NULL,
  `EvCustId` int(11) DEFAULT NULL,
  `EvCustName` varchar(50) DEFAULT NULL,
  `EvStatus` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `eventtbl`
--

INSERT INTO `eventtbl` (`EvId`, `EvName`, `EvDate`, `VenueId`, `EvVenue`, `EvDurartion`, `EvCustId`, `EvCustName`, `EvStatus`) VALUES
(3, 'Hello', '2023-05-05', 4, 'Khan Hall', 3, 1, 'Ali Khan', 'Waiting');

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `Id` int(11) NOT NULL,
  `EventId` int(11) DEFAULT NULL,
  `EventName` varchar(50) DEFAULT NULL,
  `Venue` int(11) DEFAULT NULL,
  `Hospatality` int(11) DEFAULT NULL,
  `Pucntuality` int(11) DEFAULT NULL,
  `Overall` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `feedback`
--

INSERT INTO `feedback` (`Id`, `EventId`, `EventName`, `Venue`, `Hospatality`, `Pucntuality`, `Overall`) VALUES
(2, 3, 'Hello', 1, 2, 2, 0),
(3, 3, 'Hello', 1, 2, 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `venuetbl`
--

CREATE TABLE `venuetbl` (
  `VenueId` int(11) NOT NULL,
  `VName` varchar(50) DEFAULT NULL,
  `VCapacity` varchar(50) DEFAULT NULL,
  `VAddress` varchar(100) DEFAULT NULL,
  `VManager` varchar(50) DEFAULT NULL,
  `VPhone` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `venuetbl`
--

INSERT INTO `venuetbl` (`VenueId`, `VName`, `VCapacity`, `VAddress`, `VManager`, `VPhone`) VALUES
(4, 'Khan Hall', '202', 'Peshawar', 'Ali', '091234567');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustId`);

--
-- Indexes for table `eventtbl`
--
ALTER TABLE `eventtbl`
  ADD PRIMARY KEY (`EvId`),
  ADD KEY `VenueId` (`VenueId`),
  ADD KEY `EvCustId` (`EvCustId`);

--
-- Indexes for table `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `EventId` (`EventId`);

--
-- Indexes for table `venuetbl`
--
ALTER TABLE `venuetbl`
  ADD PRIMARY KEY (`VenueId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `CustId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `eventtbl`
--
ALTER TABLE `eventtbl`
  MODIFY `EvId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `feedback`
--
ALTER TABLE `feedback`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `venuetbl`
--
ALTER TABLE `venuetbl`
  MODIFY `VenueId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `eventtbl`
--
ALTER TABLE `eventtbl`
  ADD CONSTRAINT `eventtbl_ibfk_1` FOREIGN KEY (`VenueId`) REFERENCES `venuetbl` (`VenueId`),
  ADD CONSTRAINT `eventtbl_ibfk_2` FOREIGN KEY (`EvCustId`) REFERENCES `customer` (`CustId`);

--
-- Constraints for table `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`EventId`) REFERENCES `eventtbl` (`EvId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
