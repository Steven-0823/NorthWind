

//IUserActionWriter Writer = new ConsoleWriter();
//IUserActionWriter Writer = new DebugWriter();
IUserActionWriter Writer = new FileWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azucar refinada");

/* AppLogger y los writers: Responsabilidad Unica 
 * AppLogger : Abierto pero cerrado 
 * AppLogger:  Inversion de Dependencias. Los modulos 
 * de alto nivel son independientes de los detalles de implementacion.
 *
 ***/