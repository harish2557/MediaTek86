# MediaTek86

## Présentation

MediaTek86 est une application développée en C# avec WinForms et une base de données MySQL.

Ce projet a été réalisé dans le cadre de ma formation en BTS SIO option SLAM.  
L’objectif est de gérer les personnels ainsi que leurs absences au sein d’une structure.

L’application permet notamment :
- la gestion des personnels ;
- la gestion des absences ;
- la gestion des motifs d’absence.

Le projet suit une architecture MVC afin de mieux organiser le code et faciliter la maintenance.

---

## Technologies utilisées

- C#
- WinForms
- MySQL
- Visual Studio 2022
- phpMyAdmin

---

## Structure du projet

Le projet est organisé selon le modèle MVC :

- **Contrôleur** : gestion des actions et des traitements ;
- **Modèle** : accès aux données et classes métiers ;
- **Vue** : interface utilisateur.

Le dossier `modele` contient :
- les classes métiers ;
- les classes d’accès aux données (DAL) ;
- la connexion à la base de données.

---

## Fonctionnalités

### Gestion du personnel

- Affichage de la liste du personnel ;
- Ajout d’un membre du personnel ;
- Modification des informations ;
- Suppression d’un membre du personnel.

### Gestion des absences

- Affichage des absences ;
- Ajout d’une absence ;
- Modification d’une absence ;
- Suppression d’une absence.

---

## Base de données

La base de données MySQL est composée des tables suivantes :

- `personnel`
- `absence`
- `motif`
- `service`
- `responsable`

Des données de test sont incluses afin de faciliter les essais de l’application.

---

## Déploiement

Le dossier `Release` contient :
- l’exécutable `MediaTek86.exe` ;
- les bibliothèques nécessaires au fonctionnement de l’application.

---

## Auteur

Projet réalisé par Harish dans le cadre du BTS SIO SLAM.
