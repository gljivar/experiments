using Microsoft.Azure.Cosmos;
using Azure.Identity;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// New instance of CosmosClient class
using CosmosClient client = new(
    accountEndpoint: Environment.GetEnvironmentVariable("COSMOS_ENDPOINT"),
    tokenCredential: new DefaultAzureCredential()
);