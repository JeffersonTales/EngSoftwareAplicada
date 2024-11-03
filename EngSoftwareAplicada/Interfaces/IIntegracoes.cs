namespace Integracoes.Interfaces
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IIntegracoes
    {

        IIntegracaoPadraoFocco CreateIntegracaoPadraoFocco();

        IIntegracaoPadraoSAP CreateIntegracaoPadraoSAP();

        IIntegracaoPadraoTotovs CreateIntegracaoPadraoTotovs();

    }
}
