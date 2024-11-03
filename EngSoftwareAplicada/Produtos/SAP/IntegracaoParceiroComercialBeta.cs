using Integracoes.Interfaces;

namespace Integracoes.ConcretesFactory.SAP
{
    /// <summary>
    /// Produto
    /// </summary>
    public class IntegracaoParceiroComercialBeta : IIntegracaoPadraoSAP
    {
        public void ApontarProducao()
        {
            Console.WriteLine("Apontando produção para o Cliente Beta");
        }

        public void BaixarOrdensProducao()
        {
            Console.WriteLine("Baixando ordens de produção para o Cliente Beta");
        }

        public void EncerrarProducao()
        {
            Console.WriteLine("Encerrando produção para o Cliente Beta");
        }
    }
}