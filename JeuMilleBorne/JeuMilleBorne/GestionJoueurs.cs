using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    public static class GestionJoueurs
    {
        public static Joueur Joueur1 = new Joueur();
        public static Joueur Joueur2 = new Joueur();
        private static Random alea = new Random();
        private static int tour;

        public static Random Alea { get => alea; set => alea = value; }
        public static int Tour { get => tour; set => tour = value; }

        public static int TourAlea()
        {
            return Alea.Next(0, 2);
        }
    }
}
