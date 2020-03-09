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
        List<Carte> PaquetJeu = new List<Carte>();
        List<Carte> PaquetMelange = new List<Carte>();
        List<Carte> MainJoueur1 = new List<Carte>();
        List<Carte> MainJoueur2 = new List<Carte>();
        List<Carte> Defausse = new List<Carte>();
        Point LocPaqMel = new Point(100,300);
        Point LocMainJ1 = new Point(400, 300);
        Point LocMainJ2 =new Point(700,300);
        private int pl = 0, m1 = 0, m2 = 0;

        GestionCartes Gestion =new GestionCartes();
        public int i = 0;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void msCreerPaquetDeJeu_Click(object sender, EventArgs e)
        {
            Gestion.CreerPaquet(ref PaquetJeu);
        }

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
            pbCarte.Invalidate();
            if (pl == PaquetMelange.Count)
            {
                //btnCarteSuivante.Enabled = false;
                pl = 0;
            }
        }

        private void msMelangerPaquet_Click(object sender, EventArgs e)
        {
            Gestion.MelangerPaquet(ref PaquetJeu, ref PaquetMelange);
        }

        private void btnCarteSuivJ1_Click(object sender, EventArgs e)
        {
            m1++;
            pbCarte.Invalidate();
            if (m1 == MainJoueur1.Count)
            {
                //btnCarteSuivante.Enabled = false;
                m1 = 0;
            }

        }

        private void btnCarteSuivJ2_Click(object sender, EventArgs e)
        {
            m2++;
            pbCarte.Invalidate();
            if (m2 == MainJoueur2.Count)
            {
                //btnCarteSuivante.Enabled = false;
                m2 = 0;
            }

        }

        private void msDistribuerCartes_Click(object sender, EventArgs e)
        {
            Gestion.DistribuerCartes(ref PaquetMelange, ref MainJoueur1, ref MainJoueur2);
            pbCarte.Invalidate();
            lblPaqMel.Text = PaquetMelange.Count.ToString();
            lblMainJ1.Text = MainJoueur1.Count.ToString();
            lblMainJ2.Text = MainJoueur2.Count.ToString();
        }

        private void pbCarte_Paint(object sender, PaintEventArgs e)
        {
            if (PaquetMelange.Count > 0 && MainJoueur1.Count > 0 && MainJoueur2.Count > 0)
            {
                e.Graphics.DrawImage(PaquetMelange[pl].ImageCarte, LocPaqMel);
                e.Graphics.DrawImage(MainJoueur1[m1].ImageCarte, LocMainJ1);
                e.Graphics.DrawImage(MainJoueur2[m2].ImageCarte, LocMainJ2);
            }
            else
            {
                e.Graphics.DrawString("Créer le paquet puis mélanger et distribuer les cartes"
                    , new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Chocolate), 350, 350  );
            }

        }
    }
}
