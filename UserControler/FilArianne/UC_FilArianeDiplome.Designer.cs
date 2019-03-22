namespace dotnet.UserControler.FilArianne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FilArianeDiplome));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lRacine = new System.Windows.Forms.Label();
            this.lDiplome = new System.Windows.Forms.Label();
            this.lAnnee = new System.Windows.Forms.Label();
            this.lPeriode = new System.Windows.Forms.Label();
            this.lUE = new System.Windows.Forms.Label();
            this.lEC = new System.Windows.Forms.Label();
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
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowLayoutPanel.Size = new System.Drawing.Size(974, 43);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // lRacine
            // 
            this.lRacine.Image = ((System.Drawing.Image)(resources.GetObject("lRacine.Image")));
            this.lRacine.Location = new System.Drawing.Point(3, 2);
            this.lRacine.Name = "lRacine";
            this.lRacine.Size = new System.Drawing.Size(113, 36);
            this.lRacine.TabIndex = 0;
            this.lRacine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lRacine.Click += new System.EventHandler(this.lRacine_Click);
            // 
            // lDiplome
            // 
            this.lDiplome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lDiplome.Image = ((System.Drawing.Image)(resources.GetObject("lDiplome.Image")));
            this.lDiplome.Location = new System.Drawing.Point(122, 2);
            this.lDiplome.Name = "lDiplome";
            this.lDiplome.Size = new System.Drawing.Size(113, 36);
            this.lDiplome.TabIndex = 1;
            this.lDiplome.Text = "Diplôme";
            this.lDiplome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lDiplome.Visible = false;
            this.lDiplome.Click += new System.EventHandler(this.lDiplome_Click);
            // 
            // lAnnee
            // 
            this.lAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lAnnee.Image = ((System.Drawing.Image)(resources.GetObject("lAnnee.Image")));
            this.lAnnee.Location = new System.Drawing.Point(241, 2);
            this.lAnnee.Name = "lAnnee";
            this.lAnnee.Size = new System.Drawing.Size(113, 36);
            this.lAnnee.TabIndex = 2;
            this.lAnnee.Text = "Année";
            this.lAnnee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAnnee.Visible = false;
            this.lAnnee.Click += new System.EventHandler(this.lAnnee_Click);
            // 
            // lPeriode
            // 
            this.lPeriode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lPeriode.Image = ((System.Drawing.Image)(resources.GetObject("lPeriode.Image")));
            this.lPeriode.Location = new System.Drawing.Point(360, 2);
            this.lPeriode.Name = "lPeriode";
            this.lPeriode.Size = new System.Drawing.Size(113, 36);
            this.lPeriode.TabIndex = 3;
            this.lPeriode.Text = "Période";
            this.lPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lPeriode.Visible = false;
            this.lPeriode.Click += new System.EventHandler(this.lPeriode_Click);
            // 
            // lUE
            // 
            this.lUE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lUE.Image = ((System.Drawing.Image)(resources.GetObject("lUE.Image")));
            this.lUE.Location = new System.Drawing.Point(479, 2);
            this.lUE.Name = "lUE";
            this.lUE.Size = new System.Drawing.Size(113, 36);
            this.lUE.TabIndex = 4;
            this.lUE.Text = "UE";
            this.lUE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lUE.Visible = false;
            this.lUE.Click += new System.EventHandler(this.lUE_Click);
            // 
            // lEC
            // 
            this.lEC.ForeColor = System.Drawing.Color.White;
            this.lEC.Image = ((System.Drawing.Image)(resources.GetObject("lEC.Image")));
            this.lEC.Location = new System.Drawing.Point(598, 2);
            this.lEC.Name = "lEC";
            this.lEC.Size = new System.Drawing.Size(113, 36);
            this.lEC.TabIndex = 5;
            this.lEC.Text = "EC";
            this.lEC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lEC.Visible = false;
            this.lEC.Click += new System.EventHandler(this.lEC_Click);
            // 
            // UC_FilArianeDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "UC_FilArianeDiplome";
            this.Size = new System.Drawing.Size(980, 49);
            this.Load += new System.EventHandler(this.UC_FilArianeDiplome_Load);
            this.flowLayoutPanel.ResumeLayout(false);
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
    }
}
