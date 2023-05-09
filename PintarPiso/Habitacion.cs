using System;

namespace PintarPiso
{
	public class Habitacion
	{

        string nombre;  // Nombre de la habitación
        double mPared;  // metros de pared de la habitación
        int numPuertas; // Número de puertas de 2 x 0.80 m2
        int numVentanas;// Número de ventanas de 1x1 m2
        int tipoPintura;// id del tipo de pintura en el catálogo [0..4]

        public Habitacion(string nombre, double mPared, int numPuertas, int numVentanas, int tipoPintura)
        {
            this.nombre = nombre;
            this.mPared = mPared;
            this.numPuertas = numPuertas;
            this.numVentanas = numVentanas;
            this.tipoPintura = tipoPintura;
        }

        public Habitacion(string nombre, double mPared, int numPuertas, int numVentanas)
        {
            this.nombre = nombre;
            this.mPared = mPared;
            this.numPuertas = numPuertas;
            this.numVentanas = numVentanas;
            this.tipoPintura = 0;
        }

        public Habitacion()
        {
            
        }

        public string Nombre { get => nombre; } // set => nombre = value; }
        public double MPared { get => mPared; } //set => mPared = value; }
        public int NumPuertas { get => numPuertas; } //set => numPuertas = value; }
        public int NumVentanas { get => numVentanas; } //set => numVentanas = value; }
        public int TipoPintura { get => tipoPintura; } //set => tipoPintura = value; }


        public virtual double SuperficiePintar
        {
            get => mPared * 2.5 - numPuertas * 1.6 - numVentanas;
        }

        public virtual void Mostrar()
        {
            //pinturas
            for (int i = 0; i < Piso.ListaRecintos.Count; i++)
            {
                //recinto
                Util.Posicion(nombre,10,i);
                Util.Posicion(Convert.ToString(mPared), 10,i);
                Util.Posicion(Convert.ToString(numPuertas), 10,i);
                Util.Posicion(Convert.ToString(numVentanas), 10,i);


                //pintura
                Console.Write("");

                //metros
                Console.Write("");

                //total
                Console.WriteLine("");

            }
        }

        public virtual double MostrarPrecioPintura()
        {
            //pintura de la habitacion del catalogo
            Pintura p = CatalogoPinturas.ListaPinturas[tipoPintura];

            double precioPintura = SuperficiePintar * p.PrecioM2;
            precioPintura = Math.Round(precioPintura, 2);

            //se muestra alineado
            Console.Write("   {0}",Util.CuadraTexto(nombre,13));
            if(mPared<10)
                Console.Write(" ");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t  {5}", mPared, numPuertas, numVentanas,p.NombreColor,p.PrecioM2,precioPintura);

            return precioPintura;
        }
    }

}
