using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    [Serializable]
    public class GestionDonneesJeux
    {
        #region Paquets
        public static List<Carte> PaquetJeu = new List<Carte>();
        public static List<Carte> PaquetMelange = new List<Carte>();
        public static List<Carte> Defausse = new List<Carte>();
        public static Carte Carte_piochee = new Carte();
        public static Carte Ctmp = new Carte();
        public static List<Carte> MainJoueur1 = new List<Carte>();
        public static List<Carte> J1Bottes = new List<Carte>();
        public static List<Carte> J1Vitesse = new List<Carte>();
        public static List<Carte> J1Bataille = new List<Carte>();
        public static List<Carte> J1Bornes25 = new List<Carte>();
        public static List<Carte> J1Bornes50 = new List<Carte>();
        public static List<Carte> J1Bornes75 = new List<Carte>();
        public static List<Carte> J1Bornes100 = new List<Carte>();
        public static List<Carte> J1Bornes200 = new List<Carte>();
        public static List<Carte> MainJoueur2 = new List<Carte>();
        public static List<Carte> J2Bottes = new List<Carte>();
        public static List<Carte> J2Vitesse = new List<Carte>();
        public static List<Carte> J2Bataille = new List<Carte>();
        public static List<Carte> J2Bornes25 = new List<Carte>();
        public static List<Carte> J2Bornes50 = new List<Carte>();
        public static List<Carte> J2Bornes75 = new List<Carte>();
        public static List<Carte> J2Bornes100 = new List<Carte>();
        public static List<Carte> J2Bornes200 = new List<Carte>();
        #endregion
        #region Joueurs
        public static Joueur Joueur1 = new Joueur();
        public static Joueur Joueur2 = new Joueur();
        private static Random alea = new Random();
        private static int tour;
        #endregion
        public static bool ReceptionDuReseau(MemoryStream MSReceive)
        {
            //var streamDatas = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();

            MSReceive.Write(MSReceive.ToArray(), 0, MSReceive.ToArray().Length);
            MSReceive.Seek(0, SeekOrigin.Begin);

            PaquetJeu = (List<Carte>)formatter.Deserialize(MSReceive);
            PaquetMelange = (List<Carte>)formatter.Deserialize(MSReceive);
            Defausse = (List<Carte>)formatter.Deserialize(MSReceive);
            Carte_piochee = (Carte)formatter.Deserialize(MSReceive);
            Ctmp = (Carte)formatter.Deserialize(MSReceive);
            MainJoueur1 = (List<Carte>)formatter.Deserialize(MSReceive);
            J1Bottes = (List<Carte>)formatter.Deserialize(MSReceive);
            J1Vitesse = (List<Carte>)formatter.Deserialize(MSReceive);
            J1Bataille = (List<Carte>)formatter.Deserialize(MSReceive);
            J1Bornes25 = (List<Carte>)formatter.Deserialize(MSReceive);
            J1Bornes50 = (List<Carte>)formatter.Deserialize(MSReceive);
            J1Bornes75 = (List<Carte>)formatter.Deserialize(MSReceive);
            J1Bornes100 = (List<Carte>)formatter.Deserialize(MSReceive);
            J1Bornes200 = (List<Carte>)formatter.Deserialize(MSReceive);
            MainJoueur2 = (List<Carte>)formatter.Deserialize(MSReceive);
            J2Bottes = (List<Carte>)formatter.Deserialize(MSReceive);
            J2Vitesse = (List<Carte>)formatter.Deserialize(MSReceive);
            J2Bataille = (List<Carte>)formatter.Deserialize(MSReceive);
            J2Bornes25 = (List<Carte>)formatter.Deserialize(MSReceive);
            J2Bornes50 = (List<Carte>)formatter.Deserialize(MSReceive);
            J2Bornes75 = (List<Carte>)formatter.Deserialize(MSReceive);
            J2Bornes100 = (List<Carte>)formatter.Deserialize(MSReceive);
            J2Bornes200 = (List<Carte>)formatter.Deserialize(MSReceive);
            /********************************/
            Joueur1 = (Joueur)formatter.Deserialize(MSReceive);
            Joueur2 = (Joueur)formatter.Deserialize(MSReceive);
            tour = (int)formatter.Deserialize(MSReceive);
            
            
            
            return true;
        }

    }
}
