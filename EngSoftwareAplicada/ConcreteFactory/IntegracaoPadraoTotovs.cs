using Integracoes.ConcretesFactory.SAP;
using Integracoes.ConcretesFactory.Totovs;
using Integracoes.Interfaces;
using static Integracoes.Interfaces.IIntegracoesSAPFactory;
using static Integracoes.Interfaces.IIntegracoesTotvsFactory;

namespace Integracoes.ConcreteFactory
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class IntegracaoPadraoTotovs : IIntegracoesTotvsFactory
    {
        public IIntegracaoPadraoTotovs CreateIntegracaoPadraoTotovs(TipoIntegracaoTotovs tipo)
        {
            return tipo switch
            {
                TipoIntegracaoTotovs.Zeta => new IntegracaoParceiroComercialZeta(),
                _ => throw new ArgumentException("Tipo de integração Totovs inválido")
            };
        }
    }
}
