-- phpMyAdmin SQL Dump
-- version 4.0.8
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jan 21, 2014 at 12:14 PM
-- Server version: 5.5.32-cll-lve
-- PHP Version: 5.3.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `first_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE IF NOT EXISTS `admin` (
  `user` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`user`, `password`) VALUES
('admin', 'password'),
('shah', 'bhau'),
('admin', 'password2');

-- --------------------------------------------------------

--
-- Table structure for table `login_attempts`
--

CREATE TABLE IF NOT EXISTS `login_attempts` (
  `user_id` int(11) NOT NULL,
  `time` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login_attempts`
--

INSERT INTO `login_attempts` (`user_id`, `time`) VALUES
(17, '1388204383'),
(17, '1388204392'),
(17, '1388204444'),
(22, '1388338819'),
(22, '1388342106');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE IF NOT EXISTS `product` (
  `pid` int(11) NOT NULL AUTO_INCREMENT,
  `pname` varchar(25) DEFAULT NULL,
  `category` varchar(25) DEFAULT NULL,
  `company` varchar(25) DEFAULT NULL,
  `desc1` varchar(50) DEFAULT NULL,
  `desc2` varchar(50) DEFAULT NULL,
  `desc3` varchar(50) DEFAULT NULL,
  `desc4` varchar(50) DEFAULT NULL,
  `desc5` varchar(50) DEFAULT NULL,
  `sellingprice` double DEFAULT NULL,
  `costprice` double DEFAULT NULL,
  `dealerprice` double DEFAULT NULL,
  `vat` double DEFAULT NULL,
  PRIMARY KEY (`pid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`pid`, `pname`, `category`, `company`, `desc1`, `desc2`, `desc3`, `desc4`, `desc5`, `sellingprice`, `costprice`, `dealerprice`, `vat`) VALUES
(5, 'p1', 'cat1', 'comp1', 'd1', 'd2', 'd3', 'd4', 'd5', 55, 35, 40, 10),
(6, 'p2', 'cat2', 'comp2', 'dd1', 'dd2', 'dd3', 'dd4', 'dd5', 10, 9, 9, 10),
(7, 'abc', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 9, 9, 9, 9);

-- --------------------------------------------------------

--
-- Table structure for table `quotations`
--

CREATE TABLE IF NOT EXISTS `quotations` (
  `qid` int(11) NOT NULL AUTO_INCREMENT,
  `customername` varchar(20) DEFAULT NULL,
  `customertype` char(1) DEFAULT NULL COMMENT 'c-customer, d-dealer',
  `quotedate` date DEFAULT NULL,
  `salesmanID` int(11) DEFAULT NULL,
  `customerEmail` varchar(20) DEFAULT NULL,
  `accountPhone` varchar(20) DEFAULT NULL,
  `salesPhone` varchar(20) DEFAULT NULL,
  `ownerPhone` varchar(20) DEFAULT NULL,
  `cstNo` varchar(20) DEFAULT NULL,
  `tinNo` varchar(20) DEFAULT NULL,
  `totalPrice` double DEFAULT NULL,
  `installationCost` double DEFAULT NULL,
  `salesTax` double DEFAULT NULL,
  `discount` double DEFAULT NULL,
  `quoteObj` text,
  PRIMARY KEY (`qid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=23 ;

--
-- Dumping data for table `quotations`
--

INSERT INTO `quotations` (`qid`, `customername`, `customertype`, `quotedate`, `salesmanID`, `customerEmail`, `accountPhone`, `salesPhone`, `ownerPhone`, `cstNo`, `tinNo`, `totalPrice`, `installationCost`, `salesTax`, `discount`, `quoteObj`) VALUES
(18, 'abbc', '', '0000-00-00', 22, ' ', ' ', ' ', ' ', ' ', ' ', 0, 0, 0, 0, ' {"quotation":[ {  "version" : "1",    "date":"date", "subject" : "aaa" , "totalPrice":""  , "products": [{"pid" : "5","pname" : "p1","category" : "cat1","company" : "comp1","desc1" : "d1","desc2" : "d2","desc3" : "d3","desc4" : "d4","desc5" : "d5","price" : "55","vat" : "10","quantity" : "4" },{"pid" : "7","pname" : "abc","category" : "b","company" : "b","desc1" : "b","desc2" : "b","desc3" : "b","desc4" : "b","desc5" : "b","price" : "9","vat" : "9","quantity" : "2" }] } ] }'),
(19, '', '', '0000-00-00', 22, ' ', ' ', ' ', ' ', ' ', ' ', 0, 0, 0, 0, ' {"quotation":[ {  "version" : "1",    "date":"date", "subject" : "" , "totalPrice":""  , "products": [{"pid" : "7","pname" : "abc","category" : "b","company" : "b","desc1" : "b","desc2" : "b","desc3" : "b","desc4" : "b","desc5" : "b","price" : "9","vat" : "9","quantity" : "11" },{"pid" : "5","pname" : "p1","category" : "cat1","company" : "comp1","desc1" : "d1","desc2" : "d2","desc3" : "d3","desc4" : "d4","desc5" : "d5","price" : "55","vat" : "10","quantity" : "2" },{"pid" : "6","pname" : "p2","category" : "cat2","company" : "comp2","desc1" : "dd1","desc2" : "dd2","desc3" : "dd3","desc4" : "dd4","desc5" : "dd5","price" : "10","vat" : "10","quantity" : "5" }] } ] }'),
(20, '123', '', '0000-00-00', 22, ' ', ' ', ' ', ' ', ' ', ' ', 0, 0, 0, 0, ' {"quotation":[ {  "version" : "1",    "date":"date", "subject" : "wqe" , "totalPrice":""  , "products": [{"pid" : "5","pname" : "p1","category" : "cat1","company" : "comp1","desc1" : "d1","desc2" : "d2","desc3" : "d3","desc4" : "d4","desc5" : "d5","price" : "55","vat" : "10","quantity" : "15" }] } ] }'),
(22, 'jhj', '', '2013-12-30', 22, '', '', '', '', '', '', 74.29, 0, 0, 0, '{"quotation":[ {  "version" : "1",    "date":"date", "subject" : "jhhkll" , "totalPrice":""  , "products": [{"pid" : "5","pname" : "p1","category" : "cat1","company" : "comp1","desc1" : "d1","desc2" : "d2","desc3" : "d3","desc4" : "d4","desc5" : "d5","price" : "55","vat" : "10","quantity" : "1" },{"pid" : "7","pname" : "abc","category" : "b","company" : "b","desc1" : "b","desc2" : "b","desc3" : "b","desc4" : "b","desc5" : "b","price" : "9","vat" : "9","quantity" : "1" },{"pid" : "6","pname" : "p2","category" : "cat2","company" : "comp2","desc1" : "dd1","desc2" : "dd2","desc3" : "dd3","desc4" : "dd4","desc5" : "dd5","price" : "10","vat" : "10","quantity" : "1" }] } ] }');

-- --------------------------------------------------------

--
-- Table structure for table `salesman`
--

CREATE TABLE IF NOT EXISTS `salesman` (
  `sid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) DEFAULT NULL,
  `fname` varchar(20) DEFAULT NULL,
  `lname` varchar(20) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  `discount` double DEFAULT NULL,
  `password` char(128) DEFAULT NULL,
  `salt` char(128) DEFAULT NULL,
  PRIMARY KEY (`sid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=25 ;

--
-- Dumping data for table `salesman`
--

INSERT INTO `salesman` (`sid`, `username`, `fname`, `lname`, `phone`, `email`, `discount`, `password`, `salt`) VALUES
(22, 'admin1', 'ajinkya', 'kshirsagar', '2134794438', 'akshirsa@usc.edu', 11, 'd3d188f12cf69fed7701886ae97e7a58bc05e0a617cddfa1d5a6cbd1325b28d1791f27ea7c977c4bceacf35165fc403d84f02f3e55416be302416a3577acb309', '997ca8ba8f9767f9caf761e36777735bd770e654d918ea00cea099c84bc9fd06e3dc447cb572fe9050dc562dcc51c6ccd2882431cfcbd72d146af1dee06ba4e2'),
(23, 'student', 'student', 'lastname', '1234567890', 'akshirsa@usc.edu', 15, 'a712b54ed66b770cfa4cd6770119923e2c10e7dff4b092cae54cb33a1c50b30bc79f8d2ea09625e4eb4cae3feccfe0dc551af27898714d226d31980d0ddde10f', 'd36dcad050ded2ac2bae390cc69aa94b1309fbe1a5e0b98035d96de60850edf0180dd64468d07c8c7e4592235ee46fc6aaace90aeaa474c2454e90082546135b'),
(24, 'ajinkya', 'ajinkya', 'kshirsagar', '09876543', 'raincoat.is.ajinkya@gmail.com', 25, 'a1b81b9c25e7255b076a09a7a8e203aabe8c5b72e1b89d05d49a2ef1428b12878c957e13621e2c0754c15ed3f07568cc6961f84caae5e1dc9ffe03d010542340', '019441ecd124df8758e25aea5a67755ce338006562a6e51b913cd2d88f478e0b4604a5d8acadd56e2c2e5d9797b449cfab03483db65d72dd5cbf3df1327eb8f7');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
