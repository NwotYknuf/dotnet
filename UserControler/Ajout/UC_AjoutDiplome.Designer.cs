namespace dotnet
{
    partial class UC_AjoutDiplome
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
            this.lDescription = new System.Windows.Forms.Label();
            this.rtBDesc = new System.Windows.Forms.RichTextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.gBTitreAjout.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTitre
            // 
            this.gBTitreAjout.Text = "Ajouter un diplôme : ";
            // 
            // bCreer
            // 
            this.bCreer.Text = "Créer un diplôme";
            this.bCreer.Click += new System.EventHandler(this.bCreer_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tBNom);
            this.panel.Controls.Add(this.lNom);
            this.panel.Controls.Add(this.lDescription);
            this.panel.Controls.Add(this.rtBDesc);
            this.panel.Controls.SetChildIndex(this.rtBDesc, 0);
            this.panel.Controls.SetChildIndex(this.lDescription, 0);
            this.panel.Controls.SetChildIndex(this.lNom, 0);
            this.panel.Controls.SetChildIndex(this.tBNom, 0);
            this.panel.Controls.SetChildIndex(this.bCreer, 0);
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(332, 20);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(69, 13);
            this.lDescription.TabIndex = 4;
            this.lDescription.Text = "Description : ";
            // 
            // rtBDesc
            // 
            this.rtBDesc.Location = new System.Drawing.Point(426, 1);
            this.rtBDesc.Name = "rtBDesc";
            this.rtBDesc.Size = new System.Drawing.Size(231, 47);
            this.rtBDesc.TabIndex = 3;
            this.rtBDesc.Text = "";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(17, 20);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(38, 13);
            this.lNom.TabIndex = 5;
            this.lNom.Text = "Nom : ";
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(104, 17);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(100, 20);
            this.tBNom.TabIndex = 6;
            // 
            // UC_AjoutDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_AjoutDiplome";
            this.gBTitreAjout.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.RichTextBox rtBDesc;
        private System.Windows.Forms.TextBox tBNom;
    }
}
