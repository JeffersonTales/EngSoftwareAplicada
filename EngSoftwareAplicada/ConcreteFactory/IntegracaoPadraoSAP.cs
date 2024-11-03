using Integracoes.ConcretesFactory.SAP;
using Integracoes.Interfaces;
using static Integracoes.Interfaces.IIntegracoesSAPFactory;

namespace Integracoes.ConcreteFactory
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class IntegracaoPadraoSAP : IIntegracoesSAPFactory
    {
        public IIntegracaoPadraoSAP CreateIntegracaoPadraoSAP(TipoIntegracaoSAP tipo)
        {
            return tipo switch
            {
                TipoIntegracaoSAP.Alfa => new IntegracaoParceiroComercialAlfa(),
                TipoIntegracaoSAP.Beta => new IntegracaoParceiroComercialBeta(),
                TipoIntegracaoSAP.Gama => new IntegracaoParceiroComercialGama(),
                _ => throw new ArgumentException("Tipo de integração SAP inválido")
            };
        }
    }
}
