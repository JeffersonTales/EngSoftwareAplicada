using Integracoes.ConcretesFactory.Totvs;
using Integracoes.Interfaces;
using static Integracoes.Interfaces.IIntegracoesTotvsFactory;

namespace Integracoes.ConcreteFactory
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class IntegracaoPadraoTotvs : IIntegracoesTotvsFactory
    {
        public IIntegracaoPadraoTotvs CreateIntegracaoPadraoTotvs(TipoIntegracaoTotvs tipo)
        {
            return tipo switch
            {
                TipoIntegracaoTotvs.Zeta => new IntegracaoParceiroComercialZeta(),
                _ => throw new ArgumentException("Tipo de integração Totvs inválido")
            };
        }
    }
}
