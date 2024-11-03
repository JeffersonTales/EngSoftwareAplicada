using Integracoes.Interfaces;

namespace Integracoes.ConcretesFactory.Focco
{
    /// <summary>
    /// Produto
    /// </summary>
    public class IntegracaoParceiroComercialEpsilon : IIntegracaoPadraoFocco
    {
        public void ApontarProducao()
        {
            Console.WriteLine("Apontando produção para o Cliente Epsilon");
        }

        public void ApontarRefugo()
        {
            Console.WriteLine("Apontando refugo para o Cliente Epsilon");
        }

        public void BaixarOrdensProducao()
        {
            Console.WriteLine("Baixando ordens de produção para o Cliente Epsilon");
        }
    }
}
