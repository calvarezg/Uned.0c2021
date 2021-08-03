using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uned._0c2021.LogicaDeNegocio.PruebasUnitarias.Calendario
{
    [TestClass]
    public class PruebasTemporadaSeca
    {
        private bool RespuestaEsperada { get; set; }
        private bool RespuestaObtenida { get; set; }

        [TestMethod]
        public void Calendario_EsDeLaTemporadaSeca_DiciembreVerdadero()
        {
            const int DICIEMBRE = 12;
            RespuestaEsperada = true;

            RespuestaObtenida = LogicaDeNegocio.Calendario.EsDeLaTemporadaSeca(DICIEMBRE);

            Assert.AreEqual(RespuestaEsperada, RespuestaObtenida);
        }

        [TestMethod]
        public void Calendario_EsDeLaTemporadaSeca_EneroAAbrilVerdadero()
        {
            RespuestaEsperada = true;

            for (var elMes = 1; elMes < 5; elMes++)
            {
                RespuestaObtenida = LogicaDeNegocio.Calendario.EsDeLaTemporadaSeca(elMes);
                Assert.AreEqual(RespuestaEsperada, RespuestaObtenida);
            }
        }
        
        [TestMethod]
        public void Calendario_EsDeLaTemporadaSeca_MayoANoviembreFalso()
        {
            RespuestaEsperada = false;

            for (var elMes = 5; elMes < 12; elMes++)
            {
                RespuestaObtenida = LogicaDeNegocio.Calendario.EsDeLaTemporadaSeca(elMes);
                Assert.AreEqual(RespuestaEsperada, RespuestaObtenida);
            }
        }
    }
}
