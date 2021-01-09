using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuMilleBorne
{
    static class GestionCartes
    {
        #region Donnees
        public static bool piocher = true;
        public static bool FlagNetwork { get; set; } = false;
        public static bool FlagServer { get; set; } = false;
        public static bool FlagClient { get; set; } = false;
        #endregion
        public static void CreerPaquet(List<Carte> paquet)
        {
            int index = 1;
            for (Carte.NomsCartes nomCarte = Carte.NomsCartes.Prioritaire;
                nomCarte <= Carte.NomsCartes.AsVolant;
                nomCarte++)
            {
                paquet.Add(CreerCarte(nomCarte, Carte.TypesCartes.Botte, index));
                index++;
            }

            for (int i = 0; i < 3; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Accident, Carte.TypesCartes.Attaque, index));
            }

            index++;
            for (int i = 0; i < 3; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Creve, Carte.TypesCartes.Attaque, index));
            }

            index++;
            for (int i = 0; i < 4; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Lim, Carte.TypesCartes.Attaque, index));
            }

            index++;
            for (int i = 0; i < 3; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Panne, Carte.TypesCartes.Attaque, index));
            }

            index++;
            for (int i = 0; i < 5; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Stop, Carte.TypesCartes.Attaque, index));
            }

            index++;
            for (int i = 0; i < 6; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Reparations, Carte.TypesCartes.Defense, index));
            }

            index++;
            for (int i = 0; i < 6; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Roue, Carte.TypesCartes.Defense, index));
            }

            index++;
            for (int i = 0; i < 6; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.LimFin, Carte.TypesCartes.Defense, index));
            }

            index++;
            for (int i = 0; i < 6; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Essence, Carte.TypesCartes.Defense, index));
            }

            index++;
            for (int i = 0; i < 14; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Roule, Carte.TypesCartes.Roule, index));
            }

            index = 25;
            for (int i = 0; i < 10; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.VingtCinq, Carte.TypesCartes.Vitesse, index));
            }

            index += 25;
            for (int i = 0; i < 10; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Cinquante, Carte.TypesCartes.Vitesse, index));
            }

            index += 25;
            for (int i = 0; i < 10; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.SeptanteCinq, Carte.TypesCartes.Vitesse, index));
            }

            index += 25;
            for (int i = 0; i < 12; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Cent, Carte.TypesCartes.Vitesse, index));
            }

            index *= 2;
            for (int i = 0; i < 4; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.DeuxCents, Carte.TypesCartes.Vitesse, index));
            }

            MessageBox.Show("Le jeu de " + paquet.Count.ToString() + " cartes a été créé", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static Carte CreerCarte(Carte.NomsCartes nomcarte, Carte.TypesCartes typecarte, int index)
        {
            Carte carte = new Carte();
            carte.Nom = carte.RetournerTexteNomsCartes(nomcarte);
            carte.Type = carte.RetournerTexteTypesCartes(typecarte);
            carte.ImageCarte = (Image) Resource1.ResourceManager.GetObject(string.Format("mb_{0}", index));
            if (index == 25)
                carte.Valeur = index;
            if (index == 50)
                carte.Valeur = index;
            if (index == 75)
                carte.Valeur = index;
            if (index == 100)
                carte.Valeur = index;
            if (index == 200)
                carte.Valeur = index;
            return carte;
        }

        public static void MelangerPaquet(List<Carte> paquet, List<Carte> paquetmelange)
        {
            Random ran = new Random();

            while (paquetmelange.Count < paquet.Count)
            {
                int i = ran.Next(0, paquet.Count);
                if (!paquetmelange.Contains(paquet[i]))
                {
                    paquetmelange.Add(paquet[i]);
                }
            }

            MessageBox.Show("Le paquet a été mélangé et contient " + paquet.Count.ToString(), "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void DistribuerCartes(List<Carte> paquetmelange, List<Carte> mjoueur1, List<Carte> mjoueur2)
        {
            for (int i = 0; i < 12; i++)
            {
                /** MessageBox.Show("Carte " + i.ToString() + " et carte " + (i + 1).ToString()); **/
                mjoueur1.Add(paquetmelange[i]);
                mjoueur2.Add(paquetmelange[i+1]);
                i++;
            }
            paquetmelange.RemoveRange(0,12);

            MessageBox.Show("Distribution des cartes terminée");
        }

        public static void Piocher(ref List<Carte> paquetmel, ref Carte ctmp)
        {
            ctmp = paquetmel[0];
            paquetmel.RemoveAt(0);
            if (ctmp.Type == "Botte")
                piocher = true;
            else
                piocher = false;

        }

        public static void ReverseDatas()
        {
            var tmp1 = PaquetsDeCartes.MainJoueur1;
            var tmp2 = PaquetsDeCartes.J1Bottes;
            var tmp3 = PaquetsDeCartes.J1Vitesse;
            var tmp4 = PaquetsDeCartes.J1Bataille;
            var tmp5 = PaquetsDeCartes.J1Bornes25;
            var tmp6 = PaquetsDeCartes.J1Bornes50;
            var tmp7 = PaquetsDeCartes.J1Bornes75;
            var tmp8 = PaquetsDeCartes.J1Bornes100;
            var tmp9 = PaquetsDeCartes.J1Bornes200;

            PaquetsDeCartes.MainJoueur1 = PaquetsDeCartes.MainJoueur2;
            PaquetsDeCartes.J1Bottes = PaquetsDeCartes.J2Bottes;
            PaquetsDeCartes.J1Vitesse = PaquetsDeCartes.J2Vitesse;
            PaquetsDeCartes.J1Bataille = PaquetsDeCartes.J2Bataille;
            PaquetsDeCartes.J1Bornes25 = PaquetsDeCartes.J2Bornes25;
            PaquetsDeCartes.J1Bornes50 = PaquetsDeCartes.J2Bornes50;
            PaquetsDeCartes.J1Bornes75 = PaquetsDeCartes.J2Bornes75;
            PaquetsDeCartes.J1Bornes100 = PaquetsDeCartes.J2Bornes100;
            PaquetsDeCartes.J1Bornes200 = PaquetsDeCartes.J2Bornes200;

            PaquetsDeCartes.MainJoueur2 = tmp1;
            PaquetsDeCartes.J2Bottes = tmp2;
            PaquetsDeCartes.J2Vitesse = tmp3;
            PaquetsDeCartes.J2Bataille = tmp4;
            PaquetsDeCartes.J2Bornes25 = tmp5;
            PaquetsDeCartes.J2Bornes50 = tmp6;
            PaquetsDeCartes.J2Bornes75 = tmp7;
            PaquetsDeCartes.J2Bornes100 = tmp8;
            PaquetsDeCartes.J2Bornes200 = tmp9;

            var jTmp1 = GestionJoueurs.Joueur1;
            GestionJoueurs.Joueur1 = GestionJoueurs.Joueur2;
            GestionJoueurs.Joueur2 = jTmp1;
            if (GestionJoueurs.tour == 0)
            {
                GestionJoueurs.tour = 1;
            }
            else
            {
                GestionJoueurs.tour = 0;
                piocher = true;
            }
        }

        public static void JoueurSuivant()
        {
            if (GestionJoueurs.Tour == 0)
            {
                GestionJoueurs.Tour = 1;
            }
            else
            {
                GestionJoueurs.Tour = 0;
            }

            if (FlagNetwork && GestionJoueurs.tour==1)
            {
                piocher = false;
            }
            else
            {
                piocher = true;
            }
        }
        public static void DefausserCarte(ref Carte cTmp, ref List<Carte> defausse)
        {
            defausse.Add(cTmp);
            cTmp = new Carte();
        }

        public static void CarteJouee(ref List<Carte> mainJoueur, ref Carte cTmp, int i)
        {
            cTmp = mainJoueur[i];
            mainJoueur.RemoveAt(i);
        }

        public static void JouerCartePiochee(ref Carte cartePiochee, ref Carte cTmp)
        {
            cTmp = cartePiochee;
            cartePiochee = new Carte();
        }

        public static void Reverse()
        {
            PaquetsDeCartes.Carte_piochee = PaquetsDeCartes.Ctmp;
            PaquetsDeCartes.Ctmp = new Carte();
        }

        public static void PlacerCarte(ref Carte cTmp, ref List<Carte> PileCartes)
        {
            PileCartes.Add(cTmp);
            cTmp = new Carte();
        }

        public static void PlacerCartePiochee(ref List<Carte> mainJoueur, ref Carte cartePiochee)
        {
            mainJoueur.Add(cartePiochee);
            cartePiochee = new Carte();
        }

        public static void LimVitesse(Carte cTmp, List<Carte> PileVitesse, string pile_du_joueur)
        {
            if (pile_du_joueur == "J1")
            {
                if (GestionJoueurs.Tour == 0 && PileVitesse.Count != 0 && PileVitesse[PileVitesse.Count - 1].Nom == "Limite de vitesse à 50" && 
                    cTmp.Nom == "Fin de Limite de vitesse")
                {
                    PileVitesse.Add(cTmp);
                    cTmp = new Carte();
                }
                else
                {
                    if (GestionJoueurs.Tour == 1 && (PileVitesse.Count == 0 || (PileVitesse[PileVitesse.Count - 1].Nom == "Fin de Limite de vitesse" &&
                                                                                cTmp.Nom == "Limite de vitesse à 50")))
                    {
                        if (CheckBotteJ1())
                        {
                            PileVitesse.Add(cTmp);
                            cTmp = new Carte();
                        }
                        else
                        {
                            MessageBox.Show("Le joueur est protégé par une botte");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce n'est pas le moment de jouer cette carte ici.");
                    }
                }
            }
            else
            {
                if (GestionJoueurs.Tour == 1 && PileVitesse.Count != 0 && PileVitesse[PileVitesse.Count - 1].Nom == "Limite de vitesse à 50" &&
                    cTmp.Nom == "Fin de Limite de vitesse")
                {
                    PileVitesse.Add(cTmp);
                    cTmp = new Carte();
                }
                else
                {
                    if (GestionJoueurs.Tour == 0 && (PileVitesse.Count == 0 || (PileVitesse[PileVitesse.Count - 1].Nom == "Fin de Limite de vitesse" &&
                                                                                cTmp.Nom == "Limite de vitesse à 50")))
                    {
                        if (CheckBotteJ2())
                        {
                            PileVitesse.Add(cTmp);
                            cTmp = new Carte();
                        }
                        else
                        {
                            MessageBox.Show("Le joueur est protégé par une botte");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce n'est pas le moment de jouer cette carte ici.");
                    }
                }

            }
        }

        public static bool Bataille(Carte cTmp, List<Carte> PileBataille, string pile_du_joueur)
        {
            bool check = false;
            if (pile_du_joueur == "J1")
            {
                if (GestionJoueurs.Tour == 0)
                {
                    if (PaquetsDeCartes.J1Bataille.Count == 0)
                    {
                        if (PaquetsDeCartes.Ctmp.Type == Carte.TypesCartes.Roule.ToString())
                        {
                            PileBataille.Add(cTmp);
                            cTmp = new Carte();
                            check = true;
                        }
                        else
                        {
                            MessageBox.Show("Vous ne pas ecnore jouer ici.");
                            check = false;
                        }
                    }
                    else
                    {
                        if (cTmp.Type == Carte.TypesCartes.Attaque.ToString())
                        {
                            MessageBox.Show("Vous ne pouvez pas vous attaquer !");
                            check = false;
                        }
                        else
                        {
                            if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom == "Accident..." &&
                                PaquetsDeCartes.Ctmp.Nom == "Réparations")
                            {
                                if (CheckBotteJ1())
                                {
                                    PileBataille.Add(cTmp);
                                    cTmp = new Carte();
                                    check = true;
                                }
                                else
                                {
                                    MessageBox.Show("Vous êtes protégé par une botte");
                                    check = false;
                                }
                            }
                            else
                            {
                                if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom == "Crevé !" &&
                                    PaquetsDeCartes.Ctmp.Nom == "Roue de secours")
                                {
                                    if (CheckBotteJ1())
                                    {
                                        PileBataille.Add(cTmp);
                                        cTmp = new Carte();
                                        check = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vous êtes protégé par une botte");
                                        check = false;
                                    }
                                }
                                else
                                {
                                    if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom ==
                                        "Panne d'essence" && PaquetsDeCartes.Ctmp.Nom == "Essence")
                                    {
                                        if (CheckBotteJ1())
                                        {
                                            PileBataille.Add(cTmp);
                                            cTmp = new Carte();
                                            check = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Vous êtes protégé par une botte");
                                            check = false;
                                        }
                                    }
                                    else
                                    {
                                        if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom ==
                                            "Feux rouge" && PaquetsDeCartes.Ctmp.Nom == "Feux vert")
                                        {
                                            if (CheckBotteJ1())
                                            {
                                                PileBataille.Add(cTmp);
                                                cTmp = new Carte();
                                                check = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Vous êtes protégé par une botte");
                                                check = false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Impossible de jouer cette carte.");
                                            check = false;
                                        }

                                    }

                                }

                            }
                        }
                    }
                }
                else
                {
                    if (PaquetsDeCartes.J1Bataille.Count == 0)
                    {
                        MessageBox.Show("Vous ne pouvez pas encore attaquer.");
                    }
                    else
                    {
                        if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Type == "Roule" ||
                            PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Type == "Défense")
                        {
                            if (CheckBotteJ1())
                            {
                                PileBataille.Add(cTmp);
                                cTmp = new Carte();
                                check = true;
                            }
                            else
                            {
                                MessageBox.Show("Le joueur est protégé par une botte");
                                check = false;
                            }
                        }
                    }
                }
            }
            else
            {
                if (GestionJoueurs.Tour == 1)
                {
                    if (PaquetsDeCartes.J2Bataille.Count == 0)
                    {
                        if (PaquetsDeCartes.Ctmp.Type == "Roule")
                        {
                            PileBataille.Add(cTmp);
                            cTmp = new Carte();
                            check = true;
                        }
                        else
                        {
                            MessageBox.Show("Vous ne pas encore jouer ici.");
                            check = false;
                        }
                    }
                    else
                    {
                        if (cTmp.Type == Carte.TypesCartes.Attaque.ToString())
                        {
                            MessageBox.Show("Vous ne pouvez pas vous attaquer !");
                            check = false;
                        }
                        else
                        {
                            if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Nom == "Accident..." &&
                                PaquetsDeCartes.Ctmp.Nom == "Réparations")
                            {
                                if (CheckBotteJ2())
                                {
                                    PileBataille.Add(cTmp);
                                    cTmp = new Carte();
                                    check = true;
                                }
                                else
                                {
                                    MessageBox.Show("Le joueur est protégé par une botte");
                                    check = false;
                                }
                            }
                            else
                            {
                                if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Nom == "Crevé !" &&
                                    PaquetsDeCartes.Ctmp.Nom == "Roue de secours")
                                {
                                    if (CheckBotteJ2())
                                    {
                                        PileBataille.Add(cTmp);
                                        cTmp = new Carte();
                                        check = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Le joueur est protégé par une botte");
                                        check = false;
                                    }
                                }
                                else
                                {
                                    if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Nom ==
                                        "Panne d'essence" &&
                                        PaquetsDeCartes.Ctmp.Nom == "Essence")
                                    {
                                        if (CheckBotteJ2())
                                        {
                                            PileBataille.Add(cTmp);
                                            cTmp = new Carte();
                                            check = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Le joueur est protégé par une botte");
                                            check = false;
                                        }
                                    }
                                    else
                                    {
                                        if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Nom ==
                                            "Feux rouge" &&
                                            PaquetsDeCartes.Ctmp.Nom == "Feux vert")
                                        {
                                            if (CheckBotteJ2())
                                            {
                                                PileBataille.Add(cTmp);
                                                cTmp = new Carte();
                                                check = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Le joueur est protégé par une botte");
                                                check = false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Impossible de jouer cette carte.");
                                            check = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (PaquetsDeCartes.J2Bataille.Count == 0)
                    {
                        MessageBox.Show("Vous ne pouvez pas encore attaquer.");
                        check = false;
                    }
                    else
                    {
                        if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Type == "Roule" || 
                            PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Type == "Défense")
                        {
                            if (CheckBotteJ2())
                            {
                                PileBataille.Add(cTmp);
                                cTmp = new Carte();
                                check = true;
                            }
                            else
                            {
                                MessageBox.Show("Le joueur est protégé par une botte");
                                check = false;
                            }
                        }
                    }
                }
            }

            return check;
        }

        public static bool Check25(Carte cTmp)
        {
            if (cTmp.Valeur == 25)
            {
                //MessageBox.Show("Je passe par ici... la valeur est"+ cTmp.Valeur.ToString());
                return true;
            }
            else
            {
                //MessageBox.Show("Non je passe par là..." + cTmp.Valeur.ToString());
                return false;
            }
        }

        public static bool Check50(Carte cTmp)
        {
            if (cTmp.Valeur == 50)
            {
                //MessageBox.Show("Je passe par ici...");
                return true;
            }
            else
            {
                //MessageBox.Show("Non je passe par là...");
                return false;
            }
        }

        public static bool Check75(Carte cTmp)
        {
            if (cTmp.Valeur == 75)
            {
                //MessageBox.Show("Je passe par ici...");
                return true;
            }
            else
            {
                //MessageBox.Show("Non je passe par là...");
                return false;
            }
        }

        public static bool Check100(Carte cTmp)
        {
            if (cTmp.Valeur == 100)
            {
                //MessageBox.Show("Je passe par ici...");
                return true;
            }
            else
            {
                //MessageBox.Show("Non je passe par là...");
                return false;
            }
        }

        public static bool Check200(Carte cTmp)
        {
            if (cTmp.Valeur == 200)
            {
                //MessageBox.Show("Je passe par ici...");
                return true;
            }
            else
            {
                //MessageBox.Show("Non je passe par là...");
                return false;
            }
        }

        public static bool CheckPlacerBotte(Carte cTmp)
        {
            bool placer = false;

            if (cTmp.Type == "Botte")
            {
                placer = true;
            }
            else
            {
                placer = false;
            }

            return placer;
        }

        public static bool AuthorisationAvancer(List<Carte> PileBataille, List<Carte> ListeBotte, Carte cTmp)
        {
            bool placer = false;

            if (PileBataille.Count == 0 )
            {
                foreach (Carte c in ListeBotte)
                {
                    if (c.Nom == "Véhicule prioritaire (contre feux rouge et limite de vitesse)")
                    {
                        placer = true;
                        break;
                    }
                    else
                    {
                        placer = false;
                    }
                }
            }
            else
            {
                placer = true;
            }

            return placer;
        }

        public static bool CheckBotteJ1()
        {
            bool placer = false;

            if (PaquetsDeCartes.J1Bottes.Count == 0)
            {
                placer = true;
            }
            else
            {
                foreach (Carte c in PaquetsDeCartes.J1Bottes)
                {
                    if (c.Nom == "Citerne d'essence" && PaquetsDeCartes.Ctmp.Nom == "Panne d'essence")
                    {
                        placer = false;
                        break;
                    }
                    else
                    {
                        if (c.Nom == "As du volant" && PaquetsDeCartes.Ctmp.Nom == "Accident...")
                        {
                            placer = false;
                            break;
                        }
                        else
                        {
                            if (c.Nom == "Increvable !" && PaquetsDeCartes.Ctmp.Nom == "Crevé !")
                            {
                                placer = false;
                                break;
                            }
                            else
                            {
                                if (c.Nom == "Véhicule prioritaire (contre feux rouge et limite de vitesse)" && PaquetsDeCartes.Ctmp.Nom == "Feux rouge")
                                {
                                    placer = false;
                                    break;
                                }
                                else
                                {
                                    if (c.Nom == "Véhicule prioritaire (contre feux rouge et limite de vitesse)" && PaquetsDeCartes.Ctmp.Nom == "Limite de vitesse à 50")
                                    {
                                        placer = false;
                                        break;
                                    }
                                    else
                                    {
                                        placer = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return placer;
        }
        public static bool CheckBotteJ2()
        {
            bool placer = false;

            if (PaquetsDeCartes.J2Bottes.Count == 0)
            {
                placer = true;
            }
            else
            {
                foreach (Carte c in PaquetsDeCartes.J2Bottes)
                {
                    if (c.Nom == "Citerne d'essence" && PaquetsDeCartes.Ctmp.Nom == "Panne d'essence")
                    {
                        placer = false;
                        break;
                    }
                    else
                    {
                        if (c.Nom == "As du volant" && PaquetsDeCartes.Ctmp.Nom == "Accident...")
                        {
                            placer = false;
                            break;
                        }
                        else
                        {
                            if (c.Nom == "Increvable !" && PaquetsDeCartes.Ctmp.Nom == "Crevé !")
                            {
                                placer = false;
                                break;
                            }
                            else
                            {
                                if (c.Nom == "Véhicule prioritaire (contre feux rouge et limite de vitesse)" && PaquetsDeCartes.Ctmp.Nom == "Feux rouge")
                                {
                                    placer = false;
                                    break;
                                }
                                else
                                {
                                    if (c.Nom == "Véhicule prioritaire (contre feux rouge et limite de vitesse)" && PaquetsDeCartes.Ctmp.Nom == "Limite de vitesse à 50")
                                    {
                                        placer = false;
                                        break;
                                    }
                                    else
                                    {
                                        placer = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return placer;
        }

        public static void TricheJ1()
        {
            string carte_triche = "";
            if (PaquetsDeCartes.J1Bataille.Count == 0 && PaquetsDeCartes.J1Bottes.Count == 0)
            {
                carte_triche = "Feux vert";
            }
            else
            {
                if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count-1].Nom == "Panne d'essence")
                {
                    carte_triche = "Essence";
                }
                else
                {
                    if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom == "Crevé !")
                    {
                        carte_triche = "Roue de secours";
                    }
                    else
                    {
                        if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom == "Accident...")
                        {
                            carte_triche = "Réparations";
                        }
                        else
                        {
                            if (PaquetsDeCartes.J1Vitesse[PaquetsDeCartes.J1Vitesse.Count - 1].Nom == "Limite de vitesse à 50")
                            {
                                carte_triche = "Fin de Limite de vitesse";
                            }
                            else
                            {
                                if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom == "Feux rouge")
                                {
                                    carte_triche = "Feux vert";
                                }
                            }
                        }
                    }
                }
            }

            int i = 0;
            foreach (Carte c in PaquetsDeCartes.PaquetMelange)
            {
                if (c.Nom == carte_triche)
                {
                    PaquetsDeCartes.Carte_piochee = c;
                    break;
                }

                i++;
            }
            PaquetsDeCartes.PaquetMelange.RemoveAt(i);
        }
    }
}
