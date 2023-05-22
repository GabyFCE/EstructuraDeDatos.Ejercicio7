using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ejercicio7
{
    internal class ComponenteEnt
    {
        public string Codigo { get; set; }

        public bool ValidarComponente(out string error)
        {
            if (Codigo == null)
            {
                error = "Código vacio";
                return false;
            }
            if (Codigo.Length != 6)
            {
                error = "El código debe tener 6 carácteres";
                return false;
            }


            error = null;
            return true;
        }
    }
}
