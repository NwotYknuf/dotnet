namespace dotnet.Fenetres
{
    partial class FenetreRetrait
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bValider = new System.Windows.Forms.Button();
            this.lTitre = new System.Windows.Forms.Label();
            this.cBListe = new System.Windows.Forms.ComboBox();
            this.lErreur = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lErreur);
            this.panel1.Controls.Add(this.cBListe);
            this.panel1.Controls.Add(this.bAnnuler);
            this.panel1.Controls.Add(this.bValider);
            this.panel1.Controls.Add(this.lTitre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 105);
            this.panel1.TabIndex = 8;
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(42, 72);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 9;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(228, 72);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(75, 23);
            this.bValider.TabIndex = 7;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Location = new System.Drawing.Point(39, 13);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(28, 13);
            this.lTitre.TabIndex = 5;
            this.lTitre.Text = "Titre";
            // 
            // cBListe
            // 
            this.cBListe.FormattingEnabled = true;
            this.cBListe.Location = new System.Drawing.Point(42, 40);
            this.cBListe.Name = "cBListe";
            this.cBListe.Size = new System.Drawing.Size(153, 21);
            this.cBListe.TabIndex = 10;
            // 
            // lErreur
            // 
            this.lErreur.AutoSize = true;
            this.lErreur.ForeColor = System.Drawing.Color.Red;
            this.lErreur.Location = new System.Drawing.Point(223, 45);
            this.lErreur.Name = "lErreur";
            this.lErreur.Size = new System.Drawing.Size(88, 13);
            this.lErreur.TabIndex = 11;
            this.lErreur.Text = "Erreur, réessayez";
            this.lErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lErreur.Visible = false;
            // 
            // FenetreRetrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 129);
            this.Controls.Add(this.panel1);
            this.Name = "FenetreRetrait";
            this.Text = "FenetreRetrait";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bValider;
        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.ComboBox cBListe;
        private System.Windows.Forms.Label lErreur;
    }
}