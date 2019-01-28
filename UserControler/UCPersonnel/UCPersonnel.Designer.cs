namespace dotnet
{
    partial class UCPersonnel
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
            this.gbCours = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPersonnelLibre = new System.Windows.Forms.GroupBox();
            this.gbInfos = new System.Windows.Forms.GroupBox();
            this.lNom = new System.Windows.Forms.Label();
            this.lNbHAttribuees = new System.Windows.Forms.Label();
            this.lNbHNonAttribuees = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCours
            // 
            this.gbCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCours.Location = new System.Drawing.Point(35, 153);
            this.gbCours.Name = "gbCours";
            this.gbCours.Size = new System.Drawing.Size(535, 382);
            this.gbCours.TabIndex = 17;
            this.gbCours.TabStop = false;
            this.gbCours.Text = "Cours : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPersonnelLibre);
            this.panel1.Location = new System.Drawing.Point(588, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 561);
            this.panel1.TabIndex = 18;
            // 
            // gbPersonnelLibre
            // 
            this.gbPersonnelLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonnelLibre.Location = new System.Drawing.Point(19, 25);
            this.gbPersonnelLibre.Name = "gbPersonnelLibre";
            this.gbPersonnelLibre.Size = new System.Drawing.Size(412, 510);
            this.gbPersonnelLibre.TabIndex = 0;
            this.gbPersonnelLibre.TabStop = false;
            this.gbPersonnelLibre.Text = "Personnels libres : ";
            // 
            // gbInfos
            // 
            this.gbInfos.Controls.Add(this.lNbHNonAttribuees);
            this.gbInfos.Controls.Add(this.lNbHAttribuees);
            this.gbInfos.Controls.Add(this.lNom);
            this.gbInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfos.Location = new System.Drawing.Point(35, 25);
            this.gbInfos.Name = "gbInfos";
            this.gbInfos.Size = new System.Drawing.Size(535, 122);
            this.gbInfos.TabIndex = 19;
            this.gbInfos.TabStop = false;
            this.gbInfos.Text = "Informations : ";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(37, 30);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(46, 16);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom : ";
            // 
            // lNbHAttribuees
            // 
            this.lNbHAttribuees.AutoSize = true;
            this.lNbHAttribuees.Location = new System.Drawing.Point(37, 57);
            this.lNbHAttribuees.Name = "lNbHAttribuees";
            this.lNbHAttribuees.Size = new System.Drawing.Size(183, 16);
            this.lNbHAttribuees.TabIndex = 1;
            this.lNbHAttribuees.Text = "Nombre d\'heures attribuées : ";
            // 
            // lNbHNonAttribuees
            // 
            this.lNbHNonAttribuees.AutoSize = true;
            this.lNbHNonAttribuees.Location = new System.Drawing.Point(37, 86);
            this.lNbHNonAttribuees.Name = "lNbHNonAttribuees";
            this.lNbHNonAttribuees.Size = new System.Drawing.Size(208, 16);
            this.lNbHNonAttribuees.TabIndex = 2;
            this.lNbHNonAttribuees.Text = "Nombre d\'heures non attribuées : ";
            // 
            // UCPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbInfos);
            this.Controls.Add(this.gbCours);
            this.Controls.Add(this.panel1);
            this.Name = "UCPersonnel";
            this.Size = new System.Drawing.Size(1112, 561);
            this.panel1.ResumeLayout(false);
            this.gbInfos.ResumeLayout(false);
            this.gbInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCours;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPersonnelLibre;
        private System.Windows.Forms.GroupBox gbInfos;
        private System.Windows.Forms.Label lNbHNonAttribuees;
        private System.Windows.Forms.Label lNbHAttribuees;
        private System.Windows.Forms.Label lNom;
    }
}
