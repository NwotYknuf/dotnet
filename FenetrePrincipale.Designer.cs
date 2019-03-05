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
            this.ucRecherche1 = new dotnet.UCRecherche();
            this.ucGestion1 = new dotnet.UCGestion();
            this.ucPersonnel1 = new dotnet.UCPersonnel();
            this.ucListePersonnel1 = new dotnet.UCListePersonnel();
            this.ucue1 = new dotnet.UCUE();
            this.ucListeUE1 = new dotnet.UCListeUE();
            this.ucPeriode1 = new dotnet.UCPeriode();
            this.ucAnnee1 = new dotnet.UCAnnee();
            this.ucListeDiplome1 = new dotnet.UC_OngletDiplomes();
            this.ucAccueil1 = new dotnet.UCAccueil();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // miAcceuil
            // 
            this.miAcceuil.Image = ((System.Drawing.Image)(resources.GetObject("miAcceuil.Image")));
            this.miAcceuil.Name = "miAcceuil";
            this.miAcceuil.Size = new System.Drawing.Size(143, 35);
            this.miAcceuil.Text = "Accueil";
            this.miAcceuil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miAcceuil.Click += new System.EventHandler(this.miAcceuil_Click);
            // 
            // miDiplome
            // 
            this.miDiplome.Image = ((System.Drawing.Image)(resources.GetObject("miDiplome.Image")));
            this.miDiplome.Name = "miDiplome";
            this.miDiplome.Size = new System.Drawing.Size(143, 35);
            this.miDiplome.Text = "Diplome";
            this.miDiplome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miDiplome.Click += new System.EventHandler(this.miDiplome_Click);
            // 
            // miPersonnel
            // 
            this.miPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("miPersonnel.Image")));
            this.miPersonnel.Name = "miPersonnel";
            this.miPersonnel.Size = new System.Drawing.Size(143, 35);
            this.miPersonnel.Text = "Personnel";
            this.miPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miPersonnel.Click += new System.EventHandler(this.miPersonnel_Click);
            // 
            // miGestion
            // 
            this.miGestion.Image = ((System.Drawing.Image)(resources.GetObject("miGestion.Image")));
            this.miGestion.Name = "miGestion";
            this.miGestion.Size = new System.Drawing.Size(143, 35);
            this.miGestion.Text = "Gestion";
            this.miGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miGestion.Click += new System.EventHandler(this.miGestion_Click);
            // 
            // msMenu
            // 
            this.msMenu.AutoSize = false;
            this.msMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.miRecherche.Image = ((System.Drawing.Image)(resources.GetObject("miRecherche.Image")));
            this.miRecherche.Name = "miRecherche";
            this.miRecherche.Size = new System.Drawing.Size(143, 35);
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
            // ucPersonnel1
            // 
            this.ucPersonnel1.Location = new System.Drawing.Point(153, 121);
            this.ucPersonnel1.Name = "ucPersonnel1";
            this.ucPersonnel1.Size = new System.Drawing.Size(1112, 561);
            this.ucPersonnel1.TabIndex = 8;
            // 
            // ucListePersonnel1
            // 
            this.ucListePersonnel1.Location = new System.Drawing.Point(153, 0);
            this.ucListePersonnel1.Name = "ucListePersonnel1";
            this.ucListePersonnel1.Size = new System.Drawing.Size(1112, 682);
            this.ucListePersonnel1.TabIndex = 7;
            // 
            // ucue1
            // 
            this.ucue1.Location = new System.Drawing.Point(153, 121);
            this.ucue1.Name = "ucue1";
            this.ucue1.Size = new System.Drawing.Size(1112, 561);
            this.ucue1.TabIndex = 6;
            // 
            // ucListeUE1
            // 
            this.ucListeUE1.Location = new System.Drawing.Point(153, 121);
            this.ucListeUE1.Name = "ucListeUE1";
            this.ucListeUE1.Size = new System.Drawing.Size(1112, 561);
            this.ucListeUE1.TabIndex = 5;
            // 
            // ucPeriode1
            // 
            this.ucPeriode1.Location = new System.Drawing.Point(153, 121);
            this.ucPeriode1.Name = "ucPeriode1";
            this.ucPeriode1.Size = new System.Drawing.Size(1112, 561);
            this.ucPeriode1.TabIndex = 4;
            // 
            // ucAnnee1
            // 
            this.ucAnnee1.Location = new System.Drawing.Point(153, 121);
            this.ucAnnee1.Name = "ucAnnee1";
            this.ucAnnee1.Size = new System.Drawing.Size(1112, 561);
            this.ucAnnee1.TabIndex = 3;
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
            this.Controls.Add(this.ucRecherche1);
            this.Controls.Add(this.ucGestion1);
            this.Controls.Add(this.ucPersonnel1);
            this.Controls.Add(this.ucListePersonnel1);
            this.Controls.Add(this.ucue1);
            this.Controls.Add(this.ucListeUE1);
            this.Controls.Add(this.ucPeriode1);
            this.Controls.Add(this.ucAnnee1);
            this.Controls.Add(this.ucListeDiplome1);
            this.Controls.Add(this.ucAccueil1);
            this.Controls.Add(this.msMenu);
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
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem miRecherche;
        private UCAccueil ucAccueil1;
        private UC_OngletDiplomes ucListeDiplome1;
        private UCAnnee ucAnnee1;
        private UCPeriode ucPeriode1;
        private UCListeUE ucListeUE1;
        private UCUE ucue1;
        private UCListePersonnel ucListePersonnel1;
        private UCPersonnel ucPersonnel1;
        private UCGestion ucGestion1;
        private UCRecherche ucRecherche1;
    }
}

