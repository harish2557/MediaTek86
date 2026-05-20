-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 20 mai 2026 à 23:10
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, '2024-01-03 08:00:00', '2024-01-05 17:00:00', 1),
(2, '2024-01-10 08:00:00', '2024-01-12 17:00:00', 2),
(3, '2024-01-15 08:00:00', '2024-01-16 17:00:00', 3),
(4, '2024-01-20 08:00:00', '2024-01-22 17:00:00', 4),
(5, '2024-01-25 08:00:00', '2024-01-27 17:00:00', 1),
(6, '2024-02-01 08:00:00', '2024-02-03 17:00:00', 2),
(7, '2024-02-05 08:00:00', '2024-02-06 17:00:00', 3),
(8, '2024-02-10 08:00:00', '2024-02-13 17:00:00', 4),
(9, '2024-02-15 08:00:00', '2024-02-16 17:00:00', 1),
(10, '2024-02-20 08:00:00', '2024-02-22 17:00:00', 2),
(1, '2024-03-01 08:00:00', '2024-03-02 17:00:00', 3),
(2, '2024-03-04 08:00:00', '2024-03-05 17:00:00', 4),
(3, '2024-03-07 08:00:00', '2024-03-08 17:00:00', 1),
(4, '2024-03-10 08:00:00', '2024-03-12 17:00:00', 2),
(5, '2024-03-14 08:00:00', '2024-03-15 17:00:00', 3),
(6, '2024-03-17 08:00:00', '2024-03-19 17:00:00', 4),
(7, '2024-03-21 08:00:00', '2024-03-22 17:00:00', 1),
(8, '2024-03-24 08:00:00', '2024-03-26 17:00:00', 2),
(9, '2024-03-28 08:00:00', '2024-03-29 17:00:00', 3),
(10, '2024-04-01 08:00:00', '2024-04-03 17:00:00', 4),
(1, '2024-04-05 08:00:00', '2024-04-06 17:00:00', 1),
(2, '2024-04-08 08:00:00', '2024-04-09 17:00:00', 2),
(3, '2024-04-11 08:00:00', '2024-04-13 17:00:00', 3),
(4, '2024-04-15 08:00:00', '2024-04-16 17:00:00', 4),
(5, '2024-04-18 08:00:00', '2024-04-20 17:00:00', 1),
(6, '2024-04-22 08:00:00', '2024-04-23 17:00:00', 2),
(7, '2024-04-25 08:00:00', '2024-04-27 17:00:00', 3),
(8, '2024-04-29 08:00:00', '2024-04-30 17:00:00', 4),
(9, '2024-05-02 08:00:00', '2024-05-04 17:00:00', 1),
(10, '2024-05-06 08:00:00', '2024-05-07 17:00:00', 2),
(1, '2024-05-09 08:00:00', '2024-05-11 17:00:00', 3),
(2, '2024-05-13 08:00:00', '2024-05-14 17:00:00', 4),
(3, '2024-05-16 08:00:00', '2024-05-18 17:00:00', 1),
(4, '2024-05-20 08:00:00', '2024-05-21 17:00:00', 2),
(5, '2024-05-23 08:00:00', '2024-05-25 17:00:00', 3),
(6, '2024-05-27 08:00:00', '2024-05-28 17:00:00', 4),
(7, '2024-05-30 08:00:00', '2024-06-01 17:00:00', 1),
(8, '2024-06-03 08:00:00', '2024-06-04 17:00:00', 2),
(9, '2024-06-06 08:00:00', '2024-06-08 17:00:00', 3),
(10, '2024-06-10 08:00:00', '2024-06-11 17:00:00', 4),
(1, '2024-06-13 08:00:00', '2024-06-15 17:00:00', 1),
(2, '2024-06-17 08:00:00', '2024-06-18 17:00:00', 2),
(3, '2024-06-20 08:00:00', '2024-06-22 17:00:00', 3),
(4, '2024-06-24 08:00:00', '2024-06-25 17:00:00', 4),
(5, '2024-06-27 08:00:00', '2024-06-29 17:00:00', 1),
(6, '2024-07-01 08:00:00', '2024-07-02 17:00:00', 2),
(7, '2024-07-04 08:00:00', '2024-07-06 17:00:00', 3),
(8, '2024-07-08 08:00:00', '2024-07-09 17:00:00', 4),
(9, '2024-07-11 08:00:00', '2024-07-13 17:00:00', 1),
(10, '2024-07-15 08:00:00', '2024-07-16 17:00:00', 2),
(28, '2026-05-20 00:00:00', '2026-05-25 00:00:00', 3),
(12, '2026-06-13 00:00:00', '2026-06-19 00:00:00', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(12, 'Lila Pace', 'Kiara Charles', '1-358-618-4397', 'nec.metus@yahoo.couk', 2),
(13, 'Clark Mayer', 'Gloria Rollins', '1-389-646-1475', 'nec@yahoo.org', 3),
(14, 'Gannon Meyer', 'Devin Foreman', '(679) 877-4254', 'est@protonmail.ca', 1),
(15, 'Holmes Richardson', 'Janna Beasley', '(676) 244-3162', 'est@icloud.ca', 2),
(16, 'Barclay Foster', 'Eagan Rodriquez', '1-415-327-5723', 'eget.venenatis@hotmail.couk', 3),
(17, 'Hammett Potts', 'Kylie Stokes', '1-387-710-0220', 'pede.nonummy.ut@yahoo.com', 1),
(18, 'Breanna Frederick', 'Ryan Bird', '(778) 888-7234', 'augue@aol.couk', 2),
(19, 'Keane Mcguire', 'Basia Hancock', '(715) 824-8622', 'in.ornare.sagittis@aol.net', 3),
(20, 'George Kent', 'Morgan Wagner', '1-986-887-8575', 'eu.tempor@outlook.ca', 1),
(21, 'Dupont', 'Jean', NULL, NULL, 1),
(22, 'Dupont', 'Jean', NULL, NULL, 1),
(23, 'Dupont', 'Jean', NULL, NULL, 1),
(25, 'Dupont', 'Jean', NULL, NULL, 1),
(26, 'Dupont', 'Jean', NULL, NULL, 1),
(27, 'Dupont', 'Jean', NULL, NULL, 1),
(28, 'Dupont', 'Jean', NULL, NULL, 1),
(34, 'martin', 'lucas', NULL, NULL, 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
