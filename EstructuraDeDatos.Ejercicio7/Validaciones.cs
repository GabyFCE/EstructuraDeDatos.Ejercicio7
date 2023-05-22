using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ejercicio7
{
    internal static class Validaciones
    {
        public static bool ValidarEnteroLargo(string ingreso, long? minimo, long? maximo, out long valor, out string error)
        {

            var valido = long.TryParse(ingreso, out valor);
            if (!valido)
            {

                error = "Ingrese un número entero válido.";
                return false;
            }

            //validar mínimo
            if (minimo.HasValue && valor < minimo.Value)
            {
                error = $"Ingrese un número mayor o igual a {minimo}.";
                return false;
            }

            //validar máximo
            if (maximo.HasValue && valor > maximo.Value)
            {
                error = $"Ingrese un número menor o igual a {maximo}.";
                return false;
            }

            //Otras validaciones... ???

            //si todo OK:
            error = null;
            return true;

        }
        public static bool ValidarEntero(string ingreso, int? minimo, int? maximo, out int valor, out string error)
        {

            var valido = int.TryParse(ingreso, out valor);
            if (!valido)
            {

                error = "Ingrese un número entero válido.";
                return false;
            }

            //validar mínimo
            if (minimo.HasValue && valor < minimo.Value)
            {
                error = $"Ingrese un número mayor o igual a {minimo}.";
                return false;
            }

            //validar máximo
            if (maximo.HasValue && valor > maximo.Value)
            {
                error = $"Ingrese un número menor o igual a {maximo}.";
                return false;
            }

            //Otras validaciones... ???

            //si todo OK:
            error = null;
            return true;

        }

        public static bool ValidarDecimal(string ingreso, decimal? minimo, decimal? maximo, out decimal valor, out string error)
        {

            var valido = decimal.TryParse(ingreso, out valor);
            if (!valido)
            {

                error = "Ingrese un número entero válido.";
                return false;
            }

            //validar mínimo
            if (minimo.HasValue && valor < minimo.Value)
            {
                error = $"Ingrese un número mayor o igual a {minimo}.";
                return false;
            }

            //validar máximo
            if (maximo.HasValue && valor > maximo.Value)
            {
                error = $"Ingrese un número menor o igual a {maximo}.";
                return false;
            }

            //Otras validaciones... ???

            //si todo OK:
            error = null;
            return true;

        }


        public static bool ValidarFecha(string ingreso, DateTime? min, DateTime? max, out DateTime valor, out string error)
        {
            var valido = DateTime.TryParse(ingreso, out valor);
            if (!valido)
            {

                error = "Ingrese una fecha válida.";
                return false;
            }

            if (min.HasValue && valor < min.Value)
            {
                error = $"Ingrese un fecha mayor o igual a {min}.";
                return false;
            }

            if (max.HasValue && valor > max.Value)
            {
                error = $"Ingrese una fecha menor o igual a {max}.";
                return false;
            }


            error = null;
            return true;
        }

        public static bool ValidarCadena(string ingreso, int? minCaracteres, int? maxCaracteres, bool soloLetras, out string mensajeError)
        {
            if (minCaracteres.HasValue && (ingreso == null || ingreso.Length < minCaracteres))
            {
                mensajeError = $"Debe ingresar al menos {minCaracteres} caracteres";
                return false;
            }

            if (maxCaracteres.HasValue && ingreso.Length > maxCaracteres)
            {
                mensajeError = $"Debe ser menor o igual a {maxCaracteres} caracteres";
                return false;
            }

            if (soloLetras)
            {
                foreach (char caracter in ingreso.ToLower())
                {
                    if ((caracter < 'a' || caracter > 'z') && caracter != ' ' && caracter != 'ñ')
                    {
                        mensajeError = "Utilice letras y espacio solamente.";
                        return false;
                    }
                }
            }

            //puedo agregar mas condiciones...
            mensajeError = null;
            return true;

        }
    }
}
