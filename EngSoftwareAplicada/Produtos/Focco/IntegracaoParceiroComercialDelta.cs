using Integracoes.Interfaces;

namespace Integracoes.ConcretesFactory.Focco
{
    /// <summary>
    /// Produto
    /// </summary>
    public class IntegracaoParceiroComercialDelta : IIntegracaoPadraoFocco
    {
        public void ApontarProducao()
        {
            Console.WriteLine("Apontando produção para o Cliente Delta");
        }

        public void ApontarRefugo()
        {
            Console.WriteLine("Apontando refugo para o Cliente Delta");
        }

        public void BaixarOrdensProducao()
        {
            Console.WriteLine("Baixando ordens de produção para o Cliente Delta");
        }
    }
}
