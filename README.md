# FactoryWorks
## _Factory Maintenance Tracking App_

#### By Dani Steely

#### _App for tracking machines, engineers, machine/engineer assignments, and machine repairs for a fictional factory, using many-to-many relationships in .Net and MySQL database. Student project for C# with .NET course at Epicodus_

## Technologies Used
* _C#_
* _Razor Markdown_
* _ASP.NET Core MVC_
* _Entity Framework Core_
* _MySQL_

## Setup/Installation Requirements
#### Setting up directories
* clone this repo to your desktop
* navigate to project directory in your terminal
* you may want to include a .gitignore file in your root directory
* in your .gitignore file you can include the appsettings.json file that you will need to create in the next step

#### Creating an appsettings file
* navigate to "Factory" directory (production directory)
* create a new file called appsettings.json
* the following code should go in the appsettings.json file:
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[USERNAME];pwd={PASSWORD};"
  }
}
```
* within the appsettings.json file, you will need to replace `[DATABASE-NAME]` with the name of the database, `[USERNAME]` with your username, and `[PASSWORD]` with your password

#### Database setup
* you will need to recreate the database used for this project
* you can view the database structure in the file titled "factory_dani_steely" in the root directory
* you can alternatively use code-first database setup using migrations
* to do this, follow the lesson on ["Code-First Development"][Code-First Dev] from Epicodus

## Description

This application is an independent project created as part of [Epicodus][Epicodus] coursework in [C# with .Net][C# course main]. The project was completed after week six: ["Many To Many Relationships"][C# chapter]. The application displays machine and engineer information for a fictional factory. The application was created to demonstrate ability to use the Entity Framework Core and MySQL databases with many-to-many relationships. The application uses ASP.NET Core MVC to handle routing and requests and uses Entity FrameWork Core to communicate to a MySql database using .NET objects. 

## Objectives
* Does at least one of your classes have all CRUD methods implemented in your app?
* Are you able to view both sides of the many-many relationship? For a particular instance of a class, are you able to view all of the instances of the other class that are related to it?
* Build files and sensitive information are included in .gitignore file and is not to be tracked by Git, and includes instructions on how to create the appsettings.json and set up the project.
* There should be a many-to-many relationship between Engineers and Machines.
* The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines.

## Stretch Goals
* _Add all CRUD methods to both classes._
* _Add properties to specify if a machine is operational, malfunctioning, or in the process of being repaired._
* _Add properties to specify if an engineer is idle, or actively working on repairs._
* _Add inspection dates to the machines, or dates of license renewal to the engineers._
* _Add a table for incidents, showing which engineer repaired which machine._
* _Add a table for locations, and specify which engineers or machines are located at which factory._
* _Add styling to give life to the project._

## Known Bugs
* No known bugs

## License

_MIT License_

Copyright (c) _3/25/23_ _Dani Steely_

[Epicodus]: https://www.epicodus.com/
[C# course main]: https://www.learnhowtoprogram.com/c-and-net-part-time
[C# chapter]: https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships
[Code-First Dev]: https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-mig



