using Integracoes.ConcretesFactory.Totovs;
using Integracoes.Interfaces;

namespace Integracoes.ConcreteFactory
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class IntegracaoPadraoTotovs : IIntegracoes
    {
        public IIntegracaoPadraoFocco CreateIntegracaoPadraoFocco()
        {
            return null;
        }

        public IIntegracaoPadraoSAP CreateIntegracaoPadraoSAP()
        {
            return null;
        }

        public IIntegracaoPadraoTotovs CreateIntegracaoPadraoTotovs()
        {
            return new IntegracaoParceiroComercialZeta();
        }
    }
}
