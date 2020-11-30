using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    [Serializable]
    public class DataNetwork
    {
        #region sPaquets de carte
        //public List<Carte> PaquetJeu { get; set; }
        //public List<Carte> PaquetMelange { get; set; }
        //public List<Carte> Defausse { get; set; }
        //public Carte Carte_piochee { get; set; }
        //public Carte Ctmp { get; set; }
        //public List<Carte> MainJoueur1 { get; set; }
        //public List<Carte> J1Bottes { get; set; }
        //public List<Carte> J1Vitesse { get; set; }
        //public List<Carte> J1Bataille { get; set; }
        //public List<Carte> J1Bornes25 { get; set; }
        //public List<Carte> J1Bornes50 { get; set; }
        //public List<Carte> J1Bornes75 { get; set; }
        //public List<Carte> J1Bornes100 { get; set; }
        //public List<Carte> J1Bornes200 { get; set; }
        //public List<Carte> MainJoueur2 { get; set; }
        //public List<Carte> J2Bottes { get; set; }
        //public List<Carte> J2Vitesse { get; set; }
        //public List<Carte> J2Bataille { get; set; }
        //public List<Carte> J2Bornes25 { get; set; }
        //public List<Carte> J2Bornes50 { get; set; }
        //public List<Carte> J2Bornes75 { get; set; }
        //public List<Carte> J2Bornes100 { get; set; }
        //public List<Carte> J2Bornes200 { get; set; }
        public PaquetsDeCartes PaquetsDeCartes { get; set; }
        #endregion
        #region Joueurs
        //public Joueur Joueur1 { get; set; }
        //public Joueur Joueur2 { get; set; }
        public GestionJoueurs DataJoueurs { get; set; }
        #endregion

    }
}
