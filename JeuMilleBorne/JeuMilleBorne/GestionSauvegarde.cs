using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace JeuMilleBorne
{
    static class GestionSauvegarde
    {
        public static void Sauver()
        {
            //try
            //{
                //List<Carte> lstCartes = new List<Carte>();
                //lstCartes.Add(PaquetsDeCartes.Carte_piochee);
                //lstCartes.Add(PaquetsDeCartes.Ctmp);
                //List<List<Carte>> lstPaquets = new List<List<Carte>>();
                //lstPaquets.Add(PaquetsDeCartes.PaquetJeu);
                //lstPaquets.Add(PaquetsDeCartes.PaquetMelange);
                //lstPaquets.Add(PaquetsDeCartes.Defausse);
                //lstPaquets.Add(PaquetsDeCartes.MainJoueur1);
                //lstPaquets.Add(PaquetsDeCartes.J1Bottes);
                //lstPaquets.Add(PaquetsDeCartes.J1Vitesse);
                //lstPaquets.Add(PaquetsDeCartes.J1Bataille);
                //lstPaquets.Add(PaquetsDeCartes.J1Bornes25);
                //lstPaquets.Add(PaquetsDeCartes.J1Bornes50);
                //lstPaquets.Add(PaquetsDeCartes.J1Bornes75);
                //lstPaquets.Add(PaquetsDeCartes.J1Bornes100);
                //lstPaquets.Add(PaquetsDeCartes.J1Bornes200);
                //lstPaquets.Add(PaquetsDeCartes.MainJoueur2);
                //lstPaquets.Add(PaquetsDeCartes.J2Bottes);
                //lstPaquets.Add(PaquetsDeCartes.J2Vitesse);
                //lstPaquets.Add(PaquetsDeCartes.J2Bataille);
                //lstPaquets.Add(PaquetsDeCartes.J2Bornes25);
                //lstPaquets.Add(PaquetsDeCartes.J2Bornes50);
                //lstPaquets.Add(PaquetsDeCartes.J2Bornes75);
                //lstPaquets.Add(PaquetsDeCartes.J2Bornes100);
                //lstPaquets.Add(PaquetsDeCartes.J2Bornes200);
                //List<Joueur> lstJoueurs = new List<Joueur>();
                //lstJoueurs.Add(GestionJoueurs.Joueur1);
                //lstJoueurs.Add(GestionJoueurs.Joueur2);
                //Serialiser("PaquetsData.xml", lstPaquets);
                //Serialiser("CatesData.xml", lstCartes);
                //Serialiser("JoueursData.xml", lstJoueurs);
                //MessageBox.Show("Partie sauvegardée");
                GestionJoueurs.sauverjoueurs();
                PaquetsDeCartes.SauverPaquets();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("Problème lors de la sauvegarde");
            //}
        }
        public static void Charger()
        {
            GestionJoueurs.ChargerJoueur();
            PaquetsDeCartes.ChargerPaquets();
        }
        public static void Serialiser<T>(string sFichier, T Arg)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            StreamWriter sw = new StreamWriter(sFichier);
            xs.Serialize(sw, Arg);
            sw.Close();
        }

        public static T Desirialiser<T>(string sFichier)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            StreamReader sr = new StreamReader(sFichier);
            T rep = (T) xs.Deserialize(sr);
            return rep;
        }
    }
}
