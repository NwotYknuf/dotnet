namespace dotnet.UserControler.Affichage.Accueil
{
    partial class UC_ElementLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            this.SuspendLayout();
            // 
            // gBAffElement
            // 
            this.gBAffElement.Size = new System.Drawing.Size(477, 65);
            this.gBAffElement.Text = "";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(6, 14);
            this.panel.Size = new System.Drawing.Size(465, 43);
            this.panel.Controls.SetChildIndex(this.pBSupprimer, 0);
            this.panel.Controls.SetChildIndex(this.pBModifier, 0);
            this.panel.Controls.SetChildIndex(this.label1, 0);
            // 
            // pBModifier
            // 
            this.pBModifier.Location = new System.Drawing.Point(383, 3);
            this.pBModifier.Visible = false;
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Location = new System.Drawing.Point(426, 3);
            this.pBSupprimer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tout est en ordre ! ";
            // 
            // UC_ElementLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementLabel";
            this.Size = new System.Drawing.Size(484, 67);
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}
