namespace dotnet.UserControler.Affichage.Accueil
{
    partial class UC_ElementPersonnelAccueil
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
            this.lPrenom = new System.Windows.Forms.Label();
            this.tBPrenom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.tBNbHeuresAttrib = new System.Windows.Forms.TextBox();
            this.tBNbHeuresNonAttrib = new System.Windows.Forms.TextBox();
            this.lNbHeuresNonAttrib = new System.Windows.Forms.Label();
            this.lNbHeuresAttrib = new System.Windows.Forms.Label();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            this.SuspendLayout();
            // 
            // gBAffElement
            // 
            this.gBAffElement.Size = new System.Drawing.Size(477, 114);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tBNbHeuresAttrib);
            this.panel.Controls.Add(this.tBNbHeuresNonAttrib);
            this.panel.Controls.Add(this.lNbHeuresNonAttrib);
            this.panel.Controls.Add(this.lNbHeuresAttrib);
            this.panel.Controls.Add(this.lPrenom);
            this.panel.Controls.Add(this.tBPrenom);
            this.panel.Controls.Add(this.lNom);
            this.panel.Controls.Add(this.tBNom);
            this.panel.Size = new System.Drawing.Size(465, 90);
            this.panel.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            this.panel.Controls.SetChildIndex(this.pBSupprimer, 0);
            this.panel.Controls.SetChildIndex(this.pBModifier, 0);
            this.panel.Controls.SetChildIndex(this.tBNom, 0);
            this.panel.Controls.SetChildIndex(this.lNom, 0);
            this.panel.Controls.SetChildIndex(this.tBPrenom, 0);
            this.panel.Controls.SetChildIndex(this.lPrenom, 0);
            this.panel.Controls.SetChildIndex(this.lNbHeuresAttrib, 0);
            this.panel.Controls.SetChildIndex(this.lNbHeuresNonAttrib, 0);
            this.panel.Controls.SetChildIndex(this.tBNbHeuresNonAttrib, 0);
            this.panel.Controls.SetChildIndex(this.tBNbHeuresAttrib, 0);
            // 
            // pBModifier
            // 
            this.pBModifier.Location = new System.Drawing.Point(423, 6);
            this.pBModifier.Click += new System.EventHandler(this.pBModifier_Click);
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Location = new System.Drawing.Point(424, 49);
            this.pBSupprimer.Click += new System.EventHandler(this.pBSupprimer_Click);
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(13, 49);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(52, 13);
            this.lPrenom.TabIndex = 36;
            this.lPrenom.Text = "Prénom : ";
            // 
            // tBPrenom
            // 
            this.tBPrenom.Enabled = false;
            this.tBPrenom.Location = new System.Drawing.Point(67, 46);
            this.tBPrenom.Name = "tBPrenom";
            this.tBPrenom.Size = new System.Drawing.Size(100, 20);
            this.tBPrenom.TabIndex = 37;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(13, 27);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(38, 13);
            this.lNom.TabIndex = 34;
            this.lNom.Text = "Nom : ";
            // 
            // tBNom
            // 
            this.tBNom.Enabled = false;
            this.tBNom.Location = new System.Drawing.Point(67, 20);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(100, 20);
            this.tBNom.TabIndex = 35;
            // 
            // tBNbHeuresAttrib
            // 
            this.tBNbHeuresAttrib.Location = new System.Drawing.Point(305, 20);
            this.tBNbHeuresAttrib.Name = "tBNbHeuresAttrib";
            this.tBNbHeuresAttrib.Size = new System.Drawing.Size(66, 20);
            this.tBNbHeuresAttrib.TabIndex = 49;
            // 
            // tBNbHeuresNonAttrib
            // 
            this.tBNbHeuresNonAttrib.Location = new System.Drawing.Point(305, 46);
            this.tBNbHeuresNonAttrib.Name = "tBNbHeuresNonAttrib";
            this.tBNbHeuresNonAttrib.Size = new System.Drawing.Size(66, 20);
            this.tBNbHeuresNonAttrib.TabIndex = 50;
            // 
            // lNbHeuresNonAttrib
            // 
            this.lNbHeuresNonAttrib.AutoSize = true;
            this.lNbHeuresNonAttrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNbHeuresNonAttrib.Location = new System.Drawing.Point(182, 51);
            this.lNbHeuresNonAttrib.Name = "lNbHeuresNonAttrib";
            this.lNbHeuresNonAttrib.Size = new System.Drawing.Size(120, 13);
            this.lNbHeuresNonAttrib.TabIndex = 48;
            this.lNbHeuresNonAttrib.Text = "Heures non attribuées : ";
            // 
            // lNbHeuresAttrib
            // 
            this.lNbHeuresAttrib.AutoSize = true;
            this.lNbHeuresAttrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNbHeuresAttrib.Location = new System.Drawing.Point(182, 27);
            this.lNbHeuresAttrib.Name = "lNbHeuresAttrib";
            this.lNbHeuresAttrib.Size = new System.Drawing.Size(99, 13);
            this.lNbHeuresAttrib.TabIndex = 47;
            this.lNbHeuresAttrib.Text = "Heures attribuées : ";
            // 
            // UC_ElementPersonnelAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementPersonnelAccueil";
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.TextBox tBPrenom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.TextBox tBNbHeuresAttrib;
        private System.Windows.Forms.TextBox tBNbHeuresNonAttrib;
        private System.Windows.Forms.Label lNbHeuresNonAttrib;
        private System.Windows.Forms.Label lNbHeuresAttrib;
    }
}
