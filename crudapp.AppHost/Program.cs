var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.crudapp_ApiService>("apiservice");

builder.AddProject<Projects.crudapp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
