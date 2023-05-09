using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PintarPiso
{
    class CatalogoPinturas
    {

        static List<Pintura> listaPinturas = new List<Pintura>();

        //creamos get y set para poder usar la lista
        public static List<Pintura> ListaPinturas { get => listaPinturas; } //set => listaPinturas = value; }

        public static void Mostrar()   //<-- falta algo
        {
            Console.WriteLine("\n--------- PRESENTACION LISTA DE PINTURAS ----------\n");
            Console.WriteLine("\tid\tColor\tprecioM2");
            Console.WriteLine("\t--\t-----\t--------");

            //pinturas
            for(int i=0;i< listaPinturas.Count; i++)
            {
                Console.WriteLine("\t {0}\t{1} {2}", i, Util.CuadraTexto(listaPinturas[i].NombreColor,12), listaPinturas[i].PrecioM2);
            }

        }
    }
}
