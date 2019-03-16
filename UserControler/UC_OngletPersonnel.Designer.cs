namespace dotnet
{
    partial class UC_OngletPersonnel
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
            this.gbPersonnels = new System.Windows.Forms.GroupBox();
            this.bFilAriane2 = new System.Windows.Forms.Button();
            this.bFilAriane1 = new System.Windows.Forms.Button();
            this.gbAjout = new System.Windows.Forms.GroupBox();
            this.tbPersonnel = new System.Windows.Forms.TextBox();
            this.bCreerPersonnel = new System.Windows.Forms.Button();
            this.lNomPersonnel = new System.Windows.Forms.Label();
            this.lTitre = new System.Windows.Forms.Label();
            this.gbAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonnels
            // 
            this.gbPersonnels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonnels.Location = new System.Drawing.Point(71, 278);
            this.gbPersonnels.Name = "gbPersonnels";
            this.gbPersonnels.Size = new System.Drawing.Size(975, 382);
            this.gbPersonnels.TabIndex = 17;
            this.gbPersonnels.TabStop = false;
            this.gbPersonnels.Text = "Personnels : ";
            // 
            // bFilAriane2
            // 
            this.bFilAriane2.AutoSize = true;
            this.bFilAriane2.Location = new System.Drawing.Point(229, 80);
            this.bFilAriane2.Name = "bFilAriane2";
            this.bFilAriane2.Size = new System.Drawing.Size(143, 23);
            this.bFilAriane2.TabIndex = 14;
            this.bFilAriane2.Text = "Nom_Cours_séléctionné";
            this.bFilAriane2.UseVisualStyleBackColor = true;
            // 
            // bFilAriane1
            // 
            this.bFilAriane1.AutoSize = true;
            this.bFilAriane1.Location = new System.Drawing.Point(71, 80);
            this.bFilAriane1.Name = "bFilAriane1";
            this.bFilAriane1.Size = new System.Drawing.Size(152, 23);
            this.bFilAriane1.TabIndex = 13;
            this.bFilAriane1.Text = "Nom_Personnel_séléctionné";
            this.bFilAriane1.UseVisualStyleBackColor = true;
            // 
            // gbAjout
            // 
            this.gbAjout.Controls.Add(this.tbPersonnel);
            this.gbAjout.Controls.Add(this.bCreerPersonnel);
            this.gbAjout.Controls.Add(this.lNomPersonnel);
            this.gbAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjout.Location = new System.Drawing.Point(71, 150);
            this.gbAjout.Name = "gbAjout";
            this.gbAjout.Size = new System.Drawing.Size(337, 100);
            this.gbAjout.TabIndex = 12;
            this.gbAjout.TabStop = false;
            this.gbAjout.Text = "Ajouter un personnel : ";
            // 
            // tbPersonnel
            // 
            this.tbPersonnel.Location = new System.Drawing.Point(46, 39);
            this.tbPersonnel.Name = "tbPersonnel";
            this.tbPersonnel.Size = new System.Drawing.Size(100, 22);
            this.tbPersonnel.TabIndex = 3;
            // 
            // bCreerPersonnel
            // 
            this.bCreerPersonnel.AutoSize = true;
            this.bCreerPersonnel.Location = new System.Drawing.Point(207, 37);
            this.bCreerPersonnel.Name = "bCreerPersonnel";
            this.bCreerPersonnel.Size = new System.Drawing.Size(128, 26);
            this.bCreerPersonnel.TabIndex = 1;
            this.bCreerPersonnel.Text = "Créer le personnel";
            this.bCreerPersonnel.UseVisualStyleBackColor = true;
            // 
            // lNomPersonnel
            // 
            this.lNomPersonnel.AutoSize = true;
            this.lNomPersonnel.Location = new System.Drawing.Point(6, 42);
            this.lNomPersonnel.Name = "lNomPersonnel";
            this.lNomPersonnel.Size = new System.Drawing.Size(46, 16);
            this.lNomPersonnel.TabIndex = 4;
            this.lNomPersonnel.Text = "Nom : ";
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(66, 23);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(68, 29);
            this.lTitre.TabIndex = 11;
            this.lTitre.Text = "Titre";
            // 
            // UCListePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPersonnels);
            this.Controls.Add(this.bFilAriane2);
            this.Controls.Add(this.bFilAriane1);
            this.Controls.Add(this.gbAjout);
            this.Controls.Add(this.lTitre);
            this.Name = "UCListePersonnel";
            this.Size = new System.Drawing.Size(1112, 682);
            this.gbAjout.ResumeLayout(false);
            this.gbAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonnels;
        private System.Windows.Forms.Button bFilAriane2;
        private System.Windows.Forms.Button bFilAriane1;
        private System.Windows.Forms.GroupBox gbAjout;
        private System.Windows.Forms.TextBox tbPersonnel;
        private System.Windows.Forms.Button bCreerPersonnel;
        private System.Windows.Forms.Label lNomPersonnel;
        private System.Windows.Forms.Label lTitre;
    }
}
