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
            this.btnAccueilSuivant.Location = new System.Drawing.Point(319, 371);
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
            // FicAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}