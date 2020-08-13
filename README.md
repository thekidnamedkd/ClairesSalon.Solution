# _CLAIRE'S SALON_

#### _C# Week 3 Independent Project_

#### By _**KEVIN DAVIS**_

![A Salon](./img/evidenza-salone-80-2.jpg)

## Description

_An MVC application in C# for a salon using ASP/.NET and an SQL Database constructed and managed by Entity. It will keep track of the salon's many clients and the particular stylist for each client demonstrating a one-to-many relationship._

### Specs
| Spec | Input | Output | Done? |
| :-------------     | :------------- | :------------- | :------------- | 
| Program will create a MVC for Clients. | input: | output:  | [X] |
| Program will create a MVC for Stylists. | input: | output:  | [X] |
| Program will link to an SQL database. | input: | output:  | [X] |
| Program will let the owner create a list of stylists who work at the salon and save to the database. | input: | output:  | [X] |
| Program will let the owner create client card for new clients including their stylist and save to the database. | input: | output:  | [X] |
| Program will let the owner view a list of salon's clients and add to it. | input: | output:  | [X] |
| Program will let the owner view a list of salon's stylists and add to it. | input: | output:  | [X] |
| Program will let the owner view client card, update info, or delete. | input: | output:  | [X] |

## SQL Database Instructions
* _Prior to running this program you will need to have MySQL installed on your machine. Go to https://dev.mysql.com/downloads/file/?id=484914 and follow next steps to install for your OS. More details with recommended login details here: https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql_
* _Once installed, open a new Terminal and navigate to your desktop. There run mysql -uroot -pepicodus and once running MySQL drop in this snippet:

```
DROP DATABASE IF EXISTS `kevin_davis`;
CREATE DATABASE `kevin_davis`;

USE `kevin_davis`;

CREATE TABLE `Clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `ClientName` varchar(255) DEFAULT NULL,
  `Style` varchar(255) DEFAULT NULL,
  `Phone` varchar(255) DEFAULT NULL,
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `StylistName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
)  ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```
* _Proceed to next set of instructions for Setup/Installation._


## Program Setup/Installation Requirements

* _Visit the following link: https://github.com/thekidnamedkd/ClairesSalon.Solution_
* _Clone the repository to your desired directory._
* _Use the terminal to navigate into to ClairesSalon.Solution_
* _Once inside the folder, navigate further to the HairSalon folder via the terminal._
* _There you can use the command ```$dotnet restore``` to add the necessary system files to the application._
* _Once that is complete you can run ```$dotnet run``` to launch the application._
* _Make sure you have the .NET Core installed for your operating system. If you are unsure go here https://dotnet.microsoft.com/download/dotnet-core/2.2. Find the right version for you and install. Then restart from step 3._
* _If the program successfully launches you should be able to go to http://localhost:5000/ to view the project._

## Known Bugs

No known bugs at this time.

## Support and contact details

_For questions, comments, or collaboration contact me at thekidnamedkd@gmail.com_

## Technologies Used

* _C#_
* _.NET Core 2.2_
* _Entity_
* _VS Code_
* _MySQL_
* _Git_
* _HTML_
* _CSS_

### License

*GPL license distribution*

Copyright (c) 2020 **_Kevin Davis_**