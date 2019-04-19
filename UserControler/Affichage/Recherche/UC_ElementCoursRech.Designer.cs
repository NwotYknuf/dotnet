namespace dotnet.UserControler.Affichage.Recherche
{
    partial class UC_ElementCoursRech
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
            this.tBEC = new System.Windows.Forms.TextBox();
            this.lEC = new System.Windows.Forms.Label();
            this.tBHoraires = new System.Windows.Forms.TextBox();
            this.tBCours = new System.Windows.Forms.TextBox();
            this.lHoraires = new System.Windows.Forms.Label();
            this.lTypeCours = new System.Windows.Forms.Label();
            this.tBPersonnel = new System.Windows.Forms.TextBox();
            this.lPersonnel = new System.Windows.Forms.Label();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tBPersonnel);
            this.panel.Controls.Add(this.lPersonnel);
            this.panel.Controls.Add(this.tBEC);
            this.panel.Controls.Add(this.lEC);
            this.panel.Controls.Add(this.tBHoraires);
            this.panel.Controls.Add(this.tBCours);
            this.panel.Controls.Add(this.lHoraires);
            this.panel.Controls.Add(this.lTypeCours);
            this.panel.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            this.panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            this.panel.MouseHover += new System.EventHandler(this.panel_MouseHover);
            // 
            // tBEC
            // 
            this.tBEC.Enabled = false;
            this.tBEC.Location = new System.Drawing.Point(444, 35);
            this.tBEC.Name = "tBEC";
            this.tBEC.Size = new System.Drawing.Size(170, 20);
            this.tBEC.TabIndex = 18;
            // 
            // lEC
            // 
            this.lEC.AutoSize = true;
            this.lEC.Location = new System.Drawing.Point(315, 38);
            this.lEC.Name = "lEC";
            this.lEC.Size = new System.Drawing.Size(125, 13);
            this.lEC.TabIndex = 17;
            this.lEC.Text = "Élément constitutif (EC) : ";
            // 
            // tBHoraires
            // 
            this.tBHoraires.Enabled = false;
            this.tBHoraires.Location = new System.Drawing.Point(116, 35);
            this.tBHoraires.Name = "tBHoraires";
            this.tBHoraires.Size = new System.Drawing.Size(170, 20);
            this.tBHoraires.TabIndex = 16;
            // 
            // tBCours
            // 
            this.tBCours.Enabled = false;
            this.tBCours.Location = new System.Drawing.Point(116, 11);
            this.tBCours.Name = "tBCours";
            this.tBCours.Size = new System.Drawing.Size(170, 20);
            this.tBCours.TabIndex = 15;
            // 
            // lHoraires
            // 
            this.lHoraires.AutoSize = true;
            this.lHoraires.Location = new System.Drawing.Point(19, 38);
            this.lHoraires.Name = "lHoraires";
            this.lHoraires.Size = new System.Drawing.Size(91, 13);
            this.lHoraires.TabIndex = 14;
            this.lHoraires.Text = "Volume horaires : ";
            // 
            // lTypeCours
            // 
            this.lTypeCours.AutoSize = true;
            this.lTypeCours.Location = new System.Drawing.Point(19, 14);
            this.lTypeCours.Name = "lTypeCours";
            this.lTypeCours.Size = new System.Drawing.Size(84, 13);
            this.lTypeCours.TabIndex = 13;
            this.lTypeCours.Text = "Type de cours : ";
            // 
            // tBPersonnel
            // 
            this.tBPersonnel.Enabled = false;
            this.tBPersonnel.Location = new System.Drawing.Point(444, 11);
            this.tBPersonnel.Name = "tBPersonnel";
            this.tBPersonnel.Size = new System.Drawing.Size(170, 20);
            this.tBPersonnel.TabIndex = 20;
            // 
            // lPersonnel
            // 
            this.lPersonnel.AutoSize = true;
            this.lPersonnel.Location = new System.Drawing.Point(315, 14);
            this.lPersonnel.Name = "lPersonnel";
            this.lPersonnel.Size = new System.Drawing.Size(69, 13);
            this.lPersonnel.TabIndex = 19;
            this.lPersonnel.Text = "Enseignant : ";
            // 
            // UC_ElementCoursRech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementCoursRech";
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBEC;
        private System.Windows.Forms.Label lEC;
        private System.Windows.Forms.TextBox tBHoraires;
        private System.Windows.Forms.TextBox tBCours;
        private System.Windows.Forms.Label lHoraires;
        private System.Windows.Forms.Label lTypeCours;
        private System.Windows.Forms.TextBox tBPersonnel;
        private System.Windows.Forms.Label lPersonnel;
    }
}
