using dotnet.UserControler.Affichage;
using dotnet.UserControler.Ajout;
using dotnet.UserControler.FilArianne;

namespace dotnet.UserControler
{
    partial class UC_OngletPersonnels
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
            this.flpTitre = new System.Windows.Forms.FlowLayoutPanel();
            this.lTitre1 = new System.Windows.Forms.Label();
            this.lTitre2 = new System.Windows.Forms.Label();
            this.lTitre3 = new System.Windows.Forms.Label();
            this.gBPersonnel = new System.Windows.Forms.GroupBox();
            this.uC_FilArianePersonnel1 = new dotnet.UserControler.FilArianne.UC_FilArianePersonnel();
            this.uC_Affichage1 = new dotnet.UserControler.Affichage.UC_Affichage();
            this.uC_Ajout1 = new dotnet.UC_Ajout();
            this.flpTitre.SuspendLayout();
            this.SuspendLayout();
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
            this.flpTitre.TabIndex = 24;
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
            // gBPersonnel
            // 
            this.gBPersonnel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPersonnel.Location = new System.Drawing.Point(72, 126);
            this.gBPersonnel.Name = "gBPersonnel";
            this.gBPersonnel.Size = new System.Drawing.Size(993, 159);
            this.gBPersonnel.TabIndex = 25;
            this.gBPersonnel.TabStop = false;
            this.gBPersonnel.Text = "Informations : ";
            // 
            // uC_FilArianePersonnel1
            // 
            this.uC_FilArianePersonnel1.Location = new System.Drawing.Point(67, 22);
            this.uC_FilArianePersonnel1.Name = "uC_FilArianePersonnel1";
            this.uC_FilArianePersonnel1.Size = new System.Drawing.Size(980, 49);
            this.uC_FilArianePersonnel1.TabIndex = 20;
            // 
            // uC_Affichage1
            // 
            this.uC_Affichage1.Location = new System.Drawing.Point(67, 288);
            this.uC_Affichage1.Name = "uC_Affichage1";
            this.uC_Affichage1.Size = new System.Drawing.Size(1007, 364);
            this.uC_Affichage1.TabIndex = 19;
            // 
            // uC_Ajout1
            // 
            this.uC_Ajout1.Location = new System.Drawing.Point(69, 137);
            this.uC_Ajout1.Name = "uC_Ajout1";
            this.uC_Ajout1.Size = new System.Drawing.Size(1007, 89);
            this.uC_Ajout1.TabIndex = 21;
            // 
            // UC_OngletPersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBPersonnel);
            this.Controls.Add(this.uC_FilArianePersonnel1);
            this.Controls.Add(this.uC_Affichage1);
            this.Controls.Add(this.uC_Ajout1);
            this.Controls.Add(this.flpTitre);
            this.Name = "UC_OngletPersonnels";
            this.Size = new System.Drawing.Size(1112, 682);
            this.Load += new System.EventHandler(this.UC_OngletPersonnels_Load);
            this.flpTitre.ResumeLayout(false);
            this.flpTitre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private UC_Affichage uC_Affichage1;
        private UC_FilArianePersonnel uC_FilArianePersonnel1;
        private UC_Ajout uC_Ajout1;
        private System.Windows.Forms.FlowLayoutPanel flpTitre;
        private System.Windows.Forms.Label lTitre1;
        private System.Windows.Forms.Label lTitre2;
        private System.Windows.Forms.Label lTitre3;
        private System.Windows.Forms.GroupBox gBPersonnel;
    }
}
