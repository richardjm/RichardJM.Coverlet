# Example multi-job usage of microsoft coverage

Flipping this around to use the newer [Microsoft.Testing.Platform](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-nunit-runner-intro) and [Microsoft Code Coverage](https://learn.microsoft.com/en-us/dotnet/core/testing/microsoft-testing-platform-extensions-code-coverage#microsoft-code-coverage) library instead of coverlet.

Main issue is to ensure that the binaries to test are not rebuilt before test. We must ensure the build was deterministic in CI which isn't too onerous since .NET 8 SDK as SourceLink is in by default. Setting the `ContinuousIntegrationBuild` property locally and using [NuGet Package Manager](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer) is a good way to check for deterministic builds with pdbs in the NuGet package.
