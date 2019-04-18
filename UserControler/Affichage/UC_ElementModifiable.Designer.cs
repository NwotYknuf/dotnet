namespace dotnet.UserControler.Affichage
{
    partial class UC_ElementModifiable
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBModifier = new System.Windows.Forms.PictureBox();
            this.pBSupprimer = new System.Windows.Forms.PictureBox();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pBModifier);
            this.panel.Controls.Add(this.pBSupprimer);
            // 
            // pBModifier
            // 
            this.pBModifier.Image = global::dotnet.Properties.Resources.modifier;
            this.pBModifier.InitialImage = null;
            this.pBModifier.Location = new System.Drawing.Point(856, 2);
            this.pBModifier.Name = "pBModifier";
            this.pBModifier.Size = new System.Drawing.Size(37, 37);
            this.pBModifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBModifier.TabIndex = 3;
            this.pBModifier.TabStop = false;
            this.pBModifier.MouseEnter += new System.EventHandler(this.pBModifier_MouseEnter);
            this.pBModifier.MouseLeave += new System.EventHandler(this.pBModifier_MouseLeave);
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Image = global::dotnet.Properties.Resources.supprimer;
            this.pBSupprimer.InitialImage = null;
            this.pBSupprimer.Location = new System.Drawing.Point(895, 2);
            this.pBSupprimer.Name = "pBSupprimer";
            this.pBSupprimer.Size = new System.Drawing.Size(37, 37);
            this.pBSupprimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSupprimer.TabIndex = 2;
            this.pBSupprimer.TabStop = false;
            this.pBSupprimer.MouseEnter += new System.EventHandler(this.pBSupprimer_MouseEnter);
            this.pBSupprimer.MouseLeave += new System.EventHandler(this.pBSupprimer_MouseLeave);
            // 
            // UC_ElementModifiable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementModifiable";
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.PictureBox pBModifier;
        protected System.Windows.Forms.PictureBox pBSupprimer;
    }
}
