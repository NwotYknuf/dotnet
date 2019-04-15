namespace dotnet
{
    partial class FenetreAjout
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
            this.lTitre = new System.Windows.Forms.Label();
            this.tB = new System.Windows.Forms.TextBox();
            this.bValider = new System.Windows.Forms.Button();
            this.lErreur = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lErreur);
            this.panel1.Controls.Add(this.bValider);
            this.panel1.Controls.Add(this.tB);
            this.panel1.Controls.Add(this.lTitre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 105);
            this.panel1.TabIndex = 0;
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Location = new System.Drawing.Point(34, 27);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(28, 13);
            this.lTitre.TabIndex = 0;
            this.lTitre.Text = "Titre";
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(37, 55);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(100, 20);
            this.tB.TabIndex = 1;
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(223, 53);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(75, 23);
            this.bValider.TabIndex = 2;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // lErreur
            // 
            this.lErreur.AutoSize = true;
            this.lErreur.ForeColor = System.Drawing.Color.Red;
            this.lErreur.Location = new System.Drawing.Point(218, 80);
            this.lErreur.Name = "lErreur";
            this.lErreur.Size = new System.Drawing.Size(88, 13);
            this.lErreur.TabIndex = 3;
            this.lErreur.Text = "Erreur, réessayez";
            this.lErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lErreur.Visible = false;
            // 
            // FenetreAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 129);
            this.Controls.Add(this.panel1);
            this.Name = "FenetreAjout";
            this.Text = "Fenetre d\'ajout";
            this.Load += new System.EventHandler(this.FenetreAjout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bValider;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.Label lErreur;
    }
}