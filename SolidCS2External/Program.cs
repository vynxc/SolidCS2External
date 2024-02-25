using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.Services;
using SolidCS2External.Startup;

var serviceCollection = new ServiceCollection();
Startup.ConfigureService(serviceCollection);
await using var serviceProvider = serviceCollection.BuildServiceProvider();
var cheetoService = serviceProvider.GetRequiredService<CheetoService>();
await cheetoService.Run();