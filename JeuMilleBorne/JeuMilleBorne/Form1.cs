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
        #region Donnees
        List<Carte> PaquetJeu = new List<Carte>();
        List<Carte> PaquetMelange = new List<Carte>();
        List<Carte> Defausse = new List<Carte>();
        Carte Carte_piochee = new Carte();
        Carte Ctmp = new Carte();
        List<Carte> MainJoueur1 = new List<Carte>();
        List<Carte> J1Bottes = new List<Carte>();
        List<Carte> J1Vitesse = new List<Carte>();
        List<Carte> J1Bataille = new List<Carte>();
        List<Carte> J1Bornes25 = new List<Carte>();
        List<Carte> J1Bornes50 = new List<Carte>();
        List<Carte> J1Bornes75 = new List<Carte>();
        List<Carte> J1Bornes100 = new List<Carte>();
        List<Carte> J1Bornes200 = new List<Carte>();
        List<Carte> MainJoueur2 = new List<Carte>();
        List<Carte> J2Bottes = new List<Carte>();
        List<Carte> J2Vitesse = new List<Carte>();
        List<Carte> J2Bataille = new List<Carte>();
        List<Carte> J2Bornes25 = new List<Carte>();
        List<Carte> J2Bornes50 = new List<Carte>();
        List<Carte> J2Bornes75 = new List<Carte>();
        List<Carte> J2Bornes100 = new List<Carte>();
        List<Carte> J2Bornes200 = new List<Carte>();
        //Point LocPaqMel = new Point(100,300);
        //Point LocMainJ1 = new Point(400, 300);
        //Point LocMainJ2 =new Point(700,300);
        private int pl = 0, m1 = 0, m2 = 0;
        private GestionCartes Gestion = new GestionCartes();
        private GestionSurfaceJeu GestionSurface = new GestionSurfaceJeu();
        public int tour = 0;
        #endregion

        #region Accesseurs

        public int Tour
        {
            get => tour;
            set => tour = value;
        }

        #endregion
        public FormPrincipal()
        {
            InitializeComponent();
            GestionSurface.CreerPlateau();
            Carte_piochee = null;
        }

        #region CreationPaquetDeJeu
        private void msCreerPaquetDeJeu_Click(object sender, EventArgs e)
        {
            Gestion.CreerPaquet(ref PaquetJeu);
        }
        private void msMelangerPaquet_Click(object sender, EventArgs e)
        {
            Gestion.MelangerPaquet(ref PaquetJeu, ref PaquetMelange);
        }
        private void msDistribuerCartes_Click(object sender, EventArgs e)
        {
            Gestion.DistribuerCartes(ref PaquetMelange, ref MainJoueur1, ref MainJoueur2);
            //pbJOpCarte6.Invalidate();
            lblPaqMel.Text = PaquetMelange.Count.ToString();
            lblMainJ1.Text = MainJoueur1.Count.ToString();
            lblMainJ2.Text = MainJoueur2.Count.ToString();
            Afficher();
            Tour = Gestion.TourAlea();
            if (Tour == 0)
                MessageBox.Show("C'est au joueur 1 de commencer la partie");
            if (Tour == 1)
                MessageBox.Show("C'est au joueur 2 de commencer la partie");
        }
        #endregion
        private void btnCarteSuivante_Click(object sender, EventArgs e)
        {
            /*lblInfoCarte.Text = PaquetJeu[i].Type + " : " + PaquetJeu[i].Nom;
            pbCarte.Image = PaquetJeu[i].ImageCarte;*/

            //       /!\ A reflechir /!\
            //Graphics g = CreateGraphics();
            //g.DrawImage(PaquetMelange[i].ImageCarte, ...);

            //lblInfoCarte.Text = "Carte : " + i.ToString() + " " + PaquetMelange[i].Type + " : " + PaquetMelange[i].Nom;
            //pbCarte.Image = PaquetMelange[i].ImageCarte;



            //i++;
            //if (i==106)
            //{
            //    btnCarteSuivante.Enabled = false;
            //}
            pl++;
            pbJOpCarte6.Invalidate();
            Afficher();
            if (pl == PaquetMelange.Count)
            {
                //btnCarteSuivante.Enabled = false;
                pl = 0;
            }
        }

        private void btnCarteSuivJ1_Click(object sender, EventArgs e)
        {
            m1++;
            pbJOpCarte6.Invalidate();
            if (m1 == MainJoueur1.Count)
            {
                //btnCarteSuivante.Enabled = false;
                m1 = 0;
            }

        }

        private void btnCarteSuivJ2_Click(object sender, EventArgs e)
        {
            m2++;
            pbJOpCarte6.Invalidate();
            if (m2 == MainJoueur2.Count)
            {
                //btnCarteSuivante.Enabled = false;
                m2 = 0;
            }

        }

        #region PiocheEtDefausse
        private void pbPioche_Click(object sender, EventArgs e)
        {
            Gestion.Piocher(ref PaquetMelange, ref Carte_piochee);
            Afficher();
        }

        private void pbDefausse_Click(object sender, EventArgs e)
        {
            Gestion.DefausserCarte(ref Ctmp, ref Defausse);
            Afficher();
        }
        #endregion
        #region ZoneJoueur1
        private void pbJECCarte1_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur1, ref Ctmp, 0);
            Gestion.PlacerCartePiochee(ref MainJoueur1, ref Carte_piochee);
            Afficher();
        }

        private void pbJECCarte2_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur1, ref Ctmp, 1);
            Gestion.PlacerCartePiochee(ref MainJoueur1, ref Carte_piochee);
            Afficher();
        }

        private void pbJECCarte3_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur1, ref Ctmp, 2);
            Gestion.PlacerCartePiochee(ref MainJoueur1, ref Carte_piochee);
            Afficher();
        }

        private void pbJECCarte4_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur1, ref Ctmp, 3);
            Gestion.PlacerCartePiochee(ref MainJoueur1, ref Carte_piochee);
            Afficher();
        }

        private void pbJECCarte5_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur1, ref Ctmp, 4);
            Gestion.PlacerCartePiochee(ref MainJoueur1, ref Carte_piochee);
            Afficher();
        }

        private void pbJECCarte6_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur1, ref Ctmp, 5);
            Gestion.PlacerCartePiochee(ref MainJoueur1, ref Carte_piochee);
            Afficher();
        }

        private void pbJECVit25_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J1Bornes25);
            Afficher();
        }

        private void pbJECVit50_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J1Bornes50);
            Afficher();
        }

        private void pbJECVit75_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J1Bornes75);
            Afficher();
        }

        private void pbJECVit100_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J1Bornes100);
            Afficher();
        }

        private void pbJECVit200_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J1Bornes200);
            Afficher();
        }

        private void pbJECBotte1_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J1Bottes);
            Afficher();
        }

        private void pbJECBotte2_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J1Bottes);
            Afficher();
        }

        private void pbJECBotte3_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J1Bottes);
            Afficher();
        }

        private void pbJECBotte4_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J1Bottes);
            Afficher();
        }

        private void pbJECVitesse_Click(object sender, EventArgs e)
        {
            Gestion.LimVitesse(ref Ctmp, ref J1Vitesse);
            Afficher();
        }
        private void pbJECBataille_Click(object sender, EventArgs e)
        {
            Gestion.Bataille(ref Ctmp, ref J1Bataille);
            Afficher();
        }

        #endregion

        #region CartePiochee

        private void pbCartePiochee_Click(object sender, EventArgs e)
        {
            Gestion.JouerCartePiochee(ref Carte_piochee, ref Ctmp);
        }

        #endregion
        #region ZoneJoueur2
        private void pbJOpCarte1_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur2, ref Ctmp, 0);
            Gestion.PlacerCartePiochee(ref MainJoueur2, ref Carte_piochee);
            Afficher();
        }
        private void pbJOpCarte2_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur2, ref Ctmp, 1);
            Gestion.PlacerCartePiochee(ref MainJoueur2, ref Carte_piochee);
            Afficher();
        }
        private void pbJOpCarte3_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur2, ref Ctmp, 2);
            Gestion.PlacerCartePiochee(ref MainJoueur2, ref Carte_piochee);
            Afficher();
        }
        private void pbJOpCarte4_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur2, ref Ctmp, 3);
            Gestion.PlacerCartePiochee(ref MainJoueur2, ref Carte_piochee);
            Afficher();
        }
        private void pbJOpCarte5_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur2, ref Ctmp, 4);
            Gestion.PlacerCartePiochee(ref MainJoueur2, ref Carte_piochee);
            Afficher();
        }
        private void pbJOpCarte6_Click(object sender, EventArgs e)
        {
            Gestion.CarteJouee(ref MainJoueur2, ref Ctmp, 5);
            Gestion.PlacerCartePiochee(ref MainJoueur2, ref Carte_piochee);
            Afficher();
        }
        private void pbJOpVit25_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J2Bornes25);
            Afficher();
        }

        private void pbJOpVit50_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J2Bornes50);
            Afficher();
        }

        private void pbJOpVit75_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J2Bornes75);
            Afficher();
        }

        private void pbJOpVit100_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J2Bornes100);
            Afficher();
        }

        private void pbJOpVit200_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J2Bornes200);
            Afficher();
        }

        private void pbJOpBotte1_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J2Bottes);
            Afficher();
        }

        private void pbJOpBotte2_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J2Bottes);
            Afficher();
        }

        private void pbJOpBotte3_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J2Bottes);
            Afficher();
        }

        private void pbJOpBotte4_Click(object sender, EventArgs e)
        {
            Gestion.PlacerCarte(ref Ctmp, ref J2Bottes);
            Afficher();
        }

        private void pbJOpVitesse_Click(object sender, EventArgs e)
        {
            Gestion.LimVitesse(ref Ctmp, ref J2Vitesse);
            Afficher();
        }

        private void pbJOpBataille_Click(object sender, EventArgs e)
        {
            Gestion.Bataille(ref Ctmp, ref J2Bataille);
            Afficher();
        }

        #endregion

        private void Afficher()
        {
            pbPioche.Image = PaquetMelange[pl].ImageCarte;
            // Afficher la pile de cartes défaussées
            if (Defausse.Count !=0 )
                pbDefausse.Image=Defausse[Defausse.Count-1].ImageCarte;
            else
            {
                pbDefausse.Image = null;
                pbDefausse.BackColor = Color.LightGreen;
            }
            // Affache carte piochée
            if (Carte_piochee != null)
                pbCartePiochee.Image = Carte_piochee.ImageCarte;
            else
            {
                pbCartePiochee.Image = null;
                pbCartePiochee.BackColor = Color.LightGreen;
            }
            // Plateau coté Joueur 1
            pbJECCarte1.BackgroundImage = MainJoueur1[0].ImageCarte;
            pbJECCarte2.BackgroundImage = MainJoueur1[1].ImageCarte;
            pbJECCarte3.BackgroundImage = MainJoueur1[2].ImageCarte;
            pbJECCarte4.BackgroundImage = MainJoueur1[3].ImageCarte;
            pbJECCarte5.BackgroundImage = MainJoueur1[4].ImageCarte;
            pbJECCarte6.BackgroundImage = MainJoueur1[5].ImageCarte;
            if (J1Bornes25.Count != 0)
                pbJECVit25.BackgroundImage = J1Bornes25[J1Bornes25.Count-1].ImageCarte;
            else
            {
                pbJECVit25.Image = null;
                pbJECVit25.BackColor = Color.LightGreen;
            }
            if (J1Bornes50.Count != 0)
                pbJECVit50.BackgroundImage = J1Bornes50[J1Bornes50.Count - 1].ImageCarte;
            else
            {
                pbJECVit50.Image = null;
                pbJECVit50.BackColor = Color.LightGreen;
            }
            if (J1Bornes75.Count != 0)
                pbJECVit75.BackgroundImage = J1Bornes75[J1Bornes75.Count - 1].ImageCarte;
            else
            {
                pbJECVit75.Image = null;
                pbJECVit75.BackColor = Color.LightGreen;
            }
            if (J1Bornes100.Count != 0)
                pbJECVit100.BackgroundImage = J1Bornes100[J1Bornes100.Count - 1].ImageCarte;
            else
            {
                pbJECVit100.Image = null;
                pbJECVit100.BackColor = Color.LightGreen;
            }
            if (J1Bornes200.Count != 0)
                pbJECVit200.BackgroundImage = J1Bornes200[J1Bornes200.Count - 1].ImageCarte;
            else
            {
                pbJECVit200.Image = null;
                pbJECVit200.BackColor = Color.LightGreen;
            }

            if (J1Bottes.Count >= 1)
                pbJECBotte1.Image = J1Bottes[0].ImageCarte;
            else
            {
                pbJECBotte1.Image = null;
                pbJECBotte1.BackColor = Color.LightGreen;
            }
            if (J1Bottes.Count >= 2)
                pbJECBotte2.Image = J1Bottes[1].ImageCarte;
            else
            {
                pbJECBotte2.Image = null;
                pbJECBotte2.BackColor = Color.LightGreen;
            }
            if (J1Bottes.Count >= 3)
                pbJECBotte3.Image = J1Bottes[2].ImageCarte;
            else
            {
                pbJECBotte3.Image = null;
                pbJECBotte3.BackColor = Color.LightGreen;
            }
            if (J1Bottes.Count >= 4)
                pbJECBotte4.Image = J1Bottes[3].ImageCarte;
            else
            {
                pbJECBotte4.Image = null;
                pbJECBotte4.BackColor = Color.LightGreen;
            }
            if (J1Vitesse.Count != 0)
                pbJECVitesse.Image = J1Vitesse[J1Vitesse.Count - 1].ImageCarte;
            else
            {
                pbJECVitesse.Image = null;
                pbJECVitesse.BackColor = Color.LightGreen;
            }
            if (J1Bataille.Count != 0)
                pbJECBataille.Image = J1Bataille[J1Bataille.Count - 1].ImageCarte;
            else
            {
                pbJECBataille.Image = null;
                pbJECBataille.BackColor = Color.LightGreen;
            }
            // Fin affichage plateau Joueur1
            // Affichage plateau coté Joueur2
            pbJOpCarte1.Image = MainJoueur2[0].ImageCarte;
            pbJOpCarte2.Image = MainJoueur2[1].ImageCarte;
            pbJOpCarte3.Image = MainJoueur2[2].ImageCarte;
            pbJOpCarte4.Image = MainJoueur2[3].ImageCarte;
            pbJOpCarte5.Image = MainJoueur2[4].ImageCarte;
            pbJOpCarte6.Image = MainJoueur2[5].ImageCarte;
            if (J2Bornes25.Count != 0)
                pbJOpVit25.BackgroundImage = J2Bornes25[J2Bornes25.Count - 1].ImageCarte;
            else
            {
                pbJOpVit25.Image = null;
                pbJOpVit25.BackColor = Color.LightGreen;
            }
            if (J2Bornes50.Count != 0)
                pbJOpVit50.BackgroundImage = J2Bornes50[J2Bornes50.Count - 1].ImageCarte;
            else
            {
                pbJOpVit50.Image = null;
                pbJOpVit50.BackColor = Color.LightGreen;
            }
            if (J2Bornes75.Count != 0)
                pbJOpVit75.BackgroundImage = J2Bornes75[J2Bornes75.Count - 1].ImageCarte;
            else
            {
                pbJOpVit75.Image = null;
                pbJOpVit75.BackColor = Color.LightGreen;
            }
            if (J2Bornes100.Count != 0)
                pbJOpVit100.BackgroundImage = J2Bornes100[J2Bornes100.Count - 1].ImageCarte;
            else
            {
                pbJOpVit100.Image = null;
                pbJOpVit100.BackColor = Color.LightGreen;
            }
            if (J2Bornes200.Count != 0)
                pbJOpVit200.BackgroundImage = J2Bornes200[J2Bornes200.Count - 1].ImageCarte;
            else
            {
                pbJOpVit200.Image = null;
                pbJOpVit200.BackColor = Color.LightGreen;
            }

            if (J2Bottes.Count >= 1)
                pbJOpBotte1.Image = J2Bottes[0].ImageCarte;
            else
            {
                pbJOpBotte1.Image = null;
                pbJOpBotte1.BackColor = Color.LightGreen;
            }
            if (J2Bottes.Count >= 2)
                pbJOpBotte2.Image = J2Bottes[1].ImageCarte;
            else
            {
                pbJOpBotte2.Image = null;
                pbJOpBotte2.BackColor = Color.LightGreen;
            }
            if (J2Bottes.Count >= 3)
                pbJOpBotte3.Image = J2Bottes[2].ImageCarte;
            else
            {
                pbJOpBotte3.Image = null;
                pbJOpBotte3.BackColor = Color.LightGreen;
            }
            if (J2Bottes.Count >= 4)
                pbJOpBotte4.Image = J2Bottes[3].ImageCarte;
            else
            {
                pbJOpBotte4.Image = null;
                pbJOpBotte4.BackColor = Color.LightGreen;
            }
            if (J2Vitesse.Count != 0)
                pbJOpVitesse.Image = J2Vitesse[J2Vitesse.Count - 1].ImageCarte;
            else
            {
                pbJOpVitesse.Image = null;
                pbJOpVitesse.BackColor = Color.LightGreen;
            }
            if (J2Bataille.Count != 0)
                pbJOpBataille.Image = J2Bataille[J2Bataille.Count - 1].ImageCarte;
            else
            {
                pbJOpBataille.Image = null;
                pbJOpBataille.BackColor = Color.LightGreen;
            }

            // Fin affichage plateau Joueur2
        }

        /*private void pbCarte_Paint(object sender, PaintEventArgs e)
        {
            if (PaquetMelange.Count > 0 && MainJoueur1.Count > 0 && MainJoueur2.Count > 0)
            {
                for (int k = 0; k < 2; k++)
                {
                    int carte = 0, lg = 0;
                    for (int j = 2; j < 8; j++)
                    {
                        e.Graphics.DrawImage(MainJoueur2[carte].ImageCarte, GestionSurface.Plateau.Zones[lg, j]);
                        lg = lg + 4;
                        e.Graphics.DrawImage(MainJoueur1[carte].ImageCarte, GestionSurface.Plateau.Zones[lg, j]);
                        carte++;
                        lg = 0;
                    }
                }

                e.Graphics.DrawImage(PaquetMelange[pl].ImageCarte, GestionSurface.Plateau.Zones[1,0]);

                //carte = 0;
                //for (int j = 34; j < 40; j++)
                //{
                //    e.Graphics.DrawImage(MainJoueur1[carte].ImageCarte, GestionSurface.Plateau.Zones[7,j]);
                //    carte++;
                //}

                //e.Graphics.DrawImage(PaquetMelange[pl].ImageCarte, LocPaqMel);
                //e.Graphics.DrawImage(MainJoueur1[m1].ImageCarte, LocMainJ1);
                //e.Graphics.DrawImage(MainJoueur2[m2].ImageCarte, LocMainJ2);
            }
            else
            {
                e.Graphics.DrawString("Créer le paquet puis mélanger et distribuer les cartes"
                    , new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Chocolate), 350, 350  );
            }
        }*/
    }
}
