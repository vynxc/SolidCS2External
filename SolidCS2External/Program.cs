using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.Startup;

Console.WriteLine($"C_BaseEntity.m_iHealth: {C_BaseEntity.m_iHealth}");
var serviceCollection = new ServiceCollection();
Startup.ConfigureService(serviceCollection);
await using var serviceProvider = serviceCollection.BuildServiceProvider();
var startup = serviceProvider.GetRequiredService<Startup>();
await startup.ConfigureAsync();