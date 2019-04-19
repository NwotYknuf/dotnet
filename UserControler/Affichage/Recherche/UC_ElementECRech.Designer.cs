namespace dotnet.UserControler.Affichage.Recherche
{
    partial class UC_ElementECRech
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
            this.cB_ECActive = new System.Windows.Forms.CheckBox();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.lDescAnnee = new System.Windows.Forms.Label();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cB_ECActive);
            this.panel.Controls.Add(this.lDescAnnee);
            this.panel.Controls.Add(this.tBDesc);
            this.panel.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            this.panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            this.panel.MouseHover += new System.EventHandler(this.panel_MouseHover);
            // 
            // cB_ECActive
            // 
            this.cB_ECActive.AutoSize = true;
            this.cB_ECActive.BackColor = System.Drawing.Color.Transparent;
            this.cB_ECActive.Checked = true;
            this.cB_ECActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_ECActive.Enabled = false;
            this.cB_ECActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB_ECActive.Location = new System.Drawing.Point(767, 25);
            this.cB_ECActive.Name = "cB_ECActive";
            this.cB_ECActive.Size = new System.Drawing.Size(53, 17);
            this.cB_ECActive.TabIndex = 10;
            this.cB_ECActive.Text = "Active";
            this.cB_ECActive.UseVisualStyleBackColor = false;
            // 
            // tBDesc
            // 
            this.tBDesc.Enabled = false;
            this.tBDesc.Location = new System.Drawing.Point(99, 23);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(649, 20);
            this.tBDesc.TabIndex = 9;
            // 
            // lDescAnnee
            // 
            this.lDescAnnee.AutoSize = true;
            this.lDescAnnee.Location = new System.Drawing.Point(24, 26);
            this.lDescAnnee.Name = "lDescAnnee";
            this.lDescAnnee.Size = new System.Drawing.Size(69, 13);
            this.lDescAnnee.TabIndex = 8;
            this.lDescAnnee.Text = "Description : ";
            // 
            // UC_ElementECRech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementECRech";
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cB_ECActive;
        private System.Windows.Forms.Label lDescAnnee;
        private System.Windows.Forms.TextBox tBDesc;
    }
}
