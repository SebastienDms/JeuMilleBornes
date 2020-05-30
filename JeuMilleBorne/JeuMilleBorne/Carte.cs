using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace JeuMilleBorne
{
    [Serializable]
    [XmlRoot()]
    class Carte
    {
        #region Donnees
        private string nom;
        private string type;
        private int valeur;
        private Image imageCarte;
        #endregion

        #region Accesseurs
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }

        public Image ImageCarte
        {
            get { return imageCarte; }
            set { imageCarte = value; }
        }
        #endregion

        #region Constructeur
        public Carte() { }
        public Carte(string nom, string type, Image imagecarte)
        {
            Nom = nom;
            Type = type;
            ImageCarte = imagecarte;
        }

        public Carte(string nom, string type, int val, Image imagecarte)
            :this(nom, type, imagecarte)
        {
            Valeur = val;
        }
        #endregion

        #region Enumerations
        public enum TypesCartes
        {
            Roule = 0,
            Stop = 1,
            Vitesse = 2,
            Attaque = 3,
            Defense = 4,
            Botte = 5
        }
        public string RetournerTexteTypesCartes(TypesCartes typecarte)
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
        public enum NomsCartes
        {
            Roule=0,
            Stop=1,
            VingtCinq=2,
            Cinquante=3,
            SeptanteCinq=4,
            Cent=5,
            DeuxCents=6,
            Lim=7,
            Panne=8,
            Creve=9,
            Accident=10,
            LimFin=11,
            Essence=12,
            Roue=13,
            Reparations=14,
            Prioritaire=15,
            Citerne=16,
            Increvable=17,
            AsVolant=18,
        }
        public string RetournerTexteNomsCartes(NomsCartes nomcarte)
        {
            switch (nomcarte)
            {
                case NomsCartes.Roule: return "Feux vert";
                case NomsCartes.Stop: return "Feux rouge";
                case NomsCartes.VingtCinq: return "Vitesse 25";
                case NomsCartes.Cinquante: return "Vitesse 50";
                case NomsCartes.SeptanteCinq: return "Vitesse 75";
                case NomsCartes.Cent: return "Vitesse 100";
                case NomsCartes.DeuxCents: return "Vitesse 200";
                case NomsCartes.Lim: return "Limite de vitesse à 50";
                case NomsCartes.Panne: return "Panne d'essence";
                case NomsCartes.Creve: return "Crevé !";
                case NomsCartes.Accident: return "Accident...";
                case NomsCartes.LimFin: return "Fin de Limite de vitesse";
                case NomsCartes.Essence: return "Essence";
                case NomsCartes.Roue: return "Roue de secours";
                case NomsCartes.Reparations: return "Réparations";
                case NomsCartes.Prioritaire: return "Véhicule prioritaire (contre feux rouge et limite de vitesse)";
                case NomsCartes.Citerne: return "Citerne d'essence";
                case NomsCartes.Increvable: return "Increvable !";
                case NomsCartes.AsVolant: return "As du volant";
                default: return null;
            }
        }
        public enum ValeursCartes
        {
            VingtCinq = 0,
            Cinquante = 1,
            SeptanteCinq = 2,
            Cent = 3,
            DeuxCents = 4,
        }
        public int RetournerValeurCartes(ValeursCartes valeurcarte)
        {
            switch (valeurcarte)
            {
                case ValeursCartes.VingtCinq: return 25;
                case ValeursCartes.Cinquante: return 50;
                case ValeursCartes.SeptanteCinq: return 75;
                case ValeursCartes.Cent: return 100;
                case ValeursCartes.DeuxCents: return 200;
                default: return 0;
            }
        }
        #endregion
    }
}
