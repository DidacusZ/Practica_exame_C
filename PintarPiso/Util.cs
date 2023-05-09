using System;
using System.Collections.Generic;

namespace PintarPiso
{
	public class Util  
	{
        //----DEVUELVE LA OPCION SELECCIONADA
        public static int Menu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\t\t\tAlumno: Diego de la Prada");
                Console.WriteLine("\t\t\t╔══════════════════════════════╗");
                Console.WriteLine("\t\t\t║             MENU             ║");
                Console.WriteLine("\t\t\t╠══════════════════════════════╣");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║    1.- Lista de pinturas     ║");
                Console.WriteLine("\t\t\t║    2.- Presentar Precios     ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║    3.- Añadir Recinto        ║");
                Console.WriteLine("\t\t\t║    4.- Eliminar Recinto      ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║          0) Salir            ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t╚══════════════════════════════╝");
                Console.Write("\t\t\t¿Opción?");
                opcion = Console.ReadKey(false).KeyChar-'0';
            } while (opcion < 0 || opcion > 4);

            return opcion;
        }


        public static int CapturaEntero(string mensaje, int min, int max)
        {
            int valor = 0;
            bool esCorrecto = false;
            do
            {
                Console.Write("\n{0} ({1}..{2}): ", mensaje, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto || valor < min || valor > max)
                    Console.WriteLine(" ** Error ** Debe ser un entero de {0} a {1}  **", min, max);
            }
            while (!esCorrecto || valor < min || valor > max);

            return valor;
        }


        public static string CuadraTexto(string texto, int numCaracteres)
        {
            texto += "                                                                                                               ";
            texto = texto.Substring(0,numCaracteres);
            return texto;
        }


        public static void Posicion(string txt, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(txt);
        }


        public static bool PreguntaSiNo(string texto)
        {

            //bool correcto = false;
            //bool error = true;
            char letra;

            do
            {
                Console.Write("\n\n\t{0} [s/n]: ", texto);
                letra = Console.ReadKey().KeyChar;// capturamos una pulsacion

                if (letra == 's' || letra == 'S')
                    return true;


                if (letra == 'n' || letra == 'N')
                    return false;

                Console.Write("\n\n\t**Te has equivocado, porfavor introduce un valor correcto**");

            } while (true);

        }

    }
}
