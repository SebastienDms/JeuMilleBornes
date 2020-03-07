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
            this.btnCarteSuivante = new System.Windows.Forms.Button();
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
            this.pbCarte.Location = new System.Drawing.Point(285, 78);
            this.pbCarte.Name = "pbCarte";
            this.pbCarte.Size = new System.Drawing.Size(200, 283);
            this.pbCarte.TabIndex = 1;
            this.pbCarte.TabStop = false;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCreerPaquetDeJeu,
            this.msMelangerPaquet});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
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
            // btnCarteSuivante
            // 
            this.btnCarteSuivante.Location = new System.Drawing.Point(330, 376);
            this.btnCarteSuivante.Name = "btnCarteSuivante";
            this.btnCarteSuivante.Size = new System.Drawing.Size(109, 23);
            this.btnCarteSuivante.TabIndex = 3;
            this.btnCarteSuivante.Text = "Carte suivante";
            this.btnCarteSuivante.UseVisualStyleBackColor = true;
            this.btnCarteSuivante.Click += new System.EventHandler(this.btnCarteSuivante_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

