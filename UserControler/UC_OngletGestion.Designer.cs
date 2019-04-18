namespace dotnet.UserControler
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_OngletGestion));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpTitre = new System.Windows.Forms.FlowLayoutPanel();
            this.lTitre1 = new System.Windows.Forms.Label();
            this.lTitre2 = new System.Windows.Forms.Label();
            this.pBAjoutLigne = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBAjoutColonne = new System.Windows.Forms.PictureBox();
            this.pBRetraitLigne = new System.Windows.Forms.PictureBox();
            this.pBRetraitColonne = new System.Windows.Forms.PictureBox();
            this.pBEnregistrer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flpTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjoutLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjoutColonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRetraitLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRetraitColonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEnregistrer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Location = new System.Drawing.Point(71, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 484);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column0
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Column0.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column0.HeaderText = "Catégorie";
            this.Column0.Name = "Column0";
            this.Column0.Width = 108;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Heures imposées";
            this.Column1.Name = "Column1";
            this.Column1.Width = 152;
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
            // pBAjoutLigne
            // 
            this.pBAjoutLigne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBAjoutLigne.Image = ((System.Drawing.Image)(resources.GetObject("pBAjoutLigne.Image")));
            this.pBAjoutLigne.InitialImage = null;
            this.pBAjoutLigne.Location = new System.Drawing.Point(72, 586);
            this.pBAjoutLigne.Name = "pBAjoutLigne";
            this.pBAjoutLigne.Size = new System.Drawing.Size(50, 50);
            this.pBAjoutLigne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAjoutLigne.TabIndex = 24;
            this.pBAjoutLigne.TabStop = false;
            this.pBAjoutLigne.Click += new System.EventHandler(this.pBAjoutLigne_Click);
            this.pBAjoutLigne.MouseEnter += new System.EventHandler(this.pBAjoutLigne_MouseEnter);
            this.pBAjoutLigne.MouseLeave += new System.EventHandler(this.pBAjoutLigne_MouseLeave);
            // 
            // pBAjoutColonne
            // 
            this.pBAjoutColonne.BackColor = System.Drawing.SystemColors.Control;
            this.pBAjoutColonne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBAjoutColonne.Image = ((System.Drawing.Image)(resources.GetObject("pBAjoutColonne.Image")));
            this.pBAjoutColonne.InitialImage = null;
            this.pBAjoutColonne.Location = new System.Drawing.Point(1026, 96);
            this.pBAjoutColonne.Name = "pBAjoutColonne";
            this.pBAjoutColonne.Size = new System.Drawing.Size(50, 50);
            this.pBAjoutColonne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAjoutColonne.TabIndex = 25;
            this.pBAjoutColonne.TabStop = false;
            this.pBAjoutColonne.Click += new System.EventHandler(this.pBAjoutColonne_Click);
            this.pBAjoutColonne.MouseEnter += new System.EventHandler(this.pBAjoutColonne_MouseEnter);
            this.pBAjoutColonne.MouseLeave += new System.EventHandler(this.pBAjoutColonne_MouseLeave);
            // 
            // pBRetraitLigne
            // 
            this.pBRetraitLigne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBRetraitLigne.Image = ((System.Drawing.Image)(resources.GetObject("pBRetraitLigne.Image")));
            this.pBRetraitLigne.InitialImage = null;
            this.pBRetraitLigne.Location = new System.Drawing.Point(128, 586);
            this.pBRetraitLigne.Name = "pBRetraitLigne";
            this.pBRetraitLigne.Size = new System.Drawing.Size(50, 50);
            this.pBRetraitLigne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBRetraitLigne.TabIndex = 26;
            this.pBRetraitLigne.TabStop = false;
            this.pBRetraitLigne.Click += new System.EventHandler(this.pBRetraitLigne_Click);
            this.pBRetraitLigne.MouseEnter += new System.EventHandler(this.pBRetraitLigne_MouseEnter);
            this.pBRetraitLigne.MouseLeave += new System.EventHandler(this.pBRetraitLigne_MouseLeave);
            // 
            // pBRetraitColonne
            // 
            this.pBRetraitColonne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBRetraitColonne.Image = ((System.Drawing.Image)(resources.GetObject("pBRetraitColonne.Image")));
            this.pBRetraitColonne.InitialImage = null;
            this.pBRetraitColonne.Location = new System.Drawing.Point(1026, 152);
            this.pBRetraitColonne.Name = "pBRetraitColonne";
            this.pBRetraitColonne.Size = new System.Drawing.Size(50, 50);
            this.pBRetraitColonne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBRetraitColonne.TabIndex = 27;
            this.pBRetraitColonne.TabStop = false;
            this.pBRetraitColonne.Click += new System.EventHandler(this.pBRetraitColonne_Click);
            this.pBRetraitColonne.MouseEnter += new System.EventHandler(this.pBRetraitColonne_MouseEnter);
            this.pBRetraitColonne.MouseLeave += new System.EventHandler(this.pBRetraitColonne_MouseLeave);
            // 
            // pBEnregistrer
            // 
            this.pBEnregistrer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("pBEnregistrer.Image")));
            this.pBEnregistrer.InitialImage = null;
            this.pBEnregistrer.Location = new System.Drawing.Point(1026, 586);
            this.pBEnregistrer.Name = "pBEnregistrer";
            this.pBEnregistrer.Size = new System.Drawing.Size(50, 50);
            this.pBEnregistrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBEnregistrer.TabIndex = 28;
            this.pBEnregistrer.TabStop = false;
            this.pBEnregistrer.Click += new System.EventHandler(this.pBEnregistrer_Click);
            this.pBEnregistrer.MouseEnter += new System.EventHandler(this.pBEnregistrer_MouseEnter);
            this.pBEnregistrer.MouseLeave += new System.EventHandler(this.pBEnregistrer_MouseLeave);
            // 
            // UC_OngletGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBEnregistrer);
            this.Controls.Add(this.pBRetraitColonne);
            this.Controls.Add(this.pBRetraitLigne);
            this.Controls.Add(this.pBAjoutColonne);
            this.Controls.Add(this.pBAjoutLigne);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flpTitre);
            this.Name = "UC_OngletGestion";
            this.Size = new System.Drawing.Size(1112, 682);
            this.Load += new System.EventHandler(this.UC_OngletGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flpTitre.ResumeLayout(false);
            this.flpTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjoutLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjoutColonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRetraitLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRetraitColonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEnregistrer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flpTitre;
        private System.Windows.Forms.Label lTitre1;
        private System.Windows.Forms.Label lTitre2;
        protected System.Windows.Forms.PictureBox pBAjoutLigne;
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.PictureBox pBAjoutColonne;
        protected System.Windows.Forms.PictureBox pBRetraitLigne;
        protected System.Windows.Forms.PictureBox pBRetraitColonne;
        protected System.Windows.Forms.PictureBox pBEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
