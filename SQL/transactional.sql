-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 14, 2015 at 01:56 AM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `transactional`
--

-- --------------------------------------------------------

--
-- Table structure for table `addresses`
--

CREATE TABLE IF NOT EXISTS `addresses` (
  `AddressID` int(50) NOT NULL AUTO_INCREMENT,
  `Address_Line1` varchar(32) NOT NULL,
  `Address_Line2` varchar(32) NOT NULL,
  `Country` varchar(32) NOT NULL,
  `County` varchar(32) NOT NULL,
  `City` varchar(32) NOT NULL,
  `Postcode` varchar(10) NOT NULL,
  PRIMARY KEY (`AddressID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `addresses`
--

INSERT INTO `addresses` (`AddressID`, `Address_Line1`, `Address_Line2`, `Country`, `County`, `City`, `Postcode`) VALUES
(1, '123 Fake Street', 'Flat 2a', 'United Kingdom', 'Cambridgeshire', 'Cambridge', 'CB1 1DE'),
(2, '6 Baker Street', 'Unit 5', 'United Kingdom', 'Suffolk', 'Haverhill', 'CB9 9AU'),
(3, '123 Fake Street', 'Flat 12c', 'United Kingdom', 'Cambridgeshire', 'Cambridge', 'CB1 1DE');

-- --------------------------------------------------------

--
-- Table structure for table `address_type`
--

CREATE TABLE IF NOT EXISTS `address_type` (
  `Address_Type` varchar(10) NOT NULL,
  `Address_Description` varchar(50) NOT NULL,
  PRIMARY KEY (`Address_Type`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `address_type`
--

INSERT INTO `address_type` (`Address_Type`, `Address_Description`) VALUES
('Home', 'It''s a house'),
('Warehouse', 'It''s a Warehouse'),
('Flat', 'It''s a flat');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE IF NOT EXISTS `customers` (
  `CustomerID` int(50) NOT NULL AUTO_INCREMENT,
  `First_Name` varchar(64) DEFAULT NULL,
  `Last_Name` varchar(64) DEFAULT NULL,
  `Phone_Number` varchar(15) DEFAULT NULL,
  `Email_Address` varchar(254) DEFAULT NULL,
  `Password` char(50) DEFAULT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerID`, `First_Name`, `Last_Name`, `Phone_Number`, `Email_Address`, `Password`) VALUES
(1, 'Ben', 'Harrods', '07777777777', 'ben.harrods@gmail.com', 'benharrods'),
(2, 'Steve', 'Jobs', '07878787878', 'steve.jobs@gmail.com', 'stevejobs');

-- --------------------------------------------------------

--
-- Table structure for table `customer_addresses`
--

CREATE TABLE IF NOT EXISTS `customer_addresses` (
  `CustomerID` int(50) NOT NULL,
  `AddressID` int(50) NOT NULL,
  `Date_From` datetime NOT NULL,
  `Address_Type` varchar(10) NOT NULL,
  `Date_To` datetime DEFAULT NULL,
  PRIMARY KEY (`Date_From`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_addresses`
--

INSERT INTO `customer_addresses` (`CustomerID`, `AddressID`, `Date_From`, `Address_Type`, `Date_To`) VALUES
(1, 1, '2015-11-01 22:02:09', 'Home', '2015-12-01 22:02:19'),
(2, 3, '2015-11-02 19:04:12', 'Flat', '2015-11-03 19:04:19');

-- --------------------------------------------------------

--
-- Table structure for table `customer_orders`
--

CREATE TABLE IF NOT EXISTS `customer_orders` (
  `OrderID` int(50) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(50) NOT NULL,
  `Customer_Payment_MethodID` int(50) NOT NULL,
  `Order_Status` int(50) NOT NULL,
  `Date_Order_Placed` datetime DEFAULT NULL,
  `Date_Order_Paid` datetime DEFAULT NULL,
  `Order_Price` double(50,2) NOT NULL,
  `Order_Details` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`OrderID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `customer_orders`
--

INSERT INTO `customer_orders` (`OrderID`, `CustomerID`, `Customer_Payment_MethodID`, `Order_Status`, `Date_Order_Placed`, `Date_Order_Paid`, `Order_Price`, `Order_Details`) VALUES
(1, 1, 1, 1, '2015-11-01 22:05:16', '2015-11-01 22:05:30', 9.99, 'Beard Oil'),
(2, 1, 1, 1, '2015-12-01 16:03:40', '2015-12-01 16:03:44', 19.99, 'Beard Comb');

-- --------------------------------------------------------

--
-- Table structure for table `customer_order_delivery`
--

CREATE TABLE IF NOT EXISTS `customer_order_delivery` (
  `OrderID` int(50) NOT NULL,
  `Date_Reported` datetime NOT NULL,
  `Delivery_Status` tinyint(1) NOT NULL,
  PRIMARY KEY (`Date_Reported`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_order_delivery`
--

INSERT INTO `customer_order_delivery` (`OrderID`, `Date_Reported`, `Delivery_Status`) VALUES
(1, '2015-11-02 22:08:01', 1),
(2, '2015-12-03 16:06:01', 1);

-- --------------------------------------------------------

--
-- Table structure for table `customer_order_products`
--

CREATE TABLE IF NOT EXISTS `customer_order_products` (
  `OrderID` int(50) NOT NULL,
  `ProductID` int(50) NOT NULL,
  `Quantity` int(50) NOT NULL,
  `Comments` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_order_products`
--

INSERT INTO `customer_order_products` (`OrderID`, `ProductID`, `Quantity`, `Comments`) VALUES
(1, 1, 1, '1 Beard Oil was purchased'),
(2, 2, 1, '1 Beard Comb was Purchased');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE IF NOT EXISTS `products` (
  `ProductID` int(50) NOT NULL AUTO_INCREMENT,
  `SupplierID` int(50) NOT NULL,
  `Product_Price` double(50,2) NOT NULL,
  `Quantity` int(50) NOT NULL,
  `Product_Details` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ProductID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ProductID`, `SupplierID`, `Product_Price`, `Quantity`, `Product_Details`) VALUES
(1, 1, 9.99, 10, 'Mr.Beard Beard Oil'),
(2, 1, 19.99, 10, 'Beard Comb');

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE IF NOT EXISTS `suppliers` (
  `SupplierID` int(50) NOT NULL AUTO_INCREMENT,
  `Supplier_Name` varchar(50) NOT NULL,
  `Supplier_Details` varchar(50) NOT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`SupplierID`, `Supplier_Name`, `Supplier_Details`) VALUES
(1, 'BeardLtd', 'All of your beardie needs');

-- --------------------------------------------------------

--
-- Table structure for table `warehouse`
--

CREATE TABLE IF NOT EXISTS `warehouse` (
  `WarehouseID` int(50) NOT NULL AUTO_INCREMENT,
  `SupplierID` int(50) NOT NULL,
  `ProductID` int(50) NOT NULL,
  `AddressID` int(50) NOT NULL,
  PRIMARY KEY (`WarehouseID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `warehouse`
--

INSERT INTO `warehouse` (`WarehouseID`, `SupplierID`, `ProductID`, `AddressID`) VALUES
(1, 1, 1, 2);

-- --------------------------------------------------------

--
-- Table structure for table `warehouse_addresses`
--

CREATE TABLE IF NOT EXISTS `warehouse_addresses` (
  `WarehouseID` int(50) NOT NULL,
  `AddressID` int(50) NOT NULL,
  `Date_From` datetime NOT NULL,
  `Address_Type` varchar(10) NOT NULL,
  `Date_To` datetime NOT NULL,
  PRIMARY KEY (`Date_From`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `warehouse_addresses`
--

INSERT INTO `warehouse_addresses` (`WarehouseID`, `AddressID`, `Date_From`, `Address_Type`, `Date_To`) VALUES
(1, 2, '2015-11-02 22:16:20', 'Warehouse', '2015-12-07 22:16:27');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
