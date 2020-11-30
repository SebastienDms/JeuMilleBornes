using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace JeuMilleBorne
{
    [Serializable]
    class PaquetsDeCartes
    {
        private static byte[] DataBytes = new byte[1024];
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
        /** Serialize les données afin de les envoyées sur le réseau **/
        public static byte[] EnvoiePourReseau()
        {
            var streamDatas = new MemoryStream();

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(streamDatas, PaquetJeu);
            formatter.Serialize(streamDatas, PaquetMelange);
            formatter.Serialize(streamDatas, Defausse);
            formatter.Serialize(streamDatas, Carte_piochee);
            formatter.Serialize(streamDatas, Ctmp);
            formatter.Serialize(streamDatas, MainJoueur1);
            formatter.Serialize(streamDatas, J1Bottes);
            formatter.Serialize(streamDatas, J1Vitesse);
            formatter.Serialize(streamDatas, J1Bataille);
            formatter.Serialize(streamDatas, J1Bornes25);
            formatter.Serialize(streamDatas, J1Bornes50);
            formatter.Serialize(streamDatas, J1Bornes75);
            formatter.Serialize(streamDatas, J1Bornes100);
            formatter.Serialize(streamDatas, J1Bornes200);
            formatter.Serialize(streamDatas, MainJoueur2);
            formatter.Serialize(streamDatas, J2Bottes);
            formatter.Serialize(streamDatas, J2Vitesse);
            formatter.Serialize(streamDatas, J2Bataille);
            formatter.Serialize(streamDatas, J2Bornes25);
            formatter.Serialize(streamDatas, J2Bornes50);
            formatter.Serialize(streamDatas, J2Bornes75);
            formatter.Serialize(streamDatas, J2Bornes100);
            formatter.Serialize(streamDatas, J2Bornes200);

            DataBytes = streamDatas.ToArray();

            //GestionConnexion._Client.Send(DataBytes);
            return DataBytes;
        }

        public static void ReceptionDuReseau()
        {
            var streamDatas = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();

            streamDatas.Write(DataBytes, 0, DataBytes.Length);
            streamDatas.Seek(0, SeekOrigin.Begin);

            PaquetJeu = (List<Carte>)formatter.Deserialize(streamDatas);
            PaquetMelange = (List<Carte>)formatter.Deserialize(streamDatas);
            Defausse = (List<Carte>)formatter.Deserialize(streamDatas);
            Carte_piochee = (Carte)formatter.Deserialize(streamDatas);
            Ctmp = (Carte)formatter.Deserialize(streamDatas);
            MainJoueur1 = (List<Carte>)formatter.Deserialize(streamDatas);
            J1Bottes = (List<Carte>)formatter.Deserialize(streamDatas);
            J1Vitesse = (List<Carte>)formatter.Deserialize(streamDatas);
            J1Bataille = (List<Carte>)formatter.Deserialize(streamDatas);
            J1Bornes25 = (List<Carte>)formatter.Deserialize(streamDatas);
            J1Bornes50 = (List<Carte>)formatter.Deserialize(streamDatas);
            J1Bornes75 = (List<Carte>)formatter.Deserialize(streamDatas);
            J1Bornes100 = (List<Carte>)formatter.Deserialize(streamDatas);
            J1Bornes200 = (List<Carte>)formatter.Deserialize(streamDatas);
            MainJoueur2 = (List<Carte>)formatter.Deserialize(streamDatas);
            J2Bottes = (List<Carte>)formatter.Deserialize(streamDatas);
            J2Vitesse = (List<Carte>)formatter.Deserialize(streamDatas);
            J2Bataille = (List<Carte>)formatter.Deserialize(streamDatas);
            J2Bornes25 = (List<Carte>)formatter.Deserialize(streamDatas);
            J2Bornes50 = (List<Carte>)formatter.Deserialize(streamDatas);
            J2Bornes75 = (List<Carte>)formatter.Deserialize(streamDatas);
            J2Bornes100 = (List<Carte>)formatter.Deserialize(streamDatas);
            J2Bornes200 = (List<Carte>)formatter.Deserialize(streamDatas);
        }
        /*****************************************************************/
    }
}
