using Integracoes.ConcretesFactory.Focco;
using Integracoes.Interfaces;
using static Integracoes.Interfaces.IIntegracoesFoccoFactory;
namespace Integracoes.ConcreteFactory
{

    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class IntegracaoPadraoFocco : IIntegracoesFoccoFactory
    {
        public IIntegracaoPadraoFocco CreateIntegracaoPadraoFocco(TipoIntegracaoFocco tipo)
        {
            return tipo switch
            {
                TipoIntegracaoFocco.Delta => new IntegracaoParceiroComercialDelta(),
                TipoIntegracaoFocco.Epsilon => new IntegracaoParceiroComercialEpsilon(),
                _ => throw new ArgumentException("Tipo de integração Focco inválido")
            };
        }
    }
}
