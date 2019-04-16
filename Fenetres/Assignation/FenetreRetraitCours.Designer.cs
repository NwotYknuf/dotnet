namespace dotnet.Fenetres.Assignation
{
    partial class FenetreRetraitCours
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bValider = new System.Windows.Forms.Button();
            this.lTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lNomPersonnel = new System.Windows.Forms.Label();
            this.lTitre2 = new System.Windows.Forms.Label();
            this.lNomCours = new System.Windows.Forms.Label();
            this.lTitre3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(54, 84);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 10;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(240, 84);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(75, 23);
            this.bValider.TabIndex = 9;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Location = new System.Drawing.Point(51, 23);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(168, 13);
            this.lTitre.TabIndex = 8;
            this.lTitre.Text = "Êtes vous sûr de vouloir supprimer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lTitre3);
            this.panel1.Controls.Add(this.lNomCours);
            this.panel1.Controls.Add(this.lNomPersonnel);
            this.panel1.Controls.Add(this.lTitre2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 105);
            this.panel1.TabIndex = 12;
            // 
            // lNomPersonnel
            // 
            this.lNomPersonnel.AutoSize = true;
            this.lNomPersonnel.Location = new System.Drawing.Point(172, 50);
            this.lNomPersonnel.Name = "lNomPersonnel";
            this.lNomPersonnel.Size = new System.Drawing.Size(82, 13);
            this.lNomPersonnel.TabIndex = 13;
            this.lNomPersonnel.Text = "Nom_Personnel";
            // 
            // lTitre2
            // 
            this.lTitre2.AutoSize = true;
            this.lTitre2.Location = new System.Drawing.Point(68, 30);
            this.lTitre2.Name = "lTitre2";
            this.lTitre2.Size = new System.Drawing.Size(59, 13);
            this.lTitre2.TabIndex = 0;
            this.lTitre2.Text = "- le cours : ";
            // 
            // lNomCours
            // 
            this.lNomCours.AutoSize = true;
            this.lNomCours.Location = new System.Drawing.Point(172, 30);
            this.lNomCours.Name = "lNomCours";
            this.lNomCours.Size = new System.Drawing.Size(62, 13);
            this.lNomCours.TabIndex = 14;
            this.lNomCours.Text = "Nom_Cours";
            // 
            // lTitre3
            // 
            this.lTitre3.AutoSize = true;
            this.lTitre3.Location = new System.Drawing.Point(68, 50);
            this.lTitre3.Name = "lTitre3";
            this.lTitre3.Size = new System.Drawing.Size(83, 13);
            this.lTitre3.TabIndex = 15;
            this.lTitre3.Text = "- du personnel : ";
            // 
            // FenetreRetraitCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 129);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bValider);
            this.Controls.Add(this.lTitre);
            this.Controls.Add(this.panel1);
            this.Name = "FenetreRetraitCours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FenetreRetraitCours";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bValider;
        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lNomPersonnel;
        private System.Windows.Forms.Label lTitre3;
        private System.Windows.Forms.Label lNomCours;
        private System.Windows.Forms.Label lTitre2;
    }
}