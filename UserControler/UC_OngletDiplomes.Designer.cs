using dotnet;
using dotnet.UserControler.Affichage;
using dotnet.UserControler.FilArianne;

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
            this.uC_Affichage1 = new dotnet.UserControler.Affichage.UC_Affichage();
            this.ucAccueil1 = new dotnet.UC_OngletAccueil();
            this.uC_Ajout1 = new dotnet.UC_Ajout();
            this.uC_FilArianeDiplome1 = new dotnet.UserControler.FilArianne.UC_FilArianeDiplome();
            this.cBActif = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(66, 80);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(68, 29);
            this.lTitre.TabIndex = 0;
            this.lTitre.Text = "Titre";
            // 
            // uC_Affichage1
            // 
            this.uC_Affichage1.Location = new System.Drawing.Point(67, 236);
            this.uC_Affichage1.Name = "uC_Affichage1";
            this.uC_Affichage1.Size = new System.Drawing.Size(982, 364);
            this.uC_Affichage1.TabIndex = 12;
            // 
            // ucAccueil1
            // 
            this.ucAccueil1.Location = new System.Drawing.Point(316, 214);
            this.ucAccueil1.Name = "ucAccueil1";
            this.ucAccueil1.Size = new System.Drawing.Size(40, 11);
            this.ucAccueil1.TabIndex = 11;
            // 
            // uC_Ajout1
            // 
            this.uC_Ajout1.Location = new System.Drawing.Point(71, 142);
            this.uC_Ajout1.Name = "uC_Ajout1";
            this.uC_Ajout1.Size = new System.Drawing.Size(982, 88);
            this.uC_Ajout1.TabIndex = 10;
            // 
            // uC_FilArianeDiplome1
            // 
            this.uC_FilArianeDiplome1.Location = new System.Drawing.Point(67, 22);
            this.uC_FilArianeDiplome1.Name = "uC_FilArianeDiplome1";
            this.uC_FilArianeDiplome1.Size = new System.Drawing.Size(980, 42);
            this.uC_FilArianeDiplome1.TabIndex = 14;
            // 
            // cBActif
            // 
            this.cBActif.BackColor = System.Drawing.Color.Transparent;
            this.cBActif.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cBActif.Checked = true;
            this.cBActif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBActif.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.cBActif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBActif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.cBActif.Location = new System.Drawing.Point(195, 89);
            this.cBActif.Name = "cBActif";
            this.cBActif.Size = new System.Drawing.Size(53, 18);
            this.cBActif.TabIndex = 15;
            this.cBActif.Text = "Actif :  ";
            this.cBActif.UseVisualStyleBackColor = false;
            this.cBActif.Visible = false;
            // 
            // UC_OngletDiplomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBActif);
            this.Controls.Add(this.uC_FilArianeDiplome1);
            this.Controls.Add(this.uC_Affichage1);
            this.Controls.Add(this.ucAccueil1);
            this.Controls.Add(this.uC_Ajout1);
            this.Controls.Add(this.lTitre);
            this.Name = "UC_OngletDiplomes";
            this.Size = new System.Drawing.Size(1112, 682);
            this.Load += new System.EventHandler(this.UC_OngletDiplomes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private UC_Ajout uC_Ajout1;
        private UC_OngletAccueil ucAccueil1;
        private UC_Affichage uC_Affichage1;
        private UC_FilArianeDiplome uC_FilArianeDiplome1;
        private System.Windows.Forms.CheckBox cBActif;
    }
}
