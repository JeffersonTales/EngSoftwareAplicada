using Integracoes.Interfaces;

namespace Integracoes.ConcretesFactory.Totvs
{
    /// <summary>
    /// Produto
    /// </summary>
    public class IntegracaoParceiroComercialZeta : IIntegracaoPadraoTotvs
    {
        public void ApontarProducao()
        {
            Console.WriteLine("Apontando produção para o Cliente Zeta");
        }

        public void BaixarOrdensProducao()
        {
            Console.WriteLine("Baixando ordens de produção para o Cliente Zeta");
        }

        public void BaixarRecursos()
        {
            Console.WriteLine("Baixando recursos para o Cliente Zeta");
        }

        public void EncerrarProducao()
        {
            Console.WriteLine("Encerrando produção para o Cliente Zeta");
        }
    }
}
