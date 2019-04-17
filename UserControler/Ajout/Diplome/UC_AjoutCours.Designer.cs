namespace dotnet.UserControler.Ajout
{
    partial class UC_AjoutCours
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
            this.tBNom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.lTypeCours = new System.Windows.Forms.Label();
            this.cBType = new System.Windows.Forms.ComboBox();
            this.lHoraires = new System.Windows.Forms.Label();
            this.tBHoraires = new System.Windows.Forms.TextBox();
            this.lChampsObligatoires = new System.Windows.Forms.Label();
            this.gBTitreAjout.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTitreAjout
            // 
            this.gBTitreAjout.Size = new System.Drawing.Size(994, 93);
            this.gBTitreAjout.Text = "Ajouter un cours : ";
            // 
            // bCreer
            // 
            this.bCreer.Location = new System.Drawing.Point(833, 15);
            this.bCreer.TabIndex = 4;
            this.bCreer.Text = "Créer un cours";
            this.bCreer.Click += new System.EventHandler(this.bCreer_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lChampsObligatoires);
            this.panel.Controls.Add(this.tBHoraires);
            this.panel.Controls.Add(this.lHoraires);
            this.panel.Controls.Add(this.cBType);
            this.panel.Controls.Add(this.tBNom);
            this.panel.Controls.Add(this.lNom);
            this.panel.Controls.Add(this.lTypeCours);
            this.panel.Size = new System.Drawing.Size(982, 67);
            this.panel.Controls.SetChildIndex(this.lErreur, 0);
            this.panel.Controls.SetChildIndex(this.lTypeCours, 0);
            this.panel.Controls.SetChildIndex(this.lNom, 0);
            this.panel.Controls.SetChildIndex(this.bCreer, 0);
            this.panel.Controls.SetChildIndex(this.tBNom, 0);
            this.panel.Controls.SetChildIndex(this.cBType, 0);
            this.panel.Controls.SetChildIndex(this.lHoraires, 0);
            this.panel.Controls.SetChildIndex(this.tBHoraires, 0);
            this.panel.Controls.SetChildIndex(this.lChampsObligatoires, 0);
            // 
            // lErreur
            // 
            this.lErreur.Location = new System.Drawing.Point(849, 43);
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(63, 19);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(100, 20);
            this.tBNom.TabIndex = 1;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(17, 22);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(45, 13);
            this.lNom.TabIndex = 17;
            this.lNom.Text = "Nom * : ";
            // 
            // lTypeCours
            // 
            this.lTypeCours.AutoSize = true;
            this.lTypeCours.Location = new System.Drawing.Point(254, 22);
            this.lTypeCours.Name = "lTypeCours";
            this.lTypeCours.Size = new System.Drawing.Size(91, 13);
            this.lTypeCours.TabIndex = 16;
            this.lTypeCours.Text = "Type de cours * : ";
            // 
            // cBType
            // 
            this.cBType.FormattingEnabled = true;
            this.cBType.Location = new System.Drawing.Point(344, 18);
            this.cBType.Name = "cBType";
            this.cBType.Size = new System.Drawing.Size(121, 21);
            this.cBType.TabIndex = 2;
            // 
            // lHoraires
            // 
            this.lHoraires.AutoSize = true;
            this.lHoraires.Location = new System.Drawing.Point(563, 22);
            this.lHoraires.Name = "lHoraires";
            this.lHoraires.Size = new System.Drawing.Size(93, 13);
            this.lHoraires.TabIndex = 20;
            this.lHoraires.Text = "Volume horaire * : ";
            // 
            // tBHoraires
            // 
            this.tBHoraires.Location = new System.Drawing.Point(655, 19);
            this.tBHoraires.Name = "tBHoraires";
            this.tBHoraires.Size = new System.Drawing.Size(100, 20);
            this.tBHoraires.TabIndex = 3;
            // 
            // lChampsObligatoires
            // 
            this.lChampsObligatoires.AutoSize = true;
            this.lChampsObligatoires.Location = new System.Drawing.Point(543, 47);
            this.lChampsObligatoires.Name = "lChampsObligatoires";
            this.lChampsObligatoires.Size = new System.Drawing.Size(268, 13);
            this.lChampsObligatoires.TabIndex = 35;
            this.lChampsObligatoires.Text = "Les champs suivis d\'une astérisque (*) sont obligatoires.";
            // 
            // UC_AjoutCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_AjoutCours";
            this.Size = new System.Drawing.Size(1000, 99);
            this.Load += new System.EventHandler(this.UC_AjoutCours_Load);
            this.gBTitreAjout.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lTypeCours;
        private System.Windows.Forms.TextBox tBHoraires;
        private System.Windows.Forms.Label lHoraires;
        private System.Windows.Forms.ComboBox cBType;
        private System.Windows.Forms.Label lChampsObligatoires;
    }
}
