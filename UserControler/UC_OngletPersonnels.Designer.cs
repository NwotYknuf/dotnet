using dotnet.UserControler.Affichage;
using dotnet.UserControler.Ajout;
using dotnet.UserControler.FilArianne;

namespace dotnet
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
            this.lTitre = new System.Windows.Forms.Label();
            this.uC_FilArianePersonnel1 = new dotnet.UserControler.FilArianne.UC_FilArianePersonnel();
            this.uC_Affichage1 = new dotnet.UserControler.Affichage.UC_Affichage();
            this.uC_Information1 = new dotnet.UserControler.Affichage.UC_Information();
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
            this.lTitre.TabIndex = 11;
            this.lTitre.Text = "Titre";
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
            this.uC_Affichage1.Location = new System.Drawing.Point(67, 257);
            this.uC_Affichage1.Name = "uC_Affichage1";
            this.uC_Affichage1.Size = new System.Drawing.Size(1007, 364);
            this.uC_Affichage1.TabIndex = 19;
            // 
            // uC_Information1
            // 
            this.uC_Information1.Location = new System.Drawing.Point(69, 123);
            this.uC_Information1.Name = "uC_Information1";
            this.uC_Information1.Size = new System.Drawing.Size(1005, 128);
            this.uC_Information1.TabIndex = 22;
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
            this.Controls.Add(this.uC_FilArianePersonnel1);
            this.Controls.Add(this.uC_Affichage1);
            this.Controls.Add(this.lTitre);
            this.Controls.Add(this.uC_Information1);
            this.Controls.Add(this.uC_Ajout1);
            this.Name = "UC_OngletPersonnels";
            this.Size = new System.Drawing.Size(1112, 682);
            this.Load += new System.EventHandler(this.UC_OngletPersonnels_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTitre;
        private UC_Affichage uC_Affichage1;
        private UC_FilArianePersonnel uC_FilArianePersonnel1;
        private UC_Ajout uC_Ajout1;
        private UC_Information uC_Information1;
    }
}
