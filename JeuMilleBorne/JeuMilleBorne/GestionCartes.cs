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
        }

        public static void DefausserCarte(ref Carte cTmp, ref List<Carte> defausse)
        {
            defausse.Add(cTmp);
            cTmp = null;
        }

        public static void CarteJouee(ref List<Carte> mainJoueur, ref Carte cTmp, int i)
        {
            cTmp = mainJoueur[i];
            mainJoueur.RemoveAt(i);
        }

        public static void JouerCartePiochee(ref Carte cartePiochee, ref Carte cTmp)
        {
            cTmp = cartePiochee;
            cartePiochee = null;
        }

        public static void Reverse(ref Carte cTmp, ref Carte cartePiochee)
        {
            cartePiochee = cTmp;
            cTmp = null;
        }

        public static void PlacerCarte(ref Carte cTmp, ref List<Carte> PileCartes)
        {
            PileCartes.Add(cTmp);
            cTmp = null;
        }

        public static void PlacerCartePiochee(ref List<Carte> mainJoueur, ref Carte cartePiochee)
        {
            mainJoueur.Add(cartePiochee);
            cartePiochee = null;
        }

        public static void LimVitesse(Carte cTmp, List<Carte> PileVitesse, string pile_du_joueur)
        {
            if (pile_du_joueur == "J1")
            {
                if (GestionJoueurs.Tour == 0 && PileVitesse.Count != 0 && PileVitesse[PileVitesse.Count - 1].Nom == Carte.NomsCartes.Lim.ToString() && cTmp.Nom == Carte.NomsCartes.LimFin.ToString())
                {
                    PileVitesse.Add(cTmp);
                    cTmp = null;
                }
                else
                {
                    if (GestionJoueurs.Tour == 1 && (PileVitesse.Count == 0 || (PileVitesse[PileVitesse.Count - 1].Nom == Carte.NomsCartes.LimFin.ToString() && cTmp.Nom == Carte.NomsCartes.Lim.ToString())))
                    {
                        if (CheckBotteJ1())
                        {
                            PileVitesse.Add(cTmp);
                            cTmp = null;
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
                if (GestionJoueurs.Tour == 1 && PileVitesse.Count != 0 && PileVitesse[PileVitesse.Count - 1].Nom == Carte.NomsCartes.Lim.ToString() && cTmp.Nom == Carte.NomsCartes.LimFin.ToString())
                {
                    PileVitesse.Add(cTmp);
                    cTmp = null;
                }
                else
                {
                    if (GestionJoueurs.Tour == 0 && (PileVitesse.Count == 0 || (PileVitesse[PileVitesse.Count - 1].Nom == Carte.NomsCartes.LimFin.ToString() && cTmp.Nom == Carte.NomsCartes.Lim.ToString())))
                    {
                        if (CheckBotteJ2())
                        {
                            PileVitesse.Add(cTmp);
                            cTmp = null;
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

        public static void Bataille(Carte cTmp, List<Carte> PileBataille, string pile_du_joueur)
        {
            if (pile_du_joueur == "J1")
            {
                if (GestionJoueurs.Tour == 0)
                {
                    if (PaquetsDeCartes.J1Bataille.Count == 0)
                    {
                        if (PaquetsDeCartes.Ctmp.Type == Carte.TypesCartes.Roule.ToString())
                        {
                            PileBataille.Add(cTmp);
                            cTmp = null;
                        }
                        else
                        {
                            MessageBox.Show("Vous ne pas ecnore jouer ici.");
                        }
                    }
                    else
                    {
                        if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom == Carte.NomsCartes.Accident.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Reparations.ToString())
                        {
                            if (CheckBotteJ1())
                            {
                                PileBataille.Add(cTmp);
                                cTmp = null;
                            }
                            else
                            {
                                MessageBox.Show("Le joueur est protégé par une botte");
                            }
                        }
                        else
                        {
                            if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom == Carte.NomsCartes.Creve.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Roue.ToString())
                            {
                                if (CheckBotteJ1())
                                {
                                    PileBataille.Add(cTmp);
                                    cTmp = null;
                                }
                                else
                                {
                                    MessageBox.Show("Le joueur est protégé par une botte");
                                }
                            }
                            else
                            {
                                if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom == Carte.NomsCartes.Panne.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Essence.ToString())
                                {
                                    if (CheckBotteJ1())
                                    {
                                        PileBataille.Add(cTmp);
                                        cTmp = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Le joueur est protégé par une botte");
                                    }
                                }
                                else
                                {
                                    if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Nom == Carte.NomsCartes.Stop.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Roule.ToString())
                                    {
                                        if (CheckBotteJ1())
                                        {
                                            PileBataille.Add(cTmp);
                                            cTmp = null;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Le joueur est protégé par une botte");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Impossible de jouer cette carte.");
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
                        if (PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Type == Carte.TypesCartes.Roule.ToString() || PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].Type == Carte.TypesCartes.Defense.ToString())
                        {
                            PileBataille.Add(cTmp);
                            cTmp = null;
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
                        if (PaquetsDeCartes.Ctmp.Type == Carte.TypesCartes.Roule.ToString())
                        {
                            PileBataille.Add(cTmp);
                            cTmp = null;
                        }
                        else
                        {
                            MessageBox.Show("Vous ne pas encore jouer ici.");
                        }
                    }
                    else
                    {
                        if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Nom ==
                                Carte.NomsCartes.Accident.ToString() &&
                                PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Reparations.ToString())
                        {
                            if (CheckBotteJ2())
                            {
                                PileBataille.Add(cTmp);
                                cTmp = null;
                            }
                            else
                            {
                                MessageBox.Show("Le joueur est protégé par une botte");
                            }
                        }
                        else
                        {
                            if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Nom ==
                                Carte.NomsCartes.Creve.ToString() &&
                                PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Roue.ToString())
                            {
                                if (CheckBotteJ2())
                                {
                                    PileBataille.Add(cTmp);
                                    cTmp = null;
                                }
                                else
                                {
                                    MessageBox.Show("Le joueur est protégé par une botte");
                                }
                            }
                            else
                            {
                                if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Nom ==
                                    Carte.NomsCartes.Panne.ToString() &&
                                    PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Essence.ToString())
                                {
                                    if (CheckBotteJ2())
                                    {
                                        PileBataille.Add(cTmp);
                                        cTmp = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Le joueur est protégé par une botte");
                                    }
                                }
                                else
                                {
                                    if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Nom ==
                                        Carte.NomsCartes.Stop.ToString() &&
                                        PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Roule.ToString())
                                    {
                                        if (CheckBotteJ2())
                                        {
                                            PileBataille.Add(cTmp);
                                            cTmp = null;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Le joueur est protégé par une botte");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Impossible de jouer cette carte.");
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
                    }
                    else
                    {
                        if (PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Type == Carte.TypesCartes.Roule.ToString() || PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].Type == Carte.TypesCartes.Defense.ToString())
                        {
                            if (CheckBotteJ2())
                            {
                                PileBataille.Add(cTmp);
                                cTmp = null;
                            }
                            else
                            {
                                MessageBox.Show("Le joueur est protégé par une botte");
                            }
                        }
                    }
                }
            }
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

        public static bool CheckBotte(Carte cTmp)
        {
            bool placer = false;
            if (cTmp.Type == Carte.TypesCartes.Botte.ToString())
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
                    if (c.Nom == Carte.NomsCartes.Prioritaire.ToString())
                    {
                        placer = true;
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

            if (PaquetsDeCartes.J1Bataille.Count == 0)
            {
                placer = true;
            }
            else
            {
                foreach (Carte c in PaquetsDeCartes.J1Bottes)
                {
                    if (c.Nom == Carte.NomsCartes.Citerne.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Panne.ToString())
                    {
                        placer = false;
                    }
                    else
                    {
                        if (c.Nom == Carte.NomsCartes.AsVolant.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Accident.ToString())
                        {
                            placer = false;
                        }
                        else
                        {
                            if (c.Nom == Carte.NomsCartes.Increvable.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Creve.ToString())
                            {
                                placer = false;
                            }
                            else
                            {
                                if (c.Nom == Carte.NomsCartes.Prioritaire.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Stop.ToString())
                                {
                                    placer = false;
                                }
                                else
                                {
                                    if (c.Nom == Carte.NomsCartes.Prioritaire.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Lim.ToString())
                                    {
                                        placer = false;
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

            if (PaquetsDeCartes.J2Bataille.Count == 0)
            {
                placer = true;
            }
            else
            {
                foreach (Carte c in PaquetsDeCartes.J2Bottes)
                {
                    if (c.Nom == Carte.NomsCartes.Citerne.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Panne.ToString())
                    {
                        placer = false;
                    }
                    else
                    {
                        if (c.Nom == Carte.NomsCartes.AsVolant.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Accident.ToString())
                        {
                            placer = false;
                        }
                        else
                        {
                            if (c.Nom == Carte.NomsCartes.Increvable.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Creve.ToString())
                            {
                                placer = false;
                            }
                            else
                            {
                                if (c.Nom == Carte.NomsCartes.Prioritaire.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Stop.ToString())
                                {
                                    placer = false;
                                }
                                else
                                {
                                    if (c.Nom == Carte.NomsCartes.Prioritaire.ToString() && PaquetsDeCartes.Ctmp.Nom == Carte.NomsCartes.Lim.ToString())
                                    {
                                        placer = false;
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

    }
}
