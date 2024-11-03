using Integracoes.ConcretesFactory.Focco;
using Integracoes.ConcretesFactory.SAP;
using Integracoes.ConcretesFactory.Totovs;
using Integracoes.Interfaces;

namespace Integracoes.ConcreteFactory
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class IntegracaoPadraoSAP : IIntegracoes
    {
        public IIntegracaoPadraoFocco CreateIntegracaoPadraoFocco()
        {
            return null;
        }

        public IIntegracaoPadraoSAP CreateIntegracaoPadraoSAP()
        {
            return new IntegracaoParceiroComercialAlfa();
        }

        public IIntegracaoPadraoTotovs CreateIntegracaoPadraoTotovs()
        {
            return null;
        }
    }
}
