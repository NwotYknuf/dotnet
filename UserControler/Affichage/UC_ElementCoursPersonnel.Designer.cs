namespace dotnet.UserControler.Affichage
{
    partial class UC_ElementCoursPersonnel
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
            this.bRetirer = new System.Windows.Forms.Button();
            this.tBEC = new System.Windows.Forms.TextBox();
            this.lEC = new System.Windows.Forms.Label();
            this.tBHoraires = new System.Windows.Forms.TextBox();
            this.tBCours = new System.Windows.Forms.TextBox();
            this.lHoraires = new System.Windows.Forms.Label();
            this.lTypeCours = new System.Windows.Forms.Label();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBAffElement
            // 
            this.gBAffElement.Size = new System.Drawing.Size(951, 123);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.bRetirer);
            this.panel.Controls.Add(this.tBEC);
            this.panel.Controls.Add(this.lEC);
            this.panel.Controls.Add(this.tBHoraires);
            this.panel.Controls.Add(this.tBCours);
            this.panel.Controls.Add(this.lHoraires);
            this.panel.Controls.Add(this.lTypeCours);
            this.panel.Size = new System.Drawing.Size(938, 100);
            // 
            // bRetirer
            // 
            this.bRetirer.Location = new System.Drawing.Point(807, 39);
            this.bRetirer.Name = "bRetirer";
            this.bRetirer.Size = new System.Drawing.Size(128, 23);
            this.bRetirer.TabIndex = 13;
            this.bRetirer.Text = "Retirer ce cours";
            this.bRetirer.UseVisualStyleBackColor = true;
            this.bRetirer.Click += new System.EventHandler(this.bRetirer_Click);
            // 
            // tBEC
            // 
            this.tBEC.Enabled = false;
            this.tBEC.Location = new System.Drawing.Point(56, 61);
            this.tBEC.Name = "tBEC";
            this.tBEC.Size = new System.Drawing.Size(100, 20);
            this.tBEC.TabIndex = 12;
            // 
            // lEC
            // 
            this.lEC.AutoSize = true;
            this.lEC.Location = new System.Drawing.Point(20, 64);
            this.lEC.Name = "lEC";
            this.lEC.Size = new System.Drawing.Size(30, 13);
            this.lEC.TabIndex = 11;
            this.lEC.Text = "EC : ";
            // 
            // tBHoraires
            // 
            this.tBHoraires.Enabled = false;
            this.tBHoraires.Location = new System.Drawing.Point(162, 36);
            this.tBHoraires.Name = "tBHoraires";
            this.tBHoraires.Size = new System.Drawing.Size(100, 20);
            this.tBHoraires.TabIndex = 10;
            // 
            // tBCours
            // 
            this.tBCours.Enabled = false;
            this.tBCours.Location = new System.Drawing.Point(111, 12);
            this.tBCours.Name = "tBCours";
            this.tBCours.Size = new System.Drawing.Size(100, 20);
            this.tBCours.TabIndex = 9;
            // 
            // lHoraires
            // 
            this.lHoraires.AutoSize = true;
            this.lHoraires.Location = new System.Drawing.Point(21, 39);
            this.lHoraires.Name = "lHoraires";
            this.lHoraires.Size = new System.Drawing.Size(135, 13);
            this.lHoraires.TabIndex = 8;
            this.lHoraires.Text = "Volume horaires du cours : ";
            // 
            // lTypeCours
            // 
            this.lTypeCours.AutoSize = true;
            this.lTypeCours.Location = new System.Drawing.Point(21, 15);
            this.lTypeCours.Name = "lTypeCours";
            this.lTypeCours.Size = new System.Drawing.Size(84, 13);
            this.lTypeCours.TabIndex = 7;
            this.lTypeCours.Text = "Type de cours : ";
            // 
            // UC_ElementCoursPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementCoursPersonnel";
            this.Size = new System.Drawing.Size(955, 126);
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bRetirer;
        private System.Windows.Forms.TextBox tBEC;
        private System.Windows.Forms.Label lEC;
        private System.Windows.Forms.TextBox tBHoraires;
        private System.Windows.Forms.TextBox tBCours;
        private System.Windows.Forms.Label lHoraires;
        private System.Windows.Forms.Label lTypeCours;
    }
}
