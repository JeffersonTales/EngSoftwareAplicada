using Integracoes;
using Integracoes.ConcreteFactory;
using Integracoes.Interfaces;
using Microsoft.Extensions.Configuration;
using static Integracoes.Interfaces.IIntegracoesSAPFactory;

class Program
{
    static void Main(string[] args)
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

        // Instanciando as fábricas concretas
        IIntegracoesSAPFactory sapFactory = new IntegracaoPadraoSAP();
        IIntegracoesFoccoFactory foccoFactory = new IntegracaoPadraoFocco();
        IIntegracoesTotvsFactory totvsFactory = new IntegracaoPadraoTotovs();

        // Criando o cliente de integração e passando o tipo específico para SAP
        IntegracaoClient client = new IntegracaoClient(sapFactory, foccoFactory, totvsFactory, TipoIntegracaoSAP.Alfa);

        // Executando os processos do cliente
        client.ExecutarProcessos();


        Console.ReadKey();
    }
}
