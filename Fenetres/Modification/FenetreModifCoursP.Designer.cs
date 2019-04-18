namespace dotnet.Fenetres.Modification
{
    partial class FenetreModifCoursP
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
            this.lChampsObligatoires = new System.Windows.Forms.Label();
            this.lTypeCours = new System.Windows.Forms.Label();
            this.tBHoraires = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.lHoraires = new System.Windows.Forms.Label();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.cBType = new System.Windows.Forms.ComboBox();
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
            this.panel2.Controls.Add(this.lTypeCours);
            this.panel2.Controls.Add(this.cBType);
            this.panel2.Controls.Add(this.lChampsObligatoires);
            this.panel2.Controls.Add(this.tBNom);
            this.panel2.Controls.Add(this.lHoraires);
            this.panel2.Controls.Add(this.tBHoraires);
            this.panel2.Controls.Add(this.lNom);
            // 
            // lChampsObligatoires
            // 
            this.lChampsObligatoires.AutoSize = true;
            this.lChampsObligatoires.Location = new System.Drawing.Point(159, 102);
            this.lChampsObligatoires.Name = "lChampsObligatoires";
            this.lChampsObligatoires.Size = new System.Drawing.Size(268, 13);
            this.lChampsObligatoires.TabIndex = 51;
            this.lChampsObligatoires.Text = "Les champs suivis d\'une astérisque (*) sont obligatoires.";
            // 
            // lTypeCours
            // 
            this.lTypeCours.AutoSize = true;
            this.lTypeCours.Location = new System.Drawing.Point(214, 35);
            this.lTypeCours.Name = "lTypeCours";
            this.lTypeCours.Size = new System.Drawing.Size(91, 13);
            this.lTypeCours.TabIndex = 48;
            this.lTypeCours.Text = "Type de cours * : ";
            // 
            // tBHoraires
            // 
            this.tBHoraires.Location = new System.Drawing.Point(108, 57);
            this.tBHoraires.Name = "tBHoraires";
            this.tBHoraires.Size = new System.Drawing.Size(93, 20);
            this.tBHoraires.TabIndex = 47;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(13, 34);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(45, 13);
            this.lNom.TabIndex = 49;
            this.lNom.Text = "Nom * : ";
            // 
            // lHoraires
            // 
            this.lHoraires.AutoSize = true;
            this.lHoraires.Location = new System.Drawing.Point(13, 60);
            this.lHoraires.Name = "lHoraires";
            this.lHoraires.Size = new System.Drawing.Size(93, 13);
            this.lHoraires.TabIndex = 50;
            this.lHoraires.Text = "Volume horaire * : ";
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(108, 32);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(93, 20);
            this.tBNom.TabIndex = 45;
            // 
            // cBType
            // 
            this.cBType.FormattingEnabled = true;
            this.cBType.Location = new System.Drawing.Point(311, 32);
            this.cBType.Name = "cBType";
            this.cBType.Size = new System.Drawing.Size(116, 21);
            this.cBType.TabIndex = 46;
            // 
            // FenetreModifCoursP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 240);
            this.Name = "FenetreModifCoursP";
            this.Text = "FenetreModifCoursP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBAffElement.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lChampsObligatoires;
        private System.Windows.Forms.Label lTypeCours;
        private System.Windows.Forms.TextBox tBHoraires;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lHoraires;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.ComboBox cBType;
    }
}