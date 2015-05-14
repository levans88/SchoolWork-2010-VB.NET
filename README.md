This project is an old WinForms class project in VB.NET restored from 2010. It emulates a travel reservation and information system. To run the project:  

-Use SQL Server Management Studio (I used 2008) to attach the database.  
-The database needs SQL Server 2008 (2008 Express works, 2005 does not). On my machine I also have SQL Server 2005, so I have to stop that service, start Express, and connect to "localhost\sqlexpress" using SSMS 2008.  
-To attach the DB, launch the management studio, right-click on "Databases", and choose "Attach..."  
-Add the amsterdam.mdf file. The log data file (LDF) will be pulled in automatically.  
-Open the solution file (.sln) in Visual Studio 2008 and run it.  
-Detach the database when done.  
