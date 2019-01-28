namespace dotnet
{
    partial class UCListeUE
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
            this.gbUE = new System.Windows.Forms.GroupBox();
            this.gbAjout = new System.Windows.Forms.GroupBox();
            this.bCreerUE = new System.Windows.Forms.Button();
            this.lNomUE = new System.Windows.Forms.Label();
            this.tbUE = new System.Windows.Forms.TextBox();
            this.gbAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUE
            // 
            this.gbUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUE.Location = new System.Drawing.Point(69, 153);
            this.gbUE.Name = "gbUE";
            this.gbUE.Size = new System.Drawing.Size(976, 382);
            this.gbUE.TabIndex = 14;
            this.gbUE.TabStop = false;
            this.gbUE.Text = "UE : ";
            // 
            // gbAjout
            // 
            this.gbAjout.Controls.Add(this.tbUE);
            this.gbAjout.Controls.Add(this.bCreerUE);
            this.gbAjout.Controls.Add(this.lNomUE);
            this.gbAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjout.Location = new System.Drawing.Point(69, 25);
            this.gbAjout.Name = "gbAjout";
            this.gbAjout.Size = new System.Drawing.Size(337, 100);
            this.gbAjout.TabIndex = 13;
            this.gbAjout.TabStop = false;
            this.gbAjout.Text = "Ajouter une UE : ";
            // 
            // bCreerUE
            // 
            this.bCreerUE.AutoSize = true;
            this.bCreerUE.Location = new System.Drawing.Point(207, 37);
            this.bCreerUE.Name = "bCreerUE";
            this.bCreerUE.Size = new System.Drawing.Size(124, 26);
            this.bCreerUE.TabIndex = 1;
            this.bCreerUE.Text = "Créer la période : ";
            this.bCreerUE.UseVisualStyleBackColor = true;
            // 
            // lNomUE
            // 
            this.lNomUE.AutoSize = true;
            this.lNomUE.Location = new System.Drawing.Point(6, 42);
            this.lNomUE.Name = "lNomUE";
            this.lNomUE.Size = new System.Drawing.Size(46, 16);
            this.lNomUE.TabIndex = 4;
            this.lNomUE.Text = "Nom : ";
            // 
            // tbUE
            // 
            this.tbUE.Location = new System.Drawing.Point(46, 39);
            this.tbUE.Name = "tbUE";
            this.tbUE.Size = new System.Drawing.Size(100, 22);
            this.tbUE.TabIndex = 3;
            // 
            // UCListeUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbUE);
            this.Controls.Add(this.gbAjout);
            this.Name = "UCListeUE";
            this.Size = new System.Drawing.Size(1112, 561);
            this.gbAjout.ResumeLayout(false);
            this.gbAjout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUE;
        private System.Windows.Forms.GroupBox gbAjout;
        private System.Windows.Forms.Button bCreerUE;
        private System.Windows.Forms.Label lNomUE;
        private System.Windows.Forms.TextBox tbUE;
    }
}
