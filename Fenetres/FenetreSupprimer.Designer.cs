namespace dotnet.Fenetres
{
    partial class FenetreSupprimer
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
            this.bValider = new System.Windows.Forms.Button();
            this.lTitre = new System.Windows.Forms.Label();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.lNomElement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(240, 88);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(75, 23);
            this.bValider.TabIndex = 4;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Location = new System.Drawing.Point(51, 23);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(258, 13);
            this.lTitre.TabIndex = 3;
            this.lTitre.Text = "Êtes vous sûr de vouloir supprimer l\'élément suivant : ";
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(54, 88);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 5;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // lNomElement
            // 
            this.lNomElement.AutoSize = true;
            this.lNomElement.Location = new System.Drawing.Point(142, 53);
            this.lNomElement.Name = "lNomElement";
            this.lNomElement.Size = new System.Drawing.Size(73, 13);
            this.lNomElement.TabIndex = 6;
            this.lNomElement.Text = "Nom_Element";
            // 
            // FenetreSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 129);
            this.Controls.Add(this.lNomElement);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bValider);
            this.Controls.Add(this.lTitre);
            this.Name = "FenetreSupprimer";
            this.Text = "FenetreSupprimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bValider;
        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Label lNomElement;
    }
}