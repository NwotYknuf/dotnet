namespace dotnet
{
    partial class UC_ElementDiplome
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
            this.lNomDiplome = new System.Windows.Forms.Label();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBAffElement
            // 
            this.gBAffElement.Text = "TitreElementDiplôme";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lNomDiplome);
            this.panel.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lNomDiplome
            // 
            this.lNomDiplome.AutoSize = true;
            this.lNomDiplome.Location = new System.Drawing.Point(23, 13);
            this.lNomDiplome.Name = "lNomDiplome";
            this.lNomDiplome.Size = new System.Drawing.Size(67, 13);
            this.lNomDiplome.TabIndex = 0;
            this.lNomDiplome.Text = "NomDiplôme";
            // 
            // UC_ElementDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementDiplome";
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lNomDiplome;
    }
}
