using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ejercicio7
{
    internal static class ModuloRemitos
    {
        internal static void Alta()
        {

            List<RemitoEnt> remitos = new List<RemitoEnt>();

            while (true)
            {

                RemitoEnt remitoNuevo = IngresarRemito();
                remitos.Add(remitoNuevo);
                Console.WriteLine("Se ha agregado un nuevo remito");
                Console.WriteLine($"Cantidad: {remitos.Count}");

                Console.WriteLine("¿Desea continuar agregando remitos? [S/N]");
                string continuar = null;
                while (continuar != "S" && continuar != "N")
                {
                    continuar = Console.ReadLine();
                }

                if (continuar == "N")
                {
                    foreach (RemitoEnt r in remitos)
                    {
                        RemitoArchivo.AgregarRemito(r);
                    }
                    break;
                }

            }




            RemitoEnt IngresarRemito()
            {
                RemitoEnt remito = new RemitoEnt();

                while (true)
                {

                    ClienteEnt cliente = new ClienteEnt();
                    List<LineaEnt> lineas = new List<LineaEnt>();

                    //Razon social
                    cliente.RazonSocial = Ingreso.Cadena("la razon social", 1, 30, soloLetras:false);

                    //Direccion
                    cliente.Direccion= Ingreso.Cadena("la dirección", 1, 120, soloLetras:false);

                    //Detalle
                    while (true)
                    {
                        LineaEnt linea = new LineaEnt();
                        linea.Cantidad = Ingreso.Entero("la cantidad", 1, 100);
                        while (true)
                        {
                            string productoBuscado = Ingreso.Cadena("el producto", 1, 30, soloLetras: true);
                            List<ProductoEnt> productos = ProductoArchivo.ObtenerProducto();
                            if (productos.Exists(x=> x.Codigo == productoBuscado))
                            {
                                linea.Producto = productoBuscado;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No se encontró el producto, deberá volver a probar");
                            }

                        }
                        linea.Peso = Ingreso.Decimal("el peso", 1, 1000);
                        lineas.Add(linea);
                        Console.WriteLine("Se ha agregado una linea");
                        Console.WriteLine($"Cantidad: {lineas.Count}");
                        Console.WriteLine("¿Desea continuar agregando lineas? [S/N]");
                        string continuar = null;
                        while (continuar != "S" && continuar != "N")
                        {
                            continuar = Console.ReadLine();
                        }

                        if (continuar == "N")
                        {
                            break;
                        }
                    }

                    //Cliente
                    remito.Cliente = cliente;

                    //Detalle
                    remito.Detalle = lineas;


                    if (!remito.ValidaRemito(out string error))
                    {
                        Console.WriteLine(error);
                    }

                    break;
                }

                return remito;
            }



        }

        internal static void Baja()
        {
            throw new NotImplementedException();
        }

        internal static void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
