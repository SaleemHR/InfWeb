# InfWeb
INFWEB course
The course is devided in two parts
## Backend
  1. Web Api (api)
  2. Entity Framework

## Frontend
  1. Typescrip
  2. React Typescript
  3. Extra stuff

Lecture devision: (not final yet)

### Lecture 0:
  Entity Framework
  a.	Create a console app with logical name (say Lecute0EF) 
        dotnet new console -o Lecture0EF 
        cd Exam 
  b.	Add the following NuGet Packges 
        dotnet add package  Microsoft.EntityFrameworkCore.Design 
        dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL 
  c.	Open project directory in VS Code  (you may add packages via terminal in vs code) 

  d.  For migrations you might need to install (ef tools, and then run migration and update database)
      dotnet tool install --global dotnet-ef 
      dotnet ef migrations add migrationName 
      dotnet ef database update 

### Lecture 1, 2, 3:
  Backend (api, controller, services)
### Lecture 4
  Typescript
### Lecture 5
  React Typescript
### Lecture 6
  Combininig backend frontend
