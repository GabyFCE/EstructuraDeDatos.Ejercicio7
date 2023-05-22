using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ejercicio7
{
    internal static class ProductoArchivo
    {
        //Vamos a grabar archivos de texto con una notación llamada
        //JSON utilizando una herramienta llamada Newtonsoft.Json
        //se dice "yaison"
        //se escribe JSON

        //ejemplo. Una persona:
        /*
        {
             "Apellido": "Perez",
             "Nombre": "Juan",
             "Telefonos": [ 
                { 
                    "Tipo": "Casa",
                    "Numero": 1131798888
                },
                {
                    "Tipo": "Trabajo",
                    "Numero": 1131798887
                }
             ]
        }
        */


        //internamente, maneja una coleccion de personas.
        static List<ProductoEnt> productos;

        //Constructor estático:
        // - NO tiene modificador de acceso (public, private, etc.)
        // - NO puede tener parámetros.
        // - Se ejecuta UNA sola vez, justo antes del primer uso de
        //   una propiedad o método del módulo.
        static ProductoArchivo()
        {
            //si existe el archivo...
            if (File.Exists("productos.json"))
            {
                //lee TODO el contenido del archivo.
                string contenidoDelArchivo = File.ReadAllText("productos.json");

                //esta linea convierte el texto
                //de vuelta a objetos de tipo PersonaEnt;

                productos = JsonConvert.DeserializeObject<List<ProductoEnt>>(contenidoDelArchivo);
            }
            else
            {
                productos = new List<ProductoEnt>();
            }
        }

        //Estilo 1: este modulo devuelve una lista de todas las personas
        //y el resto del sistema trabaja con eso.
        public static List<ProductoEnt> ObtenerProducto()
        {
            return productos.ToList();
        }


        public static void AgregarProducto(ProductoEnt producto)
        {
            productos.Add(producto);
        }

        public static void AgregarListaProductos(List<ProductoEnt> productosNuevos)
        {
            productos.Concat(productosNuevos);
        }

        //Estilo 2: todas las consultas van a este modulo.
        //En este caso, hay que tener en cuenta que talvez
        //muchos modulos del sistema van a compartir el uso de éste.

        /*
        public static List<PersonaEnt> LasQueEmpiezanCon(char primeraLetra)
        {
            var resultado = new List<PersonaEnt>();
            foreach (var persona in todas)
            {
                if (persona.Apellido.StartsWith(primeraLetra))
                {
                    resultado.Add(persona);
                }
            }

            return resultado;
        }
        */
        /*
        public static List<PersonaEnt> MayoresA(int edad)
        {
            var resultado = new List<PersonaEnt>();
            foreach (var persona in todas)
            {
                if (persona.Edad > edad)
                {
                    resultado.Add(persona);
                }
            }
            return resultado;
        }
        

        public static void Borrar(string apellido)
        {
            foreach (var persona in todas)
            {
                if (persona.Apellido == apellido)
                {
                    todas.Remove(persona);
                    return;
                }
            }

            //hay un problema, porque no la encontré.
            //Tirar un error, para que se note.
            throw new ApplicationException($"La persona {apellido} no existe.");
        }

        public static void Borrar(PersonaEnt ent)
        {
            todas.Remove(ent);
        }
        */
        public static void Grabar()
        {
            var contenido = JsonConvert.SerializeObject(productos);
            File.WriteAllText("productos.json", contenido);
        }
    }
}
