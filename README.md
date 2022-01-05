# _Best Restaurants_

#### By: _*Katie Pundt, Liz Thomas, and Anna Pittman*_

#### _A refactored version of the BestRestaurants project to use many to many relationships._

## Technologies Used
* C#
* .NET5
* ASP.NET Core MVC
* Razor
* NuGet
* git
* GitHub
* MySql

## Description
_A website where users can add their favorite restaurants, based on the type of cuisine that they serve. Built with full CRUD functionality._

## System Requirements
* Download and install [.NET5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* A text editor, such as [VS Code](https://code.visualstudio.com/)
* MySQL and MySQL Workbench

## Setup/Installation Instructions
* Download, install, and configure MySQL
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/kpundt93/BestRestaurantsRefactor.Solution.git`
* After cloning the project, navigate into it using the command `cd BestRestaurantsRefactor.Solution/BestRestaurants`
* Create a file named "appsettings.json" in the `BestRestaurants` directory
* Add the following code to appsettings.json and add your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants_refactor;uid=[YOUR MYSQL USER ID];pwd=[YOUR MYSQL PASSWORD];"
  }
}
```
* Then run the command `dotnet ef database update`
* Then run the command `dotnet restore` to install project dependencies
* Then run the command `dotnet run` to run the project in the browser

## Known Bugs
* _No known bugs_

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Katie Pundt, Liz Thomas, and Anna Pittman_