﻿namespace dotnet.UserControler.FilArianne
{
    partial class UC_FilArianeDiplome
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lRacine = new System.Windows.Forms.Label();
            this.lDiplome = new System.Windows.Forms.Label();
            this.lAnnee = new System.Windows.Forms.Label();
            this.lPeriode = new System.Windows.Forms.Label();
            this.lUE = new System.Windows.Forms.Label();
            this.lEC = new System.Windows.Forms.Label();
            this.lCours = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.lRacine);
            this.flowLayoutPanel.Controls.Add(this.lDiplome);
            this.flowLayoutPanel.Controls.Add(this.lAnnee);
            this.flowLayoutPanel.Controls.Add(this.lPeriode);
            this.flowLayoutPanel.Controls.Add(this.lUE);
            this.flowLayoutPanel.Controls.Add(this.lEC);
            this.flowLayoutPanel.Controls.Add(this.lCours);
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowLayoutPanel.Size = new System.Drawing.Size(974, 43);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // lRacine
            // 
            this.lRacine.Image = global::dotnet.Properties.Resources.fA_racine_blanc_113x36;
            this.lRacine.Location = new System.Drawing.Point(3, 2);
            this.lRacine.MinimumSize = new System.Drawing.Size(114, 37);
            this.lRacine.Name = "lRacine";
            this.lRacine.Size = new System.Drawing.Size(114, 37);
            this.lRacine.TabIndex = 1;
            this.lRacine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lRacine.Click += new System.EventHandler(this.lRacine_Click);
            this.lRacine.MouseEnter += new System.EventHandler(this.lRacine_MouseEnter);
            this.lRacine.MouseLeave += new System.EventHandler(this.lRacine_MouseLeave);
            // 
            // lDiplome
            // 
            this.lDiplome.AutoEllipsis = true;
            this.lDiplome.AutoSize = true;
            this.lDiplome.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiplome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lDiplome.Image = global::dotnet.Properties.Resources.fA_blanc_113x36;
            this.lDiplome.Location = new System.Drawing.Point(123, 2);
            this.lDiplome.MinimumSize = new System.Drawing.Size(114, 37);
            this.lDiplome.Name = "lDiplome";
            this.lDiplome.Size = new System.Drawing.Size(114, 37);
            this.lDiplome.TabIndex = 2;
            this.lDiplome.Text = "Diplôme";
            this.lDiplome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lDiplome.Visible = false;
            this.lDiplome.Click += new System.EventHandler(this.lDiplome_Click);
            this.lDiplome.MouseEnter += new System.EventHandler(this.lDiplome_MouseEnter);
            this.lDiplome.MouseLeave += new System.EventHandler(this.lDiplome_MouseLeave);
            // 
            // lAnnee
            // 
            this.lAnnee.AutoEllipsis = true;
            this.lAnnee.AutoSize = true;
            this.lAnnee.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lAnnee.Image = global::dotnet.Properties.Resources.fA_blanc_113x36;
            this.lAnnee.Location = new System.Drawing.Point(243, 2);
            this.lAnnee.MinimumSize = new System.Drawing.Size(114, 37);
            this.lAnnee.Name = "lAnnee";
            this.lAnnee.Size = new System.Drawing.Size(114, 37);
            this.lAnnee.TabIndex = 3;
            this.lAnnee.Text = "Année";
            this.lAnnee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAnnee.Visible = false;
            this.lAnnee.Click += new System.EventHandler(this.lAnnee_Click);
            this.lAnnee.MouseEnter += new System.EventHandler(this.lAnnee_MouseEnter);
            this.lAnnee.MouseLeave += new System.EventHandler(this.lAnnee_MouseLeave);
            // 
            // lPeriode
            // 
            this.lPeriode.AutoEllipsis = true;
            this.lPeriode.AutoSize = true;
            this.lPeriode.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPeriode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lPeriode.Image = global::dotnet.Properties.Resources.fA_blanc_113x36;
            this.lPeriode.Location = new System.Drawing.Point(363, 2);
            this.lPeriode.MinimumSize = new System.Drawing.Size(114, 37);
            this.lPeriode.Name = "lPeriode";
            this.lPeriode.Size = new System.Drawing.Size(114, 37);
            this.lPeriode.TabIndex = 4;
            this.lPeriode.Text = "Période";
            this.lPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lPeriode.Visible = false;
            this.lPeriode.Click += new System.EventHandler(this.lPeriode_Click);
            this.lPeriode.MouseEnter += new System.EventHandler(this.lPeriode_MouseEnter);
            this.lPeriode.MouseLeave += new System.EventHandler(this.lPeriode_MouseLeave);
            // 
            // lUE
            // 
            this.lUE.AutoEllipsis = true;
            this.lUE.AutoSize = true;
            this.lUE.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lUE.Image = global::dotnet.Properties.Resources.fA_blanc_113x36;
            this.lUE.Location = new System.Drawing.Point(483, 2);
            this.lUE.MinimumSize = new System.Drawing.Size(114, 37);
            this.lUE.Name = "lUE";
            this.lUE.Size = new System.Drawing.Size(114, 37);
            this.lUE.TabIndex = 5;
            this.lUE.Text = "UE";
            this.lUE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lUE.Visible = false;
            this.lUE.Click += new System.EventHandler(this.lUE_Click);
            this.lUE.MouseEnter += new System.EventHandler(this.lUE_MouseEnter);
            this.lUE.MouseLeave += new System.EventHandler(this.lUE_MouseLeave);
            // 
            // lEC
            // 
            this.lEC.AutoEllipsis = true;
            this.lEC.AutoSize = true;
            this.lEC.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lEC.Image = global::dotnet.Properties.Resources.fA_blanc_113x36;
            this.lEC.Location = new System.Drawing.Point(603, 2);
            this.lEC.MinimumSize = new System.Drawing.Size(114, 37);
            this.lEC.Name = "lEC";
            this.lEC.Size = new System.Drawing.Size(114, 37);
            this.lEC.TabIndex = 6;
            this.lEC.Text = "EC";
            this.lEC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lEC.Visible = false;
            this.lEC.Click += new System.EventHandler(this.lEC_Click);
            this.lEC.MouseEnter += new System.EventHandler(this.lEC_MouseEnter);
            this.lEC.MouseLeave += new System.EventHandler(this.lEC_MouseLeave);
            // 
            // lCours
            // 
            this.lCours.AutoEllipsis = true;
            this.lCours.AutoSize = true;
            this.lCours.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCours.ForeColor = System.Drawing.Color.White;
            this.lCours.Image = global::dotnet.Properties.Resources.fA_bleu_113x36;
            this.lCours.Location = new System.Drawing.Point(723, 2);
            this.lCours.MinimumSize = new System.Drawing.Size(114, 37);
            this.lCours.Name = "lCours";
            this.lCours.Size = new System.Drawing.Size(114, 37);
            this.lCours.TabIndex = 7;
            this.lCours.Text = "Cours";
            this.lCours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lCours.Visible = false;
            this.lCours.Click += new System.EventHandler(this.lCours_Click);
            this.lCours.MouseEnter += new System.EventHandler(this.lCours_MouseEnter);
            this.lCours.MouseLeave += new System.EventHandler(this.lCours_MouseLeave);
            // 
            // UC_FilArianeDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "UC_FilArianeDiplome";
            this.Load += new System.EventHandler(this.UC_FilArianeDiplome_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lRacine;
        private System.Windows.Forms.Label lDiplome;
        private System.Windows.Forms.Label lAnnee;
        private System.Windows.Forms.Label lPeriode;
        private System.Windows.Forms.Label lUE;
        private System.Windows.Forms.Label lEC;
        private System.Windows.Forms.Label lCours;
    }
}
