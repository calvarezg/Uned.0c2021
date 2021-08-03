using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Uned._0c2021.LogicaDeNegocio.PruebasUnitarias.Denuncias
{
    [TestClass]
    public class PruebasDenunciaUrbana
    {
        [TestMethod]
        public void DenunciaUrbana_Tipo()
        {
            var elResultadoEsperado = "Urbana";
            
            var fecha = new DateTime(2001, 1, 1);
            var denuncia = ObtengaDenuncia(fecha);
            var elResultadoObtenido = denuncia.Tipo;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void DenunciaUrbana_Impacto()
        {
            var elResultadoEsperado = NivelDeImpacto.Leve;

            var fecha = new DateTime(2001, 1, 1);
            var denuncia = ObtengaDenuncia(fecha);
            var elResultadoObtenido = denuncia.Impacto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private DenunciaUrbana ObtengaDenuncia(DateTime fecha)
        {
            var denuncia = new DenunciaUrbana() 
            { 
                Titulo = "Denuncia de prueba 1", 
                Estado = EstadoDeDenuncia.Registrada, 
                Fecha = fecha, 
                Latitud = 1232321, 
                Longitud = 234433 
            };
            return denuncia;
        }
    }
}
