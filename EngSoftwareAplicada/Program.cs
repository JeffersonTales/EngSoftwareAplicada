using Microsoft.Extensions.Configuration;

class Program
{
    static void Main()
    {
        // Configuração do Builder para carregar o appsettings.json
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        IConfiguration config = builder.Build();

        // Leitura de valores de configuração
        string appName = config["ApplicationName"];
        string defaultConnection = config.GetSection("ConnectionStrings")["DefaultConnection"]; //

        Console.WriteLine($"Application Name: {appName}");
        Console.WriteLine($"Default Connection: {defaultConnection}");
    }
}
