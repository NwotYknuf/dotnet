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
            this.lHorloge = new System.Windows.Forms.Label();
            this.timerBienvenu = new System.Windows.Forms.Timer(this.components);
            this.timerHorloge = new System.Windows.Forms.Timer(this.components);
            this.lDate = new System.Windows.Forms.Label();
            this.pAffPersonnel = new System.Windows.Forms.Panel();
            this.pAffCours = new System.Windows.Forms.Panel();
            this.gBAffPersonnel = new System.Windows.Forms.GroupBox();
            this.gBAffCours = new System.Windows.Forms.GroupBox();
            this.fLPAffPersonnel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lElement1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBienvenu.SuspendLayout();
            this.pAccueil.SuspendLayout();
            this.pAffPersonnel.SuspendLayout();
            this.pAffCours.SuspendLayout();
            this.gBAffPersonnel.SuspendLayout();
            this.gBAffCours.SuspendLayout();
            this.fLPAffPersonnel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBienvenu
            // 
            this.lBienvenu.AutoEllipsis = true;
            this.lBienvenu.AutoSize = true;
            this.lBienvenu.Font = new System.Drawing.Font("Pristina", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBienvenu.ForeColor = System.Drawing.Color.White;
            this.lBienvenu.Location = new System.Drawing.Point(143, 194);
            this.lBienvenu.Name = "lBienvenu";
            this.lBienvenu.Size = new System.Drawing.Size(858, 252);
            this.lBienvenu.TabIndex = 0;
            this.lBienvenu.Text = "Bienvenu dans notre \r\n      application de gestion !";
            // 
            // pBienvenu
            // 
            this.pBienvenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.pBienvenu.Controls.Add(this.lBienvenu);
            this.pBienvenu.Location = new System.Drawing.Point(3, 3);
            this.pBienvenu.Name = "pBienvenu";
            this.pBienvenu.Size = new System.Drawing.Size(1106, 676);
            this.pBienvenu.TabIndex = 1;
            this.pBienvenu.Click += new System.EventHandler(this.pBienvenu_Click);
            // 
            // pAccueil
            // 
            this.pAccueil.Controls.Add(this.pAffCours);
            this.pAccueil.Controls.Add(this.pAffPersonnel);
            this.pAccueil.Controls.Add(this.lDate);
            this.pAccueil.Controls.Add(this.lHorloge);
            this.pAccueil.Location = new System.Drawing.Point(3, 3);
            this.pAccueil.Name = "pAccueil";
            this.pAccueil.Size = new System.Drawing.Size(1106, 676);
            this.pAccueil.TabIndex = 1;
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
            // pAffPersonnel
            // 
            this.pAffPersonnel.Controls.Add(this.gBAffPersonnel);
            this.pAffPersonnel.Location = new System.Drawing.Point(3, 96);
            this.pAffPersonnel.Name = "pAffPersonnel";
            this.pAffPersonnel.Size = new System.Drawing.Size(550, 577);
            this.pAffPersonnel.TabIndex = 2;
            // 
            // pAffCours
            // 
            this.pAffCours.Controls.Add(this.gBAffCours);
            this.pAffCours.Location = new System.Drawing.Point(553, 96);
            this.pAffCours.Name = "pAffCours";
            this.pAffCours.Size = new System.Drawing.Size(550, 577);
            this.pAffCours.TabIndex = 3;
            // 
            // gBAffPersonnel
            // 
            this.gBAffPersonnel.Controls.Add(this.fLPAffPersonnel);
            this.gBAffPersonnel.Location = new System.Drawing.Point(15, 12);
            this.gBAffPersonnel.Name = "gBAffPersonnel";
            this.gBAffPersonnel.Size = new System.Drawing.Size(519, 550);
            this.gBAffPersonnel.TabIndex = 0;
            this.gBAffPersonnel.TabStop = false;
            this.gBAffPersonnel.Text = "Les personnels qui n\'ont pas toutes leurs heures affectées : ";
            // 
            // gBAffCours
            // 
            this.gBAffCours.Controls.Add(this.flowLayoutPanel1);
            this.gBAffCours.Location = new System.Drawing.Point(16, 13);
            this.gBAffCours.Name = "gBAffCours";
            this.gBAffCours.Size = new System.Drawing.Size(519, 550);
            this.gBAffCours.TabIndex = 1;
            this.gBAffCours.TabStop = false;
            this.gBAffCours.Text = "Les cours non affectés : ";
            // 
            // fLPAffPersonnel
            // 
            this.fLPAffPersonnel.Controls.Add(this.lElement1);
            this.fLPAffPersonnel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPAffPersonnel.Location = new System.Drawing.Point(6, 19);
            this.fLPAffPersonnel.Name = "fLPAffPersonnel";
            this.fLPAffPersonnel.Padding = new System.Windows.Forms.Padding(10);
            this.fLPAffPersonnel.Size = new System.Drawing.Size(507, 525);
            this.fLPAffPersonnel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 525);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lElement1
            // 
            this.lElement1.AutoSize = true;
            this.lElement1.Location = new System.Drawing.Point(13, 10);
            this.lElement1.Name = "lElement1";
            this.lElement1.Size = new System.Drawing.Size(88, 13);
            this.lElement1.TabIndex = 0;
            this.lElement1.Text = "Tout est en ordre";
            this.lElement1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tout est en ordre";
            this.label1.Visible = false;
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
            this.pAffPersonnel.ResumeLayout(false);
            this.pAffCours.ResumeLayout(false);
            this.gBAffPersonnel.ResumeLayout(false);
            this.gBAffCours.ResumeLayout(false);
            this.fLPAffPersonnel.ResumeLayout(false);
            this.fLPAffPersonnel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox gBAffCours;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pAffPersonnel;
        private System.Windows.Forms.GroupBox gBAffPersonnel;
        private System.Windows.Forms.FlowLayoutPanel fLPAffPersonnel;
        private System.Windows.Forms.Label lElement1;
    }
}
