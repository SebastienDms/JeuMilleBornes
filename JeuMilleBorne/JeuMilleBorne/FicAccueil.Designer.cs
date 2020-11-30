namespace JeuMilleBorne
{
    partial class FicAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicAccueil));
            this.lblAccueilBienvenue = new System.Windows.Forms.Label();
            this.btnAccueilSuivant = new System.Windows.Forms.Button();
            this.lblAccueilJeu = new System.Windows.Forms.Label();
            this.lblAccueilJoueur1 = new System.Windows.Forms.Label();
            this.tbAccueilJ1Pseudo = new System.Windows.Forms.TextBox();
            this.tbAccueilJ2Pseudo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChargerPartie = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lblPseudoJoueur = new System.Windows.Forms.Label();
            this.btnCreerServer = new System.Windows.Forms.Button();
            this.lblPartieLocale = new System.Windows.Forms.Label();
            this.lblPartieReseau = new System.Windows.Forms.Label();
            this.lblChoixServer = new System.Windows.Forms.Label();
            this.cbServers = new System.Windows.Forms.ComboBox();
            this.btnLoadServers = new System.Windows.Forms.Button();
            this.btnCreerClient = new System.Windows.Forms.Button();
            this.btnSuivantLanGame = new System.Windows.Forms.Button();
            this.btnEnvoyerPseudo = new System.Windows.Forms.Button();
            this.gbJouer = new System.Windows.Forms.GroupBox();
            this.gbJoueurClient = new System.Windows.Forms.GroupBox();
            this.gbJouer.SuspendLayout();
            this.gbJoueurClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccueilBienvenue
            // 
            this.lblAccueilBienvenue.AutoSize = true;
            this.lblAccueilBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilBienvenue.Location = new System.Drawing.Point(291, 32);
            this.lblAccueilBienvenue.Name = "lblAccueilBienvenue";
            this.lblAccueilBienvenue.Size = new System.Drawing.Size(204, 26);
            this.lblAccueilBienvenue.TabIndex = 0;
            this.lblAccueilBienvenue.Text = "Bienvenue joueurs !";
            // 
            // btnAccueilSuivant
            // 
            this.btnAccueilSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueilSuivant.Location = new System.Drawing.Point(50, 373);
            this.btnAccueilSuivant.Name = "btnAccueilSuivant";
            this.btnAccueilSuivant.Size = new System.Drawing.Size(148, 34);
            this.btnAccueilSuivant.TabIndex = 1;
            this.btnAccueilSuivant.Text = "S U I V A N T";
            this.btnAccueilSuivant.UseVisualStyleBackColor = true;
            this.btnAccueilSuivant.Click += new System.EventHandler(this.btnAccueilSuivant_Click);
            // 
            // lblAccueilJeu
            // 
            this.lblAccueilJeu.AutoSize = true;
            this.lblAccueilJeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilJeu.Location = new System.Drawing.Point(214, 74);
            this.lblAccueilJeu.Name = "lblAccueilJeu";
            this.lblAccueilJeu.Size = new System.Drawing.Size(382, 26);
            this.lblAccueilJeu.TabIndex = 2;
            this.lblAccueilJeu.Text = "Prêts pour une partie de 1000 bornes !";
            // 
            // lblAccueilJoueur1
            // 
            this.lblAccueilJoueur1.AutoSize = true;
            this.lblAccueilJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilJoueur1.Location = new System.Drawing.Point(70, 199);
            this.lblAccueilJoueur1.Name = "lblAccueilJoueur1";
            this.lblAccueilJoueur1.Size = new System.Drawing.Size(154, 20);
            this.lblAccueilJoueur1.TabIndex = 3;
            this.lblAccueilJoueur1.Text = "Pseudo du joueur 1 :";
            // 
            // tbAccueilJ1Pseudo
            // 
            this.tbAccueilJ1Pseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccueilJ1Pseudo.Location = new System.Drawing.Point(230, 196);
            this.tbAccueilJ1Pseudo.Name = "tbAccueilJ1Pseudo";
            this.tbAccueilJ1Pseudo.Size = new System.Drawing.Size(128, 26);
            this.tbAccueilJ1Pseudo.TabIndex = 4;
            // 
            // tbAccueilJ2Pseudo
            // 
            this.tbAccueilJ2Pseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccueilJ2Pseudo.Location = new System.Drawing.Point(230, 259);
            this.tbAccueilJ2Pseudo.Name = "tbAccueilJ2Pseudo";
            this.tbAccueilJ2Pseudo.Size = new System.Drawing.Size(128, 26);
            this.tbAccueilJ2Pseudo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pseudo du joueur 2 :";
            // 
            // btnChargerPartie
            // 
            this.btnChargerPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargerPartie.Location = new System.Drawing.Point(230, 358);
            this.btnChargerPartie.Name = "btnChargerPartie";
            this.btnChargerPartie.Size = new System.Drawing.Size(148, 65);
            this.btnChargerPartie.TabIndex = 7;
            this.btnChargerPartie.Text = "C H A R G E R  P A R T I E";
            this.btnChargerPartie.UseVisualStyleBackColor = true;
            this.btnChargerPartie.Click += new System.EventHandler(this.btnChargerPartie_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(589, 187);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(148, 26);
            this.tb1.TabIndex = 9;
            // 
            // lblPseudoJoueur
            // 
            this.lblPseudoJoueur.AutoSize = true;
            this.lblPseudoJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudoJoueur.Location = new System.Drawing.Point(442, 190);
            this.lblPseudoJoueur.Name = "lblPseudoJoueur";
            this.lblPseudoJoueur.Size = new System.Drawing.Size(141, 20);
            this.lblPseudoJoueur.TabIndex = 8;
            this.lblPseudoJoueur.Text = "Pseudo du joueur :";
            // 
            // btnCreerServer
            // 
            this.btnCreerServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerServer.Location = new System.Drawing.Point(446, 230);
            this.btnCreerServer.Name = "btnCreerServer";
            this.btnCreerServer.Size = new System.Drawing.Size(342, 34);
            this.btnCreerServer.TabIndex = 10;
            this.btnCreerServer.Text = "Connexion Joueur/Serveur";
            this.btnCreerServer.UseVisualStyleBackColor = true;
            this.btnCreerServer.Click += new System.EventHandler(this.btnCreerServer_Click);
            // 
            // lblPartieLocale
            // 
            this.lblPartieLocale.AutoSize = true;
            this.lblPartieLocale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartieLocale.Location = new System.Drawing.Point(146, 142);
            this.lblPartieLocale.Name = "lblPartieLocale";
            this.lblPartieLocale.Size = new System.Drawing.Size(116, 20);
            this.lblPartieLocale.TabIndex = 11;
            this.lblPartieLocale.Text = "Partie en local :";
            // 
            // lblPartieReseau
            // 
            this.lblPartieReseau.AutoSize = true;
            this.lblPartieReseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartieReseau.Location = new System.Drawing.Point(525, 142);
            this.lblPartieReseau.Name = "lblPartieReseau";
            this.lblPartieReseau.Size = new System.Drawing.Size(142, 20);
            this.lblPartieReseau.TabIndex = 12;
            this.lblPartieReseau.Text = "Partien en réseau :";
            // 
            // lblChoixServer
            // 
            this.lblChoixServer.AutoSize = true;
            this.lblChoixServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixServer.Location = new System.Drawing.Point(5, 64);
            this.lblChoixServer.Name = "lblChoixServer";
            this.lblChoixServer.Size = new System.Drawing.Size(134, 20);
            this.lblChoixServer.TabIndex = 13;
            this.lblChoixServer.Text = "Choix du serveur :";
            // 
            // cbServers
            // 
            this.cbServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(145, 59);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(193, 28);
            this.cbServers.TabIndex = 14;
            // 
            // btnLoadServers
            // 
            this.btnLoadServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadServers.Location = new System.Drawing.Point(75, 19);
            this.btnLoadServers.Name = "btnLoadServers";
            this.btnLoadServers.Size = new System.Drawing.Size(219, 34);
            this.btnLoadServers.TabIndex = 15;
            this.btnLoadServers.Text = "C H A R G E R";
            this.btnLoadServers.UseVisualStyleBackColor = true;
            this.btnLoadServers.Click += new System.EventHandler(this.btnLoadServers_Click);
            // 
            // btnCreerClient
            // 
            this.btnCreerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerClient.Location = new System.Drawing.Point(9, 99);
            this.btnCreerClient.Name = "btnCreerClient";
            this.btnCreerClient.Size = new System.Drawing.Size(329, 34);
            this.btnCreerClient.TabIndex = 16;
            this.btnCreerClient.Text = "Connexion Joueur/Client";
            this.btnCreerClient.UseVisualStyleBackColor = true;
            this.btnCreerClient.Click += new System.EventHandler(this.btnCreerClient_Click);
            // 
            // btnSuivantLanGame
            // 
            this.btnSuivantLanGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivantLanGame.Location = new System.Drawing.Point(174, 19);
            this.btnSuivantLanGame.Name = "btnSuivantLanGame";
            this.btnSuivantLanGame.Size = new System.Drawing.Size(156, 34);
            this.btnSuivantLanGame.TabIndex = 17;
            this.btnSuivantLanGame.Text = "Lancer la partie";
            this.btnSuivantLanGame.UseVisualStyleBackColor = true;
            this.btnSuivantLanGame.Click += new System.EventHandler(this.btnSuivantLanGame_Click);
            // 
            // btnEnvoyerPseudo
            // 
            this.btnEnvoyerPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyerPseudo.Location = new System.Drawing.Point(6, 19);
            this.btnEnvoyerPseudo.Name = "btnEnvoyerPseudo";
            this.btnEnvoyerPseudo.Size = new System.Drawing.Size(162, 34);
            this.btnEnvoyerPseudo.TabIndex = 18;
            this.btnEnvoyerPseudo.Text = "Envoyer pseudo";
            this.btnEnvoyerPseudo.UseVisualStyleBackColor = true;
            this.btnEnvoyerPseudo.Click += new System.EventHandler(this.btnEnvoyerPseudo_Click);
            // 
            // gbJouer
            // 
            this.gbJouer.Controls.Add(this.btnEnvoyerPseudo);
            this.gbJouer.Controls.Add(this.btnSuivantLanGame);
            this.gbJouer.Location = new System.Drawing.Point(446, 418);
            this.gbJouer.Name = "gbJouer";
            this.gbJouer.Size = new System.Drawing.Size(345, 67);
            this.gbJouer.TabIndex = 20;
            this.gbJouer.TabStop = false;
            this.gbJouer.Text = "Jouer :";
            // 
            // gbJoueurClient
            // 
            this.gbJoueurClient.Controls.Add(this.btnLoadServers);
            this.gbJoueurClient.Controls.Add(this.lblChoixServer);
            this.gbJoueurClient.Controls.Add(this.btnCreerClient);
            this.gbJoueurClient.Controls.Add(this.cbServers);
            this.gbJoueurClient.Location = new System.Drawing.Point(446, 270);
            this.gbJoueurClient.Name = "gbJoueurClient";
            this.gbJoueurClient.Size = new System.Drawing.Size(345, 142);
            this.gbJoueurClient.TabIndex = 21;
            this.gbJoueurClient.TabStop = false;
            this.gbJoueurClient.Text = "Paramètres client :";
            // 
            // FicAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.gbJoueurClient);
            this.Controls.Add(this.gbJouer);
            this.Controls.Add(this.lblPartieReseau);
            this.Controls.Add(this.lblPartieLocale);
            this.Controls.Add(this.btnCreerServer);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lblPseudoJoueur);
            this.Controls.Add(this.btnChargerPartie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAccueilJ2Pseudo);
            this.Controls.Add(this.tbAccueilJ1Pseudo);
            this.Controls.Add(this.lblAccueilJoueur1);
            this.Controls.Add(this.lblAccueilJeu);
            this.Controls.Add(this.btnAccueilSuivant);
            this.Controls.Add(this.lblAccueilBienvenue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FicAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FicAccueil";
            this.Load += new System.EventHandler(this.FicAccueil_Load);
            this.gbJouer.ResumeLayout(false);
            this.gbJoueurClient.ResumeLayout(false);
            this.gbJoueurClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccueilBienvenue;
        private System.Windows.Forms.Button btnAccueilSuivant;
        private System.Windows.Forms.Label lblAccueilJeu;
        private System.Windows.Forms.Label lblAccueilJoueur1;
        private System.Windows.Forms.TextBox tbAccueilJ1Pseudo;
        private System.Windows.Forms.TextBox tbAccueilJ2Pseudo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChargerPartie;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label lblPseudoJoueur;
        private System.Windows.Forms.Button btnCreerServer;
        private System.Windows.Forms.Label lblPartieLocale;
        private System.Windows.Forms.Label lblPartieReseau;
        private System.Windows.Forms.Label lblChoixServer;
        private System.Windows.Forms.ComboBox cbServers;
        private System.Windows.Forms.Button btnLoadServers;
        private System.Windows.Forms.Button btnCreerClient;
        private System.Windows.Forms.Button btnSuivantLanGame;
        private System.Windows.Forms.Button btnEnvoyerPseudo;
        private System.Windows.Forms.GroupBox gbJouer;
        private System.Windows.Forms.GroupBox gbJoueurClient;
    }
}