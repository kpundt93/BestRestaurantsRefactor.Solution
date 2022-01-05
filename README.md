
# _Best Restaurants_

#### By: _*Katie Pundt, Hannah Young, and Matt Luker*_

#### _A website to store favorite restaurants and the cuisines they serve._

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

![Screenshot of database schema](/schema.png)
## System Requirements
* Download and install [.NET5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* A text editor, such as [VS Code](https://code.visualstudio.com/)
* MySQL and MySQL Workbench

## Setup/Installation Instructions
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/kpundt93/BestRestaurants.Solution.git`
* After cloning the project, navigate into it using the command `cd BestRestaurants.Solution/BestRestaurants`
* Create a file named "appsettings.json" in the `BestRestaurants` directory
* Add the following code to appsettings.json and add your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=[YOUR MYSQL USER ID];pwd=[YOUR PASSWORD];"
  }
}
```
* Open MySQL Workbench and log into your server
* Find the "Navigator" panel and select the "Administration" tab
* Click on "Data Import/Restore"
* Select "Import from Self-Contained File" and navigate to where you cloned the project
* Under "Default Schema to be Imported To" select "New..."
* Name the new schema "best_restaurants" and click "OK"
* Click "Start Import" in the bottom right corner
* After the import is finished, go back to the "Navigator" panel and switch to the "Schemas" tab
* Once in the "Schemas" tab, right-click and select "Refresh All" to see the imported database
* Then run the command `dotnet restore` to install project dependencies
* Then run the command `dotnet run` to run the project in the browser

## Known Bugs
* _No known bugs_

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Katie Pundt, Hannah Young, and Matt Luker_