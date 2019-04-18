using dotnet;
using dotnet.UserControler.Affichage;
using dotnet.UserControler.FilArianne;

namespace dotnet.UserControler
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
            this.cB_ECActive = new System.Windows.Forms.CheckBox();
            this.flpTitre = new System.Windows.Forms.FlowLayoutPanel();
            this.lTitre1 = new System.Windows.Forms.Label();
            this.lTitre2 = new System.Windows.Forms.Label();
            this.lTitre3 = new System.Windows.Forms.Label();
            this.uC_FilArianeDiplome1 = new dotnet.UserControler.FilArianne.UC_FilArianeDiplome();
            this.uC_Affichage1 = new dotnet.UserControler.Affichage.UC_Affichage();
            this.uC_Ajout1 = new dotnet.UC_Ajout();
            this.flpTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // cB_ECActive
            // 
            this.cB_ECActive.AutoSize = true;
            this.cB_ECActive.BackColor = System.Drawing.Color.Transparent;
            this.cB_ECActive.Checked = true;
            this.cB_ECActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_ECActive.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.cB_ECActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB_ECActive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_ECActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cB_ECActive.Location = new System.Drawing.Point(923, 89);
            this.cB_ECActive.Name = "cB_ECActive";
            this.cB_ECActive.Size = new System.Drawing.Size(111, 23);
            this.cB_ECActive.TabIndex = 15;
            this.cB_ECActive.Text = "EC Activée ";
            this.cB_ECActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cB_ECActive.UseVisualStyleBackColor = false;
            this.cB_ECActive.Visible = false;
            this.cB_ECActive.CheckedChanged += new System.EventHandler(this.cB_ECActive_CheckedChanged);
            // 
            // flpTitre
            // 
            this.flpTitre.Controls.Add(this.lTitre1);
            this.flpTitre.Controls.Add(this.lTitre2);
            this.flpTitre.Controls.Add(this.lTitre3);
            this.flpTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flpTitre.Location = new System.Drawing.Point(63, 79);
            this.flpTitre.Margin = new System.Windows.Forms.Padding(0);
            this.flpTitre.Name = "flpTitre";
            this.flpTitre.Size = new System.Drawing.Size(848, 42);
            this.flpTitre.TabIndex = 25;
            // 
            // lTitre1
            // 
            this.lTitre1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lTitre1.AutoSize = true;
            this.lTitre1.Font = new System.Drawing.Font("Heroes Legend", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(79)))), ((int)(((byte)(93)))));
            this.lTitre1.Location = new System.Drawing.Point(3, 0);
            this.lTitre1.Name = "lTitre1";
            this.lTitre1.Size = new System.Drawing.Size(98, 36);
            this.lTitre1.TabIndex = 19;
            this.lTitre1.Text = "Titre1";
            // 
            // lTitre2
            // 
            this.lTitre2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTitre2.AutoSize = true;
            this.lTitre2.Font = new System.Drawing.Font("Heroes Legend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.lTitre2.Location = new System.Drawing.Point(104, 2);
            this.lTitre2.Margin = new System.Windows.Forms.Padding(0);
            this.lTitre2.Name = "lTitre2";
            this.lTitre2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTitre2.Size = new System.Drawing.Size(93, 34);
            this.lTitre2.TabIndex = 20;
            this.lTitre2.Text = "titre2";
            // 
            // lTitre3
            // 
            this.lTitre3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTitre3.AutoSize = true;
            this.lTitre3.Font = new System.Drawing.Font("Heroes Legend", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(79)))), ((int)(((byte)(93)))));
            this.lTitre3.Location = new System.Drawing.Point(197, 0);
            this.lTitre3.Margin = new System.Windows.Forms.Padding(0);
            this.lTitre3.Name = "lTitre3";
            this.lTitre3.Size = new System.Drawing.Size(98, 36);
            this.lTitre3.TabIndex = 21;
            this.lTitre3.Text = "titre3";
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
            this.uC_Affichage1.Location = new System.Drawing.Point(67, 256);
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
            this.Controls.Add(this.flpTitre);
            this.Name = "UC_OngletDiplomes";
            this.Size = new System.Drawing.Size(1112, 682);
            this.Load += new System.EventHandler(this.UC_OngletDiplomes_Load);
            this.flpTitre.ResumeLayout(false);
            this.flpTitre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UC_Ajout uC_Ajout1;
        private UC_Affichage uC_Affichage1;
        private UC_FilArianeDiplome uC_FilArianeDiplome1;
        private System.Windows.Forms.CheckBox cB_ECActive;
        private System.Windows.Forms.FlowLayoutPanel flpTitre;
        private System.Windows.Forms.Label lTitre1;
        private System.Windows.Forms.Label lTitre2;
        private System.Windows.Forms.Label lTitre3;
    }
}
