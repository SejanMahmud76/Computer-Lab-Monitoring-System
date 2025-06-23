-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 22, 2017 at 05:54 AM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbmonitoring`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbrand`
--

CREATE TABLE IF NOT EXISTS `tblbrand` (
  `BrandID` int(11) NOT NULL AUTO_INCREMENT,
  `Brand` varchar(90) NOT NULL,
  `Description` varchar(255) NOT NULL,
  PRIMARY KEY (`BrandID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tblbrand`
--

INSERT INTO `tblbrand` (`BrandID`, `Brand`, `Description`) VALUES
(1, 'Logitech', 'Logitech'),
(2, 'Samsung', 'Samsung');

-- --------------------------------------------------------

--
-- Table structure for table `tblcompset`
--

CREATE TABLE IF NOT EXISTS `tblcompset` (
  `CompSetID` int(11) NOT NULL AUTO_INCREMENT,
  `ComputerSet` varchar(90) NOT NULL,
  PRIMARY KEY (`CompSetID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tblcompset`
--

INSERT INTO `tblcompset` (`CompSetID`, `ComputerSet`) VALUES
(1, 'Computer 1'),
(2, 'Computer 2'),
(3, 'Computer 3');

-- --------------------------------------------------------

--
-- Table structure for table `tblitems`
--

CREATE TABLE IF NOT EXISTS `tblitems` (
  `ItemID` int(11) NOT NULL AUTO_INCREMENT,
  `Barcode` varchar(125) NOT NULL,
  `BrandID` int(11) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `PartsID` int(11) NOT NULL,
  `RecievedDate` date NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `LocationID` varchar(90) NOT NULL,
  `CompSetID` int(11) NOT NULL,
  `Status` varchar(30) NOT NULL,
  `Remarks` varchar(30) NOT NULL,
  PRIMARY KEY (`ItemID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `tblitems`
--

INSERT INTO `tblitems` (`ItemID`, `Barcode`, `BrandID`, `Description`, `PartsID`, `RecievedDate`, `Quantity`, `Price`, `LocationID`, `CompSetID`, `Status`, `Remarks`) VALUES
(1, '123123123123', 1, 'sdasdsa', 1, '2017-03-20', 1, 0, '1', 0, 'Ok', ''),
(2, '1`312312312', 1, 'asasdasdsadassdaaaaaaaaaaaaaaaaaaaaaaaaa', 1, '2017-03-20', 1, 0, '1', 0, 'Ok', ''),
(3, '12312312312312', 2, 'sadsaddsa', 3, '2017-03-20', 1, 0, '2', 0, 'Ok', ''),
(4, '123123123', 2, 'sadasdas', 3, '2017-03-20', 1, 0, '2', 0, 'Ok', ''),
(5, '555555555555555', 2, 'sadsad', 2, '2017-03-20', 1, 0, '3', 0, 'Ok', ''),
(6, '2133333333333', 1, 'asdsadas', 1, '2017-03-20', 1, 0, '1', 1, 'Good', ''),
(7, '21333333333', 1, 'sadasdas', 1, '2017-03-20', 1, 0, '1', 3, 'Good', 'Transfered'),
(8, '21333333333', 1, 'xasdasdas', 1, '2017-03-20', 1, 0, '1', 2, 'Good', ''),
(9, '12321321321', 1, 'SAZXZCCA', 3, '2017-03-20', 1, 0, '1', 1, 'Maintenance', 'Transfered'),
(10, '21312312312', 1, 'weqwewqewqe', 3, '2017-03-21', 1, 0, '1', 3, 'Maintenance', 'Transfered');

-- --------------------------------------------------------

--
-- Table structure for table `tbllocation`
--

CREATE TABLE IF NOT EXISTS `tbllocation` (
  `LocationID` int(11) NOT NULL AUTO_INCREMENT,
  `Location` varchar(90) NOT NULL,
  PRIMARY KEY (`LocationID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tbllocation`
--

INSERT INTO `tbllocation` (`LocationID`, `Location`) VALUES
(1, 'ComLabB'),
(2, 'ComLabA'),
(3, 'Lab3');

-- --------------------------------------------------------

--
-- Table structure for table `tblparts`
--

CREATE TABLE IF NOT EXISTS `tblparts` (
  `PartsID` int(11) NOT NULL AUTO_INCREMENT,
  `Parts` varchar(90) NOT NULL,
  PRIMARY KEY (`PartsID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `tblparts`
--

INSERT INTO `tblparts` (`PartsID`, `Parts`) VALUES
(1, 'Mouse'),
(2, 'Keyboard'),
(3, 'Monitor'),
(4, 'RAM');

-- --------------------------------------------------------

--
-- Table structure for table `tbltransfer`
--

CREATE TABLE IF NOT EXISTS `tbltransfer` (
  `TransferID` int(11) NOT NULL AUTO_INCREMENT,
  `ItemID` int(11) NOT NULL,
  `Item` varchar(90) NOT NULL,
  `Parts` varchar(30) NOT NULL,
  `LocationFROM` varchar(90) NOT NULL,
  `LocationTO` varchar(90) NOT NULL,
  `PCFrom` varchar(30) NOT NULL,
  `PCTo` varchar(30) NOT NULL,
  `TransferDate` date NOT NULL,
  PRIMARY KEY (`TransferID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `tbltransfer`
--

INSERT INTO `tbltransfer` (`TransferID`, `ItemID`, `Item`, `Parts`, `LocationFROM`, `LocationTO`, `PCFrom`, `PCTo`, `TransferDate`) VALUES
(1, 10, 'weqwewqewqe', 'Monitor', 'ComLabB', 'ComLabB', 'Computer 3', 'Computer 1', '2017-03-22'),
(2, 10, 'weqwewqewqe', 'Monitor', 'ComLabB', 'ComLabB', 'Computer 1', 'Computer 3', '2017-03-22'),
(3, 9, 'SAZXZCCA', 'Monitor', 'ComLabB', 'ComLabB', 'Computer 2', 'Computer 1', '2017-03-22'),
(4, 7, 'sadasdas', 'Mouse', 'ComLabA', 'ComLabB', 'Computer 1', 'Computer 3', '2017-03-22');

-- --------------------------------------------------------

--
-- Table structure for table `tbluseraccounts`
--

CREATE TABLE IF NOT EXISTS `tbluseraccounts` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Fullname` varchar(30) NOT NULL,
  `Username` varchar(30) NOT NULL,
  `Pass` varchar(90) NOT NULL,
  `Role` varchar(30) NOT NULL,
  `Status` varchar(30) NOT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tbluseraccounts`
--

INSERT INTO `tbluseraccounts` (`UserID`, `Fullname`, `Username`, `Pass`, `Role`, `Status`) VALUES
(1, 'Janno Palacios', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator', 'Active'),
(2, 'James Yap', 'staff', '6ccb4b7c39a6e77f76ecfa935a855c6c46ad5611', 'Staff', 'Active'),
(3, 'sadas', 'a', '86f7e437faa5a7fce15d1ddcb9eaeaea377667b8', 'Staff', 'Active');
