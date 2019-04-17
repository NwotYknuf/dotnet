namespace dotnet.UserControler.Ajout
{
    partial class UC_AjoutEC
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
            this.lDescription = new System.Windows.Forms.Label();
            this.rtBDesc = new System.Windows.Forms.RichTextBox();
            this.cB_ECActive = new System.Windows.Forms.CheckBox();
            this.lChampsObligatoires = new System.Windows.Forms.Label();
            this.gBTitreAjout.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTitreAjout
            // 
            this.gBTitreAjout.Size = new System.Drawing.Size(994, 93);
            this.gBTitreAjout.Text = "Ajouter une EC à cette UE : ";
            // 
            // bCreer
            // 
            this.bCreer.Location = new System.Drawing.Point(833, 15);
            this.bCreer.TabIndex = 4;
            this.bCreer.Text = "Créer une EC";
            this.bCreer.Click += new System.EventHandler(this.bCreer_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lChampsObligatoires);
            this.panel.Controls.Add(this.cB_ECActive);
            this.panel.Controls.Add(this.tBNom);
            this.panel.Controls.Add(this.lNom);
            this.panel.Controls.Add(this.lDescription);
            this.panel.Controls.Add(this.rtBDesc);
            this.panel.Size = new System.Drawing.Size(982, 67);
            this.panel.Controls.SetChildIndex(this.lErreur, 0);
            this.panel.Controls.SetChildIndex(this.bCreer, 0);
            this.panel.Controls.SetChildIndex(this.rtBDesc, 0);
            this.panel.Controls.SetChildIndex(this.lDescription, 0);
            this.panel.Controls.SetChildIndex(this.lNom, 0);
            this.panel.Controls.SetChildIndex(this.tBNom, 0);
            this.panel.Controls.SetChildIndex(this.cB_ECActive, 0);
            this.panel.Controls.SetChildIndex(this.lChampsObligatoires, 0);
            // 
            // lErreur
            // 
            this.lErreur.Location = new System.Drawing.Point(849, 43);
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(90, 19);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(100, 20);
            this.tBNom.TabIndex = 1;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(30, 22);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(45, 13);
            this.lNom.TabIndex = 17;
            this.lNom.Text = "Nom * : ";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(213, 22);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(76, 13);
            this.lDescription.TabIndex = 16;
            this.lDescription.Text = "Description * : ";
            // 
            // rtBDesc
            // 
            this.rtBDesc.Location = new System.Drawing.Point(304, 19);
            this.rtBDesc.Name = "rtBDesc";
            this.rtBDesc.Size = new System.Drawing.Size(402, 20);
            this.rtBDesc.TabIndex = 2;
            this.rtBDesc.Text = "";
            // 
            // cB_ECActive
            // 
            this.cB_ECActive.AutoSize = true;
            this.cB_ECActive.BackColor = System.Drawing.Color.Transparent;
            this.cB_ECActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cB_ECActive.Checked = true;
            this.cB_ECActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_ECActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB_ECActive.Location = new System.Drawing.Point(734, 20);
            this.cB_ECActive.Name = "cB_ECActive";
            this.cB_ECActive.Size = new System.Drawing.Size(69, 17);
            this.cB_ECActive.TabIndex = 3;
            this.cB_ECActive.Text = "Active * : ";
            this.cB_ECActive.UseVisualStyleBackColor = false;
            // 
            // lChampsObligatoires
            // 
            this.lChampsObligatoires.AutoSize = true;
            this.lChampsObligatoires.Location = new System.Drawing.Point(543, 47);
            this.lChampsObligatoires.Name = "lChampsObligatoires";
            this.lChampsObligatoires.Size = new System.Drawing.Size(268, 13);
            this.lChampsObligatoires.TabIndex = 37;
            this.lChampsObligatoires.Text = "Les champs suivis d\'une astérisque (*) sont obligatoires.";
            // 
            // UC_AjoutEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_AjoutEC";
            this.Size = new System.Drawing.Size(1000, 99);
            this.gBTitreAjout.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.RichTextBox rtBDesc;
        private System.Windows.Forms.CheckBox cB_ECActive;
        private System.Windows.Forms.Label lChampsObligatoires;
    }
}
