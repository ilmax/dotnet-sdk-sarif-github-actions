var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.dotnet_sdk_sarif_github_actions_ApiService>("apiservice");

builder.AddProject<Projects.dotnet_sdk_sarif_github_actions_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
