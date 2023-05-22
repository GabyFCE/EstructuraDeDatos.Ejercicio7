using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ejercicio7
{
    internal class ProductoEnt
    {
        public string Codigo { get; set; }
        public string NombreCorto { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public List<ComponenteEnt> Componentes { get; set; }

        public bool ValidarProducto(out string error)
        {
            error = null;
            if (Codigo == null)
            {
                error = error + "Codigo vacio";
                return false;
            }
            if (NombreCorto == null)
            {
                error = error + "Nombre vacio";
                return false;
            }
            if (Descripcion == null)
            {
                error = error + "Descipción vacia";
                return false;
            }
            if (Precio == null)
            {
                error = error + "Precio vacio";
                return false;
            }
            if (Componentes.Count != Componentes.Distinct().Count())
            {
                error = error + "Lista con valores duplicados";
                return false;
            }
            if (Costo >= Precio)
            {
                error = error + "El costo es mayor igual al precio";
                return false;
            }
            return true;
        }

    }
}
