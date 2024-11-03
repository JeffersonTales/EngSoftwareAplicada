namespace Integracoes.Interfaces
{
    /// <summary>
    /// Abstract Factory para integrações Focco
    /// </summary>
    public interface IIntegracoesFoccoFactory
    {
        IIntegracaoPadraoFocco CreateIntegracaoPadraoFocco(TipoIntegracaoFocco tipo);

        public enum TipoIntegracaoFocco
        {
            Delta,
            Epsilon
        }

    }

    /// <summary>
    /// Abstract Factory para integrações SAP
    /// </summary>
    public interface IIntegracoesSAPFactory
    {
        IIntegracaoPadraoSAP CreateIntegracaoPadraoSAP(TipoIntegracaoSAP tipo);

        public enum TipoIntegracaoSAP
        {
            Alfa,
            Beta,
            Gama
        }
    }

    /// <summary>
    /// Abstract Factory para integrações Totvs
    /// </summary>
    public interface IIntegracoesTotvsFactory
    {
        IIntegracaoPadraoTotovs CreateIntegracaoPadraoTotovs(TipoIntegracaoTotovs tipo);

        public enum TipoIntegracaoTotovs
        {
            Zeta
        }
    }
}
