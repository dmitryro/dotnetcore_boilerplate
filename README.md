

# README 

To run this specific example just get packages, build and run it, but if you create from scratch, follow the steps below. You still need to get the packages once you clone the repository.


##  To create a new project (if you don't use the code provided)
```
dotnet new webapi -o Boilerplate
```

## cd into the project dir
```
cd Boilerplate
```



## Add the packages so the project can be built
```
dotnet add package Swashbuckle.AspNetCore
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.Extensions.Caching.Abstractions
dotnet add package System.Net.Http.Json
dotnet add package Newtonsoft.Json
dotnet add package Norm.net
dotnet add package Swashbuckle.AspNetCore
dotnet add package System.Linq.Async
```

## Build the Project

```
dotnet build
```


## Run the Project

```
dotnet run
```


## Check the API

Open broser at https://localhost:5001/api/record
You should get the response from API
For other endpoints - check the Controllers definitions and follow same routing convention **api/helloworld**, **api/record/<id>** etc.



