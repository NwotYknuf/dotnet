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
            this.gBTitreAjout.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTitreAjout
            // 
            this.gBTitreAjout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gBTitreAjout.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gBTitreAjout.Size = new System.Drawing.Size(1325, 132);
            this.gBTitreAjout.Text = "Ajouter un personnel : ";
            // 
            // bCreer
            // 
            this.bCreer.Location = new System.Drawing.Point(1111, 21);
            this.bCreer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bCreer.Text = "Créer un personnel";
            this.bCreer.Click += new System.EventHandler(this.bCreer_Click);
            this.bCreer.MouseCaptureChanged += new System.EventHandler(this.bCreer_Click);
            // 
            // panel
            // 
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
            this.panel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel.Size = new System.Drawing.Size(1309, 100);
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
            // 
            // lErreur
            // 
            this.lErreur.Location = new System.Drawing.Point(1132, 58);
            this.lErreur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // tBAdresseEmail
            // 
            this.tBAdresseEmail.Location = new System.Drawing.Point(479, 21);
            this.tBAdresseEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBAdresseEmail.Name = "tBAdresseEmail";
            this.tBAdresseEmail.Size = new System.Drawing.Size(132, 23);
            this.tBAdresseEmail.TabIndex = 25;
            // 
            // lAdresseEmail
            // 
            this.lAdresseEmail.AutoSize = true;
            this.lAdresseEmail.Location = new System.Drawing.Point(349, 25);
            this.lAdresseEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAdresseEmail.Name = "lAdresseEmail";
            this.lAdresseEmail.Size = new System.Drawing.Size(123, 17);
            this.lAdresseEmail.TabIndex = 24;
            this.lAdresseEmail.Text = "Adresse e-mail * : ";
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(103, 21);
            this.tBNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(132, 23);
            this.tBNom.TabIndex = 23;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(23, 25);
            this.lNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(58, 17);
            this.lNom.TabIndex = 22;
            this.lNom.Text = "Nom * : ";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(23, 57);
            this.lPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(78, 17);
            this.lPrenom.TabIndex = 26;
            this.lPrenom.Text = "Prénom * : ";
            // 
            // tBPrenom
            // 
            this.tBPrenom.Location = new System.Drawing.Point(103, 53);
            this.tBPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBPrenom.Name = "tBPrenom";
            this.tBPrenom.Size = new System.Drawing.Size(132, 23);
            this.tBPrenom.TabIndex = 27;
            // 
            // lTelephone
            // 
            this.lTelephone.AutoSize = true;
            this.lTelephone.Location = new System.Drawing.Point(728, 25);
            this.lTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTelephone.Name = "lTelephone";
            this.lTelephone.Size = new System.Drawing.Size(88, 17);
            this.lTelephone.TabIndex = 28;
            this.lTelephone.Text = "Téléphone : ";
            // 
            // tBTelephone
            // 
            this.tBTelephone.Location = new System.Drawing.Point(825, 21);
            this.tBTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBTelephone.Name = "tBTelephone";
            this.tBTelephone.Size = new System.Drawing.Size(132, 23);
            this.tBTelephone.TabIndex = 29;
            // 
            // cBCategorie
            // 
            this.cBCategorie.FormattingEnabled = true;
            this.cBCategorie.Location = new System.Drawing.Point(825, 53);
            this.cBCategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBCategorie.Name = "cBCategorie";
            this.cBCategorie.Size = new System.Drawing.Size(160, 25);
            this.cBCategorie.TabIndex = 31;
            // 
            // lCategorie
            // 
            this.lCategorie.AutoSize = true;
            this.lCategorie.Location = new System.Drawing.Point(728, 57);
            this.lCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCategorie.Name = "lCategorie";
            this.lCategorie.Size = new System.Drawing.Size(81, 17);
            this.lCategorie.TabIndex = 30;
            this.lCategorie.Text = "Catégorie : ";
            // 
            // tBAdressePost
            // 
            this.tBAdressePost.Location = new System.Drawing.Point(479, 53);
            this.tBAdressePost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBAdressePost.Name = "tBAdressePost";
            this.tBAdressePost.Size = new System.Drawing.Size(132, 23);
            this.tBAdressePost.TabIndex = 33;
            // 
            // lAdressePost
            // 
            this.lAdressePost.AutoSize = true;
            this.lAdressePost.Location = new System.Drawing.Point(349, 57);
            this.lAdressePost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAdressePost.Name = "lAdressePost";
            this.lAdressePost.Size = new System.Drawing.Size(131, 17);
            this.lAdressePost.TabIndex = 32;
            this.lAdressePost.Text = "Adresse postale * : ";
            // 
            // UC_AjoutPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_AjoutPersonnel";
            this.Size = new System.Drawing.Size(1333, 135);
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
    }
}
