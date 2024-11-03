namespace Integracoes.Interfaces
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public interface IIntegracaoPadraoTotvs
    {

        void BaixarOrdensProducao();

        void ApontarProducao();

        void EncerrarProducao();

        void BaixarRecursos();
    }
}
