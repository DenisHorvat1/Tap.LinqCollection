using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using IHost host = Host.CreateDefaultBuilder(args)
                        .ConfigureServices((_, services) =>
                            services.AddTransient<IReportService, ReportService>()
                            //@Students: Please make use of the code below to configure your Dependency injection, for Exercise 5 - DIP
                            //.AddTransient<IYourInterface, YourClass>()
                            //.AddTransient<IOtherInterface, YourOtherClass>()
                            )
                        .Build();


await host.RunAsync();
