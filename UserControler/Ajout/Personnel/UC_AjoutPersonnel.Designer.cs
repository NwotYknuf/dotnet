namespace dotnet.UserControler.Ajout
{
    partial class UC_AjoutPersonnel
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
            this.tBAdresseEmail = new System.Windows.Forms.TextBox();
            this.lAdresseEmail = new System.Windows.Forms.Label();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.tBPrenom = new System.Windows.Forms.TextBox();
            this.lTelephone = new System.Windows.Forms.Label();
            this.tBTelephone = new System.Windows.Forms.TextBox();
            this.cBCategorie = new System.Windows.Forms.ComboBox();
            this.lCategorie = new System.Windows.Forms.Label();
            this.tBAdressePost = new System.Windows.Forms.TextBox();
            this.lAdressePost = new System.Windows.Forms.Label();
            this.lChampsObligatoires = new System.Windows.Forms.Label();
            this.gBTitreAjout.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTitreAjout
            // 
            this.gBTitreAjout.Margin = new System.Windows.Forms.Padding(4);
            this.gBTitreAjout.Padding = new System.Windows.Forms.Padding(4);
            this.gBTitreAjout.Size = new System.Drawing.Size(994, 130);
            this.gBTitreAjout.Text = "Ajouter un personnel : ";
            // 
            // bCreer
            // 
            this.bCreer.Location = new System.Drawing.Point(833, 17);
            this.bCreer.Margin = new System.Windows.Forms.Padding(4);
            this.bCreer.TabIndex = 7;
            this.bCreer.Text = "Créer un personnel";
            this.bCreer.Click += new System.EventHandler(this.bCreer_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lChampsObligatoires);
            this.panel.Controls.Add(this.cBCategorie);
            this.panel.Controls.Add(this.lCategorie);
            this.panel.Controls.Add(this.lTelephone);
            this.panel.Controls.Add(this.tBTelephone);
            this.panel.Controls.Add(this.lPrenom);
            this.panel.Controls.Add(this.tBPrenom);
            this.panel.Controls.Add(this.tBAdresseEmail);
            this.panel.Controls.Add(this.lAdresseEmail);
            this.panel.Controls.Add(this.lNom);
            this.panel.Controls.Add(this.tBNom);
            this.panel.Controls.Add(this.lAdressePost);
            this.panel.Controls.Add(this.tBAdressePost);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Size = new System.Drawing.Size(982, 103);
            this.panel.Controls.SetChildIndex(this.bCreer, 0);
            this.panel.Controls.SetChildIndex(this.lErreur, 0);
            this.panel.Controls.SetChildIndex(this.tBAdressePost, 0);
            this.panel.Controls.SetChildIndex(this.lAdressePost, 0);
            this.panel.Controls.SetChildIndex(this.tBNom, 0);
            this.panel.Controls.SetChildIndex(this.lNom, 0);
            this.panel.Controls.SetChildIndex(this.lAdresseEmail, 0);
            this.panel.Controls.SetChildIndex(this.tBAdresseEmail, 0);
            this.panel.Controls.SetChildIndex(this.tBPrenom, 0);
            this.panel.Controls.SetChildIndex(this.lPrenom, 0);
            this.panel.Controls.SetChildIndex(this.tBTelephone, 0);
            this.panel.Controls.SetChildIndex(this.lTelephone, 0);
            this.panel.Controls.SetChildIndex(this.lCategorie, 0);
            this.panel.Controls.SetChildIndex(this.cBCategorie, 0);
            this.panel.Controls.SetChildIndex(this.lChampsObligatoires, 0);
            // 
            // lErreur
            // 
            this.lErreur.Location = new System.Drawing.Point(849, 47);
            this.lErreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // tBAdresseEmail
            // 
            this.tBAdresseEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tBAdresseEmail.Location = new System.Drawing.Point(417, 17);
            this.tBAdresseEmail.Name = "tBAdresseEmail";
            this.tBAdresseEmail.Size = new System.Drawing.Size(203, 20);
            this.tBAdresseEmail.TabIndex = 4;
            this.tBAdresseEmail.Text = "nom.prenom@exemple.com";
            this.tBAdresseEmail.Enter += new System.EventHandler(this.tBAdresseEmail_Enter);
            // 
            // lAdresseEmail
            // 
            this.lAdresseEmail.AutoSize = true;
            this.lAdresseEmail.Location = new System.Drawing.Point(320, 20);
            this.lAdresseEmail.Name = "lAdresseEmail";
            this.lAdresseEmail.Size = new System.Drawing.Size(91, 13);
            this.lAdresseEmail.TabIndex = 24;
            this.lAdresseEmail.Text = "Adresse e-mail * : ";
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(129, 17);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(100, 20);
            this.tBNom.TabIndex = 1;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(59, 20);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(45, 13);
            this.lNom.TabIndex = 22;
            this.lNom.Text = "Nom * : ";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(59, 47);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(59, 13);
            this.lPrenom.TabIndex = 26;
            this.lPrenom.Text = "Prénom * : ";
            // 
            // tBPrenom
            // 
            this.tBPrenom.Location = new System.Drawing.Point(129, 44);
            this.tBPrenom.Name = "tBPrenom";
            this.tBPrenom.Size = new System.Drawing.Size(100, 20);
            this.tBPrenom.TabIndex = 2;
            // 
            // lTelephone
            // 
            this.lTelephone.AutoSize = true;
            this.lTelephone.Location = new System.Drawing.Point(59, 74);
            this.lTelephone.Name = "lTelephone";
            this.lTelephone.Size = new System.Drawing.Size(67, 13);
            this.lTelephone.TabIndex = 28;
            this.lTelephone.Text = "Téléphone : ";
            // 
            // tBTelephone
            // 
            this.tBTelephone.Location = new System.Drawing.Point(129, 71);
            this.tBTelephone.Name = "tBTelephone";
            this.tBTelephone.Size = new System.Drawing.Size(100, 20);
            this.tBTelephone.TabIndex = 3;
            // 
            // cBCategorie
            // 
            this.cBCategorie.FormattingEnabled = true;
            this.cBCategorie.Location = new System.Drawing.Point(396, 71);
            this.cBCategorie.Name = "cBCategorie";
            this.cBCategorie.Size = new System.Drawing.Size(224, 21);
            this.cBCategorie.TabIndex = 6;
            // 
            // lCategorie
            // 
            this.lCategorie.AutoSize = true;
            this.lCategorie.Location = new System.Drawing.Point(323, 74);
            this.lCategorie.Name = "lCategorie";
            this.lCategorie.Size = new System.Drawing.Size(68, 13);
            this.lCategorie.TabIndex = 30;
            this.lCategorie.Text = "Catégorie * : ";
            // 
            // tBAdressePost
            // 
            this.tBAdressePost.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tBAdressePost.Location = new System.Drawing.Point(417, 44);
            this.tBAdressePost.Name = "tBAdressePost";
            this.tBAdressePost.Size = new System.Drawing.Size(203, 20);
            this.tBAdressePost.TabIndex = 5;
            this.tBAdressePost.Text = "3 rue Augustin Fresnel 57073 METZ";
            this.tBAdressePost.Enter += new System.EventHandler(this.tBAdressePost_Enter);
            // 
            // lAdressePost
            // 
            this.lAdressePost.AutoSize = true;
            this.lAdressePost.Location = new System.Drawing.Point(320, 47);
            this.lAdressePost.Name = "lAdressePost";
            this.lAdressePost.Size = new System.Drawing.Size(98, 13);
            this.lAdressePost.TabIndex = 32;
            this.lAdressePost.Text = "Adresse postale * : ";
            // 
            // lChampsObligatoires
            // 
            this.lChampsObligatoires.AutoSize = true;
            this.lChampsObligatoires.Location = new System.Drawing.Point(704, 81);
            this.lChampsObligatoires.Name = "lChampsObligatoires";
            this.lChampsObligatoires.Size = new System.Drawing.Size(268, 13);
            this.lChampsObligatoires.TabIndex = 34;
            this.lChampsObligatoires.Text = "Les champs suivis d\'une astérisque (*) sont obligatoires.";
            // 
            // UC_AjoutPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_AjoutPersonnel";
            this.Size = new System.Drawing.Size(1000, 139);
            this.Load += new System.EventHandler(this.UC_AjoutPersonnel_Load);
            this.gBTitreAjout.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBAdresseEmail;
        private System.Windows.Forms.Label lAdresseEmail;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.Label lTelephone;
        private System.Windows.Forms.TextBox tBTelephone;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.TextBox tBPrenom;
        private System.Windows.Forms.ComboBox cBCategorie;
        private System.Windows.Forms.Label lCategorie;
        private System.Windows.Forms.TextBox tBAdressePost;
        private System.Windows.Forms.Label lAdressePost;
        private System.Windows.Forms.Label lChampsObligatoires;
    }
}
