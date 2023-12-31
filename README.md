# Dr. Sillystringz's Factory

### By: Eva Kemp

## Technologies Used

- C#
- .NET6
- MySQL Workbench
- Razor
- ASP.NET Core MVC
- VS Code
- Entity Framework Core

## Description

This is an application that allows a user to create, edit, or delete engineers and machines in a factory. The user can add machines to an engineer and vice versa. It uses a many-to-many database relationship.

## How To Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Clone Project

- Clone the repository from GitHub by navigating to the main page of the repository.
- Above the list of files on the repository, click "Code".
- Then click "Download ZIP".
- After downloading, open the file in VS Code.
- Navigate to this project's production directory called "HairSalon" using the command `cd Factory` in the command line.
- Run `dotnet build` to compile the application.

### Import the MySQL Database:

- Open MySQL Workbench, in the Navigator > Administration window, select Data Import/Restore.
- In Import Options select Import from Self-Contained File.
- Navigate to the sql file located in the root directory HairSalon of this project called eva_kemp_factory.sql
- Under Default Schema to be Imported To, select the New button.
- Choose another name for your database, or use eva_kemp_factory.sql, then click OK
- Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
- After you are finished with the above steps, reopen the Navigator > Schemas tab.
- Right click and select Refresh All.
- Your new database will appear!

### Set Up and Run Project

1. Open the terminal and navigate to this project's production directory called "Factory".
2. Within the production directory "Factory", create a new file called `appsettings.json`.
3. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}
```

4. Check the .gitignore file to ensure that `appsettings.json` is listed and remains hidden.
5. Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
6. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

- None known

## License

MIT License

Copyright (c) _2023_ Eva Kemp

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
