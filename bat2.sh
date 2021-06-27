dotnet new sln --name UsageEligibility
dotnet new classlib -n Api
dotnet new console -n AdHoc
dotnet new classlib -n Business
dotnet new classlib -n DataAccess
dotnet new classlib -n Database
dotnet new classlib -n Models
dotnet new classlib -n Tests
dotnet sln add Api/Api.csproj
dotnet sln add Business/Business.csproj
dotnet sln add DataAccess/DataAccess.csproj
dotnet sln add Database/Database.csproj
dotnet sln add Models/Models.csproj
dotnet sln add Tests/Tests.csproj