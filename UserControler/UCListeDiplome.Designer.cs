namespace dotnet
{
    partial class UCListeDiplome
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
            this.lTitre = new System.Windows.Forms.Label();
            this.bCreerDiplome = new System.Windows.Forms.Button();
            this.tbDiplome = new System.Windows.Forms.TextBox();
            this.lNomDiplome = new System.Windows.Forms.Label();
            this.gbAjout = new System.Windows.Forms.GroupBox();
            this.bFilAriane1 = new System.Windows.Forms.Button();
            this.bFilAriane2 = new System.Windows.Forms.Button();
            this.bFilAriane3 = new System.Windows.Forms.Button();
            this.bFilAriane4 = new System.Windows.Forms.Button();
            this.gbDiplomes = new System.Windows.Forms.GroupBox();
            this.gbAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(66, 23);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(68, 29);
            this.lTitre.TabIndex = 0;
            this.lTitre.Text = "Titre";
            // 
            // bCreerDiplome
            // 
            this.bCreerDiplome.AutoSize = true;
            this.bCreerDiplome.Location = new System.Drawing.Point(211, 41);
            this.bCreerDiplome.Name = "bCreerDiplome";
            this.bCreerDiplome.Size = new System.Drawing.Size(117, 26);
            this.bCreerDiplome.TabIndex = 1;
            this.bCreerDiplome.Text = "Créer le diplôme";
            this.bCreerDiplome.UseVisualStyleBackColor = true;
            // 
            // tbDiplome
            // 
            this.tbDiplome.Location = new System.Drawing.Point(50, 43);
            this.tbDiplome.Name = "tbDiplome";
            this.tbDiplome.Size = new System.Drawing.Size(100, 22);
            this.tbDiplome.TabIndex = 3;
            // 
            // lNomDiplome
            // 
            this.lNomDiplome.AutoSize = true;
            this.lNomDiplome.Location = new System.Drawing.Point(10, 46);
            this.lNomDiplome.Name = "lNomDiplome";
            this.lNomDiplome.Size = new System.Drawing.Size(46, 16);
            this.lNomDiplome.TabIndex = 4;
            this.lNomDiplome.Text = "Nom : ";
            // 
            // gbAjout
            // 
            this.gbAjout.Controls.Add(this.tbDiplome);
            this.gbAjout.Controls.Add(this.bCreerDiplome);
            this.gbAjout.Controls.Add(this.lNomDiplome);
            this.gbAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjout.Location = new System.Drawing.Point(71, 150);
            this.gbAjout.Name = "gbAjout";
            this.gbAjout.Size = new System.Drawing.Size(337, 100);
            this.gbAjout.TabIndex = 5;
            this.gbAjout.TabStop = false;
            this.gbAjout.Text = "Ajouter un diplôme : ";
            // 
            // bFilAriane1
            // 
            this.bFilAriane1.AutoSize = true;
            this.bFilAriane1.Location = new System.Drawing.Point(71, 80);
            this.bFilAriane1.Name = "bFilAriane1";
            this.bFilAriane1.Size = new System.Drawing.Size(143, 23);
            this.bFilAriane1.TabIndex = 6;
            this.bFilAriane1.Text = "Nom_Diplôme_séléctionné";
            this.bFilAriane1.UseVisualStyleBackColor = true;
            // 
            // bFilAriane2
            // 
            this.bFilAriane2.AutoSize = true;
            this.bFilAriane2.Location = new System.Drawing.Point(220, 80);
            this.bFilAriane2.Name = "bFilAriane2";
            this.bFilAriane2.Size = new System.Drawing.Size(143, 23);
            this.bFilAriane2.TabIndex = 7;
            this.bFilAriane2.Text = "Nom_Année_séléctionnée";
            this.bFilAriane2.UseVisualStyleBackColor = true;
            // 
            // bFilAriane3
            // 
            this.bFilAriane3.AutoSize = true;
            this.bFilAriane3.Location = new System.Drawing.Point(369, 80);
            this.bFilAriane3.Name = "bFilAriane3";
            this.bFilAriane3.Size = new System.Drawing.Size(146, 23);
            this.bFilAriane3.TabIndex = 8;
            this.bFilAriane3.Text = "Nom_période_séléctionnée";
            this.bFilAriane3.UseVisualStyleBackColor = true;
            // 
            // bFilAriane4
            // 
            this.bFilAriane4.AutoSize = true;
            this.bFilAriane4.Location = new System.Drawing.Point(521, 80);
            this.bFilAriane4.Name = "bFilAriane4";
            this.bFilAriane4.Size = new System.Drawing.Size(146, 23);
            this.bFilAriane4.TabIndex = 9;
            this.bFilAriane4.Text = "Nom_UE_séléctionnée";
            this.bFilAriane4.UseVisualStyleBackColor = true;
            // 
            // gbDiplomes
            // 
            this.gbDiplomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiplomes.Location = new System.Drawing.Point(71, 278);
            this.gbDiplomes.Name = "gbDiplomes";
            this.gbDiplomes.Size = new System.Drawing.Size(975, 382);
            this.gbDiplomes.TabIndex = 10;
            this.gbDiplomes.TabStop = false;
            this.gbDiplomes.Text = "Diplômes : ";
            // 
            // UCListeDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDiplomes);
            this.Controls.Add(this.bFilAriane4);
            this.Controls.Add(this.bFilAriane3);
            this.Controls.Add(this.bFilAriane2);
            this.Controls.Add(this.bFilAriane1);
            this.Controls.Add(this.gbAjout);
            this.Controls.Add(this.lTitre);
            this.Name = "UCListeDiplome";
            this.Size = new System.Drawing.Size(1112, 682);
            this.gbAjout.ResumeLayout(false);
            this.gbAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.Button bCreerDiplome;
        private System.Windows.Forms.TextBox tbDiplome;
        private System.Windows.Forms.Label lNomDiplome;
        private System.Windows.Forms.GroupBox gbAjout;
        private System.Windows.Forms.Button bFilAriane1;
        private System.Windows.Forms.Button bFilAriane2;
        private System.Windows.Forms.Button bFilAriane3;
        private System.Windows.Forms.Button bFilAriane4;
        private System.Windows.Forms.GroupBox gbDiplomes;
    }
}
