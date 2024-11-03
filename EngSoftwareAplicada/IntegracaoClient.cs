using Integracoes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IntegracaoClient(IIntegracoes integracoesFactory)
        {
                this.integracaoPadraoSAP = integracoesFactory.CreateIntegracaoPadraoSAP();
                this.integracaoPadraoFocco = integracoesFactory.CreateIntegracaoPadraoFocco();
                this.integracaoPadraoTotovs = integracoesFactory.CreateIntegracaoPadraoTotovs();
        }


    }
}
