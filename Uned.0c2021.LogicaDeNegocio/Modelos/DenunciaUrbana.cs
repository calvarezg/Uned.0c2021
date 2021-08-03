namespace Uned._0c2021.LogicaDeNegocio
{
    public class DenunciaUrbana : Denuncia
    {
        public DenunciaUrbana()
        {
            Tipo = "Urbana";
        }
        protected override NivelDeImpacto CalculeImpacto()
        {
            return NivelDeImpacto.Leve;
        }
    }
}


