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
    public partial class FicAccueil : Form
    {
        public FicAccueil()
        {
            InitializeComponent();
        }

        private void btnAccueilSuivant_Click(object sender, EventArgs e)
        {
            GestionJoueurs.Joueur1.Pseudo = tbAccueilJ1Pseudo.Text;
            GestionJoueurs.Joueur1.Num_joueur = 0;
            GestionJoueurs.Joueur1.Points = 0;
            GestionJoueurs.Joueur2.Pseudo = tbAccueilJ2Pseudo.Text ;
            GestionJoueurs.Joueur2.Num_joueur = 1;
            GestionJoueurs.Joueur2.Points = 0;
            this.Close();
        }
    }
}
