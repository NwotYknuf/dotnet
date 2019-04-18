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
            this.pBAjouterRetirer = new System.Windows.Forms.PictureBox();
            this.tBPersonnel = new System.Windows.Forms.TextBox();
            this.lPersonnel = new System.Windows.Forms.Label();
            this.tBHoraires = new System.Windows.Forms.TextBox();
            this.tBCours = new System.Windows.Forms.TextBox();
            this.lHoraires = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjouterRetirer)).BeginInit();
            this.SuspendLayout();
            // 
            // pBModifier
            // 
            this.pBModifier.Location = new System.Drawing.Point(897, 11);
            this.pBModifier.Click += new System.EventHandler(this.pBModifier_Click);
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Location = new System.Drawing.Point(899, 53);
            this.pBSupprimer.Click += new System.EventHandler(this.pBSupprimer_Click);
            // 
            // gBAffElement
            // 
            this.gBAffElement.Size = new System.Drawing.Size(951, 123);
            this.gBAffElement.Text = "Nom du cours";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tBPersonnel);
            this.panel.Controls.Add(this.lPersonnel);
            this.panel.Controls.Add(this.tBHoraires);
            this.panel.Controls.Add(this.tBCours);
            this.panel.Controls.Add(this.lHoraires);
            this.panel.Controls.Add(this.pBAjouterRetirer);
            this.panel.Controls.Add(this.lTypeCours);
            this.panel.Size = new System.Drawing.Size(938, 100);
            this.panel.Controls.SetChildIndex(this.lTypeCours, 0);
            this.panel.Controls.SetChildIndex(this.pBSupprimer, 0);
            this.panel.Controls.SetChildIndex(this.pBModifier, 0);
            this.panel.Controls.SetChildIndex(this.pBAjouterRetirer, 0);
            this.panel.Controls.SetChildIndex(this.lHoraires, 0);
            this.panel.Controls.SetChildIndex(this.tBCours, 0);
            this.panel.Controls.SetChildIndex(this.tBHoraires, 0);
            this.panel.Controls.SetChildIndex(this.lPersonnel, 0);
            this.panel.Controls.SetChildIndex(this.tBPersonnel, 0);
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
            // pBAjouterRetirer
            // 
            this.pBAjouterRetirer.Image = global::dotnet.Properties.Resources.ajouter_personnel;
            this.pBAjouterRetirer.InitialImage = null;
            this.pBAjouterRetirer.Location = new System.Drawing.Point(828, 26);
            this.pBAjouterRetirer.Name = "pBAjouterRetirer";
            this.pBAjouterRetirer.Size = new System.Drawing.Size(61, 48);
            this.pBAjouterRetirer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAjouterRetirer.TabIndex = 7;
            this.pBAjouterRetirer.TabStop = false;
            this.pBAjouterRetirer.Click += new System.EventHandler(this.pBAjouterRetirer_Click);
            this.pBAjouterRetirer.MouseEnter += new System.EventHandler(this.pBAjouterRetirer_MouseEnter);
            this.pBAjouterRetirer.MouseLeave += new System.EventHandler(this.pBAjouterRetirer_MouseLeave);
            // 
            // tBPersonnel
            // 
            this.tBPersonnel.Enabled = false;
            this.tBPersonnel.Location = new System.Drawing.Point(118, 60);
            this.tBPersonnel.Name = "tBPersonnel";
            this.tBPersonnel.Size = new System.Drawing.Size(100, 20);
            this.tBPersonnel.TabIndex = 22;
            // 
            // lPersonnel
            // 
            this.lPersonnel.AutoSize = true;
            this.lPersonnel.Location = new System.Drawing.Point(20, 64);
            this.lPersonnel.Name = "lPersonnel";
            this.lPersonnel.Size = new System.Drawing.Size(69, 13);
            this.lPersonnel.TabIndex = 21;
            this.lPersonnel.Text = "Enseignant : ";
            // 
            // tBHoraires
            // 
            this.tBHoraires.Enabled = false;
            this.tBHoraires.Location = new System.Drawing.Point(118, 36);
            this.tBHoraires.Name = "tBHoraires";
            this.tBHoraires.Size = new System.Drawing.Size(100, 20);
            this.tBHoraires.TabIndex = 20;
            // 
            // tBCours
            // 
            this.tBCours.Enabled = false;
            this.tBCours.Location = new System.Drawing.Point(118, 12);
            this.tBCours.Name = "tBCours";
            this.tBCours.Size = new System.Drawing.Size(100, 20);
            this.tBCours.TabIndex = 19;
            // 
            // lHoraires
            // 
            this.lHoraires.AutoSize = true;
            this.lHoraires.Location = new System.Drawing.Point(21, 39);
            this.lHoraires.Name = "lHoraires";
            this.lHoraires.Size = new System.Drawing.Size(91, 13);
            this.lHoraires.TabIndex = 18;
            this.lHoraires.Text = "Volume horaires : ";
            // 
            // UC_ElementCoursDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementCoursDiplome";
            this.Size = new System.Drawing.Size(955, 126);
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjouterRetirer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTypeCours;
        protected System.Windows.Forms.PictureBox pBAjouterRetirer;
        private System.Windows.Forms.TextBox tBPersonnel;
        private System.Windows.Forms.Label lPersonnel;
        private System.Windows.Forms.TextBox tBHoraires;
        private System.Windows.Forms.TextBox tBCours;
        private System.Windows.Forms.Label lHoraires;
    }
}
