namespace dotnet
{
    partial class FenetrePrincipale
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            this.acceuil = new System.Windows.Forms.ToolStripMenuItem();
            this.diplomes = new System.Windows.Forms.ToolStripMenuItem();
            this.personnel = new System.Windows.Forms.ToolStripMenuItem();
            this.baremes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toast = new dotnet.toast();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acceuil
            // 
            this.acceuil.Image = ((System.Drawing.Image)(resources.GetObject("acceuil.Image")));
            this.acceuil.Name = "acceuil";
            this.acceuil.Size = new System.Drawing.Size(100, 20);
            this.acceuil.Text = "Accueil";
            this.acceuil.Click += new System.EventHandler(this.acceuilClick);
            // 
            // diplomes
            // 
            this.diplomes.Name = "diplomes";
            this.diplomes.Size = new System.Drawing.Size(100, 19);
            this.diplomes.Text = "Diplomes";
            this.diplomes.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // personnel
            // 
            this.personnel.Name = "personnel";
            this.personnel.Size = new System.Drawing.Size(100, 19);
            this.personnel.Text = "Personnel";
            this.personnel.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // baremes
            // 
            this.baremes.Name = "baremes";
            this.baremes.Size = new System.Drawing.Size(100, 19);
            this.baremes.Text = "Gestion barêmes";
            this.baremes.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceuil,
            this.diplomes,
            this.personnel,
            this.baremes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(113, 656);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toast
            // 
            this.toast.Location = new System.Drawing.Point(212, 30);
            this.toast.Name = "toast";
            this.toast.Size = new System.Drawing.Size(542, 421);
            this.toast.TabIndex = 1;
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 656);
            this.Controls.Add(this.toast);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FenetrePrincipale";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FenetrePrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem acceuil;
        private System.Windows.Forms.ToolStripMenuItem diplomes;
        private System.Windows.Forms.ToolStripMenuItem personnel;
        private System.Windows.Forms.ToolStripMenuItem baremes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private toast toast;
    }
}

