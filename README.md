I've created this repository to explore NuGet packaging when a package references other libraries maintained by me. I've came across such issue in my day-to-day work and the first solution used separate NuGet packages for each referenced .csproj, which I regarded as superfluous. I decided to test it out on something simple.

## Details

The code contains 3 dummy libraries:
- Notes.DAL - contains a definition for an entity and its' repository
- Notes.BLL - contains a definition for a model and its' service, uses the .DAL project as explicit dependency
- Notes.BLL.Standalone - contains the same classes as Notes.BLL, but .DAL is supposed to be a private dependency - meaning that the consumer does not need to install .DAL nuget.
