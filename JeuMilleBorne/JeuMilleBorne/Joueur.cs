using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    public class Joueur
    {
        #region Donnees
        private string pseudo;
        private int points;
        private int num_joueur;
        #endregion
        #region Accesseurs
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public int Points { get => points; set => points = value; }
        public int Num_joueur { get => num_joueur; set => num_joueur = value; }
        #endregion
        #region Constructeurs
        public Joueur() { }
        public Joueur(string pseudo, int points, int numerojoueur)
        {
            Pseudo = pseudo;
            Points = points;
            Num_joueur = numerojoueur;
        }
        #endregion
    }
}
