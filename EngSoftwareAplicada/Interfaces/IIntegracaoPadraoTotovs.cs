namespace Integracoes.Interfaces
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public interface IIntegracaoPadraoTotovs
    {

        void BaixarOrdensProducao();

        void ApontarProducao();

        void EncerrarProducao();

        void BaixarRecursos();
    }
}
