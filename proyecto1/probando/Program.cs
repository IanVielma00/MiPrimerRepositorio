using Microsoft.Extensions.Configuration;

var config = new ConfigurationManager();
config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

var connectionString = config.GetConnectionString("DefaultConnection") ?? "Cadena de conexión no encontrada";
Console.WriteLine("Hello, Roda!");
Console.WriteLine($"Cadena de conexión simulada: {connectionString}");
