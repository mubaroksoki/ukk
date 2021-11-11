-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3606
-- Generation Time: Nov 11, 2021 at 09:43 AM
-- Server version: 5.7.24
-- PHP Version: 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `stematelbook`
--

-- --------------------------------------------------------

--
-- Table structure for table `daftarbuku`
--

CREATE TABLE `daftarbuku` (
  `id_buku` int(11) NOT NULL,
  `judul` varchar(225) NOT NULL,
  `pengarang` varchar(225) NOT NULL,
  `penerbit` varchar(225) NOT NULL,
  `upload_gambar` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `daftarbuku`
--

INSERT INTO `daftarbuku` (`id_buku`, `judul`, `pengarang`, `penerbit`, `upload_gambar`) VALUES
(19, 'suzuki', 'sss', 'ettterwesgvhgv', '182-bcl 3.JPG'),
(21, 'gvhvjg', 'ubjbkj', 'jhbjkhjkhj', '549-'),
(22, 'dddfsdf', 'sdgfsdgdfg', 'sdgfvsdfgsdf', '39-');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `name`) VALUES
(1, 'Admin', '123', 'NOWDEMY'),
(2, 'user1', 'abc', 'User 1'),
(3, 'user2', 'abc', 'User 2'),
(4, 'syauqi22', 'abcde', 'Syauqi Mubarok');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `daftarbuku`
--
ALTER TABLE `daftarbuku`
  ADD PRIMARY KEY (`id_buku`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `daftarbuku`
--
ALTER TABLE `daftarbuku`
  MODIFY `id_buku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
