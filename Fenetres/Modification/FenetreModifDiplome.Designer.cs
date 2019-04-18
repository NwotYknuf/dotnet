namespace dotnet.Fenetres.Modification
{
    partial class FenetreModifDiplome
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
            this.tBNom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.rtBDesc = new System.Windows.Forms.RichTextBox();
            this.lChampsObligatoires = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gBAffElement.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAnnuler
            // 
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bValider
            // 
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tBNom);
            this.panel2.Controls.Add(this.lNom);
            this.panel2.Controls.Add(this.lDescription);
            this.panel2.Controls.Add(this.rtBDesc);
            this.panel2.Controls.Add(this.lChampsObligatoires);
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(95, 31);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(100, 20);
            this.tBNom.TabIndex = 42;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(13, 34);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(45, 13);
            this.lNom.TabIndex = 45;
            this.lNom.Text = "Nom * : ";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(13, 60);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(76, 13);
            this.lDescription.TabIndex = 44;
            this.lDescription.Text = "Description * : ";
            // 
            // rtBDesc
            // 
            this.rtBDesc.Location = new System.Drawing.Point(95, 57);
            this.rtBDesc.Name = "rtBDesc";
            this.rtBDesc.Size = new System.Drawing.Size(327, 20);
            this.rtBDesc.TabIndex = 43;
            this.rtBDesc.Text = "";
            // 
            // lChampsObligatoires
            // 
            this.lChampsObligatoires.AutoSize = true;
            this.lChampsObligatoires.Location = new System.Drawing.Point(159, 102);
            this.lChampsObligatoires.Name = "lChampsObligatoires";
            this.lChampsObligatoires.Size = new System.Drawing.Size(268, 13);
            this.lChampsObligatoires.TabIndex = 41;
            this.lChampsObligatoires.Text = "Les champs suivis d\'une astérisque (*) sont obligatoires.";
            // 
            // FenetreModifDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 240);
            this.Name = "FenetreModifDiplome";
            this.Text = "FenetreModifDiplome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBAffElement.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.RichTextBox rtBDesc;
        private System.Windows.Forms.Label lChampsObligatoires;
    }
}