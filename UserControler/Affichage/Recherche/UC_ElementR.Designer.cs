﻿namespace dotnet.UserControler.Affichage.Recherche
{
    partial class UC_ElementR
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
            this.gBAffElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            this.panel.MouseHover += new System.EventHandler(this.panel_MouseHover);
            // 
            // UC_ElementR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementR";
            this.gBAffElement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
