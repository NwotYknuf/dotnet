﻿namespace dotnet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_OngletGestion));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.flpTitre = new System.Windows.Forms.FlowLayoutPanel();
            this.lTitre1 = new System.Windows.Forms.Label();
            this.lTitre2 = new System.Windows.Forms.Label();
            this.pBAjoutLigne = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBAjoutColonne = new System.Windows.Forms.PictureBox();
            this.pBRetraitLigne = new System.Windows.Forms.PictureBox();
            this.pBRetraitColonne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flpTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjoutLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAjoutColonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRetraitLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRetraitColonne)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(71, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 484);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Catégorie";
            this.Column1.Name = "Column1";
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(842, 52);
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
            // 
            // pBAjoutColonne
            // 
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
            // 
            // UC_OngletGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBRetraitColonne);
            this.Controls.Add(this.pBRetraitLigne);
            this.Controls.Add(this.pBAjoutColonne);
            this.Controls.Add(this.pBAjoutLigne);
            this.Controls.Add(this.bEnregistrer);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.FlowLayoutPanel flpTitre;
        private System.Windows.Forms.Label lTitre1;
        private System.Windows.Forms.Label lTitre2;
        protected System.Windows.Forms.PictureBox pBAjoutLigne;
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.PictureBox pBAjoutColonne;
        protected System.Windows.Forms.PictureBox pBRetraitLigne;
        protected System.Windows.Forms.PictureBox pBRetraitColonne;
    }
}
