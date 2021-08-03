namespace Uned._0c2021.LogicaDeNegocio
{
    public class Calendario
    {
        private const int ENERO = 1;
        private const int MAYO = 5;
        public static bool EsDeLaTemporadaSeca(int elMes)
        {
            var esDiciembre = EsDiciembre(elMes);
            bool estaEntreEneroYAbril = elMes >= ENERO && elMes < MAYO;
            return esDiciembre || estaEntreEneroYAbril;
        }
        private static bool EsDiciembre(int elMes)
        {
            const int DICIEMBRE = 12;
            return elMes == DICIEMBRE;
        }
    }
}
