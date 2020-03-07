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
    }
}
