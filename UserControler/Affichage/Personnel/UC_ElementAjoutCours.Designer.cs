namespace dotnet.UserControler.Affichage.Personnel
{
    partial class UC_ElementAjoutCours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ElementAjoutCours));
            this.pBAjouterCours = new System.Windows.Forms.PictureBox();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjouterCours)).BeginInit();
            this.SuspendLayout();
            // 
            // gBAffElement
            // 
            this.gBAffElement.Size = new System.Drawing.Size(951, 78);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pBAjouterCours);
            this.panel.Size = new System.Drawing.Size(938, 55);
            this.panel.Controls.SetChildIndex(this.pBSupprimer, 0);
            this.panel.Controls.SetChildIndex(this.pBModifier, 0);
            this.panel.Controls.SetChildIndex(this.pBAjouterCours, 0);
            // 
            // pBModifier
            // 
            this.pBModifier.Location = new System.Drawing.Point(857, 9);
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Location = new System.Drawing.Point(900, 9);
            // 
            // pBAjouterCours
            // 
            this.pBAjouterCours.Image = ((System.Drawing.Image)(resources.GetObject("pBAjouterCours.Image")));
            this.pBAjouterCours.InitialImage = null;
            this.pBAjouterCours.Location = new System.Drawing.Point(431, 3);
            this.pBAjouterCours.Name = "pBAjouterCours";
            this.pBAjouterCours.Size = new System.Drawing.Size(59, 46);
            this.pBAjouterCours.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAjouterCours.TabIndex = 52;
            this.pBAjouterCours.TabStop = false;
            this.pBAjouterCours.Click += new System.EventHandler(this.pBAjouterCours_Click);
            // 
            // UC_ElementAjoutCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementAjoutCours";
            this.Size = new System.Drawing.Size(955, 81);
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjouterCours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox pBAjouterCours;
    }
}
