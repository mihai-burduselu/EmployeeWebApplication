Welcome to EmployeeWebApplication repository!
===================

This **ASP.NET WebApi** project allows user to add, delete, get and update "Employee" objects in a **Azure SQL Database** from a web page.
I made a SQL Database on portal.azure.com.
I added some classes:

 - Employee to describe our real object;
 - EmployeeContext that makes connection with SQL Database;
 - EmployeeRepository --- there are methods for quering, updating and creating new entities;
 - EmployeeController --- handles HTTP requests;

In the controller we have our repository and methods for getting all employees and creating, updating and deleting employees.
Basically, each method in our controller uses the repository to call methods from the repository.

## Running the project ##
If you want to use this repository, you need to insert your Azure credentials in a file named **ConnectionStrings.config** in the same folder with Web.config. 
We find the connection string for the database in the Azure portal, in the main blade of the database, by clicking Show Database Connection Strings. This will show you all connection strings for connecting to all predefined environments.
This is a template of ConnectionStrings.config.

    <connectionStrings>
    <clear />
    <add name="EmployeeDbConnectionString"
    providerName="System.Data.SqlClient"
    connectionString="Server=tcp:{your_serverName_here}.database.windows.net,1433; Database={your_databaseName_here}; Connection Timeout=30; Encrypt=True; TrustServerCertificate=False;"
    />
     </connectionStrings>
