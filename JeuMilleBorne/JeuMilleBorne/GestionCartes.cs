using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    class GestionCartes
    {
        public void CreerPaquet(ref List<Carte> paquet)
        {
            int index = 1;
            for (Carte.NomsCartes nomCarte = Carte.NomsCartes.Prioritaire; nomCarte <= Carte.NomsCartes.AsVolant; nomCarte++)
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
            for (int i = 0; i < 3; i++)
            {
                paquet.Add(CreerCarte(Carte.NomsCartes.Stop, Carte.TypesCartes.Attaque, index));
            }
        }

        public Carte CreerCarte(Carte.NomsCartes nomcarte, Carte.TypesCartes typecarte, int index)
        {
            Carte carte = new Carte();
            carte.Nom = carte.RetournerTexteNomsCartes(nomcarte);
            carte.Type = carte.RetournerTexteTypesCartes(typecarte);
            carte.ImageCarte = (Image)Resource1.ResourceManager.GetObject(string.Format("mb_{0}", index));
            return carte;
        }
    }
}
