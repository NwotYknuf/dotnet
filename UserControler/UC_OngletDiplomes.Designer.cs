namespace dotnet
{
    partial class UC_OngletDiplomes
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitre = new System.Windows.Forms.Label();
            this.filArianne1 = new dotnet.FilArianne();
            this.uC_Affichage1 = new dotnet.UC_Affichage();
            this.ucAccueil1 = new dotnet.UC_OngletAccueil();
            this.uC_Ajout1 = new dotnet.UC_Ajout();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(66, 23);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(68, 29);
            this.lTitre.TabIndex = 0;
            this.lTitre.Text = "Titre";
            // 
            // filArianne1
            // 
            this.filArianne1.Location = new System.Drawing.Point(71, 72);
            this.filArianne1.Name = "filArianne1";
            this.filArianne1.Size = new System.Drawing.Size(1068, 45);
            this.filArianne1.TabIndex = 13;
            // 
            // uC_Affichage1
            // 
            this.uC_Affichage1.Location = new System.Drawing.Point(67, 236);
            this.uC_Affichage1.Name = "uC_Affichage1";
            this.uC_Affichage1.Size = new System.Drawing.Size(982, 364);
            this.uC_Affichage1.TabIndex = 12;
            // 
            // ucAccueil1
            // 
            this.ucAccueil1.Location = new System.Drawing.Point(316, 214);
            this.ucAccueil1.Name = "ucAccueil1";
            this.ucAccueil1.Size = new System.Drawing.Size(40, 11);
            this.ucAccueil1.TabIndex = 11;
            // 
            // uC_Ajout1
            // 
            this.uC_Ajout1.Location = new System.Drawing.Point(71, 142);
            this.uC_Ajout1.Name = "uC_Ajout1";
            this.uC_Ajout1.Size = new System.Drawing.Size(982, 88);
            this.uC_Ajout1.TabIndex = 10;
            // 
            // UC_OngletDiplomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filArianne1);
            this.Controls.Add(this.uC_Affichage1);
            this.Controls.Add(this.ucAccueil1);
            this.Controls.Add(this.uC_Ajout1);
            this.Controls.Add(this.lTitre);
            this.Name = "UC_OngletDiplomes";
            this.Size = new System.Drawing.Size(1112, 682);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private UC_Ajout uC_Ajout1;
        private UC_OngletAccueil ucAccueil1;
        private UC_Affichage uC_Affichage1;
        private FilArianne filArianne1;
    }
}
