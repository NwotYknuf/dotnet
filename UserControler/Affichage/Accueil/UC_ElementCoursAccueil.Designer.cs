namespace dotnet.UserControler.Affichage.Accueil
{
    partial class UC_ElementCoursAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ElementCoursAccueil));
            this.tBPersonnel = new System.Windows.Forms.TextBox();
            this.lPersonnel = new System.Windows.Forms.Label();
            this.tBHoraires = new System.Windows.Forms.TextBox();
            this.tBCours = new System.Windows.Forms.TextBox();
            this.lHoraires = new System.Windows.Forms.Label();
            this.lTypeCours = new System.Windows.Forms.Label();
            this.pBAjouterRetirer = new System.Windows.Forms.PictureBox();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjouterRetirer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pBAjouterRetirer);
            this.panel.Controls.Add(this.tBPersonnel);
            this.panel.Controls.Add(this.lPersonnel);
            this.panel.Controls.Add(this.tBHoraires);
            this.panel.Controls.Add(this.tBCours);
            this.panel.Controls.Add(this.lHoraires);
            this.panel.Controls.Add(this.lTypeCours);
            this.panel.Controls.SetChildIndex(this.pBSupprimer, 0);
            this.panel.Controls.SetChildIndex(this.pBModifier, 0);
            this.panel.Controls.SetChildIndex(this.lTypeCours, 0);
            this.panel.Controls.SetChildIndex(this.lHoraires, 0);
            this.panel.Controls.SetChildIndex(this.tBCours, 0);
            this.panel.Controls.SetChildIndex(this.tBHoraires, 0);
            this.panel.Controls.SetChildIndex(this.lPersonnel, 0);
            this.panel.Controls.SetChildIndex(this.tBPersonnel, 0);
            this.panel.Controls.SetChildIndex(this.pBAjouterRetirer, 0);
            // 
            // pBModifier
            // 
            this.pBModifier.Location = new System.Drawing.Point(453, 6);
            this.pBModifier.Click += new System.EventHandler(this.pBModifier_Click);
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Location = new System.Drawing.Point(454, 49);
            this.pBSupprimer.Click += new System.EventHandler(this.pBSupprimer_Click);
            // 
            // tBPersonnel
            // 
            this.tBPersonnel.Enabled = false;
            this.tBPersonnel.Location = new System.Drawing.Point(123, 58);
            this.tBPersonnel.Name = "tBPersonnel";
            this.tBPersonnel.Size = new System.Drawing.Size(100, 20);
            this.tBPersonnel.TabIndex = 17;
            // 
            // lPersonnel
            // 
            this.lPersonnel.AutoSize = true;
            this.lPersonnel.Location = new System.Drawing.Point(25, 62);
            this.lPersonnel.Name = "lPersonnel";
            this.lPersonnel.Size = new System.Drawing.Size(69, 13);
            this.lPersonnel.TabIndex = 16;
            this.lPersonnel.Text = "Enseignant : ";
            // 
            // tBHoraires
            // 
            this.tBHoraires.Enabled = false;
            this.tBHoraires.Location = new System.Drawing.Point(123, 34);
            this.tBHoraires.Name = "tBHoraires";
            this.tBHoraires.Size = new System.Drawing.Size(100, 20);
            this.tBHoraires.TabIndex = 15;
            // 
            // tBCours
            // 
            this.tBCours.Enabled = false;
            this.tBCours.Location = new System.Drawing.Point(123, 10);
            this.tBCours.Name = "tBCours";
            this.tBCours.Size = new System.Drawing.Size(100, 20);
            this.tBCours.TabIndex = 14;
            // 
            // lHoraires
            // 
            this.lHoraires.AutoSize = true;
            this.lHoraires.Location = new System.Drawing.Point(26, 37);
            this.lHoraires.Name = "lHoraires";
            this.lHoraires.Size = new System.Drawing.Size(91, 13);
            this.lHoraires.TabIndex = 13;
            this.lHoraires.Text = "Volume horaires : ";
            // 
            // lTypeCours
            // 
            this.lTypeCours.AutoSize = true;
            this.lTypeCours.Location = new System.Drawing.Point(26, 13);
            this.lTypeCours.Name = "lTypeCours";
            this.lTypeCours.Size = new System.Drawing.Size(84, 13);
            this.lTypeCours.TabIndex = 12;
            this.lTypeCours.Text = "Type de cours : ";
            // 
            // pBAjouterRetirer
            // 
            this.pBAjouterRetirer.Image = ((System.Drawing.Image)(resources.GetObject("pBAjouterRetirer.Image")));
            this.pBAjouterRetirer.InitialImage = null;
            this.pBAjouterRetirer.Location = new System.Drawing.Point(378, 20);
            this.pBAjouterRetirer.Name = "pBAjouterRetirer";
            this.pBAjouterRetirer.Size = new System.Drawing.Size(61, 48);
            this.pBAjouterRetirer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAjouterRetirer.TabIndex = 18;
            this.pBAjouterRetirer.TabStop = false;
            this.pBAjouterRetirer.Click += new System.EventHandler(this.pBAjouterRetirer_Click);
            // 
            // UC_ElementCoursAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementCoursAccueil";
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjouterRetirer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBPersonnel;
        private System.Windows.Forms.Label lPersonnel;
        private System.Windows.Forms.TextBox tBHoraires;
        private System.Windows.Forms.TextBox tBCours;
        private System.Windows.Forms.Label lHoraires;
        private System.Windows.Forms.Label lTypeCours;
        protected System.Windows.Forms.PictureBox pBAjouterRetirer;
    }
}
