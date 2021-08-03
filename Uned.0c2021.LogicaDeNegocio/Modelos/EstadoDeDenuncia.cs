using System.ComponentModel;

namespace Uned._0c2021.LogicaDeNegocio
{
    public enum EstadoDeDenuncia
    {
        [Description("Registrada")]
        Registrada = 0,

        [Description("Denegada por un juez")]
        Denegada = 1,

        [Description("En Proceso")]
        EnProceso = 2,

        [Description("Atendida")]
        Atendida = 3,

        [Description("Finalizada")]
        Finalizada = 4
    }
}