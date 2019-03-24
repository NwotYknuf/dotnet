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
            this.lPrenom = new System.Windows.Forms.Label();
            this.tBPrenom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.lCategorie = new System.Windows.Forms.Label();
            this.tBCategorie = new System.Windows.Forms.TextBox();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tBCategorie);
            this.panel.Controls.Add(this.lCategorie);
            this.panel.Controls.Add(this.lPrenom);
            this.panel.Controls.Add(this.tBPrenom);
            this.panel.Controls.Add(this.lNom);
            this.panel.Controls.Add(this.tBNom);
            this.panel.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            this.panel.Controls.SetChildIndex(this.tBNom, 0);
            this.panel.Controls.SetChildIndex(this.lNom, 0);
            this.panel.Controls.SetChildIndex(this.tBPrenom, 0);
            this.panel.Controls.SetChildIndex(this.lPrenom, 0);
            this.panel.Controls.SetChildIndex(this.lCategorie, 0);
            this.panel.Controls.SetChildIndex(this.tBCategorie, 0);
            this.panel.Controls.SetChildIndex(this.pBSupprimer, 0);
            this.panel.Controls.SetChildIndex(this.pBModifier, 0);
            // 
            // pBModifier
            // 
            this.pBModifier.Click += new System.EventHandler(this.pBModifier_Click);
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Click += new System.EventHandler(this.pBSupprimer_Click);
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(255, 14);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(52, 13);
            this.lPrenom.TabIndex = 30;
            this.lPrenom.Text = "Prénom : ";
            // 
            // tBPrenom
            // 
            this.tBPrenom.Enabled = false;
            this.tBPrenom.Location = new System.Drawing.Point(321, 11);
            this.tBPrenom.Name = "tBPrenom";
            this.tBPrenom.Size = new System.Drawing.Size(100, 20);
            this.tBPrenom.TabIndex = 31;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(29, 14);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(38, 13);
            this.lNom.TabIndex = 28;
            this.lNom.Text = "Nom : ";
            // 
            // tBNom
            // 
            this.tBNom.Enabled = false;
            this.tBNom.Location = new System.Drawing.Point(79, 11);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(100, 20);
            this.tBNom.TabIndex = 29;
            // 
            // lCategorie
            // 
            this.lCategorie.AutoSize = true;
            this.lCategorie.Location = new System.Drawing.Point(506, 14);
            this.lCategorie.Name = "lCategorie";
            this.lCategorie.Size = new System.Drawing.Size(61, 13);
            this.lCategorie.TabIndex = 32;
            this.lCategorie.Text = "Catégorie : ";
            // 
            // tBCategorie
            // 
            this.tBCategorie.Enabled = false;
            this.tBCategorie.Location = new System.Drawing.Point(583, 11);
            this.tBCategorie.Name = "tBCategorie";
            this.tBCategorie.Size = new System.Drawing.Size(100, 20);
            this.tBCategorie.TabIndex = 33;
            // 
            // UC_ElementPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementPersonnel";
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
        private System.Windows.Forms.TextBox tBCategorie;
        private System.Windows.Forms.Label lCategorie;
    }
}
