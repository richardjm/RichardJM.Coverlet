# Example multi-job usage of coverlet

Minimal implementation of [coverlet.collector](https://github.com/coverlet-coverage/coverlet) to get code coverage in a multi-job pipeline.

Main issue is to ensure that the binaries to test are not rebuilt before test, and the step of `dotnet publish` is also not necessary. We must ensure the build was deterministic in CI which isn't too onerous since .NET 8 SDK as SourceLink is in by default. Setting the `ContinuousIntegrationBuild` property locally and using [NuGet Package Manager](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer) is a good way to check for deterministic builds with pdbs in the NuGet package.
