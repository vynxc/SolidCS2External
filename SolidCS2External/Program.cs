using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.Game.Offsets;
using SolidCS2External.Startup;

await OffsetsUpdater.UpdateOffsets();
var offset = OffsetsReader.ReadOffset("client.dll.json", "ActiveModelConfig_t", "m_AssociatedEntities");
var offset2 = OffsetsReader.ReadOffset("offsets.json", "client_dll", "dwEntityList");
Console.WriteLine($"Found offset: {offset}");
Console.WriteLine($"Found offset: {offset2}");
var serviceCollection = new ServiceCollection();
Startup.ConfigureService(serviceCollection);
await using var serviceProvider = serviceCollection.BuildServiceProvider();
var startup = serviceProvider.GetRequiredService<Startup>();
await startup.ConfigureAsync();