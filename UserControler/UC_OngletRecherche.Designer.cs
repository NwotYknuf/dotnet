namespace dotnet.UserControler
{
    partial class UC_OngletRecherche
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
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.bLancerRech = new System.Windows.Forms.Button();
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.lErreur = new System.Windows.Forms.Label();
            this.cBCritere = new System.Windows.Forms.ComboBox();
            this.lCritere = new System.Windows.Forms.Label();
            this.lMotClef = new System.Windows.Forms.Label();
            this.uC_Affichage1 = new dotnet.UserControler.Affichage.UC_Affichage();
            this.gbRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Heroes Legend", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(79)))), ((int)(((byte)(93)))));
            this.lTitre.Location = new System.Drawing.Point(66, 28);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(146, 36);
            this.lTitre.TabIndex = 11;
            this.lTitre.Text = "Recherche";
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(134, 29);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(163, 22);
            this.tbRecherche.TabIndex = 1;
            // 
            // bLancerRech
            // 
            this.bLancerRech.AutoSize = true;
            this.bLancerRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLancerRech.Location = new System.Drawing.Point(357, 39);
            this.bLancerRech.Name = "bLancerRech";
            this.bLancerRech.Size = new System.Drawing.Size(101, 26);
            this.bLancerRech.TabIndex = 3;
            this.bLancerRech.Text = "Lancer";
            this.bLancerRech.UseVisualStyleBackColor = true;
            this.bLancerRech.Click += new System.EventHandler(this.bLancerRech_Click);
            // 
            // gbRecherche
            // 
            this.gbRecherche.Controls.Add(this.lErreur);
            this.gbRecherche.Controls.Add(this.cBCritere);
            this.gbRecherche.Controls.Add(this.lCritere);
            this.gbRecherche.Controls.Add(this.lMotClef);
            this.gbRecherche.Controls.Add(this.tbRecherche);
            this.gbRecherche.Controls.Add(this.bLancerRech);
            this.gbRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecherche.Location = new System.Drawing.Point(71, 106);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Size = new System.Drawing.Size(464, 100);
            this.gbRecherche.TabIndex = 12;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Effectuer une recherche : ";
            // 
            // lErreur
            // 
            this.lErreur.AutoSize = true;
            this.lErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErreur.ForeColor = System.Drawing.Color.Red;
            this.lErreur.Location = new System.Drawing.Point(364, 71);
            this.lErreur.Name = "lErreur";
            this.lErreur.Size = new System.Drawing.Size(88, 13);
            this.lErreur.TabIndex = 7;
            this.lErreur.Text = "Erreur, réessayez";
            this.lErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lErreur.Visible = false;
            // 
            // cBCritere
            // 
            this.cBCritere.AutoCompleteCustomSource.AddRange(new string[] {
            "diplome",
            "annee",
            "periode",
            "ue",
            "ec",
            "cours",
            "personnel"});
            this.cBCritere.FormattingEnabled = true;
            this.cBCritere.ItemHeight = 16;
            this.cBCritere.Items.AddRange(new object[] {
            "diplome",
            "annee",
            "periode",
            "ue",
            "ec",
            "cours",
            "personnel"});
            this.cBCritere.Location = new System.Drawing.Point(176, 57);
            this.cBCritere.Name = "cBCritere";
            this.cBCritere.Size = new System.Drawing.Size(121, 24);
            this.cBCritere.TabIndex = 6;
            // 
            // lCritere
            // 
            this.lCritere.AutoSize = true;
            this.lCritere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCritere.Location = new System.Drawing.Point(17, 62);
            this.lCritere.Name = "lCritere";
            this.lCritere.Size = new System.Drawing.Size(153, 13);
            this.lCritere.TabIndex = 5;
            this.lCritere.Text = "Rechercher dans quel critère : ";
            // 
            // lMotClef
            // 
            this.lMotClef.AutoSize = true;
            this.lMotClef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMotClef.Location = new System.Drawing.Point(17, 34);
            this.lMotClef.Name = "lMotClef";
            this.lMotClef.Size = new System.Drawing.Size(111, 13);
            this.lMotClef.TabIndex = 4;
            this.lMotClef.Text = "Entrer votre mot-clef : ";
            // 
            // uC_Affichage1
            // 
            this.uC_Affichage1.Location = new System.Drawing.Point(66, 228);
            this.uC_Affichage1.Name = "uC_Affichage1";
            this.uC_Affichage1.Size = new System.Drawing.Size(980, 364);
            this.uC_Affichage1.TabIndex = 13;
            // 
            // UC_OngletRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_Affichage1);
            this.Controls.Add(this.lTitre);
            this.Controls.Add(this.gbRecherche);
            this.Name = "UC_OngletRecherche";
            this.Size = new System.Drawing.Size(1112, 682);
            this.Load += new System.EventHandler(this.UC_OngletRecherche_Load);
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.Button bLancerRech;
        private System.Windows.Forms.GroupBox gbRecherche;
        private System.Windows.Forms.ComboBox cBCritere;
        private System.Windows.Forms.Label lCritere;
        private System.Windows.Forms.Label lMotClef;
        private UserControler.Affichage.UC_Affichage uC_Affichage1;
        private System.Windows.Forms.Label lErreur;
    }
}
