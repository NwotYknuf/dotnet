﻿namespace dotnet.Fenetres.Assignation
{
    partial class FenetreAssignation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_AffichageFenAssign1 = new dotnet.UserControler.Affichage.Assignation.UC_AffichageFenAssign();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(8, 14);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(340, 16);
            this.lTitre.TabIndex = 1;
            this.lTitre.Text = "Sélectionnez l\'ELEMENT que vous souhaitez assigner : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lTitre);
            this.panel1.Controls.Add(this.uC_AffichageFenAssign1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 488);
            this.panel1.TabIndex = 2;
            // 
            // uC_AffichageFenAssign1
            // 
            this.uC_AffichageFenAssign1.Location = new System.Drawing.Point(4, 40);
            this.uC_AffichageFenAssign1.Name = "uC_AffichageFenAssign1";
            this.uC_AffichageFenAssign1.Size = new System.Drawing.Size(700, 445);
            this.uC_AffichageFenAssign1.TabIndex = 0;
            // 
            // FenetreAssignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 512);
            this.Controls.Add(this.panel1);
            this.Name = "FenetreAssignation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FenetreAssignation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lTitre;
        protected UserControler.Affichage.Assignation.UC_AffichageFenAssign uC_AffichageFenAssign1;
        protected System.Windows.Forms.Panel panel1;
    }
}