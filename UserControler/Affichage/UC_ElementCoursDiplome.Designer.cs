namespace dotnet.UserControler.Affichage
{
    partial class UC_ElementCoursDiplome
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
            this.lTypeCours = new System.Windows.Forms.Label();
            this.lHoraires = new System.Windows.Forms.Label();
            this.tBCours = new System.Windows.Forms.TextBox();
            this.tBHoraires = new System.Windows.Forms.TextBox();
            this.lPersonnel = new System.Windows.Forms.Label();
            this.tBPersonnel = new System.Windows.Forms.TextBox();
            this.bAjouterRetirer = new System.Windows.Forms.Button();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBAffElement
            // 
            this.gBAffElement.Size = new System.Drawing.Size(951, 123);
            this.gBAffElement.Text = "Nom du cours";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.bAjouterRetirer);
            this.panel.Controls.Add(this.tBPersonnel);
            this.panel.Controls.Add(this.lPersonnel);
            this.panel.Controls.Add(this.tBHoraires);
            this.panel.Controls.Add(this.tBCours);
            this.panel.Controls.Add(this.lHoraires);
            this.panel.Controls.Add(this.lTypeCours);
            this.panel.Size = new System.Drawing.Size(938, 100);
            // 
            // lTypeCours
            // 
            this.lTypeCours.AutoSize = true;
            this.lTypeCours.Location = new System.Drawing.Point(21, 15);
            this.lTypeCours.Name = "lTypeCours";
            this.lTypeCours.Size = new System.Drawing.Size(84, 13);
            this.lTypeCours.TabIndex = 0;
            this.lTypeCours.Text = "Type de cours : ";
            // 
            // lHoraires
            // 
            this.lHoraires.AutoSize = true;
            this.lHoraires.Location = new System.Drawing.Point(21, 39);
            this.lHoraires.Name = "lHoraires";
            this.lHoraires.Size = new System.Drawing.Size(135, 13);
            this.lHoraires.TabIndex = 1;
            this.lHoraires.Text = "Volume horaires du cours : ";
            // 
            // tBCours
            // 
            this.tBCours.Enabled = false;
            this.tBCours.Location = new System.Drawing.Point(111, 12);
            this.tBCours.Name = "tBCours";
            this.tBCours.Size = new System.Drawing.Size(100, 20);
            this.tBCours.TabIndex = 2;
            // 
            // tBHoraires
            // 
            this.tBHoraires.Enabled = false;
            this.tBHoraires.Location = new System.Drawing.Point(162, 36);
            this.tBHoraires.Name = "tBHoraires";
            this.tBHoraires.Size = new System.Drawing.Size(100, 20);
            this.tBHoraires.TabIndex = 3;
            // 
            // lPersonnel
            // 
            this.lPersonnel.AutoSize = true;
            this.lPersonnel.Location = new System.Drawing.Point(20, 64);
            this.lPersonnel.Name = "lPersonnel";
            this.lPersonnel.Size = new System.Drawing.Size(118, 13);
            this.lPersonnel.TabIndex = 4;
            this.lPersonnel.Text = "Personnel enseignant : ";
            // 
            // tBPersonnel
            // 
            this.tBPersonnel.Enabled = false;
            this.tBPersonnel.Location = new System.Drawing.Point(144, 60);
            this.tBPersonnel.Name = "tBPersonnel";
            this.tBPersonnel.Size = new System.Drawing.Size(100, 20);
            this.tBPersonnel.TabIndex = 5;
            // 
            // bAjouterRetirer
            // 
            this.bAjouterRetirer.Location = new System.Drawing.Point(807, 39);
            this.bAjouterRetirer.Name = "bAjouterRetirer";
            this.bAjouterRetirer.Size = new System.Drawing.Size(128, 23);
            this.bAjouterRetirer.TabIndex = 6;
            this.bAjouterRetirer.Text = "Ajouter-Retirer";
            this.bAjouterRetirer.UseVisualStyleBackColor = true;
            this.bAjouterRetirer.Click += new System.EventHandler(this.bAjouterRetirer_Click);
            // 
            // UC_ElementCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementCours";
            this.Size = new System.Drawing.Size(955, 126);
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTypeCours;
        private System.Windows.Forms.TextBox tBHoraires;
        private System.Windows.Forms.TextBox tBCours;
        private System.Windows.Forms.Label lHoraires;
        private System.Windows.Forms.TextBox tBPersonnel;
        private System.Windows.Forms.Label lPersonnel;
        private System.Windows.Forms.Button bAjouterRetirer;
    }
}
