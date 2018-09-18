dotnet pack
dotnet nuget push **/*.nupkg -s http://localhost:50561/v3/index.json --no-service-endpoint