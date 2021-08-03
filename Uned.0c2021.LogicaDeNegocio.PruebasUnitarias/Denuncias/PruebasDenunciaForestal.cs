using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Uned._0c2021.LogicaDeNegocio.PruebasUnitarias.Denuncias
{
    [TestClass]
    public class PruebasDenunciaForestal
    {
        [TestMethod]
        public void DenunciaForestal_Tipo()
        {
            var elResultadoEsperado = "Incendio forestal";

            var fecha = new DateTime(2001, 1, 1);
            var denuncia = ObtengaDenuncia(fecha);
            var elResultadoObtenido = denuncia.Tipo;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void DenunciaForestal_ImpactoCritico()
        {
            var elResultadoEsperado = NivelDeImpacto.Critica;

            var fecha = new DateTime(2001, 1, 1);
            var denuncia = ObtengaDenuncia(fecha);
            var elResultadoObtenido = denuncia.Impacto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void DenunciaForestal_ImpactoLeve()
        {
            var elResultadoEsperado = NivelDeImpacto.Leve;

            var fecha = new DateTime(2001, 11, 1);
            var denuncia = ObtengaDenuncia(fecha);
            var elResultadoObtenido = denuncia.Impacto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private DenunciaDeIncendioForestal ObtengaDenuncia(DateTime fecha)
        {
            var denuncia = new DenunciaDeIncendioForestal()
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
