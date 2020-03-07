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
            lblInfoCarte.Text = "Carte : " + i.ToString() + " " + PaquetMelange[i].Type + " : " + PaquetMelange[i].Nom;
            pbCarte.Image = PaquetMelange[i].ImageCarte;


            i++;
            if (i==106)
            {
                btnCarteSuivante.Enabled = false;
            }
        }

        private void msMelangerPaquet_Click(object sender, EventArgs e)
        {
            Gestion.MelangerPaquet(ref PaquetJeu, ref PaquetMelange);
        }
    }
}
