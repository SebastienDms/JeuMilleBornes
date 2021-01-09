using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuMilleBorne
{
    public partial class FicAccueil : Form
    {
        //private int tentatives = 0;
        private GestionConnexion connexion = new GestionConnexion();

        public FicAccueil()
        {
            InitializeComponent();
            //gbJouer.Enabled = false;
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

        private void btnChargerPartie_Click(object sender, EventArgs e)
        {
            GestionSauvegarde.Charger();
            this.Close();
        }

        private void FicAccueil_Load(object sender, EventArgs e)
        {

        }
        private void btnLoadServers_Click(object sender, EventArgs e)
        {
            btnCreerServer.Enabled = false;
            btnAccueilSuivant.Enabled = false;
            btnChargerPartie.Enabled = false;
            fPing();
        }

        #region Ping

        public async void fPing()
        {
            List<Task<string>> tasks = new List<Task<string>>();

            for (int i = 1; i <= 255; i++)
            {
                string ip = "192.168.1." + i.ToString();
                //PingReply pingReponse = await ;
                tasks.Add(PingTask(ip));
            }

            var res = await Task.WhenAll(tasks);

            foreach (var hostname in res)
            {
                if (hostname != null)
                {
                    cbServers.Items.Add(hostname);
                }
            }

            MessageBox.Show("Scan terminé");
        }

        public Task<string> PingTask(string ip)
        {
            return Task.Run(() => Ping(ip)).ContinueWith(task =>
            {
                IPHostEntry repEntry = null;

                if (task.Result.Status == IPStatus.Success)
                {
                    try
                    {
                        repEntry = Dns.GetHostEntry(task.Result.Address);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
                //? permet de renvoyer null ou le hostname \\
                return repEntry?.HostName.ToString();
            });
        }

        public async Task<PingReply> Ping(string ip)
        {
            Ping pingServer = new Ping();
            PingReply rep = await pingServer.SendPingAsync(ip, 100);
            return rep;
        }
        #endregion

        private async void btnCreerServer_Click(object sender, EventArgs e)
        {
            gbJoueurClient.Enabled = false;
            btnAccueilSuivant.Enabled = false;
            btnChargerPartie.Enabled = false;
            btnCreerServer.Enabled = false;
            btnEnvoyerPseudo.Enabled = false;

            //SerializeDataNetwork.GetFieldValues(new PaquetsDeCartes());

            await connexion.Server();
            /* Set des différents flags */
            GestionCartes.FlagNetwork = true;
            GestionCartes.FlagServer = true;
            GestionCartes.FlagClient = false;

            /* Attente de données provenant du client */
            var test = await connexion.ReceiveData();
            
            if (true)
            {
                MessageBox.Show("Bien reçu! (Serveur)");
            }
        }

        private async void btnCreerClient_Click(object sender, EventArgs e)
        {
            try
            {
                await connexion.Client(cbServers.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez choisir un serveur dans la liste!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            gbJoueurClient.Enabled = false;
            GestionCartes.FlagNetwork = true;
            GestionCartes.FlagClient = true;
            GestionCartes.FlagServer = false;
            btnCreerClient.Enabled = false;
        }
        private async void btnEnvoyerPseudo_Click(object sender, EventArgs e)
        {
            if (tb1.Text != string.Empty)
            {
                GestionJoueurs.Joueur1.Pseudo = tb1.Text;
                GestionJoueurs.Joueur1.Num_joueur = 0;
                GestionJoueurs.Joueur1.Points = 0;
                /*pseudo J2 en attente*/
                GestionJoueurs.Joueur2.Num_joueur = 1;
                GestionJoueurs.Joueur2.Points = 0;

                GestionDonneesJeux.GestionJoueurs = new GestionJoueurs();
                GestionDonneesJeux.PaquetsDeCartes = new PaquetsDeCartes();
                var datasgame = new GestionDonneesJeux();
                await connexion.SendData(datasgame);
                //btnSuivantLanGame.Enabled = true;
            }
            else
            {
                MessageBox.Show("Merci de saisir votre pseudo!");
            }
        }

        private async void btnSuivantLanGame_Click(object sender, EventArgs e)
        {
            if (GestionCartes.FlagServer)
            {
                GestionJoueurs.Joueur2.Pseudo = GestionJoueurs.Joueur1.Pseudo;
                GestionJoueurs.Joueur1.Pseudo = tb1.Text;
            }
            else
            {
                await connexion.ReceiveData();
            }

            this.Close();
        }

    }
}
