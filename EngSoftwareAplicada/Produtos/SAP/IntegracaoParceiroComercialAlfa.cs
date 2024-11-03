using Integracoes.Interfaces;

namespace Integracoes.ConcretesFactory.SAP
{
    /// <summary>
    /// Produto
    /// </summary>
    public class IntegracaoParceiroComercialAlfa : IIntegracaoPadraoSAP
    {
        public void ApontarProducao()
        {
            Console.WriteLine("Apontando produção para o Cliente Alfa");
        }

        public void BaixarOrdensProducao()
        {
            Console.WriteLine("Baixando ordens de produção para o Cliente Alfa");
        }

        public void EncerrarProducao()
        {
            Console.WriteLine("Encerrando produção para o Cliente Alfa");
        }

    }
}
