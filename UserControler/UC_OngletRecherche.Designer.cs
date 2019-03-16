namespace dotnet
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
            this.bRechercher = new System.Windows.Forms.Button();
            this.gbResultats = new System.Windows.Forms.GroupBox();
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.gbRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(66, 23);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(139, 29);
            this.lTitre.TabIndex = 11;
            this.lTitre.Text = "Recherche";
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(6, 39);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(195, 22);
            this.tbRecherche.TabIndex = 3;
            // 
            // bRechercher
            // 
            this.bRechercher.AutoSize = true;
            this.bRechercher.Location = new System.Drawing.Point(211, 37);
            this.bRechercher.Name = "bRechercher";
            this.bRechercher.Size = new System.Drawing.Size(117, 26);
            this.bRechercher.TabIndex = 1;
            this.bRechercher.Text = "Rechercher";
            this.bRechercher.UseVisualStyleBackColor = true;
            // 
            // gbResultats
            // 
            this.gbResultats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultats.Location = new System.Drawing.Point(71, 196);
            this.gbResultats.Name = "gbResultats";
            this.gbResultats.Size = new System.Drawing.Size(975, 464);
            this.gbResultats.TabIndex = 17;
            this.gbResultats.TabStop = false;
            this.gbResultats.Text = "Résultats de la recherche : ";
            // 
            // gbRecherche
            // 
            this.gbRecherche.Controls.Add(this.tbRecherche);
            this.gbRecherche.Controls.Add(this.bRechercher);
            this.gbRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecherche.Location = new System.Drawing.Point(71, 76);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Size = new System.Drawing.Size(337, 100);
            this.gbRecherche.TabIndex = 12;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Entrer vos mots-clefs : ";
            // 
            // UCRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lTitre);
            this.Controls.Add(this.gbResultats);
            this.Controls.Add(this.gbRecherche);
            this.Name = "UCRecherche";
            this.Size = new System.Drawing.Size(1112, 682);
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.Button bRechercher;
        private System.Windows.Forms.GroupBox gbResultats;
        private System.Windows.Forms.GroupBox gbRecherche;
    }
}
