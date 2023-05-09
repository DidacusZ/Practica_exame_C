using System;
using System.Collections.Generic;

namespace PintarPiso
{
	class Piso
	{
        string direccion;

        static List<Habitacion> listaRecintos = new List<Habitacion>();

        public Piso(string direccion)
        {
            this.direccion = direccion;
        }

        public static List<Habitacion> ListaRecintos { get => listaRecintos; set => listaRecintos = value; }

        public static void MostrarRecintos()
        {
            double suma = 0;
            // cabecera
            Console.WriteLine("\n   -- Precio de pintura del piso: {0} --\n", "direccion");
            Console.WriteLine("   Recinto    ------ PARED -------      -- PINTURA --   PRETIL    TOTAL");
            Console.WriteLine("   Nombre     metros   nºP     nºV      Color  Precio   metros    Precio");
            Console.WriteLine("   -------    ------   ---     ---      -----  ------   ------    ------");
            //...

            foreach (Habitacion habitacion in listaRecintos)
            {
                suma += habitacion.MostrarPrecioPintura();
            }


            // Pie
            Console.WriteLine("                                                                  ------");
            Console.WriteLine("                                             TOTAL Euros Pintura: {0}", suma);
        }

        public static double PrecioPintura(double SuperficiePintar, double precioM2)
        {
            return SuperficiePintar * precioM2;
        }

        public void NuevoRecinto(Habitacion recinto)
        {
            listaRecintos.Add(recinto);
        }

        public void AñadirRecinto()
        {
            bool v = true;
            string nombre="";

            do
            {
                Console.Write("\nIntroduce el nombre del recinto: ");
                nombre = Console.ReadLine();
                foreach (Habitacion habitacion in listaRecintos)
                {
                    if (habitacion.Nombre == nombre)
                    {
                        Console.WriteLine("\nEl nombre " + nombre + " ya existe");
                        v = false;
                    }

                }
            } while (!v);

            double mParedes = Util.CapturaEntero("Introduce los metros de pared a pintar",1,999);

            int nPuertas = Util.CapturaEntero("Introduce el numero de puertas", 1, 99);

            int nVentanas = Util.CapturaEntero("Introduce el numero de ventanas", 1, 99);

            int tPintura = Util.CapturaEntero("Introduce el tipo de pintura", 0, CatalogoPinturas.ListaPinturas.Count);


            if(Util.PreguntaSiNo("Quieres añadir metros de petril? (SOLO EN TERRAZAS)"))
            {
                double mPretil = Util.CapturaEntero("Introduce los metros de petril", 1, 999);
                NuevoRecinto(new Terraza(nombre, mParedes, nPuertas, nVentanas, tPintura, mPretil));
            }

            NuevoRecinto(new Habitacion(nombre, mParedes, nPuertas, nVentanas, tPintura));
  
        }

        public void EliminarRecinto()
        {
            Console.WriteLine("\n\tId     nombre");
            Console.WriteLine("\t---     ---------");
            for (int i=0;i< listaRecintos.Count; i++)
            {
                
                Console.WriteLine("\t{0}     {1}", i, listaRecintos[i].Nombre);

            }

            int n = Util.CapturaEntero("Que recinto quieres eliminar",0, listaRecintos.Count-1);

            listaRecintos.RemoveAt(n);

            Console.WriteLine("\n\nRecinto eliminado con exito");

        }
    }
}
