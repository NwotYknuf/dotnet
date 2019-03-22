namespace dotnet.UserControler.Affichage
{
    partial class UC_ElementEC
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
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.lDescAnnee = new System.Windows.Forms.Label();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tBDesc);
            this.panel.Controls.Add(this.lDescAnnee);
            this.panel.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // tBDesc
            // 
            this.tBDesc.Enabled = false;
            this.tBDesc.Location = new System.Drawing.Point(99, 12);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(799, 20);
            this.tBDesc.TabIndex = 6;
            // 
            // lDescAnnee
            // 
            this.lDescAnnee.AutoSize = true;
            this.lDescAnnee.Location = new System.Drawing.Point(24, 15);
            this.lDescAnnee.Name = "lDescAnnee";
            this.lDescAnnee.Size = new System.Drawing.Size(69, 13);
            this.lDescAnnee.TabIndex = 5;
            this.lDescAnnee.Text = "Description : ";
            // 
            // UC_ElementEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementEC";
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.Label lDescAnnee;
    }
}
