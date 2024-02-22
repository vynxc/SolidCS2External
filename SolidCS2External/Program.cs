//using BenchmarkDotNet.Running;
using Microsoft.Extensions.DependencyInjection;
//using SolidCS2External.Benchmarks;
using SolidCS2External.Startup;

//var summary = BenchmarkRunner.Run<MemoryBenchmark>(); 
//Console.WriteLine(summary.ToString());
var serviceCollection = new ServiceCollection();
Startup.ConfigureService(serviceCollection);
await using var serviceProvider = serviceCollection.BuildServiceProvider();
var startup = serviceProvider.GetRequiredService<Startup>();
await startup.ConfigureAsync();