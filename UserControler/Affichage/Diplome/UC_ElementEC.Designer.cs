namespace dotnet.UserControler.Affichage
{
    partial class UC_ElementEC
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
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.lDescAnnee = new System.Windows.Forms.Label();
            this.cB_ECActive = new System.Windows.Forms.CheckBox();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cB_ECActive);
            this.panel.Controls.Add(this.tBDesc);
            this.panel.Controls.Add(this.lDescAnnee);
            this.panel.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            this.panel.Controls.SetChildIndex(this.lDescAnnee, 0);
            this.panel.Controls.SetChildIndex(this.tBDesc, 0);
            this.panel.Controls.SetChildIndex(this.pBSupprimer, 0);
            this.panel.Controls.SetChildIndex(this.pBModifier, 0);
            this.panel.Controls.SetChildIndex(this.cB_ECActive, 0);
            // 
            // pBModifier
            // 
            this.pBModifier.Click += new System.EventHandler(this.pBModifier_Click);
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Click += new System.EventHandler(this.pBSupprimer_Click);
            // 
            // tBDesc
            // 
            this.tBDesc.Enabled = false;
            this.tBDesc.Location = new System.Drawing.Point(99, 12);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(649, 20);
            this.tBDesc.TabIndex = 6;
            // 
            // lDescAnnee
            // 
            this.lDescAnnee.AutoSize = true;
            this.lDescAnnee.Location = new System.Drawing.Point(24, 15);
            this.lDescAnnee.Name = "lDescAnnee";
            this.lDescAnnee.Size = new System.Drawing.Size(69, 13);
            this.lDescAnnee.TabIndex = 5;
            this.lDescAnnee.Text = "Description : ";
            // 
            // cB_ECActive
            // 
            this.cB_ECActive.AutoSize = true;
            this.cB_ECActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cB_ECActive.Checked = true;
            this.cB_ECActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_ECActive.Enabled = false;
            this.cB_ECActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB_ECActive.Location = new System.Drawing.Point(767, 14);
            this.cB_ECActive.Name = "cB_ECActive";
            this.cB_ECActive.Size = new System.Drawing.Size(62, 17);
            this.cB_ECActive.TabIndex = 7;
            this.cB_ECActive.Text = "Active : ";
            this.cB_ECActive.UseVisualStyleBackColor = true;
            // 
            // UC_ElementEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementEC";
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.Label lDescAnnee;
        private System.Windows.Forms.CheckBox cB_ECActive;
    }
}
