namespace dotnet
{
    partial class UCAnnee
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
            this.gbAnnee = new System.Windows.Forms.GroupBox();
            this.gbAjout = new System.Windows.Forms.GroupBox();
            this.bCreerAnnee = new System.Windows.Forms.Button();
            this.lNomAnnee = new System.Windows.Forms.Label();
            this.tbAnnee = new System.Windows.Forms.TextBox();
            this.gbAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnnee
            // 
            this.gbAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnnee.Location = new System.Drawing.Point(69, 153);
            this.gbAnnee.Name = "gbAnnee";
            this.gbAnnee.Size = new System.Drawing.Size(975, 382);
            this.gbAnnee.TabIndex = 12;
            this.gbAnnee.TabStop = false;
            this.gbAnnee.Text = "Années : ";
            // 
            // gbAjout
            // 
            this.gbAjout.Controls.Add(this.tbAnnee);
            this.gbAjout.Controls.Add(this.bCreerAnnee);
            this.gbAjout.Controls.Add(this.lNomAnnee);
            this.gbAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjout.Location = new System.Drawing.Point(69, 25);
            this.gbAjout.Name = "gbAjout";
            this.gbAjout.Size = new System.Drawing.Size(337, 100);
            this.gbAjout.TabIndex = 11;
            this.gbAjout.TabStop = false;
            this.gbAjout.Text = "Ajouter une année : ";
            // 
            // bCreerAnnee
            // 
            this.bCreerAnnee.AutoSize = true;
            this.bCreerAnnee.Location = new System.Drawing.Point(207, 37);
            this.bCreerAnnee.Name = "bCreerAnnee";
            this.bCreerAnnee.Size = new System.Drawing.Size(117, 26);
            this.bCreerAnnee.TabIndex = 1;
            this.bCreerAnnee.Text = "Créer l\'année";
            this.bCreerAnnee.UseVisualStyleBackColor = true;
            // 
            // lNomAnnee
            // 
            this.lNomAnnee.AutoSize = true;
            this.lNomAnnee.Location = new System.Drawing.Point(6, 42);
            this.lNomAnnee.Name = "lNomAnnee";
            this.lNomAnnee.Size = new System.Drawing.Size(46, 16);
            this.lNomAnnee.TabIndex = 4;
            this.lNomAnnee.Text = "Nom : ";
            // 
            // tbAnnee
            // 
            this.tbAnnee.Location = new System.Drawing.Point(46, 39);
            this.tbAnnee.Name = "tbAnnee";
            this.tbAnnee.Size = new System.Drawing.Size(100, 22);
            this.tbAnnee.TabIndex = 3;
            // 
            // UCAnnee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAnnee);
            this.Controls.Add(this.gbAjout);
            this.Name = "UCAnnee";
            this.Size = new System.Drawing.Size(1112, 561);
            this.gbAjout.ResumeLayout(false);
            this.gbAjout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnnee;
        private System.Windows.Forms.GroupBox gbAjout;
        private System.Windows.Forms.Button bCreerAnnee;
        private System.Windows.Forms.Label lNomAnnee;
        private System.Windows.Forms.TextBox tbAnnee;
    }
}
