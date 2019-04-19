namespace dotnet.UserControler.Affichage.Personnel
{
    partial class UC_ElementPersonnel
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
            this.tBCategorie = new System.Windows.Forms.TextBox();
            this.tBNbHeuresAttrib = new System.Windows.Forms.TextBox();
            this.tBNbHeuresNonAttrib = new System.Windows.Forms.TextBox();
            this.lCategorie = new System.Windows.Forms.Label();
            this.lTelephone = new System.Windows.Forms.Label();
            this.tBTelephone = new System.Windows.Forms.TextBox();
            this.lPrenom = new System.Windows.Forms.Label();
            this.tBPrenom = new System.Windows.Forms.TextBox();
            this.tBAdresseEmail = new System.Windows.Forms.TextBox();
            this.lAdresseEmail = new System.Windows.Forms.Label();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.lAdressePost = new System.Windows.Forms.Label();
            this.tBAdressePost = new System.Windows.Forms.TextBox();
            this.lNbHeuresNonAttrib = new System.Windows.Forms.Label();
            this.lNbHeuresAttrib = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBModifier
            // 
            this.pBModifier.Location = new System.Drawing.Point(897, 9);
            this.pBModifier.Click += new System.EventHandler(this.pBModifier_Click);
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Location = new System.Drawing.Point(898, 53);
            this.pBSupprimer.Click += new System.EventHandler(this.pBSupprimer_Click);
            // 
            // gBAffElement
            // 
            this.gBAffElement.Size = new System.Drawing.Size(951, 121);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tBCategorie);
            this.panel.Controls.Add(this.tBNbHeuresAttrib);
            this.panel.Controls.Add(this.tBNbHeuresNonAttrib);
            this.panel.Controls.Add(this.lCategorie);
            this.panel.Controls.Add(this.lTelephone);
            this.panel.Controls.Add(this.tBTelephone);
            this.panel.Controls.Add(this.lPrenom);
            this.panel.Controls.Add(this.tBPrenom);
            this.panel.Controls.Add(this.tBAdresseEmail);
            this.panel.Controls.Add(this.lAdresseEmail);
            this.panel.Controls.Add(this.tBNom);
            this.panel.Controls.Add(this.lAdressePost);
            this.panel.Controls.Add(this.tBAdressePost);
            this.panel.Controls.Add(this.lNbHeuresNonAttrib);
            this.panel.Controls.Add(this.lNbHeuresAttrib);
            this.panel.Controls.Add(this.lNom);
            this.panel.Size = new System.Drawing.Size(938, 98);
            this.panel.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            this.panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            this.panel.MouseHover += new System.EventHandler(this.panel_MouseHover);
            this.panel.Controls.SetChildIndex(this.pBSupprimer, 0);
            this.panel.Controls.SetChildIndex(this.pBModifier, 0);
            this.panel.Controls.SetChildIndex(this.lNom, 0);
            this.panel.Controls.SetChildIndex(this.lNbHeuresAttrib, 0);
            this.panel.Controls.SetChildIndex(this.lNbHeuresNonAttrib, 0);
            this.panel.Controls.SetChildIndex(this.tBAdressePost, 0);
            this.panel.Controls.SetChildIndex(this.lAdressePost, 0);
            this.panel.Controls.SetChildIndex(this.tBNom, 0);
            this.panel.Controls.SetChildIndex(this.lAdresseEmail, 0);
            this.panel.Controls.SetChildIndex(this.tBAdresseEmail, 0);
            this.panel.Controls.SetChildIndex(this.tBPrenom, 0);
            this.panel.Controls.SetChildIndex(this.lPrenom, 0);
            this.panel.Controls.SetChildIndex(this.tBTelephone, 0);
            this.panel.Controls.SetChildIndex(this.lTelephone, 0);
            this.panel.Controls.SetChildIndex(this.lCategorie, 0);
            this.panel.Controls.SetChildIndex(this.tBNbHeuresNonAttrib, 0);
            this.panel.Controls.SetChildIndex(this.tBNbHeuresAttrib, 0);
            this.panel.Controls.SetChildIndex(this.tBCategorie, 0);
            // 
            // tBCategorie
            // 
            this.tBCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCategorie.Location = new System.Drawing.Point(322, 62);
            this.tBCategorie.Name = "tBCategorie";
            this.tBCategorie.Size = new System.Drawing.Size(175, 20);
            this.tBCategorie.TabIndex = 63;
            // 
            // tBNbHeuresAttrib
            // 
            this.tBNbHeuresAttrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNbHeuresAttrib.Location = new System.Drawing.Point(669, 10);
            this.tBNbHeuresAttrib.Name = "tBNbHeuresAttrib";
            this.tBNbHeuresAttrib.Size = new System.Drawing.Size(100, 20);
            this.tBNbHeuresAttrib.TabIndex = 61;
            // 
            // tBNbHeuresNonAttrib
            // 
            this.tBNbHeuresNonAttrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNbHeuresNonAttrib.Location = new System.Drawing.Point(669, 36);
            this.tBNbHeuresNonAttrib.Name = "tBNbHeuresNonAttrib";
            this.tBNbHeuresNonAttrib.Size = new System.Drawing.Size(100, 20);
            this.tBNbHeuresNonAttrib.TabIndex = 62;
            // 
            // lCategorie
            // 
            this.lCategorie.AutoSize = true;
            this.lCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCategorie.Location = new System.Drawing.Point(228, 69);
            this.lCategorie.Name = "lCategorie";
            this.lCategorie.Size = new System.Drawing.Size(61, 13);
            this.lCategorie.TabIndex = 58;
            this.lCategorie.Text = "Catégorie : ";
            // 
            // lTelephone
            // 
            this.lTelephone.AutoSize = true;
            this.lTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelephone.Location = new System.Drawing.Point(12, 67);
            this.lTelephone.Name = "lTelephone";
            this.lTelephone.Size = new System.Drawing.Size(67, 13);
            this.lTelephone.TabIndex = 56;
            this.lTelephone.Text = "Téléphone : ";
            // 
            // tBTelephone
            // 
            this.tBTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTelephone.Location = new System.Drawing.Point(85, 64);
            this.tBTelephone.Name = "tBTelephone";
            this.tBTelephone.Size = new System.Drawing.Size(100, 20);
            this.tBTelephone.TabIndex = 57;
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrenom.Location = new System.Drawing.Point(12, 41);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(52, 13);
            this.lPrenom.TabIndex = 54;
            this.lPrenom.Text = "Prénom : ";
            // 
            // tBPrenom
            // 
            this.tBPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPrenom.Location = new System.Drawing.Point(85, 38);
            this.tBPrenom.Name = "tBPrenom";
            this.tBPrenom.Size = new System.Drawing.Size(100, 20);
            this.tBPrenom.TabIndex = 55;
            // 
            // tBAdresseEmail
            // 
            this.tBAdresseEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAdresseEmail.Location = new System.Drawing.Point(322, 12);
            this.tBAdresseEmail.Name = "tBAdresseEmail";
            this.tBAdresseEmail.Size = new System.Drawing.Size(175, 20);
            this.tBAdresseEmail.TabIndex = 53;
            // 
            // lAdresseEmail
            // 
            this.lAdresseEmail.AutoSize = true;
            this.lAdresseEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAdresseEmail.Location = new System.Drawing.Point(225, 15);
            this.lAdresseEmail.Name = "lAdresseEmail";
            this.lAdresseEmail.Size = new System.Drawing.Size(84, 13);
            this.lAdresseEmail.TabIndex = 52;
            this.lAdresseEmail.Text = "Adresse e-mail : ";
            // 
            // tBNom
            // 
            this.tBNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNom.Location = new System.Drawing.Point(85, 12);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(100, 20);
            this.tBNom.TabIndex = 51;
            // 
            // lAdressePost
            // 
            this.lAdressePost.AutoSize = true;
            this.lAdressePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAdressePost.Location = new System.Drawing.Point(225, 41);
            this.lAdressePost.Name = "lAdressePost";
            this.lAdressePost.Size = new System.Drawing.Size(91, 13);
            this.lAdressePost.TabIndex = 59;
            this.lAdressePost.Text = "Adresse postale : ";
            // 
            // tBAdressePost
            // 
            this.tBAdressePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAdressePost.Location = new System.Drawing.Point(322, 38);
            this.tBAdressePost.Name = "tBAdressePost";
            this.tBAdressePost.Size = new System.Drawing.Size(175, 20);
            this.tBAdressePost.TabIndex = 60;
            // 
            // lNbHeuresNonAttrib
            // 
            this.lNbHeuresNonAttrib.AutoSize = true;
            this.lNbHeuresNonAttrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNbHeuresNonAttrib.Location = new System.Drawing.Point(540, 41);
            this.lNbHeuresNonAttrib.Name = "lNbHeuresNonAttrib";
            this.lNbHeuresNonAttrib.Size = new System.Drawing.Size(120, 13);
            this.lNbHeuresNonAttrib.TabIndex = 50;
            this.lNbHeuresNonAttrib.Text = "Heures non attribuées : ";
            // 
            // lNbHeuresAttrib
            // 
            this.lNbHeuresAttrib.AutoSize = true;
            this.lNbHeuresAttrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNbHeuresAttrib.Location = new System.Drawing.Point(540, 17);
            this.lNbHeuresAttrib.Name = "lNbHeuresAttrib";
            this.lNbHeuresAttrib.Size = new System.Drawing.Size(99, 13);
            this.lNbHeuresAttrib.TabIndex = 49;
            this.lNbHeuresAttrib.Text = "Heures attribuées : ";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNom.Location = new System.Drawing.Point(12, 12);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(38, 13);
            this.lNom.TabIndex = 48;
            this.lNom.Text = "Nom : ";
            // 
            // UC_ElementPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementPersonnel";
            this.Size = new System.Drawing.Size(955, 124);
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBCategorie;
        private System.Windows.Forms.TextBox tBNbHeuresAttrib;
        private System.Windows.Forms.TextBox tBNbHeuresNonAttrib;
        private System.Windows.Forms.Label lCategorie;
        private System.Windows.Forms.Label lTelephone;
        private System.Windows.Forms.TextBox tBTelephone;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.TextBox tBPrenom;
        private System.Windows.Forms.TextBox tBAdresseEmail;
        private System.Windows.Forms.Label lAdresseEmail;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.Label lAdressePost;
        private System.Windows.Forms.TextBox tBAdressePost;
        private System.Windows.Forms.Label lNbHeuresNonAttrib;
        private System.Windows.Forms.Label lNbHeuresAttrib;
        private System.Windows.Forms.Label lNom;
    }
}
