using Integracoes;
using Integracoes.ConcreteFactory;
using Integracoes.Interfaces;
using Microsoft.Extensions.Configuration;

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

        IIntegracoes integracaoAlfa = new IntegracaoPadraoSAP();
        IntegracaoClient clientAlfa = new IntegracaoClient(integracaoAlfa);
        Console.WriteLine(clientAlfa.integracaoPadraoSAP.ToString());

        IIntegracoes integracaoBeta = new IntegracaoPadraoSAP();
        IntegracaoClient clientBeta = new IntegracaoClient(integracaoBeta);

        IIntegracoes integracaoGama = new IntegracaoPadraoSAP();
        IntegracaoClient clientGama = new IntegracaoClient(integracaoGama);

        IIntegracoes integracaoDelta = new IntegracaoPadraoFocco();
        IIntegracoes integracaoEpsilon = new IntegracaoPadraoFocco();
        IntegracaoClient clientDelta = new IntegracaoClient(integracaoDelta);
        IntegracaoClient clientEpsilon = new IntegracaoClient(integracaoEpsilon);


        IIntegracoes integracaoZeta = new IntegracaoPadraoTotovs();
        IntegracaoClient clientZeta = new IntegracaoClient(integracaoZeta);


        Console.ReadKey();
    }
}
