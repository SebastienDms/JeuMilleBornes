namespace JeuMilleBorne
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfoCarte = new System.Windows.Forms.Label();
            this.pbCarte = new System.Windows.Forms.PictureBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msCreerPaquetDeJeu = new System.Windows.Forms.ToolStripMenuItem();
            this.msMelangerPaquet = new System.Windows.Forms.ToolStripMenuItem();
            this.msDistribuerCartes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCarteSuivante = new System.Windows.Forms.Button();
            this.btnCarteSuivJ1 = new System.Windows.Forms.Button();
            this.btnCarteSuivJ2 = new System.Windows.Forms.Button();
            this.lblPaqMel = new System.Windows.Forms.Label();
            this.lblMainJ1 = new System.Windows.Forms.Label();
            this.lblMainJ2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarte)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoCarte
            // 
            this.lblInfoCarte.AutoSize = true;
            this.lblInfoCarte.Location = new System.Drawing.Point(327, 50);
            this.lblInfoCarte.Name = "lblInfoCarte";
            this.lblInfoCarte.Size = new System.Drawing.Size(112, 13);
            this.lblInfoCarte.TabIndex = 0;
            this.lblInfoCarte.Text = "Information de la carte";
            // 
            // pbCarte
            // 
            this.pbCarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCarte.Location = new System.Drawing.Point(0, 24);
            this.pbCarte.Name = "pbCarte";
            this.pbCarte.Size = new System.Drawing.Size(1635, 920);
            this.pbCarte.TabIndex = 1;
            this.pbCarte.TabStop = false;
            this.pbCarte.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCarte_Paint);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCreerPaquetDeJeu,
            this.msMelangerPaquet,
            this.msDistribuerCartes});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1635, 24);
            this.msMenu.TabIndex = 2;
            this.msMenu.Text = "Menu";
            // 
            // msCreerPaquetDeJeu
            // 
            this.msCreerPaquetDeJeu.Name = "msCreerPaquetDeJeu";
            this.msCreerPaquetDeJeu.Size = new System.Drawing.Size(122, 20);
            this.msCreerPaquetDeJeu.Text = "Créer Paquet de jeu";
            this.msCreerPaquetDeJeu.Click += new System.EventHandler(this.msCreerPaquetDeJeu_Click);
            // 
            // msMelangerPaquet
            // 
            this.msMelangerPaquet.Name = "msMelangerPaquet";
            this.msMelangerPaquet.Size = new System.Drawing.Size(121, 20);
            this.msMelangerPaquet.Text = "Mélanger le paquet";
            this.msMelangerPaquet.Click += new System.EventHandler(this.msMelangerPaquet_Click);
            // 
            // msDistribuerCartes
            // 
            this.msDistribuerCartes.AutoSize = false;
            this.msDistribuerCartes.Name = "msDistribuerCartes";
            this.msDistribuerCartes.Size = new System.Drawing.Size(136, 20);
            this.msDistribuerCartes.Text = "Distribution des cartes";
            this.msDistribuerCartes.Click += new System.EventHandler(this.msDistribuerCartes_Click);
            // 
            // btnCarteSuivante
            // 
            this.btnCarteSuivante.Location = new System.Drawing.Point(427, 0);
            this.btnCarteSuivante.Name = "btnCarteSuivante";
            this.btnCarteSuivante.Size = new System.Drawing.Size(109, 23);
            this.btnCarteSuivante.TabIndex = 3;
            this.btnCarteSuivante.Text = "Carte suivante";
            this.btnCarteSuivante.UseVisualStyleBackColor = true;
            this.btnCarteSuivante.Click += new System.EventHandler(this.btnCarteSuivante_Click);
            // 
            // btnCarteSuivJ1
            // 
            this.btnCarteSuivJ1.Location = new System.Drawing.Point(542, 0);
            this.btnCarteSuivJ1.Name = "btnCarteSuivJ1";
            this.btnCarteSuivJ1.Size = new System.Drawing.Size(133, 23);
            this.btnCarteSuivJ1.TabIndex = 4;
            this.btnCarteSuivJ1.Text = "Carte suivante Joueur 1";
            this.btnCarteSuivJ1.UseVisualStyleBackColor = true;
            this.btnCarteSuivJ1.Click += new System.EventHandler(this.btnCarteSuivJ1_Click);
            // 
            // btnCarteSuivJ2
            // 
            this.btnCarteSuivJ2.Location = new System.Drawing.Point(681, 0);
            this.btnCarteSuivJ2.Name = "btnCarteSuivJ2";
            this.btnCarteSuivJ2.Size = new System.Drawing.Size(146, 23);
            this.btnCarteSuivJ2.TabIndex = 5;
            this.btnCarteSuivJ2.Text = " Carte suivante Joueur 2";
            this.btnCarteSuivJ2.UseVisualStyleBackColor = true;
            this.btnCarteSuivJ2.Click += new System.EventHandler(this.btnCarteSuivJ2_Click);
            // 
            // lblPaqMel
            // 
            this.lblPaqMel.AutoSize = true;
            this.lblPaqMel.Location = new System.Drawing.Point(424, 35);
            this.lblPaqMel.Name = "lblPaqMel";
            this.lblPaqMel.Size = new System.Drawing.Size(43, 13);
            this.lblPaqMel.TabIndex = 6;
            this.lblPaqMel.Text = "PaqMel";
            // 
            // lblMainJ1
            // 
            this.lblMainJ1.AutoSize = true;
            this.lblMainJ1.Location = new System.Drawing.Point(539, 35);
            this.lblMainJ1.Name = "lblMainJ1";
            this.lblMainJ1.Size = new System.Drawing.Size(41, 13);
            this.lblMainJ1.TabIndex = 7;
            this.lblMainJ1.Text = "MainJ1";
            // 
            // lblMainJ2
            // 
            this.lblMainJ2.AutoSize = true;
            this.lblMainJ2.Location = new System.Drawing.Point(678, 35);
            this.lblMainJ2.Name = "lblMainJ2";
            this.lblMainJ2.Size = new System.Drawing.Size(41, 13);
            this.lblMainJ2.TabIndex = 8;
            this.lblMainJ2.Text = "MainJ2";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 944);
            this.Controls.Add(this.lblMainJ2);
            this.Controls.Add(this.lblMainJ1);
            this.Controls.Add(this.lblPaqMel);
            this.Controls.Add(this.btnCarteSuivJ2);
            this.Controls.Add(this.btnCarteSuivJ1);
            this.Controls.Add(this.btnCarteSuivante);
            this.Controls.Add(this.pbCarte);
            this.Controls.Add(this.lblInfoCarte);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "FormPrincipal";
            this.Text = "Plateau de jeu";
            ((System.ComponentModel.ISupportInitialize)(this.pbCarte)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoCarte;
        private System.Windows.Forms.PictureBox pbCarte;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msCreerPaquetDeJeu;
        private System.Windows.Forms.Button btnCarteSuivante;
        private System.Windows.Forms.ToolStripMenuItem msMelangerPaquet;
        private System.Windows.Forms.ToolStripMenuItem msDistribuerCartes;
        private System.Windows.Forms.Button btnCarteSuivJ1;
        private System.Windows.Forms.Button btnCarteSuivJ2;
        private System.Windows.Forms.Label lblPaqMel;
        private System.Windows.Forms.Label lblMainJ1;
        private System.Windows.Forms.Label lblMainJ2;
    }
}

