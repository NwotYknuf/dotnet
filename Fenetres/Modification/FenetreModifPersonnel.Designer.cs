namespace dotnet.Fenetres.Modification
{
    partial class FenetreModifPersonnel
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
            this.cBCategorie = new System.Windows.Forms.ComboBox();
            this.lCategorie = new System.Windows.Forms.Label();
            this.lTelephone = new System.Windows.Forms.Label();
            this.tBTelephone = new System.Windows.Forms.TextBox();
            this.lPrenom = new System.Windows.Forms.Label();
            this.tBPrenom = new System.Windows.Forms.TextBox();
            this.tBAdresseEmail = new System.Windows.Forms.TextBox();
            this.lAdresseEmail = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.lAdressePost = new System.Windows.Forms.Label();
            this.tBAdressePost = new System.Windows.Forms.TextBox();
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
            this.panel2.Controls.Add(this.lChampsObligatoires);
            this.panel2.Controls.Add(this.cBCategorie);
            this.panel2.Controls.Add(this.lCategorie);
            this.panel2.Controls.Add(this.lTelephone);
            this.panel2.Controls.Add(this.tBTelephone);
            this.panel2.Controls.Add(this.lPrenom);
            this.panel2.Controls.Add(this.tBPrenom);
            this.panel2.Controls.Add(this.tBAdresseEmail);
            this.panel2.Controls.Add(this.lAdresseEmail);
            this.panel2.Controls.Add(this.lNom);
            this.panel2.Controls.Add(this.tBNom);
            this.panel2.Controls.Add(this.lAdressePost);
            this.panel2.Controls.Add(this.tBAdressePost);
            // 
            // lChampsObligatoires
            // 
            this.lChampsObligatoires.AutoSize = true;
            this.lChampsObligatoires.Location = new System.Drawing.Point(159, 102);
            this.lChampsObligatoires.Name = "lChampsObligatoires";
            this.lChampsObligatoires.Size = new System.Drawing.Size(268, 13);
            this.lChampsObligatoires.TabIndex = 47;
            this.lChampsObligatoires.Text = "Les champs suivis d\'une astérisque (*) sont obligatoires.";
            // 
            // cBCategorie
            // 
            this.cBCategorie.FormattingEnabled = true;
            this.cBCategorie.Location = new System.Drawing.Point(265, 74);
            this.cBCategorie.Name = "cBCategorie";
            this.cBCategorie.Size = new System.Drawing.Size(162, 21);
            this.cBCategorie.TabIndex = 40;
            // 
            // lCategorie
            // 
            this.lCategorie.AutoSize = true;
            this.lCategorie.Location = new System.Drawing.Point(189, 77);
            this.lCategorie.Name = "lCategorie";
            this.lCategorie.Size = new System.Drawing.Size(68, 13);
            this.lCategorie.TabIndex = 45;
            this.lCategorie.Text = "Catégorie * : ";
            // 
            // lTelephone
            // 
            this.lTelephone.AutoSize = true;
            this.lTelephone.Location = new System.Drawing.Point(13, 77);
            this.lTelephone.Name = "lTelephone";
            this.lTelephone.Size = new System.Drawing.Size(67, 13);
            this.lTelephone.TabIndex = 44;
            this.lTelephone.Text = "Téléphone : ";
            // 
            // tBTelephone
            // 
            this.tBTelephone.Location = new System.Drawing.Point(80, 74);
            this.tBTelephone.Name = "tBTelephone";
            this.tBTelephone.Size = new System.Drawing.Size(92, 20);
            this.tBTelephone.TabIndex = 37;
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(13, 50);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(59, 13);
            this.lPrenom.TabIndex = 43;
            this.lPrenom.Text = "Prénom * : ";
            // 
            // tBPrenom
            // 
            this.tBPrenom.Location = new System.Drawing.Point(80, 47);
            this.tBPrenom.Name = "tBPrenom";
            this.tBPrenom.Size = new System.Drawing.Size(92, 20);
            this.tBPrenom.TabIndex = 36;
            // 
            // tBAdresseEmail
            // 
            this.tBAdresseEmail.Location = new System.Drawing.Point(286, 20);
            this.tBAdresseEmail.Name = "tBAdresseEmail";
            this.tBAdresseEmail.Size = new System.Drawing.Size(141, 20);
            this.tBAdresseEmail.TabIndex = 38;
            // 
            // lAdresseEmail
            // 
            this.lAdresseEmail.AutoSize = true;
            this.lAdresseEmail.Location = new System.Drawing.Point(189, 23);
            this.lAdresseEmail.Name = "lAdresseEmail";
            this.lAdresseEmail.Size = new System.Drawing.Size(91, 13);
            this.lAdresseEmail.TabIndex = 42;
            this.lAdresseEmail.Text = "Adresse e-mail * : ";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(13, 23);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(45, 13);
            this.lNom.TabIndex = 41;
            this.lNom.Text = "Nom * : ";
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(80, 20);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(92, 20);
            this.tBNom.TabIndex = 35;
            // 
            // lAdressePost
            // 
            this.lAdressePost.AutoSize = true;
            this.lAdressePost.Location = new System.Drawing.Point(189, 50);
            this.lAdressePost.Name = "lAdressePost";
            this.lAdressePost.Size = new System.Drawing.Size(98, 13);
            this.lAdressePost.TabIndex = 46;
            this.lAdressePost.Text = "Adresse postale * : ";
            // 
            // tBAdressePost
            // 
            this.tBAdressePost.Location = new System.Drawing.Point(286, 47);
            this.tBAdressePost.Name = "tBAdressePost";
            this.tBAdressePost.Size = new System.Drawing.Size(141, 20);
            this.tBAdressePost.TabIndex = 39;
            // 
            // FenetreModifPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 240);
            this.Name = "FenetreModifPersonnel";
            this.Text = "FenetreModifPersonnel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBAffElement.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lChampsObligatoires;
        private System.Windows.Forms.ComboBox cBCategorie;
        private System.Windows.Forms.Label lCategorie;
        private System.Windows.Forms.Label lTelephone;
        private System.Windows.Forms.TextBox tBTelephone;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.TextBox tBPrenom;
        private System.Windows.Forms.TextBox tBAdresseEmail;
        private System.Windows.Forms.Label lAdresseEmail;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.Label lAdressePost;
        private System.Windows.Forms.TextBox tBAdressePost;
    }
}