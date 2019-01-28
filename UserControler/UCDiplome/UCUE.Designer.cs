namespace dotnet
{
    partial class UCUE
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
            this.gbCours = new System.Windows.Forms.GroupBox();
            this.gbAjout = new System.Windows.Forms.GroupBox();
            this.bCreerCours = new System.Windows.Forms.Button();
            this.lNomCours = new System.Windows.Forms.Label();
            this.tbCours = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPersonnelLibre = new System.Windows.Forms.GroupBox();
            this.lType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.gbAjout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCours
            // 
            this.gbCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCours.Location = new System.Drawing.Point(69, 153);
            this.gbCours.Name = "gbCours";
            this.gbCours.Size = new System.Drawing.Size(535, 382);
            this.gbCours.TabIndex = 14;
            this.gbCours.TabStop = false;
            this.gbCours.Text = "Cours : ";
            // 
            // gbAjout
            // 
            this.gbAjout.Controls.Add(this.tbType);
            this.gbAjout.Controls.Add(this.tbCours);
            this.gbAjout.Controls.Add(this.lType);
            this.gbAjout.Controls.Add(this.bCreerCours);
            this.gbAjout.Controls.Add(this.lNomCours);
            this.gbAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjout.Location = new System.Drawing.Point(69, 25);
            this.gbAjout.Name = "gbAjout";
            this.gbAjout.Size = new System.Drawing.Size(535, 100);
            this.gbAjout.TabIndex = 13;
            this.gbAjout.TabStop = false;
            this.gbAjout.Text = "Ajouter un cours : ";
            // 
            // bCreerCours
            // 
            this.bCreerCours.AutoSize = true;
            this.bCreerCours.Location = new System.Drawing.Point(393, 37);
            this.bCreerCours.Name = "bCreerCours";
            this.bCreerCours.Size = new System.Drawing.Size(124, 26);
            this.bCreerCours.TabIndex = 1;
            this.bCreerCours.Text = "Créer le cours : ";
            this.bCreerCours.UseVisualStyleBackColor = true;
            // 
            // lNomCours
            // 
            this.lNomCours.AutoSize = true;
            this.lNomCours.Location = new System.Drawing.Point(6, 42);
            this.lNomCours.Name = "lNomCours";
            this.lNomCours.Size = new System.Drawing.Size(46, 16);
            this.lNomCours.TabIndex = 4;
            this.lNomCours.Text = "Nom : ";
            // 
            // tbCours
            // 
            this.tbCours.Location = new System.Drawing.Point(46, 39);
            this.tbCours.Name = "tbCours";
            this.tbCours.Size = new System.Drawing.Size(100, 22);
            this.tbCours.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPersonnelLibre);
            this.panel1.Location = new System.Drawing.Point(622, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 561);
            this.panel1.TabIndex = 15;
            // 
            // gbPersonnelLibre
            // 
            this.gbPersonnelLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonnelLibre.Location = new System.Drawing.Point(19, 25);
            this.gbPersonnelLibre.Name = "gbPersonnelLibre";
            this.gbPersonnelLibre.Size = new System.Drawing.Size(412, 510);
            this.gbPersonnelLibre.TabIndex = 0;
            this.gbPersonnelLibre.TabStop = false;
            this.gbPersonnelLibre.Text = "Personnels libres : ";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(163, 42);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(104, 16);
            this.lType.TabIndex = 6;
            this.lType.Text = "Type de cours : ";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(265, 39);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 22);
            this.tbType.TabIndex = 5;
            // 
            // UCUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCours);
            this.Controls.Add(this.gbAjout);
            this.Name = "UCUE";
            this.Size = new System.Drawing.Size(1112, 561);
            this.gbAjout.ResumeLayout(false);
            this.gbAjout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCours;
        private System.Windows.Forms.GroupBox gbAjout;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbCours;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Button bCreerCours;
        private System.Windows.Forms.Label lNomCours;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPersonnelLibre;
    }
}
