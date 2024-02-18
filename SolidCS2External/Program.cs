using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.Game.Offsets;
using SolidCS2External.Game.Offsets.Attributes;
using SolidCS2External.Startup;

await OffsetsUpdater.UpdateOffsets();
OffsetsWithFilePath.FillOffsets();
Console.WriteLine($"dwPrediction: {client_dll.dwPrediction}");
var serviceCollection = new ServiceCollection();
Startup.ConfigureService(serviceCollection);
await using var serviceProvider = serviceCollection.BuildServiceProvider();
var startup = serviceProvider.GetRequiredService<Startup>();
await startup.ConfigureAsync();