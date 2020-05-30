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

        public static int PointsJ1()
        {
            Joueur1.Points = PaquetsDeCartes.J1Bornes25.Count * 25 + PaquetsDeCartes.J1Bornes50.Count * 50 + PaquetsDeCartes.J1Bornes75.Count * 75 +
                             PaquetsDeCartes.J1Bornes100.Count * 100 + PaquetsDeCartes.J1Bornes200.Count * 200;
            return Joueur1.Points;
        }
        public static int PointsJ2()
        {
            Joueur2.Points = PaquetsDeCartes.J2Bornes25.Count * 25 + PaquetsDeCartes.J2Bornes50.Count * 50 + PaquetsDeCartes.J2Bornes75.Count * 75 +
                             PaquetsDeCartes.J2Bornes100.Count * 100 + PaquetsDeCartes.J2Bornes200.Count * 200;
            return Joueur2.Points;
        }
    }
}
