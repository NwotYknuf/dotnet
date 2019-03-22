namespace dotnet.UserControler.Affichage
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
            this.lDescDiplome = new System.Windows.Forms.Label();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBAffElement
            // 
            this.gBAffElement.Text = "Nom du diplôme";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tBDesc);
            this.panel.Controls.Add(this.lDescDiplome);
            this.panel.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // lDescDiplome
            // 
            this.lDescDiplome.AutoSize = true;
            this.lDescDiplome.Location = new System.Drawing.Point(24, 15);
            this.lDescDiplome.Name = "lDescDiplome";
            this.lDescDiplome.Size = new System.Drawing.Size(69, 13);
            this.lDescDiplome.TabIndex = 0;
            this.lDescDiplome.Text = "Description : ";
            // 
            // tBDesc
            // 
            this.tBDesc.Enabled = false;
            this.tBDesc.Location = new System.Drawing.Point(99, 12);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(799, 20);
            this.tBDesc.TabIndex = 3;
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

        private System.Windows.Forms.Label lDescDiplome;
        private System.Windows.Forms.TextBox tBDesc;
    }
}
