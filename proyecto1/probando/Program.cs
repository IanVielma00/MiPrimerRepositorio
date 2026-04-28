using Microsoft.Extensions.Configuration;

var config = new ConfigurationManager();
config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

var connectionString = config.GetConnectionString("DefaultConnection") ?? "Cadena de conexión no encontrada";
Console.WriteLine("Hello, Roda!");
Console.WriteLine($"Cadena de conexión simulada: {connectionString}");

string stripe_api_key = "sk_test_51N8m9uK9y0n9oz1ad3e4f5g6h7i8j9k0l1m2n3o";

