namespace dotnet
{
    partial class UCPeriode
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
            this.gbPeriode = new System.Windows.Forms.GroupBox();
            this.gbAjout = new System.Windows.Forms.GroupBox();
            this.bCreerPeriode = new System.Windows.Forms.Button();
            this.lNomPeriode = new System.Windows.Forms.Label();
            this.tbPeriode = new System.Windows.Forms.TextBox();
            this.gbAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPeriode
            // 
            this.gbPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeriode.Location = new System.Drawing.Point(69, 153);
            this.gbPeriode.Name = "gbPeriode";
            this.gbPeriode.Size = new System.Drawing.Size(975, 382);
            this.gbPeriode.TabIndex = 12;
            this.gbPeriode.TabStop = false;
            this.gbPeriode.Text = "Périodes : ";
            // 
            // gbAjout
            // 
            this.gbAjout.Controls.Add(this.tbPeriode);
            this.gbAjout.Controls.Add(this.bCreerPeriode);
            this.gbAjout.Controls.Add(this.lNomPeriode);
            this.gbAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjout.Location = new System.Drawing.Point(69, 25);
            this.gbAjout.Name = "gbAjout";
            this.gbAjout.Size = new System.Drawing.Size(337, 100);
            this.gbAjout.TabIndex = 11;
            this.gbAjout.TabStop = false;
            this.gbAjout.Text = "Ajouter une période : ";
            // 
            // bCreerPeriode
            // 
            this.bCreerPeriode.AutoSize = true;
            this.bCreerPeriode.Location = new System.Drawing.Point(207, 37);
            this.bCreerPeriode.Name = "bCreerPeriode";
            this.bCreerPeriode.Size = new System.Drawing.Size(124, 26);
            this.bCreerPeriode.TabIndex = 1;
            this.bCreerPeriode.Text = "Créer la période : ";
            this.bCreerPeriode.UseVisualStyleBackColor = true;
            // 
            // lNomPeriode
            // 
            this.lNomPeriode.AutoSize = true;
            this.lNomPeriode.Location = new System.Drawing.Point(6, 42);
            this.lNomPeriode.Name = "lNomPeriode";
            this.lNomPeriode.Size = new System.Drawing.Size(46, 16);
            this.lNomPeriode.TabIndex = 4;
            this.lNomPeriode.Text = "Nom : ";
            // 
            // tbPeriode
            // 
            this.tbPeriode.Location = new System.Drawing.Point(46, 39);
            this.tbPeriode.Name = "tbPeriode";
            this.tbPeriode.Size = new System.Drawing.Size(100, 22);
            this.tbPeriode.TabIndex = 3;
            // 
            // UCPeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPeriode);
            this.Controls.Add(this.gbAjout);
            this.Name = "UCPeriode";
            this.Size = new System.Drawing.Size(1112, 561);
            this.gbAjout.ResumeLayout(false);
            this.gbAjout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPeriode;
        private System.Windows.Forms.GroupBox gbAjout;
        private System.Windows.Forms.Button bCreerPeriode;
        private System.Windows.Forms.Label lNomPeriode;
        private System.Windows.Forms.TextBox tbPeriode;
    }
}
