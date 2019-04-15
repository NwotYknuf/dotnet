namespace dotnet
{
    partial class UC_OngletAccueil
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
            this.lBienvenu = new System.Windows.Forms.Label();
            this.pBienvenu = new System.Windows.Forms.Panel();
            this.pAccueil = new System.Windows.Forms.Panel();
            this.pAffCours = new System.Windows.Forms.Panel();
            this.pAffPersonnel = new System.Windows.Forms.Panel();
            this.lDate = new System.Windows.Forms.Label();
            this.lHorloge = new System.Windows.Forms.Label();
            this.timerBienvenu = new System.Windows.Forms.Timer(this.components);
            this.timerHorloge = new System.Windows.Forms.Timer(this.components);
            this.lTitre = new System.Windows.Forms.Label();
            this.uC_AffCours = new dotnet.UserControler.Affichage.UC_AffichageA();
            this.uC_AffPersonnel = new dotnet.UserControler.Affichage.UC_AffichageA();
            this.pBienvenu.SuspendLayout();
            this.pAccueil.SuspendLayout();
            this.pAffCours.SuspendLayout();
            this.pAffPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBienvenu
            // 
            this.lBienvenu.AutoEllipsis = true;
            this.lBienvenu.AutoSize = true;
            this.lBienvenu.BackColor = System.Drawing.Color.Transparent;
            this.lBienvenu.Font = new System.Drawing.Font("Pristina", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBienvenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.lBienvenu.Location = new System.Drawing.Point(143, 194);
            this.lBienvenu.Name = "lBienvenu";
            this.lBienvenu.Size = new System.Drawing.Size(858, 252);
            this.lBienvenu.TabIndex = 0;
            this.lBienvenu.Text = "Bienvenu dans votre \r\n      application de gestion !";
            // 
            // pBienvenu
            // 
            this.pBienvenu.BackColor = System.Drawing.Color.White;
            this.pBienvenu.Controls.Add(this.lBienvenu);
            this.pBienvenu.Location = new System.Drawing.Point(3, 3);
            this.pBienvenu.Name = "pBienvenu";
            this.pBienvenu.Size = new System.Drawing.Size(1106, 676);
            this.pBienvenu.TabIndex = 1;
            this.pBienvenu.Click += new System.EventHandler(this.pBienvenu_Click);
            // 
            // pAccueil
            // 
            this.pAccueil.Controls.Add(this.lTitre);
            this.pAccueil.Controls.Add(this.pAffCours);
            this.pAccueil.Controls.Add(this.pAffPersonnel);
            this.pAccueil.Controls.Add(this.lDate);
            this.pAccueil.Controls.Add(this.lHorloge);
            this.pAccueil.Location = new System.Drawing.Point(3, 3);
            this.pAccueil.Name = "pAccueil";
            this.pAccueil.Size = new System.Drawing.Size(1106, 676);
            this.pAccueil.TabIndex = 1;
            // 
            // pAffCours
            // 
            this.pAffCours.Controls.Add(this.uC_AffCours);
            this.pAffCours.Location = new System.Drawing.Point(553, 96);
            this.pAffCours.Name = "pAffCours";
            this.pAffCours.Size = new System.Drawing.Size(498, 577);
            this.pAffCours.TabIndex = 3;
            // 
            // pAffPersonnel
            // 
            this.pAffPersonnel.Controls.Add(this.uC_AffPersonnel);
            this.pAffPersonnel.Location = new System.Drawing.Point(56, 96);
            this.pAffPersonnel.Name = "pAffPersonnel";
            this.pAffPersonnel.Size = new System.Drawing.Size(498, 577);
            this.pAffPersonnel.TabIndex = 2;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(829, 18);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(249, 31);
            this.lDate.TabIndex = 1;
            this.lDate.Text = "Jour Num Mois Année";
            // 
            // lHorloge
            // 
            this.lHorloge.AutoSize = true;
            this.lHorloge.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHorloge.Location = new System.Drawing.Point(930, 58);
            this.lHorloge.Name = "lHorloge";
            this.lHorloge.Size = new System.Drawing.Size(96, 25);
            this.lHorloge.TabIndex = 0;
            this.lHorloge.Text = "hh:mm:ss";
            // 
            // timerBienvenu
            // 
            this.timerBienvenu.Tick += new System.EventHandler(this.timerBienvenu_Tick);
            // 
            // timerHorloge
            // 
            this.timerHorloge.Tick += new System.EventHandler(this.timerHorloge_Tick);
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Heroes Legend", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(79)))), ((int)(((byte)(93)))));
            this.lTitre.Location = new System.Drawing.Point(63, 25);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(85, 36);
            this.lTitre.TabIndex = 2;
            this.lTitre.Text = "Titre";
            // 
            // uC_AffCours
            // 
            this.uC_AffCours.Location = new System.Drawing.Point(10, 8);
            this.uC_AffCours.Name = "uC_AffCours";
            this.uC_AffCours.Size = new System.Drawing.Size(480, 555);
            this.uC_AffCours.TabIndex = 0;
            // 
            // uC_AffPersonnel
            // 
            this.uC_AffPersonnel.Location = new System.Drawing.Point(9, 8);
            this.uC_AffPersonnel.Name = "uC_AffPersonnel";
            this.uC_AffPersonnel.Size = new System.Drawing.Size(482, 555);
            this.uC_AffPersonnel.TabIndex = 0;
            // 
            // UC_OngletAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pAccueil);
            this.Controls.Add(this.pBienvenu);
            this.Name = "UC_OngletAccueil";
            this.Size = new System.Drawing.Size(1112, 682);
            this.Load += new System.EventHandler(this.UC_OngletAccueil_Load);
            this.pBienvenu.ResumeLayout(false);
            this.pBienvenu.PerformLayout();
            this.pAccueil.ResumeLayout(false);
            this.pAccueil.PerformLayout();
            this.pAffCours.ResumeLayout(false);
            this.pAffPersonnel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lBienvenu;
        private System.Windows.Forms.Panel pBienvenu;
        private System.Windows.Forms.Panel pAccueil;
        private System.Windows.Forms.Timer timerBienvenu;
        private System.Windows.Forms.Label lHorloge;
        private System.Windows.Forms.Timer timerHorloge;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Panel pAffCours;
        private System.Windows.Forms.Panel pAffPersonnel;
        private UserControler.Affichage.UC_AffichageA uC_AffPersonnel;
        private UserControler.Affichage.UC_AffichageA uC_AffCours;
        private System.Windows.Forms.Label lTitre;
    }
}
