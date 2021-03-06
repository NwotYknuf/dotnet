﻿namespace dotnet.UserControler.Affichage.Personnel
{
    partial class UC_ElementCoursPersonnel
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
            this.tBEC = new System.Windows.Forms.TextBox();
            this.lEC = new System.Windows.Forms.Label();
            this.tBHoraires = new System.Windows.Forms.TextBox();
            this.tBCours = new System.Windows.Forms.TextBox();
            this.lHoraires = new System.Windows.Forms.Label();
            this.lTypeCours = new System.Windows.Forms.Label();
            this.pBRetirer = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRetirer)).BeginInit();
            this.SuspendLayout();
            // 
            // pBModifier
            // 
            this.pBModifier.Location = new System.Drawing.Point(896, 8);
            this.pBModifier.Click += new System.EventHandler(this.pBModifier_Click);
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Location = new System.Drawing.Point(897, 55);
            this.pBSupprimer.Click += new System.EventHandler(this.pBSupprimer_Click);
            // 
            // gBAffElement
            // 
            this.gBAffElement.Size = new System.Drawing.Size(951, 123);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pBRetirer);
            this.panel.Controls.Add(this.tBEC);
            this.panel.Controls.Add(this.lEC);
            this.panel.Controls.Add(this.tBHoraires);
            this.panel.Controls.Add(this.tBCours);
            this.panel.Controls.Add(this.lHoraires);
            this.panel.Controls.Add(this.lTypeCours);
            this.panel.Size = new System.Drawing.Size(938, 100);
            this.panel.Controls.SetChildIndex(this.lTypeCours, 0);
            this.panel.Controls.SetChildIndex(this.lHoraires, 0);
            this.panel.Controls.SetChildIndex(this.tBCours, 0);
            this.panel.Controls.SetChildIndex(this.tBHoraires, 0);
            this.panel.Controls.SetChildIndex(this.lEC, 0);
            this.panel.Controls.SetChildIndex(this.tBEC, 0);
            this.panel.Controls.SetChildIndex(this.pBSupprimer, 0);
            this.panel.Controls.SetChildIndex(this.pBModifier, 0);
            this.panel.Controls.SetChildIndex(this.pBRetirer, 0);
            // 
            // tBEC
            // 
            this.tBEC.Enabled = false;
            this.tBEC.Location = new System.Drawing.Point(155, 61);
            this.tBEC.Name = "tBEC";
            this.tBEC.Size = new System.Drawing.Size(170, 20);
            this.tBEC.TabIndex = 12;
            // 
            // lEC
            // 
            this.lEC.AutoSize = true;
            this.lEC.Location = new System.Drawing.Point(20, 64);
            this.lEC.Name = "lEC";
            this.lEC.Size = new System.Drawing.Size(125, 13);
            this.lEC.TabIndex = 11;
            this.lEC.Text = "Élément constitutif (EC) : ";
            // 
            // tBHoraires
            // 
            this.tBHoraires.Enabled = false;
            this.tBHoraires.Location = new System.Drawing.Point(155, 36);
            this.tBHoraires.Name = "tBHoraires";
            this.tBHoraires.Size = new System.Drawing.Size(170, 20);
            this.tBHoraires.TabIndex = 10;
            // 
            // tBCours
            // 
            this.tBCours.Enabled = false;
            this.tBCours.Location = new System.Drawing.Point(155, 12);
            this.tBCours.Name = "tBCours";
            this.tBCours.Size = new System.Drawing.Size(170, 20);
            this.tBCours.TabIndex = 9;
            // 
            // lHoraires
            // 
            this.lHoraires.AutoSize = true;
            this.lHoraires.Location = new System.Drawing.Point(21, 39);
            this.lHoraires.Name = "lHoraires";
            this.lHoraires.Size = new System.Drawing.Size(91, 13);
            this.lHoraires.TabIndex = 8;
            this.lHoraires.Text = "Volume horaires : ";
            // 
            // lTypeCours
            // 
            this.lTypeCours.AutoSize = true;
            this.lTypeCours.Location = new System.Drawing.Point(21, 15);
            this.lTypeCours.Name = "lTypeCours";
            this.lTypeCours.Size = new System.Drawing.Size(84, 13);
            this.lTypeCours.TabIndex = 7;
            this.lTypeCours.Text = "Type de cours : ";
            // 
            // pBRetirer
            // 
            this.pBRetirer.Image = global::dotnet.Properties.Resources.retirer_cours;
            this.pBRetirer.InitialImage = null;
            this.pBRetirer.Location = new System.Drawing.Point(829, 25);
            this.pBRetirer.Name = "pBRetirer";
            this.pBRetirer.Size = new System.Drawing.Size(61, 48);
            this.pBRetirer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBRetirer.TabIndex = 19;
            this.pBRetirer.TabStop = false;
            this.pBRetirer.Click += new System.EventHandler(this.pBRetirer_Click);
            this.pBRetirer.MouseEnter += new System.EventHandler(this.pBRetirer_MouseEnter);
            this.pBRetirer.MouseLeave += new System.EventHandler(this.pBRetirer_MouseLeave);
            // 
            // UC_ElementCoursPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementCoursPersonnel";
            this.Size = new System.Drawing.Size(955, 126);
            this.Load += new System.EventHandler(this.UC_ElementCoursPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRetirer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tBEC;
        private System.Windows.Forms.Label lEC;
        private System.Windows.Forms.TextBox tBHoraires;
        private System.Windows.Forms.TextBox tBCours;
        private System.Windows.Forms.Label lHoraires;
        private System.Windows.Forms.Label lTypeCours;
        protected System.Windows.Forms.PictureBox pBRetirer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
