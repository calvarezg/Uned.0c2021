using System;

namespace Uned._0c2021.LogicaDeNegocio
{
    public class DenunciaPositiva : Denuncia
    {
        public DenunciaPositiva()
        {
            Tipo = "Positiva";
        }
        protected override NivelDeImpacto CalculeImpacto()
        {
            throw new Exception("Este tipo de denuncias no tienen impacto");
        }
    }
}
