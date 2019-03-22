namespace dotnet.UserControler.FilArianne
{
    partial class UC_FilArianePersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FilArianePersonnel));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lRacine = new System.Windows.Forms.Label();
            this.lPersonnel = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.lRacine);
            this.flowLayoutPanel.Controls.Add(this.lPersonnel);
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowLayoutPanel.Size = new System.Drawing.Size(974, 43);
            this.flowLayoutPanel.TabIndex = 3;
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
            // lPersonnel
            // 
            this.lPersonnel.ForeColor = System.Drawing.Color.White;
            this.lPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("lPersonnel.Image")));
            this.lPersonnel.Location = new System.Drawing.Point(122, 2);
            this.lPersonnel.Name = "lPersonnel";
            this.lPersonnel.Size = new System.Drawing.Size(113, 36);
            this.lPersonnel.TabIndex = 5;
            this.lPersonnel.Text = "Personnel";
            this.lPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lPersonnel.Visible = false;
            this.lPersonnel.Click += new System.EventHandler(this.lPersonnel_Click);
            // 
            // UC_FilArianePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "UC_FilArianePersonnel";
            this.Size = new System.Drawing.Size(980, 49);
            this.Load += new System.EventHandler(this.UC_FilArianePersonnel_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lRacine;
        private System.Windows.Forms.Label lPersonnel;
    }
}
