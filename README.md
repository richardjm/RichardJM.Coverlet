# Example multi-job usage of coverlet

Minimal implementation of [coverlet.collector](https://github.com/coverlet-coverage/coverlet) to get code coverage in a multi-job pipeline.

Main issue is to ensure that the binaries to test are not rebuilt before test. This required to ensure the build was deterministic in CI which isn't too onerous since .NET 8 SDK as SourceLink is in by default.
