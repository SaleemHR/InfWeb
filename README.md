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

### Lecture 0: Entity Framework
  >+ Create a console app with logical name (say Lecute0EF) <BR>
  >    - dotnet new console -o Lecture0EF <BR>
  >    - cd Exam <BR>

  >+ Add the following NuGet Packges <BR>
  >    - dotnet add package  Microsoft. EntityFrameworkCore.Design <BR>
  >    - dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL <BR>
  
  >+	Open project directory in VS Code  (you may add packages via terminal in vs code) <BR>

  >+ For migrations you might need to install (ef tools, and then run migration and update database)<BR>
  >    - dotnet tool install --global dotnet-ef <BR>
  >    - dotnet ef migrations add migrationName <BR>
  >    - dotnet ef database update <BR>

#### Unit Test (not available yet)
  dotnet new mstest -o ProjectName
  dotnet sln add ProjectFolderToBeTested/ProjectToBeTested.csproj

### Lecture 1, 2, 3:
  Backend (api, controller, services)
### Lecture 4: Typescript
+ ``yarn init `` to create typescript application 
+ ``Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass`` if you get error  *You cannot run this script on the current system*
+ ``npm install --global yarn`` if yarn is not installed <url>https://www.typescriptlang.org/download</url>

+ ``yarn add typescript -D`` 
+ ``touch SomeSuorceFile.ts`` to create Some Source Code file with .ts 
+ ``yarn tsc --init``

> **Enabel from tsconfig.json file**
>  - "incremental": true,
>  - "composite": true,
>  - "outDir": "./bin",  
>  - "target": "ES2020", 
>  - "sourceMap": true,
>  - "noImplicitAny": true,/
>  - "strictNullChecks": true

+ Hello world in sourcecode.ts file

  ``console.log("Hello World")``
+ ``yarn tsc -w`` -w is for watch you could run with out watch as well

+ ``node bin/SomeSourceFile.js`` to execute for output
  - or add in package.json file to run atomatically
    ```
    "scripts": {
    "start": "node bin/SomeSourceFile.js" }
  - yarn start
+ some useful link <url> https://www.typescriptlang.org/docs/handbook/typescript-tooling-in-5-minutes.html
### Lecture 5
  React Typescript
### Lecture 6
  Combininig backend frontend
