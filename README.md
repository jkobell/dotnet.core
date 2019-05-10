# dotnet.core
.NET CORE PROJECTS

Name: RazorPagesNorthwind

Database: Northwind 

Description: ASP.NET Core Razor Pages

Purpose: Provide CRUD operations on database table that is located in the APP_DATA folder of the Project.

Problem: .NET CORE is a cross platform framework; however, unlike .NET Standard, a data source connection string can no longer simply contain [AttachDbFilename=|DataDirectory|] as a way of connecting with a database within the APP_DATA folder. In fact, APP_DATA is not created by default as part of a new .NET CORE project. As a result, the database in a project is located at an absolute path.  

Solution: The solution is to use a %CONTENTROOTPATH% token within the connection string and replace the token within the Startup class of the project during configuration. First, the IConfiguration interface within the Startup class gets the key value json pairs from the appsettings.json file. One of these key value pairs is the connection string. Next, the IHostingEnvironment interface provides a value (an absolute path to the database which is located in the APP_DATA folder of the project) that can be used to replace the %CONTENTROOTPATH% token within the current connection string. The replacement is done by using the Replace(old, new) method. Finally, the IServiceCollection interface, also in the Startup class, specifies the service.AddDbContext for connecting to the database with the options.UseSqlServer([connection]). (The connection is the new connection string after token substitution.)

By using the above described solution, a database can be placed into the APP_DATA folder of the project, and  Entity Framework will continue to have access to the database tables that it is using.
Note: It has been noted that if the Project is shared on GitHub, any changes to the database table field values may not be updated when changes are pushed with git.    

