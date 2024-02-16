using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.Startup;
using SolidCS2External.Utils;

var serviceCollection = new ServiceCollection();
Startup.ConfigureService(serviceCollection);
await using var serviceProvider = serviceCollection.BuildServiceProvider();
var startup = serviceProvider.GetRequiredService<Startup>();
await startup.ConfigureAsync();
