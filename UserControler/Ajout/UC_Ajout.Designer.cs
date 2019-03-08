namespace dotnet
{
    partial class UC_Ajout
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.bCreer = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.bCreer);
            this.groupBox.Controls.Add(this.panel);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(569, 150);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox1";
            // 
            // bCreer
            // 
            this.bCreer.AutoSize = true;
            this.bCreer.Location = new System.Drawing.Point(446, 118);
            this.bCreer.Name = "bCreer";
            this.bCreer.Size = new System.Drawing.Size(117, 26);
            this.bCreer.TabIndex = 2;
            this.bCreer.Text = "Créer";
            this.bCreer.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(7, 20);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(556, 124);
            this.panel.TabIndex = 3;
            // 
            // UC_Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "UC_Ajout";
            this.Size = new System.Drawing.Size(569, 150);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox;
        protected System.Windows.Forms.Button bCreer;
        protected System.Windows.Forms.Panel panel;
    }
}
