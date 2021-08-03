using System.Collections.Generic;
using Uned._0c2021.LogicaDeNegocio;

namespace Uned._0c2021.InterfazGrafica
{    
    internal class BaseDeDatos
    {

        private static List<Denuncia> lasDenuncias = new List<Denuncia>();
        public static void Guarde(Denuncia denuncia)
        {
            lasDenuncias.Add(denuncia);
        }

        public static List<Denuncia> ListarDenuncias()
        {
            return lasDenuncias;
        }
    }
}