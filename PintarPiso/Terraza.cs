
using System;

namespace PintarPiso
{
    class Terraza : Habitacion
    {

        double mPretil;   // metros lineales de pretil

        public Terraza(string nombre, double mPared, int numPuertas, int numVentanas, int tipoPintura, double mPretil) 
            : base(nombre, mPared, numPuertas, numVentanas, tipoPintura)
        {
            this.mPretil = mPretil;
        }

        public Terraza(string nombre, double mPared, int numPuertas, int numVentanas, double mPretil)
         : base(nombre, mPared, numPuertas, numVentanas)
        {
            this.mPretil = mPretil;
        }

        public Terraza()
            : base()
        {
            
        }

        public override double SuperficiePintar
        {
            get => MPared * 2.5 - NumPuertas * 1.6 - NumVentanas + mPretil * 1.5;
            //get => base.SuperficiePintar + mPretil * 1.5;
        }

        public override double MostrarPrecioPintura()
        {
            //pintura de la habitacion del catalogo
            Pintura p = CatalogoPinturas.ListaPinturas[TipoPintura];

            double precioPintura = SuperficiePintar * p.PrecioM2;
            precioPintura = Math.Round(precioPintura, 2);


            //Console.WriteLine("   {0}{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t  {7}", Util.CuadraTexto(Nombre, 13), MPared, NumPuertas, NumVentanas, p.NombreColor, p.PrecioM2,mPretil, precioPintura);

            //alineado
            Console.Write("   {0}", Util.CuadraTexto(Nombre, 13));
            if (MPared < 10)
                Console.Write(" ");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t  {6}", MPared, NumPuertas, NumVentanas, p.NombreColor, p.PrecioM2, mPretil, precioPintura);

            return precioPintura;
        }


    }
}
