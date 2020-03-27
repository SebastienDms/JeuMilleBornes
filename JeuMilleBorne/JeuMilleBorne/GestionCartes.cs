using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuMilleBorne
{
    class GestionCartes
    {
        #region Donnees

        private Random alea = new Random();

        #endregion

        public int TourAlea()
        {
            return alea.Next(0, 2);
        }
        public void CreerPaquet(ref List<Carte> paquet)
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

        public Carte CreerCarte(Carte.NomsCartes nomcarte, Carte.TypesCartes typecarte, int index)
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

        public void MelangerPaquet(ref List<Carte> paquet, ref List<Carte> paquetmelange)
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

        public void DistribuerCartes(ref List<Carte> paquetmelange, ref List<Carte> mjoueur1, ref List<Carte> mjoueur2)
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

        public void Piocher(ref List<Carte> paquetmel, ref Carte ctmp)
        {
            ctmp = paquetmel[0];
            paquetmel.RemoveAt(0);
        }

        public void DefausserCarte(ref Carte cTmp, ref List<Carte> defausse)
        {
            defausse.Add(cTmp);
            cTmp = null;
        }

        public void CarteJouee(ref List<Carte> mainJoueur,ref Carte cTmp, int i)
        {
            cTmp = mainJoueur[i];
            mainJoueur.RemoveAt(i);
        }

        public void JouerCartePiochee(ref Carte cartePiochee, ref Carte cTmp)
        {
            cTmp = cartePiochee;
            cartePiochee = null;
        }

        public void PlacerCarte(ref Carte cTmp, ref List<Carte> PileCartes)
        {
            PileCartes.Add(cTmp);
            cTmp = null;
        }

        public void PlacerCartePiochee(ref List<Carte> mainJoueur, ref Carte cartePiochee)
        {
            mainJoueur.Add(cartePiochee);
            cartePiochee = null;
        }

        public void LimVitesse(ref Carte cTmp, ref List<Carte> PileVitesse)
        {
            PileVitesse.Add(cTmp);
            cTmp = null;
        }

        public void Bataille(ref Carte cTmp, ref List<Carte> PileBataille)
        {
            PileBataille.Add(cTmp);
            cTmp = null;
        }

        public bool Check25(ref Carte cTmp)
        {
            if (cTmp.Valeur == 25)
            {
                MessageBox.Show("Je passe par ici... la valeur est"+ cTmp.Valeur.ToString());
                return true;
            }
            else
            {
                MessageBox.Show("Non je passe par là..." + cTmp.Valeur.ToString());
                return false;
            }
        }

        public bool Check50(ref Carte cTmp)
        {
            if (cTmp.Valeur == 50)
            {
                MessageBox.Show("Je passe par ici...");
                return true;
            }
            else
            {
                MessageBox.Show("Non je passe par là...");
                return false;
            }
        }

        public bool Check75(ref Carte cTmp)
        {
            if (cTmp.Valeur == 75)
            {
                MessageBox.Show("Je passe par ici...");
                return true;
            }
            else
            {
                MessageBox.Show("Non je passe par là...");
                return false;
            }
        }

        public bool Check100(ref Carte cTmp)
        {
            if (cTmp.Valeur == 100)
            {
                MessageBox.Show("Je passe par ici...");
                return true;
            }
            else
            {
                MessageBox.Show("Non je passe par là...");
                return false;
            }
        }

        public bool Check200(ref Carte cTmp)
        {
            if (cTmp.Valeur == 200)
            {
                MessageBox.Show("Je passe par ici...");
                return true;
            }
            else
            {
                MessageBox.Show("Non je passe par là...");
                return false;
            }
        }
    }
}
