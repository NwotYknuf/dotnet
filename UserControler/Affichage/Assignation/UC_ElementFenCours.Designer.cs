namespace dotnet.UserControler.Affichage.Assignation
{
    partial class UC_ElementFenCours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ElementFenCours));
            this.tBEC = new System.Windows.Forms.TextBox();
            this.lEC = new System.Windows.Forms.Label();
            this.tBHoraires = new System.Windows.Forms.TextBox();
            this.tBCours = new System.Windows.Forms.TextBox();
            this.lHoraires = new System.Windows.Forms.Label();
            this.lTypeCours = new System.Windows.Forms.Label();
            this.pBAjouterCours = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjouterCours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pBAjouterCours);
            this.panel.Controls.Add(this.tBEC);
            this.panel.Controls.Add(this.lTypeCours);
            this.panel.Controls.Add(this.lEC);
            this.panel.Controls.Add(this.lHoraires);
            this.panel.Controls.Add(this.tBHoraires);
            this.panel.Controls.Add(this.tBCours);
            // 
            // tBEC
            // 
            this.tBEC.Enabled = false;
            this.tBEC.Location = new System.Drawing.Point(123, 61);
            this.tBEC.Name = "tBEC";
            this.tBEC.Size = new System.Drawing.Size(100, 20);
            this.tBEC.TabIndex = 23;
            // 
            // lEC
            // 
            this.lEC.AutoSize = true;
            this.lEC.Location = new System.Drawing.Point(26, 64);
            this.lEC.Name = "lEC";
            this.lEC.Size = new System.Drawing.Size(30, 13);
            this.lEC.TabIndex = 22;
            this.lEC.Text = "EC : ";
            // 
            // tBHoraires
            // 
            this.tBHoraires.Enabled = false;
            this.tBHoraires.Location = new System.Drawing.Point(123, 37);
            this.tBHoraires.Name = "tBHoraires";
            this.tBHoraires.Size = new System.Drawing.Size(100, 20);
            this.tBHoraires.TabIndex = 21;
            // 
            // tBCours
            // 
            this.tBCours.Enabled = false;
            this.tBCours.Location = new System.Drawing.Point(123, 13);
            this.tBCours.Name = "tBCours";
            this.tBCours.Size = new System.Drawing.Size(100, 20);
            this.tBCours.TabIndex = 20;
            // 
            // lHoraires
            // 
            this.lHoraires.AutoSize = true;
            this.lHoraires.Location = new System.Drawing.Point(26, 40);
            this.lHoraires.Name = "lHoraires";
            this.lHoraires.Size = new System.Drawing.Size(91, 13);
            this.lHoraires.TabIndex = 19;
            this.lHoraires.Text = "Volume horaires : ";
            // 
            // lTypeCours
            // 
            this.lTypeCours.AutoSize = true;
            this.lTypeCours.Location = new System.Drawing.Point(26, 16);
            this.lTypeCours.Name = "lTypeCours";
            this.lTypeCours.Size = new System.Drawing.Size(84, 13);
            this.lTypeCours.TabIndex = 18;
            this.lTypeCours.Text = "Type de cours : ";
            // 
            // pBAjouterCours
            // 
            this.pBAjouterCours.Image = ((System.Drawing.Image)(resources.GetObject("pBAjouterCours.Image")));
            this.pBAjouterCours.InitialImage = null;
            this.pBAjouterCours.Location = new System.Drawing.Point(532, 24);
            this.pBAjouterCours.Name = "pBAjouterCours";
            this.pBAjouterCours.Size = new System.Drawing.Size(59, 46);
            this.pBAjouterCours.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAjouterCours.TabIndex = 53;
            this.pBAjouterCours.TabStop = false;
            this.pBAjouterCours.Click += new System.EventHandler(this.pBAjouterCours_Click);
            // 
            // UC_ElementFenCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ElementFenCours";
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjouterCours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBEC;
        private System.Windows.Forms.Label lEC;
        private System.Windows.Forms.TextBox tBHoraires;
        private System.Windows.Forms.TextBox tBCours;
        private System.Windows.Forms.Label lHoraires;
        private System.Windows.Forms.Label lTypeCours;
        protected System.Windows.Forms.PictureBox pBAjouterCours;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
