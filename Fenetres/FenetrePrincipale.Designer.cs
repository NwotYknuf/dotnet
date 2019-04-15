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
            this.miAcceuil = new System.Windows.Forms.ToolStripMenuItem();
            this.miDiplome = new System.Windows.Forms.ToolStripMenuItem();
            this.miPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.miGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.miRecherche = new System.Windows.Forms.ToolStripMenuItem();
            this.ucRecherche1 = new dotnet.UC_OngletRecherche();
            this.ucGestion1 = new dotnet.UC_OngletGestion();
            this.ucListePersonnel1 = new dotnet.UC_OngletPersonnels();
            this.ucListeDiplome1 = new dotnet.UC_OngletDiplomes();
            this.ucAccueil1 = new dotnet.UC_OngletAccueil();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // miAcceuil
            // 
            this.miAcceuil.ForeColor = System.Drawing.Color.White;
            this.miAcceuil.Image = ((System.Drawing.Image)(resources.GetObject("miAcceuil.Image")));
            this.miAcceuil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAcceuil.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.miAcceuil.Name = "miAcceuil";
            this.miAcceuil.Size = new System.Drawing.Size(143, 84);
            this.miAcceuil.Text = "Accueil";
            this.miAcceuil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miAcceuil.Click += new System.EventHandler(this.miAcceuil_Click);
            // 
            // miDiplome
            // 
            this.miDiplome.ForeColor = System.Drawing.Color.White;
            this.miDiplome.Image = ((System.Drawing.Image)(resources.GetObject("miDiplome.Image")));
            this.miDiplome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miDiplome.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.miDiplome.Name = "miDiplome";
            this.miDiplome.Size = new System.Drawing.Size(143, 84);
            this.miDiplome.Text = "Diplome";
            this.miDiplome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miDiplome.Click += new System.EventHandler(this.miDiplome_Click);
            // 
            // miPersonnel
            // 
            this.miPersonnel.ForeColor = System.Drawing.Color.White;
            this.miPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("miPersonnel.Image")));
            this.miPersonnel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miPersonnel.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.miPersonnel.Name = "miPersonnel";
            this.miPersonnel.Size = new System.Drawing.Size(143, 84);
            this.miPersonnel.Text = "Personnel";
            this.miPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miPersonnel.Click += new System.EventHandler(this.miPersonnel_Click);
            // 
            // miGestion
            // 
            this.miGestion.ForeColor = System.Drawing.Color.White;
            this.miGestion.Image = ((System.Drawing.Image)(resources.GetObject("miGestion.Image")));
            this.miGestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miGestion.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.miGestion.Name = "miGestion";
            this.miGestion.Size = new System.Drawing.Size(143, 84);
            this.miGestion.Text = "Gestion";
            this.miGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miGestion.Click += new System.EventHandler(this.miGestion_Click);
            // 
            // msMenu
            // 
            this.msMenu.AutoSize = false;
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.msMenu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAcceuil,
            this.miDiplome,
            this.miPersonnel,
            this.miGestion,
            this.miRecherche});
            this.msMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msMenu.Size = new System.Drawing.Size(150, 682);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "Menu";
            // 
            // miRecherche
            // 
            this.miRecherche.ForeColor = System.Drawing.Color.White;
            this.miRecherche.Image = ((System.Drawing.Image)(resources.GetObject("miRecherche.Image")));
            this.miRecherche.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miRecherche.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.miRecherche.Name = "miRecherche";
            this.miRecherche.Size = new System.Drawing.Size(143, 84);
            this.miRecherche.Text = "Recherche";
            this.miRecherche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miRecherche.Click += new System.EventHandler(this.miRecherche_Click);
            // 
            // ucRecherche1
            // 
            this.ucRecherche1.Location = new System.Drawing.Point(153, 0);
            this.ucRecherche1.Name = "ucRecherche1";
            this.ucRecherche1.Size = new System.Drawing.Size(1112, 682);
            this.ucRecherche1.TabIndex = 10;
            // 
            // ucGestion1
            // 
            this.ucGestion1.Location = new System.Drawing.Point(153, 0);
            this.ucGestion1.Name = "ucGestion1";
            this.ucGestion1.Size = new System.Drawing.Size(1112, 682);
            this.ucGestion1.TabIndex = 9;
            // 
            // ucListePersonnel1
            // 
            this.ucListePersonnel1.Location = new System.Drawing.Point(153, 0);
            this.ucListePersonnel1.Name = "ucListePersonnel1";
            this.ucListePersonnel1.Size = new System.Drawing.Size(1112, 682);
            this.ucListePersonnel1.TabIndex = 7;
            // 
            // ucListeDiplome1
            // 
            this.ucListeDiplome1.Location = new System.Drawing.Point(153, 0);
            this.ucListeDiplome1.Name = "ucListeDiplome1";
            this.ucListeDiplome1.Size = new System.Drawing.Size(1112, 682);
            this.ucListeDiplome1.TabIndex = 2;
            // 
            // ucAccueil1
            // 
            this.ucAccueil1.Location = new System.Drawing.Point(153, 0);
            this.ucAccueil1.Name = "ucAccueil1";
            this.ucAccueil1.Size = new System.Drawing.Size(1112, 682);
            this.ucAccueil1.TabIndex = 1;
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.ucListeDiplome1);
            this.Controls.Add(this.ucAccueil1);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.ucRecherche1);
            this.Controls.Add(this.ucGestion1);
            this.Controls.Add(this.ucListePersonnel1);
            this.Name = "FenetrePrincipale";
            this.Text = "Application de gestion";
            this.Load += new System.EventHandler(this.FenetrePrincipale_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem miAcceuil;
        private System.Windows.Forms.ToolStripMenuItem miDiplome;
        private System.Windows.Forms.ToolStripMenuItem miPersonnel;
        private System.Windows.Forms.ToolStripMenuItem miGestion;
        private System.Windows.Forms.ToolStripMenuItem miRecherche;
        private UC_OngletAccueil ucAccueil1;
        private UC_OngletDiplomes ucListeDiplome1;
        private UC_OngletPersonnels ucListePersonnel1;
        private UC_OngletGestion ucGestion1;
        private UC_OngletRecherche ucRecherche1;
        private System.Windows.Forms.MenuStrip msMenu;
    }
}

