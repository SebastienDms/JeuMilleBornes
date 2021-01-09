using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace JeuMilleBorne
{
    [Serializable]
    public class PaquetsDeCartes
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

        #region Sauvegarde locale

        public static void SauverPaquets()
        {
            FileStream FicSauvegarde;
            string nomFic = "savepaquets.txt";
            IFormatter formatter = new BinaryFormatter();
            FicSauvegarde = new FileStream(nomFic, FileMode.Create);

            formatter.Serialize(FicSauvegarde, PaquetJeu);
            formatter.Serialize(FicSauvegarde, PaquetMelange);
            formatter.Serialize(FicSauvegarde, Defausse);
            formatter.Serialize(FicSauvegarde, Carte_piochee);
            formatter.Serialize(FicSauvegarde, Ctmp);
            formatter.Serialize(FicSauvegarde, MainJoueur1);
            formatter.Serialize(FicSauvegarde, J1Bottes);
            formatter.Serialize(FicSauvegarde, J1Vitesse);
            formatter.Serialize(FicSauvegarde, J1Bataille);
            formatter.Serialize(FicSauvegarde, J1Bornes25);
            formatter.Serialize(FicSauvegarde, J1Bornes50);
            formatter.Serialize(FicSauvegarde, J1Bornes75);
            formatter.Serialize(FicSauvegarde, J1Bornes100);
            formatter.Serialize(FicSauvegarde, J1Bornes200);
            formatter.Serialize(FicSauvegarde, MainJoueur2);
            formatter.Serialize(FicSauvegarde, J2Bottes);
            formatter.Serialize(FicSauvegarde, J2Vitesse);
            formatter.Serialize(FicSauvegarde, J2Bataille);
            formatter.Serialize(FicSauvegarde, J2Bornes25);
            formatter.Serialize(FicSauvegarde, J2Bornes50);
            formatter.Serialize(FicSauvegarde, J2Bornes75);
            formatter.Serialize(FicSauvegarde, J2Bornes100);
            formatter.Serialize(FicSauvegarde, J2Bornes200);
        }
        public static void ChargerPaquets()
        {
            FileStream FicSauvegarde;
            string nomFic = "savepaquets.txt";
            IFormatter formatter = new BinaryFormatter();
            FicSauvegarde = new FileStream(nomFic, FileMode.Open);

            PaquetJeu = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            PaquetMelange = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            Defausse = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            Carte_piochee = (Carte)formatter.Deserialize(FicSauvegarde);
            Ctmp = (Carte)formatter.Deserialize(FicSauvegarde);
            MainJoueur1 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J1Bottes = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J1Vitesse = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J1Bataille = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J1Bornes25 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J1Bornes50 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J1Bornes75 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J1Bornes100 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J1Bornes200 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            MainJoueur2 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J2Bottes = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J2Vitesse = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J2Bataille = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J2Bornes25 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J2Bornes50 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J2Bornes75 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J2Bornes100 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
            J2Bornes200 = (List<Carte>)formatter.Deserialize(FicSauvegarde);
        }
        #endregion

        #region Gestion réseau

        public static long ReceptionDuReseau(MemoryStream MSReceive)
        {
            IFormatter formatter = new BinaryFormatter();

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
            return MSReceive.Position;
        }

        #endregion
    }
}
