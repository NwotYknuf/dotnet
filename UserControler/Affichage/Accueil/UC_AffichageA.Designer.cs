﻿namespace dotnet.UserControler.Affichage
{
    partial class UC_AffichageA
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
            this.gBTitreAffichage = new System.Windows.Forms.GroupBox();
            this.flowLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gBTitreAffichage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTitreAffichage
            // 
            this.gBTitreAffichage.Controls.Add(this.flowLPanel);
            this.gBTitreAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTitreAffichage.Location = new System.Drawing.Point(3, 3);
            this.gBTitreAffichage.Name = "gBTitreAffichage";
            this.gBTitreAffichage.Size = new System.Drawing.Size(472, 550);
            this.gBTitreAffichage.TabIndex = 1;
            this.gBTitreAffichage.TabStop = false;
            this.gBTitreAffichage.Text = "TitreAffichage";
            // 
            // flowLPanel
            // 
            this.flowLPanel.AutoScroll = true;
            this.flowLPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLPanel.Location = new System.Drawing.Point(6, 21);
            this.flowLPanel.Name = "flowLPanel";
            this.flowLPanel.Size = new System.Drawing.Size(460, 523);
            this.flowLPanel.TabIndex = 0;
            this.flowLPanel.WrapContents = false;
            // 
            // UC_AffichageA
            // 
            this.Controls.Add(this.gBTitreAffichage);
            this.Name = "UC_AffichageA";
            this.Size = new System.Drawing.Size(480, 555);
            this.gBTitreAffichage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox gBTitreAffichage;
        protected System.Windows.Forms.FlowLayoutPanel flowLPanel;
    }
}
