namespace dotnet
{
    partial class UC_Element
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
            this.gBAffElement = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.gBAffElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBAffElement
            // 
            this.gBAffElement.Controls.Add(this.panel);
            this.gBAffElement.Location = new System.Drawing.Point(3, 0);
            this.gBAffElement.Name = "gBAffElement";
            this.gBAffElement.Size = new System.Drawing.Size(951, 147);
            this.gBAffElement.TabIndex = 0;
            this.gBAffElement.TabStop = false;
            this.gBAffElement.Text = "TitreElement";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(6, 17);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(938, 124);
            this.panel.TabIndex = 0;
            // 
            // UC_Element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBAffElement);
            this.Name = "UC_Element";
            this.Size = new System.Drawing.Size(955, 150);
            this.gBAffElement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox gBAffElement;
        protected System.Windows.Forms.Panel panel;
    }
}
