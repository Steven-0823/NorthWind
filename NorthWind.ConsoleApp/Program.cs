

//IUserActionWriter Writer = new ConsoleWriter();
//IUserActionWriter Writer = new DebugWriter();

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddConsoleWriter();
Builder.Services.AddDebugWriter();
Builder.Services.AddFileWriter();

Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();


AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();	
Logger.WriteLog("Application started.");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azucar refinada");

/* AppLogger y los writers: Responsabilidad Unica 
 * AppLogger : Abierto pero cerrado 
 * AppLogger:  Inversion de Dependencias. Los modulos 
 * de alto nivel son independientes de los detalles de implementacion.
 *
 ***/