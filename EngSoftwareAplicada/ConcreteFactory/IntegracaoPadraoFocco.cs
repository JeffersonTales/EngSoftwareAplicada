using Integracoes.ConcretesFactory.Focco;
using Integracoes.Interfaces;

namespace Integracoes.ConcreteFactory
{

    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class IntegracaoPadraoFocco : IIntegracoes
    {
        public IIntegracaoPadraoFocco CreateIntegracaoPadraoFocco()
        {
            return new IntegracaoParceiroComercialDelta();
        }

        public IIntegracaoPadraoSAP CreateIntegracaoPadraoSAP()
        {
            return null;
        }

        public IIntegracaoPadraoTotovs CreateIntegracaoPadraoTotovs()
        {
            return null;
        }
    }
}
