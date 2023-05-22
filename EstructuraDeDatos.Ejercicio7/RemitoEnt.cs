using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ejercicio7
{
    internal class RemitoEnt
    {
        public ClienteEnt Cliente { get; set; }
        public List<LineaEnt> Detalle { get; set; }

        public decimal PesoTotal 
        { get
            {
                decimal sumaPesos = 0;
                foreach(LineaEnt linea in Detalle)
                {
                    sumaPesos = sumaPesos + (linea.Peso * linea.Cantidad);
                }
                return sumaPesos;
            } 
        }

        public bool ValidaRemito(out string error)
        {
            error = null;
            bool flag = true;
            if (Detalle.Count == 0)
            {
                error = "Remito sin detalle";
                flag = false;
            }
            if (Cliente == null)
            {
                error = error + "\n" + "Falta el cliente";
                flag = false;
            }

            return flag;
        }
    }
}
