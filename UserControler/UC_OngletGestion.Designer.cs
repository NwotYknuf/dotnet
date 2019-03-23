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
            this.lTitre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bAjoutColonne = new System.Windows.Forms.Button();
            this.bAjoutLigne = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(66, 23);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(663, 29);
            this.lTitre.TabIndex = 18;
            this.lTitre.Text = "Gestion des types de cours et catégories de personnels";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(71, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 536);
            this.dataGridView1.TabIndex = 19;
            // 
            // bAjoutColonne
            // 
            this.bAjoutColonne.Location = new System.Drawing.Point(71, 73);
            this.bAjoutColonne.Name = "bAjoutColonne";
            this.bAjoutColonne.Size = new System.Drawing.Size(129, 23);
            this.bAjoutColonne.TabIndex = 20;
            this.bAjoutColonne.Text = "Ajouter une colonne";
            this.bAjoutColonne.UseVisualStyleBackColor = true;
            this.bAjoutColonne.Click += new System.EventHandler(this.bAjoutColonne_Click);
            // 
            // bAjoutLigne
            // 
            this.bAjoutLigne.Location = new System.Drawing.Point(224, 73);
            this.bAjoutLigne.Name = "bAjoutLigne";
            this.bAjoutLigne.Size = new System.Drawing.Size(129, 23);
            this.bAjoutLigne.TabIndex = 21;
            this.bAjoutLigne.Text = "Ajouter une ligne";
            this.bAjoutLigne.UseVisualStyleBackColor = true;
            this.bAjoutLigne.Click += new System.EventHandler(this.bAjoutLigne_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(842, 73);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(201, 23);
            this.bEnregistrer.TabIndex = 22;
            this.bEnregistrer.Text = "Enregistrer les modifications";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Catégorie";
            this.Column1.Name = "Column1";
            // 
            // UC_OngletGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bAjoutLigne);
            this.Controls.Add(this.bAjoutColonne);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lTitre);
            this.Name = "UC_OngletGestion";
            this.Size = new System.Drawing.Size(1112, 682);
            this.Load += new System.EventHandler(this.UC_OngletGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bAjoutColonne;
        private System.Windows.Forms.Button bAjoutLigne;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
