using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.Startup;

var serviceCollection = new ServiceCollection();
Startup.ConfigureService(serviceCollection);
await using var serviceProvider = serviceCollection.BuildServiceProvider();
var startup = serviceProvider.GetRequiredService<Startup>();
await startup.ConfigureAsync();
