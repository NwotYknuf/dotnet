namespace dotnet
{
    partial class UC_OngletGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAjoutColonne = new System.Windows.Forms.Button();
            this.bAjoutLigne = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.flpTitre = new System.Windows.Forms.FlowLayoutPanel();
            this.lTitre1 = new System.Windows.Forms.Label();
            this.lTitre2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flpTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(71, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 524);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Catégorie";
            this.Column1.Name = "Column1";
            // 
            // bAjoutColonne
            // 
            this.bAjoutColonne.Location = new System.Drawing.Point(71, 82);
            this.bAjoutColonne.Name = "bAjoutColonne";
            this.bAjoutColonne.Size = new System.Drawing.Size(129, 23);
            this.bAjoutColonne.TabIndex = 20;
            this.bAjoutColonne.Text = "Ajouter une colonne";
            this.bAjoutColonne.UseVisualStyleBackColor = true;
            this.bAjoutColonne.Click += new System.EventHandler(this.bAjoutColonne_Click);
            // 
            // bAjoutLigne
            // 
            this.bAjoutLigne.Location = new System.Drawing.Point(224, 82);
            this.bAjoutLigne.Name = "bAjoutLigne";
            this.bAjoutLigne.Size = new System.Drawing.Size(129, 23);
            this.bAjoutLigne.TabIndex = 21;
            this.bAjoutLigne.Text = "Ajouter une ligne";
            this.bAjoutLigne.UseVisualStyleBackColor = true;
            this.bAjoutLigne.Click += new System.EventHandler(this.bAjoutLigne_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(842, 82);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(201, 23);
            this.bEnregistrer.TabIndex = 22;
            this.bEnregistrer.Text = "Enregistrer les modifications";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // flpTitre
            // 
            this.flpTitre.Controls.Add(this.lTitre1);
            this.flpTitre.Controls.Add(this.lTitre2);
            this.flpTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flpTitre.Location = new System.Drawing.Point(63, 28);
            this.flpTitre.Margin = new System.Windows.Forms.Padding(0);
            this.flpTitre.Name = "flpTitre";
            this.flpTitre.Size = new System.Drawing.Size(754, 42);
            this.flpTitre.TabIndex = 23;
            // 
            // lTitre1
            // 
            this.lTitre1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lTitre1.AutoSize = true;
            this.lTitre1.Font = new System.Drawing.Font("Heroes Legend", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(79)))), ((int)(((byte)(93)))));
            this.lTitre1.Location = new System.Drawing.Point(3, 0);
            this.lTitre1.Name = "lTitre1";
            this.lTitre1.Size = new System.Drawing.Size(118, 36);
            this.lTitre1.TabIndex = 19;
            this.lTitre1.Text = "Gestion";
            // 
            // lTitre2
            // 
            this.lTitre2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTitre2.AutoSize = true;
            this.lTitre2.Font = new System.Drawing.Font("Heroes Legend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.lTitre2.Location = new System.Drawing.Point(124, 2);
            this.lTitre2.Margin = new System.Windows.Forms.Padding(0);
            this.lTitre2.Name = "lTitre2";
            this.lTitre2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTitre2.Size = new System.Drawing.Size(553, 34);
            this.lTitre2.TabIndex = 20;
            this.lTitre2.Text = "des types de cours et catégories du personnel";
            // 
            // UC_OngletGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bAjoutLigne);
            this.Controls.Add(this.bAjoutColonne);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flpTitre);
            this.Name = "UC_OngletGestion";
            this.Size = new System.Drawing.Size(1112, 682);
            this.Load += new System.EventHandler(this.UC_OngletGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flpTitre.ResumeLayout(false);
            this.flpTitre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bAjoutColonne;
        private System.Windows.Forms.Button bAjoutLigne;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.FlowLayoutPanel flpTitre;
        private System.Windows.Forms.Label lTitre1;
        private System.Windows.Forms.Label lTitre2;
    }
}
