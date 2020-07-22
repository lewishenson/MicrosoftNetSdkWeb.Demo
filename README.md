# ASP.NET Core Web SDK integration test gotcha

## Issue
When running integration tests a `404 Not Found` response is returned instead of the expected response type.

## Cause
Using a custom `Startup.cs` file in the test project will mean controllers in the web project are not discovered.

## Solution
Ensure that the integration test project references the Microsoft.NET.Sdk.Web in the `*.csproj` file:

```xml
<Project Sdk="Microsoft.NET.Sdk.Web">
  <!-- existing project configuration -->
</Project>
```

## Demonstration
This repository demos this behaviour. There is a simple web application (based on the standard WebAPI template) that has an endpoint to return weather forecasts.

There are two integration test projects each with a copy of the same single test. The test in `MicrosoftNetSdkWeb.Demo.WorkingTest.csproj` will pass while the test in `MicrosoftNetSdkWeb.Demo.BrokenTest.csproj` will fail. The only difference is the SDK reference in the `*.csproj` file.
