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
            this.cB_ECActive = new System.Windows.Forms.CheckBox();
            this.uC_FilArianeDiplome1 = new dotnet.UserControler.FilArianne.UC_FilArianeDiplome();
            this.uC_Affichage1 = new dotnet.UserControler.Affichage.UC_Affichage();
            this.uC_Ajout1 = new dotnet.UC_Ajout();
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
            // cB_ECActive
            // 
            this.cB_ECActive.BackColor = System.Drawing.Color.Transparent;
            this.cB_ECActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cB_ECActive.Checked = true;
            this.cB_ECActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_ECActive.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.cB_ECActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB_ECActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_ECActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cB_ECActive.Location = new System.Drawing.Point(951, 84);
            this.cB_ECActive.Name = "cB_ECActive";
            this.cB_ECActive.Size = new System.Drawing.Size(96, 26);
            this.cB_ECActive.TabIndex = 15;
            this.cB_ECActive.Text = "EC Active :  ";
            this.cB_ECActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cB_ECActive.UseVisualStyleBackColor = false;
            this.cB_ECActive.Visible = false;
            this.cB_ECActive.CheckedChanged += new System.EventHandler(this.cB_ECActive_CheckedChanged);
            // 
            // uC_FilArianeDiplome1
            // 
            this.uC_FilArianeDiplome1.Location = new System.Drawing.Point(67, 22);
            this.uC_FilArianeDiplome1.Name = "uC_FilArianeDiplome1";
            this.uC_FilArianeDiplome1.Size = new System.Drawing.Size(980, 42);
            this.uC_FilArianeDiplome1.TabIndex = 14;
            // 
            // uC_Affichage1
            // 
            this.uC_Affichage1.Location = new System.Drawing.Point(67, 236);
            this.uC_Affichage1.Name = "uC_Affichage1";
            this.uC_Affichage1.Size = new System.Drawing.Size(1012, 364);
            this.uC_Affichage1.TabIndex = 12;
            // 
            // uC_Ajout1
            // 
            this.uC_Ajout1.Location = new System.Drawing.Point(69, 137);
            this.uC_Ajout1.Name = "uC_Ajout1";
            this.uC_Ajout1.Size = new System.Drawing.Size(1008, 88);
            this.uC_Ajout1.TabIndex = 10;
            // 
            // UC_OngletDiplomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cB_ECActive);
            this.Controls.Add(this.uC_FilArianeDiplome1);
            this.Controls.Add(this.uC_Affichage1);
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
        private UC_Affichage uC_Affichage1;
        private UC_FilArianeDiplome uC_FilArianeDiplome1;
        private System.Windows.Forms.CheckBox cB_ECActive;
    }
}
