﻿namespace dotnet
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
            this.gBTitreAjout = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.lErreur = new System.Windows.Forms.Label();
            this.bCreer = new System.Windows.Forms.Button();
            this.gBTitreAjout.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTitreAjout
            // 
            this.gBTitreAjout.Controls.Add(this.panel);
            this.gBTitreAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTitreAjout.Location = new System.Drawing.Point(3, 3);
            this.gBTitreAjout.Name = "gBTitreAjout";
            this.gBTitreAjout.Size = new System.Drawing.Size(994, 77);
            this.gBTitreAjout.TabIndex = 0;
            this.gBTitreAjout.TabStop = false;
            this.gBTitreAjout.Text = "TitreAjout";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.lErreur);
            this.panel.Controls.Add(this.bCreer);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(6, 20);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(982, 51);
            this.panel.TabIndex = 3;
            // 
            // lErreur
            // 
            this.lErreur.AutoSize = true;
            this.lErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErreur.ForeColor = System.Drawing.Color.Red;
            this.lErreur.Location = new System.Drawing.Point(849, 35);
            this.lErreur.Name = "lErreur";
            this.lErreur.Size = new System.Drawing.Size(88, 13);
            this.lErreur.TabIndex = 8;
            this.lErreur.Text = "Erreur, réessayez";
            this.lErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lErreur.Visible = false;
            // 
            // bCreer
            // 
            this.bCreer.AutoSize = true;
            this.bCreer.Location = new System.Drawing.Point(833, 7);
            this.bCreer.Name = "bCreer";
            this.bCreer.Size = new System.Drawing.Size(117, 26);
            this.bCreer.TabIndex = 2;
            this.bCreer.Text = "Créer";
            this.bCreer.UseVisualStyleBackColor = true;
            // 
            // UC_Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBTitreAjout);
            this.Name = "UC_Ajout";
            this.Size = new System.Drawing.Size(1000, 80);
            this.gBTitreAjout.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox gBTitreAjout;
        protected System.Windows.Forms.Button bCreer;
        protected System.Windows.Forms.Panel panel;
        protected System.Windows.Forms.Label lErreur;
    }
}
