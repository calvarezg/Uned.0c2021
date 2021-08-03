using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Uned._0c2021.LogicaDeNegocio;

namespace Uned._0c2021.InterfazGrafica
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            //ImprimaDosDenuncias();
            //SoliciteAlUsuarioCrearNuevasDenuncias();
        }
        private static void SoliciteAlUsuarioCrearNuevasDenuncias()
        {
            while (true)
            {
                Console.Write("Digite el título: ");
                var param1 = Console.ReadLine();
                Console.Write("Digite la latitud: ");
                var param2 = Console.ReadLine();
                Console.Write("Digite la longitud: ");
                var param3 = Console.ReadLine();
                Console.Write("Indique el estado (número entre 0 y 4): ");
                var param4 = Console.ReadLine();
                Console.Write("Digite la fecha (yyyy-MM-dd): ");
                var param5 = Console.ReadLine();
                Console.Write("Indique el tipo (1- Urbana, 2- Forestal): ");
                var param6 = Console.ReadLine();

                switch (param6)
                {
                    case "1":
                        CrearNuevaDenunciaUrbana(param1, param2, param3, param4, param5);
                        break;
                    case "2":
                        CrearNuevaDenunciaForestal(param1, param2, param3, param4, param5);
                        break;
                }
                ImprimirDenuncias();
                Console.Write("Digite cualquier tecla para agregar otra denuncia...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private static void ImprimaDosDenuncias()
        {
            var d1 = new DenunciaUrbana() { Titulo = "Denuncia de prueba 1", Estado = EstadoDeDenuncia.Registrada, Fecha = DateTime.Now, Latitud = 1232321, Longitud = 234433 };
            var d2 = new DenunciaDeIncendioForestal() { Titulo = "Denuncia de prueba 2", Estado = EstadoDeDenuncia.Registrada, Fecha = DateTime.Now, Latitud = 1232321, Longitud = 234433 };
            Imprimir(d1);
            Console.WriteLine(new string('-', 80));
            Imprimir(d2);
        }
        private static void ImprimirDenuncias()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Lista de denuncias:");
            Console.WriteLine();
            var lasDenuncias = BaseDeDatos.ListarDenuncias();
            lasDenuncias.ForEach(d =>
            {
                Imprimir(d);
                Console.WriteLine(new string('-', 80));
            });
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void Imprimir(Denuncia denuncia)
        {
            Console.WriteLine($"\tTítulo: {denuncia.Titulo}");
            Console.WriteLine($"\tTítulo: {denuncia.Tipo}");
            Console.WriteLine($"\tFecha: {denuncia.Fecha}");
            Console.WriteLine($"\tLatitud: {denuncia.Latitud}");
            Console.WriteLine($"\tLongitud: {denuncia.Longitud}");
            Console.WriteLine($"\tEstado: {ObtenerDescripcion(denuncia.Estado)}");
            Console.WriteLine($"\tNivel de impacto: {ObtenerDescripcion(denuncia.Impacto)}");
        }
        public static void CrearNuevaDenunciaUrbana(
            string param1, string param2,
            string param3, string param4, string param5)
        {
            var denuncia = new DenunciaUrbana();
            denuncia.Titulo = param1;
            denuncia.Latitud = double.Parse(param2);
            denuncia.Longitud = double.Parse(param3);
            denuncia.Estado = (EstadoDeDenuncia)int.Parse(param4);
            denuncia.Fecha = DateTime.Parse(param5);
            if (string.IsNullOrEmpty(denuncia.Titulo))
            {
                throw new Exception("La denuncia debe tener un título");
            }
            BaseDeDatos.Guarde(denuncia);
        }
        public static void CrearNuevaDenunciaForestal(
            string param1, string param2,
            string param3, string param4, string param5)
        {
            var denuncia = new DenunciaDeIncendioForestal();
            denuncia.Titulo = param1;
            denuncia.Latitud = double.Parse(param2);
            denuncia.Longitud = double.Parse(param3);
            denuncia.Estado = (EstadoDeDenuncia)int.Parse(param4);
            denuncia.Fecha = DateTime.Parse(param5);
            if (string.IsNullOrEmpty(denuncia.Titulo))
            {
                throw new Exception("La denuncia debe tener un título");
            }
            BaseDeDatos.Guarde(denuncia);
        }
        public static string ObtenerDescripcion<T>(T enumerado)
        {
            return enumerado.GetType()
                        .GetMember(enumerado.ToString())
                        .First()
                        .GetCustomAttribute<DescriptionAttribute>()?
                        .Description ?? string.Empty;
        }
    }
}
