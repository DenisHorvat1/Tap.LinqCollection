using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tap.LinqCollection;

using IHost host = Host.CreateDefaultBuilder(args)
                        .ConfigureServices((_, services) =>
                            services.AddTransient<ICarRepository, CarRepository>()
                            //@Students: Please make use of the code below to configure your Dependency injection, for Exercise 5 - DIP
                            //.AddTransient<IYourInterface, YourClass>()
                            //.AddTransient<IOtherInterface, YourOtherClass>()
                            )
                        .Build();


await host.RunAsync();
