using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    class Carte
    {
        private string nom;
        private string type;
        private int valeur;

        public enum TypesCartes
        {
            Roule = 0,
            Stop = 1,
            Vitesse = 2,
            Attaque = 3,
            Defense = 4,
            Botte = 5
        }

        public string RetournerTexteTypesCarte(TypesCartes typecarte)
        {
            switch ((typecarte))
            {
                case TypesCartes.Roule: return "Roule";
                case TypesCartes.Stop: return "Stop";
                case TypesCartes.Vitesse: return "Vitesse";
                case TypesCartes.Attaque: return "Attaque";
                case TypesCartes.Defense: return "Défense";
                case TypesCartes.Botte: return "Botte";
                default: return null;
            }
        }
    }
}
