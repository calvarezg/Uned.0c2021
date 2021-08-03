using System.ComponentModel;

namespace Uned._0c2021.LogicaDeNegocio
{
    public enum NivelDeImpacto
    {
        [Description("Denuncia de bajo impacto leve")]
        Leve = 1,
        [Description("Denuncia de impacto moderado. Debe procursarse su solución pronta")]
        Moderada = 2,
        [Description("Denuncia de impacto crítico. Debe atenderse de inmediato")]
        Critica = 3
    }
}
