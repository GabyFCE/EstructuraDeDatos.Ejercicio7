using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ejercicio7
{
    internal static class Ingreso
    {
        //Se ingresa texto que se desea que se ejecute en loop, valor minimo y maximo a validar
        public static int Entero(string texto, int? minimo, int? maximo)
        {
            int entero;
            while (true)
            {
                Console.WriteLine("Ingrese " + texto);
                var ingreso = Console.ReadLine();
                if (!Validaciones.ValidarEntero(ingreso, minimo, maximo, out int valor, out string errorEntero))
                {
                    Console.WriteLine(errorEntero);
                    continue;
                }
                entero = valor;
                break;

            }

            return entero;
        }

        //Se ingresa texto que se desea que se ejecute en loop, valor minimo y maximo a validar
        public static long EnteroLargo(string texto, long? minimo, long? maximo)
        {
            long enteroLargo;
            while (true)
            {
                Console.WriteLine("Ingrese " + texto);
                var ingreso = Console.ReadLine();
                if (!Validaciones.ValidarEnteroLargo(ingreso, minimo, maximo, out long valor, out string errorEnteroLargo))
                {
                    Console.WriteLine(errorEnteroLargo);
                    continue;
                }
                enteroLargo = valor;
                break;

            }

            return enteroLargo;
        }

        //Se ingresa texto que se desea que se ejecute en loop, valor minimo y maximo a validar
        public static decimal Decimal(string texto, decimal? minimo, decimal? maximo)
        {
            decimal numeroDecimal;
            while (true)
            {
                Console.WriteLine("Ingrese " + texto);
                var ingreso = Console.ReadLine();
                if (!Validaciones.ValidarDecimal(ingreso, minimo, maximo, out decimal valor, out string errorDecimal))
                {
                    Console.WriteLine(errorDecimal);
                    continue;
                }
                numeroDecimal = valor;
                break;

            }

            return numeroDecimal;
        }

        //Se ingresa texto que se desea que se ejecute en loop,
        //valor minimo y maximo de carácteresa validar.
        public static string Cadena(string texto, int? minimo, int? maximo, bool soloLetras)
        {
            string cadena;
            while (true)
            {
                Console.WriteLine("Ingrese " + texto);
                var ingreso = Console.ReadLine();
                if (!Validaciones.ValidarCadena(ingreso, minimo, maximo, soloLetras, out string errorCadena))
                {
                    Console.WriteLine(errorCadena);
                    continue;
                }
                cadena = ingreso;
                break;

            }

            return cadena;
        }

        //Se ingresa texto que se desea que se ejecute en loop, valor minimo y maximo a validar
        public static DateTime Fecha(string texto, DateTime? minimo, DateTime? maximo)
        {
            DateTime fecha;
            while (true)
            {
                Console.WriteLine("Ingrese " + texto);
                var ingreso = Console.ReadLine();
                if (!Validaciones.ValidarFecha(ingreso, minimo, maximo, out DateTime valor, out string errorFecha))
                {
                    Console.WriteLine(errorFecha);
                    continue;
                }
                fecha = valor;
                break;

            }

            return fecha;
        }

    }
}
