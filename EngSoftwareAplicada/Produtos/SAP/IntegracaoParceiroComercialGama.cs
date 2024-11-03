using Integracoes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integracoes.ConcretesFactory.SAP
{
    public class IntegracaoParceiroComercialGama : IIntegracaoPadraoSAP
    {
        public void ApontarProducao()
        {
            Console.WriteLine("Apontando produção para o Cliente Gama");
        }

        public void BaixarOrdensProducao()
        {
            Console.WriteLine("Baixando ordens de produção para o Cliente Gama");
        }

        public void EncerrarProducao()
        {
            Console.WriteLine("Encerrando produção para o Cliente Gama");
        }
    }
}
