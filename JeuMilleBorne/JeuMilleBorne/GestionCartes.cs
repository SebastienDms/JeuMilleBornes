﻿using System;
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
            for (Carte.NomsCartes nomCarte = Carte.NomsCartes.Prioritaire; nomCarte <= Carte.NomsCartes.AsVolant; nomCarte++)
            {
                Carte carte = new Carte();
                carte.Nom = carte.RetournerTexteNomsCartes(nomCarte);
                carte.Type = carte.RetournerTexteTypesCartes(Carte.TypesCartes.Botte);
                carte.ImageCarte = (Image)Ressource.ResourceManager.GetObject(string.Format("mb_{0}", nomCarte));
                //carte.ImageCarte = Ressource.;
                paquet.Add(carte);
            }
        }
    }
}
