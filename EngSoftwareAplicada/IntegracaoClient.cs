using Integracoes.Interfaces;
using static Integracoes.Interfaces.IIntegracoesFoccoFactory;
using static Integracoes.Interfaces.IIntegracoesSAPFactory;
using static Integracoes.Interfaces.IIntegracoesTotvsFactory;

namespace Integracoes
{

    /// <summary>
    /// Service
    /// </summary>
    public class IntegracaoClient
    {
        public readonly IIntegracaoPadraoSAP integracaoPadraoSAP;
        public readonly IIntegracaoPadraoFocco integracaoPadraoFocco;
        public readonly IIntegracaoPadraoTotvs integracaoPadraoTotvs;

        public IntegracaoClient(IIntegracoesSAPFactory sapFactory,
                                IIntegracoesFoccoFactory foccoFactory,
                                IIntegracoesTotvsFactory totvsFactory,
                                TipoIntegracaoSAP tipoSAP,
                                TipoIntegracaoFocco tipoFocco,
                                TipoIntegracaoTotvs tipoTotvs)
        {
            this.integracaoPadraoSAP = sapFactory.CreateIntegracaoPadraoSAP(tipoSAP);
            //this.integracaoPadraoFocco = foccoFactory.CreateIntegracaoPadraoFocco(tipoFocco);
            //this.integracaoPadraoTotvs = totvsFactory.CreateIntegracaoPadraoTotvs(tipoTotvs);
        }

        public IntegracaoClient(IIntegracoesSAPFactory sapFactory,
                                IIntegracoesFoccoFactory foccoFactory,
                                IIntegracoesTotvsFactory totvsFactory,
                                TipoIntegracaoSAP tipoSAP)
        {
            this.integracaoPadraoSAP = sapFactory.CreateIntegracaoPadraoSAP(tipoSAP);
            //this.integracaoPadraoFocco = foccoFactory.CreateIntegracaoPadraoFocco(tipoFocco);
            //this.integracaoPadraoTotvs = totvsFactory.CreateIntegracaoPadraoTotvs(tipoTotvs);
        }


        public void ExecutarProcessos()
        {
            integracaoPadraoSAP.BaixarOrdensProducao();
            integracaoPadraoSAP.ApontarProducao();
            integracaoPadraoSAP.EncerrarProducao();
        }
    }

}
