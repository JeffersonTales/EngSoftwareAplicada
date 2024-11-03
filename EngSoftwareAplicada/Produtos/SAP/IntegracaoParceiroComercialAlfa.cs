using Integracoes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integracoes.ConcretesFactory.SAP
{
    /// <summary>
    /// Produto
    /// </summary>
    public class IntegracaoParceiroComercialAlfa : IIntegracaoPadraoSAP
    {
        public void ApontarProducao()
        {
            throw new NotImplementedException();
        }

        public void BaixarOrdensProducao()
        {
            throw new NotImplementedException();
        }

        public void EncerrarProducao()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Integração para o Cliente Alfa com o padrão SAP foi criada.";
        }
    }
}
