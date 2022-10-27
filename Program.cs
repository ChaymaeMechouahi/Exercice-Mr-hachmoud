using System;

namespace Exercice1_2
{
    class ProgramPrincipale
    {
        static void Main(string[] args)
        {
            NbrePr nomb1 = new NbrePr();
            if(nomb1.Isprime())
            Console.WriteLine("Ce nombre est premier");
           else
                Console.WriteLine("Ce nombre n'est pas premier");

        }
    }
    public class NbrePr
    {
        private int nwbre;
        public NbrePr()
        {
            string nbre;
            do
            {
                Console.WriteLine(" Nombre à ");
                nbre = Console.ReadLine();
                int.TryParse(nbre, out nwbre);  /*Permet de convertir du type String en int */
            } while (nwbre <= 1);/*Afin de s'assurer que le nombre entré est une nombre en premier lieu et afin de s'assurer aussi que ce nombre là n'est pas négatif ou null*/
        }
        public bool Isprime()
        {
            int d;
            bool pr = true;
            for (d = 2; d * d <= nwbre && pr; d++)
            {
                if (nwbre % d == 0) pr = false;
            }
            return pr;
        }
    }
    public class Tri
    {
        private int[] array;
        private int dim;
        public Tri( int dimension)
        {
            dim = dimension;
            String a;
            for (int i = 0; i < dim; i++)
            {
                Console.WriteLine("case number " + i++);
                 a = Console.ReadLine();
                int.TryParse(a, out array[i]);
            }
        }
        public void ajouter(int[] tab, int dimension,int nbr_ajout)
        {
            int i = 0;
            if ((tab[i] < tab[i+1])&&(tab[i+1] < tab[i+2]))
            {
                while ((i<dimension)&&(dimension>tab.Length))
                {

                }
            }
        }

    }
}
