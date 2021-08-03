namespace Uned._0c2021.LogicaDeNegocio
{
    public class DenunciaDeIncendioForestal : Denuncia
    {
        public DenunciaDeIncendioForestal()
        {
            Tipo = "Incendio forestal";
        }
        protected override NivelDeImpacto CalculeImpacto()
        {
            var elMesEnQueSucedioLaDenuncia = Fecha.Month;
            if (Calendario.EsDeLaTemporadaSeca(elMesEnQueSucedioLaDenuncia))
                return NivelDeImpacto.Critica;
            return NivelDeImpacto.Leve;
        }
    }
}
