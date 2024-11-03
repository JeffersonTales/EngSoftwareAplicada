using Integracoes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Integracoes.Interfaces.IIntegracoesSAPFactory;

namespace Integracoes
{

    /// <summary>
    /// Service
    /// </summary>
    public class IntegracaoClient
    {
        public readonly IIntegracaoPadraoSAP integracaoPadraoSAP;
        public readonly IIntegracaoPadraoFocco integracaoPadraoFocco;
        public readonly IIntegracaoPadraoTotovs integracaoPadraoTotovs;

        public IntegracaoClient(
            IIntegracoesSAPFactory sapFactory,
            IIntegracoesFoccoFactory foccoFactory,
            IIntegracoesTotvsFactory totvsFactory,
            TipoIntegracaoSAP tipoSAP)  // Parâmetro para escolher o tipo de SAP
        {
            this.integracaoPadraoSAP = sapFactory.CreateIntegracaoPadraoSAP(tipoSAP);
            //this.integracaoPadraoFocco = foccoFactory.CreateIntegracaoPadraoFocco();
            //this.integracaoPadraoTotovs = totvsFactory.CreateIntegracaoPadraoTotovs();
        }

        public void ExecutarProcessos()
        {
            integracaoPadraoSAP.BaixarOrdensProducao();
            integracaoPadraoFocco.ApontarProducao();
            integracaoPadraoTotovs.EncerrarProducao();
        }
    }

}
