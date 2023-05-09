// Alumno:

using System;
using System.Collections.Generic;

namespace PintarPiso
{
	public class PintarPisoApp
	{
		static void Main(string[] args)
		{

            //como el la lista es estatica, no se construlle objeto catalogo
            // se accede directamente a ls lista

            //accedemos gracias al get
            CatalogoPinturas.ListaPinturas.Add(new Pintura("Blanco", 4.5));
            CatalogoPinturas.ListaPinturas.Add(new Pintura("Verde", 3.8));
            CatalogoPinturas.ListaPinturas.Add(new Pintura("Salmón", 8.5));
            CatalogoPinturas.ListaPinturas.Add(new Pintura("Beige", 7.2));
            CatalogoPinturas.ListaPinturas.Add(new Pintura("Amarillo", 6.2));
            //tambien se puede hacer con un metodo en el catalogo que las añada, asi no hace falta el get


            Piso piso1 = new Piso("Bellavista, 9 9ºB");

            piso1.NuevoRecinto(new Habitacion("Salón", 20.5, 2, 3));
            piso1.NuevoRecinto(new Habitacion("Dormi1", 15, 1, 1, 2));
            piso1.NuevoRecinto(new Terraza("Terraza1", 4.0, 1, 1, 3, 10));

            int opcion;

            do
            {
                opcion = Util.Menu();
                Console.Clear();
                switch (opcion)
                {
                    case 1: // Mostrar las pinturas
                        CatalogoPinturas.Mostrar();
                        break;
                    case 2: // Mostrar los recintos y sus precios
                        Piso.MostrarRecintos();
                        break;
                    case 3: // Añadir Recinto
                        piso1.AñadirRecinto();
                        break;
                    case 4: // Eliminar Recinto
                        piso1.EliminarRecinto();
                        break;
                }

                
                if(opcion != 0)
                {
                    Console.WriteLine("\n\n\nPulsa una tecla para volver al Menú");
                    Console.ReadKey();  
                }
               

            } while (opcion!=0);
		}
	}
}
