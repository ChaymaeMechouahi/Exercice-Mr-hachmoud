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
        public void ajouter(int[] tab,int nbr_ajout)//ajouter un nombre à un tableau déjà trié les paramètres sont notre tableeau + la valeur qui va etre ajoutée
        {
            int i = 0;//index 
            if ((tab[i] <= tab[i+1])&&(tab[i+1] <= tab[i+2]))//afin de savoir l'ordre de triement 
            {
                while (i<tab.length())//puisque l'ordre est croissant donc il faut que l'index soit inférieure à la longueur
                {
                    if (nbr_ajout <= tab[i])//check if nbre à ajouter est plus petit ou egal à la valeur sockée dans le tableau si oui:
                    {
                        for(int j = tab.length(),j >= i ;j--)//un autre index qui va nous permettre à réserver une case pour le nouveau nombre donc it's important to move the other cases     
                        {
                             tab[j+1] = tab[j];//moving
                        }
                        tab[i] = nbr_ajout;//affecter le nombre à son emplacement   
                        exit;//en cas d'ajout avec succées pas besoin de continuer dans le parcours du tableau  
                    }
                    i++;//incrémentation jusqu'il rentre dans la condition if 
                }
            }
            else //si le tableau est trié décroissant meme chose on va faire justement la condition d'if va etre changé 
            {
                while (i<tab.length())
                {
                    if (nbr_ajout >= tab[i])//cette fois le nbre ajouté doit etre > que notre case 
                    {
                        for(int j = tab.length(),j >= i ;j--)
                        {
                             tab[j+1] = tab[j];
                        }
                        tab[i] = nbr_ajout;
                        exit;
                    }
                    i++;
                }
            }
        }

    }
}
