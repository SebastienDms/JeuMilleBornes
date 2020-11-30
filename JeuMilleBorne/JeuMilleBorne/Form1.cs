using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuMilleBorne
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (GestionSauvegarde.Partie_chargee)
                Afficher();

            btnCarteSuivante.Visible = false;
            btnCarteSuivJ1.Visible = false;
            btnCarteSuivJ2.Visible = false;
            GestionSurfaceJeu.CreerPlateau();
            //PaquetsDeCartes.Carte_piochee = null;
            lblJ1.Text = GestionJoueurs.Joueur1.Pseudo;
            lblJ2.Text = GestionJoueurs.Joueur2.Pseudo;
            lblScoreEnCoursJ1.Text = GestionJoueurs.Joueur1.Points.ToString();
            lblScoreEnCoursJ2.Text = GestionJoueurs.Joueur2.Points.ToString();
        }
        #region CreationPaquetDeJeu
        private void msCreerPaquetDeJeu_Click(object sender, EventArgs e)
        {
            GestionCartes.CreerPaquet(PaquetsDeCartes.PaquetJeu);
        }
        private void msMelangerPaquet_Click(object sender, EventArgs e)
        {
            GestionCartes.MelangerPaquet(PaquetsDeCartes.PaquetJeu, PaquetsDeCartes.PaquetMelange);
        }
        private void msDistribuerCartes_Click(object sender, EventArgs e)
        {
            GestionCartes.DistribuerCartes(PaquetsDeCartes.PaquetMelange, PaquetsDeCartes.MainJoueur1, PaquetsDeCartes.MainJoueur2);
            lblPaqMel.Text = PaquetsDeCartes.PaquetMelange.Count.ToString();
            lblMainJ1.Text = GestionJoueurs.Tour.ToString();
            lblMainJ2.Text = "";/*PaquetsDeCartes.MainJoueur2.Count.ToString();*/
            GestionJoueurs.Tour = GestionJoueurs.TourAlea();
            if (GestionJoueurs.Tour == 0)
                MessageBox.Show("C'est au joueur 1 de commencer la partie");
            if (GestionJoueurs.Tour == 1)
                MessageBox.Show("C'est au joueur 2 de commencer la partie");

            Afficher();

        }
        #endregion
        #region PiocheEtDefausse
        private void pbPioche_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (PaquetsDeCartes.PaquetMelange.Count == 0)
            {
                GestionCartes.MelangerPaquet(PaquetsDeCartes.Defausse, PaquetsDeCartes.PaquetMelange);
                MessageBox.Show("La défausse a été mélangée.");
            }

            if (GestionCartes.piocher)
            {
                if (GestionJoueurs.Tour == 0 && me.Button == MouseButtons.Right)
                {
                    GestionCartes.TricheJ1();
                }
                else
                {
                    GestionCartes.Piocher(ref PaquetsDeCartes.PaquetMelange, ref PaquetsDeCartes.Carte_piochee);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas piocher une seconde fois!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            Afficher();
        }
        private void pbDefausse_Click(object sender, EventArgs e)
        {
            if (PaquetsDeCartes.Ctmp.Nom == "")
            {
                MessageBox.Show("Veuillez sélectionner une carte à défausser.");
            }
            else
            {
                GestionCartes.DefausserCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.Defausse);
                //if (GestionJoueurs.Tour == 0)
                //{
                //    GestionJoueurs.Tour = 1;
                //}
                //else
                //{
                //    GestionJoueurs.Tour = 0;
                //}
                GestionCartes.JoueurSuivant();
            }

            Afficher();
        }
        #endregion
        #region ZoneJoueur1
        private void pbJECCarte1_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 0 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Ctmp, 0);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 0)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJECCarte2_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 0 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Ctmp, 1);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 0)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJECCarte3_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 0 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Ctmp, 2);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 0)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJECCarte4_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 0 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Ctmp, 3);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 0)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJECCarte5_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 0 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Ctmp, 4);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 0)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJECCarte6_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 0 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Ctmp, 5);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur1, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 0)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJECVit25_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J1Bataille, PaquetsDeCartes.J1Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check25(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J1Bornes25);
                    //GestionJoueurs.Tour = 1;
                    GestionCartes.JoueurSuivant();
                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJECVit50_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J1Bataille, PaquetsDeCartes.J1Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check50(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J1Bornes50);
                    //GestionJoueurs.Tour = 1;
                    GestionCartes.JoueurSuivant();
                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJECVit75_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J1Bataille, PaquetsDeCartes.J1Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check75(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J1Bornes75);
                    //GestionJoueurs.Tour = 1;
                    GestionCartes.JoueurSuivant();
                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJECVit100_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J1Bataille, PaquetsDeCartes.J1Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check100(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J1Bornes100);
                    //GestionJoueurs.Tour = 1;
                    GestionCartes.JoueurSuivant();
                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJECVit200_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J1Bataille, PaquetsDeCartes.J1Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check200(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J1Bornes200);
                    //GestionJoueurs.Tour = 1;
                    GestionCartes.JoueurSuivant();
                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }

        #region ZoneBotte
        private void pbJECBotte1_Click(object sender, EventArgs e)
        {
            if (GestionCartes.CheckPlacerBotte(PaquetsDeCartes.Ctmp))
            {
                GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J1Bottes);
                GestionCartes.piocher = true;
            }
            else
            {
                MessageBox.Show("Cette carte ne se place ici.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJECBotte2_Click(object sender, EventArgs e)
        {
            if (GestionCartes.CheckPlacerBotte(PaquetsDeCartes.Ctmp))
            {
                GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J1Bottes);
                GestionCartes.piocher = true;
            }
            else
            {
                MessageBox.Show("Cette carte ne se place ici.");
                GestionCartes.Reverse();
            }

            Afficher();
        }
        private void pbJECBotte3_Click(object sender, EventArgs e)
        {
            if (GestionCartes.CheckPlacerBotte(PaquetsDeCartes.Ctmp))
            {
                GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J1Bottes);
                GestionCartes.piocher = true;
            }
            else
            {
                MessageBox.Show("Cette carte ne se place ici.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJECBotte4_Click(object sender, EventArgs e)
        {
            if (GestionCartes.CheckPlacerBotte(PaquetsDeCartes.Ctmp))
            {
                GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J1Bottes);
                GestionCartes.piocher = true;
            }
            else
            {
                MessageBox.Show("Cette carte ne se place ici.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        #endregion
        private void pbJECVitesse_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 0)
            {
                GestionCartes.LimVitesse(PaquetsDeCartes.Ctmp, PaquetsDeCartes.J1Vitesse, "J1");
                //GestionJoueurs.Tour = 1;
                GestionCartes.JoueurSuivant();
            }
            else
            {
                GestionCartes.LimVitesse(PaquetsDeCartes.Ctmp, PaquetsDeCartes.J1Vitesse, "J1");
                //GestionJoueurs.Tour = 0;
                GestionCartes.JoueurSuivant();
            }
            Afficher();
        }
        private void pbJECBataille_Click(object sender, EventArgs e)
        {
            if (GestionCartes.Bataille(PaquetsDeCartes.Ctmp, PaquetsDeCartes.J1Bataille, "J1"))
            {
                //if (GestionJoueurs.Tour == 0)
                //{
                //    GestionJoueurs.Tour = 1;
                //}
                //else
                //{
                //    GestionJoueurs.Tour = 0;
                //}
                GestionCartes.JoueurSuivant();
            }
            else
            {
                GestionCartes.Reverse();
            }
            Afficher();
        }
        #endregion
        #region CartePiochee
        private void pbCartePiochee_Click(object sender, EventArgs e)
        {
            if (PaquetsDeCartes.Carte_piochee.Nom == "")
            {
                MessageBox.Show("Il n'y a pas de carte...");
            }
            else
            {
                GestionCartes.JouerCartePiochee(ref PaquetsDeCartes.Carte_piochee, ref PaquetsDeCartes.Ctmp);

            }
            Afficher();
        }
        #endregion
        #region ZoneJoueur2
        private void pbJOpCarte1_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 1 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Ctmp, 0);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 1)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJOpCarte2_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 1 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Ctmp, 1);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 1)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJOpCarte3_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 1 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Ctmp, 2);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 1)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJOpCarte4_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 1 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Ctmp, 3);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 1)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJOpCarte5_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 1 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Ctmp, 4);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 1)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJOpCarte6_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 1 && PaquetsDeCartes.Carte_piochee.Nom != "")
            {
                GestionCartes.CarteJouee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Ctmp, 5);
                GestionCartes.PlacerCartePiochee(ref PaquetsDeCartes.MainJoueur2, ref PaquetsDeCartes.Carte_piochee);
            }
            else
            {
                if (GestionJoueurs.Tour == 1)
                {
                    MessageBox.Show("Tu dois d'abord piocher une carte!");

                }
                else
                {
                    MessageBox.Show("Ce n'est pas ta zone de jeu !");
                }
            }
            Afficher();
        }
        private void pbJOpVit25_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J2Bataille, PaquetsDeCartes.J2Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check25(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J2Bornes25);
                    //GestionJoueurs.Tour = 0;
                    GestionCartes.JoueurSuivant();
                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJOpVit50_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J2Bataille, PaquetsDeCartes.J2Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check50(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J2Bornes50);
                    //GestionJoueurs.Tour = 0;
                    GestionCartes.JoueurSuivant();
                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJOpVit75_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J2Bataille, PaquetsDeCartes.J2Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check75(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J2Bornes75);
                    //GestionJoueurs.Tour = 0;
                    GestionCartes.JoueurSuivant();

                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJOpVit100_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J2Bataille, PaquetsDeCartes.J2Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check100(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J2Bornes100);
                    //GestionJoueurs.Tour = 0;
                    GestionCartes.JoueurSuivant();
                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJOpVit200_Click(object sender, EventArgs e)
        {
            if (GestionCartes.AuthorisationAvancer(PaquetsDeCartes.J2Bataille, PaquetsDeCartes.J2Bottes, PaquetsDeCartes.Ctmp))
            {
                if (GestionCartes.Check200(PaquetsDeCartes.Ctmp))
                {
                    GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J2Bornes200);
                    //GestionJoueurs.Tour = 0;
                    GestionCartes.JoueurSuivant();
                }
                else
                {
                    MessageBox.Show("Cette carte ne se place pas ici !");
                    GestionCartes.Reverse();
                }
            }
            else
            {
                MessageBox.Show("Vous devez placer une carte feu vert pour pouvoir avancer.");
                GestionCartes.Reverse();
            }
            Afficher();
        }
        private void pbJOpBotte1_Click(object sender, EventArgs e)
        {
            if (GestionCartes.CheckPlacerBotte(PaquetsDeCartes.Ctmp))
            {
                GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J2Bottes);
                GestionCartes.piocher = true;
            }
            else
            {
                MessageBox.Show("Cette carte ne se place ici.");
            }
            Afficher();
        }
        private void pbJOpBotte2_Click(object sender, EventArgs e)
        {
            if (GestionCartes.CheckPlacerBotte(PaquetsDeCartes.Ctmp))
            {
                GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J2Bottes);
                GestionCartes.piocher = true;
            }
            else
            {
                MessageBox.Show("Cette carte ne se place ici.");
            }
            Afficher();
        }
        private void pbJOpBotte3_Click(object sender, EventArgs e)
        {
            if (GestionCartes.CheckPlacerBotte(PaquetsDeCartes.Ctmp))
            {
                GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J2Bottes);
                GestionCartes.piocher = true;
            }
            else
            {
                MessageBox.Show("Cette carte ne se place ici.");
            }
            Afficher();
        }
        private void pbJOpBotte4_Click(object sender, EventArgs e)
        {
            if (GestionCartes.CheckPlacerBotte(PaquetsDeCartes.Ctmp))
            {
                GestionCartes.PlacerCarte(ref PaquetsDeCartes.Ctmp, ref PaquetsDeCartes.J2Bottes);
                GestionCartes.piocher = true;
            }
            else
            {
                MessageBox.Show("Cette carte ne se place ici.");
            }
            Afficher();
        }
        private void pbJOpVitesse_Click(object sender, EventArgs e)
        {
            if (GestionJoueurs.Tour == 0)
            {
                GestionCartes.LimVitesse(PaquetsDeCartes.Ctmp, PaquetsDeCartes.J2Vitesse, "J2");
                //GestionJoueurs.Tour = 1;
                GestionCartes.JoueurSuivant();
            }
            else
            {
                GestionCartes.LimVitesse(PaquetsDeCartes.Ctmp, PaquetsDeCartes.J2Vitesse, "J2");
                //GestionJoueurs.Tour = 0;
                GestionCartes.JoueurSuivant();
            }
            Afficher();
        }
        private void pbJOpBataille_Click(object sender, EventArgs e)
        {
            if (GestionCartes.Bataille(PaquetsDeCartes.Ctmp, PaquetsDeCartes.J2Bataille, "J2"))
            {
                //if (GestionJoueurs.Tour == 0)
                //{
                //    GestionJoueurs.Tour = 1;
                //}
                //else
                //{
                //    GestionJoueurs.Tour = 0;
                //}
                GestionCartes.JoueurSuivant();
            }
            else
            {
                GestionCartes.Reverse();
            }
            Afficher();
        }

        #endregion
        #region Afficher
        private void Afficher()
        {
            lblMainJ1.Text = GestionJoueurs.Tour.ToString();
            // Affiche c'est au tour de ...
            if (GestionJoueurs.Tour == 0)
            {
                lblAQui.Text = "C'est au Joueur 1 de jouer";
            }
            else
            {
                lblAQui.Text = "C'est au Joueur 2 de jouer";
            }
            // Affiche le nombre de carte dans la pioche
            lblPaqMel.Text = PaquetsDeCartes.PaquetMelange.Count.ToString();
            // Affiche la pioche
            pbPioche.Image = Resource1.dos;
            // Afficher la pile de cartes défaussées
            if (PaquetsDeCartes.Defausse.Count != 0)
                pbDefausse.Image = PaquetsDeCartes.Defausse[PaquetsDeCartes.Defausse.Count - 1].ImageCarte;
            else
            {
                pbDefausse.Image = null;
                pbDefausse.BackColor = Color.LightGreen;
            }
            // Affache carte piochée
            if (PaquetsDeCartes.Carte_piochee.Nom != "")
                pbCartePiochee.Image = PaquetsDeCartes.Carte_piochee.ImageCarte;
            else
            {
                pbCartePiochee.Image = null;
                pbCartePiochee.BackColor = Color.LightGreen;
            }
            // Plateau coté Joueur 1
            try
            {
                if (GestionJoueurs.Tour == 1)
                {
                    pbJECCarte1.BackgroundImage = Resource1.dos;
                    pbJECCarte2.BackgroundImage = Resource1.dos;
                    pbJECCarte3.BackgroundImage = Resource1.dos;
                    pbJECCarte4.BackgroundImage = Resource1.dos;
                    pbJECCarte5.BackgroundImage = Resource1.dos;
                    pbJECCarte6.BackgroundImage = Resource1.dos;
                }
                else
                {
                    pbJECCarte1.BackgroundImage = PaquetsDeCartes.MainJoueur1[0].ImageCarte;
                    pbJECCarte2.BackgroundImage = PaquetsDeCartes.MainJoueur1[1].ImageCarte;
                    pbJECCarte3.BackgroundImage = PaquetsDeCartes.MainJoueur1[2].ImageCarte;
                    pbJECCarte4.BackgroundImage = PaquetsDeCartes.MainJoueur1[3].ImageCarte;
                    pbJECCarte5.BackgroundImage = PaquetsDeCartes.MainJoueur1[4].ImageCarte;
                    pbJECCarte6.BackgroundImage = PaquetsDeCartes.MainJoueur1[5].ImageCarte;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vous devez d'abord piocher une carte!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            if (PaquetsDeCartes.J1Bornes25.Count != 0)
                pbJECVit25.BackgroundImage = PaquetsDeCartes.J1Bornes25[PaquetsDeCartes.J1Bornes25.Count - 1].ImageCarte;
            else
            {
                pbJECVit25.Image = null;
                pbJECVit25.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J1Bornes50.Count != 0)
                pbJECVit50.BackgroundImage = PaquetsDeCartes.J1Bornes50[PaquetsDeCartes.J1Bornes50.Count - 1].ImageCarte;
            else
            {
                pbJECVit50.Image = null;
                pbJECVit50.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J1Bornes75.Count != 0)
                pbJECVit75.BackgroundImage = PaquetsDeCartes.J1Bornes75[PaquetsDeCartes.J1Bornes75.Count - 1].ImageCarte;
            else
            {
                pbJECVit75.Image = null;
                pbJECVit75.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J1Bornes100.Count != 0)
                pbJECVit100.BackgroundImage = PaquetsDeCartes.J1Bornes100[PaquetsDeCartes.J1Bornes100.Count - 1].ImageCarte;
            else
            {
                pbJECVit100.Image = null;
                pbJECVit100.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J1Bornes200.Count != 0)
                pbJECVit200.BackgroundImage = PaquetsDeCartes.J1Bornes200[PaquetsDeCartes.J1Bornes200.Count - 1].ImageCarte;
            else
            {
                pbJECVit200.Image = null;
                pbJECVit200.BackColor = Color.LightGreen;
            }

            if (PaquetsDeCartes.J1Bottes.Count >= 1)
                pbJECBotte1.Image = PaquetsDeCartes.J1Bottes[0].ImageCarte;
            else
            {
                pbJECBotte1.Image = null;
                pbJECBotte1.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J1Bottes.Count >= 2)
                pbJECBotte2.Image = PaquetsDeCartes.J1Bottes[1].ImageCarte;
            else
            {
                pbJECBotte2.Image = null;
                pbJECBotte2.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J1Bottes.Count >= 3)
                pbJECBotte3.Image = PaquetsDeCartes.J1Bottes[2].ImageCarte;
            else
            {
                pbJECBotte3.Image = null;
                pbJECBotte3.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J1Bottes.Count >= 4)
                pbJECBotte4.Image = PaquetsDeCartes.J1Bottes[3].ImageCarte;
            else
            {
                pbJECBotte4.Image = null;
                pbJECBotte4.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J1Vitesse.Count != 0)
                pbJECVitesse.Image = PaquetsDeCartes.J1Vitesse[PaquetsDeCartes.J1Vitesse.Count - 1].ImageCarte;
            else
            {
                pbJECVitesse.Image = null;
                pbJECVitesse.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J1Bataille.Count != 0)
                pbJECBataille.Image = PaquetsDeCartes.J1Bataille[PaquetsDeCartes.J1Bataille.Count - 1].ImageCarte;
            else
            {
                pbJECBataille.Image = null;
                pbJECBataille.BackColor = Color.LightGreen;
            }
            // Affichage des points du joueur 1
            lblScoreEnCoursJ1.Text = GestionJoueurs.PointsJ1().ToString();
            // Fin affichage plateau Joueur1
            // Affichage plateau coté Joueur2
            try
            {
                if (GestionJoueurs.Tour == 0)
                {
                    pbJOpCarte1.Image = Resource1.dos;
                    pbJOpCarte2.Image = Resource1.dos;
                    pbJOpCarte3.Image = Resource1.dos;
                    pbJOpCarte4.Image = Resource1.dos;
                    pbJOpCarte5.Image = Resource1.dos;
                    pbJOpCarte6.Image = Resource1.dos;

                }
                else
                {
                    pbJOpCarte1.Image = PaquetsDeCartes.MainJoueur2[0].ImageCarte;
                    pbJOpCarte2.Image = PaquetsDeCartes.MainJoueur2[1].ImageCarte;
                    pbJOpCarte3.Image = PaquetsDeCartes.MainJoueur2[2].ImageCarte;
                    pbJOpCarte4.Image = PaquetsDeCartes.MainJoueur2[3].ImageCarte;
                    pbJOpCarte5.Image = PaquetsDeCartes.MainJoueur2[4].ImageCarte;
                    pbJOpCarte6.Image = PaquetsDeCartes.MainJoueur2[5].ImageCarte;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vous devez d'abord piocher une carte!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            if (PaquetsDeCartes.J2Bornes25.Count != 0)
                pbJOpVit25.BackgroundImage = PaquetsDeCartes.J2Bornes25[PaquetsDeCartes.J2Bornes25.Count - 1].ImageCarte;
            else
            {
                pbJOpVit25.Image = null;
                pbJOpVit25.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J2Bornes50.Count != 0)
                pbJOpVit50.BackgroundImage = PaquetsDeCartes.J2Bornes50[PaquetsDeCartes.J2Bornes50.Count - 1].ImageCarte;
            else
            {
                pbJOpVit50.Image = null;
                pbJOpVit50.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J2Bornes75.Count != 0)
                pbJOpVit75.BackgroundImage = PaquetsDeCartes.J2Bornes75[PaquetsDeCartes.J2Bornes75.Count - 1].ImageCarte;
            else
            {
                pbJOpVit75.Image = null;
                pbJOpVit75.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J2Bornes100.Count != 0)
                pbJOpVit100.BackgroundImage = PaquetsDeCartes.J2Bornes100[PaquetsDeCartes.J2Bornes100.Count - 1].ImageCarte;
            else
            {
                pbJOpVit100.Image = null;
                pbJOpVit100.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J2Bornes200.Count != 0)
                pbJOpVit200.BackgroundImage = PaquetsDeCartes.J2Bornes200[PaquetsDeCartes.J2Bornes200.Count - 1].ImageCarte;
            else
            {
                pbJOpVit200.Image = null;
                pbJOpVit200.BackColor = Color.LightGreen;
            }

            if (PaquetsDeCartes.J2Bottes.Count >= 1)
                pbJOpBotte1.Image = PaquetsDeCartes.J2Bottes[0].ImageCarte;
            else
            {
                pbJOpBotte1.Image = null;
                pbJOpBotte1.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J2Bottes.Count >= 2)
                pbJOpBotte2.Image = PaquetsDeCartes.J2Bottes[1].ImageCarte;
            else
            {
                pbJOpBotte2.Image = null;
                pbJOpBotte2.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J2Bottes.Count >= 3)
                pbJOpBotte3.Image = PaquetsDeCartes.J2Bottes[2].ImageCarte;
            else
            {
                pbJOpBotte3.Image = null;
                pbJOpBotte3.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J2Bottes.Count >= 4)
                pbJOpBotte4.Image = PaquetsDeCartes.J2Bottes[3].ImageCarte;
            else
            {
                pbJOpBotte4.Image = null;
                pbJOpBotte4.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J2Vitesse.Count != 0)
                pbJOpVitesse.Image = PaquetsDeCartes.J2Vitesse[PaquetsDeCartes.J2Vitesse.Count - 1].ImageCarte;
            else
            {
                pbJOpVitesse.Image = null;
                pbJOpVitesse.BackColor = Color.LightGreen;
            }
            if (PaquetsDeCartes.J2Bataille.Count != 0)
                pbJOpBataille.Image = PaquetsDeCartes.J2Bataille[PaquetsDeCartes.J2Bataille.Count - 1].ImageCarte;
            else
            {
                pbJOpBataille.Image = null;
                pbJOpBataille.BackColor = Color.LightGreen;
            }
            // Affichage des points du joueur 1
            lblScoreEnCoursJ2.Text = GestionJoueurs.PointsJ2().ToString();
            // Fin affichage plateau Joueur2
        }
        #endregion
        #region Options
        private void sauverPartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionSauvegarde.Sauver();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afficher();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Vous êtes sur le point de quitter le jeu.\nSouhaitez-vous sauver la partie?", "Attention",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                GestionSauvegarde.Sauver();
            }
        }
        #endregion

        #region Réseau

        //private void EnvoieReseau()
        //{
        //    //byte[] bufferBytes=byte.TryParse("");
        //    var dataJ = GestionJoueurs.envoiePourReseau();
        //    var separator = Encoding.Unicode.GetBytes("|");
        //    //var dataC = PaquetsDeCartes.EnvoiePourReseau();

        //    //GestionConnexion._Buffer = dataJ;
        //    Array.Copy(dataJ, GestionConnexion._Buffer, dataJ.Length);
        //    Array.Copy(separator, 0, GestionConnexion._Buffer, GestionConnexion._Buffer.Length, dataJ.Length);
        //    //Array.Copy(dataC, 0, GestionConnexion._Buffer, GestionConnexion._Buffer.Length, dataC.Length);
        //    //Array.

        //    //GestionConnexion._Buffer = dataJ;

        //    MessageBox.Show("Taille infos joueurs: " + dataJ.Length.ToString() + " ou " + dataJ.LongLength.ToString() +
        //                    ". Taille infos cartes: " + dataC.Length.ToString() + " ou " + dataC.LongLength.ToString());
        //    //GestionConnexion.SendData();
        //}

        #endregion
    }
}
