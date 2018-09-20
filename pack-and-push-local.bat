cd src
dotnet pack
dotnet nuget push **/bin/**/*.nupkg -s http://localhost:50561/v3/index.json --no-service-endpoint

cd ..