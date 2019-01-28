namespace dotnet
{
    partial class UCAccueil
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
            this.lBienvenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBienvenu
            // 
            this.lBienvenu.AutoSize = true;
            this.lBienvenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBienvenu.Location = new System.Drawing.Point(361, 324);
            this.lBienvenu.Name = "lBienvenu";
            this.lBienvenu.Size = new System.Drawing.Size(382, 24);
            this.lBienvenu.TabIndex = 0;
            this.lBienvenu.Text = "Bienvenu dans notre application de gestion !";
            // 
            // UCAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lBienvenu);
            this.Name = "UCAccueil";
            this.Size = new System.Drawing.Size(1112, 682);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBienvenu;
    }
}
