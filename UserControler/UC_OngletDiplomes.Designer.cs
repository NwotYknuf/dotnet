namespace dotnet
{
    partial class UC_OngletDiplomes
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
            this.bFilAriane1 = new System.Windows.Forms.Button();
            this.bFilAriane2 = new System.Windows.Forms.Button();
            this.bFilAriane3 = new System.Windows.Forms.Button();
            this.bFilAriane4 = new System.Windows.Forms.Button();
            this.uC_Ajout1 = new UC_Ajout();
            this.ucAccueil1 = new dotnet.UCAccueil();
            this.uC_Affichage1 = new UC_Affichage();
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
            // uC_Ajout1
            // 
            this.uC_Ajout1.Location = new System.Drawing.Point(71, 142);
            this.uC_Ajout1.Name = "uC_Ajout1";
            this.uC_Ajout1.Size = new System.Drawing.Size(569, 150);
            this.uC_Ajout1.TabIndex = 10;
            // 
            // ucAccueil1
            // 
            this.ucAccueil1.Location = new System.Drawing.Point(316, 214);
            this.ucAccueil1.Name = "ucAccueil1";
            this.ucAccueil1.Size = new System.Drawing.Size(40, 11);
            this.ucAccueil1.TabIndex = 11;
            // 
            // uC_Affichage1
            // 
            this.uC_Affichage1.Location = new System.Drawing.Point(71, 310);
            this.uC_Affichage1.Name = "uC_Affichage1";
            this.uC_Affichage1.Size = new System.Drawing.Size(959, 364);
            this.uC_Affichage1.TabIndex = 12;
            // 
            // UCListeDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_Affichage1);
            this.Controls.Add(this.ucAccueil1);
            this.Controls.Add(this.uC_Ajout1);
            this.Controls.Add(this.bFilAriane4);
            this.Controls.Add(this.bFilAriane3);
            this.Controls.Add(this.bFilAriane2);
            this.Controls.Add(this.bFilAriane1);
            this.Controls.Add(this.lTitre);
            this.Name = "UCListeDiplome";
            this.Size = new System.Drawing.Size(1112, 682);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.Button bFilAriane1;
        private System.Windows.Forms.Button bFilAriane2;
        private System.Windows.Forms.Button bFilAriane3;
        private System.Windows.Forms.Button bFilAriane4;
        private UC_Ajout uC_Ajout1;
        private UCAccueil ucAccueil1;
        private UC_Affichage uC_Affichage1;
    }
}
