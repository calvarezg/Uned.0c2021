using System;

namespace Uned._0c2021.LogicaDeNegocio
{
    public abstract class Denuncia
    {
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public EstadoDeDenuncia Estado { get; set; }   
        public string Tipo { protected set; get; }
        public NivelDeImpacto Impacto
        {
            get
            {
                return CalculeImpacto();
            }
        }        
        protected abstract NivelDeImpacto CalculeImpacto();
    }
}
